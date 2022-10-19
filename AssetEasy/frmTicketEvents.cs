using AssetEasy.DataModel;
using System;
using System.Configuration;
using Wisej.Web;

namespace AssetEasy
{
    public partial class frmTicketEvents : Form
    {
        public AppConfig appConfig = new AppConfig();

        DbT_TicketEvents  dbT_TicketEvents = new DbT_TicketEvents ();
        DbT_Tickets dbT_Tickets = new DbT_Tickets();
        DbT_Operators dbT_Operators = new DbT_Operators();
        DbT_IssueCategories dbT_IssueCategories = new DbT_IssueCategories();
        DbT_Customers dbT_Customers = new DbT_Customers();
        private bool FormInit = false;
        private bool DataNavigatorHandlerInitialized = false;
        public BasicDAL.DbConfig DbConfig = new BasicDAL.DbConfig();

        public frmTicketEvents()
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


         
            dbT_Tickets.Init(this.DbConfig);
            dbT_TicketEvents.Init(this.DbConfig);
            dbT_Operators.Init(this.DbConfig);
            dbT_Customers.Init(this.DbConfig);
            dbT_IssueCategories.Init(this.DbConfig);


            this.dbT_Tickets.DataBinding = BasicDAL.DataBoundControlsBehaviour.BasicDALDataBinding;
            this.dbT_TicketEvents.DataBinding = BasicDAL.DataBoundControlsBehaviour.BasicDALDataBinding;

            this.dbT_TicketEvents.DbC_id.BoundControls.Add(this.txt_TicketEvents_id, "text", BasicDAL.BindingBehaviour.ReadAddNew);
            this.dbT_TicketEvents.DbC_ticketid.BoundControls.Add(this.txt_TicketEvents_TicketID, "text", BasicDAL.BindingBehaviour.ReadAddNew);
            this.dbT_TicketEvents.DbC_parentid.BoundControls.Add(this.txt_TicketEvents_ParentID, "text", BasicDAL.BindingBehaviour.ReadAddNew);


            this.dbT_TicketEvents.DbC_requestername.BoundControls.Add(this.txt_ticketevents_requestername, "text");
            this.dbT_TicketEvents.DbC_reuquesteremail.BoundControls.Add(this.txt_ticketevents_requesteremail, "text");
            this.dbT_TicketEvents.DbC_requesterphone.BoundControls.Add(this.txt_ticketevents_requesterphone, "text");
            this.dbT_TicketEvents.DbC_date.BoundControls.Add(this.dtp_TicketEvents_Date, "value");
            this.dbT_TicketEvents.DbC_time.BoundControls.Add(this.dtp_TicketEvents_Time, "value");

            this.dbT_Tickets.DbC_id.BoundControls.Add(this.txt_tickets_id, "text", BasicDAL.BindingBehaviour.Read);
            this.dbT_Tickets.DbC_creationdate.BoundControls.Add(this.dtp_tickets_creationdate, "value", BasicDAL.BindingBehaviour.Read);
            this.dbT_Tickets.DbC_creationtime.BoundControls.Add(this.txt_tickets_creationtime, "text", BasicDAL.BindingBehaviour.Read);
            this.dbT_Tickets.DbC_mnemoniccode.BoundControls.Add(this.txt_tickets_mnemoniccode, "text",BasicDAL.BindingBehaviour.Read);
            this.dbT_Tickets.DbC_issuecategoryid.BoundControls.Add(this.txt_tickets_issuecategoryid, "value",BasicDAL.BindingBehaviour.Read);
            this.dbT_Tickets.DbC_customerid.BoundControls.Add(this.txt_tickets_customerid, "value",BasicDAL.BindingBehaviour.Read);
            this.dbT_Tickets.DbC_creationoperatorid.BoundControls.Add(this.txt_tickets_creationoperatorid, "value", BasicDAL.BindingBehaviour.Read  );
            this.dbT_Tickets.DbC_priority.BoundControls.Add(this.cmb_ticket_priority, "selectedvalue", BasicDAL.BindingBehaviour.Read);
            this.dbT_Tickets.DbC_severity.BoundControls.Add(this.cmb_ticket_severity, "selectedvalue", BasicDAL.BindingBehaviour.Read);
            this.dbT_Tickets.DbC_requestername.BoundControls.Add(this.txt_tickets_requestername, "text");
            this.dbT_Tickets.DbC_requesteremail.BoundControls.Add(this.txt_tickets_requesteremail, "text");
            this.dbT_Tickets.DbC_requesterphone.BoundControls.Add(this.txt_tickets_requesterphone, "text");


            this.txt_tickets_issuecategoryid.DbLookup.DbObject = this.dbT_IssueCategories;
            this.txt_tickets_issuecategoryid.DisplayMember = this.dbT_IssueCategories.DbC_mnemoniccode.DbColumnNameE;
            this.txt_tickets_issuecategoryid.ValueMember = this.dbT_IssueCategories.DbC_id.DbColumnNameE;
            this.txt_tickets_issuecategoryid.DbLookup.BoundControls.Add(this.dbT_IssueCategories.DbC_id, this.txt_issuecategory_id, "text");
            this.txt_tickets_issuecategoryid.DbLookup.BoundControls.Add(this.dbT_IssueCategories.DbC_description, this.txt_issuecategories_description, "text");

            this.txt_tickets_creationoperatorid.DbLookup.DbObject = this.dbT_Operators;
            this.txt_tickets_creationoperatorid.DisplayMember = this.dbT_Operators.DbC_menmoniccode.DbColumnNameE;
            this.txt_tickets_creationoperatorid.ValueMember = this.dbT_Operators.DbC_id.DbColumnNameE;
            this.txt_tickets_creationoperatorid.DbLookup.BoundControls.Add(this.dbT_Operators.DbC_id, this.txt_operators_id, "text");
            this.txt_tickets_creationoperatorid.DbLookup.BoundControls.Add(this.dbT_Operators.DbC_lastname, this.txt_operators_name, "text");

            this.txt_tickets_customerid.DbLookup.DbObject = this.dbT_Customers;
            this.txt_tickets_customerid.DisplayMember = this.dbT_Customers.DbC_mnemoniccode.DbColumnNameE;
            this.txt_tickets_customerid.ValueMember = this.dbT_Customers.DbC_id.DbColumnNameE;
            this.txt_tickets_customerid.DbLookup.BoundControls.Add(this.dbT_Customers.DbC_id, this.txt_customers_id, "text");
            this.txt_tickets_customerid.DbLookup.BoundControls.Add(this.dbT_Customers.DbC_fullname, this.txt_customers_fullname, "text");


            this.cmb_ticket_severity.DataSource = Utilities.EnumToDataTable(typeof(eTicketSeverity), Utilities.EnumToDataTableValueItem.Value, Utilities.EnumToDataTableDisplayItem.ValueDescription);
            this.cmb_ticket_severity.ValueMember = "id";
            this.cmb_ticket_severity.DisplayMember = "desc";


            this.cmb_ticket_priority.DataSource = Utilities.EnumToDataTable(typeof(eTicketPriority), Utilities.EnumToDataTableValueItem.Value, Utilities.EnumToDataTableDisplayItem.ValueDescription);
            this.cmb_ticket_priority.ValueMember = "id";
            this.cmb_ticket_priority.DisplayMember = "desc";



            this.dbT_Tickets.Open(true);
                        
            this.dataNavigator1.DbObject = this.dbT_TicketEvents;
            this.dataNavigator1.ManageNavigation = false;
            this.dataNavigator1.DataGridActive = false;
            this.dataNavigator1.DataGridListView = this.dgvList;
            this.dataNavigator1.InitDataNavigator(true);

        }



        public void LoadTicket(int TicketID)
        {
            BasicDAL.DbFilters dbFTicket = new BasicDAL.DbFilters();
            this.dbT_Tickets.FiltersGroup.Clear();
            if (TicketID >0)
            {
                dbFTicket.Add(this.dbT_Tickets.DbC_id, BasicDAL.ComparisionOperator.Equal, TicketID);
                this.dbT_Tickets.FiltersGroup.Add(dbFTicket);
            }

            this.dbT_Tickets.Open(true);

        }

        public void LoadTicketEvemt(int TicketID)
        {
            BasicDAL.DbFilters dbFTicket = new BasicDAL.DbFilters();
            this.dbT_TicketEvents.FiltersGroup.Clear();
            if (TicketID > 0)
            {
                dbFTicket.Add(this.dbT_TicketEvents.DbC_ticketid , BasicDAL.ComparisionOperator.Equal, TicketID);
                this.dbT_TicketEvents.FiltersGroup.Add(dbFTicket);
            }

            this.dbT_TicketEvents.Open(true);

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
                    this.pnl_Ticket.Parent = this.tabForm;
                    this.pnl_TicketEvents.Parent = this.tabForm;
                    this.dataNavigator1.DataGridListViewActive = false;

                    break;

                case "tablist":
                    this.dataNavigator1.DataGridListViewActive = true;
                    //  this.dataNavigator1.DataGrid.DataSource = this.dataNavigator1.DbObject.DataTable;
                    break;
                case "tabattachments":
                    this.pnl_Ticket.Parent = this.tabAttachments ;
                    this.pnl_TicketEvents.Parent = this.tabAttachments;
                    break;

                default:
                    break;
            }
        }
        private void dataNavigator1_eFind()
        {

           

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
                MessageBox.Show(this.appConfig.PublicDemoMessage, String.Format("{0} - {1}", Application.ProductName, this.Text));
                this.dataNavigator1.Undo();
                return;
            }

            if (this.dataNavigator1.DataGridActive == false)
            {
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

        private void frmTicketEvents_Load(object sender, EventArgs e)
        {
            this.InitDataContext();
        }

        private void txt_tickets_id_TextChanged(object sender, EventArgs e)
        {
            this.LoadTicketEvemt(Convert.ToInt32(this.txt_tickets_id.Text));
        }
    }
}

