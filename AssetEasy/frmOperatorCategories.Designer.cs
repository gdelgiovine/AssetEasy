
namespace AssetEasy
{
    partial class frmOperatorCategories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Wisej.Web.ComponentTool componentTool1 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool2 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool3 = new Wisej.Web.ComponentTool();
            this.tabDataNavigator = new Wisej.Web.TabControl();
            this.tabForm = new Wisej.Web.TabPage();
            this.splitContainer1 = new Wisej.Web.SplitContainer();
            this.treeView = new Wisej.Web.TreeView();
            this.txt_Categories_Notes = new Wisej.Web.TextBox();
            this.txt_Categories_FullMnemonicCode = new Wisej.Web.TextBox();
            this.txt_NodeFullPath = new Wisej.Web.TextBox();
            this.tvc_Categories_ParentID = new Wisej.Web.TreeViewComboBox();
            this.txt_Categories_ID = new Wisej.Web.TextBox();
            this.txt_Categories_MnemonicCode = new Wisej.Web.TextBox();
            this.txt_Categories_Description = new Wisej.Web.TextBox();
            this.tabList = new Wisej.Web.TabPage();
            this.dgvList = new Wisej.Web.DataGridView();
            this.dataNavigator1 = new BasicDALWisejControls.DataNavigator();
            this.tabDataNavigator.SuspendLayout();
            this.tabForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDataNavigator
            // 
            this.tabDataNavigator.Controls.Add(this.tabForm);
            this.tabDataNavigator.Controls.Add(this.tabList);
            this.tabDataNavigator.Dock = Wisej.Web.DockStyle.Fill;
            this.tabDataNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabDataNavigator.Name = "tabDataNavigator";
            this.tabDataNavigator.PageInsets = new Wisej.Web.Padding(0, 41, 2, 2);
            this.tabDataNavigator.Size = new System.Drawing.Size(832, 420);
            this.tabDataNavigator.TabIndex = 6;
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.splitContainer1);
            this.tabForm.Location = new System.Drawing.Point(0, 41);
            this.tabForm.Name = "tabForm";
            this.tabForm.Size = new System.Drawing.Size(830, 377);
            this.tabForm.Text = "Form View";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = Wisej.Web.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView);
            this.splitContainer1.Panel1.ShowHeader = true;
            this.splitContainer1.Panel1.Text = "Operators Categories TreeView ";
            componentTool1.ImageSource = "spinner-plus";
            componentTool1.Name = "Expand";
            componentTool1.ToolTipText = "Expand All Nodes";
            componentTool2.ImageSource = "spinner-minus";
            componentTool2.Name = "Collapse";
            componentTool2.ToolTipText = "Collapse All Nodes";
            componentTool3.ImageSource = "icon-refresh";
            componentTool3.Name = "Refresh";
            componentTool3.ToolTipText = "Reload Categories";
            this.splitContainer1.Panel1.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1,
            componentTool2,
            componentTool3});
            this.splitContainer1.Panel1.ToolClick += new Wisej.Web.ToolClickEventHandler(this.splitContainer1_Panel1_ToolClick);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.txt_Categories_Notes);
            this.splitContainer1.Panel2.Controls.Add(this.txt_Categories_FullMnemonicCode);
            this.splitContainer1.Panel2.Controls.Add(this.txt_NodeFullPath);
            this.splitContainer1.Panel2.Controls.Add(this.tvc_Categories_ParentID);
            this.splitContainer1.Panel2.Controls.Add(this.txt_Categories_ID);
            this.splitContainer1.Panel2.Controls.Add(this.txt_Categories_MnemonicCode);
            this.splitContainer1.Panel2.Controls.Add(this.txt_Categories_Description);
            this.splitContainer1.Panel2.ShowHeader = true;
            this.splitContainer1.Panel2.Text = "Selected Operator Category";
            this.splitContainer1.Size = new System.Drawing.Size(830, 377);
            this.splitContainer1.SplitterDistance = 285;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.Dock = Wisej.Web.DockStyle.Fill;
            this.treeView.Font = new System.Drawing.Font("default", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(285, 349);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new Wisej.Web.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // txt_Categories_Notes
            // 
            this.txt_Categories_Notes.AcceptsReturn = true;
            this.txt_Categories_Notes.AcceptsTab = true;
            this.txt_Categories_Notes.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.txt_Categories_Notes.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Categories_Notes.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_Categories_Notes.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_Categories_Notes.LabelText = "Notes";
            this.txt_Categories_Notes.Location = new System.Drawing.Point(8, 201);
            this.txt_Categories_Notes.Margin = new Wisej.Web.Padding(0);
            this.txt_Categories_Notes.Multiline = true;
            this.txt_Categories_Notes.Name = "txt_Categories_Notes";
            this.txt_Categories_Notes.Size = new System.Drawing.Size(514, 139);
            this.txt_Categories_Notes.TabIndex = 8;
            // 
            // txt_Categories_FullMnemonicCode
            // 
            this.txt_Categories_FullMnemonicCode.BackColor = System.Drawing.Color.FromName("@controlLight");
            this.txt_Categories_FullMnemonicCode.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Categories_FullMnemonicCode.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_Categories_FullMnemonicCode.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_Categories_FullMnemonicCode.LabelText = "Full Mnemonic Code";
            this.txt_Categories_FullMnemonicCode.Location = new System.Drawing.Point(263, 152);
            this.txt_Categories_FullMnemonicCode.Margin = new Wisej.Web.Padding(0);
            this.txt_Categories_FullMnemonicCode.Name = "txt_Categories_FullMnemonicCode";
            this.txt_Categories_FullMnemonicCode.ReadOnly = true;
            this.txt_Categories_FullMnemonicCode.Size = new System.Drawing.Size(253, 35);
            this.txt_Categories_FullMnemonicCode.TabIndex = 5;
            // 
            // txt_NodeFullPath
            // 
            this.txt_NodeFullPath.BackColor = System.Drawing.Color.FromName("@controlLight");
            this.txt_NodeFullPath.Font = new System.Drawing.Font("default", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NodeFullPath.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NodeFullPath.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_NodeFullPath.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_NodeFullPath.LabelText = "Category Full Path";
            this.txt_NodeFullPath.Location = new System.Drawing.Point(8, 6);
            this.txt_NodeFullPath.Margin = new Wisej.Web.Padding(0);
            this.txt_NodeFullPath.Name = "txt_NodeFullPath";
            this.txt_NodeFullPath.ReadOnly = true;
            this.txt_NodeFullPath.Size = new System.Drawing.Size(508, 35);
            this.txt_NodeFullPath.TabIndex = 0;
            // 
            // tvc_Categories_ParentID
            // 
            this.tvc_Categories_ParentID.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tvc_Categories_ParentID.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.tvc_Categories_ParentID.LabelText = "Parent Category";
            this.tvc_Categories_ParentID.Location = new System.Drawing.Point(8, 102);
            this.tvc_Categories_ParentID.Name = "tvc_Categories_ParentID";
            this.tvc_Categories_ParentID.Size = new System.Drawing.Size(508, 35);
            this.tvc_Categories_ParentID.TabIndex = 3;
            // 
            // txt_Categories_ID
            // 
            this.txt_Categories_ID.BackColor = System.Drawing.Color.FromName("@controlLight");
            this.txt_Categories_ID.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Categories_ID.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_Categories_ID.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_Categories_ID.LabelText = "Category ID";
            this.txt_Categories_ID.Location = new System.Drawing.Point(437, 53);
            this.txt_Categories_ID.Margin = new Wisej.Web.Padding(0);
            this.txt_Categories_ID.Name = "txt_Categories_ID";
            this.txt_Categories_ID.ReadOnly = true;
            this.txt_Categories_ID.Size = new System.Drawing.Size(79, 35);
            this.txt_Categories_ID.TabIndex = 2;
            // 
            // txt_Categories_MnemonicCode
            // 
            this.txt_Categories_MnemonicCode.CharacterCasing = Wisej.Web.CharacterCasing.Upper;
            this.txt_Categories_MnemonicCode.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Categories_MnemonicCode.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_Categories_MnemonicCode.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_Categories_MnemonicCode.LabelText = "Mnemonic Code";
            this.txt_Categories_MnemonicCode.Location = new System.Drawing.Point(8, 152);
            this.txt_Categories_MnemonicCode.Margin = new Wisej.Web.Padding(0);
            this.txt_Categories_MnemonicCode.Name = "txt_Categories_MnemonicCode";
            this.txt_Categories_MnemonicCode.Size = new System.Drawing.Size(250, 35);
            this.txt_Categories_MnemonicCode.TabIndex = 4;
            // 
            // txt_Categories_Description
            // 
            this.txt_Categories_Description.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Categories_Description.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_Categories_Description.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_Categories_Description.LabelText = "Description";
            this.txt_Categories_Description.Location = new System.Drawing.Point(8, 53);
            this.txt_Categories_Description.Margin = new Wisej.Web.Padding(0);
            this.txt_Categories_Description.Name = "txt_Categories_Description";
            this.txt_Categories_Description.Size = new System.Drawing.Size(425, 35);
            this.txt_Categories_Description.TabIndex = 1;
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.dgvList);
            this.tabList.Hidden = true;
            this.tabList.Location = new System.Drawing.Point(0, 41);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new Wisej.Web.Padding(3);
            this.tabList.Size = new System.Drawing.Size(830, 377);
            this.tabList.Text = "List View";
            // 
            // dgvList
            // 
            this.dgvList.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvList.AutoSizeRowsMode = Wisej.Web.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvList.Dock = Wisej.Web.DockStyle.Fill;
            this.dgvList.KeepSameRowHeight = true;
            this.dgvList.Location = new System.Drawing.Point(3, 3);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.Size = new System.Drawing.Size(824, 371);
            this.dgvList.TabIndex = 0;
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Caption = "";
            this.dataNavigator1.Dock = Wisej.Web.DockStyle.Bottom;
            this.dataNavigator1.HeaderBackColor = System.Drawing.Color.FromName("@primary");
            this.dataNavigator1.Location = new System.Drawing.Point(0, 420);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(832, 60);
            this.dataNavigator1.TabIndex = 7;
            // 
            // frmOperatorCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 480);
            this.Controls.Add(this.tabDataNavigator);
            this.Controls.Add(this.dataNavigator1);
            this.Name = "frmOperatorCategories";
            this.Text = "frmOperatorCategories";
            this.Load += new System.EventHandler(this.frmOperatorCategories_Load);
            this.tabDataNavigator.ResumeLayout(false);
            this.tabForm.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.TabControl tabDataNavigator;
        private Wisej.Web.TabPage tabForm;
        private Wisej.Web.SplitContainer splitContainer1;
        private Wisej.Web.TreeView treeView;
        private Wisej.Web.TextBox txt_Categories_Notes;
        private Wisej.Web.TextBox txt_Categories_FullMnemonicCode;
        private Wisej.Web.TextBox txt_NodeFullPath;
        private Wisej.Web.TreeViewComboBox tvc_Categories_ParentID;
        private Wisej.Web.TextBox txt_Categories_ID;
        private Wisej.Web.TextBox txt_Categories_MnemonicCode;
        private Wisej.Web.TextBox txt_Categories_Description;
        private Wisej.Web.TabPage tabList;
        private Wisej.Web.DataGridView dgvList;
        private BasicDALWisejControls.DataNavigator dataNavigator1;
    }
}