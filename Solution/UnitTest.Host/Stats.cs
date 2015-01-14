using System;
using System.Diagnostics;
using System.Text;

namespace WKCA.UnitTest.Host
{
    public class Stats
    {
        private readonly Stopwatch globalTime;
        private readonly Stopwatch localTime;

        public Stats()
        {
            globalTime = new Stopwatch();
            localTime = new Stopwatch();

            globalTime.Start();
        }

        public int GlobalFailCount { get; private set; }

        public int GlobalPassCount { get; private set; }

        public int GlobalCount { get; private set; }

        public TimeSpan GlobalTime
        {
            get { return globalTime.Elapsed; }
        }

        public TimeSpan LocalTime
        {
            get { return localTime.Elapsed; }
        }

        public void AddGlobalFailCount()
        {
            GlobalFailCount++;
        }

        public void AddGlobalPassCount()
        {
            GlobalPassCount++;
        }

        public void AddGlobalCount()
        {
            GlobalCount++;
        }

        public void StartLocalTime()
        {
            localTime.Start();
        }

        public void ResetLocalTime()
        {
            localTime.Reset();
        }

        public string GetFinalResult()
        {
            var result = new StringBuilder();
            localTime.Stop();
            globalTime.Stop();

            result.AppendFormat("{0} test(s) executed.", GlobalCount);
            result.Append(Environment.NewLine);
            result.AppendFormat("{0} passed and {1} failed.",
                GlobalPassCount,
                GlobalFailCount);
            result.Append(Environment.NewLine);
            result.AppendFormat("Total time elapsed: {0} s.",
                GlobalTime.TotalSeconds);

            return result.ToString();
        }
    }
}