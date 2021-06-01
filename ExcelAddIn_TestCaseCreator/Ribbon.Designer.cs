namespace ExcelAddIn_TestCaseCreator
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.TestCaseCreatorGroup = this.Factory.CreateRibbonGroup();
            this.CreateFactorTableButton = this.Factory.CreateRibbonButton();
            this.CreateTestCaseButton = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.TestCaseCreatorGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.TestCaseCreatorGroup);
            this.tab1.Label = "テストケース生成";
            this.tab1.Name = "tab1";
            // 
            // TestCaseCreatorGroup
            // 
            this.TestCaseCreatorGroup.Items.Add(this.CreateFactorTableButton);
            this.TestCaseCreatorGroup.Items.Add(this.CreateTestCaseButton);
            this.TestCaseCreatorGroup.Label = "生成";
            this.TestCaseCreatorGroup.Name = "TestCaseCreatorGroup";
            // 
            // CreateFactorTableButton
            // 
            this.CreateFactorTableButton.Label = "要因表を生成";
            this.CreateFactorTableButton.Name = "CreateFactorTableButton";
            this.CreateFactorTableButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CreateFactorTableButton_Click);
            // 
            // CreateTestCaseButton
            // 
            this.CreateTestCaseButton.Label = "テストケースを生成";
            this.CreateTestCaseButton.Name = "CreateTestCaseButton";
            this.CreateTestCaseButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CreateTestCaseButton_Click);
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.TestCaseCreatorGroup.ResumeLayout(false);
            this.TestCaseCreatorGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup TestCaseCreatorGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton CreateFactorTableButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton CreateTestCaseButton;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
