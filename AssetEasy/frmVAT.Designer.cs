
namespace AssetEasy
{
    partial class frmVAT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVAT));
            this.tabDataNavigator = new Wisej.Web.TabControl();
            this.tabForm = new Wisej.Web.TabPage();
            this.button1 = new Wisej.Web.Button();
            this.txt_vat_rate = new Wisej.Web.TextBox();
            this.txt_vat_mnemoniccode = new Wisej.Web.TextBox();
            this.txt_owners_notes = new Wisej.Web.TextBox();
            this.txt_vat_description = new Wisej.Web.TextBox();
            this.txt_vat_id = new Wisej.Web.TextBox();
            this.tabList = new Wisej.Web.TabPage();
            this.dgvList = new Wisej.Web.DataGridView();
            this.dataNavigator1 = new BasicDALWisejControls.DataNavigator();
            this.tabDataNavigator.SuspendLayout();
            this.tabForm.SuspendLayout();
            this.tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDataNavigator
            // 
            this.tabDataNavigator.Controls.Add(this.tabForm);
            this.tabDataNavigator.Controls.Add(this.tabList);
            resources.ApplyResources(this.tabDataNavigator, "tabDataNavigator");
            this.tabDataNavigator.Name = "tabDataNavigator";
            this.tabDataNavigator.PageInsets = new Wisej.Web.Padding(0, 41, 2, 2);
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.button1);
            this.tabForm.Controls.Add(this.txt_vat_rate);
            this.tabForm.Controls.Add(this.txt_vat_mnemoniccode);
            this.tabForm.Controls.Add(this.txt_owners_notes);
            this.tabForm.Controls.Add(this.txt_vat_description);
            this.tabForm.Controls.Add(this.txt_vat_id);
            resources.ApplyResources(this.tabForm, "tabForm");
            this.tabForm.Name = "tabForm";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("button1.ResponsiveProfiles"))));
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_vat_rate
            // 
            this.txt_vat_rate.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            resources.ApplyResources(this.txt_vat_rate, "txt_vat_rate");
            this.txt_vat_rate.Name = "txt_vat_rate";
            // 
            // txt_vat_mnemoniccode
            // 
            this.txt_vat_mnemoniccode.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            resources.ApplyResources(this.txt_vat_mnemoniccode, "txt_vat_mnemoniccode");
            this.txt_vat_mnemoniccode.Name = "txt_vat_mnemoniccode";
            // 
            // txt_owners_notes
            // 
            this.txt_owners_notes.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            resources.ApplyResources(this.txt_owners_notes, "txt_owners_notes");
            this.txt_owners_notes.Name = "txt_owners_notes";
            // 
            // txt_vat_description
            // 
            this.txt_vat_description.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            resources.ApplyResources(this.txt_vat_description, "txt_vat_description");
            this.txt_vat_description.Name = "txt_vat_description";
            // 
            // txt_vat_id
            // 
            this.txt_vat_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            resources.ApplyResources(this.txt_vat_id, "txt_vat_id");
            this.txt_vat_id.Name = "txt_vat_id";
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.dgvList);
            resources.ApplyResources(this.tabList, "tabList");
            this.tabList.Name = "tabList";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToOrderColumns = true;
            this.dgvList.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvList.AutoSizeRowsMode = Wisej.Web.DataGridViewAutoSizeRowsMode.AllCells;
            resources.ApplyResources(this.dgvList, "dgvList");
            this.dgvList.KeepSameRowHeight = true;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Caption = "Locations";
            resources.ApplyResources(this.dataNavigator1, "dataNavigator1");
            this.dataNavigator1.FKeyEnabled = true;
            this.dataNavigator1.HeaderBackColor = System.Drawing.Color.FromName("@primary");
            this.dataNavigator1.HeaderForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.dataNavigator1.Name = "dataNavigator1";
            // 
            // frmVAT
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.tabDataNavigator);
            this.Controls.Add(this.dataNavigator1);
            this.Name = "frmVAT";
            this.Load += new System.EventHandler(this.frmVAT_Load);
            this.tabDataNavigator.ResumeLayout(false);
            this.tabForm.ResumeLayout(false);
            this.tabForm.PerformLayout();
            this.tabList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.TabControl tabDataNavigator;
        private Wisej.Web.TabPage tabForm;
        private Wisej.Web.TextBox txt_vat_mnemoniccode;
        private Wisej.Web.TextBox txt_owners_notes;
        private Wisej.Web.TextBox txt_vat_description;
        private Wisej.Web.TextBox txt_vat_id;
        private Wisej.Web.TabPage tabList;
        private Wisej.Web.DataGridView dgvList;
        private BasicDALWisejControls.DataNavigator dataNavigator1;
        private Wisej.Web.TextBox txt_vat_rate;
        private Wisej.Web.Button button1;
    }
}