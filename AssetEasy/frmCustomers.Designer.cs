
namespace AssetEasy
{
    partial class frmCustomers
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
            this.txt_customers_mnemoniccode = new Wisej.Web.TextBox();
            this.txt_customers_notes = new Wisej.Web.TextBox();
            this.txt_customers_emailaddress = new Wisej.Web.TextBox();
            this.txt_customers_phonenumber = new Wisej.Web.TextBox();
            this.txt_customers_geolocation = new Wisej.Web.TextBox();
            this.txt_customers_zip = new Wisej.Web.TextBox();
            this.txt_customers_address = new Wisej.Web.TextBox();
            this.txt_customers_country = new Wisej.Web.TextBox();
            this.txt_customers_state = new Wisej.Web.TextBox();
            this.txt_customers_city = new Wisej.Web.TextBox();
            this.txt_customers_fullname = new Wisej.Web.TextBox();
            this.txt_customers_id = new Wisej.Web.TextBox();
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
            this.tabDataNavigator.Size = new System.Drawing.Size(694, 410);
            this.tabDataNavigator.TabIndex = 23;
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.txt_customers_mnemoniccode);
            this.tabForm.Controls.Add(this.txt_customers_notes);
            this.tabForm.Controls.Add(this.txt_customers_emailaddress);
            this.tabForm.Controls.Add(this.txt_customers_phonenumber);
            this.tabForm.Controls.Add(this.txt_customers_geolocation);
            this.tabForm.Controls.Add(this.txt_customers_zip);
            this.tabForm.Controls.Add(this.txt_customers_address);
            this.tabForm.Controls.Add(this.txt_customers_country);
            this.tabForm.Controls.Add(this.txt_customers_state);
            this.tabForm.Controls.Add(this.txt_customers_city);
            this.tabForm.Controls.Add(this.txt_customers_fullname);
            this.tabForm.Controls.Add(this.txt_customers_id);
            this.tabForm.Location = new System.Drawing.Point(0, 41);
            this.tabForm.Name = "tabForm";
            this.tabForm.Size = new System.Drawing.Size(692, 367);
            this.tabForm.Text = "Form View";
            // 
            // txt_customers_mnemoniccode
            // 
            this.txt_customers_mnemoniccode.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_customers_mnemoniccode.LabelText = "Mnemonic Code";
            this.txt_customers_mnemoniccode.Location = new System.Drawing.Point(413, 7);
            this.txt_customers_mnemoniccode.Name = "txt_customers_mnemoniccode";
            this.txt_customers_mnemoniccode.Size = new System.Drawing.Size(117, 38);
            this.txt_customers_mnemoniccode.TabIndex = 2;
            // 
            // txt_customers_notes
            // 
            this.txt_customers_notes.AcceptsReturn = true;
            this.txt_customers_notes.AcceptsTab = true;
            this.txt_customers_notes.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_customers_notes.LabelText = "Notes";
            this.txt_customers_notes.Location = new System.Drawing.Point(7, 233);
            this.txt_customers_notes.Multiline = true;
            this.txt_customers_notes.Name = "txt_customers_notes";
            this.txt_customers_notes.Size = new System.Drawing.Size(669, 130);
            this.txt_customers_notes.TabIndex = 11;
            // 
            // txt_customers_emailaddress
            // 
            this.txt_customers_emailaddress.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_customers_emailaddress.LabelText = "Email";
            this.txt_customers_emailaddress.Location = new System.Drawing.Point(343, 159);
            this.txt_customers_emailaddress.Name = "txt_customers_emailaddress";
            this.txt_customers_emailaddress.Size = new System.Drawing.Size(333, 38);
            this.txt_customers_emailaddress.TabIndex = 10;
            // 
            // txt_customers_phonenumber
            // 
            this.txt_customers_phonenumber.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_customers_phonenumber.LabelText = "Phone Number";
            this.txt_customers_phonenumber.Location = new System.Drawing.Point(7, 159);
            this.txt_customers_phonenumber.Name = "txt_customers_phonenumber";
            this.txt_customers_phonenumber.Size = new System.Drawing.Size(333, 38);
            this.txt_customers_phonenumber.TabIndex = 9;
            // 
            // txt_customers_geolocation
            // 
            this.txt_customers_geolocation.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_customers_geolocation.LabelText = "GeoLocation Info";
            this.txt_customers_geolocation.Location = new System.Drawing.Point(457, 108);
            this.txt_customers_geolocation.Name = "txt_customers_geolocation";
            this.txt_customers_geolocation.Size = new System.Drawing.Size(205, 38);
            this.txt_customers_geolocation.TabIndex = 8;
            // 
            // txt_customers_zip
            // 
            this.txt_customers_zip.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_customers_zip.LabelText = "ZIP code";
            this.txt_customers_zip.Location = new System.Drawing.Point(343, 58);
            this.txt_customers_zip.MaxLength = 5;
            this.txt_customers_zip.Name = "txt_customers_zip";
            this.txt_customers_zip.Size = new System.Drawing.Size(62, 38);
            this.txt_customers_zip.TabIndex = 4;
            // 
            // txt_customers_address
            // 
            this.txt_customers_address.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_customers_address.LabelText = "Address";
            this.txt_customers_address.Location = new System.Drawing.Point(7, 58);
            this.txt_customers_address.Name = "txt_customers_address";
            this.txt_customers_address.Size = new System.Drawing.Size(333, 38);
            this.txt_customers_address.TabIndex = 3;
            // 
            // txt_customers_country
            // 
            this.txt_customers_country.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_customers_country.LabelText = "Country";
            this.txt_customers_country.Location = new System.Drawing.Point(400, 108);
            this.txt_customers_country.MaxLength = 3;
            this.txt_customers_country.Name = "txt_customers_country";
            this.txt_customers_country.Size = new System.Drawing.Size(53, 38);
            this.txt_customers_country.TabIndex = 7;
            // 
            // txt_customers_state
            // 
            this.txt_customers_state.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_customers_state.LabelText = "State";
            this.txt_customers_state.Location = new System.Drawing.Point(343, 108);
            this.txt_customers_state.MaxLength = 3;
            this.txt_customers_state.Name = "txt_customers_state";
            this.txt_customers_state.Size = new System.Drawing.Size(53, 38);
            this.txt_customers_state.TabIndex = 6;
            // 
            // txt_customers_city
            // 
            this.txt_customers_city.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_customers_city.LabelText = "City";
            this.txt_customers_city.Location = new System.Drawing.Point(7, 108);
            this.txt_customers_city.Name = "txt_customers_city";
            this.txt_customers_city.Size = new System.Drawing.Size(333, 38);
            this.txt_customers_city.TabIndex = 5;
            // 
            // txt_customers_fullname
            // 
            this.txt_customers_fullname.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_customers_fullname.LabelText = "Full Name";
            this.txt_customers_fullname.Location = new System.Drawing.Point(73, 7);
            this.txt_customers_fullname.Name = "txt_customers_fullname";
            this.txt_customers_fullname.Size = new System.Drawing.Size(337, 38);
            this.txt_customers_fullname.TabIndex = 1;
            // 
            // txt_customers_id
            // 
            this.txt_customers_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_customers_id.LabelText = "Customer ID";
            this.txt_customers_id.Location = new System.Drawing.Point(7, 7);
            this.txt_customers_id.Name = "txt_customers_id";
            this.txt_customers_id.Size = new System.Drawing.Size(63, 38);
            this.txt_customers_id.TabIndex = 0;
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.dgvList);
            this.tabList.Location = new System.Drawing.Point(0, 41);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new Wisej.Web.Padding(3);
            this.tabList.Size = new System.Drawing.Size(692, 367);
            this.tabList.Text = "List View";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToOrderColumns = true;
            this.dgvList.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvList.AutoSizeRowsMode = Wisej.Web.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvList.Dock = Wisej.Web.DockStyle.Fill;
            this.dgvList.KeepSameRowHeight = true;
            this.dgvList.Location = new System.Drawing.Point(3, 3);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.Size = new System.Drawing.Size(686, 361);
            this.dgvList.TabIndex = 0;
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Caption = "Locations";
            this.dataNavigator1.Dock = Wisej.Web.DockStyle.Bottom;
            this.dataNavigator1.FKeyEnabled = true;
            this.dataNavigator1.HeaderBackColor = System.Drawing.Color.FromName("@primary");
            this.dataNavigator1.Location = new System.Drawing.Point(0, 410);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(694, 60);
            this.dataNavigator1.TabIndex = 24;
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 470);
            this.Controls.Add(this.tabDataNavigator);
            this.Controls.Add(this.dataNavigator1);
            this.Name = "frmCustomers";
            this.Text = "Customers";
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
        private Wisej.Web.TextBox txt_customers_mnemoniccode;
        private Wisej.Web.TextBox txt_customers_notes;
        private Wisej.Web.TextBox txt_customers_emailaddress;
        private Wisej.Web.TextBox txt_customers_phonenumber;
        private Wisej.Web.TextBox txt_customers_geolocation;
        private Wisej.Web.TextBox txt_customers_zip;
        private Wisej.Web.TextBox txt_customers_address;
        private Wisej.Web.TextBox txt_customers_country;
        private Wisej.Web.TextBox txt_customers_state;
        private Wisej.Web.TextBox txt_customers_city;
        private Wisej.Web.TextBox txt_customers_fullname;
        private Wisej.Web.TextBox txt_customers_id;
        private Wisej.Web.TabPage tabList;
        private Wisej.Web.DataGridView dgvList;
        private BasicDALWisejControls.DataNavigator dataNavigator1;
    }
}