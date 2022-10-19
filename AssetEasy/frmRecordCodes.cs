using System;
using Wisej.Web;
using AssetEasy.DataModel;



namespace AssetEasy
{
    public partial class frmRecordCodes : Form
    {
        public AppConfig appConfig = new AppConfig();

        public DbT_RecordCodes dbT_RecordCodes = new DbT_RecordCodes();
        public DbT_RecordCodes dbT_DestinationLocationRecordCodes = new DbT_RecordCodes();
        public DbT_Locations  dbT_SourceLocations = new DbT_Locations();
        public DbT_Locations dbT_DestinationLocations = new DbT_Locations();

        private bool FormInit = false;
        private bool DataNavigatorHandlerInitialized = false;
        public BasicDAL.DbConfig DbConfig = new BasicDAL.DbConfig();

        public frmRecordCodes()
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

            this.DbConfig = this.appConfig.DbConfig.Clone();

            InitDataNavigatorHandler();


            //Initialize a DBObject
            this.dbT_RecordCodes.Init(DbConfig);
            this.dbT_RecordCodes.DataBinding = BasicDAL.DataBoundControlsBehaviour.BasicDALDataBinding;
            this.dbT_RecordCodes.Init(this.DbConfig);
            this.dbT_SourceLocations.Init(this.DbConfig);
            this.dbT_DestinationLocations.Init(this.DbConfig);
            this.dbT_DestinationLocationRecordCodes.Init(this.DbConfig);


            this.cmb_recordcodes_actiononprimarylocationinventory.DataSource = Utilities.EnumToDataTable(typeof(eActionsOnLocationInventory), Utilities.EnumToDataTableValueItem.Value, Utilities.EnumToDataTableDisplayItem.Description);
            this.cmb_recordcodes_actiononprimarylocationinventory.ValueMember = "id";
            this.cmb_recordcodes_actiononprimarylocationinventory.DisplayMember = "desc";

            this.cmb_recordcodes_actiononsecondarylocationinventory.DataSource = Utilities.EnumToDataTable(typeof(eActionsOnLocationInventory), Utilities.EnumToDataTableValueItem.Value, Utilities.EnumToDataTableDisplayItem.Description);
            this.cmb_recordcodes_actiononsecondarylocationinventory.ValueMember = "id";
            this.cmb_recordcodes_actiononsecondarylocationinventory.DisplayMember = "desc";

            this.dbT_RecordCodes.DbC_id.BoundControls.Add(this.txt_recordcodes_id, "text", BasicDAL.BindingBehaviour.ReadAddNew);
            this.dbT_RecordCodes.DbC_mnemoniccode.BoundControls.Add(this.txt_recordcodes_mnemoniccode, "text");
            this.dbT_RecordCodes.DbC_description.BoundControls.Add(this.txt_recordcodes_description, "text");
            this.dbT_RecordCodes.DbC_primarylocationid.BoundControls.Add(this.txt_recordcodes_primarylocationid , "value");
            this.dbT_RecordCodes.DbC_secondarylocationid.BoundControls.Add(this.txt_recordcodes_secondarylocationid, "value");
            this.dbT_RecordCodes.DbC_notes.BoundControls.Add(this.txt_recordcodes_notes, "text");
            this.dbT_RecordCodes.DbC_actiononprimarylocationinventory.BoundControls.Add(this.cmb_recordcodes_actiononprimarylocationinventory, "selectedvalue");
            this.dbT_RecordCodes.DbC_actiononsecondarylocationinventory.BoundControls.Add(this.cmb_recordcodes_actiononsecondarylocationinventory, "selectedvalue");
            this.dbT_RecordCodes.DbC_secondarylocationrecordcodeid .BoundControls.Add(this.txt_recordcodes_secondarylocationrecordcodeid  , "value");


            this.txt_recordcodes_primarylocationid.DbLookup.DbObject = this.dbT_SourceLocations  ;
            this.txt_recordcodes_primarylocationid.DisplayMember = this.dbT_SourceLocations.DbC_mnemoniccode.DbColumnNameE;
            this.txt_recordcodes_primarylocationid.ValueMember = this.dbT_SourceLocations.DbC_id.DbColumnNameE;
            this.txt_recordcodes_primarylocationid.DbLookup.BoundControls.Add(this.dbT_SourceLocations.DbC_name   , this.txt_sourcelocation_name, "text");
            this.txt_recordcodes_primarylocationid.DbLookup.BoundControls.Add(this.dbT_SourceLocations.DbC_id, this.txt_sourcelocation_id, "text");

            this.txt_recordcodes_secondarylocationid.DbLookup.DbObject = this.dbT_DestinationLocations;
            this.txt_recordcodes_secondarylocationid.DisplayMember = this.dbT_DestinationLocations.DbC_mnemoniccode.DbColumnNameE;
            this.txt_recordcodes_secondarylocationid.ValueMember = this.dbT_DestinationLocations.DbC_id.DbColumnNameE;
            this.txt_recordcodes_secondarylocationid.DbLookup.BoundControls.Add(this.dbT_DestinationLocations.DbC_name, this.txt_destinationlocation_name, "text");
            this.txt_recordcodes_secondarylocationid.DbLookup.BoundControls.Add(this.dbT_DestinationLocations.DbC_id, this.txt_destinationlocation_id, "text");

            this.txt_recordcodes_secondarylocationrecordcodeid.DbLookup.DbObject = this.dbT_DestinationLocationRecordCodes;
            this.txt_recordcodes_secondarylocationrecordcodeid.DisplayMember = this.dbT_DestinationLocationRecordCodes.DbC_mnemoniccode.DbColumnNameE;
            this.txt_recordcodes_secondarylocationrecordcodeid.ValueMember = this.dbT_DestinationLocationRecordCodes.DbC_id.DbColumnNameE;
            this.txt_recordcodes_secondarylocationrecordcodeid.DbLookup.BoundControls.Add(this.dbT_DestinationLocationRecordCodes.DbC_id,this.txt_destinationlocationrecordcode_id , "text");
            this.txt_recordcodes_secondarylocationrecordcodeid.DbLookup.BoundControls.Add(this.dbT_DestinationLocationRecordCodes.DbC_description , this.txt_destinationlocationrecordcode_description , "text");


            this.dbT_RecordCodes.Open(true);
            this.dbT_SourceLocations.Open(true);
            this.dbT_DestinationLocations.Open(true);

            this.dataNavigator1.DbObject = this.dbT_RecordCodes;
            this.dataNavigator1.ManageNavigation = false;
            this.dataNavigator1.DataGridActive = false;
            this.dataNavigator1.DataGridListView = this.dgvList;
            //this.dataNavigator1.ListViewColumns.Add(this.dbT_Locations.DbC_pub_id, "Publisher ID", "");
            //this.dataNavigator1.ListViewColumns.Add(this.dbT_Locations.DbC_pub_name, "Publisher Name", "");
            this.dataNavigator1.InitDataNavigator(true);

        }

        private void qbe_RecordCodes()
        {
            DbT_RecordCodes QBEDbObject = new DbT_RecordCodes ();

            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();

            QBEDbObject.Init(this.DbConfig.Clone());
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.BoundControls ;
            QBEForm.CallerForm = this;
            QBEForm.Text = "Search for " + this.Text;

            QBEForm.DbObject = QBEDbObject;
            QBEForm.QueryDbObject = this.dbT_RecordCodes;
            QBEForm.AutoLoadAll = true;
            QBEForm.UseExactSearchForString = false;
            //QBEForm.DbColumnsMapping.Add(QBEDbObject.DbC_mnemoniccode , this.dbT_RecordCodes.DbC_id);
            QBEForm.ShowQBE(this);
        }

        private void qbe_SourceLocations()
        {
            DbT_Locations QBEDbObject = new DbT_Locations();

            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();

            QBEDbObject.Init(this.DbConfig.Clone());
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.BoundControls ;
            QBEForm.CallerForm = this;
            QBEForm.Text = "Search for Source Locations";

            QBEForm.DbObject = QBEDbObject;
            QBEForm.QueryDbObject = this.dbT_RecordCodes;
            QBEForm.AutoLoadAll = true;
            QBEForm.UseExactSearchForString = false;
            QBEForm.BoundControls.Add(QBEDbObject.DbC_id , this.txt_recordcodes_primarylocationid , "value");
            //QBEForm.DbColumnsMapping.Add(QBEDbObject.DbC_id, this.dbT_RecordCodes.DbC_id);
            QBEForm.ShowQBE(this);
        }

        private void qbe_DestinationLocations()
        {
            DbT_Locations QBEDbObject = new DbT_Locations();

            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();

            QBEDbObject.Init(this.DbConfig.Clone());
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.BoundControls ;
            QBEForm.CallerForm = this;
            QBEForm.Text = "Search for Destination Locations";

            QBEForm.DbObject = QBEDbObject;
            QBEForm.QueryDbObject = this.dbT_RecordCodes;
            QBEForm.AutoLoadAll = true;
            QBEForm.UseExactSearchForString = false;
            QBEForm.BoundControls.Add(QBEDbObject.DbC_id, this.txt_recordcodes_secondarylocationid , "value");

            QBEForm.ShowQBE(this);
        }

        private void qbe_DestinationRecordCode()
        {
            DbT_RecordCodes  QBEDbObject = new DbT_RecordCodes();

            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();

            QBEDbObject.Init(this.DbConfig.Clone());
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.BoundControls;
            QBEForm.CallerForm = this;
            QBEForm.Text = "Search for Destination Record Codes";

            QBEForm.DbObject = QBEDbObject;
            QBEForm.QueryDbObject = this.dbT_RecordCodes;
            QBEForm.AutoLoadAll = true;
            QBEForm.UseExactSearchForString = false;
            QBEForm.BoundControls.Add(QBEDbObject.DbC_id, this.txt_recordcodes_secondarylocationrecordcodeid , "value");

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

        private void ManageTabDataNavigator(string Item)
        {
            switch (Item.ToLower())
            {
                case "tabform":
                    this.dataNavigator1.DataGridListViewActive = false;
                    break;

                case "tablist":
                    this.dataNavigator1.DataGridListViewActive = true;
                    //  this.dataNavigator1.DataGrid.DataSource = this.dataNavigator1.DbObject.DataTable;
                    break;

                default:
                    break;
            }
        }
        private void dataNavigator1_eFind()
        {

            qbe_RecordCodes();

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
                    this.dataNavigator1.DataGrid_AddNew();
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
                    this.dataNavigator1.DataGrid_Delete();
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


        private void frmRecordCodes_Load(object sender, EventArgs e)
        {
            this.InitDataContext();
        }

        private void txt_recordcodes_sourcelocationid_ToolClick(object sender, ToolClickEventArgs e)
        {
            this.qbe_SourceLocations();

        }

        private void txt_recordcodes_destinationlocationid_ToolClick(object sender, ToolClickEventArgs e)
        {
            qbe_DestinationLocations();
        }

        private void txt_recordcodes_destinationlocationrecordcode_ToolClick(object sender, ToolClickEventArgs e)
        {
            qbe_DestinationRecordCode();
        }
    }
}
