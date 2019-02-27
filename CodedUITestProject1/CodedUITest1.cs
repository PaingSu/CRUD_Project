using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;


namespace CodedUITestProject1
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            #region Variable Declarations
            WinEdit uITxtNameEdit = this.UIMap.UIForm1Window.UITxtNameWindow.UITxtNameEdit;
            WinEdit uITxtNrcEdit = this.UIMap.UIForm1Window.UITxtNrcWindow.UITxtNrcEdit;
            WinEdit uITxtCityEdit = this.UIMap.UIForm1Window.UITxtCityWindow.UITxtCityEdit;
            WinButton uIInsertButton = this.UIMap.UIForm1Window.UIInsertWindow.UIInsertButton;
            WinTable uIDataGridViewTable = this.UIMap.UIForm1Window.UIDgResultWindow.UIDataGridViewTable;
            #endregion

            uITxtNameEdit.Text = "Ruby";
            uITxtNrcEdit.Text = "12/OuKaTa(N)123456";
            uITxtCityEdit.Text = "Yangon";

            Mouse.Click(uIInsertButton);

            int rowCount = uIDataGridViewTable.Rows.Count;
            WinRow lastRow = uIDataGridViewTable.Rows[rowCount - 1] as WinRow;

            Assert.AreEqual("Ruby", (lastRow.Cells[1] as WinCell).Value);
            Assert.AreEqual("12/OuKaTa(N)123456", (lastRow.Cells[2] as WinCell).Value);
            Assert.AreEqual("Yangon", (lastRow.Cells[3] as WinCell).Value);

            string data = "";
            for (int i = 0; i < uIDataGridViewTable.Rows.Count; i++)
            {
                WinRow row = uIDataGridViewTable.Rows[i] as WinRow;
                data += (row.Cells[1] as WinCell).Value+"|";
                data += (row.Cells[2] as WinCell).Value+"|";
                data += (row.Cells[3] as WinCell).Value+"|";
            }

            Assert.AreEqual("", data);
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public void MyTestInitialize()
        {        
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        }

        ////Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {        
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        }

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
