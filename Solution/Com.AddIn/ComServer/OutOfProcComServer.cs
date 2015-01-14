/****************************** Module Header ******************************\
* Module Name:	ExeCOMServer.cs
* Project:		CSExeCOMServer
* Copyright (c) Microsoft Corporation.
* 
* ExeCOMServer encapsulates the skeleton of an out-of-process COM server in  
* C#. The class implements the singleton design pattern and it's thread-safe. 
* To start the server, call CSExeCOMServer.Instance.Run(). If the server is 
* running, the function returns directly. Inside the Run method, it registers 
* the class factories for the COM classes to be exposed from the COM server, 
* and starts the message loop to wait for the drop of lock count to zero. 
* When lock count equals zero, it revokes the registrations and quits the 
* server.
* 
* The lock count of the server is incremented when a COM object is created, 
* and it's decremented when the object is released (GC-ed). In order that the 
* COM objects can be GC-ed in time, ExeCOMServer triggers GC every 5 seconds 
* by running a Timer after the server is started.
* 
* This source is subject to the Microsoft Public License.
* See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
* All other rights reserved.
* 
* THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
* EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
* WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using System;
using System.Threading;

namespace Com.AddIn.ComServer
{
    internal sealed class OutOfProcComServer
    {
        private uint _cookieComAccessProvider;


        // The lock count (the number of active COM objects) in the server
        private int _nLockCnt;

        /// <summary>
        ///     RegisterComClasses is responsible for registering the COM class
        ///     factories for the COM classes to be exposed from the server, and
        ///     initializing the key member variables of the COM server (e.g. _nLockCnt).
        /// </summary>
        public void RegisterComClasses()
        {
            //
            // Register the COM class factories.
            //

            var clsidComAccessProvider = ComIds.CLSID_ComAccessProvider;
            var hResult = ComNative.CoRegisterClassObject(
                ref clsidComAccessProvider, // CLSID to be registered
                new ComAccessProviderClassFactory(), // Class factory
                CLSCTX.LOCAL_SERVER, // Context to run
                REGCLS.MULTIPLEUSE | REGCLS.SUSPENDED,
                out _cookieComAccessProvider);
            if (hResult != 0)
            {
                throw new ApplicationException("CoRegisterClassObject failed w/err 0x" + hResult.ToString("X"));
            }

            // Register other class objects 
            // ...

            // Inform the SCM about all the registered classes, and begins 
            // letting activation requests into the server process.
            hResult = ComNative.CoResumeClassObjects();
            if (hResult != 0)
            {
                if (_cookieComAccessProvider != 0)
                {
                    ComNative.CoRevokeClassObject(_cookieComAccessProvider);
                }

                // Revoke the registration of other classes
                // ...

                throw new ApplicationException("CoResumeClassObjects failed w/err 0x" + hResult.ToString("X"));
            }

            // Records the count of the active COM objects in the server. 
            // When _nLockCnt drops to zero, the server can be shut down.
            _nLockCnt = 0;
        }

        /// <summary>
        ///     UnRegisterComClasses is called to revoke the registration of the COM
        ///     classes exposed from the server, and perform the cleanups.
        /// </summary>
        public void UnRegisterComClasses()
        {
            /////////////////////////////////////////////////////////////////
            // Revoke the registration of the COM classes.
            // 

            // Revoke the registration of AppInstance
            if (_cookieComAccessProvider != 0)
            {
                ComNative.CoRevokeClassObject(_cookieComAccessProvider);
            }
            // Revoke the registration of other classes
            // ...
        }


        /// <summary>
        ///     Increase the lock count
        /// </summary>
        /// <returns>The new lock count after the increment</returns>
        /// <remarks>The method is thread-safe.</remarks>
        public int Lock()
        {
            return Interlocked.Increment(ref _nLockCnt);
        }

        /// <summary>
        ///     Decrease the lock count. When the lock count drops to zero, post
        ///     the WM_QUIT message to the message loop in the main thread to
        ///     shut down the COM server.
        /// </summary>
        /// <returns>The new lock count after the increment</returns>
        public int Unlock()
        {
            var nRet = Interlocked.Decrement(ref _nLockCnt);

            return nRet;
        }

        /// <summary>
        ///     Get the current lock count.
        /// </summary>
        /// <returns></returns>
        public int GetLockCount()
        {
            return _nLockCnt;
        }

        #region Singleton Pattern

        private OutOfProcComServer()
        {
        }

        public static OutOfProcComServer Instance { get; } = new OutOfProcComServer();

        #endregion
    }
}