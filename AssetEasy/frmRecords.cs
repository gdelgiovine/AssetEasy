using System;
using Wisej.Web;
using AssetEasy.DataModel;



namespace AssetEasy
{
    public partial class frmRecords : Form
    {
        public AppConfig appConfig = new AppConfig();

         DbT_RecordMasters dbT_RecordMasters = new DbT_RecordMasters();
         DbT_RecordDetails dbT_RecordDetails = new DbT_RecordDetails();

         DbT_RecordCodes dbT_PrimaryRecordCode = new DbT_RecordCodes();
         DbT_RecordCodes dbT_SecondaryRecordCode = new DbT_RecordCodes();
         DbT_Locations dbT_PrimaryLocation = new DbT_Locations();
         DbT_Locations dbT_SecondaryLocation = new DbT_Locations();
         DbT_Assets dbT_Assets = new DbT_Assets();
         DbT_AssetBarcodes  dbT_AssetBarcodes = new DbT_AssetBarcodes();
         DbT_Assets dbT_AssetsSpeedInput = new DbT_Assets();
         DbT_AssetBarcodes dbT_AssetBarcodesSpeedInput = new DbT_AssetBarcodes();
         DbT_Tickets dbT_Tickets = new DbT_Tickets();
        DbT_TicketEvents dbT_TicketEvents = new DbT_TicketEvents();

        DbT_Customers dbT_Customers = new DbT_Customers();
         DbT_Owners dbT_Owners = new DbT_Owners();
         DbT_Vendors dbT_Vendors = new DbT_Vendors();

        bool FormInit = false;
        bool DataNavigatorHandlerInitialized = false;
        BasicDAL.DbConfig DbConfig;
        BasicDAL.DbConfig TransactionDbConfig;

        public frmRecords()
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

            this.DbConfig = this.appConfig.DbConfig;
            //this.DbConfig.DbConnectionKeepOpen = true;
            this.DbConfig.SuppressErrorsNotification = false;

            this.TransactionDbConfig = this.appConfig.DbConfig.Clone();
           
            InitDataNavigatorHandler();

            this.DbConfig.DbConnectionKeepOpen = false;

            //Initialize a DBObject
            this.dbT_RecordMasters.Init(TransactionDbConfig);
            this.dbT_RecordMasters.DataBinding = BasicDAL.DataBoundControlsBehaviour.BasicDALDataBinding;

            this.dbT_RecordDetails.Init(TransactionDbConfig);
            this.dbT_PrimaryRecordCode.Init(DbConfig);
            this.dbT_SecondaryRecordCode.Init(this.DbConfig);
            this.dbT_PrimaryLocation.Init(this.DbConfig);
            this.dbT_SecondaryLocation.Init(this.DbConfig);
            this.dbT_Assets.Init(this.DbConfig);
            this.dbT_AssetBarcodes.Init(this.DbConfig);
            this.dbT_AssetsSpeedInput.Init(this.DbConfig);
            this.dbT_AssetBarcodesSpeedInput.Init(this.DbConfig);
            this.dbT_Customers.Init(this.DbConfig);
            this.dbT_Owners.Init(this.DbConfig);
            this.dbT_Vendors.Init(this.DbConfig);
            this.dbT_Tickets.Init(this.DbConfig);
            this.dbT_TicketEvents.Init(this.DbConfig);


          

            this.cmb_recordmasters_documenttypeid.DataSource   = Utilities.EnumToDataTable(typeof(eDocumentTypes ), Utilities.EnumToDataTableValueItem.Value, Utilities.EnumToDataTableDisplayItem.Description);
            this.cmb_recordmasters_documenttypeid.ValueMember = "id";
            this.cmb_recordmasters_documenttypeid.DisplayMember = "desc";

            this.cmb_recordmasters_recordtype.DataSource = Utilities.EnumToDataTable(typeof(eRecordTypes  ), Utilities.EnumToDataTableValueItem.Value, Utilities.EnumToDataTableDisplayItem.Description);
            this.cmb_recordmasters_recordtype.ValueMember = "id";
            this.cmb_recordmasters_recordtype.DisplayMember = "desc";

            this.cmb_recordmasters_documentissuertype.DataSource = Utilities.EnumToDataTable(typeof(eDocumentIssuerTypes ), Utilities.EnumToDataTableValueItem.Value, Utilities.EnumToDataTableDisplayItem.Description);
            this.cmb_recordmasters_documentissuertype.ValueMember = "id";
            this.cmb_recordmasters_documentissuertype.DisplayMember = "desc";




            this.dbT_RecordMasters.DbC_id.BoundControls.Add(this.txt_recordmasters_id, "text", BasicDAL.BindingBehaviour.ReadAddNew);
            this.dbT_RecordMasters.DbC_recordtype.BoundControls.Add(this.cmb_recordmasters_recordtype , "selectedvalue");
            this.dbT_RecordMasters.DbC_parentrecordid.BoundControls.Add(this.txt_recordmasters_recordparentid, "text");


            this.dbT_RecordMasters.DbC_description.BoundControls.Add(this.txt_recordmasters_description, "text");
            this.dbT_RecordMasters.DbC_recorddate.BoundControls.Add(this.dtp_recordmasters_recorddate , "value");
            this.dbT_RecordMasters.DbC_recordtime.BoundControls.Add(this.txt_recordmasters_recordtime, "text");
            this.dbT_RecordMasters.DbC_recordingdate.BoundControls.Add(this.dtp_recordmasters_recordingdate, "value");
            this.dbT_RecordMasters.DbC_recordingtime.BoundControls.Add(this.txt_recordmasters_recordingtime, "text");


            this.dbT_RecordMasters.DbC_documenttypeid.BoundControls.Add(this.cmb_recordmasters_documenttypeid , "selectedvalue");
            this.dbT_RecordMasters.DbC_documentissuertype.BoundControls.Add(this.cmb_recordmasters_documentissuertype , "selectedvalue");
            this.dbT_RecordMasters.DbC_documentissuerid.BoundControls.Add(this.txt_recordmasters_documentissuerid, "text");
            this.dbT_RecordMasters.DbC_documentissuername.BoundControls.Add(this.txt_recordmasters_documentissuername, "text");
            this.dbT_RecordMasters.DbC_documentdate .BoundControls.Add(this.dtp_recordmasters_documentdate , "value");
            this.dbT_RecordMasters.DbC_documentnumber.BoundControls.Add(this.txt_recordmasters_documentnumber, "text");


            this.dbT_RecordMasters.DbC_primaryrecordcodeid.BoundControls.Add(this.txt_recordmasters_primaryrecordcodeid, "value");
            this.dbT_RecordMasters.DbC_primarylocationid.BoundControls.Add(this.txt_recordmasters_primarylocationid, "value");
            this.dbT_RecordMasters.DbC_secondaryrecordcodeid.BoundControls.Add(this.txt_recordmasters_secondaryrecordcodeid, "value");
            this.dbT_RecordMasters.DbC_secondarylocationid.BoundControls.Add(this.txt_recordmasters_secondarylocationid, "value");

            this.dbT_RecordMasters.DbC_ticketid .BoundControls.Add(this.txt_recordmasters_ticketid, "value");
            this.dbT_RecordMasters.DbC_ticketeventid .BoundControls.Add(this.txt_recordmasters_ticketeventid, "value");


            this.txt_recordmasters_primaryrecordcodeid.DbLookup.DbObject = this.dbT_PrimaryRecordCode ;
            this.txt_recordmasters_primaryrecordcodeid.DisplayMember = this.dbT_PrimaryRecordCode.DbC_mnemoniccode.DbColumnNameE;
            this.txt_recordmasters_primaryrecordcodeid.ValueMember = this.dbT_PrimaryRecordCode.DbC_id.DbColumnNameE;
            this.txt_recordmasters_primaryrecordcodeid.DbLookup.BoundControls.Add(this.dbT_PrimaryRecordCode.DbC_id, this.txt_primaryrecordcode_id , "text");
            this.txt_recordmasters_primaryrecordcodeid.DbLookup.BoundControls.Add(this.dbT_PrimaryRecordCode.DbC_description, this.txt_primaryrecordcode_description, "text");

            this.txt_recordmasters_secondaryrecordcodeid.DbLookup.DbObject = this.dbT_SecondaryRecordCode;
            this.txt_recordmasters_secondaryrecordcodeid.DisplayMember = this.dbT_SecondaryRecordCode.DbC_mnemoniccode.DbColumnNameE;
            this.txt_recordmasters_secondaryrecordcodeid.ValueMember = this.dbT_SecondaryRecordCode.DbC_id.DbColumnNameE;
            this.txt_recordmasters_secondaryrecordcodeid.DbLookup.BoundControls.Add(this.dbT_SecondaryRecordCode.DbC_id, this.txt_secondaryrecordcode_id, "text");
            this.txt_recordmasters_secondaryrecordcodeid.DbLookup.BoundControls.Add(this.dbT_SecondaryRecordCode.DbC_description, this.txt_secondaryrecordcode_description, "text");



            this.txt_recordmasters_primarylocationid.DbLookup.DbObject = this.dbT_PrimaryLocation;
            this.txt_recordmasters_primarylocationid.DisplayMember = this.dbT_PrimaryLocation.DbC_mnemoniccode.DbColumnNameE;
            this.txt_recordmasters_primarylocationid.ValueMember = this.dbT_PrimaryLocation.DbC_id.DbColumnNameE;
            this.txt_recordmasters_primarylocationid.DbLookup.BoundControls.Add(this.dbT_PrimaryLocation.DbC_name, this.txt_primarylocation_name, "text");
            this.txt_recordmasters_primarylocationid.DbLookup.BoundControls.Add(this.dbT_PrimaryLocation.DbC_id, this.txt_primarylocation_id, "text");

            this.txt_recordmasters_secondarylocationid.DbLookup.DbObject = this.dbT_SecondaryLocation;
            this.txt_recordmasters_secondarylocationid.DisplayMember = this.dbT_SecondaryLocation.DbC_mnemoniccode.DbColumnNameE;
            this.txt_recordmasters_secondarylocationid.ValueMember = this.dbT_SecondaryLocation.DbC_id.DbColumnNameE;
            this.txt_recordmasters_secondarylocationid.DbLookup.BoundControls.Add(this.dbT_SecondaryLocation.DbC_name, this.txt_secondarylocation_name, "text");
            this.txt_recordmasters_secondarylocationid.DbLookup.BoundControls.Add(this.dbT_SecondaryLocation.DbC_id, this.txt_secondarylocation_id, "text");


            this.txt_recordmasters_ticketid.DbLookup.DbObject = this.dbT_Tickets;
            this.txt_recordmasters_ticketid.DisplayMember = this.dbT_Tickets.DbC_mnemoniccode.DbColumnNameE;
            this.txt_recordmasters_ticketid.ValueMember = this.dbT_Tickets.DbC_id.DbColumnNameE;
            this.txt_recordmasters_ticketid.DbLookup.BoundControls.Add(this.dbT_Tickets.DbC_description , this.txt_ticket, "text");

            this.txt_recordmasters_ticketeventid.DbLookup.DbObject = this.dbT_TicketEvents;
            this.txt_recordmasters_ticketeventid.DisplayMember = this.dbT_TicketEvents.DbC_id.DbColumnNameE;
            this.txt_recordmasters_ticketeventid.ValueMember = this.dbT_Tickets.DbC_id.DbColumnNameE;
            this.txt_recordmasters_ticketeventid.DbLookup.BoundControls.Add(this.dbT_TicketEvents.DbC_description , this.txt_ticketeventdescription, "text");



            this.dbT_RecordMasters.Open(true);
            this.dbT_PrimaryLocation.Open(true);
            this.dbT_SecondaryLocation.Open(true);
            this.dbT_PrimaryRecordCode.Open(true);
            this.dbT_SecondaryRecordCode.Open(true);


            this.dataNavigator1.DbObject = this.dbT_RecordMasters;
            this.dataNavigator1.ManageNavigation = false;
            this.dataNavigator1.DataGridActive = false;
            this.dataNavigator1.DataGridListView = this.dgvList;
            this.dataNavigator1.DataGrid = this.dgv_Details;
            //this.dataNavigator1.ListViewColumns.Add(this.dbT_Locations.DbC_pub_id, "Publisher ID", "");
            //this.dataNavigator1.ListViewColumns.Add(this.dbT_Locations.DbC_pub_name, "Publisher Name", "");
            this.dataNavigator1.InitDataNavigator(true);
            this.dataNavigator1.DataGridActive = false;
        }

        private void LoadDetails()
        {
          
            int ID = -1;
            int.TryParse(this.txt_recordmasters_id.Text,out  ID);
            BasicDAL.DbFilters dBF = new BasicDAL.DbFilters();
            dBF.Add(this.dbT_RecordDetails.DbC_recordmasterid, BasicDAL.ComparisionOperator.Equal,ID);
            this.dbT_RecordDetails.FiltersGroup.Clear();
            this.dbT_RecordDetails.FiltersGroup.Add(dBF);
            this.dbT_RecordDetails.Open(true);
            this.dgv_Details.DataSource = this.dbT_RecordDetails.DataTable;
        }


        private void GetDocumentIssuer()
        {

          
            eDocumentIssuerTypes issuertype = (eDocumentIssuerTypes)Convert.ToInt32(this.cmb_recordmasters_documentissuertype.SelectedValue);
            int ID = 0;
            if (Int32.TryParse(this.txt_recordmasters_documentissuerid.Text, out ID) == true)
            {
                switch (issuertype)
                {
                    case eDocumentIssuerTypes.Self:
                        //this.txt_recordmasters_documentissuerid.Value = "0";
                        //this.txt_recordmasters_documentissuername.Text = "SELF";
                        break;
                    case eDocumentIssuerTypes.Customer:
                        GetCustomer(ID);
                        break;
                    case eDocumentIssuerTypes.Owner:
                        GetOwner(ID);
                        break;
                    case eDocumentIssuerTypes.Vendor:
                        GetVendor(ID);
                        break;
                    case eDocumentIssuerTypes.Other:
                        break;
                    default:
                        break;
                }
            }
        }

        private void GetCustomer(int ID)
        {
            BasicDAL.DbFilters dBF = new BasicDAL.DbFilters();
            dBF.Add(this.dbT_Customers.DbC_id, BasicDAL.ComparisionOperator.Equal, ID);
            this.dbT_Customers.FiltersGroup.Clear();
            this.dbT_Customers.FiltersGroup.Add(dBF);
            this.dbT_Customers.Open(true);
            if (this.dbT_Customers.ExecutionResult.Success == true && this.dbT_Customers.RowCount == 1)
            {
                this.txt_recordmasters_documentissuername.Text = this.dbT_Customers.DbC_fullname.Value.ToString();
            }    
        }


        private void GetOwner(int ID)
        {
            BasicDAL.DbFilters dBF = new BasicDAL.DbFilters();
            dBF.Add(this.dbT_Owners.DbC_id, BasicDAL.ComparisionOperator.Equal, ID);
            this.dbT_Owners.FiltersGroup.Clear();
            this.dbT_Owners.FiltersGroup.Add(dBF);
            this.dbT_Owners.Open(true);
            if (this.dbT_Owners.ExecutionResult.Success == true && this.dbT_Owners.RowCount == 1)
            {
                this.txt_recordmasters_documentissuername.Text = this.dbT_Owners.DbC_name.Value.ToString();
            }
        }


        private void GetVendor(int ID)
        {
            BasicDAL.DbFilters dBF = new BasicDAL.DbFilters();
            dBF.Add(this.dbT_Vendors.DbC_id, BasicDAL.ComparisionOperator.Equal, ID);
            this.dbT_Vendors.FiltersGroup.Clear();
            this.dbT_Vendors.FiltersGroup.Add(dBF);
            this.dbT_Vendors.Open(true);
            if (this.dbT_Vendors.ExecutionResult.Success == true && this.dbT_Vendors.RowCount == 1)
            {
                this.txt_recordmasters_documentissuername.Text = this.dbT_Vendors.DbC_name.Value.ToString();
            }
        }



        private void qbe_PrimaryLocations()
        {
            DbT_Locations QBEDbObject = new DbT_Locations();

            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();

            QBEDbObject.Init(this.DbConfig);
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.BoundControls;
            QBEForm.CallerForm = this;
            QBEForm.Text = "Search for Primary Locations";

            QBEForm.DbObject = QBEDbObject;
            QBEForm.AutoLoadAll = true;
            QBEForm.UseExactSearchForString = false;
            QBEForm.BoundControls.Add(QBEDbObject.DbC_id, this.txt_recordmasters_primarylocationid, "value");
            QBEForm.ShowQBE(this);
        }

        private void qbe_PrimaryRecordCodes()
        {
            DbT_RecordCodes QBEDbObject = new DbT_RecordCodes();

            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();

            QBEDbObject.Init(this.DbConfig);
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.BoundControls;
            QBEForm.CallerForm = this;
            QBEForm.Text = "Search for Primary Record Codes";

            QBEForm.DbObject = QBEDbObject;
            QBEForm.AutoLoadAll = true;
            QBEForm.UseExactSearchForString = false;
            QBEForm.BoundControls.Add(QBEDbObject.DbC_id, this.txt_recordmasters_primaryrecordcodeid, "value");
            QBEForm.ShowQBE(this);
        }

        private void qbe_SecondaryLocations()
        {
            DbT_Locations QBEDbObject = new DbT_Locations();

            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();

            QBEDbObject.Init(this.DbConfig);
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.BoundControls;
            QBEForm.CallerForm = this;
            QBEForm.Text = "Search for Secondary Destination Locations";

            QBEForm.DbObject = QBEDbObject;
            QBEForm.AutoLoadAll = true;
            QBEForm.UseExactSearchForString = false;
            QBEForm.BoundControls.Add(QBEDbObject.DbC_id, this.txt_recordmasters_secondarylocationid, "value");

            QBEForm.ShowQBE(this);
        }

        private void qbe_SecondaryRecordCode()
        {
            DbT_RecordCodes QBEDbObject = new DbT_RecordCodes();

            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();

            QBEDbObject.Init(this.DbConfig);
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.BoundControls;
            QBEForm.CallerForm = this;
            QBEForm.Text = "Search for Secondary Record Codes";
            QBEForm.DbObject = QBEDbObject;
            QBEForm.AutoLoadAll = true;
            QBEForm.UseExactSearchForString = false;
            QBEForm.BoundControls.Add(QBEDbObject.DbC_id, this.txt_recordmasters_secondaryrecordcodeid, "value");
          
            QBEForm.ShowQBE(this);
        }

        private void qbe_Ticket()
        {
            DbT_Tickets  QBEDbObject = new DbT_Tickets();

            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();

            QBEDbObject.Init(this.DbConfig);
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.BoundControls;
            QBEForm.CallerForm = this;
            QBEForm.Text = "Search for Referenced Ticket";
            QBEForm.DbObject = QBEDbObject;
            QBEForm.AutoLoadAll = true;
            QBEForm.UseExactSearchForString = false;
            QBEForm.BoundControls.Add(QBEDbObject.DbC_id, this.txt_recordmasters_ticketid, "value");

            QBEForm.ShowQBE(this);
        }

        private void qbe_TicketEvent()
        {
            DbT_TicketEvents QBEDbObject = new DbT_TicketEvents();

            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();

            QBEDbObject.Init(this.DbConfig);
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.BoundControls;
            QBEForm.CallerForm = this;
            QBEForm.Text = "Search for Referenced Ticket Events";
            QBEForm.DbObject = QBEDbObject;
            QBEForm.AutoLoadAll = true;
            QBEForm.UseExactSearchForString = false;
            QBEForm.BoundControls.Add(QBEDbObject.DbC_id, this.txt_recordmasters_ticketeventid, "value");

            QBEForm.ShowQBE(this);
        }

        private void qbe_AssetItem()
        {
            DbT_Assets QBEDbObject = new DbT_Assets();
            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();
            QBEDbObject.Init(this.DbConfig);
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.BoundControls;
            QBEForm.CallerForm = this;
            QBEForm.Text = "Search for Assets Item";
            QBEForm.DbObject = QBEDbObject;
            QBEForm.AutoLoadAll = true;
            QBEForm.UseExactSearchForString = false;
            QBEForm.BoundControls.Add(QBEDbObject.DbC_id, this.dgv_Details .CurrentRow[this.dgvc_AssetID.Name], "value");
      
            QBEForm.ShowQBE(this);
            
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


        private int GetAssetIDFromBarcode(string Barcode, ref DbT_AssetBarcodes dbT_AssetBarcodes)
        {
            BasicDAL.DbFilters DbF = new BasicDAL.DbFilters();
            DbF.Add(dbT_AssetBarcodes.DbC_barcodevalue, BasicDAL.ComparisionOperator.Equal, Barcode);
            dbT_AssetBarcodes.FiltersGroup.Clear();
            dbT_AssetBarcodes.FiltersGroup.Add(DbF);
            dbT_AssetBarcodes.DoQuery();

            if (dbT_AssetBarcodes.RowCount == 1)
            {
                return (int)dbT_AssetBarcodes.DbC_assetid.Value;
            }
            return 0;
        }

        private int GetAssetFromBarcode(string Barcode, ref DbT_AssetBarcodes dbT_AssetBarcodes, ref DbT_Assets dbT_Assets )
        {
            
            BasicDAL.DbFilters DbF = new BasicDAL.DbFilters();
            DbF.Add(dbT_AssetBarcodes.DbC_barcodevalue, BasicDAL.ComparisionOperator.Equal, Barcode);
            dbT_AssetBarcodes.FiltersGroup.Clear();
            dbT_AssetBarcodes.FiltersGroup.Add(DbF);
            dbT_AssetBarcodes.DoQuery();
       
            if (dbT_AssetBarcodes .RowCount ==1)
            {
                this.GetAssetItem((int)dbT_AssetBarcodes.DbC_assetid.Value, ref dbT_Assets);
                if (dbT_Assets.RowCount == 1)
                    return (int)dbT_Assets.DbC_id.Value;

            }
            return 0;
        }


        private void ManageTabDataNavigator(string Item)
        {
            switch (Item.ToLower())
            {
                case "tabform":
                    this.dataNavigator1.DataGridListViewActive = false;
                    this.dataNavigator1.DbObject = this.dbT_RecordMasters;
                    this.dataNavigator1.DataGridActive = false;
                    this.pnl_Master.Parent = this.tabForm;
                    this.pnl_Master.Enabled = true;
                    this.pnl_Details.Parent = this.tabForm;
                    this.pnl_Details.Enabled = false;
                    break;

                case "tablist":
                    this.dataNavigator1.DataGridListViewActive = true;
                    //  this.dataNavigator1.DataGrid.DataSource = this.dataNavigator1.DbObject.DataTable;
                    break;

                case "tabdetails":
                    this.dataNavigator1.DbObject = this.dbT_RecordDetails;
                    this.dataNavigator1.DataGridActive = true;
                    this.pnl_Master.Parent = this.tabDetails ;
                    this.pnl_Master.Enabled = false;

                    this.pnl_Details.Parent = this.tabDetails;
                    this.pnl_Details.Enabled = true;
                    break;
                case "tabnotes":
                    this.pnl_Master.Parent = this.tabNotes ;
                    this.pnl_Master.Enabled = false;
                    break;

                default:
                    break;
            }
        }
        private void dataNavigator1_eFind()
        {

            //qbe_RecordCodes();

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
                //this.LoadDetails();
            }
            else
            {
                if (this.dataNavigator1.DataGrid != null)
                {
                    this.dataNavigator1.DataGrid_AddNew();
                    this.dgv_Details.CurrentRow[this.dgvc_RecordMasterID].Value = this.txt_recordmasters_id.Text;
                 
                }
            }
        }

        private void dataNavigator1_eClose()
        {
            this.Close();
        }

        private void dataNavigator1_eDelete()
        {

            if (this.appConfig.IsPublicDemo == true)
            {
                MessageBox.Show(this.appConfig.PublicDemoMessage, String.Format("{0} - {1}", Application.ProductName, this.Text));
                this.dataNavigator1.Undo();
                return;
            }

            if (this.dataNavigator1.DataGridActive == false)
            {
                this.dataNavigator1.DbObject.Delete();
            }
            else
            {
                if (this.dataNavigator1.DataGrid != null)
                {
                    //this.dataNavigator1.DbObject.SetupCommands();
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
                {
                   
                    this.dataNavigator1.DataGrid_MoveFirst();

                }
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

            // check for public demo - can't add or delete data
            if (this.dataNavigator1.AddNewPending == true && this.appConfig.IsPublicDemo == true)
            {
                this.dataNavigator1.Undo();
                return;
            }

            if (this.dataNavigator1.DataGridActive == false)
            {

                //MessageBox.Show(this.cmb_recordcodes_actiononsourcelocationinventory.SelectedValue.ToString());
                this.dataNavigator1.DbObject.Update();
            }
            else
            {
                if (this.dataNavigator1.DataGrid != null)
                    this.dataNavigator1.DataGrid_Update();



            }
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
                    this.dataNavigator1.DataGrid_Undo();
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


        private void frmRecords_Load(object sender, EventArgs e)
        {
            this.InitDataContext();
        }

        private void txt_recordcodes_primarylocationid_ToolClick(object sender, ToolClickEventArgs e)
        {
            this.qbe_PrimaryLocations();

        }

        private void txt_recordcodes_secondarylocationid_ToolClick(object sender, ToolClickEventArgs e)
        {
            qbe_SecondaryLocations();
        }

        private void txt_recordcodes_secondarylocationrecordcode_ToolClick(object sender, ToolClickEventArgs e)
        {
            qbe_SecondaryRecordCode();
        }

        private void txt_recordmasters_primaryrecordcodeid_ToolClick(object sender, ToolClickEventArgs e)
        {
            qbe_PrimaryRecordCodes();
        }

        private void txt_recordmasters_id_TextChanged(object sender, EventArgs e)
        {
            this.LoadDetails();


        }

        private void dgv_Details_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           
            foreach (DataGridViewRow cRow in this.dgv_Details.Rows)
            {
                if (cRow[this.dgvc_AssetID.Name].Value != DBNull.Value)
                {
                    GetAssetItem(Convert.ToInt32(cRow[this.dgvc_AssetID.Name].Value), ref this.dbT_Assets);

                    if (this.dbT_Assets.ExecutionResult.Success == true)
                    {
                        // codice di decodifica
                        cRow[this.dgvc_AssetDescription.Name].Value = this.dbT_Assets.DbC_description.Value.ToString();
                    }
                    else
                    {
                        cRow[this.dgvc_AssetDescription.Name].Value = "";
                    }
                }
            }   
        }


        private void  GetAssetItem(int AssetID, ref DbT_Assets dbT_Assets)
        {
            BasicDAL.DbFilters dBF = new BasicDAL.DbFilters();
            dBF.Add(dbT_Assets.DbC_id, BasicDAL.ComparisionOperator.Equal, AssetID);
            dbT_Assets.FiltersGroup.Clear();
            dbT_Assets.FiltersGroup.Add(dBF);
            dbT_Assets.DoQuery();
        }

        private void dgv_Details_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == this.dgvc_searchasset.Index )
            {
                qbe_AssetItem();
            }
        }

        private void dgv_Details_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == this.dgvc_searchasset.Index)
            {
                // codice QBE
            }

            //if (e.ColumnIndex == this.dgvc_Barcode.Index )
            //{
            //    this.GetAssetFromBarcode(this.dgv_Details.CurrentCell.Value.ToString(), ref this.dbT_AssetBarcodes , ref this.dbT_Assets );
            //}

            //if (e.ColumnIndex == this.dgvc_AssetID.Index)
            //{
            //    this.GetAssetItem((int)this.dgv_Details.CurrentRow[this.dgvc_AssetID].Value, ref this.dbT_Assets); 
            //}
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {


            MessageBox.Show(this.dbT_RecordMasters.GetDbColumn(this.dbT_RecordMasters .DbC_description.DbColumnNameE).Value .ToString ());
        }

        private void txt_recordmasters_documentissuerid_TextChanged(object sender, EventArgs e)
        {
            this.GetDocumentIssuer();

        }

        private void cmb_recordmasters_documentissuertype_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cmb_recordmasters_documentissuertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmb_recordmasters_documentissuertype.SelectedIndex >= 0 && this.cmb_recordmasters_documentissuertype .ValueMember !="")
            {
                eDocumentIssuerTypes issuertype = (eDocumentIssuerTypes)Convert.ToInt32(this.cmb_recordmasters_documentissuertype.SelectedValue);

                switch (issuertype)
                {
                    case eDocumentIssuerTypes.Self:
                        this.txt_recordmasters_documentissuerid.Enabled = false;
                        this.txt_recordmasters_documentissuername.ReadOnly = true;
                        this.txt_recordmasters_documentissuerid.Text = "0";
                        this.txt_recordmasters_documentissuername.Text = "SELF";
                        this.txt_recordmasters_documentissuername.BackColor = this.txt_primarylocation_id.BackColor;
                        break;
                    case eDocumentIssuerTypes.Customer:
                    case eDocumentIssuerTypes.Owner:
                    case eDocumentIssuerTypes.Vendor:
                        this.txt_recordmasters_documentissuerid.Enabled = true;
                        this.txt_recordmasters_documentissuername.ReadOnly  = true;
                        this.txt_recordmasters_documentissuername.BackColor = this.txt_primarylocation_id.BackColor;
                        break;

                    case eDocumentIssuerTypes.Other:
                        this.txt_recordmasters_documentissuerid.Enabled = false;
                        this.txt_recordmasters_documentissuername.ReadOnly = false;
                        this.txt_recordmasters_documentissuerid.Text = "0";
                        this.txt_recordmasters_documentissuername.BackColor = this.txt_recordmasters_id.BackColor;
                        break;
                    default:
                        break;
                }

            }

        }

        private void chkShowBarcode_CheckStateChanged(object sender, EventArgs e)
        {
            this.dgvc_Barcode.Visible = this.chkShowBarcode.Checked;
            this.pnl_SpeedInput.Visible = this.chkShowBarcode.Checked;
        }

        private void txt_BarcodeSpeedInput_TextChanged(object sender, EventArgs e)
        {

        if (this.GetAssetFromBarcode(this.txt_BarcodeSpeedInput .Text, ref this.dbT_AssetBarcodesSpeedInput, ref this.dbT_AssetsSpeedInput)!=0)
            {
                
                this.dataNavigator1.DataGrid_AddNew();
                this.dgv_Details.CurrentRow[this.dgvc_RecordMasterID].Value = this.dbT_RecordMasters .DbC_id .Value ;
                this.dataNavigator1.DataGrid.CurrentRow[this.dgvc_Barcode ].Value = this.txt_BarcodeSpeedInput.Text;
                this.dataNavigator1.DataGrid.CurrentRow[this.dgvc_AssetID].Value = this.dbT_AssetsSpeedInput.DbC_id.Value;
                this.dataNavigator1.DataGrid.CurrentRow[this.dgvc_Qty].Value =  this.txt_QtySpeedInput.Text;
                this.dataNavigator1.DataGrid.CurrentRow[this.dgvc_UnitValue].Value = this.dbT_AssetsSpeedInput.DbC_acquisitioncost.Value;
                this.dataNavigator1.DataGrid.CurrentRow[this.dgvc_AssetDescription].Value = this.dbT_AssetsSpeedInput.DbC_description.Value;


                bool AutoSave = false;

                this.dataNavigator1.DataGrid.CurrentRow[this.dgvc_UnitValue].Value = this.dbT_AssetsSpeedInput.DbC_acquisitioncost.Value;



                if (this.dbT_AssetsSpeedInput.DbC_managementmode.Value.ToString() == "0")
                {
                    AutoSave = true;
                }

                if (this.dbT_AssetsSpeedInput.DbC_managementmode.Value.ToString() == "1")
                {
                    this.dataNavigator1.DataGrid.CurrentRow[this.dgvc_RecordDetailSerialNumber].Value = this.dbT_AssetsSpeedInput.DbC_serialnumber.Value;
                    AutoSave = true;
                }

                if (this.dbT_AssetsSpeedInput.DbC_managementmode.Value.ToString() == "2")
                {
                    AutoSave = false;
                }





                if (AutoSave == true)
                {
                    this.dataNavigator1.DataGrid_Save();
                    this.txt_BarcodeSpeedInput.Text = "";
                    this.txt_QtySpeedInput.Text = "1";
                    this.txt_BarcodeSpeedInput.Focus();
                }
                else
                {

                    this.dataNavigator1.DataGrid.CurrentCell = this.dataNavigator1.DataGrid.CurrentRow[this.dgvc_RecordDetailSerialNumber];
                    this.dataNavigator1.DataGrid.BeginEdit(true);


                }
            }
            
           
            
        }

        private void txt_recordmasters_ticketid_ToolClick(object sender, ToolClickEventArgs e)
        {
            qbe_Ticket();
        }


        private void txt_recordmasters_ticketeventid_ToolClick(object sender, ToolClickEventArgs e)
        {
            qbe_TicketEvent();
        }
    }
}
