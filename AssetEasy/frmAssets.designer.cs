using System;
using Wisej.Web;

namespace AssetEasy
{
    partial class frmAssets : Form
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
            Wisej.Web.ComponentTool componentTool1 = new Wisej.Web.ComponentTool();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssets));
            Wisej.Web.ComponentTool componentTool2 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool3 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool4 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool5 = new Wisej.Web.ComponentTool();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
            this.tabDataNavigator = new Wisej.Web.TabControl();
            this.tabForm = new Wisej.Web.TabPage();
            this.cmb_Asset_VATCode = new Wisej.Web.ComboBox();
            this.txt_asset_depreciationrateyear = new Wisej.Web.TextBox();
            this.txt_asset_acquisitioncost = new Wisej.Web.TextBox();
            this.dtp_asset_acquisitiondate = new Wisej.Web.DateTimePicker();
            this.txt_asset_accountingcode = new Wisej.Web.TextBox();
            this.txt_owners_name = new Wisej.Web.TextBox();
            this.txt_asset_ownerid = new BasicDALWisejControls.DbLookUpTextBox(this.components);
            this.txt_asset_serialnumber = new Wisej.Web.TextBox();
            this.txt_asset_vendorsku = new Wisej.Web.TextBox();
            this.txt_asset_partnumber = new Wisej.Web.TextBox();
            this.txt_vendors_name = new Wisej.Web.TextBox();
            this.txt_asset_vendorid = new BasicDALWisejControls.DbLookUpTextBox(this.components);
            this.txt_brandcategories_level = new Wisej.Web.TextBox();
            this.txt_brandcategories_id = new Wisej.Web.TextBox();
            this.txt_brandcategories_description = new Wisej.Web.TextBox();
            this.txt_asset_brandcategoryid = new BasicDALWisejControls.DbLookUpTextBox(this.components);
            this.txt_assetcategories_level = new Wisej.Web.TextBox();
            this.txt_assetcategories_id = new Wisej.Web.TextBox();
            this.txt_assetcategories_description = new Wisej.Web.TextBox();
            this.txt_asset_assetcategoryid = new BasicDALWisejControls.DbLookUpTextBox(this.components);
            this.cmb_asset_measureunit = new Wisej.Web.ComboBox();
            this.cmb_asset_managementmode = new Wisej.Web.ComboBox();
            this.txt_asset_mnemoniccode = new Wisej.Web.TextBox();
            this.txt_asset_description = new Wisej.Web.TextBox();
            this.txt_asset_id = new Wisej.Web.TextBox();
            this.tabList = new Wisej.Web.TabPage();
            this.dgvList = new Wisej.Web.DataGridView();
            this.tabGeoLocation = new Wisej.Web.TabPage();
            this.txt_asset_geolocationinfo = new Wisej.Web.TextBox();
            this.txt_locations_name = new Wisej.Web.TextBox();
            this.txt_asset_locationid = new BasicDALWisejControls.DbLookUpTextBox(this.components);
            this.tabNotes = new Wisej.Web.TabPage();
            this.txt_asset_notes = new Wisej.Web.Ext.TinyMCE.TinyMCE();
            this.pnlAssetInfo = new Wisej.Web.Panel();
            this.txt_pnl_assetinfo_assetid = new Wisej.Web.TextBox();
            this.txt_pnl_assetinfo_accountingcode = new Wisej.Web.TextBox();
            this.txt_pnl_assetinfo_description = new Wisej.Web.TextBox();
            this.txt_pnl_assetinfo_serialnumber = new Wisej.Web.TextBox();
            this.txt_pnl_assetinfo_mnemoniccode = new Wisej.Web.TextBox();
            this.txt_pnl_assetinfo_partnumber = new Wisej.Web.TextBox();
            this.txt_pnl_assetinfo_vendorsku = new Wisej.Web.TextBox();
            this.tabBarcodes = new Wisej.Web.TabPage();
            this.dgv_AssetBarcodes = new Wisej.Web.DataGridView();
            this.dgvc_barcode_assetid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dgvc_barcode_enabled = new Wisej.Web.DataGridViewCheckBoxColumn();
            this.dgvc_barcode_internaluse = new Wisej.Web.DataGridViewCheckBoxColumn();
            this.dgvc_barcode_barcodevalue = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dgvc_barcodetype = new Wisej.Web.DataGridViewComboBoxColumn();
            this.dgvc_barcode_qty = new Wisej.Web.DataGridViewNumericUpDownColumn();
            this.tabAttachments = new Wisej.Web.TabPage();
            this.uploadAttachment = new Wisej.Web.Upload();
            this.dgv_Attachments = new Wisej.Web.DataGridView();
            this.dgvc_attachments_id = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dgvc_attachments_parentobjecttype = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dgvc_attachments_parentobjectid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dgvc_attachments_icon = new Wisej.Web.DataGridViewImageColumn();
            this.dgvc_attachments_description = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dgvc_attachments_date = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dgvc_attachments_ranking = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dgvc_attachments_filename = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dgvc_attachments_open = new Wisej.Web.DataGridViewImageColumn();
            this.dgvc_attachments_upload = new Wisej.Web.DataGridViewImageColumn();
            this.dgvc_attachments_camera = new Wisej.Web.DataGridViewImageColumn();
            this.dgvc_attachments_uniquefilename = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dgvc_attachments_contenttype = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dgvc_attachments_notes = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dataNavigator1 = new BasicDALWisejControls.DataNavigator();
            this.tabDataNavigator.SuspendLayout();
            this.tabForm.SuspendLayout();
            this.tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.tabGeoLocation.SuspendLayout();
            this.tabNotes.SuspendLayout();
            this.pnlAssetInfo.SuspendLayout();
            this.tabBarcodes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AssetBarcodes)).BeginInit();
            this.tabAttachments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Attachments)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDataNavigator
            // 
            this.tabDataNavigator.Controls.Add(this.tabForm);
            this.tabDataNavigator.Controls.Add(this.tabList);
            this.tabDataNavigator.Controls.Add(this.tabGeoLocation);
            this.tabDataNavigator.Controls.Add(this.tabNotes);
            this.tabDataNavigator.Controls.Add(this.tabBarcodes);
            this.tabDataNavigator.Controls.Add(this.tabAttachments);
            this.tabDataNavigator.Dock = Wisej.Web.DockStyle.Fill;
            this.tabDataNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabDataNavigator.Name = "tabDataNavigator";
            this.tabDataNavigator.PageInsets = new Wisej.Web.Padding(0, 41, 2, 2);
            this.tabDataNavigator.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("tabDataNavigator.ResponsiveProfiles"))));
            this.tabDataNavigator.Size = new System.Drawing.Size(752, 436);
            this.tabDataNavigator.TabIndex = 0;
            this.tabDataNavigator.SelectedIndexChanged += new System.EventHandler(this.tabDataNavigator_SelectedIndexChanged);
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.cmb_Asset_VATCode);
            this.tabForm.Controls.Add(this.txt_asset_depreciationrateyear);
            this.tabForm.Controls.Add(this.txt_asset_acquisitioncost);
            this.tabForm.Controls.Add(this.dtp_asset_acquisitiondate);
            this.tabForm.Controls.Add(this.txt_asset_accountingcode);
            this.tabForm.Controls.Add(this.txt_owners_name);
            this.tabForm.Controls.Add(this.txt_asset_ownerid);
            this.tabForm.Controls.Add(this.txt_asset_serialnumber);
            this.tabForm.Controls.Add(this.txt_asset_vendorsku);
            this.tabForm.Controls.Add(this.txt_asset_partnumber);
            this.tabForm.Controls.Add(this.txt_vendors_name);
            this.tabForm.Controls.Add(this.txt_asset_vendorid);
            this.tabForm.Controls.Add(this.txt_brandcategories_level);
            this.tabForm.Controls.Add(this.txt_brandcategories_id);
            this.tabForm.Controls.Add(this.txt_brandcategories_description);
            this.tabForm.Controls.Add(this.txt_asset_brandcategoryid);
            this.tabForm.Controls.Add(this.txt_assetcategories_level);
            this.tabForm.Controls.Add(this.txt_assetcategories_id);
            this.tabForm.Controls.Add(this.txt_assetcategories_description);
            this.tabForm.Controls.Add(this.txt_asset_assetcategoryid);
            this.tabForm.Controls.Add(this.cmb_asset_measureunit);
            this.tabForm.Controls.Add(this.cmb_asset_managementmode);
            this.tabForm.Controls.Add(this.txt_asset_mnemoniccode);
            this.tabForm.Controls.Add(this.txt_asset_description);
            this.tabForm.Controls.Add(this.txt_asset_id);
            this.tabForm.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/window.svg";
            this.tabForm.Location = new System.Drawing.Point(0, 41);
            this.tabForm.Name = "tabForm";
            this.tabForm.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("tabForm.ResponsiveProfiles"))));
            this.tabForm.Size = new System.Drawing.Size(750, 393);
            this.tabForm.Text = "General Info";
            // 
            // cmb_Asset_VATCode
            // 
            this.cmb_Asset_VATCode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cmb_Asset_VATCode.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Asset_VATCode.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.cmb_Asset_VATCode.LabelText = "VAT Code";
            this.cmb_Asset_VATCode.Location = new System.Drawing.Point(333, 300);
            this.cmb_Asset_VATCode.Name = "cmb_Asset_VATCode";
            this.cmb_Asset_VATCode.Size = new System.Drawing.Size(222, 35);
            this.cmb_Asset_VATCode.TabIndex = 24;
            // 
            // txt_asset_depreciationrateyear
            // 
            this.txt_asset_depreciationrateyear.InputType.Max = "100";
            this.txt_asset_depreciationrateyear.InputType.Min = "0";
            this.txt_asset_depreciationrateyear.InputType.Mode = Wisej.Web.TextBoxMode.Decimal;
            this.txt_asset_depreciationrateyear.InputType.Step = 1D;
            this.txt_asset_depreciationrateyear.InputType.Type = Wisej.Web.TextBoxType.Number;
            this.txt_asset_depreciationrateyear.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_asset_depreciationrateyear.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_asset_depreciationrateyear.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_asset_depreciationrateyear.LabelText = "Depreciation Rate Year";
            this.txt_asset_depreciationrateyear.Location = new System.Drawing.Point(228, 300);
            this.txt_asset_depreciationrateyear.Margin = new Wisej.Web.Padding(0);
            this.txt_asset_depreciationrateyear.Name = "txt_asset_depreciationrateyear";
            this.txt_asset_depreciationrateyear.Size = new System.Drawing.Size(102, 35);
            this.txt_asset_depreciationrateyear.TabIndex = 23;
            // 
            // txt_asset_acquisitioncost
            // 
            this.txt_asset_acquisitioncost.InputType.Max = "9999999999";
            this.txt_asset_acquisitioncost.InputType.Min = "0";
            this.txt_asset_acquisitioncost.InputType.Mode = Wisej.Web.TextBoxMode.Decimal;
            this.txt_asset_acquisitioncost.InputType.Step = 1D;
            this.txt_asset_acquisitioncost.InputType.Type = Wisej.Web.TextBoxType.Number;
            this.txt_asset_acquisitioncost.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_asset_acquisitioncost.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_asset_acquisitioncost.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_asset_acquisitioncost.LabelText = "Acquisition Cost";
            this.txt_asset_acquisitioncost.Location = new System.Drawing.Point(123, 300);
            this.txt_asset_acquisitioncost.Margin = new Wisej.Web.Padding(0);
            this.txt_asset_acquisitioncost.Name = "txt_asset_acquisitioncost";
            this.txt_asset_acquisitioncost.Size = new System.Drawing.Size(102, 35);
            this.txt_asset_acquisitioncost.TabIndex = 22;
            // 
            // dtp_asset_acquisitiondate
            // 
            this.dtp_asset_acquisitiondate.CustomFormat = "dd/MM/yyyy";
            this.dtp_asset_acquisitiondate.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtp_asset_acquisitiondate.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_asset_acquisitiondate.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.dtp_asset_acquisitiondate.LabelText = "Acquisition Date";
            this.dtp_asset_acquisitiondate.Location = new System.Drawing.Point(8, 300);
            this.dtp_asset_acquisitiondate.Name = "dtp_asset_acquisitiondate";
            this.dtp_asset_acquisitiondate.Size = new System.Drawing.Size(112, 35);
            this.dtp_asset_acquisitiondate.TabIndex = 21;
            this.dtp_asset_acquisitiondate.Value = new System.DateTime(((long)(0)));
            // 
            // txt_asset_accountingcode
            // 
            this.txt_asset_accountingcode.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_asset_accountingcode.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_asset_accountingcode.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_asset_accountingcode.LabelText = "Asset Owner Accounting Code";
            this.txt_asset_accountingcode.Location = new System.Drawing.Point(569, 56);
            this.txt_asset_accountingcode.Margin = new Wisej.Web.Padding(0);
            this.txt_asset_accountingcode.Name = "txt_asset_accountingcode";
            this.txt_asset_accountingcode.Size = new System.Drawing.Size(174, 36);
            this.txt_asset_accountingcode.TabIndex = 5;
            // 
            // txt_owners_name
            // 
            this.txt_owners_name.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_owners_name.Focusable = false;
            this.txt_owners_name.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_owners_name.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_owners_name.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_owners_name.LabelText = "Owner Name";
            this.txt_owners_name.Location = new System.Drawing.Point(165, 56);
            this.txt_owners_name.Margin = new Wisej.Web.Padding(0);
            this.txt_owners_name.Name = "txt_owners_name";
            this.txt_owners_name.ReadOnly = true;
            this.txt_owners_name.Size = new System.Drawing.Size(400, 36);
            this.txt_owners_name.TabIndex = 4;
            // 
            // txt_asset_ownerid
            // 
            this.txt_asset_ownerid.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_asset_ownerid.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_asset_ownerid.LabelText = "Owner ID";
            this.txt_asset_ownerid.Location = new System.Drawing.Point(7, 56);
            this.txt_asset_ownerid.Name = "txt_asset_ownerid";
            this.txt_asset_ownerid.Size = new System.Drawing.Size(154, 36);
            this.txt_asset_ownerid.TabIndex = 3;
            componentTool1.ImageSource = "icon-search";
            componentTool1.Name = "search";
            componentTool1.ToolTipText = "Search Owners";
            this.txt_asset_ownerid.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1});
            this.txt_asset_ownerid.ToolClick += new Wisej.Web.ToolClickEventHandler(this.txt_asset_ownerid_ToolClick);
            // 
            // txt_asset_serialnumber
            // 
            this.txt_asset_serialnumber.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_asset_serialnumber.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_asset_serialnumber.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_asset_serialnumber.LabelText = "Manufacturer Asset Serial Number";
            this.txt_asset_serialnumber.Location = new System.Drawing.Point(472, 251);
            this.txt_asset_serialnumber.Margin = new Wisej.Web.Padding(0);
            this.txt_asset_serialnumber.Name = "txt_asset_serialnumber";
            this.txt_asset_serialnumber.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txt_asset_serialnumber.ResponsiveProfiles"))));
            this.txt_asset_serialnumber.Size = new System.Drawing.Size(166, 36);
            this.txt_asset_serialnumber.TabIndex = 20;
            // 
            // txt_asset_vendorsku
            // 
            this.txt_asset_vendorsku.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_asset_vendorsku.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_asset_vendorsku.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_asset_vendorsku.LabelText = "Vendor SKU";
            this.txt_asset_vendorsku.Location = new System.Drawing.Point(569, 203);
            this.txt_asset_vendorsku.Margin = new Wisej.Web.Padding(0);
            this.txt_asset_vendorsku.Name = "txt_asset_vendorsku";
            this.txt_asset_vendorsku.Size = new System.Drawing.Size(175, 36);
            this.txt_asset_vendorsku.TabIndex = 16;
            // 
            // txt_asset_partnumber
            // 
            this.txt_asset_partnumber.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_asset_partnumber.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_asset_partnumber.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_asset_partnumber.LabelText = "Manufacturer Part Number";
            this.txt_asset_partnumber.Location = new System.Drawing.Point(303, 251);
            this.txt_asset_partnumber.Margin = new Wisej.Web.Padding(0);
            this.txt_asset_partnumber.Name = "txt_asset_partnumber";
            this.txt_asset_partnumber.Size = new System.Drawing.Size(166, 36);
            this.txt_asset_partnumber.TabIndex = 19;
            // 
            // txt_vendors_name
            // 
            this.txt_vendors_name.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_vendors_name.Focusable = false;
            this.txt_vendors_name.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_vendors_name.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_vendors_name.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_vendors_name.LabelText = "Vendor Name";
            this.txt_vendors_name.Location = new System.Drawing.Point(165, 203);
            this.txt_vendors_name.Margin = new Wisej.Web.Padding(0);
            this.txt_vendors_name.Name = "txt_vendors_name";
            this.txt_vendors_name.ReadOnly = true;
            this.txt_vendors_name.Size = new System.Drawing.Size(400, 36);
            this.txt_vendors_name.TabIndex = 15;
            // 
            // txt_asset_vendorid
            // 
            this.txt_asset_vendorid.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_asset_vendorid.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_asset_vendorid.LabelText = "Vendor ID";
            this.txt_asset_vendorid.Location = new System.Drawing.Point(7, 203);
            this.txt_asset_vendorid.Name = "txt_asset_vendorid";
            this.txt_asset_vendorid.Size = new System.Drawing.Size(154, 36);
            this.txt_asset_vendorid.TabIndex = 14;
            componentTool2.ImageSource = "icon-search";
            componentTool2.Name = "search";
            componentTool2.ToolTipText = "Search Vendors";
            this.txt_asset_vendorid.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool2});
            this.txt_asset_vendorid.ToolClick += new Wisej.Web.ToolClickEventHandler(this.txt_asset_vendorid_ToolClick);
            // 
            // txt_brandcategories_level
            // 
            this.txt_brandcategories_level.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_brandcategories_level.Focusable = false;
            this.txt_brandcategories_level.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_brandcategories_level.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_brandcategories_level.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_brandcategories_level.LabelText = "Asset Category Lev.";
            this.txt_brandcategories_level.Location = new System.Drawing.Point(654, 154);
            this.txt_brandcategories_level.Margin = new Wisej.Web.Padding(0);
            this.txt_brandcategories_level.Name = "txt_brandcategories_level";
            this.txt_brandcategories_level.ReadOnly = true;
            this.txt_brandcategories_level.Size = new System.Drawing.Size(89, 36);
            this.txt_brandcategories_level.TabIndex = 13;
            this.txt_brandcategories_level.Text = "0";
            // 
            // txt_brandcategories_id
            // 
            this.txt_brandcategories_id.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_brandcategories_id.Focusable = false;
            this.txt_brandcategories_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_brandcategories_id.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_brandcategories_id.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_brandcategories_id.LabelText = "Asset Category ID";
            this.txt_brandcategories_id.Location = new System.Drawing.Point(569, 154);
            this.txt_brandcategories_id.Margin = new Wisej.Web.Padding(0);
            this.txt_brandcategories_id.Name = "txt_brandcategories_id";
            this.txt_brandcategories_id.ReadOnly = true;
            this.txt_brandcategories_id.Size = new System.Drawing.Size(82, 36);
            this.txt_brandcategories_id.TabIndex = 12;
            // 
            // txt_brandcategories_description
            // 
            this.txt_brandcategories_description.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_brandcategories_description.Focusable = false;
            this.txt_brandcategories_description.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_brandcategories_description.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_brandcategories_description.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_brandcategories_description.LabelText = "Asset Category Description";
            this.txt_brandcategories_description.Location = new System.Drawing.Point(165, 154);
            this.txt_brandcategories_description.Margin = new Wisej.Web.Padding(0);
            this.txt_brandcategories_description.Name = "txt_brandcategories_description";
            this.txt_brandcategories_description.ReadOnly = true;
            this.txt_brandcategories_description.Size = new System.Drawing.Size(400, 36);
            this.txt_brandcategories_description.TabIndex = 11;
            // 
            // txt_asset_brandcategoryid
            // 
            this.txt_asset_brandcategoryid.CharacterCasing = Wisej.Web.CharacterCasing.Upper;
            this.txt_asset_brandcategoryid.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_asset_brandcategoryid.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_asset_brandcategoryid.LabelText = "Brand Category";
            this.txt_asset_brandcategoryid.Location = new System.Drawing.Point(7, 154);
            this.txt_asset_brandcategoryid.Name = "txt_asset_brandcategoryid";
            this.txt_asset_brandcategoryid.Size = new System.Drawing.Size(154, 36);
            this.txt_asset_brandcategoryid.TabIndex = 10;
            componentTool3.ImageSource = "icon-search";
            componentTool3.Name = "search";
            componentTool3.ToolTipText = "Search Brand Categories";
            this.txt_asset_brandcategoryid.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool3});
            this.txt_asset_brandcategoryid.ToolClick += new Wisej.Web.ToolClickEventHandler(this.txt_asset_brandcategoryid_ToolClick);
            // 
            // txt_assetcategories_level
            // 
            this.txt_assetcategories_level.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_assetcategories_level.Focusable = false;
            this.txt_assetcategories_level.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_assetcategories_level.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_assetcategories_level.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_assetcategories_level.LabelText = "Asset Category Lev.";
            this.txt_assetcategories_level.Location = new System.Drawing.Point(654, 105);
            this.txt_assetcategories_level.Margin = new Wisej.Web.Padding(0);
            this.txt_assetcategories_level.Name = "txt_assetcategories_level";
            this.txt_assetcategories_level.ReadOnly = true;
            this.txt_assetcategories_level.Size = new System.Drawing.Size(90, 36);
            this.txt_assetcategories_level.TabIndex = 9;
            this.txt_assetcategories_level.Text = "0";
            // 
            // txt_assetcategories_id
            // 
            this.txt_assetcategories_id.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_assetcategories_id.Focusable = false;
            this.txt_assetcategories_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_assetcategories_id.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_assetcategories_id.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_assetcategories_id.LabelText = "Asset Category ID";
            this.txt_assetcategories_id.Location = new System.Drawing.Point(569, 105);
            this.txt_assetcategories_id.Margin = new Wisej.Web.Padding(0);
            this.txt_assetcategories_id.Name = "txt_assetcategories_id";
            this.txt_assetcategories_id.ReadOnly = true;
            this.txt_assetcategories_id.Size = new System.Drawing.Size(82, 36);
            this.txt_assetcategories_id.TabIndex = 8;
            // 
            // txt_assetcategories_description
            // 
            this.txt_assetcategories_description.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_assetcategories_description.Focusable = false;
            this.txt_assetcategories_description.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_assetcategories_description.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_assetcategories_description.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_assetcategories_description.LabelText = "Asset Category Description";
            this.txt_assetcategories_description.Location = new System.Drawing.Point(165, 105);
            this.txt_assetcategories_description.Margin = new Wisej.Web.Padding(0);
            this.txt_assetcategories_description.Name = "txt_assetcategories_description";
            this.txt_assetcategories_description.ReadOnly = true;
            this.txt_assetcategories_description.Size = new System.Drawing.Size(400, 36);
            this.txt_assetcategories_description.TabIndex = 7;
            // 
            // txt_asset_assetcategoryid
            // 
            this.txt_asset_assetcategoryid.CharacterCasing = Wisej.Web.CharacterCasing.Upper;
            this.txt_asset_assetcategoryid.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_asset_assetcategoryid.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_asset_assetcategoryid.LabelText = "Asset Category";
            this.txt_asset_assetcategoryid.Location = new System.Drawing.Point(7, 105);
            this.txt_asset_assetcategoryid.Name = "txt_asset_assetcategoryid";
            this.txt_asset_assetcategoryid.Size = new System.Drawing.Size(154, 36);
            this.txt_asset_assetcategoryid.TabIndex = 6;
            componentTool4.ImageSource = "icon-search";
            componentTool4.Name = "search";
            componentTool4.ToolTipText = "Searcg Asset Categories";
            this.txt_asset_assetcategoryid.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool4});
            this.txt_asset_assetcategoryid.ToolClick += new Wisej.Web.ToolClickEventHandler(this.txt_asset_assetcategoryid_ToolClick);
            this.txt_asset_assetcategoryid.TextChanged += new System.EventHandler(this.txt_asset_assetcategoryid_TextChanged);
            // 
            // cmb_asset_measureunit
            // 
            this.cmb_asset_measureunit.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cmb_asset_measureunit.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_asset_measureunit.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.cmb_asset_measureunit.LabelText = "Measure Unit";
            this.cmb_asset_measureunit.Location = new System.Drawing.Point(164, 252);
            this.cmb_asset_measureunit.Name = "cmb_asset_measureunit";
            this.cmb_asset_measureunit.Size = new System.Drawing.Size(136, 35);
            this.cmb_asset_measureunit.TabIndex = 18;
            // 
            // cmb_asset_managementmode
            // 
            this.cmb_asset_managementmode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cmb_asset_managementmode.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_asset_managementmode.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.cmb_asset_managementmode.LabelText = "Management Mode";
            this.cmb_asset_managementmode.Location = new System.Drawing.Point(8, 252);
            this.cmb_asset_managementmode.Name = "cmb_asset_managementmode";
            this.cmb_asset_managementmode.Size = new System.Drawing.Size(152, 35);
            this.cmb_asset_managementmode.TabIndex = 17;
            // 
            // txt_asset_mnemoniccode
            // 
            this.txt_asset_mnemoniccode.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_asset_mnemoniccode.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_asset_mnemoniccode.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_asset_mnemoniccode.LabelText = "Mnemonic Code";
            this.txt_asset_mnemoniccode.Location = new System.Drawing.Point(568, 7);
            this.txt_asset_mnemoniccode.Margin = new Wisej.Web.Padding(0);
            this.txt_asset_mnemoniccode.Name = "txt_asset_mnemoniccode";
            this.txt_asset_mnemoniccode.Size = new System.Drawing.Size(175, 36);
            this.txt_asset_mnemoniccode.TabIndex = 2;
            // 
            // txt_asset_description
            // 
            this.txt_asset_description.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_asset_description.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_asset_description.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_asset_description.LabelText = "Asset Description";
            this.txt_asset_description.Location = new System.Drawing.Point(164, 7);
            this.txt_asset_description.Margin = new Wisej.Web.Padding(0);
            this.txt_asset_description.Name = "txt_asset_description";
            this.txt_asset_description.Size = new System.Drawing.Size(400, 36);
            this.txt_asset_description.TabIndex = 1;
            // 
            // txt_asset_id
            // 
            this.txt_asset_id.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_asset_id.Focusable = false;
            this.txt_asset_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_asset_id.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_asset_id.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_asset_id.LabelText = "Asset ID";
            this.txt_asset_id.Location = new System.Drawing.Point(7, 7);
            this.txt_asset_id.Margin = new Wisej.Web.Padding(0);
            this.txt_asset_id.Name = "txt_asset_id";
            this.txt_asset_id.Size = new System.Drawing.Size(154, 36);
            this.txt_asset_id.TabIndex = 0;
            this.txt_asset_id.TextChanged += new System.EventHandler(this.txt_asset_id_TextChanged);
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.dgvList);
            this.tabList.Hidden = true;
            this.tabList.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/list-task.svg";
            this.tabList.Location = new System.Drawing.Point(0, 41);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new Wisej.Web.Padding(3);
            this.tabList.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("tabList.ResponsiveProfiles"))));
            this.tabList.Size = new System.Drawing.Size(750, 393);
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
            this.dgvList.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("dgvList.ResponsiveProfiles"))));
            this.dgvList.Size = new System.Drawing.Size(744, 387);
            this.dgvList.TabIndex = 0;
            // 
            // tabGeoLocation
            // 
            this.tabGeoLocation.Controls.Add(this.txt_asset_geolocationinfo);
            this.tabGeoLocation.Controls.Add(this.txt_locations_name);
            this.tabGeoLocation.Controls.Add(this.txt_asset_locationid);
            this.tabGeoLocation.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/compass.svg";
            this.tabGeoLocation.Location = new System.Drawing.Point(0, 41);
            this.tabGeoLocation.Name = "tabGeoLocation";
            this.tabGeoLocation.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("tabGeoLocation.ResponsiveProfiles"))));
            this.tabGeoLocation.Size = new System.Drawing.Size(750, 393);
            this.tabGeoLocation.Text = "GeoLocation";
            // 
            // txt_asset_geolocationinfo
            // 
            this.txt_asset_geolocationinfo.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_asset_geolocationinfo.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_asset_geolocationinfo.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_asset_geolocationinfo.LabelText = "Geo Location Info";
            this.txt_asset_geolocationinfo.Location = new System.Drawing.Point(7, 161);
            this.txt_asset_geolocationinfo.Margin = new Wisej.Web.Padding(0);
            this.txt_asset_geolocationinfo.Name = "txt_asset_geolocationinfo";
            this.txt_asset_geolocationinfo.Size = new System.Drawing.Size(218, 36);
            this.txt_asset_geolocationinfo.TabIndex = 25;
            // 
            // txt_locations_name
            // 
            this.txt_locations_name.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_locations_name.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_locations_name.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_locations_name.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_locations_name.LabelText = "Location Name";
            this.txt_locations_name.Location = new System.Drawing.Point(164, 112);
            this.txt_locations_name.Margin = new Wisej.Web.Padding(0);
            this.txt_locations_name.Name = "txt_locations_name";
            this.txt_locations_name.ReadOnly = true;
            this.txt_locations_name.Size = new System.Drawing.Size(400, 36);
            this.txt_locations_name.TabIndex = 24;
            // 
            // txt_asset_locationid
            // 
            this.txt_asset_locationid.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_asset_locationid.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_asset_locationid.LabelText = "Location ID";
            this.txt_asset_locationid.Location = new System.Drawing.Point(7, 112);
            this.txt_asset_locationid.Name = "txt_asset_locationid";
            this.txt_asset_locationid.Size = new System.Drawing.Size(154, 36);
            this.txt_asset_locationid.TabIndex = 23;
            componentTool5.ImageSource = "icon-search";
            componentTool5.Name = "search";
            componentTool5.ToolTipText = "Search Vendors";
            this.txt_asset_locationid.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool5});
            this.txt_asset_locationid.ToolClick += new Wisej.Web.ToolClickEventHandler(this.txt_asset_locationid_ToolClick);
            // 
            // tabNotes
            // 
            this.tabNotes.Controls.Add(this.txt_asset_notes);
            this.tabNotes.Controls.Add(this.pnlAssetInfo);
            this.tabNotes.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/vector-pen.svg";
            this.tabNotes.Location = new System.Drawing.Point(0, 41);
            this.tabNotes.Name = "tabNotes";
            this.tabNotes.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("tabNotes.ResponsiveProfiles"))));
            this.tabNotes.Size = new System.Drawing.Size(750, 393);
            this.tabNotes.Text = "Notes";
            // 
            // txt_asset_notes
            // 
            this.txt_asset_notes.Location = new System.Drawing.Point(5, 109);
            this.txt_asset_notes.Name = "txt_asset_notes";
            this.txt_asset_notes.Size = new System.Drawing.Size(733, 281);
            this.txt_asset_notes.TabIndex = 48;
            // 
            // pnlAssetInfo
            // 
            this.pnlAssetInfo.Controls.Add(this.txt_pnl_assetinfo_assetid);
            this.pnlAssetInfo.Controls.Add(this.txt_pnl_assetinfo_accountingcode);
            this.pnlAssetInfo.Controls.Add(this.txt_pnl_assetinfo_description);
            this.pnlAssetInfo.Controls.Add(this.txt_pnl_assetinfo_serialnumber);
            this.pnlAssetInfo.Controls.Add(this.txt_pnl_assetinfo_mnemoniccode);
            this.pnlAssetInfo.Controls.Add(this.txt_pnl_assetinfo_partnumber);
            this.pnlAssetInfo.Controls.Add(this.txt_pnl_assetinfo_vendorsku);
            this.pnlAssetInfo.Dock = Wisej.Web.DockStyle.Top;
            this.pnlAssetInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlAssetInfo.Name = "pnlAssetInfo";
            this.pnlAssetInfo.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("pnlAssetInfo.ResponsiveProfiles"))));
            this.pnlAssetInfo.Size = new System.Drawing.Size(750, 103);
            this.pnlAssetInfo.TabIndex = 46;
            // 
            // txt_pnl_assetinfo_assetid
            // 
            this.txt_pnl_assetinfo_assetid.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_pnl_assetinfo_assetid.Focusable = false;
            this.txt_pnl_assetinfo_assetid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pnl_assetinfo_assetid.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pnl_assetinfo_assetid.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_pnl_assetinfo_assetid.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_pnl_assetinfo_assetid.LabelText = "Asset ID";
            this.txt_pnl_assetinfo_assetid.Location = new System.Drawing.Point(5, 4);
            this.txt_pnl_assetinfo_assetid.Margin = new Wisej.Web.Padding(0);
            this.txt_pnl_assetinfo_assetid.Name = "txt_pnl_assetinfo_assetid";
            this.txt_pnl_assetinfo_assetid.ReadOnly = true;
            this.txt_pnl_assetinfo_assetid.Size = new System.Drawing.Size(88, 36);
            this.txt_pnl_assetinfo_assetid.TabIndex = 36;
            this.txt_pnl_assetinfo_assetid.TabStop = false;
            // 
            // txt_pnl_assetinfo_accountingcode
            // 
            this.txt_pnl_assetinfo_accountingcode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_pnl_assetinfo_accountingcode.Focusable = false;
            this.txt_pnl_assetinfo_accountingcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pnl_assetinfo_accountingcode.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pnl_assetinfo_accountingcode.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_pnl_assetinfo_accountingcode.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_pnl_assetinfo_accountingcode.LabelText = "Asset Owner Accounting Code";
            this.txt_pnl_assetinfo_accountingcode.Location = new System.Drawing.Point(577, 4);
            this.txt_pnl_assetinfo_accountingcode.Margin = new Wisej.Web.Padding(0);
            this.txt_pnl_assetinfo_accountingcode.Name = "txt_pnl_assetinfo_accountingcode";
            this.txt_pnl_assetinfo_accountingcode.ReadOnly = true;
            this.txt_pnl_assetinfo_accountingcode.Size = new System.Drawing.Size(166, 36);
            this.txt_pnl_assetinfo_accountingcode.TabIndex = 44;
            this.txt_pnl_assetinfo_accountingcode.TabStop = false;
            // 
            // txt_pnl_assetinfo_description
            // 
            this.txt_pnl_assetinfo_description.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_pnl_assetinfo_description.Focusable = false;
            this.txt_pnl_assetinfo_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pnl_assetinfo_description.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pnl_assetinfo_description.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_pnl_assetinfo_description.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_pnl_assetinfo_description.LabelText = "Asset Description";
            this.txt_pnl_assetinfo_description.Location = new System.Drawing.Point(226, 4);
            this.txt_pnl_assetinfo_description.Margin = new Wisej.Web.Padding(0);
            this.txt_pnl_assetinfo_description.Name = "txt_pnl_assetinfo_description";
            this.txt_pnl_assetinfo_description.ReadOnly = true;
            this.txt_pnl_assetinfo_description.Size = new System.Drawing.Size(348, 36);
            this.txt_pnl_assetinfo_description.TabIndex = 37;
            this.txt_pnl_assetinfo_description.TabStop = false;
            // 
            // txt_pnl_assetinfo_serialnumber
            // 
            this.txt_pnl_assetinfo_serialnumber.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_pnl_assetinfo_serialnumber.Focusable = false;
            this.txt_pnl_assetinfo_serialnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pnl_assetinfo_serialnumber.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pnl_assetinfo_serialnumber.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_pnl_assetinfo_serialnumber.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_pnl_assetinfo_serialnumber.LabelText = "Manufacturer Asset Serial Number";
            this.txt_pnl_assetinfo_serialnumber.Location = new System.Drawing.Point(343, 53);
            this.txt_pnl_assetinfo_serialnumber.Margin = new Wisej.Web.Padding(0);
            this.txt_pnl_assetinfo_serialnumber.Name = "txt_pnl_assetinfo_serialnumber";
            this.txt_pnl_assetinfo_serialnumber.ReadOnly = true;
            this.txt_pnl_assetinfo_serialnumber.Size = new System.Drawing.Size(166, 36);
            this.txt_pnl_assetinfo_serialnumber.TabIndex = 39;
            this.txt_pnl_assetinfo_serialnumber.TabStop = false;
            // 
            // txt_pnl_assetinfo_mnemoniccode
            // 
            this.txt_pnl_assetinfo_mnemoniccode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_pnl_assetinfo_mnemoniccode.Focusable = false;
            this.txt_pnl_assetinfo_mnemoniccode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pnl_assetinfo_mnemoniccode.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pnl_assetinfo_mnemoniccode.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_pnl_assetinfo_mnemoniccode.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_pnl_assetinfo_mnemoniccode.LabelText = "Mnemonic Code";
            this.txt_pnl_assetinfo_mnemoniccode.Location = new System.Drawing.Point(96, 4);
            this.txt_pnl_assetinfo_mnemoniccode.Margin = new Wisej.Web.Padding(0);
            this.txt_pnl_assetinfo_mnemoniccode.Name = "txt_pnl_assetinfo_mnemoniccode";
            this.txt_pnl_assetinfo_mnemoniccode.ReadOnly = true;
            this.txt_pnl_assetinfo_mnemoniccode.Size = new System.Drawing.Size(127, 36);
            this.txt_pnl_assetinfo_mnemoniccode.TabIndex = 38;
            this.txt_pnl_assetinfo_mnemoniccode.TabStop = false;
            // 
            // txt_pnl_assetinfo_partnumber
            // 
            this.txt_pnl_assetinfo_partnumber.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_pnl_assetinfo_partnumber.Focusable = false;
            this.txt_pnl_assetinfo_partnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pnl_assetinfo_partnumber.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pnl_assetinfo_partnumber.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_pnl_assetinfo_partnumber.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_pnl_assetinfo_partnumber.LabelText = "Manufacturer Part Number";
            this.txt_pnl_assetinfo_partnumber.Location = new System.Drawing.Point(174, 53);
            this.txt_pnl_assetinfo_partnumber.Margin = new Wisej.Web.Padding(0);
            this.txt_pnl_assetinfo_partnumber.Name = "txt_pnl_assetinfo_partnumber";
            this.txt_pnl_assetinfo_partnumber.ReadOnly = true;
            this.txt_pnl_assetinfo_partnumber.Size = new System.Drawing.Size(166, 36);
            this.txt_pnl_assetinfo_partnumber.TabIndex = 40;
            this.txt_pnl_assetinfo_partnumber.TabStop = false;
            // 
            // txt_pnl_assetinfo_vendorsku
            // 
            this.txt_pnl_assetinfo_vendorsku.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_pnl_assetinfo_vendorsku.Focusable = false;
            this.txt_pnl_assetinfo_vendorsku.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pnl_assetinfo_vendorsku.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pnl_assetinfo_vendorsku.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 3);
            this.txt_pnl_assetinfo_vendorsku.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_pnl_assetinfo_vendorsku.LabelText = "Vendor SKU";
            this.txt_pnl_assetinfo_vendorsku.Location = new System.Drawing.Point(5, 53);
            this.txt_pnl_assetinfo_vendorsku.Margin = new Wisej.Web.Padding(0);
            this.txt_pnl_assetinfo_vendorsku.Name = "txt_pnl_assetinfo_vendorsku";
            this.txt_pnl_assetinfo_vendorsku.ReadOnly = true;
            this.txt_pnl_assetinfo_vendorsku.Size = new System.Drawing.Size(166, 36);
            this.txt_pnl_assetinfo_vendorsku.TabIndex = 41;
            this.txt_pnl_assetinfo_vendorsku.TabStop = false;
            // 
            // tabBarcodes
            // 
            this.tabBarcodes.Controls.Add(this.dgv_AssetBarcodes);
            this.tabBarcodes.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/upc.svg";
            this.tabBarcodes.Location = new System.Drawing.Point(0, 41);
            this.tabBarcodes.Name = "tabBarcodes";
            this.tabBarcodes.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("tabBarcodes.ResponsiveProfiles"))));
            this.tabBarcodes.Size = new System.Drawing.Size(750, 393);
            this.tabBarcodes.Text = "Barcodes";
            // 
            // dgv_AssetBarcodes
            // 
            this.dgv_AssetBarcodes.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dgv_AssetBarcodes.AutoGenerateColumns = false;
            this.dgv_AssetBarcodes.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.dgvc_barcode_assetid,
            this.dgvc_barcode_enabled,
            this.dgvc_barcode_internaluse,
            this.dgvc_barcode_barcodevalue,
            this.dgvc_barcodetype,
            this.dgvc_barcode_qty});
            this.dgv_AssetBarcodes.Location = new System.Drawing.Point(4, 113);
            this.dgv_AssetBarcodes.Name = "dgv_AssetBarcodes";
            this.dgv_AssetBarcodes.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("dgv_AssetBarcodes.ResponsiveProfiles"))));
            this.dgv_AssetBarcodes.Size = new System.Drawing.Size(738, 275);
            this.dgv_AssetBarcodes.TabIndex = 42;
            // 
            // dgvc_barcode_assetid
            // 
            this.dgvc_barcode_assetid.DataPropertyName = "assetid";
            this.dgvc_barcode_assetid.HeaderText = "Asset ID";
            this.dgvc_barcode_assetid.Name = "dgvc_barcode_assetid";
            this.dgvc_barcode_assetid.Visible = false;
            // 
            // dgvc_barcode_enabled
            // 
            this.dgvc_barcode_enabled.DataPropertyName = "enabled";
            this.dgvc_barcode_enabled.HeaderText = "Enabled";
            this.dgvc_barcode_enabled.Name = "dgvc_barcode_enabled";
            // 
            // dgvc_barcode_internaluse
            // 
            this.dgvc_barcode_internaluse.DataPropertyName = "internaluse";
            this.dgvc_barcode_internaluse.HeaderText = "Internal Use";
            this.dgvc_barcode_internaluse.Name = "dgvc_barcode_internaluse";
            // 
            // dgvc_barcode_barcodevalue
            // 
            this.dgvc_barcode_barcodevalue.DataPropertyName = "barcodevalue";
            this.dgvc_barcode_barcodevalue.HeaderText = "Barcode Value";
            this.dgvc_barcode_barcodevalue.Name = "dgvc_barcode_barcodevalue";
            this.dgvc_barcode_barcodevalue.Width = 250;
            // 
            // dgvc_barcodetype
            // 
            this.dgvc_barcodetype.DataPropertyName = "barcodetype";
            this.dgvc_barcodetype.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.dgvc_barcodetype.HeaderText = "Barcode Type";
            this.dgvc_barcodetype.Name = "dgvc_barcodetype";
            // 
            // dgvc_barcode_qty
            // 
            this.dgvc_barcode_qty.DataPropertyName = "qty";
            this.dgvc_barcode_qty.DecimalPlaces = 3;
            this.dgvc_barcode_qty.HeaderText = "Qty x Barcode";
            this.dgvc_barcode_qty.HideUpDownButtons = true;
            this.dgvc_barcode_qty.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.dgvc_barcode_qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dgvc_barcode_qty.Name = "dgvc_barcode_qty";
            // 
            // tabAttachments
            // 
            this.tabAttachments.Controls.Add(this.uploadAttachment);
            this.tabAttachments.Controls.Add(this.dgv_Attachments);
            this.tabAttachments.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/paperclip.svg";
            this.tabAttachments.Location = new System.Drawing.Point(0, 41);
            this.tabAttachments.Name = "tabAttachments";
            this.tabAttachments.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("tabAttachments.ResponsiveProfiles"))));
            this.tabAttachments.Size = new System.Drawing.Size(750, 393);
            this.tabAttachments.Text = "Attachments";
            // 
            // uploadAttachment
            // 
            this.uploadAttachment.AllowedFileTypes = "audio/*,video/*,image/*,application/*,text/*";
            this.uploadAttachment.AllowMultipleFiles = true;
            this.uploadAttachment.HideValue = true;
            this.uploadAttachment.Location = new System.Drawing.Point(524, 77);
            this.uploadAttachment.Name = "uploadAttachment";
            this.uploadAttachment.Size = new System.Drawing.Size(219, 30);
            this.uploadAttachment.TabIndex = 44;
            this.uploadAttachment.Text = "Upload Attachment";
            this.uploadAttachment.Visible = false;
            this.uploadAttachment.Uploaded += new Wisej.Web.UploadedEventHandler(this.uploadAttachment_Uploaded);
            // 
            // dgv_Attachments
            // 
            this.dgv_Attachments.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dgv_Attachments.AutoGenerateColumns = false;
            this.dgv_Attachments.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.dgvc_attachments_id,
            this.dgvc_attachments_parentobjecttype,
            this.dgvc_attachments_parentobjectid,
            this.dgvc_attachments_icon,
            this.dgvc_attachments_description,
            this.dgvc_attachments_date,
            this.dgvc_attachments_ranking,
            this.dgvc_attachments_filename,
            this.dgvc_attachments_open,
            this.dgvc_attachments_upload,
            this.dgvc_attachments_camera,
            this.dgvc_attachments_uniquefilename,
            this.dgvc_attachments_contenttype,
            this.dgvc_attachments_notes});
            this.dgv_Attachments.Location = new System.Drawing.Point(4, 113);
            this.dgv_Attachments.Name = "dgv_Attachments";
            this.dgv_Attachments.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("dgv_Attachments.ResponsiveProfiles"))));
            this.dgv_Attachments.Size = new System.Drawing.Size(743, 275);
            this.dgv_Attachments.TabIndex = 43;
            this.dgv_Attachments.CellClick += new Wisej.Web.DataGridViewCellEventHandler(this.dgv_Attachments_CellClick);
            // 
            // dgvc_attachments_id
            // 
            this.dgvc_attachments_id.DataPropertyName = "ID";
            this.dgvc_attachments_id.HeaderText = "ID";
            this.dgvc_attachments_id.Name = "dgvc_attachments_id";
            this.dgvc_attachments_id.Visible = false;
            // 
            // dgvc_attachments_parentobjecttype
            // 
            this.dgvc_attachments_parentobjecttype.DataPropertyName = "parentobjecttype";
            this.dgvc_attachments_parentobjecttype.HeaderText = "Type";
            this.dgvc_attachments_parentobjecttype.Name = "dgvc_attachments_parentobjecttype";
            this.dgvc_attachments_parentobjecttype.Visible = false;
            // 
            // dgvc_attachments_parentobjectid
            // 
            this.dgvc_attachments_parentobjectid.DataPropertyName = "parentobjectid";
            this.dgvc_attachments_parentobjectid.HeaderText = "Asset ID";
            this.dgvc_attachments_parentobjectid.Name = "dgvc_attachments_parentobjectid";
            this.dgvc_attachments_parentobjectid.Visible = false;
            // 
            // dgvc_attachments_icon
            // 
            this.dgvc_attachments_icon.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet;
            this.dgvc_attachments_icon.CellImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/list-task.svg";
            this.dgvc_attachments_icon.HeaderText = "Type";
            this.dgvc_attachments_icon.Name = "dgvc_attachments_icon";
            // 
            // dgvc_attachments_description
            // 
            this.dgvc_attachments_description.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvc_attachments_description.DataPropertyName = "description";
            this.dgvc_attachments_description.HeaderText = "Description";
            this.dgvc_attachments_description.MinimumWidth = 200;
            this.dgvc_attachments_description.Name = "dgvc_attachments_description";
            this.dgvc_attachments_description.Width = 200;
            // 
            // dgvc_attachments_date
            // 
            this.dgvc_attachments_date.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvc_attachments_date.DataPropertyName = "date";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dgvc_attachments_date.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvc_attachments_date.HeaderText = "Date";
            this.dgvc_attachments_date.Name = "dgvc_attachments_date";
            // 
            // dgvc_attachments_ranking
            // 
            this.dgvc_attachments_ranking.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvc_attachments_ranking.DataPropertyName = "ranking";
            this.dgvc_attachments_ranking.HeaderText = "Ranking";
            this.dgvc_attachments_ranking.MaxInputLength = 2;
            this.dgvc_attachments_ranking.Name = "dgvc_attachments_ranking";
            // 
            // dgvc_attachments_filename
            // 
            this.dgvc_attachments_filename.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvc_attachments_filename.DataPropertyName = "filename";
            this.dgvc_attachments_filename.HeaderText = "File Name";
            this.dgvc_attachments_filename.Name = "dgvc_attachments_filename";
            this.dgvc_attachments_filename.Visible = false;
            // 
            // dgvc_attachments_open
            // 
            this.dgvc_attachments_open.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvc_attachments_open.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet;
            this.dgvc_attachments_open.CellImageSource = "icon-search";
            this.dgvc_attachments_open.HeaderText = "Open";
            this.dgvc_attachments_open.Name = "dgvc_attachments_open";
            // 
            // dgvc_attachments_upload
            // 
            this.dgvc_attachments_upload.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvc_attachments_upload.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet;
            this.dgvc_attachments_upload.CellImageSource = "icon-upload";
            this.dgvc_attachments_upload.HeaderText = "Upload";
            this.dgvc_attachments_upload.Name = "dgvc_attachments_upload";
            // 
            // dgvc_attachments_camera
            // 
            this.dgvc_attachments_camera.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvc_attachments_camera.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet;
            this.dgvc_attachments_camera.CellImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/camera.svg";
            this.dgvc_attachments_camera.HeaderText = "Acquire";
            this.dgvc_attachments_camera.Name = "dgvc_attachments_camera";
            // 
            // dgvc_attachments_uniquefilename
            // 
            this.dgvc_attachments_uniquefilename.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvc_attachments_uniquefilename.DataPropertyName = "uniquefilename";
            this.dgvc_attachments_uniquefilename.HeaderText = "UID";
            this.dgvc_attachments_uniquefilename.Name = "dgvc_attachments_uniquefilename";
            this.dgvc_attachments_uniquefilename.Visible = false;
            // 
            // dgvc_attachments_contenttype
            // 
            this.dgvc_attachments_contenttype.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvc_attachments_contenttype.DataPropertyName = "contenttype";
            this.dgvc_attachments_contenttype.HeaderText = "Content Type";
            this.dgvc_attachments_contenttype.Name = "dgvc_attachments_contenttype";
            this.dgvc_attachments_contenttype.Visible = false;
            // 
            // dgvc_attachments_notes
            // 
            this.dgvc_attachments_notes.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvc_attachments_notes.DataPropertyName = "notes";
            this.dgvc_attachments_notes.HeaderText = "Notes";
            this.dgvc_attachments_notes.Multiline = true;
            this.dgvc_attachments_notes.Name = "dgvc_attachments_notes";
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Caption = "Assets";
            this.dataNavigator1.Dock = Wisej.Web.DockStyle.Bottom;
            this.dataNavigator1.FKeyEnabled = true;
            this.dataNavigator1.HeaderBackColor = System.Drawing.Color.FromName("@primary");
            this.dataNavigator1.HeaderForeColor = System.Drawing.Color.FromName("@highlightText");
            this.dataNavigator1.Location = new System.Drawing.Point(0, 436);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("dataNavigator1.ResponsiveProfiles"))));
            this.dataNavigator1.Size = new System.Drawing.Size(752, 61);
            this.dataNavigator1.TabIndex = 1;
            // 
            // frmAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 497);
            this.Controls.Add(this.tabDataNavigator);
            this.Controls.Add(this.dataNavigator1);
            this.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/box.svg";
            this.Name = "frmAssets";
            this.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("$this.ResponsiveProfiles"))));
            this.Text = "Assets";
            this.Load += new System.EventHandler(this.frmAssets_Load);
            this.Accelerator += new Wisej.Web.AcceleratorEventHandler(this.frmAssets_Accelerator);
            this.ResponsiveProfileChanged += new Wisej.Web.ResponsiveProfileChangedEventHandler(this.frmAssets_ResponsiveProfileChanged);
            this.tabDataNavigator.ResumeLayout(false);
            this.tabForm.ResumeLayout(false);
            this.tabForm.PerformLayout();
            this.tabList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.tabGeoLocation.ResumeLayout(false);
            this.tabGeoLocation.PerformLayout();
            this.tabNotes.ResumeLayout(false);
            this.pnlAssetInfo.ResumeLayout(false);
            this.pnlAssetInfo.PerformLayout();
            this.tabBarcodes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AssetBarcodes)).EndInit();
            this.tabAttachments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Attachments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BasicDALWisejControls.DataNavigator dataNavigator1;
        private Wisej.Web.TabControl tabDataNavigator;
        private Wisej.Web.TabPage tabForm;
        private Wisej.Web.TabPage tabList;
        private Wisej.Web.DataGridView dgvList;
        private TextBox txt_asset_description;
        private TextBox txt_asset_id;
        private TextBox txt_asset_mnemoniccode;
        private ComboBox cmb_asset_measureunit;
        private ComboBox cmb_asset_managementmode;
        private BasicDALWisejControls.DbLookUpTextBox txt_asset_assetcategoryid;
        private TextBox txt_assetcategories_description;
        private TextBox txt_assetcategories_id;
        private TextBox txt_assetcategories_level;
        private TextBox txt_brandcategories_level;
        private TextBox txt_brandcategories_id;
        private TextBox txt_brandcategories_description;
        private BasicDALWisejControls.DbLookUpTextBox txt_asset_brandcategoryid;
        private TextBox txt_vendors_name;
        private BasicDALWisejControls.DbLookUpTextBox txt_asset_vendorid;
        private TextBox txt_asset_serialnumber;
        private TextBox txt_asset_vendorsku;
        private TextBox txt_asset_partnumber;
        private TabPage tabBarcodes;
        private DataGridView dgv_AssetBarcodes;
        private DataGridViewTextBoxColumn dgvc_barcode_assetid;
        private DataGridViewCheckBoxColumn dgvc_barcode_enabled;
        private DataGridViewTextBoxColumn dgvc_barcode_barcodevalue;
        private DataGridViewCheckBoxColumn dgvc_barcode_internaluse;
        private DataGridViewNumericUpDownColumn dgvc_barcode_qty;
        private TextBox txt_owners_name;
        private BasicDALWisejControls.DbLookUpTextBox txt_asset_ownerid;
        private TextBox txt_asset_accountingcode;
        private TabPage tabNotes;
        private TabPage tabAttachments;
        private Panel pnlAssetInfo;
        private TextBox txt_pnl_assetinfo_assetid;
        private TextBox txt_pnl_assetinfo_accountingcode;
        private TextBox txt_pnl_assetinfo_description;
        private TextBox txt_pnl_assetinfo_serialnumber;
        private TextBox txt_pnl_assetinfo_mnemoniccode;
        private TextBox txt_pnl_assetinfo_partnumber;
        private TextBox txt_pnl_assetinfo_vendorsku;
        private DataGridView dgv_Attachments;
        private DataGridViewTextBoxColumn dgvc_attachments_parentobjectid;
        private TabPage tabGeoLocation;
        private TextBox txt_locations_name;
        private BasicDALWisejControls.DbLookUpTextBox txt_asset_locationid;
        private TextBox txt_asset_geolocationinfo;
        private DataGridViewTextBoxColumn dgvc_attachments_parentobjecttype;
        private DataGridViewTextBoxColumn dgvc_attachments_description;
        private DataGridViewTextBoxColumn dgvc_attachments_ranking;
        private DataGridViewTextBoxColumn dgvc_attachments_notes;
        private Upload uploadAttachment;
        private DataGridViewTextBoxColumn dgvc_attachments_filename;
        private DataGridViewImageColumn dgvc_attachments_open;
        private DataGridViewImageColumn dgvc_attachments_upload;
        private DataGridViewComboBoxColumn dgvc_barcodetype;
        private DataGridViewTextBoxColumn dgvc_attachments_uniquefilename;
        private DataGridViewTextBoxColumn dgvc_attachments_id;
        private DataGridViewTextBoxColumn dgvc_attachments_contenttype;
        private DataGridViewImageColumn dgvc_attachments_camera;
        private DataGridViewTextBoxColumn dgvc_attachments_date;
        private DataGridViewImageColumn dgvc_attachments_icon;
        private Wisej.Web.Ext.TinyMCE.TinyMCE txt_asset_notes;
        private TextBox txt_asset_depreciationrateyear;
        private TextBox txt_asset_acquisitioncost;
        private DateTimePicker dtp_asset_acquisitiondate;
        private ComboBox cmb_Asset_VATCode;
    }
}
