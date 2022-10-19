using System;
using System.ComponentModel;
namespace AssetEasy.DataModel
{


    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_Attachments
    // Date   :05/04/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbT_Attachments : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, true, 0);
        private BasicDAL.DbColumn _DbC_parentobjecttype = new BasicDAL.DbColumn("[ParentObjectType]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_parentobjectid = new BasicDAL.DbColumn("[ParentObjectID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_description = new BasicDAL.DbColumn("[Description]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_filename = new BasicDAL.DbColumn("[FileName]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_date = new BasicDAL.DbColumn("[Date]", System.Data.DbType.DateTime, false, DateTime.Today);
        private BasicDAL.DbColumn _DbC_ranking = new BasicDAL.DbColumn("[Ranking]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_attachment = new BasicDAL.DbColumn("[Attachment]", System.Data.DbType.Binary, false,null);
        private BasicDAL.DbColumn _DbC_contenttype = new BasicDAL.DbColumn("[ContentType]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_source = new BasicDAL.DbColumn("[Source]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_notes = new BasicDAL.DbColumn("[Notes]", System.Data.DbType.String, false, "");

        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_parentobjecttype
        {
            get { return _DbC_parentobjecttype; }
            set { _DbC_parentobjecttype = value; }
        }

        public BasicDAL.DbColumn DbC_parentobjectid
        {
            get { return _DbC_parentobjectid; }
            set { _DbC_parentobjectid = value; }
        }

        public BasicDAL.DbColumn DbC_description
        {
            get { return _DbC_description; }
            set { _DbC_description = value; }
        }

        public BasicDAL.DbColumn DbC_filename
        {
            get { return _DbC_filename; }
            set { _DbC_filename = value; }
        }

        public BasicDAL.DbColumn DbC_date
        {
            get { return _DbC_date; }
            set { _DbC_date = value; }
        }

        public BasicDAL.DbColumn DbC_ranking
        {
            get { return _DbC_ranking; }
            set { _DbC_ranking = value; }
        }

        public BasicDAL.DbColumn DbC_attachment
        {
            get { return _DbC_attachment; }
            set { _DbC_attachment = value; }
        }

        public BasicDAL.DbColumn DbC_contenttype
        {
            get { return _DbC_contenttype; }
            set { _DbC_contenttype = value; }
        }

        public BasicDAL.DbColumn DbC_source
        {
            get { return _DbC_source; }
            set { _DbC_source = value; }
        }

        public BasicDAL.DbColumn DbC_notes
        {
            get { return _DbC_notes; }
            set { _DbC_notes = value; }
        }

        #endregion

        public DbT_Attachments()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
            this.DbTableName = "Attachments";
        }
    }
    //------------------------------------------------------------------------------



    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_AssetCategories
    // Date   :21/04/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbT_AssetCategories : BasicDAL.DbObject
    {

        #region 'DbColumns'
        
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, true, 0);
        private BasicDAL.DbColumn _DbC_parentid = new BasicDAL.DbColumn("[ParentID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_mnemoniccode = new BasicDAL.DbColumn("[MnemonicCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_description = new BasicDAL.DbColumn("[Description]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_managementmode = new BasicDAL.DbColumn("[ManagementMode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_measureunitid = new BasicDAL.DbColumn("[MeasureUnitID]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_vatcode = new BasicDAL.DbColumn("[VatCode]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_notes = new BasicDAL.DbColumn("[Notes]", System.Data.DbType.String, false, "");

        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_parentid
        {
            get { return _DbC_parentid; }
            set { _DbC_parentid = value; }
        }

        public BasicDAL.DbColumn DbC_mnemoniccode
        {
            get { return _DbC_mnemoniccode; }
            set { _DbC_mnemoniccode = value; }
        }

        public BasicDAL.DbColumn DbC_description
        {
            get { return _DbC_description; }
            set { _DbC_description = value; }
        }

        public BasicDAL.DbColumn DbC_managementmode
        {
            get { return _DbC_managementmode; }
            set { _DbC_managementmode = value; }
        }

        public BasicDAL.DbColumn DbC_measureunitid
        {
            get { return _DbC_measureunitid; }
            set { _DbC_measureunitid = value; }
        }

        public BasicDAL.DbColumn DbC_vatcode
        {
            get { return _DbC_vatcode; }
            set { _DbC_vatcode = value; }
        }

        public BasicDAL.DbColumn DbC_notes
        {
            get { return _DbC_notes; }
            set { _DbC_notes = value; }
        }

        #endregion

        public DbT_AssetCategories()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
            this.DbTableName = "AssetCategories";
        }
    }
    //------------------------------------------------------------------------------



    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_Vat
    // Date   :21/04/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbT_VAT : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, true, 0);
        private BasicDAL.DbColumn _DbC_mnemoniccode = new BasicDAL.DbColumn("[MnemonicCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_description = new BasicDAL.DbColumn("[Description]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_rate = new BasicDAL.DbColumn("[Rate]", System.Data.DbType.Int16, false, 0);
        private BasicDAL.DbColumn _DbC_notes = new BasicDAL.DbColumn("[Notes]", System.Data.DbType.String, false, "");

        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_mnemoniccode
        {
            get { return _DbC_mnemoniccode; }
            set { _DbC_mnemoniccode = value; }
        }

        public BasicDAL.DbColumn DbC_description
        {
            get { return _DbC_description; }
            set { _DbC_description = value; }
        }

        public BasicDAL.DbColumn DbC_rate
        {
            get { return _DbC_rate; }
            set { _DbC_rate = value; }
        }

        public BasicDAL.DbColumn DbC_notes
        {
            get { return _DbC_notes; }
            set { _DbC_notes = value; }
        }

        #endregion

        public DbT_VAT()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
            this.DbTableName = "Vat";
        }
    }
    //------------------------------------------------------------------------------



    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_dbo_Assets
    // Date   :21/04/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbT_Assets : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, true, 0);
        private BasicDAL.DbColumn _DbC_mnemoniccode = new BasicDAL.DbColumn("[MnemonicCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_description = new BasicDAL.DbColumn("[Description]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_ownerid = new BasicDAL.DbColumn("[OwnerID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_accountingcode = new BasicDAL.DbColumn("[AccountingCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_assetcategoryid = new BasicDAL.DbColumn("[AssetCategoryID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_brandcategoryid = new BasicDAL.DbColumn("[BrandCategoryID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_vendorid = new BasicDAL.DbColumn("[VendorID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_managementmode = new BasicDAL.DbColumn("[ManagementMode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_measureunit = new BasicDAL.DbColumn("[MeasureUnit]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_serialnumber = new BasicDAL.DbColumn("[SerialNumber]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_partnumber = new BasicDAL.DbColumn("[PartNumber]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_vendorsku = new BasicDAL.DbColumn("[VendorSKU]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_notes = new BasicDAL.DbColumn("[Notes]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_locationid = new BasicDAL.DbColumn("[LocationID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_geolocationinfo = new BasicDAL.DbColumn("[GeoLocationInfo]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_acquisitiondate = new BasicDAL.DbColumn("[AcquisitionDate]", System.Data.DbType.DateTime, false, DateTime.Today);
        private BasicDAL.DbColumn _DbC_acquisitioncost = new BasicDAL.DbColumn("[AcquisitionCost]", System.Data.DbType.Decimal, false, 0);
        private BasicDAL.DbColumn _DbC_depreciationrateyear = new BasicDAL.DbColumn("[DepreciationRateYear]", System.Data.DbType.Decimal, false, 0);
        private BasicDAL.DbColumn _DbC_vatcode = new BasicDAL.DbColumn("[VatCode]", System.Data.DbType.Int32, false, 0);

        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_mnemoniccode
        {
            get { return _DbC_mnemoniccode; }
            set { _DbC_mnemoniccode = value; }
        }

        public BasicDAL.DbColumn DbC_description
        {
            get { return _DbC_description; }
            set { _DbC_description = value; }
        }

        public BasicDAL.DbColumn DbC_ownerid
        {
            get { return _DbC_ownerid; }
            set { _DbC_ownerid = value; }
        }

        public BasicDAL.DbColumn DbC_accountingcode
        {
            get { return _DbC_accountingcode; }
            set { _DbC_accountingcode = value; }
        }

        public BasicDAL.DbColumn DbC_assetcategoryid
        {
            get { return _DbC_assetcategoryid; }
            set { _DbC_assetcategoryid = value; }
        }

        public BasicDAL.DbColumn DbC_brandcategoryid
        {
            get { return _DbC_brandcategoryid; }
            set { _DbC_brandcategoryid = value; }
        }

        public BasicDAL.DbColumn DbC_vendorid
        {
            get { return _DbC_vendorid; }
            set { _DbC_vendorid = value; }
        }

        public BasicDAL.DbColumn DbC_managementmode
        {
            get { return _DbC_managementmode; }
            set { _DbC_managementmode = value; }
        }

        public BasicDAL.DbColumn DbC_measureunit
        {
            get { return _DbC_measureunit; }
            set { _DbC_measureunit = value; }
        }

        public BasicDAL.DbColumn DbC_serialnumber
        {
            get { return _DbC_serialnumber; }
            set { _DbC_serialnumber = value; }
        }

        public BasicDAL.DbColumn DbC_partnumber
        {
            get { return _DbC_partnumber; }
            set { _DbC_partnumber = value; }
        }

        public BasicDAL.DbColumn DbC_vendorsku
        {
            get { return _DbC_vendorsku; }
            set { _DbC_vendorsku = value; }
        }

        public BasicDAL.DbColumn DbC_notes
        {
            get { return _DbC_notes; }
            set { _DbC_notes = value; }
        }

        public BasicDAL.DbColumn DbC_locationid
        {
            get { return _DbC_locationid; }
            set { _DbC_locationid = value; }
        }

        public BasicDAL.DbColumn DbC_geolocationinfo
        {
            get { return _DbC_geolocationinfo; }
            set { _DbC_geolocationinfo = value; }
        }

        public BasicDAL.DbColumn DbC_acquisitiondate
        {
            get { return _DbC_acquisitiondate; }
            set { _DbC_acquisitiondate = value; }
        }

        public BasicDAL.DbColumn DbC_acquisitioncost
        {
            get { return _DbC_acquisitioncost; }
            set { _DbC_acquisitioncost = value; }
        }

        public BasicDAL.DbColumn DbC_depreciationrateyear
        {
            get { return _DbC_depreciationrateyear; }
            set { _DbC_depreciationrateyear = value; }
        }

        public BasicDAL.DbColumn DbC_vatcode
        {
            get { return _DbC_vatcode; }
            set { _DbC_vatcode = value; }
        }

        #endregion

        public DbT_Assets()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
            this.DbTableName = "Assets";
        }
    }
    //------------------------------------------------------------------------------


    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_BrandCategories
    // Date   :22/03/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbT_BrandCategories : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, true, 0);
        private BasicDAL.DbColumn _DbC_mnemoniccode = new BasicDAL.DbColumn("[MnemonicCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_parentid = new BasicDAL.DbColumn("[ParentID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_brandclassid = new BasicDAL.DbColumn("[BrandClassID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_description = new BasicDAL.DbColumn("[Description]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_notes = new BasicDAL.DbColumn("[notes]", System.Data.DbType.String, false, "");
        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_mnemoniccode
        {
            get { return _DbC_mnemoniccode; }
            set { _DbC_mnemoniccode = value; }
        }

        public BasicDAL.DbColumn DbC_parentid
        {
            get { return _DbC_parentid; }
            set { _DbC_parentid = value; }
        }
        public BasicDAL.DbColumn DbC_brandclassid
        {
            get { return _DbC_brandclassid; }
            set { _DbC_brandclassid = value; }
        }

        public BasicDAL.DbColumn DbC_description
        {
            get { return _DbC_description; }
            set { _DbC_description = value; }
        }

        public BasicDAL.DbColumn DbC_notes
        {
            get { return _DbC_notes; }
            set { _DbC_notes = value; }
        }

        #endregion

        public DbT_BrandCategories()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
            this.DbTableName = "BrandCategories";
        }
    }
    //------------------------------------------------------------------------------
    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_dbo_AssetBarcodes
    // Date   :31/03/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbT_AssetBarcodes : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_assetid = new BasicDAL.DbColumn("[AssetID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_barcodevalue = new BasicDAL.DbColumn("[BarcodeValue]", System.Data.DbType.String, true, "");
        private BasicDAL.DbColumn _DbC_barcodetype = new BasicDAL.DbColumn("[BarcodeType]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_internaluse = new BasicDAL.DbColumn("[InternalUse]", System.Data.DbType.Boolean, false, false);
        private BasicDAL.DbColumn _DbC_qty = new BasicDAL.DbColumn("[Qty]", System.Data.DbType.Decimal, false, 0);
        private BasicDAL.DbColumn _DbC_decimalallowed = new BasicDAL.DbColumn("[DecimalAllowed]", System.Data.DbType.Boolean, false, false);
        private BasicDAL.DbColumn _DbC_enabled = new BasicDAL.DbColumn("[Enabled]", System.Data.DbType.Boolean, false, false);

        public BasicDAL.DbColumn DbC_assetid
        {
            get { return _DbC_assetid; }
            set { _DbC_assetid = value; }
        }

        public BasicDAL.DbColumn DbC_barcodevalue
        {
            get { return _DbC_barcodevalue; }
            set { _DbC_barcodevalue = value; }
        }

        public BasicDAL.DbColumn DbC_barcodetype
        {
            get { return _DbC_barcodetype; }
            set { _DbC_barcodetype = value; }
        }

        public BasicDAL.DbColumn DbC_internaluse
        {
            get { return _DbC_internaluse; }
            set { _DbC_internaluse = value; }
        }

        public BasicDAL.DbColumn DbC_qty
        {
            get { return _DbC_qty; }
            set { _DbC_qty = value; }
        }

        public BasicDAL.DbColumn DbC_decimalallowed
        {
            get { return _DbC_decimalallowed; }
            set { _DbC_decimalallowed = value; }
        }

        public BasicDAL.DbColumn DbC_enabled
        {
            get { return _DbC_enabled; }
            set { _DbC_enabled = value; }
        }

        #endregion

        public DbT_AssetBarcodes()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
            this.DbTableName = "dbo.AssetBarcodes";
        }
    }
    //------------------------------------------------------------------------------

    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_Customers
    // Date   :22/03/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbT_Customers : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, true, 0);
        private BasicDAL.DbColumn _DbC_mnemoniccode = new BasicDAL.DbColumn("[MnemonicCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_customercategoryid = new BasicDAL.DbColumn("[CustomerCategoryID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_fullname = new BasicDAL.DbColumn("[FullName]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_firstname = new BasicDAL.DbColumn("[FirstName]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_lastname = new BasicDAL.DbColumn("[LastName]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_titlename = new BasicDAL.DbColumn("[TitleName]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_phonenumber = new BasicDAL.DbColumn("[PhoneNumber]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_emailaddress = new BasicDAL.DbColumn("[EmailAddress]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_notes = new BasicDAL.DbColumn("[Notes]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_address = new BasicDAL.DbColumn("[Address]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_zipcode = new BasicDAL.DbColumn("[ZipCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_city = new BasicDAL.DbColumn("[City]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_vatcode = new BasicDAL.DbColumn("[VATCode]", System.Data.DbType.String, false, "");

        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_mnemoniccode
        {
            get { return _DbC_mnemoniccode; }
            set { _DbC_mnemoniccode = value; }
        }

        public BasicDAL.DbColumn DbC_customercategoryid
        {
            get { return _DbC_customercategoryid; }
            set { _DbC_customercategoryid = value; }
        }

        public BasicDAL.DbColumn DbC_fullname
        {
            get { return _DbC_fullname; }
            set { _DbC_fullname = value; }
        }

        public BasicDAL.DbColumn DbC_firstname
        {
            get { return _DbC_firstname; }
            set { _DbC_firstname = value; }
        }

        public BasicDAL.DbColumn DbC_lastname
        {
            get { return _DbC_lastname; }
            set { _DbC_lastname = value; }
        }

        public BasicDAL.DbColumn DbC_titlename
        {
            get { return _DbC_titlename; }
            set { _DbC_titlename = value; }
        }

        public BasicDAL.DbColumn DbC_phonenumber
        {
            get { return _DbC_phonenumber; }
            set { _DbC_phonenumber = value; }
        }

        public BasicDAL.DbColumn DbC_emailaddress
        {
            get { return _DbC_emailaddress; }
            set { _DbC_emailaddress = value; }
        }

        public BasicDAL.DbColumn DbC_notes
        {
            get { return _DbC_notes; }
            set { _DbC_notes = value; }
        }

        public BasicDAL.DbColumn DbC_address
        {
            get { return _DbC_address; }
            set { _DbC_address = value; }
        }

        public BasicDAL.DbColumn DbC_zipcode
        {
            get { return _DbC_zipcode; }
            set { _DbC_zipcode = value; }
        }

        public BasicDAL.DbColumn DbC_city
        {
            get { return _DbC_city; }
            set { _DbC_city = value; }
        }

        public BasicDAL.DbColumn DbC_vatcode
        {
            get { return _DbC_vatcode; }
            set { _DbC_vatcode = value; }
        }

        #endregion

        public DbT_Customers()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
            this.DbTableName = "Customers";
        }
    }
    //------------------------------------------------------------------------------
   



    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_Items
    // Date   :22/03/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbT_Items : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, true, 0);
        private BasicDAL.DbColumn _DbC_assetid = new BasicDAL.DbColumn("[AssetID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_description = new BasicDAL.DbColumn("[Description]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_serialnumber = new BasicDAL.DbColumn("[SerialNumber]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_batchnumber = new BasicDAL.DbColumn("[BatchNumber]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_measureunit = new BasicDAL.DbColumn("[MeasureUnit]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_status = new BasicDAL.DbColumn("[Status]", System.Data.DbType.Int16, false, 0);
        private BasicDAL.DbColumn _DbC_acquisitiondate = new BasicDAL.DbColumn("[AcquisitionDate]", System.Data.DbType.DateTime, false, DateTime.Today);
        private BasicDAL.DbColumn _DbC_dismissiondate = new BasicDAL.DbColumn("[DismissionDate]", System.Data.DbType.DateTime, false, DateTime.Today);
        private BasicDAL.DbColumn _DbC_notes = new BasicDAL.DbColumn("[Notes]", System.Data.DbType.String, false, "");

        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_assetid
        {
            get { return _DbC_assetid; }
            set { _DbC_assetid = value; }
        }

        public BasicDAL.DbColumn DbC_description
        {
            get { return _DbC_description; }
            set { _DbC_description = value; }
        }

        public BasicDAL.DbColumn DbC_serialnumber
        {
            get { return _DbC_serialnumber; }
            set { _DbC_serialnumber = value; }
        }

        public BasicDAL.DbColumn DbC_batchnumber
        {
            get { return _DbC_batchnumber; }
            set { _DbC_batchnumber = value; }
        }

        public BasicDAL.DbColumn DbC_measureunit
        {
            get { return _DbC_measureunit; }
            set { _DbC_measureunit = value; }
        }

        public BasicDAL.DbColumn DbC_status
        {
            get { return _DbC_status; }
            set { _DbC_status = value; }
        }

        public BasicDAL.DbColumn DbC_acquisitiondate
        {
            get { return _DbC_acquisitiondate; }
            set { _DbC_acquisitiondate = value; }
        }

        public BasicDAL.DbColumn DbC_dismissiondate
        {
            get { return _DbC_dismissiondate; }
            set { _DbC_dismissiondate = value; }
        }

        public BasicDAL.DbColumn DbC_notes
        {
            get { return _DbC_notes; }
            set { _DbC_notes = value; }
        }

        #endregion

        public DbT_Items()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
            this.DbTableName = "Items";
        }
    }
    //------------------------------------------------------------------------------

    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_Locations
    // Date   :01/04/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbT_Locations : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, true, 0);
        private BasicDAL.DbColumn _DbC_mnemoniccode = new BasicDAL.DbColumn("[MnemonicCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_ownerid = new BasicDAL.DbColumn("[OwnerID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_name = new BasicDAL.DbColumn("[Name]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_address = new BasicDAL.DbColumn("[Address]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_zip = new BasicDAL.DbColumn("[ZIP]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_city = new BasicDAL.DbColumn("[City]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_state = new BasicDAL.DbColumn("[State]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_country = new BasicDAL.DbColumn("[Country]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_geolocation = new BasicDAL.DbColumn("[GeoLocation]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_phonenumber = new BasicDAL.DbColumn("[PhoneNumber]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_email = new BasicDAL.DbColumn("[Email]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_notes = new BasicDAL.DbColumn("[Notes]", System.Data.DbType.String, false, "");

        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_mnemoniccode
        {
            get { return _DbC_mnemoniccode; }
            set { _DbC_mnemoniccode = value; }
        }

        public BasicDAL.DbColumn DbC_ownerid
        {
            get { return _DbC_ownerid; }
            set { _DbC_ownerid = value; }
        }

        public BasicDAL.DbColumn DbC_name
        {
            get { return _DbC_name; }
            set { _DbC_name = value; }
        }

        public BasicDAL.DbColumn DbC_address
        {
            get { return _DbC_address; }
            set { _DbC_address = value; }
        }

        public BasicDAL.DbColumn DbC_zip
        {
            get { return _DbC_zip; }
            set { _DbC_zip = value; }
        }

        public BasicDAL.DbColumn DbC_city
        {
            get { return _DbC_city; }
            set { _DbC_city = value; }
        }

        public BasicDAL.DbColumn DbC_state
        {
            get { return _DbC_state; }
            set { _DbC_state = value; }
        }

        public BasicDAL.DbColumn DbC_country
        {
            get { return _DbC_country; }
            set { _DbC_country = value; }
        }

        public BasicDAL.DbColumn DbC_geolocation
        {
            get { return _DbC_geolocation; }
            set { _DbC_geolocation = value; }
        }

        public BasicDAL.DbColumn DbC_phonenumber
        {
            get { return _DbC_phonenumber; }
            set { _DbC_phonenumber = value; }
        }

        public BasicDAL.DbColumn DbC_email
        {
            get { return _DbC_email; }
            set { _DbC_email = value; }
        }

        public BasicDAL.DbColumn DbC_notes
        {
            get { return _DbC_notes; }
            set { _DbC_notes = value; }
        }

        #endregion

        public DbT_Locations()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
            this.DbTableName = "Locations";
        }
    }
    //------------------------------------------------------------------------------


    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_RecordCodes
    // Date   :21/04/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbT_RecordCodes : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, true, 0);
        private BasicDAL.DbColumn _DbC_mnemoniccode = new BasicDAL.DbColumn("[MnemonicCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_description = new BasicDAL.DbColumn("[Description]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_primarylocationid = new BasicDAL.DbColumn("[PrimaryLocationID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_secondarylocationid = new BasicDAL.DbColumn("[SecondaryLocationID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_actiononprimarylocationinventory = new BasicDAL.DbColumn("[ActionOnPrimaryLocationInventory]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_actiononsecondarylocationinventory = new BasicDAL.DbColumn("[ActionOnSecondaryLocationInventory]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_secondarylocationrecordcodeid = new BasicDAL.DbColumn("[SecondaryLocationRecordCodeID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_notes = new BasicDAL.DbColumn("[Notes]", System.Data.DbType.String, false, "");

        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_mnemoniccode
        {
            get { return _DbC_mnemoniccode; }
            set { _DbC_mnemoniccode = value; }
        }

        public BasicDAL.DbColumn DbC_description
        {
            get { return _DbC_description; }
            set { _DbC_description = value; }
        }

        public BasicDAL.DbColumn DbC_primarylocationid
        {
            get { return _DbC_primarylocationid; }
            set { _DbC_primarylocationid = value; }
        }

        public BasicDAL.DbColumn DbC_secondarylocationid
        {
            get { return _DbC_secondarylocationid; }
            set { _DbC_secondarylocationid = value; }
        }

        public BasicDAL.DbColumn DbC_actiononprimarylocationinventory
        {
            get { return _DbC_actiononprimarylocationinventory; }
            set { _DbC_actiononprimarylocationinventory = value; }
        }

        public BasicDAL.DbColumn DbC_actiononsecondarylocationinventory
        {
            get { return _DbC_actiononsecondarylocationinventory; }
            set { _DbC_actiononsecondarylocationinventory = value; }
        }

        public BasicDAL.DbColumn DbC_secondarylocationrecordcodeid
        {
            get { return _DbC_secondarylocationrecordcodeid; }
            set { _DbC_secondarylocationrecordcodeid = value; }
        }

        public BasicDAL.DbColumn DbC_notes
        {
            get { return _DbC_notes; }
            set { _DbC_notes = value; }
        }

        #endregion

        public DbT_RecordCodes()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
            this.DbTableName = "RecordCodes";
        }
    }
    //------------------------------------------------------------------------------


    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_RecordDetails
    // Date   :06/05/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbT_RecordDetails : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_recorddetailid = new BasicDAL.DbColumn("[RecordDetailID]", System.Data.DbType.Int32, true, 0);
        private BasicDAL.DbColumn _DbC_recordmasterid = new BasicDAL.DbColumn("[RecordMasterID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_rownum = new BasicDAL.DbColumn("[RowNum]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_status = new BasicDAL.DbColumn("[Status]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_assetid = new BasicDAL.DbColumn("[AssetID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_barcode = new BasicDAL.DbColumn("[Barcode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_serialnumber = new BasicDAL.DbColumn("[SerialNumber]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_qty = new BasicDAL.DbColumn("[Qty]", System.Data.DbType.Decimal, false, 0);
        private BasicDAL.DbColumn _DbC_unitvalue = new BasicDAL.DbColumn("[UnitValue]", System.Data.DbType.Decimal, false, 0);
        private BasicDAL.DbColumn _DbC_recorddetailnote = new BasicDAL.DbColumn("[RecordDetailNote]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_primarysublocationinfo = new BasicDAL.DbColumn("[PrimarySubLocationInfo]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_secondarysublocationinfo = new BasicDAL.DbColumn("[SecondarySubLocationInfo]", System.Data.DbType.String, false, "");

        public BasicDAL.DbColumn DbC_recorddetailid
        {
            get { return _DbC_recorddetailid; }
            set { _DbC_recorddetailid = value; }
        }

        public BasicDAL.DbColumn DbC_recordmasterid
        {
            get { return _DbC_recordmasterid; }
            set { _DbC_recordmasterid = value; }
        }

        public BasicDAL.DbColumn DbC_rownum
        {
            get { return _DbC_rownum; }
            set { _DbC_rownum = value; }
        }

        public BasicDAL.DbColumn DbC_status
        {
            get { return _DbC_status; }
            set { _DbC_status = value; }
        }

        public BasicDAL.DbColumn DbC_assetid
        {
            get { return _DbC_assetid; }
            set { _DbC_assetid = value; }
        }

        public BasicDAL.DbColumn DbC_qty
        {
            get { return _DbC_qty; }
            set { _DbC_qty = value; }
        }

        public BasicDAL.DbColumn DbC_unitvalue
        {
            get { return _DbC_unitvalue; }
            set { _DbC_unitvalue = value; }
        }

        public BasicDAL.DbColumn DbC_recorddetailnote
        {
            get { return _DbC_recorddetailnote; }
            set { _DbC_recorddetailnote = value; }
        }

        public BasicDAL.DbColumn DbC_primarysublocationinfo
        {
            get { return _DbC_primarysublocationinfo; }
            set { _DbC_primarysublocationinfo = value; }
        }

        public BasicDAL.DbColumn DbC_secondarysublocationinfo
        {
            get { return _DbC_secondarysublocationinfo; }
            set { _DbC_secondarysublocationinfo = value; }
        }

        #endregion

        public DbT_RecordDetails()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
            this.DbTableName = "RecordDetails";
        }
    }
    //------------------------------------------------------------------------------



    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_RecordMasters
    // Date   :06/05/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbT_RecordMasters : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, true, 0);
        private BasicDAL.DbColumn _DbC_recordtype = new BasicDAL.DbColumn("[RecordType]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_parentrecordid = new BasicDAL.DbColumn("[ParentRecordID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_recorddate = new BasicDAL.DbColumn("[RecordDate]", System.Data.DbType.DateTime, false, null);
        private BasicDAL.DbColumn _DbC_recordtime = new BasicDAL.DbColumn("[RecordTime]", System.Data.DbType.Time, false,"00:00:00");
        private BasicDAL.DbColumn _DbC_recordingdate = new BasicDAL.DbColumn("[RecordingDate]", System.Data.DbType.DateTime, false,DBNull.Value );
        private BasicDAL.DbColumn _DbC_recordingtime = new BasicDAL.DbColumn("[RecordingTime]", System.Data.DbType.Time , false,"00:00:00");
        private BasicDAL.DbColumn _DbC_documenttypeid = new BasicDAL.DbColumn("[DocumentTypeID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_documentnumber = new BasicDAL.DbColumn("[DocumentNumber]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_documentdate = new BasicDAL.DbColumn("[DocumentDate]", System.Data.DbType.DateTime, false, null);
        private BasicDAL.DbColumn _DbC_documentissuertype = new BasicDAL.DbColumn("[DocumentIssuerType]", System.Data.DbType.String, false, "0");
        private BasicDAL.DbColumn _DbC_documentissuerid = new BasicDAL.DbColumn("[DocumentIssuerID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_documentissuername = new BasicDAL.DbColumn("[DocumentIssuerName]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_status = new BasicDAL.DbColumn("[Status]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_description = new BasicDAL.DbColumn("[Description]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_primaryrecordcodeid = new BasicDAL.DbColumn("[PrimaryRecordCodeID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_secondaryrecordcodeid = new BasicDAL.DbColumn("[SecondaryRecordCodeID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_primarylocationid = new BasicDAL.DbColumn("[PrimaryLocationID]", System.Data.DbType.Int32 , false, 0);
        private BasicDAL.DbColumn _DbC_secondarylocationid = new BasicDAL.DbColumn("[SecondaryLocationID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_primarysublocationinfo = new BasicDAL.DbColumn("[PrimarySubLocationInfo]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_secondarysublocationinfo = new BasicDAL.DbColumn("[SecondarySubLocationInfo]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_notes = new BasicDAL.DbColumn("[Notes]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_ticketid = new BasicDAL.DbColumn("[TicketID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_ticketeventid = new BasicDAL.DbColumn("[TicketEventID]", System.Data.DbType.Int32, false, 0);
        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_recordtype
        {
            get { return _DbC_recordtype; }
            set { _DbC_recordtype = value; }
        }

        public BasicDAL.DbColumn DbC_parentrecordid
        {
            get { return _DbC_parentrecordid; }
            set { _DbC_parentrecordid = value; }
        }

        public BasicDAL.DbColumn DbC_recorddate
        {
            get { return _DbC_recorddate; }
            set { _DbC_recorddate = value; }
        }

        public BasicDAL.DbColumn DbC_recordtime
        {
            get { return _DbC_recordtime; }
            set { _DbC_recordtime = value; }
        }

        public BasicDAL.DbColumn DbC_recordingdate
        {
            get { return _DbC_recordingdate; }
            set { _DbC_recordingdate = value; }
        }

        public BasicDAL.DbColumn DbC_recordingtime
        {
            get { return _DbC_recordingtime; }
            set { _DbC_recordingtime = value; }
        }

        public BasicDAL.DbColumn DbC_documenttypeid
        {
            get { return _DbC_documenttypeid; }
            set { _DbC_documenttypeid = value; }
        }

        public BasicDAL.DbColumn DbC_documentnumber
        {
            get { return _DbC_documentnumber; }
            set { _DbC_documentnumber = value; }
        }

        public BasicDAL.DbColumn DbC_documentdate
        {
            get { return _DbC_documentdate; }
            set { _DbC_documentdate = value; }
        }

        public BasicDAL.DbColumn DbC_documentissuertype
        {
            get { return _DbC_documentissuertype; }
            set { _DbC_documentissuertype = value; }
        }

        public BasicDAL.DbColumn DbC_documentissuerid
        {
            get { return _DbC_documentissuerid; }
            set { _DbC_documentissuerid = value; }
        }

        public BasicDAL.DbColumn DbC_documentissuername
        {
            get { return _DbC_documentissuername; }
            set { _DbC_documentissuername = value; }
        }


        public BasicDAL.DbColumn DbC_status
        {
            get { return _DbC_status; }
            set { _DbC_status = value; }
        }

        public BasicDAL.DbColumn DbC_description
        {
            get { return _DbC_description; }
            set { _DbC_description = value; }
        }

        public BasicDAL.DbColumn DbC_primaryrecordcodeid
        {
            get { return _DbC_primaryrecordcodeid; }
            set { _DbC_primaryrecordcodeid = value; }
        }

        public BasicDAL.DbColumn DbC_secondaryrecordcodeid
        {
            get { return _DbC_secondaryrecordcodeid; }
            set { _DbC_secondaryrecordcodeid = value; }
        }

        public BasicDAL.DbColumn DbC_primarylocationid
        {
            get { return _DbC_primarylocationid; }
            set { _DbC_primarylocationid = value; }
        }

        public BasicDAL.DbColumn DbC_secondarylocationid
        {
            get { return _DbC_secondarylocationid; }
            set { _DbC_secondarylocationid = value; }
        }

        public BasicDAL.DbColumn DbC_primarysublocationinfo
        {
            get { return _DbC_primarysublocationinfo; }
            set { _DbC_primarysublocationinfo = value; }
        }

        public BasicDAL.DbColumn DbC_secondarysublocationinfo
        {
            get { return _DbC_secondarysublocationinfo; }
            set { _DbC_secondarysublocationinfo = value; }
        }

        public BasicDAL.DbColumn DbC_notes
        {
            get { return _DbC_notes; }
            set { _DbC_notes = value; }
        }
        public BasicDAL.DbColumn DbC_ticketid
        {
            get { return _DbC_ticketid; }
            set { _DbC_ticketid = value; }
        }

        public BasicDAL.DbColumn DbC_ticketeventid
        {
            get { return _DbC_ticketeventid; }
            set { _DbC_ticketeventid = value; }
        }

        #endregion

        public DbT_RecordMasters()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
            this.DbTableName = "RecordMasters";
        }
    }
    //------------------------------------------------------------------------------



    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_OperatorCategories
    // Date   :22/03/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbT_OperatorCategories : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, true, 0);
        private BasicDAL.DbColumn _DbC_mnemoniccode = new BasicDAL.DbColumn("[MnemonicCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_parentid = new BasicDAL.DbColumn("[ParentID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_description = new BasicDAL.DbColumn("[Description]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_notes = new BasicDAL.DbColumn("[notes]", System.Data.DbType.String, false, "");
        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_mnemoniccode
        {
            get { return _DbC_mnemoniccode; }
            set { _DbC_mnemoniccode = value; }
        }

        public BasicDAL.DbColumn DbC_parentid
        {
            get { return _DbC_parentid; }
            set { _DbC_parentid = value; }
        }

        public BasicDAL.DbColumn DbC_description
        {
            get { return _DbC_description; }
            set { _DbC_description = value; }
        }

        public BasicDAL.DbColumn DbC_notes
        {
            get { return _DbC_notes; }
            set { _DbC_notes = value; }
        }

        #endregion

        public DbT_OperatorCategories()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
            this.DbTableName = "OperatorCategories";
        }
    }
    //------------------------------------------------------------------------------

    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbV_OperatorCategoriesTree
    // Date   :25/03/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbV_OperatorCategoriesTree : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_parentid = new BasicDAL.DbColumn("[ParentID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_description = new BasicDAL.DbColumn("[Description]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_mnemoniccode = new BasicDAL.DbColumn("[MnemonicCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_level = new BasicDAL.DbColumn("[Level]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_nodekey = new BasicDAL.DbColumn("[NodeKey]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_nodepath = new BasicDAL.DbColumn("[NodePath]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_codepath = new BasicDAL.DbColumn("[CodePath]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_nodekeypath = new BasicDAL.DbColumn("[NodeKeyPath]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_nodecodepath = new BasicDAL.DbColumn("[NodeCodePath]", System.Data.DbType.String, false, "");

        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_parentid
        {
            get { return _DbC_parentid; }
            set { _DbC_parentid = value; }
        }

        public BasicDAL.DbColumn DbC_description
        {
            get { return _DbC_description; }
            set { _DbC_description = value; }
        }

        public BasicDAL.DbColumn DbC_mnemoniccode
        {
            get { return _DbC_mnemoniccode; }
            set { _DbC_mnemoniccode = value; }
        }

        public BasicDAL.DbColumn DbC_level
        {
            get { return _DbC_level; }
            set { _DbC_level = value; }
        }

        public BasicDAL.DbColumn DbC_nodekey
        {
            get { return _DbC_nodekey; }
            set { _DbC_nodekey = value; }
        }

        public BasicDAL.DbColumn DbC_nodepath
        {
            get { return _DbC_nodepath; }
            set { _DbC_nodepath = value; }
        }

        public BasicDAL.DbColumn DbC_codepath
        {
            get { return _DbC_codepath; }
            set { _DbC_codepath = value; }
        }

        public BasicDAL.DbColumn DbC_nodekeypath
        {
            get { return _DbC_nodekeypath; }
            set { _DbC_nodekeypath = value; }
        }

        public BasicDAL.DbColumn DbC_nodecodepath
        {
            get { return _DbC_nodecodepath; }
            set { _DbC_nodecodepath = value; }
        }

        #endregion

        public DbV_OperatorCategoriesTree()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.View;
            this.DbTableName = "OperatorCategoriesTree";
        }
    }
    //------------------------------------------------------------------------------

    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_Operators
    // Date   :22/03/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbT_Operators : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, true, 0);
        private BasicDAL.DbColumn _DbC_menmoniccode = new BasicDAL.DbColumn("[MenmonicCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_operatorcategoryid = new BasicDAL.DbColumn("[OperatorCategoryID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_firstname = new BasicDAL.DbColumn("[FirstName]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_lastname = new BasicDAL.DbColumn("[LastName]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_titlename = new BasicDAL.DbColumn("[TitleName]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_locationid = new BasicDAL.DbColumn("[LocationID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_sublocationinfo = new BasicDAL.DbColumn("[SubLocationInfo]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_phonenumber = new BasicDAL.DbColumn("[PhoneNumber]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_emailaddress = new BasicDAL.DbColumn("[EmailAddress]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_notes = new BasicDAL.DbColumn("[Notes]", System.Data.DbType.String, false, "");

        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_menmoniccode
        {
            get { return _DbC_menmoniccode; }
            set { _DbC_menmoniccode = value; }
        }

        public BasicDAL.DbColumn DbC_operatorcategoryid
        {
            get { return _DbC_operatorcategoryid; }
            set { _DbC_operatorcategoryid = value; }
        }

        public BasicDAL.DbColumn DbC_firstname
        {
            get { return _DbC_firstname; }
            set { _DbC_firstname = value; }
        }

        public BasicDAL.DbColumn DbC_lastname
        {
            get { return _DbC_lastname; }
            set { _DbC_lastname = value; }
        }

        public BasicDAL.DbColumn DbC_titlename
        {
            get { return _DbC_titlename; }
            set { _DbC_titlename = value; }
        }

        public BasicDAL.DbColumn DbC_locationid
        {
            get { return _DbC_locationid; }
            set { _DbC_locationid = value; }
        }

        public BasicDAL.DbColumn DbC_sublocationinfo
        {
            get { return _DbC_sublocationinfo; }
            set { _DbC_sublocationinfo = value; }
        }

        public BasicDAL.DbColumn DbC_phonenumber
        {
            get { return _DbC_phonenumber; }
            set { _DbC_phonenumber = value; }
        }

        public BasicDAL.DbColumn DbC_emailaddress
        {
            get { return _DbC_emailaddress; }
            set { _DbC_emailaddress = value; }
        }

        public BasicDAL.DbColumn DbC_notes
        {
            get { return _DbC_notes; }
            set { _DbC_notes = value; }
        }

        #endregion

        public DbT_Operators()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
            this.DbTableName = "Operators";
        }
    }
    //------------------------------------------------------------------------------
    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_Owners
    // Date   :01/04/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbT_Owners : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, true, 0);
        private BasicDAL.DbColumn _DbC_mnemoniccode = new BasicDAL.DbColumn("[MnemonicCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_name = new BasicDAL.DbColumn("[Name]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_address = new BasicDAL.DbColumn("[Address]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_zip = new BasicDAL.DbColumn("[ZIP]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_city = new BasicDAL.DbColumn("[City]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_state = new BasicDAL.DbColumn("[State]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_country = new BasicDAL.DbColumn("[Country]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_phonenumber = new BasicDAL.DbColumn("[PhoneNumber]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_email = new BasicDAL.DbColumn("[Email]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_accountingcode = new BasicDAL.DbColumn("[AccountingCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_vatid = new BasicDAL.DbColumn("[VatID]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_taxid = new BasicDAL.DbColumn("[TaxID]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_geolocation = new BasicDAL.DbColumn("[Geolocation]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_notes = new BasicDAL.DbColumn("[Notes]", System.Data.DbType.String, false, "");

        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_mnemoniccode
        {
            get { return _DbC_mnemoniccode; }
            set { _DbC_mnemoniccode = value; }
        }

        public BasicDAL.DbColumn DbC_name
        {
            get { return _DbC_name; }
            set { _DbC_name = value; }
        }

        public BasicDAL.DbColumn DbC_address
        {
            get { return _DbC_address; }
            set { _DbC_address = value; }
        }

        public BasicDAL.DbColumn DbC_zip
        {
            get { return _DbC_zip; }
            set { _DbC_zip = value; }
        }

        public BasicDAL.DbColumn DbC_city
        {
            get { return _DbC_city; }
            set { _DbC_city = value; }
        }

        public BasicDAL.DbColumn DbC_state
        {
            get { return _DbC_state; }
            set { _DbC_state = value; }
        }

        public BasicDAL.DbColumn DbC_country
        {
            get { return _DbC_country; }
            set { _DbC_country = value; }
        }

        public BasicDAL.DbColumn DbC_phonenumber
        {
            get { return _DbC_phonenumber; }
            set { _DbC_phonenumber = value; }
        }

        public BasicDAL.DbColumn DbC_email
        {
            get { return _DbC_email; }
            set { _DbC_email = value; }
        }

        public BasicDAL.DbColumn DbC_accountingcode
        {
            get { return _DbC_accountingcode; }
            set { _DbC_accountingcode = value; }
        }

        public BasicDAL.DbColumn DbC_vatid
        {
            get { return _DbC_vatid; }
            set { _DbC_vatid = value; }
        }

        public BasicDAL.DbColumn DbC_taxid
        {
            get { return _DbC_taxid; }
            set { _DbC_taxid = value; }
        }

        public BasicDAL.DbColumn DbC_geolocation
        {
            get { return _DbC_geolocation; }
            set { _DbC_geolocation = value; }
        }

        public BasicDAL.DbColumn DbC_notes
        {
            get { return _DbC_notes; }
            set { _DbC_notes = value; }
        }

        #endregion

        public DbT_Owners()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
            this.DbTableName = "Owners";
        }
    }
    //------------------------------------------------------------------------------



    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_TicketEventAssignments
    // Date   :22/03/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbT_TicketEventAssignments : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_ticketeventid = new BasicDAL.DbColumn("[TicketEventID]", System.Data.DbType.Int32, true, 0);
        private BasicDAL.DbColumn _DbC_assignedtooperatorid = new BasicDAL.DbColumn("[AssignedToOperatorID]", System.Data.DbType.Int32, true, 0);
        private BasicDAL.DbColumn _DbC_assignedbyoperatorid = new BasicDAL.DbColumn("[AssignedByOperatorID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_status = new BasicDAL.DbColumn("[Status]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_date = new BasicDAL.DbColumn("[Date]", System.Data.DbType.Date, false, null);
        private BasicDAL.DbColumn _DbC_time = new BasicDAL.DbColumn("[Time]", System.Data.DbType.Time, false,0);
        private BasicDAL.DbColumn _DbC_notes = new BasicDAL.DbColumn("[Notes]", System.Data.DbType.String, false, "");

        public BasicDAL.DbColumn DbC_ticketeventid
        {
            get { return _DbC_ticketeventid; }
            set { _DbC_ticketeventid = value; }
        }

        public BasicDAL.DbColumn DbC_assignedtooperatorid
        {
            get { return _DbC_assignedtooperatorid; }
            set { _DbC_assignedtooperatorid = value; }
        }

        public BasicDAL.DbColumn DbC_assignedbyoperatorid
        {
            get { return _DbC_assignedbyoperatorid; }
            set { _DbC_assignedbyoperatorid = value; }
        }

        public BasicDAL.DbColumn DbC_status
        {
            get { return _DbC_status; }
            set { _DbC_status = value; }
        }

        public BasicDAL.DbColumn DbC_date
        {
            get { return _DbC_date; }
            set { _DbC_date = value; }
        }

        public BasicDAL.DbColumn DbC_time
        {
            get { return _DbC_time; }
            set { _DbC_time = value; }
        }

        public BasicDAL.DbColumn DbC_notes
        {
            get { return _DbC_notes; }
            set { _DbC_notes = value; }
        }

        #endregion

        public DbT_TicketEventAssignments()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
            this.DbTableName = "TicketEventAssignments";
        }
    }
    //------------------------------------------------------------------------------

    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_dbo_TicketEvents
    // Date   :05/10/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbT_TicketEvents : BasicDAL.DbObject
    {
        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, true, 0);
        private BasicDAL.DbColumn _DbC_ticketid = new BasicDAL.DbColumn("[TicketID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_parentid = new BasicDAL.DbColumn("[ParentID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_date = new BasicDAL.DbColumn("[Date]", System.Data.DbType.DateTime, false, null);
        private BasicDAL.DbColumn _DbC_time = new BasicDAL.DbColumn("[Time]", System.Data.DbType.Time, false, null);
  private BasicDAL.DbColumn _DbC_ticketeventtype = new BasicDAL.DbColumn("[TicketEventType]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_ticketeventdescription = new BasicDAL.DbColumn("[TicketEventDescription]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_operatorid = new BasicDAL.DbColumn("[OperatorID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_customernotes = new BasicDAL.DbColumn("[CustomerNotes]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_operatornotes = new BasicDAL.DbColumn("[OperatorNotes]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_duedate = new BasicDAL.DbColumn("[DueDate]", System.Data.DbType.DateTime, false, null);
        private BasicDAL.DbColumn _DbC_duetime = new BasicDAL.DbColumn("[DueTime]", System.Data.DbType.Time, false, null);
  private BasicDAL.DbColumn _DbC_issuecategoryid = new BasicDAL.DbColumn("[IssueCategoryID]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_status = new BasicDAL.DbColumn("[Status]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_severity = new BasicDAL.DbColumn("[Severity]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_priority = new BasicDAL.DbColumn("[Priority]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_description = new BasicDAL.DbColumn("[Description]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_requestername = new BasicDAL.DbColumn("[RequesterName]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_requesterphone = new BasicDAL.DbColumn("[RequesterPhone]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_requesteremail = new BasicDAL.DbColumn("[RequesterEmail]", System.Data.DbType.String, false, "");

        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_ticketid
        {
            get { return _DbC_ticketid; }
            set { _DbC_ticketid = value; }
        }

        public BasicDAL.DbColumn DbC_parentid
        {
            get { return _DbC_parentid; }
            set { _DbC_parentid = value; }
        }

        public BasicDAL.DbColumn DbC_date
        {
            get { return _DbC_date; }
            set { _DbC_date = value; }
        }

        public BasicDAL.DbColumn DbC_time
        {
            get { return _DbC_time; }
            set { _DbC_time = value; }
        }

        public BasicDAL.DbColumn DbC_ticketeventtype
        {
            get { return _DbC_ticketeventtype; }
            set { _DbC_ticketeventtype = value; }
        }

        public BasicDAL.DbColumn DbC_ticketeventdescription
        {
            get { return _DbC_ticketeventdescription; }
            set { _DbC_ticketeventdescription = value; }
        }

        public BasicDAL.DbColumn DbC_operatorid
        {
            get { return _DbC_operatorid; }
            set { _DbC_operatorid = value; }
        }

        public BasicDAL.DbColumn DbC_customernotes
        {
            get { return _DbC_customernotes; }
            set { _DbC_customernotes = value; }
        }

        public BasicDAL.DbColumn DbC_operatornotes
        {
            get { return _DbC_operatornotes; }
            set { _DbC_operatornotes = value; }
        }

        public BasicDAL.DbColumn DbC_duedate
        {
            get { return _DbC_duedate; }
            set { _DbC_duedate = value; }
        }

        public BasicDAL.DbColumn DbC_duetime
        {
            get { return _DbC_duetime; }
            set { _DbC_duetime = value; }
        }

        public BasicDAL.DbColumn DbC_issuecategoryid
        {
            get { return _DbC_issuecategoryid; }
            set { _DbC_issuecategoryid = value; }
        }

        public BasicDAL.DbColumn DbC_status
        {
            get { return _DbC_status; }
            set { _DbC_status = value; }
        }

        public BasicDAL.DbColumn DbC_severity
        {
            get { return _DbC_severity; }
            set { _DbC_severity = value; }
        }

        public BasicDAL.DbColumn DbC_priority
        {
            get { return _DbC_priority; }
            set { _DbC_priority = value; }
        }


        public BasicDAL.DbColumn DbC_description
        {
            get { return _DbC_description; }
            set { _DbC_description = value; }
        }
        public BasicDAL.DbColumn DbC_requestername
        {
            get { return _DbC_requestername; }
            set { _DbC_requestername = value; }
        }

        public BasicDAL.DbColumn DbC_requesterphone
        {
            get { return _DbC_requesterphone; }
            set { _DbC_requesterphone = value; }
        }

        public BasicDAL.DbColumn DbC_reuquesteremail
        {
            get { return _DbC_requesteremail; }
            set { _DbC_requesteremail = value; }
        }

        #endregion

        public DbT_TicketEvents()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
            this.DbTableName = "dbo.TicketEvents";
        }
    }
    //------------------------------------------------------------------------------

    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_Tickets
    // Date   :22/03/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbT_Tickets : BasicDAL.DbObject
    {

        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, true, 0);
        private BasicDAL.DbColumn _DbC_mnemoniccode = new BasicDAL.DbColumn("[MnemonicCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_creationdate = new BasicDAL.DbColumn("[CreationDate]", System.Data.DbType.DateTime, false, null);
        private BasicDAL.DbColumn _DbC_creationtime = new BasicDAL.DbColumn("[CreationTime]", System.Data.DbType.Time, false, null);
        private BasicDAL.DbColumn _DbC_creationoperatorid = new BasicDAL.DbColumn("[CreationOperatorID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_creationsource = new BasicDAL.DbColumn("[CreationSource]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_parentid = new BasicDAL.DbColumn("[ParentID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_status = new BasicDAL.DbColumn("[Status]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_projectid = new BasicDAL.DbColumn("[ProjectID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_customerid = new BasicDAL.DbColumn("[CustomerID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_issuecategoryid = new BasicDAL.DbColumn("[IssueCategoryID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_customernotes = new BasicDAL.DbColumn("[CustomerNotes]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_operatornotes = new BasicDAL.DbColumn("[OperatorNotes]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_severity = new BasicDAL.DbColumn("[Severity]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_priority = new BasicDAL.DbColumn("[Priority]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_description = new BasicDAL.DbColumn("[Description]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_requestername = new BasicDAL.DbColumn("[RequesterName]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_requesterphone = new BasicDAL.DbColumn("[RequesterPhone]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_reuquesteremail = new BasicDAL.DbColumn("[RequesterEmail]", System.Data.DbType.String, false, "");


        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_mnemoniccode
        {
            get { return _DbC_mnemoniccode; }
            set { _DbC_mnemoniccode = value; }
        }

        public BasicDAL.DbColumn DbC_creationdate
        {
            get { return _DbC_creationdate; }
            set { _DbC_creationdate = value; }
        }

        public BasicDAL.DbColumn DbC_creationtime
        {
            get { return _DbC_creationtime; }
            set { _DbC_creationtime = value; }
        }

        public BasicDAL.DbColumn DbC_creationoperatorid
        {
            get { return _DbC_creationoperatorid; }
            set { _DbC_creationoperatorid = value; }
        }

        public BasicDAL.DbColumn DbC_creationsource
        {
            get { return _DbC_creationsource; }
            set { _DbC_creationsource = value; }
        }

        public BasicDAL.DbColumn DbC_parentid
        {
            get { return _DbC_parentid; }
            set { _DbC_parentid = value; }
        }

        public BasicDAL.DbColumn DbC_status
        {
            get { return _DbC_status; }
            set { _DbC_status = value; }
        }

        public BasicDAL.DbColumn DbC_projectid
        {
            get { return _DbC_projectid; }
            set { _DbC_projectid = value; }
        }

        public BasicDAL.DbColumn DbC_customerid
        {
            get { return _DbC_customerid; }
            set { _DbC_customerid = value; }
        }

        public BasicDAL.DbColumn DbC_issuecategoryid
        {
            get { return _DbC_issuecategoryid; }
            set { _DbC_issuecategoryid = value; }
        }

        public BasicDAL.DbColumn DbC_customernotes
        {
            get { return _DbC_customernotes; }
            set { _DbC_customernotes = value; }
        }

        public BasicDAL.DbColumn DbC_operatornotes
        {
            get { return _DbC_operatornotes; }
            set { _DbC_operatornotes = value; }
        }

        public BasicDAL.DbColumn DbC_severity
        {
            get { return _DbC_severity; }
            set { _DbC_severity = value; }
        }

        public BasicDAL.DbColumn DbC_priority
        {
            get { return _DbC_priority; }
            set { _DbC_priority = value; }
        }

        public BasicDAL.DbColumn DbC_description
        {
            get { return _DbC_description; }
            set { _DbC_description = value; }
        }

        public BasicDAL.DbColumn DbC_requestername
        {
            get { return _DbC_requestername; }
            set { _DbC_requestername = value; }
        }

        public BasicDAL.DbColumn DbC_requesterphone
        {
            get { return _DbC_requesterphone; }
            set { _DbC_requesterphone = value; }
        }

        public BasicDAL.DbColumn DbC_requesteremail
        {
            get { return _DbC_reuquesteremail; }
            set { _DbC_reuquesteremail = value; }
        }
        public DbT_Tickets()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
            this.DbTableName = "Tickets";
        }
    }
    //------------------------------------------------------------------------------

    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_VendorCategories
    // Date   :25/03/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbT_VendorCategories : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, true, 0);
        private BasicDAL.DbColumn _DbC_mnemoniccode = new BasicDAL.DbColumn("[MnemonicCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_parentid = new BasicDAL.DbColumn("[ParentID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_description = new BasicDAL.DbColumn("[Description]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_notes = new BasicDAL.DbColumn("[Notes]", System.Data.DbType.String, false, "");

        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_mnemoniccode
        {
            get { return _DbC_mnemoniccode; }
            set { _DbC_mnemoniccode = value; }
        }

        public BasicDAL.DbColumn DbC_parentid
        {
            get { return _DbC_parentid; }
            set { _DbC_parentid = value; }
        }

        public BasicDAL.DbColumn DbC_description
        {
            get { return _DbC_description; }
            set { _DbC_description = value; }
        }

        public BasicDAL.DbColumn DbC_notes
        {
            get { return _DbC_notes; }
            set { _DbC_notes = value; }
        }

        #endregion

        public DbT_VendorCategories()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
            this.DbTableName = "VendorCategories";
        }
    }
    //------------------------------------------------------------------------------


    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_Vendors
    // Date   :01/04/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbT_Vendors : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, true, 0);
        private BasicDAL.DbColumn _DbC_mnemoniccode = new BasicDAL.DbColumn("[MnemonicCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_vendorcategoryid = new BasicDAL.DbColumn("[VendorCategoryID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_name = new BasicDAL.DbColumn("[Name]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_address = new BasicDAL.DbColumn("[Address]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_zip = new BasicDAL.DbColumn("[ZIP]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_city = new BasicDAL.DbColumn("[City]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_state = new BasicDAL.DbColumn("[State]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_country = new BasicDAL.DbColumn("[Country]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_phonenumber = new BasicDAL.DbColumn("[PhoneNumber]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_email = new BasicDAL.DbColumn("[Email]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_accountingcode = new BasicDAL.DbColumn("[AccountingCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_vatid = new BasicDAL.DbColumn("[VatID]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_taxid = new BasicDAL.DbColumn("[TaxID]", System.Data.DbType.String, false, "");

        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_mnemoniccode
        {
            get { return _DbC_mnemoniccode; }
            set { _DbC_mnemoniccode = value; }
        }

        public BasicDAL.DbColumn DbC_vendorcategoryid
        {
            get { return _DbC_vendorcategoryid; }
            set { _DbC_vendorcategoryid = value; }
        }

        public BasicDAL.DbColumn DbC_name
        {
            get { return _DbC_name; }
            set { _DbC_name = value; }
        }

        public BasicDAL.DbColumn DbC_address
        {
            get { return _DbC_address; }
            set { _DbC_address = value; }
        }

        public BasicDAL.DbColumn DbC_zip
        {
            get { return _DbC_zip; }
            set { _DbC_zip = value; }
        }

        public BasicDAL.DbColumn DbC_city
        {
            get { return _DbC_city; }
            set { _DbC_city = value; }
        }

        public BasicDAL.DbColumn DbC_state
        {
            get { return _DbC_state; }
            set { _DbC_state = value; }
        }

        public BasicDAL.DbColumn DbC_country
        {
            get { return _DbC_country; }
            set { _DbC_country = value; }
        }

        public BasicDAL.DbColumn DbC_phonenumber
        {
            get { return _DbC_phonenumber; }
            set { _DbC_phonenumber = value; }
        }

        public BasicDAL.DbColumn DbC_email
        {
            get { return _DbC_email; }
            set { _DbC_email = value; }
        }

        public BasicDAL.DbColumn DbC_accountingcode
        {
            get { return _DbC_accountingcode; }
            set { _DbC_accountingcode = value; }
        }

        public BasicDAL.DbColumn DbC_vatid
        {
            get { return _DbC_vatid; }
            set { _DbC_vatid = value; }
        }

        public BasicDAL.DbColumn DbC_taxid
        {
            get { return _DbC_taxid; }
            set { _DbC_taxid = value; }
        }

        #endregion

        public DbT_Vendors()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
            this.DbTableName = "Vendors";
        }
    }
    //------------------------------------------------------------------------------


    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbV_AssetCategoriesTree
    // Date   :23/03/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbV_AssetCategoriesTree : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_parentid = new BasicDAL.DbColumn("[ParentID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_description = new BasicDAL.DbColumn("[Description]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_mnemoniccode = new BasicDAL.DbColumn("[MnemonicCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_level = new BasicDAL.DbColumn("[Level]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_nodekey = new BasicDAL.DbColumn("[NodeKey]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_nodepath = new BasicDAL.DbColumn("[NodePath]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_codepath = new BasicDAL.DbColumn("[CodePath]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_nodekeypath = new BasicDAL.DbColumn("[NodeKeyPath]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_nodecodepath = new BasicDAL.DbColumn("[NodeCodePath]", System.Data.DbType.String, false, "");

        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_parentid
        {
            get { return _DbC_parentid; }
            set { _DbC_parentid = value; }
        }

        public BasicDAL.DbColumn DbC_description
        {
            get { return _DbC_description; }
            set { _DbC_description = value; }
        }

        public BasicDAL.DbColumn DbC_mnemoniccode
        {
            get { return _DbC_mnemoniccode; }
            set { _DbC_mnemoniccode = value; }
        }

        public BasicDAL.DbColumn DbC_level
        {
            get { return _DbC_level; }
            set { _DbC_level = value; }
        }

        public BasicDAL.DbColumn DbC_nodekey
        {
            get { return _DbC_nodekey; }
            set { _DbC_nodekey = value; }
        }

        public BasicDAL.DbColumn DbC_nodepath
        {
            get { return _DbC_nodepath; }
            set { _DbC_nodepath = value; }
        }

        public BasicDAL.DbColumn DbC_codepath
        {
            get { return _DbC_codepath; }
            set { _DbC_codepath = value; }
        }

        public BasicDAL.DbColumn DbC_nodekeypath
        {
            get { return _DbC_nodekeypath; }
            set { _DbC_nodekeypath = value; }
        }

        public BasicDAL.DbColumn DbC_nodecodepath
        {
            get { return _DbC_nodecodepath; }
            set { _DbC_nodecodepath = value; }
        }

        #endregion

        public DbV_AssetCategoriesTree()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.View;
            this.DbTableName = "AssetCategoriesTree";
        }
    }
    //------------------------------------------------------------------------------
    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbV_BrandCategoriesTree
    // Date   :23/03/2022
    // Author :
    //------------------------------------------------------------------------------


    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbV_BrandCategoriesTree
    // Date   :25/03/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbV_BrandCategoriesTree : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_parentid = new BasicDAL.DbColumn("[ParentID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_description = new BasicDAL.DbColumn("[Description]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_mnemoniccode = new BasicDAL.DbColumn("[MnemonicCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_level = new BasicDAL.DbColumn("[Level]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_nodekey = new BasicDAL.DbColumn("[NodeKey]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_nodepath = new BasicDAL.DbColumn("[NodePath]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_codepath = new BasicDAL.DbColumn("[CodePath]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_nodekeypath = new BasicDAL.DbColumn("[NodeKeyPath]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_nodecodepath = new BasicDAL.DbColumn("[NodeCodePath]", System.Data.DbType.String, false, "");

        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_parentid
        {
            get { return _DbC_parentid; }
            set { _DbC_parentid = value; }
        }

        public BasicDAL.DbColumn DbC_description
        {
            get { return _DbC_description; }
            set { _DbC_description = value; }
        }

        public BasicDAL.DbColumn DbC_mnemoniccode
        {
            get { return _DbC_mnemoniccode; }
            set { _DbC_mnemoniccode = value; }
        }

        public BasicDAL.DbColumn DbC_level
        {
            get { return _DbC_level; }
            set { _DbC_level = value; }
        }

        public BasicDAL.DbColumn DbC_nodekey
        {
            get { return _DbC_nodekey; }
            set { _DbC_nodekey = value; }
        }

        public BasicDAL.DbColumn DbC_nodepath
        {
            get { return _DbC_nodepath; }
            set { _DbC_nodepath = value; }
        }

        public BasicDAL.DbColumn DbC_codepath
        {
            get { return _DbC_codepath; }
            set { _DbC_codepath = value; }
        }

        public BasicDAL.DbColumn DbC_nodekeypath
        {
            get { return _DbC_nodekeypath; }
            set { _DbC_nodekeypath = value; }
        }

        public BasicDAL.DbColumn DbC_nodecodepath
        {
            get { return _DbC_nodecodepath; }
            set { _DbC_nodecodepath = value; }
        }

        #endregion

        public DbV_BrandCategoriesTree()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.View;
            this.DbTableName = "BrandCategoriesTree";
        }
    }
    //------------------------------------------------------------------------------

    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_IssueCategories
    // Date   :25/03/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbT_IssueCategories : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, true, 0);
        private BasicDAL.DbColumn _DbC_parentid = new BasicDAL.DbColumn("[ParentID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_mnemoniccode = new BasicDAL.DbColumn("[MnemonicCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_description = new BasicDAL.DbColumn("[Description]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_notes = new BasicDAL.DbColumn("[Notes]", System.Data.DbType.String, false, "");

        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_parentid
        {
            get { return _DbC_parentid; }
            set { _DbC_parentid = value; }
        }

        public BasicDAL.DbColumn DbC_mnemoniccode
        {
            get { return _DbC_mnemoniccode; }
            set { _DbC_mnemoniccode = value; }
        }

        public BasicDAL.DbColumn DbC_description
        {
            get { return _DbC_description; }
            set { _DbC_description = value; }
        }

        public BasicDAL.DbColumn DbC_notes
        {
            get { return _DbC_notes; }
            set { _DbC_notes = value; }
        }

        #endregion

        public DbT_IssueCategories()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
            this.DbTableName = "IssueCategories";
        }
    }
    //------------------------------------------------------------------------------


    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbV_IssueCategoriesTree
    // Date   :25/03/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbV_IssueCategoriesTree : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_parentid = new BasicDAL.DbColumn("[ParentID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_description = new BasicDAL.DbColumn("[Description]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_mnemoniccode = new BasicDAL.DbColumn("[MnemonicCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_level = new BasicDAL.DbColumn("[Level]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_nodekey = new BasicDAL.DbColumn("[NodeKey]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_nodepath = new BasicDAL.DbColumn("[NodePath]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_codepath = new BasicDAL.DbColumn("[CodePath]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_nodekeypath = new BasicDAL.DbColumn("[NodeKeyPath]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_nodecodepath = new BasicDAL.DbColumn("[NodeCodePath]", System.Data.DbType.String, false, "");

        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_parentid
        {
            get { return _DbC_parentid; }
            set { _DbC_parentid = value; }
        }

        public BasicDAL.DbColumn DbC_description
        {
            get { return _DbC_description; }
            set { _DbC_description = value; }
        }

        public BasicDAL.DbColumn DbC_mnemoniccode
        {
            get { return _DbC_mnemoniccode; }
            set { _DbC_mnemoniccode = value; }
        }

        public BasicDAL.DbColumn DbC_level
        {
            get { return _DbC_level; }
            set { _DbC_level = value; }
        }

        public BasicDAL.DbColumn DbC_nodekey
        {
            get { return _DbC_nodekey; }
            set { _DbC_nodekey = value; }
        }

        public BasicDAL.DbColumn DbC_nodepath
        {
            get { return _DbC_nodepath; }
            set { _DbC_nodepath = value; }
        }

        public BasicDAL.DbColumn DbC_codepath
        {
            get { return _DbC_codepath; }
            set { _DbC_codepath = value; }
        }

        public BasicDAL.DbColumn DbC_nodekeypath
        {
            get { return _DbC_nodekeypath; }
            set { _DbC_nodekeypath = value; }
        }

        public BasicDAL.DbColumn DbC_nodecodepath
        {
            get { return _DbC_nodecodepath; }
            set { _DbC_nodecodepath = value; }
        }

        #endregion

        public DbV_IssueCategoriesTree()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.View;
            this.DbTableName = "IssueCategoriesTree";
        }
    }
    //------------------------------------------------------------------------------


    //------------------------------------------------------------------------------
    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbV_VendorCategoriesTree
    // Date   :23/03/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbV_VendorCategoriesTree : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_parentid = new BasicDAL.DbColumn("[ParentID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_description = new BasicDAL.DbColumn("[Description]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_mnemoniccode = new BasicDAL.DbColumn("[MnemonicCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_level = new BasicDAL.DbColumn("[Level]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_nodekey = new BasicDAL.DbColumn("[NodeKey]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_nodepath = new BasicDAL.DbColumn("[NodePath]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_codepath = new BasicDAL.DbColumn("[CodePath]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_nodekeypath = new BasicDAL.DbColumn("[NodeKeyPath]", System.Data.DbType.String, false, "");

        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_parentid
        {
            get { return _DbC_parentid; }
            set { _DbC_parentid = value; }
        }

        public BasicDAL.DbColumn DbC_description
        {
            get { return _DbC_description; }
            set { _DbC_description = value; }
        }

        public BasicDAL.DbColumn DbC_mnemoniccode
        {
            get { return _DbC_mnemoniccode; }
            set { _DbC_mnemoniccode = value; }
        }

        public BasicDAL.DbColumn DbC_level
        {
            get { return _DbC_level; }
            set { _DbC_level = value; }
        }

        public BasicDAL.DbColumn DbC_nodekey
        {
            get { return _DbC_nodekey; }
            set { _DbC_nodekey = value; }
        }

        public BasicDAL.DbColumn DbC_nodepath
        {
            get { return _DbC_nodepath; }
            set { _DbC_nodepath = value; }
        }

        public BasicDAL.DbColumn DbC_codepath
        {
            get { return _DbC_codepath; }
            set { _DbC_codepath = value; }
        }

        public BasicDAL.DbColumn DbC_nodekeypath
        {
            get { return _DbC_nodekeypath; }
            set { _DbC_nodekeypath = value; }
        }

        #endregion

        public DbV_VendorCategoriesTree()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.View;
            this.DbTableName = "VendorCategoriesTree";
        }
    }
    //------------------------------------------------------------------------------
    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_MeasureUnits
    // Date   :24/03/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbT_MeasureUnits : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.String, true, "");
        private BasicDAL.DbColumn _DbC_description = new BasicDAL.DbColumn("[Description]", System.Data.DbType.String, false, "");

        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }


        public BasicDAL.DbColumn DbC_description
        {
            get { return _DbC_description; }
            set { _DbC_description = value; }
        }

        #endregion

        public DbT_MeasureUnits()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
            this.DbTableName = "MeasureUnits";
        }
    }
    //------------------------------------------------------------------------------

    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_BrandClasses
    // Date   :29/03/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbT_BrandClasses : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, true, 0);
        private BasicDAL.DbColumn _DbC_mnemoniccode = new BasicDAL.DbColumn("[MnemonicCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_parentid = new BasicDAL.DbColumn("[ParentID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_description = new BasicDAL.DbColumn("[Description]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_notes = new BasicDAL.DbColumn("[Notes]", System.Data.DbType.String, false, "");

        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_mnemoniccode
        {
            get { return _DbC_mnemoniccode; }
            set { _DbC_mnemoniccode = value; }
        }

        public BasicDAL.DbColumn DbC_parentid
        {
            get { return _DbC_parentid; }
            set { _DbC_parentid = value; }
        }

        public BasicDAL.DbColumn DbC_description
        {
            get { return _DbC_description; }
            set { _DbC_description = value; }
        }

        public BasicDAL.DbColumn DbC_notes
        {
            get { return _DbC_notes; }
            set { _DbC_notes = value; }
        }

        #endregion

        public DbT_BrandClasses()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
            this.DbTableName = "BrandClasses";
        }
    }
    //------------------------------------------------------------------------------

    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbV_BrandClassesTree
    // Date   :29/03/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbV_BrandClassesTree : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_parentid = new BasicDAL.DbColumn("[ParentID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_description = new BasicDAL.DbColumn("[Description]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_mnemoniccode = new BasicDAL.DbColumn("[MnemonicCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_level = new BasicDAL.DbColumn("[Level]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_nodekey = new BasicDAL.DbColumn("[NodeKey]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_nodepath = new BasicDAL.DbColumn("[NodePath]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_codepath = new BasicDAL.DbColumn("[CodePath]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_nodekeypath = new BasicDAL.DbColumn("[NodeKeyPath]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_nodecodepath = new BasicDAL.DbColumn("[NodeCodePath]", System.Data.DbType.String, false, "");

        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_parentid
        {
            get { return _DbC_parentid; }
            set { _DbC_parentid = value; }
        }

        public BasicDAL.DbColumn DbC_description
        {
            get { return _DbC_description; }
            set { _DbC_description = value; }
        }

        public BasicDAL.DbColumn DbC_mnemoniccode
        {
            get { return _DbC_mnemoniccode; }
            set { _DbC_mnemoniccode = value; }
        }

        public BasicDAL.DbColumn DbC_level
        {
            get { return _DbC_level; }
            set { _DbC_level = value; }
        }

        public BasicDAL.DbColumn DbC_nodekey
        {
            get { return _DbC_nodekey; }
            set { _DbC_nodekey = value; }
        }

        public BasicDAL.DbColumn DbC_nodepath
        {
            get { return _DbC_nodepath; }
            set { _DbC_nodepath = value; }
        }

        public BasicDAL.DbColumn DbC_codepath
        {
            get { return _DbC_codepath; }
            set { _DbC_codepath = value; }
        }

        public BasicDAL.DbColumn DbC_nodekeypath
        {
            get { return _DbC_nodekeypath; }
            set { _DbC_nodekeypath = value; }
        }

        public BasicDAL.DbColumn DbC_nodecodepath
        {
            get { return _DbC_nodecodepath; }
            set { _DbC_nodecodepath = value; }
        }

        #endregion

        public DbV_BrandClassesTree()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.View;
            this.DbTableName = "BrandClassesTree";
        }
    }
    //------------------------------------------------------------------------------

    
    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_DocumentSequence
    // Date   :16/05/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbT_DocumentSequence : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, true, 0);
        private BasicDAL.DbColumn _DbC_year = new BasicDAL.DbColumn("[Year]", System.Data.DbType.Int16, true, 0);
        private BasicDAL.DbColumn _DbC_documenttypeid = new BasicDAL.DbColumn("[DocumentTypeID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_sequencemask = new BasicDAL.DbColumn("[SequenceMask]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_lastvalue = new BasicDAL.DbColumn("[LastValue]", System.Data.DbType.String, false, "");

        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_year
        {
            get { return _DbC_year; }
            set { _DbC_year = value; }
        }

        public BasicDAL.DbColumn DbC_documenttypeid
        {
            get { return _DbC_documenttypeid; }
            set { _DbC_documenttypeid = value; }
        }

        public BasicDAL.DbColumn DbC_sequencemask
        {
            get { return _DbC_sequencemask; }
            set { _DbC_sequencemask = value; }
        }

        public BasicDAL.DbColumn DbC_lastvalue
        {
            get { return _DbC_lastvalue; }
            set { _DbC_lastvalue = value; }
        }

        #endregion

        public DbT_DocumentSequence()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
            this.DbTableName = "DocumentSequence";
        }
    }
    //------------------------------------------------------------------------------
    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_DocumentTypes
    // Date   :16/05/2022
    // Author :
    //------------------------------------------------------------------------------
    public class DbT_DocumentTypes : BasicDAL.DbObject
    {

        #region 'DbColumns'
        private BasicDAL.DbColumn _DbC_id = new BasicDAL.DbColumn("[ID]", System.Data.DbType.Int32, true, 0);
        private BasicDAL.DbColumn _DbC_mnemoniccode = new BasicDAL.DbColumn("[MnemonicCode]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_description = new BasicDAL.DbColumn("[Description]", System.Data.DbType.String, false, "");
        private BasicDAL.DbColumn _DbC_locationid = new BasicDAL.DbColumn("[LocationID]", System.Data.DbType.Int32, false, 0);
        private BasicDAL.DbColumn _DbC_documentfamily = new BasicDAL.DbColumn("[DocumentFamily]", System.Data.DbType.Byte, false, 0);
        private BasicDAL.DbColumn _DbC_notes = new BasicDAL.DbColumn("[Notes]", System.Data.DbType.String, false, "");

        public BasicDAL.DbColumn DbC_id
        {
            get { return _DbC_id; }
            set { _DbC_id = value; }
        }

        public BasicDAL.DbColumn DbC_mnemoniccode
        {
            get { return _DbC_mnemoniccode; }
            set { _DbC_mnemoniccode = value; }
        }

        public BasicDAL.DbColumn DbC_description
        {
            get { return _DbC_description; }
            set { _DbC_description = value; }
        }

        public BasicDAL.DbColumn DbC_locationid
        {
            get { return _DbC_locationid; }
            set { _DbC_locationid = value; }
        }

        public BasicDAL.DbColumn DbC_documentfamily
        {
            get { return _DbC_documentfamily; }
            set { _DbC_documentfamily = value; }
        }

        public BasicDAL.DbColumn DbC_notes
        {
            get { return _DbC_notes; }
            set { _DbC_notes = value; }
        }

        #endregion

        public DbT_DocumentTypes()
        {
            this.InterfaceMode = BasicDAL.InterfaceModeEnum.Private;
            this.DbObjectType = BasicDAL.DbObjectTypeEnum.Table;
            this.DbTableName = "DocumentTypes";
        }
    }
    //------------------------------------------------------------------------------


    //------------------------------------------------------------------------------
    // Class Definition for Table/View: DbT_dbo_TestTable
    // Date   :16/05/2022
    // Author :
    //------------------------------------------------------------------------------
    
    
    [BasicDAL .DbObjectAttributes(Name ="TestTable", FriendlyName ="CIAO")]
    public class DbT_dbo_TestTable

    {
        #region 'DbColumns'
        private System.Int32 _DbC_dbint;
        private System.String _DbC_dbstring;
        private System.DateTime _DbC_dbdate;
        private System.Double _DbC_dbfloat;
        private System.Boolean _DbC_dbbit;
        private System.String _DbC_dbstring1;
        private System.String _DbC_dbstring2;
        private System.String _DbC_dbstring3;
        public BasicDAL.DbObject DbObject;
               

        
        public System.Int32 DbC_dbint
        {
            get { return _DbC_dbint; }
            set { _DbC_dbint = value; }
        }

        [BasicDAL.DbColumnAttributes(Name ="A",FriendlyName="B",DefaultValue ="@Today",DbType = System.Data.DbType.String )]
        
        public System.String DbC_dbstring
        {
            get { return _DbC_dbstring; }
            set { _DbC_dbstring = value; }
        }

        public System.DateTime DbC_dbdate
        {
            get { return _DbC_dbdate; }
            set { _DbC_dbdate = value; }
        }

        public System.Double DbC_dbfloat
        {
            get { return _DbC_dbfloat; }
            set { _DbC_dbfloat = value; }
        }

        public System.Boolean DbC_dbbit
        {
            get { return _DbC_dbbit; }
            set { _DbC_dbbit = value; }
        }

        public System.String DbC_dbstring1
        {
            get { return _DbC_dbstring1; }
            set { _DbC_dbstring1 = value; }
        }

        public System.String DbC_dbstring2
        {
            get { return _DbC_dbstring2; }
            set { _DbC_dbstring2 = value; }
        }

        public System.String DbC_dbstring3
        {
            get { return _DbC_dbstring3; }
            set { _DbC_dbstring3 = value; }
        }

        #endregion

        public DbT_dbo_TestTable()
        {
        }
    }


    public class ActionsOnLocationInventory
    {
        System.Collections.Generic.Dictionary<string, string> Action = new System.Collections.Generic.Dictionary<string, string>
        {
            { "", "No Action" },
            { "=", "Set Equal" },
            { "+", "Increase" },
            { "-", "Decrease" }
        };
    }

    #region Enumerations

    public enum eManagementModes : int
    {
        [Description("Item Quantity")]
        Quantity = 0,
        [Description ("Single Item")]
        SingleItem = 1,
        [Description("Item Serial Number")]
        ItemSerialNumber = 2,
    }

    public enum eDocumentIssuerTypes : int
    {
        [Description("Self")]
        Self = 0,
        [Description("Customer")]
        Customer = 1,
        [Description("Owner")]
        Owner = 2,
        [Description("Vendor")]
        Vendor = 3,
        [Description("Other")]
        Other = 4
    }


    public enum eDocumentTypes : int
    {
        [Description("Delivery Note")]
        DeliveryNote = 0,
        [Description("Invoice")]
        Invoice = 1,
        [Description("Receipt")]
        Receipt = 2,
        [Description("Other")]
        Other = 3
        
    }


    public enum eRecordTypes : int
    {
        [Description("Manual")]
        Manual = 0,
        [Description("Automatic Secondary")]
        AutomaticSecondary = 1,
        [Description("Automatic Bill")]
        AutomaticBill = 2,
        [Description("Automatic Invoice")]
        AutomaticInvoice = 3,

    }

    public enum eActionsOnLocationInventory : int
{
    [Description("No Action"),DefaultValue("")]
    NoAction = 0,
    [Description("= Set Equal"), DefaultValue("=")]
    SetEqual = 1,
    [Description("+ Increase"), DefaultValue("+")]
    Increase = 2,
    [Description("- Decrease"), DefaultValue("-")]
    Decrease = 3,



}


    [DefaultValue(0)]
    public enum eTicketSeverity : int
    {

        [Description("Undefined"), ]
        Undefined = 0,

        [Description("Critical - Life or Money Lost") ]
        Critical=1,

        [Description("High - Broken Unusable")]
        High = 2,

        [Description("Medium - Workaround Possible")]
        Medium = 3,

        [Description("Low - Need Improvement")]
        Low = 4,

        [Description("Very Low - Cosmetic")]
        VeryLow = 5,

        
    }
    public enum eTicketPriority : int
    {
        [Description("Undefined")]
        Undefined = 0,

        [Description("Critical - Fix Now")]
        Critical = 1,

        [Description("High - Fix ASAP")]
        High = 2,

        [Description("Medium - Fix in a week")]
        Medium = 3,

        [Description("Low - Fix in planned mode")]
        Low = 4,

        [Description("Very Low - Fix if required")]
        VeryLow = 5,



    }
    public enum eBarcodeTypes 
    {
        [Description("EAN8")]
        EAN8,
        [Description("EAN13")]
        EAN13,
        [Description("EAN128")]
        EAN128,
        [Description ("UPCA")]
        UPCA,
        [Description("CODE39")]
        CODE39,
        [Description("CODE128")]
        CODE128,
        [Description("ITF")]
        ITF,
        [Description("CODABAR")]
        CODABAR,
        [Description("PLESSEY")]
        PLESSEY,
        [Description("MSI")]
        MSI,
        [Description("QRCODE")]
        QRCODE,
        [Description("PDF417")]
        PDF417,
        [Description("AZTEC")]
        AZTEC,
        [Description("DATAMATRIX")]
        DATAMATRIX,
    }
    #endregion 
}

