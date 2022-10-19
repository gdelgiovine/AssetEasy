using System;
using Wisej.Web;
using AssetEasy.DataModel;

namespace AssetEasy
{
    public partial class frmAssets : Form
    {

        public AppConfig appConfig = new AppConfig();
        private DbT_Assets dbT_Assets = new DbT_Assets();
        private DbT_AssetCategories dbT_AssetCategories = new DbT_AssetCategories();
        private DbV_AssetCategoriesTree dbV_AssetCategoriesTree = new DbV_AssetCategoriesTree();
        private DbT_BrandCategories dbT_BrandCategories = new DbT_BrandCategories();
        private DbV_BrandCategoriesTree  dbV_BrandCategoriesTree = new  DbV_BrandCategoriesTree ();
        private DbT_MeasureUnits dbT_MeasureUnits = new DbT_MeasureUnits();
        private DbT_Vendors dbT_Vendors = new DbT_Vendors();
        private DbT_Owners dbT_Owners = new DbT_Owners();
        private DbT_Locations dbT_Locations = new DbT_Locations(); 
        private DbT_AssetBarcodes dbT_AssetBarcodes = new DbT_AssetBarcodes();
        private DbT_Attachments dbT_Attachments = new DbT_Attachments();
        private DbT_VAT dbT_VAT = new DbT_VAT();

        private bool FormInit = false;
        private bool DataNavigatorHandlerInitialized = false;
        private int attachmentNewRowIndex = -1;

        // Declaration for CXMLSession Manager object. This object manage Out-of-Process Session State.
        //public CXMLSession.SessionManager SessionManager = new CXMLSession.SessionManager();
        //public CXMLSession.SessionStore SessionStore = new CXMLSession.SessionStore();

        private BasicDAL.DbConfig DbConfig = new BasicDAL.DbConfig();

        
        public frmAssets()
        {
            InitializeComponent();
        }


        private void InitDataContext(bool ForceFormInit = false)
        {
            if (ForceFormInit == true)
            {
                FormInit = false;
            }

            if (this.FormInit)
            {
                return;
            }
            //this.SessionStore.StoreMode = CXMLSession.SessionStore.StoreModes.MemoryMapped;
            //this.SessionStore.ID = Application.SessionId.ToString();

            this.DbConfig = this.appConfig.DbConfig.Clone();
            BasicDALWisejControls.BasicDALMessageBox BasicDALMessageBox = new BasicDALWisejControls.BasicDALMessageBox();
            //this.DbConfig.SuppressErrorsNotification = true;
            this.DbConfig.RedirectErrorsNotificationTo = BasicDALMessageBox;
            this.DbConfig.UseParallelism = false;
            InitDataNavigatorHandler();


            //binding for BasicDAL DbObject columns into UI objects.
            // EX: this.DbObject.dbstringcolumn.BoundControls.Add(this.txt_dbstringcolumn, "text");
            this.dbT_Assets.DbC_id.BoundControls.Add(this.txt_asset_id, "text", BasicDAL.BindingBehaviour.Read);
            this.dbT_Assets.DbC_mnemoniccode.BoundControls.Add(this.txt_asset_mnemoniccode, "text");
            this.dbT_Assets.DbC_description .BoundControls.Add(this.txt_asset_description, "text");
            this.dbT_Assets.DbC_managementmode.BoundControls.Add(this.cmb_asset_managementmode , "selectedvalue");
            this.dbT_Assets.DbC_measureunit.BoundControls.Add(this.cmb_asset_measureunit , "selectedvalue");
            this.dbT_Assets.DbC_assetcategoryid.BoundControls.Add(this.txt_asset_assetcategoryid, "value");
            this.dbT_Assets.DbC_brandcategoryid.BoundControls.Add(this.txt_asset_brandcategoryid , "value");
            this.dbT_Assets.DbC_vendorid.BoundControls.Add(this.txt_asset_vendorid, "value");
            this.dbT_Assets.DbC_serialnumber.BoundControls.Add(this.txt_asset_serialnumber, "text");
            this.dbT_Assets.DbC_accountingcode.BoundControls.Add(this.txt_asset_accountingcode, "text");
            this.dbT_Assets.DbC_partnumber.BoundControls.Add(this.txt_asset_partnumber, "text");
            this.dbT_Assets.DbC_vendorsku.BoundControls.Add(this.txt_asset_vendorsku, "text");
            this.dbT_Assets.DbC_notes.BoundControls.Add(this.txt_asset_notes, "text");
            this.dbT_Assets.DbC_vatcode.BoundControls.Add(this.cmb_Asset_VATCode, "selectedvalue");

            this.dbT_Assets.DbC_ownerid.BoundControls.Add(this.txt_asset_ownerid, "value");
            this.dbT_Assets.DbC_geolocationinfo.BoundControls.Add(this.txt_asset_geolocationinfo, "text");
            this.dbT_Assets.DbC_locationid.BoundControls.Add(this.txt_asset_locationid, "value");
            this.dbT_Assets.DbC_acquisitiondate.BoundControls.Add(this.dtp_asset_acquisitiondate, "value");
            this.dbT_Assets.DbC_acquisitioncost.BoundControls.Add(this.txt_asset_acquisitioncost, "text");
            this.dbT_Assets.DbC_depreciationrateyear .BoundControls.Add(this.txt_asset_depreciationrateyear , "text");



            // for tabbarcode readonly
            this.dbT_Assets.DbC_id.BoundControls.Add(this.txt_pnl_assetinfo_assetid , "text", BasicDAL.BindingBehaviour.Read);
            this.dbT_Assets.DbC_mnemoniccode.BoundControls.Add(this.txt_pnl_assetinfo_mnemoniccode, "text", BasicDAL.BindingBehaviour.Read );
            this.dbT_Assets.DbC_description.BoundControls.Add(this.txt_pnl_assetinfo_description, "text", BasicDAL.BindingBehaviour.Read );
            this.dbT_Assets.DbC_serialnumber.BoundControls.Add(this.txt_pnl_assetinfo_serialnumber, "text", BasicDAL.BindingBehaviour.Read );
            this.dbT_Assets.DbC_partnumber.BoundControls.Add(this.txt_pnl_assetinfo_partnumber, "text", BasicDAL.BindingBehaviour.Read );
            this.dbT_Assets.DbC_vendorsku.BoundControls.Add(this.txt_pnl_assetinfo_vendorsku, "text",BasicDAL.BindingBehaviour.Read );
            this.dbT_Assets.DbC_accountingcode.BoundControls.Add(this.txt_pnl_assetinfo_accountingcode, "text", BasicDAL.BindingBehaviour.Read);




            // Validator Example
            //this.DbObject.dbstringcolumn.ValidationType = BasicDAL.ValidationTypes.Equal;
            //this.DbObject.dbstringcolumn.ValidationExpression = "A";
            //this.DbObject.dbstringcolumn.ValidationMessage = "ERROR!!!";
            //this.DbObject.dbstringcolumn.ValidationDataType = BasicDAL.ValidationDataType.String;
            // EX: map a POCO entity 
            //System.ComponentModel.BindingList<poco_dbo_TestTable> poco = new System.ComponentModel.BindingList<poco_dbo_TestTable>();

            //Initialize a DBObject
            this.dbT_Assets.Init(this.DbConfig.Clone());
            this.dbT_Assets.DataBinding = BasicDAL.DataBoundControlsBehaviour.BasicDALDataBinding;
            this.dbT_MeasureUnits.Init(this.DbConfig);
            this.dbT_BrandCategories.Init(this.DbConfig);
            this.dbV_BrandCategoriesTree.Init(this.DbConfig);
            this.dbV_BrandCategoriesTree.OrderBy = this.dbV_BrandCategoriesTree.DbC_codepath.DbColumnNameE;
            this.dbT_AssetCategories.Init(this.DbConfig);
            this.dbV_AssetCategoriesTree.Init(this.DbConfig);
            this.dbV_AssetCategoriesTree.OrderBy = this.dbV_AssetCategoriesTree.DbC_codepath.DbColumnNameE;
            this.dbT_Vendors.Init(DbConfig);
            this.dbT_AssetBarcodes.Init(this.DbConfig.Clone());
            this.dbT_Attachments.Init(this.DbConfig);
            this.dbT_Owners.Init(this.DbConfig);
            this.dbT_Locations.Init(this.DbConfig);
            this.dbT_VAT.Init(this.DbConfig);


            this.cmb_asset_managementmode.DataSource = Utilities.EnumToDataTable(typeof(eManagementModes), Utilities.EnumToDataTableValueItem.Value, Utilities.EnumToDataTableDisplayItem.ValueDescription );
            this.cmb_asset_managementmode.ValueMember = "id";
            this.cmb_asset_managementmode.DisplayMember = "desc";

            this.dgvc_barcodetype.DataSource = Utilities.EnumToDataTable(typeof(eBarcodeTypes), Utilities.EnumToDataTableDisplayItem.ValueName, Utilities.EnumToDataTableDisplayItem.Description );
            this.dgvc_barcodetype.ValueMember = "id";
            this.dgvc_barcodetype.DisplayMember = "desc";

            BasicDALWisejControls.Utilities.BoundComboBoxItemsToDbObject(this.cmb_asset_measureunit, this.dbT_MeasureUnits, this.dbT_MeasureUnits.DbC_description.DbColumnNameE, this.dbT_MeasureUnits.DbC_id.DbColumnNameE, true, DBNull.Value);
            BasicDALWisejControls.Utilities.BoundComboBoxItemsToDbObject(this.cmb_Asset_VATCode, this.dbT_VAT, this.dbT_VAT.DbC_description.DbColumnNameE, this.dbT_VAT.DbC_id.DbColumnNameE, true, DBNull.Value);


            // Declare of DbLookUp 
            //BasicDAL.DbLookUp DbL_Lookup = new BasicDAL.DbLookUp();
            //this.DbL_LookUp.DbObject = this.DbObjectToQuery;
            //this.DbL_LookUp.Filters.AddBoundControl(this.DbObjectToQuery.ID, BasicDAL.ComparisionOperator.Equal, this.txt_ID, "text", BasicDAL.LogicOperator.None);
            //this.DbL_LookUp.BoundControls.Add(this.DbObjectToQuery.Name, this.lbl_Name, "text");

            this.txt_asset_assetcategoryid.DbLookup.DbObject = this.dbV_AssetCategoriesTree;
            this.txt_asset_assetcategoryid.DisplayMember = this.dbV_AssetCategoriesTree.DbC_codepath.DbColumnNameE;
            this.txt_asset_assetcategoryid.ValueMember = this.dbV_AssetCategoriesTree.DbC_id.DbColumnNameE;
            this.txt_asset_assetcategoryid.DbLookup.BoundControls.Add(this.dbV_AssetCategoriesTree.DbC_nodepath  , this.txt_assetcategories_description , "text");
            this.txt_asset_assetcategoryid.DbLookup.BoundControls.Add(this.dbV_AssetCategoriesTree.DbC_id, this.txt_assetcategories_id, "text");
            this.txt_asset_assetcategoryid.DbLookup.BoundControls.Add(this.dbV_AssetCategoriesTree.DbC_level, this.txt_assetcategories_level, "text");

            this.txt_asset_brandcategoryid.DbLookup.DbObject = this.dbV_BrandCategoriesTree;
            this.txt_asset_brandcategoryid.DisplayMember =  this.dbV_BrandCategoriesTree.DbC_codepath.DbColumnNameE;
            this.txt_asset_brandcategoryid.ValueMember = this.dbV_BrandCategoriesTree.DbC_id.DbColumnNameE;
            this.txt_asset_brandcategoryid.DbLookup.BoundControls.Add(this.dbV_BrandCategoriesTree.DbC_nodepath, this.txt_brandcategories_description, "text");
            this.txt_asset_brandcategoryid.DbLookup.BoundControls.Add(this.dbV_BrandCategoriesTree.DbC_id, this.txt_brandcategories_id, "text");
            this.txt_asset_brandcategoryid.DbLookup.BoundControls.Add(this.dbV_BrandCategoriesTree.DbC_level, this.txt_brandcategories_level, "text");

            this.txt_asset_vendorid.DbLookup.DbObject = this.dbT_Vendors;
            this.txt_asset_vendorid.DisplayMember = this.dbT_Vendors.DbC_id.DbColumnNameE;
            this.txt_asset_vendorid.ValueMember = this.dbT_Vendors.DbC_id.DbColumnNameE;
            this.txt_asset_vendorid.DbLookup.BoundControls.Add(this.dbT_Vendors.DbC_name, this.txt_vendors_name , "text");
            
            this.txt_asset_ownerid.DbLookup.DbObject = this.dbT_Owners;
            this.txt_asset_ownerid.DisplayMember = this.dbT_Owners.DbC_id.DbColumnNameE;
            this.txt_asset_ownerid.ValueMember = this.dbT_Owners.DbC_id.DbColumnNameE;
            this.txt_asset_ownerid.DbLookup.BoundControls.Add(this.dbT_Owners.DbC_name, this.txt_owners_name, "text");

            this.txt_asset_locationid.DbLookup.DbObject = this.dbT_Locations;
            this.txt_asset_locationid.DisplayMember = this.dbT_Locations.DbC_id.DbColumnNameE;
            this.txt_asset_locationid.ValueMember = this.dbT_Locations.DbC_id.DbColumnNameE;
            this.txt_asset_locationid.DbLookup.BoundControls.Add(this.dbT_Locations.DbC_name, this.txt_locations_name, "text");



            // l'aggiornamento batch va disabilitato quando un oggetto database (DbObject) viene associato ad una griglia e si vuole aggiornare tutti i dati modificati nella griglia
            // in questo caso vogliamo salvare tutte le modifiche fatte nella griglia della righe articolo.
            //this.DbT_RigheNonConformitaDDT.UpdateBatchEnabled = false;
            // this.DbT_NonConformitaDDT.LoadAll();


            //this.LoadComboBrandCategoryTreeView();
            //this.LoadComboAssetCategoryTreeView();

            //BasicDALWisejControls.Utilities.BoundComboBoxItemsToDbObject(this.cmb_asset_brandcategoryid, this.dbV_BrandCategoriesTree, this.dbV_BrandCategoriesTree.DbC_nodecodepath.DbColumnNameE, this.dbV_BrandCategoriesTree.DbC_id.DbColumnNameE);
            //BasicDALWisejControls.Utilities.BoundComboBoxItemsToDbObject(this.cmb_asset_assetcategoryid, this.dbV_AssetCategoriesTree, this.dbV_AssetCategoriesTree.DbC_nodecodepath.DbColumnNameE, this.dbV_AssetCategoriesTree.DbC_id.DbColumnNameE);



            this.dataNavigator1.DbObject = this.dbT_Assets;
            // non gestisco automaticamente la navigazione (debbo quindi gestire il codice negli eventi)
            this.dataNavigator1.ManageNavigation = false;
            // associo la griglia delle righe articolo al datanavigator
            //this.dataNavigator1.DataGrid = this.dgv_RigheNC;
            // tuttavia la griglia non è attiva. Si attiva solo se viene premuto il bottone "Articoli NC"

            this.dataNavigator1.DataGridActive = false;
            this.dataNavigator1.InitDataNavigator();
            this.dbT_Assets.Open(true);
            this.Accelerators = this.dataNavigator1.Accelerators ;


        }


        private void qbe_Owners()
        {
            DbT_Owners  QBEDbObject = new DbT_Owners();
            QBEDbObject.Init(this.DbConfig);
            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.BoundControls;
            QBEForm.Text = "Search for Owners";
            QBEForm.DbObject = QBEDbObject;
            QBEForm.AutoLoadAll = true;
            QBEForm.BoundControls.Add(QBEDbObject.DbC_id, this.txt_asset_ownerid, "text");
            ////QBEForm.QBEColumns.Add(QBEDbObject.dbint, "DB INT", "", "1", true, true);
            QBEForm.ShowQBE(this);
        }

        private void qbe_Vendors()
        {
            DbT_Vendors QBEDbObject = new DbT_Vendors();
            QBEDbObject.Init(this.DbConfig);
            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.BoundControls;
            QBEForm.Text = "Search for Vendors";
            QBEForm.DbObject = QBEDbObject;
            QBEForm.AutoLoadAll = true;
            QBEForm.BoundControls.Add(QBEDbObject.DbC_id, this.txt_asset_vendorid, "text");
            ////QBEForm.QBEColumns.Add(QBEDbObject.dbint, "DB INT", "", "1", true, true);
            QBEForm.ShowQBE(this);
        }

        private void qbe_Locations()
        {
            DbT_Locations  QBEDbObject = new  DbT_Locations ();
            QBEDbObject.Init(this.DbConfig);
            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.BoundControls;
            QBEForm.Text = "Search for Locations";
            QBEForm.DbObject = QBEDbObject;
            QBEForm.AutoLoadAll = true;
            QBEForm.BoundControls.Add(QBEDbObject.DbC_id, this.txt_asset_locationid, "text");
            QBEForm.ShowQBE(this);
        }

        private void qbe_AssetCategories()
        {
            DbV_AssetCategoriesTree QBEDbObject = new DbV_AssetCategoriesTree();
            QBEDbObject.OrderBy = QBEDbObject.DbC_codepath.DbColumnNameE;
            QBEDbObject.Init(this.DbConfig);
            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.BoundControls;
            QBEForm.Text = "Search for Asset Categories";
            QBEForm.DbObject = QBEDbObject;
            QBEForm.AutoLoadAll = true;
            QBEForm.BoundControls.Add(QBEDbObject.DbC_codepath , this.txt_asset_assetcategoryid, "text");
            QBEForm.QBEColumns.Add(QBEDbObject.DbC_codepath , "Category", "", "", true,true,-1);
            QBEForm.QBEColumns.Add(QBEDbObject.DbC_nodepath, "Description", "", "", true,true,-2);
          //  QBEForm.QBEColumns.GetItem(QBEDbObject.DbC_codepath).ForeColor = System.Drawing.Color.Red;
            QBEForm.QBEColumns.GetItem(QBEDbObject.DbC_codepath).FontStyle = System.Drawing.FontStyle.Bold; 
            QBEForm.ShowQBE(this);
        }

        private void qbe_BrandCategories()
        {
            DbV_BrandCategoriesTree QBEDbObject = new DbV_BrandCategoriesTree();
            QBEDbObject.Init(this.DbConfig);
            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.BoundControls;
            QBEForm.Text = "Search for Brand Categories";
            QBEForm.DbObject = QBEDbObject;
            QBEForm.AutoLoadAll = true;
            QBEForm.BoundControls.Add(QBEDbObject.DbC_codepath, this.txt_asset_brandcategoryid, "text");
            QBEForm.QBEColumns.Add(QBEDbObject.DbC_codepath, "Category", "", "", true, true, -1);
            QBEForm.QBEColumns.Add(QBEDbObject.DbC_nodepath, "Description", "", "", true, true, -2);
            ////QBEForm.QBEColumns.Add(QBEDbObject.dbint, "DB INT", "", "1", true, true);
            QBEForm.ShowQBE(this);
        }





        private void LoadComboBrandCategoryTreeView(string selectedNodeName = "")
        {
            //this.dbV_BrandCategoriesTree.FiltersGroup.Clear();
            //this.dbV_BrandCategoriesTree.Open(true);
            //this.tvc_asset_brandcategoryid .Nodes.Clear();
            //this.tvc_asset_brandcategoryid.Nodes.Add("0", "0 - NO PARENT");
            //AssetEasy.Utilities.TreeViewComboBoxLoad(ref this.tvc_asset_brandcategoryid, DBNull.Value, null, this.dbV_BrandCategoriesTree.DataTable, "ID", "ParentID", "NodePath", "CodePath", "Level, CodePath");
            //if (selectedNodeName != null)
            //{
            //    TreeNode node = AssetEasy.Utilities.GetTreeNodeByName(this.tvc_asset_brandcategoryid.Nodes, selectedNodeName);
            //    if (node != null)
            //        this.tvc_asset_brandcategoryid.SelectedItem = node;
            //}

        }

        private void LoadComboAssetCategoryTreeView(string selectedNodeName = "")
        {
            //this.dbV_AssetCategoriesTree.FiltersGroup.Clear();
            //this.dbV_AssetCategoriesTree.Open(true);
            //this.tvc_asset_assetcategoryid.Nodes.Clear();
            //this.tvc_asset_assetcategoryid.Nodes.Add("0", "0 - NO PARENT");
            //AssetEasy.Utilities.TreeViewComboBoxLoad(ref this.tvc_asset_assetcategoryid, DBNull.Value, null, this.dbV_AssetCategoriesTree.DataTable, "ID", "ParentID", "NodePath", "CodePath", "Level, CodePath");
            //if (selectedNodeName != null)
            //{
            //    TreeNode node = AssetEasy.Utilities.GetTreeNodeByName(this.tvc_asset_assetcategoryid.Nodes, selectedNodeName);
            //    if (node != null)
            //        this.tvc_asset_assetcategoryid.SelectedItem = node;
            //}

        }

        private void InitDataNavigatorHandler()
        {
            // Declare Events Handlers for DataNavigator
            if (DataNavigatorHandlerInitialized == true)
            {
                return;
            }

            this.dataNavigator1.eAddNew -= new BasicDALWisejControls.DataNavigator.eAddNewEventHandler(this.dataNavigator1_eAddNew);
            this.dataNavigator1.eAddNew += new BasicDALWisejControls.DataNavigator.eAddNewEventHandler(this.dataNavigator1_eAddNew);
            this.dataNavigator1.ePrint -= new BasicDALWisejControls.DataNavigator.ePrintEventHandler(this.dataNavigator1_ePrint);
            this.dataNavigator1.ePrint += new BasicDALWisejControls.DataNavigator.ePrintEventHandler(this.dataNavigator1_ePrint);
            this.dataNavigator1.eDelete -= new BasicDALWisejControls.DataNavigator.eDeleteEventHandler(this.dataNavigator1_eDelete);
            this.dataNavigator1.eDelete += new BasicDALWisejControls.DataNavigator.eDeleteEventHandler(this.dataNavigator1_eDelete);
            this.dataNavigator1.eRefresh -= new BasicDALWisejControls.DataNavigator.eRefreshEventHandler(this.dataNavigator1_eRefresh);
            this.dataNavigator1.eRefresh += new BasicDALWisejControls.DataNavigator.eRefreshEventHandler(this.dataNavigator1_eRefresh);
            this.dataNavigator1.eClose -= new BasicDALWisejControls.DataNavigator.eCloseEventHandler(this.dataNavigator1_eClose);
            this.dataNavigator1.eClose += new BasicDALWisejControls.DataNavigator.eCloseEventHandler(this.dataNavigator1_eClose);
            this.dataNavigator1.eFind -= new BasicDALWisejControls.DataNavigator.eFindEventHandler(this.dataNavigator1_eFind);
            this.dataNavigator1.eFind += new BasicDALWisejControls.DataNavigator.eFindEventHandler(this.dataNavigator1_eFind);
            this.dataNavigator1.eSave -= new BasicDALWisejControls.DataNavigator.eSaveEventHandler(this.dataNavigator1_eSave);
            this.dataNavigator1.eSave += new BasicDALWisejControls.DataNavigator.eSaveEventHandler(this.dataNavigator1_eSave);
            this.dataNavigator1.eMovePrevious -= new BasicDALWisejControls.DataNavigator.eMovePreviousEventHandler(this.dataNavigator1_eMovePrevious);
            this.dataNavigator1.eMovePrevious += new BasicDALWisejControls.DataNavigator.eMovePreviousEventHandler(this.dataNavigator1_eMovePrevious);
            this.dataNavigator1.eMoveFirst -= new BasicDALWisejControls.DataNavigator.eMoveFirstEventHandler(this.dataNavigator1_eMoveFirst);
            this.dataNavigator1.eMoveFirst += new BasicDALWisejControls.DataNavigator.eMoveFirstEventHandler(this.dataNavigator1_eMoveFirst);
            this.dataNavigator1.eMoveLast -= new BasicDALWisejControls.DataNavigator.eMoveLastEventHandler(this.dataNavigator1_eMoveLast);
            this.dataNavigator1.eMoveLast += new BasicDALWisejControls.DataNavigator.eMoveLastEventHandler(this.dataNavigator1_eMoveLast);
            this.dataNavigator1.eMoveNext -= new BasicDALWisejControls.DataNavigator.eMoveNextEventHandler(this.dataNavigator1_eMoveNext);
            this.dataNavigator1.eMoveNext += new BasicDALWisejControls.DataNavigator.eMoveNextEventHandler(this.dataNavigator1_eMoveNext);
            this.dataNavigator1.eUndo -= new BasicDALWisejControls.DataNavigator.eUndoEventHandler(this.dataNavigator1_eUndo);
            this.dataNavigator1.eUndo += new BasicDALWisejControls.DataNavigator.eUndoEventHandler(this.dataNavigator1_eUndo);

            // REQUEST viene emesso PRIMA che l'operazione venga effettuata sui dati.
            //this.dataNavigator1.eAddNewRequest -= new BasicDALWisejControls.DataNavigator.eAddNewRequestEventHandler(this.dataNavigator1_eAddNewRequest);
            //this.dataNavigator1.ePrintRequest -= new BasicDALWisejControls.DataNavigator.ePrintRequestEventHandler(this.dataNavigator1_ePrintRequest);
            //this.dataNavigator1.eDeleteRequest -= new BasicDALWisejControls.DataNavigator.eDeleteRequestEventHandler(this.dataNavigator1_eDeleteRequest);
            //this.dataNavigator1.eRefreshRequest -= new BasicDALWisejControls.DataNavigator.eRefreshRequestEventHandler(this.dataNavigator1_eRefreshRequest);
            //this.dataNavigator1.eCloseRequest -= new BasicDALWisejControls.DataNavigator.eCloseRequestEventHandler(this.dataNavigator1_eCloseRequest);
            //this.dataNavigator1.eFindRequest -= new BasicDALWisejControls.DataNavigator.eFindRequestEventHandler(this.dataNavigator1_eFindRequest);
            //this.dataNavigator1.eSaveRequest -= new BasicDALWisejControls.DataNavigator.eSaveRequestEventHandler(this.dataNavigator1_eSaveRequest);
            //this.dataNavigator1.eMovePreviousRequest -= new BasicDALWisejControls.DataNavigator.eMovePreviousRequestEventHandler(this.dataNavigator1_eMovePreviousRequest);
            //this.dataNavigator1.eMoveFirstRequest -= new BasicDALWisejControls.DataNavigator.eMoveFirstRequestEventHandler(this.dataNavigator1_eMoveFirstRequest);
            //this.dataNavigator1.eMoveLastRequest -= new BasicDALWisejControls.DataNavigator.eMoveLastRequestEventHandler(this.dataNavigator1_eMoveLastRequest);
            //this.dataNavigator1.eMoveNextRequest -= new BasicDALWisejControls.DataNavigator.eMoveNextRequestEventHandler(this.dataNavigator1_eMoveNextRequest);
            //this.dataNavigator1.eUndoRequest -= new BasicDALWisejControls.DataNavigator.eUndoRequestEventHandler(this.dataNavigator1_eUndoRequest);

            //this.dataNavigator1.eAddNewRequest += new BasicDALWisejControls.DataNavigator.eAddNewRequestEventHandler(this.dataNavigator1_eAddNewRequest);
            //this.dataNavigator1.ePrintRequest += new BasicDALWisejControls.DataNavigator.ePrintRequestEventHandler(this.dataNavigator1_ePrintRequest);
            //this.dataNavigator1.eDeleteRequest += new BasicDALWisejControls.DataNavigator.eDeleteRequestEventHandler(this.dataNavigator1_eDeleteRequest);
            //this.dataNavigator1.eRefreshRequest += new BasicDALWisejControls.DataNavigator.eRefreshRequestEventHandler(this.dataNavigator1_eRefreshRequest);
            //this.dataNavigator1.eCloseRequest += new BasicDALWisejControls.DataNavigator.eCloseRequestEventHandler(this.dataNavigator1_eCloseRequest);
            //this.dataNavigator1.eFindRequest += new BasicDALWisejControls.DataNavigator.eFindRequestEventHandler(this.dataNavigator1_eFindRequest);
            //this.dataNavigator1.eSaveRequest += new BasicDALWisejControls.DataNavigator.eSaveRequestEventHandler(this.dataNavigator1_eSaveRequest);
            //this.dataNavigator1.eMovePreviousRequest += new BasicDALWisejControls.DataNavigator.eMovePreviousRequestEventHandler(this.dataNavigator1_eMovePreviousRequest);
            //this.dataNavigator1.eMoveFirstRequest += new BasicDALWisejControls.DataNavigator.eMoveFirstRequestEventHandler(this.dataNavigator1_eMoveFirstRequest);
            //this.dataNavigator1.eMoveLastRequest += new BasicDALWisejControls.DataNavigator.eMoveLastRequestEventHandler(this.dataNavigator1_eMoveLastRequest);
            //this.dataNavigator1.eMoveNextRequest += new BasicDALWisejControls.DataNavigator.eMoveNextRequestEventHandler(this.dataNavigator1_eMoveNextRequest);
            //this.dataNavigator1.eUndoRequest += new BasicDALWisejControls.DataNavigator.eUndoRequestEventHandler(this.dataNavigator1_eUndoRequest);

            DataNavigatorHandlerInitialized = true;
        }
        private void Window1_Load(object sender, EventArgs e)
        {
            InitDataContext();
        }


        private void ManageTabDataNavigator(string Item)
        {
            switch (Item.ToLower())
            {
                case "tabform":
                    this.dataNavigator1.DbObject = this.dbT_Assets;
                    this.dataNavigator1.Caption = "Assets";
                    this.dataNavigator1.DataGrid = null;
                    this.dataNavigator1.DataGridActive = false;
                    this.dataNavigator1.SetDataNavigator();
                    break;

                case "tablist":
                    this.dataNavigator1.DbObject = this.dbT_Assets;
                    this.dataNavigator1.DataGrid = null;
                    this.dataNavigator1.DataGridActive = false;
                    break;

                case "tabnotes":
                    movepnlAssetInfo(this.tabNotes);
                    this.dataNavigator1.DbObject = this.dbT_Assets;
                    this.dataNavigator1.Caption = "Assets";
                    this.dataNavigator1.DataGrid = null;
                    this.dataNavigator1.DataGridActive = false;
                    this.dataNavigator1.SetDataNavigator();
                    break;

                case "tabgeolocation":
                    movepnlAssetInfo(this.tabGeoLocation );
                    this.dataNavigator1.DbObject = this.dbT_Assets;
                    this.dataNavigator1.Caption = "Assets";
                    this.dataNavigator1.DataGrid = null;
                    this.dataNavigator1.DataGridActive = false;
                    this.dataNavigator1.SetDataNavigator();
                    break;


                case "tabattachments":
                    movepnlAssetInfo(this.tabAttachments );
                    this.dataNavigator1.Caption = "Asset Attachments";
                    this.dataNavigator1.DbObject = this.dbT_Attachments ;
                    this.dataNavigator1.DataGrid = this.dgv_Attachments ;
                    LoadAssetAttachments();
                    this.dataNavigator1.DataGridActive = true;
                    this.dataNavigator1.SetDataNavigator();

                    break;

                case "tabbarcodes":
                    movepnlAssetInfo(this.tabBarcodes);
                    this.dataNavigator1.Caption = "Asset Barcodes";
                    this.dataNavigator1.DbObject = this.dbT_AssetBarcodes ;
                    this.dataNavigator1.DataGrid = this.dgv_AssetBarcodes;
                    LoadAssetBarcodes();
                    this.dataNavigator1.DataGridActive = true;
                    this.dataNavigator1.SetDataNavigator();
                    break;

                default:
                    break;
            }
        }

        private void movepnlAssetInfo(TabPage destinationtab)
        {
            if (this.pnlAssetInfo.Parent.Name == destinationtab.Name)
                return;

            this.pnlAssetInfo.Parent.Controls.Remove(this.pnlAssetInfo );
            destinationtab.Controls.Add(this.pnlAssetInfo);

        }
        private void dataNavigator1_eFind()
        {

            //DbT_DbObjectToQuery QBEDbObject = new DbT_DbObjectToQuery();
            //QBEDbObject.Init(this.DbConfig);

            //BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();
            //QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            //QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.SelectedRows;// ' torna tutte le righe selezionate
            //QBEForm.CallerForm = this;
            //QBEForm.Text = "Search for " + this.Text;

            //QBEForm.DbObject = QBEDbObject;
            ////QBEForm.QueryDbObject = this.DbT_DbObjectOnCallingForm;
            //QBEForm.AutoLoadAll = true;
            ////QBEForm.DbColumnsMapping.Add(QBEDbObject.idnonconformita, this.DbT_NonConformitaDDT.idnonconformita);
            ////QBEForm.QBEColumns.Add(QBEDbObject.dbint, "DB INT", "", "1", true, true);
            //QBEForm.ShowQBE(this);

        }

        private void dataNavigator1_ePrint()
        {

            //DbT_DbObjectToPrint QBEDbObject = new DbT_DbObjectToPrint();
            //QBEDbObject.Init(this.DbConfig);

            //BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();
            //QBEForm.Mode = BasicDALWisejControls.QbeMode.Report;
            //QBEForm.ReportsPath = @"<pathofreports>" // ex: @"C:\WisejDemo\WisejDemo\Reports";
            ////QBEForm.AddReport("Report","Report.rpt", "Descrizione del report");

            ////QBEForm.DefaultReport= QBEForm .Reports["Report"];
            ////QBEForm.Text = "Stampa " + this.Text;
            ////QBEForm.ReportViewerMode = BasicDALWisejControls.ReportViewerMode.PDFStream;
            //QBEForm.CrystalReportViewerPage = Application.StartupUrl + "CrystalReportViewer.aspx";
            //QBEForm.DbObject = QBEDbObject;

            //QBEForm.ShowQBE(this);

        }

        private void dataNavigator1_eAddNew()
        {
            if (this.dataNavigator1.DataGridActive == false)
            {
                this.dataNavigator1.DbObject.AddNew();
            }
            else
            {
                
                if (this.dataNavigator1.DataGrid != null)
                {
                    if (this.dataNavigator1.DataGrid.Name == this.dgv_AssetBarcodes.Name)
                    {
                        this.dataNavigator1.DataGrid_AddNew();
                        this.dgv_AssetBarcodes.CurrentRow[this.dgvc_barcode_assetid].Value = this.txt_asset_id.Text;
                        this.dgv_AssetBarcodes.CurrentRow[this.dgvc_barcode_qty].Value = 1;
                        this.dgv_AssetBarcodes.CurrentRow[this.dgvc_barcode_enabled].Value = true;
                    }

                    if (this.dataNavigator1.DataGrid.Name == this.dgv_Attachments.Name)
                    {
                        this.dataNavigator1.DataGrid_AddNew();
                        this.uploadAttachment.Tag = null;
                        this.attachmentNewRowIndex = this.dgv_Attachments.CurrentRow.Index;
                        this.dgv_Attachments.CurrentRow[this.dgvc_attachments_parentobjecttype].Value = "ASSET";
                        this.dgv_Attachments.CurrentRow[this.dgvc_attachments_parentobjectid].Value = this.txt_asset_id.Text;
                        this.dgv_Attachments.CurrentRow[this.dgvc_attachments_uniquefilename].Value = System.Guid.NewGuid ().ToString ();
                        
                    }

                }
            }
        }

        private void dataNavigator1_eClose()
        {
            this.Close();
        }

        private void dataNavigator1_eDelete()
        {
            if (this.dataNavigator1.DataGridActive == false)
            {
                this.dataNavigator1.DbObject.Delete();
            }
            else
            {
                if (this.dataNavigator1.DataGrid != null)
                {
                    if (this.dataNavigator1.DbObject.Name == this.dbT_Attachments.Name)
                    {
                        System.IO.File.Delete(this.GetAttachmentRealFileName(this.dgv_Attachments.CurrentRow));
                    }
                    this.dataNavigator1.DataGrid_Delete();
                    
                }
            }
        }

        private void dataNavigator1_eMoveFirst()
        {
            if (this.dataNavigator1.DataGridActive == false)
            {
                this.dataNavigator1.DbObject.MoveFirst();
            }
            else
            {
                if (this.dataNavigator1.DataGrid != null)
                    this.dataNavigator1.DataGrid_MoveFirst();
            }

        }

        private void dataNavigator1_eMoveLast()
        {

            if (this.dataNavigator1.DataGridActive == false)
            {
                this.dataNavigator1.DbObject.MoveLast();
            }
            else
            {
                if (this.dataNavigator1.DataGrid != null)
                    this.dataNavigator1.DataGrid_MoveLast();
            }
        }

        private void dataNavigator1_eMoveNext()
        {
            if (this.dataNavigator1.DataGridActive == false)
            {
                this.dataNavigator1.DbObject.MoveNext();
            }
            else
            {
                if (this.dataNavigator1.DataGrid != null)
                    this.dataNavigator1.DataGrid_MoveNext();
            }
        }

        private void dataNavigator1_eMovePrevious()
        {
            if (this.dataNavigator1.DataGridActive == false)
            {
                this.dataNavigator1.DbObject.MovePrevious();
            }
            else
            {
                if (this.dataNavigator1.DataGrid != null)
                    this.dataNavigator1.DataGrid_MovePrevious();
            }
        }

        private void dataNavigator1_eRefresh()
        {
            if (this.dataNavigator1.DataGridActive == false)
            {
                this.dataNavigator1.DbObject.DoQuery();
            }
            else
            {
                if (this.dataNavigator1.DataGrid != null)
                {
                    this.dataNavigator1.DbObject.DoQuery();
                    this.dataNavigator1.DataGrid.DataSource = this.dataNavigator1.DbObject.DataTable;
                }
            }
        }

        private void dataNavigator1_eSave()
        {
            if (this.dataNavigator1.DataGridActive == false)
            {
                this.dataNavigator1.DbObject.Update();
            }
            else
            {
                if (this.dataNavigator1.DataGrid != null)
                {
                    int attachmentRowIndex = -1;

                    if (this.tabDataNavigator.SelectedTab.Name == this.tabAttachments.Name)
                    {

                        if (this.dataNavigator1.AddNewPending == true)
                        {
                            attachmentRowIndex = this.attachmentNewRowIndex;
                        }
                        else
                        {

                            attachmentRowIndex = this.dgv_Attachments.CurrentRow.Index;
                        }
                    }

                    this.dataNavigator1.DataGrid_Update();


                    if (this.dataNavigator1.DbObject.Name == this.dbT_Attachments.Name)
                    {
                        if (this.uploadAttachment.Tag != null)
                        {
                            string _tempfilename = this.uploadAttachment.Tag.ToString();
                            string _destfilename = GetAttachmentRealFileName(this.dgv_Attachments.Rows[attachmentRowIndex] );
                            if (_destfilename != "")
                            {
                                foreach (string sFile in System.IO.Directory.GetFiles(this.appConfig.AttachmentsPath, System.IO.Path.GetFileNameWithoutExtension(_destfilename) + ".*"))
                                {
                                    System.IO.File.Delete(sFile);
                                }
                                System.IO.File.Move(_tempfilename , _destfilename);
                            }
                            this.uploadAttachment.Tag = null;
                            this.attachmentNewRowIndex =-1;
                        }
                    }
                }


            }
        }
        private void uploadAttachment_Uploaded(object sender, UploadedEventArgs e)
        {

            ManageUploadedAttachment(e.Files [0].FileName , e.Files[0].ContentType);
            string filename = this.appConfig.AttachmentsPath + @"\" + System.Guid.NewGuid().ToString();
            e.Files[0].SaveAs(filename );
            this.uploadAttachment.Tag = filename;
            

        }


        private void ManageUploadedAttachment(string filename,string contenttype)
        {
            this.dgv_Attachments.CurrentRow[this.dgvc_attachments_filename].Value = filename;
            this.dgv_Attachments.CurrentRow[this.dgvc_attachments_contenttype].Value = contenttype;
            this.dgv_Attachments.CurrentRow[this.dgvc_attachments_date].Value = System.DateTime.Now.Date;
            if (this.dgv_Attachments.CurrentRow[this.dgvc_attachments_description].Value.ToString().Trim() == "")
                this.dgv_Attachments.CurrentRow[this.dgvc_attachments_description].Value = filename;
            
        }


        private void dataNavigator1_eUndo()
        {
            if (this.dataNavigator1.DataGridActive == false)
            {
                this.dataNavigator1.DbObject.UndoChanges();
            }
            else
            {
                if (this.dataNavigator1.DataGrid != null)
                {
                    this.dataNavigator1.DataGrid_Undo();
                    if (this.uploadAttachment .Tag !=null)
                    {
                        System.IO.File.Delete(this.uploadAttachment.Tag.ToString());
                    }

                    this.uploadAttachment.Tag = null;
                    this.attachmentNewRowIndex = -1;
                }
            }
        }

        private void dataNavigator1_eSaveRequest(ref bool Cancel)
        {

        }

        private void dataNavigator1_eDeleteRequest(ref bool Cancel)
        {

        }

        private void dataNavigator1_eAddNewRequest(ref bool Cancel)
        {

        }

        private void dataNavigator1_eCloseRequest(ref bool Cancel)
        {

        }

        private void dataNavigator1_eUndoRequest(ref bool Cancel)
        {

        }

        private void dataNavigator1_ePrintRequest(ref bool Cancel)
        {

        }

        private void dataNavigator1_eRefreshRequest(ref bool Cancel)
        {

        }

        private void dataNavigator1_eMovePreviousRequest(ref bool Cancel)
        {

        }

        private void dataNavigator1_eMoveNextRequest(ref bool Cancel)
        {

        }

        private void dataNavigator1_eMoveLastRequest(ref bool Cancel)
        {

        }

        private void dataNavigator1_eMoveFirstRequest(ref bool Cancel)
        {

        }

        private void dataNavigator1_eFindRequest(ref bool Cancel)
        {

        }

        private void tabDataNavigator_SelectedIndexChanged(object sender, EventArgs e)
        {

            ManageTabDataNavigator(this.tabDataNavigator.SelectedTab.Name);
        }



        private void dataNavigator1_eBoundCompleted()
        {

        }

        private void frmAssets_Load(object sender, EventArgs e)
        {
            this.InitDataContext();

        }

        private void txt_asset_id_TextChanged(object sender, EventArgs e)
        {
            //LoadAssetBarcodes();
        }

        private void LoadAssetBarcodes()
        {
            BasicDAL.DbFilters dbf = new BasicDAL.DbFilters();

            dbf.Add(this.dbT_AssetBarcodes.DbC_assetid, BasicDAL.ComparisionOperator.Equal, this.txt_asset_id.Text);
            this.dbT_AssetBarcodes.FiltersGroup.Clear();
            this.dbT_AssetBarcodes.FiltersGroup.Add(dbf);
            this.dbT_AssetBarcodes.Open(true);
            this.dgv_AssetBarcodes.DataSource = this.dbT_AssetBarcodes.DataTable;


        }
        private void LoadAssetAttachments()
        {
            BasicDAL.DbFilters dbf = new BasicDAL.DbFilters();
            dbf.Add(this.dbT_Attachments.DbC_parentobjecttype, BasicDAL.ComparisionOperator.Equal, "ASSET", BasicDAL.LogicOperator.AND );
            dbf.Add(this.dbT_Attachments.DbC_parentobjectid, BasicDAL.ComparisionOperator.Equal, this.txt_asset_id.Text);
            this.dbT_Attachments.FiltersGroup.Clear();
            this.dbT_Attachments.FiltersGroup.Add(dbf);
            this.dbT_Attachments.Open(true);
            this.dgv_Attachments.DataSource = this.dbT_Attachments.DataTable;
        }

        private void txt_asset_ownerid_ToolClick(object sender, ToolClickEventArgs e)
        {
            this.qbe_Owners();
        }

        private void txt_asset_assetcategoryid_ToolClick(object sender, ToolClickEventArgs e)
        {
            this.qbe_AssetCategories();
        }

        private void txt_asset_brandcategoryid_ToolClick(object sender, ToolClickEventArgs e)
        {
            this.qbe_BrandCategories();
        }

        private void txt_asset_vendorid_ToolClick(object sender, ToolClickEventArgs e)
        {
            this.qbe_Vendors();
        }

        private void txt_asset_locationid_ToolClick(object sender, ToolClickEventArgs e)
        {
            this.qbe_Locations();
        }

        private void dgv_Attachments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == this.dgvc_attachments_upload .Index )
            {
                this.uploadAttachment.UploadFiles();
            }

            if (e.ColumnIndex == this.dgvc_attachments_open .Index )
            {
                
                this.DownloadAndOpenAttachmentFromDataGrid();
            }

            if (e.ColumnIndex == this.dgvc_attachments_camera.Index)
            {

                BasicDALWisejControls.VideoImageAcquireForm acquire = new BasicDALWisejControls.VideoImageAcquireForm(this);
                acquire.Source = BasicDALWisejControls.VideoImageAcquireForm.Sources.FileAndCamera;
                acquire.ApplicationTempPath = "temp";
                acquire.FileName = System.Guid.NewGuid().ToString();
                acquire.ShowDialog();
                if (acquire.FileName !=null)
                {
                    ManageUploadedAttachment(acquire.FileName, acquire.ContentType);
                    this.uploadAttachment.Tag = acquire.RealFileName ;
                }
                acquire.Dispose();
            }
        }

        
        private void DownloadAndOpenAttachmentFromDataGrid()
        {
            DataGridViewRow r = this.dgv_Attachments.CurrentRow;
            string realfilename = this.GetAttachmentRealFileName(r);
            string filename = r[this.dgvc_attachments_filename].Value.ToString();
            try
            {
                System.IO.FileStream fileStream = new System.IO.FileStream(realfilename, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                Application.DownloadAndOpen("_blank", fileStream, filename);
                fileStream.Close();
            }
            catch (Exception)
            {
            }
        }

        private string GetAttachmentRealFileName(DataGridViewRow r)
        {
            if (r !=null)
            {
                string parentobjecttype = r[this.dgvc_attachments_parentobjecttype].Value.ToString();
                string parentobjectid = r[this.dgvc_attachments_parentobjectid].Value.ToString();
                string id = r[this.dgvc_attachments_id].Value.ToString();
                string filename = "";
                try
                {
                    string extension = System.IO.Path.GetExtension(r[this.dgvc_attachments_filename].Value.ToString());
                    filename = this.appConfig.AttachmentsPath + @"\" + parentobjecttype + "_" + parentobjectid + "_" + id + extension;
                }
                catch (Exception)
                {
                }
                return filename;
            }
            else
            {
                return "";
            }
        }

        private void frmAssets_Accelerator(object sender, AcceleratorEventArgs e)
        {
            e.Handled = true;
            this.dataNavigator1.HandleUserInput(sender, e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAssets_ResponsiveProfileChanged(object sender, ResponsiveProfileChangedEventArgs e)
        {
           
        }

        private void txt_asset_assetcategoryid_TextChanged(object sender, EventArgs e)
        {
            if (this.dataNavigator1 .AddNewPending ==true)
            {
                this.cmb_Asset_VATCode.SelectedValue = this.txt_asset_assetcategoryid.Value;
            }
        }
    }


}
