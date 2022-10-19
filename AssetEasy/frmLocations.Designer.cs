
namespace AssetEasy
{
    partial class frmLocations
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
            this.components = new System.ComponentModel.Container();
            Wisej.Web.ComponentTool componentTool2 = new Wisej.Web.ComponentTool();
            this.tabDataNavigator = new Wisej.Web.TabControl();
            this.tabForm = new Wisej.Web.TabPage();
            this.button1 = new Wisej.Web.Button();
            this.txt_owners_name = new Wisej.Web.TextBox();
            this.txt_locations_mnemoniccode = new Wisej.Web.TextBox();
            this.txt_locations_notes = new Wisej.Web.TextBox();
            this.txt_locations_email = new Wisej.Web.TextBox();
            this.txt_locations_phonenumber = new Wisej.Web.TextBox();
            this.txt_locations_geolocation = new Wisej.Web.TextBox();
            this.txt_locations_zip = new Wisej.Web.TextBox();
            this.txt_locations_address = new Wisej.Web.TextBox();
            this.txt_locations_country = new Wisej.Web.TextBox();
            this.txt_locations_state = new Wisej.Web.TextBox();
            this.txt_locations_city = new Wisej.Web.TextBox();
            this.txt_locations_name = new Wisej.Web.TextBox();
            this.txt_locations_id = new Wisej.Web.TextBox();
            this.tabList = new Wisej.Web.TabPage();
            this.dgvList = new Wisej.Web.DataGridView();
            this.txt_asset_ownerid = new BasicDALWisejControls.DbLookUpTextBox(this.components);
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
            this.tabDataNavigator.PageInsets = new Wisej.Web.Padding(1, 40, 1, 1);
            this.tabDataNavigator.Size = new System.Drawing.Size(698, 387);
            this.tabDataNavigator.TabIndex = 0;
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.button1);
            this.tabForm.Controls.Add(this.txt_owners_name);
            this.tabForm.Controls.Add(this.txt_asset_ownerid);
            this.tabForm.Controls.Add(this.txt_locations_mnemoniccode);
            this.tabForm.Controls.Add(this.txt_locations_notes);
            this.tabForm.Controls.Add(this.txt_locations_email);
            this.tabForm.Controls.Add(this.txt_locations_phonenumber);
            this.tabForm.Controls.Add(this.txt_locations_geolocation);
            this.tabForm.Controls.Add(this.txt_locations_zip);
            this.tabForm.Controls.Add(this.txt_locations_address);
            this.tabForm.Controls.Add(this.txt_locations_country);
            this.tabForm.Controls.Add(this.txt_locations_state);
            this.tabForm.Controls.Add(this.txt_locations_city);
            this.tabForm.Controls.Add(this.txt_locations_name);
            this.tabForm.Controls.Add(this.txt_locations_id);
            this.tabForm.Location = new System.Drawing.Point(1, 40);
            this.tabForm.Name = "tabForm";
            this.tabForm.Size = new System.Drawing.Size(696, 346);
            this.tabForm.Text = "Form View";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_owners_name
            // 
            this.txt_owners_name.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_owners_name.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_owners_name.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_owners_name.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_owners_name.LabelText = "Owner Name";
            this.txt_owners_name.Location = new System.Drawing.Point(142, 58);
            this.txt_owners_name.Margin = new Wisej.Web.Padding(0);
            this.txt_owners_name.Name = "txt_owners_name";
            this.txt_owners_name.ReadOnly = true;
            this.txt_owners_name.Size = new System.Drawing.Size(388, 46);
            this.txt_owners_name.TabIndex = 13;
            // 
            // txt_locations_mnemoniccode
            // 
            this.txt_locations_mnemoniccode.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_locations_mnemoniccode.LabelText = "Mnemonic Code";
            this.txt_locations_mnemoniccode.Location = new System.Drawing.Point(413, 7);
            this.txt_locations_mnemoniccode.Name = "txt_locations_mnemoniccode";
            this.txt_locations_mnemoniccode.Size = new System.Drawing.Size(117, 48);
            this.txt_locations_mnemoniccode.TabIndex = 2;
            // 
            // txt_locations_notes
            // 
            this.txt_locations_notes.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_locations_notes.LabelText = "Notes";
            this.txt_locations_notes.Location = new System.Drawing.Point(7, 259);
            this.txt_locations_notes.Multiline = true;
            this.txt_locations_notes.Name = "txt_locations_notes";
            this.txt_locations_notes.Size = new System.Drawing.Size(684, 71);
            this.txt_locations_notes.TabIndex = 11;
            // 
            // txt_locations_email
            // 
            this.txt_locations_email.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_locations_email.LabelText = "Email";
            this.txt_locations_email.Location = new System.Drawing.Point(343, 208);
            this.txt_locations_email.Name = "txt_locations_email";
            this.txt_locations_email.Size = new System.Drawing.Size(348, 48);
            this.txt_locations_email.TabIndex = 10;
            // 
            // txt_locations_phonenumber
            // 
            this.txt_locations_phonenumber.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_locations_phonenumber.LabelText = "Phone Number";
            this.txt_locations_phonenumber.Location = new System.Drawing.Point(7, 208);
            this.txt_locations_phonenumber.Name = "txt_locations_phonenumber";
            this.txt_locations_phonenumber.Size = new System.Drawing.Size(333, 48);
            this.txt_locations_phonenumber.TabIndex = 9;
            // 
            // txt_locations_geolocation
            // 
            this.txt_locations_geolocation.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_locations_geolocation.LabelText = "GeoLocation Info";
            this.txt_locations_geolocation.Location = new System.Drawing.Point(457, 157);
            this.txt_locations_geolocation.Name = "txt_locations_geolocation";
            this.txt_locations_geolocation.Size = new System.Drawing.Size(234, 48);
            this.txt_locations_geolocation.TabIndex = 8;
            // 
            // txt_locations_zip
            // 
            this.txt_locations_zip.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_locations_zip.LabelText = "ZIP code";
            this.txt_locations_zip.Location = new System.Drawing.Point(343, 107);
            this.txt_locations_zip.MaxLength = 5;
            this.txt_locations_zip.Name = "txt_locations_zip";
            this.txt_locations_zip.Size = new System.Drawing.Size(62, 48);
            this.txt_locations_zip.TabIndex = 4;
            // 
            // txt_locations_address
            // 
            this.txt_locations_address.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_locations_address.LabelText = "Address";
            this.txt_locations_address.Location = new System.Drawing.Point(7, 107);
            this.txt_locations_address.Name = "txt_locations_address";
            this.txt_locations_address.Size = new System.Drawing.Size(333, 48);
            this.txt_locations_address.TabIndex = 3;
            // 
            // txt_locations_country
            // 
            this.txt_locations_country.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_locations_country.LabelText = "Country";
            this.txt_locations_country.Location = new System.Drawing.Point(400, 157);
            this.txt_locations_country.MaxLength = 3;
            this.txt_locations_country.Name = "txt_locations_country";
            this.txt_locations_country.Size = new System.Drawing.Size(53, 48);
            this.txt_locations_country.TabIndex = 7;
            // 
            // txt_locations_state
            // 
            this.txt_locations_state.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_locations_state.LabelText = "State";
            this.txt_locations_state.Location = new System.Drawing.Point(343, 157);
            this.txt_locations_state.MaxLength = 3;
            this.txt_locations_state.Name = "txt_locations_state";
            this.txt_locations_state.Size = new System.Drawing.Size(53, 48);
            this.txt_locations_state.TabIndex = 6;
            // 
            // txt_locations_city
            // 
            this.txt_locations_city.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_locations_city.LabelText = "City";
            this.txt_locations_city.Location = new System.Drawing.Point(7, 157);
            this.txt_locations_city.Name = "txt_locations_city";
            this.txt_locations_city.Size = new System.Drawing.Size(333, 48);
            this.txt_locations_city.TabIndex = 5;
            // 
            // txt_locations_name
            // 
            this.txt_locations_name.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_locations_name.LabelText = "Name";
            this.txt_locations_name.Location = new System.Drawing.Point(73, 7);
            this.txt_locations_name.Name = "txt_locations_name";
            this.txt_locations_name.Size = new System.Drawing.Size(337, 48);
            this.txt_locations_name.TabIndex = 1;
            // 
            // txt_locations_id
            // 
            this.txt_locations_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_locations_id.LabelText = "Location ID";
            this.txt_locations_id.Location = new System.Drawing.Point(7, 7);
            this.txt_locations_id.Name = "txt_locations_id";
            this.txt_locations_id.Size = new System.Drawing.Size(63, 48);
            this.txt_locations_id.TabIndex = 0;
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.dgvList);
            this.tabList.Location = new System.Drawing.Point(1, 40);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new Wisej.Web.Padding(3);
            this.tabList.Size = new System.Drawing.Size(696, 346);
            this.tabList.Text = "List View";
            // 
            // dgvList
            // 
            this.dgvList.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvList.Dock = Wisej.Web.DockStyle.Fill;
            this.dgvList.KeepSameRowHeight = true;
            this.dgvList.Location = new System.Drawing.Point(3, 3);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.Size = new System.Drawing.Size(690, 340);
            this.dgvList.TabIndex = 0;
            // 
            // txt_asset_ownerid
            // 
            this.txt_asset_ownerid.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_asset_ownerid.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_asset_ownerid.LabelText = "Owner ID";
            this.txt_asset_ownerid.Location = new System.Drawing.Point(7, 58);
            this.txt_asset_ownerid.Name = "txt_asset_ownerid";
            this.txt_asset_ownerid.Size = new System.Drawing.Size(132, 46);
            this.txt_asset_ownerid.TabIndex = 12;
            componentTool2.ImageSource = "icon-search";
            componentTool2.Name = "search";
            componentTool2.ToolTipText = "Search Owners";
            this.txt_asset_ownerid.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool2});
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Caption = "Locations";
            this.dataNavigator1.Dock = Wisej.Web.DockStyle.Bottom;
            this.dataNavigator1.FKeyEnabled = true;
            this.dataNavigator1.HeaderBackColor = System.Drawing.Color.FromName("@primary");
            this.dataNavigator1.Location = new System.Drawing.Point(0, 387);
            this.dataNavigator1.Margin = new Wisej.Web.Padding(0);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(698, 65);
            this.dataNavigator1.TabIndex = 20;
            // 
            // frmLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 452);
            this.Controls.Add(this.tabDataNavigator);
            this.Controls.Add(this.dataNavigator1);
            this.Name = "frmLocations";
            this.Text = " Locations";
            this.Load += new System.EventHandler(this.frmLocations_Load);
            this.Accelerator += new Wisej.Web.AcceleratorEventHandler(this.frmLocations_Accelerator);
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
        private Wisej.Web.TextBox txt_locations_country;
        private Wisej.Web.TextBox txt_locations_state;
        private Wisej.Web.TextBox txt_locations_city;
        private Wisej.Web.TextBox txt_locations_name;
        private Wisej.Web.TextBox txt_locations_id;
        private Wisej.Web.TabPage tabList;
        private Wisej.Web.DataGridView dgvList;
        private BasicDALWisejControls.DataNavigator dataNavigator1;
        private Wisej.Web.TextBox txt_locations_notes;
        private Wisej.Web.TextBox txt_locations_email;
        private Wisej.Web.TextBox txt_locations_phonenumber;
        private Wisej.Web.TextBox txt_locations_geolocation;
        private Wisej.Web.TextBox txt_locations_zip;
        private Wisej.Web.TextBox txt_locations_address;
        private Wisej.Web.TextBox txt_locations_mnemoniccode;
        private Wisej.Web.TextBox txt_owners_name;
        private BasicDALWisejControls.DbLookUpTextBox txt_asset_ownerid;
        private Wisej.Web.Button button1;
    }
}