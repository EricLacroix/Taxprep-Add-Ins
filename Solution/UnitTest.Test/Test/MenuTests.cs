using System;
using System.Media;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxprepAddinAPI;
using WKCA.AddIn.Handlers;

namespace WKCA.UnitTest.Test
{
    [TestClass]
    public class MenuTests
    {
        private const string TestCaption1 = "TestCaption1";
        private const string TestCaption2 = "TestCaption2";
        private static int SubMenuPopupCount { get; set; }
        private static int MenuItemClickCount { get; set; }

        private IAppInstance AppInstance { get; set; }
        private IAppSubMenu RootSubMenu { get; set; }

        public static void InitTestEvents(IAppSubMenu aParentSubMenu, bool aSeparatorBefore)
        {
            var lSubMenu = aParentSubMenu.AddSubMenu("Open Me", true);
            lSubMenu.PopupHandler = new AppNotifyHandler(() =>
            {
                SubMenuPopupCount++;
                SystemSounds.Beep.Play();
            });
            lSubMenu.Visible = true;
            lSubMenu.Enabled = true;

            var lMenuItem = lSubMenu.AddItem("Click Me", false);
            lMenuItem.ClickHandler = new AppNotifyHandler(() =>
            {
                MenuItemClickCount++;
                SystemSounds.Beep.Play();
            });
            lMenuItem.Visible = true;
            lMenuItem.Enabled = true;
        }

        [TestInitialize]
        public void Init()
        {
            AppInstance = TestHost.CurrentInstance.AppInstance;
            RootSubMenu = ((IAppMenuService) AppInstance).AddRootMenu("TEST_" + DateTime.Now.ToString("Hmmss"));
        }

        [TestCleanup]
        public void CleanUp()
        {
            RootSubMenu.Visible = false;
            RootSubMenu = null;
            AppInstance = null;
        }

        private void TestSubmenu(IAppSubMenu aSubMenu)
        {
            var testHandler = new AppNotifyHandler(null);

            // Test Caption
            aSubMenu.Caption = TestCaption1;
            Assert.IsTrue(aSubMenu.Caption == TestCaption1, "Cannot Set Caption");
            aSubMenu.Caption = TestCaption2;
            Assert.IsTrue(aSubMenu.Caption == TestCaption2, "Cannot Set Caption");

            // Test Enabled
            aSubMenu.Enabled = true;
            Assert.IsTrue(aSubMenu.Enabled, "Cannot Set Enabled");
            aSubMenu.Enabled = false;
            Assert.IsFalse(aSubMenu.Enabled, "Cannot Set Enabled");

            // Test Visible
            aSubMenu.Visible = true;
            Assert.IsTrue(aSubMenu.Visible, "Cannot Set Visible");
            aSubMenu.Visible = false;
            Assert.IsFalse(aSubMenu.Visible, "Cannot Set Visible");

            // Test Count, Items, AddSubMenu, AddItem
            var oldCount = aSubMenu.Count;
            var testSubMenu1 = aSubMenu.AddSubMenu(TestCaption1, true);
            Assert.IsTrue(aSubMenu.Items[oldCount++] == testSubMenu1, "Incorrect Items");
            var testSubMenu2 = aSubMenu.AddSubMenu(TestCaption2, false);
            Assert.IsTrue(aSubMenu.Items[oldCount++] == testSubMenu2, "Incorrect Items");
            var testItem1 = aSubMenu.AddItem(TestCaption1, true);
            Assert.IsTrue(aSubMenu.Items[oldCount++] == testItem1, "Incorrect Items");
            var testItem2 = aSubMenu.AddItem(TestCaption2, false);
            Assert.IsTrue(aSubMenu.Items[oldCount++] == testItem2, "Incorrect Items");
            Assert.IsTrue(aSubMenu.Count == oldCount, "Incorrect Count");

            // Test PopupHandler
            testSubMenu1.PopupHandler = testHandler;
            Assert.IsTrue(testSubMenu1.PopupHandler == testHandler, "Cannot Set PopupHandler");
            testSubMenu1.PopupHandler = null;
            Assert.IsTrue(testSubMenu1.PopupHandler == null, "Cannot Set PopupHandler");
        }

        private void TestMenuItem(IAppMenuItem aItem)
        {
            var testHandler = new AppNotifyHandler(null);

            // Test Caption
            aItem.Caption = TestCaption1;
            Assert.IsTrue(aItem.Caption == TestCaption1, "Cannot Set Caption");
            aItem.Caption = TestCaption2;
            Assert.IsTrue(aItem.Caption == TestCaption2, "Cannot Set Caption");

            // Test Enabled
            aItem.Enabled = true;
            Assert.IsTrue(aItem.Enabled, "Cannot Set Enabled");
            aItem.Enabled = false;
            Assert.IsFalse(aItem.Enabled, "Cannot Set Enabled");

            // Test Visible
            aItem.Visible = true;
            Assert.IsTrue(aItem.Visible, "Cannot Set Visible");
            aItem.Visible = false;
            Assert.IsFalse(aItem.Visible, "Cannot Set Visible");

            // Test ClickHandler
            aItem.ClickHandler = testHandler;
            Assert.IsTrue(aItem.ClickHandler == testHandler, "Cannot Set ClickHandler");
            aItem.ClickHandler = null;
            Assert.IsTrue(aItem.ClickHandler == null, "Cannot Set ClickHandler");
        }

        [TestMethod]
        public void TestRootSubMenu()
        {
            TestSubmenu(RootSubMenu);
        }

        [TestMethod]
        public void TestSubMenu()
        {
            var subMenu1 = RootSubMenu.AddSubMenu("Level 1", false);
            var subMenu2 = subMenu1.AddSubMenu("Level 2", false);
            TestSubmenu(subMenu1);
            TestSubmenu(subMenu2);

            Assert.IsTrue(SubMenuPopupCount > 0, "PopupHandler has not been executed");
        }

        [TestMethod]
        public void TestMenuItem()
        {
            var subMenu1 = RootSubMenu.AddSubMenu("Level 1", false);
            var subMenu2 = subMenu1.AddSubMenu("Level 2", false);

            var item1 = RootSubMenu.AddItem("Item 1", false);
            var item2 = subMenu1.AddItem("Item 2", false);
            var item3 = subMenu2.AddItem("Item 3", false);

            TestMenuItem(item1);
            TestMenuItem(item2);
            TestMenuItem(item3);

            Assert.IsTrue(MenuItemClickCount > 0, "ClickHandler has not been executed");
        }
    }
}