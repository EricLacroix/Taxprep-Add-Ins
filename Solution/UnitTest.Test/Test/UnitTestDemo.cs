using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxprepAddinAPI;

namespace WKCA.UnitTest.Test
{
    [TestClass]
    public class UnitTest1
    {
        private IAppTaxApplicationService FApplication;
        private IAppClientFileManagerService FClientFileManager;

        [TestMethod]
        public void TestForTestEngine()
        {
            Assert.IsTrue(true, "true is true");
        }

        /*
        [TestMethod]
        public void FaildMethod()
        {
            Assert.IsTrue(false, "false is not true");
        }
        */

        [TestInitialize]
        public void Init()
        {
            FApplication = (IAppTaxApplicationService) TestHost.CurrentInstance.AppInstance;
            FClientFileManager = FApplication.GetClientFileManager();
        }

        [TestCleanup]
        public void CleanUp()
        {
            FClientFileManager = null;
            FApplication = null;
        }

        [TestMethod]
        public void EnumClientFiles()
        {
            var LFilesCount = FClientFileManager.GetCount();
            var LClientFiles = new List<IAppClientFile>();
            var LGuids = new List<string>();
            for (var i = 0; i < LFilesCount; ++i)
            {
                var LClientFile = FClientFileManager.GetClientFile(i);
                LClientFiles.Add(LClientFile);
                LGuids.Add(LClientFile.GetGUID());
            }
            for (var i = 0; i < LFilesCount; ++i)
            {
                LClientFiles[i].RunCalcForAllReturns();
            }
            for (var i = 0; i < LFilesCount; ++i)
            {
                Assert.AreEqual(LGuids[i], LClientFiles[i].GetGUID());
            }
        }

        [TestMethod]
        public void CellAfterCalcCycle()
        {
            var LTaxCell = FApplication.GetCurrentTaxCell();
            Assert.IsNotNull(LTaxCell, "Please open the client file and select the cell");
            var LCellPath = LTaxCell.GetCellNameWithGroup();
            FClientFileManager.GetCurrentClientFile().RunCalcForAllReturns();
            Assert.AreEqual(LCellPath, LTaxCell.GetCellNameWithGroup());
        }

        [TestMethod]
        public void RepeatByIdAfterCalcCycle()
        {
            var LTaxCell = FApplication.GetCurrentTaxCell();
            Assert.IsNotNull(LTaxCell, "Please open the client file and select the cell");
            var LRepeatID = LTaxCell.GetOwnerRepeatId();
            uint LRepeatNum;
            var LGroup = LTaxCell.GetOwnerTaxData().GetRepeatById(LRepeatID, out LRepeatNum);
            var LGroupName = LGroup.GetName(true);
            FClientFileManager.GetCurrentClientFile().RunCalcForAllReturns();
            Assert.AreEqual(LGroupName, LGroup.GetName(true));
        }

        [TestMethod]
        public void RootGroupAfterCalcCycle()
        {
            var LTaxCell = FApplication.GetCurrentTaxCell();
            Assert.IsNotNull(LTaxCell, "Please open the client file and select the cell");
            var LGroup = LTaxCell.GetOwnerTaxData().RootGroup();
            var LRepeatId = LGroup.GetRepeatId(0);
            FClientFileManager.GetCurrentClientFile().RunCalcForAllReturns();
            Assert.AreEqual(LRepeatId, LGroup.GetRepeatId(0));
        }

        [TestMethod]
        public void GroupByNameAfterCalcCycle()
        {
            var LTaxCell = FApplication.GetCurrentTaxCell();
            Assert.IsNotNull(LTaxCell, "Please open the client file and select the cell");
            var LRepeatID = LTaxCell.GetOwnerRepeatId();
            uint LRepeatNum;
            var LGroupById = LTaxCell.GetOwnerTaxData().GetRepeatById(LRepeatID, out LRepeatNum);
            Assert.IsNotNull(LGroupById, "Could not get the group by id");
            var LGroupName = LGroupById.GetName(true);
            var LGroupByName = LTaxCell.GetOwnerTaxData().GetGroupByName(LGroupName, false, false);
            Assert.IsNotNull(LGroupById, "Could not get the group by name");
            var LNamedGroupName = LGroupByName.GetName(true);
            Assert.AreEqual(LNamedGroupName, LGroupName);
            FClientFileManager.GetCurrentClientFile().RunCalcForAllReturns();
            Assert.AreEqual(LNamedGroupName, LGroupByName.GetName(true));
        }

        [TestMethod]
        public void AttachmentGroupAfterCalcCycle()
        {
            var LTaxData = FApplication.GetCurrentTaxData();
            Assert.IsNotNull(LTaxData, "Could not get the current tax data");

            var LNoteGroup = LTaxData.GetAttachmentGroup(0);
            Assert.IsNotNull(LNoteGroup, "Could not get the current note group");
            var LNoteGroupName = LNoteGroup.GetName(true);
            Assert.IsFalse(string.IsNullOrEmpty(LNoteGroupName), "Note group is null or empty");

            var LSchedulerGroup = LTaxData.GetAttachmentGroup(1);
            Assert.IsNotNull(LSchedulerGroup, "Could not get the current scheduler group");
            var LSchedulerGroupName = LSchedulerGroup.GetName(true);
            Assert.IsFalse(string.IsNullOrEmpty(LSchedulerGroupName), "Scheduler group is null or empty");

            FClientFileManager.GetCurrentClientFile().RunCalcForAllReturns();

            Assert.AreEqual(LNoteGroupName, LNoteGroup.GetName(true));
            Assert.AreEqual(LSchedulerGroupName, LSchedulerGroup.GetName(true));
        }

        [TestMethod]
        public void GroupOwnerUnitTest()
        {
            var LTaxCell = FApplication.GetCurrentTaxCell();
            Assert.IsNotNull(LTaxCell, "Please open the client file and select the cell");
            var LRepeatID = LTaxCell.GetOwnerRepeatId();
            uint LRepeatNum;
            var LGroupById = LTaxCell.GetOwnerTaxData().GetRepeatById(LRepeatID, out LRepeatNum);
            Assert.IsNotNull(LGroupById, "Could not get the group by id");

            var LOwnerGroup = LGroupById.GetOwner();
            Assert.IsNotNull(LOwnerGroup);

            var LOwnerFirstRepeatId = LOwnerGroup.GetRepeatId(0);

            FClientFileManager.GetCurrentClientFile().RunCalcForAllReturns();

            Assert.AreEqual(LOwnerFirstRepeatId, LOwnerGroup.GetRepeatId(0));
        }

        [TestMethod]
        public void GroupOwnerByRepeatIndexUnitTest()
        {
            var LTaxCell = FApplication.GetCurrentTaxCell();
            Assert.IsNotNull(LTaxCell, "Please open the client file and select the cell");
            var LRepeatID = LTaxCell.GetOwnerRepeatId();
            uint LRepeatNum;
            var LGroupById = LTaxCell.GetOwnerTaxData().GetRepeatById(LRepeatID, out LRepeatNum);
            Assert.IsNotNull(LGroupById, "Could not get the group by id");

            var LOwnerGroup = LGroupById.GetOwnerByRepeatIndex(0);
            Assert.IsNotNull(LOwnerGroup);

            var LOwnerFirstRepeatId = LOwnerGroup.GetRepeatId(0);

            FClientFileManager.GetCurrentClientFile().RunCalcForAllReturns();

            Assert.AreEqual(LOwnerFirstRepeatId, LOwnerGroup.GetRepeatId(0));
        }

        [TestMethod]
        public void GroupOwnerByRepeatIdUnitTest()
        {
            var LTaxCell = FApplication.GetCurrentTaxCell();
            Assert.IsNotNull(LTaxCell, "Please open the client file and select the cell");
            var LRepeatID = LTaxCell.GetOwnerRepeatId();
            uint LRepeatNum;
            var LGroupById = LTaxCell.GetOwnerTaxData().GetRepeatById(LRepeatID, out LRepeatNum);
            Assert.IsNotNull(LGroupById, "Could not get the group by id");

            var LOwnerGroup = LGroupById.GetOwnerByRepeatIndex(0);
            Assert.IsNotNull(LOwnerGroup);

            var LOwnerRepeatId = LOwnerGroup.GetRepeatId(0);
            var LOwnerByRepeateID = LGroupById.GetOwnerById(LOwnerRepeatId);
            Assert.IsNotNull(LOwnerByRepeateID);

            var LOwnerFirstRepeatId = LOwnerByRepeateID.GetRepeatId(0);

            FClientFileManager.GetCurrentClientFile().RunCalcForAllReturns();

            Assert.AreEqual(LOwnerFirstRepeatId, LOwnerByRepeateID.GetRepeatId(0));
        }

        [TestMethod]
        public void SubGroupAfterCalcCycle()
        {
            var LTaxCell = FApplication.GetCurrentTaxCell();
            Assert.IsNotNull(LTaxCell, "Please open the client file and select the cell");
            var LRepeatID = LTaxCell.GetOwnerRepeatId();
            uint LRepeatNum;
            var LGroupById = LTaxCell.GetOwnerTaxData().GetRepeatById(LRepeatID, out LRepeatNum);
            Assert.IsNotNull(LGroupById, "Could not get the group by id");

            var LOwnerGroup = LGroupById.GetOwnerByRepeatIndex(0);
            Assert.IsNotNull(LOwnerGroup);

            var LSubGroup = LOwnerGroup.GetSubgroup(0, 0);
            Assert.IsNotNull(LSubGroup);
            var LSubGroupName = LSubGroup.GetName(true);

            FClientFileManager.GetCurrentClientFile().RunCalcForAllReturns();

            Assert.AreEqual(LSubGroupName, LSubGroup.GetName(true));
        }
    }
}