
namespace AssetEasy
{
    partial class frmOwners
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
            this.tabDataNavigator = new Wisej.Web.TabControl();
            this.tabForm = new Wisej.Web.TabPage();
            this.txt_owners_mnemoniccode = new Wisej.Web.TextBox();
            this.txt_owners_notes = new Wisej.Web.TextBox();
            this.txt_owners_email = new Wisej.Web.TextBox();
            this.txt_owners_phonenumber = new Wisej.Web.TextBox();
            this.txt_owners_geolocation = new Wisej.Web.TextBox();
            this.txt_owners_zip = new Wisej.Web.TextBox();
            this.txt_owners_address = new Wisej.Web.TextBox();
            this.txt_owners_country = new Wisej.Web.TextBox();
            this.txt_owners_state = new Wisej.Web.TextBox();
            this.txt_owners_city = new Wisej.Web.TextBox();
            this.txt_owners_name = new Wisej.Web.TextBox();
            this.txt_owners_id = new Wisej.Web.TextBox();
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
            this.tabDataNavigator.Dock = Wisej.Web.DockStyle.Fill;
            this.tabDataNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabDataNavigator.Name = "tabDataNavigator";
            this.tabDataNavigator.PageInsets = new Wisej.Web.Padding(0, 41, 2, 2);
            this.tabDataNavigator.Size = new System.Drawing.Size(693, 389);
            this.tabDataNavigator.TabIndex = 21;
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.txt_owners_mnemoniccode);
            this.tabForm.Controls.Add(this.txt_owners_notes);
            this.tabForm.Controls.Add(this.txt_owners_email);
            this.tabForm.Controls.Add(this.txt_owners_phonenumber);
            this.tabForm.Controls.Add(this.txt_owners_geolocation);
            this.tabForm.Controls.Add(this.txt_owners_zip);
            this.tabForm.Controls.Add(this.txt_owners_address);
            this.tabForm.Controls.Add(this.txt_owners_country);
            this.tabForm.Controls.Add(this.txt_owners_state);
            this.tabForm.Controls.Add(this.txt_owners_city);
            this.tabForm.Controls.Add(this.txt_owners_name);
            this.tabForm.Controls.Add(this.txt_owners_id);
            this.tabForm.Location = new System.Drawing.Point(0, 41);
            this.tabForm.Name = "tabForm";
            this.tabForm.Size = new System.Drawing.Size(691, 346);
            this.tabForm.Text = "Form View";
            // 
            // txt_owners_mnemoniccode
            // 
            this.txt_owners_mnemoniccode.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_owners_mnemoniccode.LabelText = "Mnemonic Code";
            this.txt_owners_mnemoniccode.Location = new System.Drawing.Point(413, 7);
            this.txt_owners_mnemoniccode.Name = "txt_owners_mnemoniccode";
            this.txt_owners_mnemoniccode.Size = new System.Drawing.Size(117, 38);
            this.txt_owners_mnemoniccode.TabIndex = 2;
            // 
            // txt_owners_notes
            // 
            this.txt_owners_notes.AcceptsReturn = true;
            this.txt_owners_notes.AcceptsTab = true;
            this.txt_owners_notes.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_owners_notes.LabelText = "Notes";
            this.txt_owners_notes.Location = new System.Drawing.Point(7, 233);
            this.txt_owners_notes.Multiline = true;
            this.txt_owners_notes.Name = "txt_owners_notes";
            this.txt_owners_notes.Size = new System.Drawing.Size(446, 92);
            this.txt_owners_notes.TabIndex = 11;
            // 
            // txt_owners_email
            // 
            this.txt_owners_email.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_owners_email.LabelText = "Email";
            this.txt_owners_email.Location = new System.Drawing.Point(343, 159);
            this.txt_owners_email.Name = "txt_owners_email";
            this.txt_owners_email.Size = new System.Drawing.Size(333, 38);
            this.txt_owners_email.TabIndex = 10;
            // 
            // txt_owners_phonenumber
            // 
            this.txt_owners_phonenumber.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_owners_phonenumber.LabelText = "Phone Number";
            this.txt_owners_phonenumber.Location = new System.Drawing.Point(7, 159);
            this.txt_owners_phonenumber.Name = "txt_owners_phonenumber";
            this.txt_owners_phonenumber.Size = new System.Drawing.Size(333, 38);
            this.txt_owners_phonenumber.TabIndex = 9;
            // 
            // txt_owners_geolocation
            // 
            this.txt_owners_geolocation.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_owners_geolocation.LabelText = "GeoLocation Info";
            this.txt_owners_geolocation.Location = new System.Drawing.Point(457, 108);
            this.txt_owners_geolocation.Name = "txt_owners_geolocation";
            this.txt_owners_geolocation.Size = new System.Drawing.Size(205, 38);
            this.txt_owners_geolocation.TabIndex = 8;
            // 
            // txt_owners_zip
            // 
            this.txt_owners_zip.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_owners_zip.LabelText = "ZIP code";
            this.txt_owners_zip.Location = new System.Drawing.Point(343, 58);
            this.txt_owners_zip.MaxLength = 5;
            this.txt_owners_zip.Name = "txt_owners_zip";
            this.txt_owners_zip.Size = new System.Drawing.Size(62, 38);
            this.txt_owners_zip.TabIndex = 4;
            // 
            // txt_owners_address
            // 
            this.txt_owners_address.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_owners_address.LabelText = "Address";
            this.txt_owners_address.Location = new System.Drawing.Point(7, 58);
            this.txt_owners_address.Name = "txt_owners_address";
            this.txt_owners_address.Size = new System.Drawing.Size(333, 38);
            this.txt_owners_address.TabIndex = 3;
            // 
            // txt_owners_country
            // 
            this.txt_owners_country.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_owners_country.LabelText = "Country";
            this.txt_owners_country.Location = new System.Drawing.Point(400, 108);
            this.txt_owners_country.MaxLength = 3;
            this.txt_owners_country.Name = "txt_owners_country";
            this.txt_owners_country.Size = new System.Drawing.Size(53, 38);
            this.txt_owners_country.TabIndex = 7;
            // 
            // txt_owners_state
            // 
            this.txt_owners_state.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_owners_state.LabelText = "State";
            this.txt_owners_state.Location = new System.Drawing.Point(343, 108);
            this.txt_owners_state.MaxLength = 3;
            this.txt_owners_state.Name = "txt_owners_state";
            this.txt_owners_state.Size = new System.Drawing.Size(53, 38);
            this.txt_owners_state.TabIndex = 6;
            // 
            // txt_owners_city
            // 
            this.txt_owners_city.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_owners_city.LabelText = "City";
            this.txt_owners_city.Location = new System.Drawing.Point(7, 108);
            this.txt_owners_city.Name = "txt_owners_city";
            this.txt_owners_city.Size = new System.Drawing.Size(333, 38);
            this.txt_owners_city.TabIndex = 5;
            // 
            // txt_owners_name
            // 
            this.txt_owners_name.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_owners_name.LabelText = "Name";
            this.txt_owners_name.Location = new System.Drawing.Point(73, 7);
            this.txt_owners_name.Name = "txt_owners_name";
            this.txt_owners_name.Size = new System.Drawing.Size(337, 38);
            this.txt_owners_name.TabIndex = 1;
            // 
            // txt_owners_id
            // 
            this.txt_owners_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_owners_id.LabelText = "Owner ID";
            this.txt_owners_id.Location = new System.Drawing.Point(7, 7);
            this.txt_owners_id.Name = "txt_owners_id";
            this.txt_owners_id.Size = new System.Drawing.Size(63, 38);
            this.txt_owners_id.TabIndex = 0;
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.dgvList);
            this.tabList.Location = new System.Drawing.Point(0, 41);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new Wisej.Web.Padding(3);
            this.tabList.Size = new System.Drawing.Size(691, 346);
            this.tabList.Text = "List View";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToOrderColumns = true;
            this.dgvList.AutoSizeRowsMode = Wisej.Web.DataGridViewAutoSizeRowsMode.DoubleClick;
            this.dgvList.Dock = Wisej.Web.DockStyle.Fill;
            this.dgvList.KeepSameRowHeight = true;
            this.dgvList.Location = new System.Drawing.Point(3, 3);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.Size = new System.Drawing.Size(685, 340);
            this.dgvList.TabIndex = 0;
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Caption = "Locations";
            this.dataNavigator1.Dock = Wisej.Web.DockStyle.Bottom;
            this.dataNavigator1.FKeyEnabled = true;
            this.dataNavigator1.HeaderBackColor = System.Drawing.Color.FromName("@primary");
            this.dataNavigator1.Location = new System.Drawing.Point(0, 389);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(693, 60);
            this.dataNavigator1.TabIndex = 22;
            // 
            // frmOwners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 449);
            this.Controls.Add(this.tabDataNavigator);
            this.Controls.Add(this.dataNavigator1);
            this.Name = "frmOwners";
            this.Text = "Owners";
            this.Load += new System.EventHandler(this.frmOwners_Load);
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
        private Wisej.Web.TextBox txt_owners_mnemoniccode;
        private Wisej.Web.TextBox txt_owners_notes;
        private Wisej.Web.TextBox txt_owners_email;
        private Wisej.Web.TextBox txt_owners_phonenumber;
        private Wisej.Web.TextBox txt_owners_geolocation;
        private Wisej.Web.TextBox txt_owners_zip;
        private Wisej.Web.TextBox txt_owners_address;
        private Wisej.Web.TextBox txt_owners_country;
        private Wisej.Web.TextBox txt_owners_state;
        private Wisej.Web.TextBox txt_owners_city;
        private Wisej.Web.TextBox txt_owners_name;
        private Wisej.Web.TextBox txt_owners_id;
        private Wisej.Web.TabPage tabList;
        private Wisej.Web.DataGridView dgvList;
        private BasicDALWisejControls.DataNavigator dataNavigator1;
    }
}