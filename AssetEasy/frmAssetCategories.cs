using System;
using Wisej.Web;
using AssetEasy.DataModel;
using System.Collections.Generic;

namespace AssetEasy 
{

    public partial class frmAssetCategories : Form
    {

        public AppConfig appConfig;

        private BasicDAL.DbConfig DbConfig ;
        private DbV_AssetCategoriesTree dbV_AssetCategoriesTree = new DbV_AssetCategoriesTree();
        private DbV_AssetCategoriesTree dbV_AssetCategoriesTreeCodePath = new DbV_AssetCategoriesTree();
        private DbT_AssetCategories   dbT_AssetCategories = new DbT_AssetCategories() ;
        private DbT_AssetCategories dbT_AssetCategoriesParent = new DbT_AssetCategories();
        private DbT_MeasureUnits dbT_MeasureUnits = new DbT_MeasureUnits();
        private DbT_VAT dbT_VAT = new DbT_VAT();
        private bool FormInit = false;
        private bool DataNavigatorHandlerInitialized = false;

        public frmAssetCategories()
        {
            InitializeComponent();
        }


        private void InitDataContext(bool ForceFormInit = false)
        {

            //this.appConfig.ReadWebConfigAppConfig();

            if (ForceFormInit == true)
            {
                FormInit = false;
            }

            if (this.FormInit)
            {
                return;
            }
       
            this.DbConfig = this.appConfig.DbConfig;
            BasicDALWisejControls.BasicDALMessageBox BasicDALMessageBox = new BasicDALWisejControls.BasicDALMessageBox();
            this.DbConfig.RedirectErrorsNotificationTo = BasicDALMessageBox;

            InitDataNavigatorHandler();

            //Initialize DBObjects
            this.dbT_AssetCategories .Init(this.DbConfig);
            this.dbT_AssetCategories .DataBinding = BasicDAL.DataBoundControlsBehaviour.BasicDALDataBinding;
            this.dbT_AssetCategoriesParent.Init(this.DbConfig);
            this.dbV_AssetCategoriesTree.Init(this.DbConfig);
            this.dbV_AssetCategoriesTreeCodePath.Init(this.DbConfig);
            this.dbT_MeasureUnits.Init(this.DbConfig);
            this.dbT_VAT.Init(this.DbConfig);

            this.dbT_VAT.LoadAll();

            //binding for BasicDAL DbObject columns into UI objects.
            // EX: this.DbObject.dbstringcolumn.BoundControls.Add(this.txt_dbstringcolumn, "text");
            this.dbT_AssetCategories.DbC_id.BoundControls.Add(this.txt_AssetCategories_ID, "text");
            this.dbT_AssetCategories.DbC_description.BoundControls.Add(this.txt_AssetCategories_Description, "text");
            this.dbT_AssetCategories.DbC_mnemoniccode.BoundControls.Add(this.txt_AssetCategories_MnemonicCode, "text");
            this.dbT_AssetCategories.DbC_measureunitid.BoundControls.Add(this.cmb_AssetCategories_MeasureUnitID  , "selectedvalue");
            this.dbT_AssetCategories.DbC_vatcode.BoundControls.Add(this.cmb_AssetCategories_VATCode, "selectedvalue");
            this.dbT_AssetCategories.DbC_managementmode.BoundControls.Add(this.cmb_AssetCategories_ManagementMode , "selectedvalue");
            this.dbT_AssetCategories.DbC_notes.BoundControls.Add(this.txt_AssetCategories_Notes, "text");

            // Set up DbLookUp for Store
            //this.dbl_stor_id .DbObject  = this.dbT_Dbo_Stores ;
            //this.dbl_stor_id.Filters.AddBoundControl(this.dbT_Dbo_Stores .DbC_stor_id , BasicDAL.ComparisionOperator.Equal, this.txt_stor_id, "text" );
            //this.dbl_stor_id.BoundControls.Add(this.dbT_Dbo_Stores.DbC_stor_name , this.txt_stor_name, "text");
            //this.dbl_stor_id.BoundControls.Add(this.dbT_Dbo_Stores.DbC_city , this.txt_stor_city, "text");


            this.cmb_AssetCategories_ManagementMode.DataSource = Utilities.EnumToDataTable(typeof(eManagementModes), Utilities.EnumToDataTableValueItem.Value, Utilities.EnumToDataTableDisplayItem.ValueDescription);
            this.cmb_AssetCategories_ManagementMode.ValueMember = "id";
            this.cmb_AssetCategories_ManagementMode.DisplayMember  = "desc";


            BasicDALWisejControls.Utilities.BoundComboBoxItemsToDbObject(this.cmb_AssetCategories_MeasureUnitID , this.dbT_MeasureUnits, this.dbT_MeasureUnits .DbC_description.DbColumnNameE, this.dbT_MeasureUnits.DbC_id.DbColumnNameE, true,DBNull .Value );
            BasicDALWisejControls.Utilities.BoundComboBoxItemsToDbObject(this.cmb_AssetCategories_VATCode, this.dbT_VAT, this.dbT_VAT.DbC_description.DbColumnNameE, this.dbT_VAT.DbC_id.DbColumnNameE, true, 0);


            this.dataNavigator1.DbObject = this.dbT_AssetCategories ;
            this.dataNavigator1.ManageNavigation = false;
            this.tabList.Hidden = true;
            //this.dataNavigator1.DataGridListView = this.dgvList;
            //this.dataNavigator1.InitDataNavigator(true);

            this.LoadCategoryTreeView(true);
            this.LoadComboCategoryTreeView();
            
            
            
            
        }

        private void LoadCategoryTreeView(bool SelectFirsNode=true)
        {

            this.dbV_AssetCategoriesTree.OrderBy = this.dbV_AssetCategoriesTree.DbC_level.DbColumnNameE +", "+ this.dbV_AssetCategoriesTree.DbC_codepath .DbColumnNameE;
            this.dbV_AssetCategoriesTree.Open(true);
            this.treeView.Nodes.Clear();
            AssetEasy.Utilities.TreeViewLoad(ref this.treeView, DBNull.Value, null, this.dbV_AssetCategoriesTree.DataTable, "ID", "ParentID", "Description", "CodePath", "Level, CodePath");
            if (SelectFirsNode == true)
                this.treeView.SelectedNode = this.treeView.Nodes[0];
        }
        private void LoadComboCategoryTreeView(string selectedNodeName="")
        {

            this.dbV_AssetCategoriesTree.Open(true);
            this.tvc_AssetCategories_ParentID .Nodes.Clear();
            this.tvc_AssetCategories_ParentID.Nodes.Add("0", "0 - NO PARENT");
            AssetEasy.Utilities.TreeViewComboBoxLoad (ref this.tvc_AssetCategories_ParentID, DBNull.Value, null, this.dbV_AssetCategoriesTree.DataTable, "ID", "ParentID", "Description", "CodePath","Level, CodePath");
            if (selectedNodeName != null)
            {
                TreeNode node = AssetEasy.Utilities.GetTreeNodeByName(this.tvc_AssetCategories_ParentID.Nodes, selectedNodeName);
                if (node != null)
                    this.tvc_AssetCategories_ParentID.SelectedItem = node;
            }

        }


        private void GetAssetCategoryFullMnemonicCode(string CategoryID, ref DbV_AssetCategoriesTree dbV_AssetCategoriesTree)
        {
            BasicDAL.DbFilters DbF = new BasicDAL.DbFilters();
            DbF.Add(dbV_AssetCategoriesTree.DbC_id, BasicDAL.ComparisionOperator.Equal, CategoryID);
            dbV_AssetCategoriesTree.FiltersGroup.Clear();
            dbV_AssetCategoriesTree.FiltersGroup.Add(DbF);
            dbV_AssetCategoriesTree.DoQuery();
            if (dbV_AssetCategoriesTree .RowCount > 0)
            {
                this.txt_AssetCategories_FullMnemonicCode.Text = dbV_AssetCategoriesTree.DbC_codepath.Value.ToString();
            }
            else
            {
                this.txt_AssetCategories_FullMnemonicCode.Text = dbV_AssetCategoriesTree.DbC_codepath.Value.ToString();
            }

        }

        #region DataNavigatorHandlers
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
        #endregion

        private void ManageTabDataNavigator(string Item)
        {
            switch (Item.ToLower())
            {
                case "tabform":
                    this.dataNavigator1.DataGridActive = false;
                    break;

                case "tablist":
                    this.dataNavigator1.DataGridActive = true;
                    this.dataNavigator1.DataGrid.DataSource = this.dataNavigator1.DbObject.DataTable;
                    break;

                default:
                    break;
            }
        }
        private void dataNavigator1_eFind()
        {

            this.qbe_Categories();

        }

        private void qbe_Categories()
        {
            DbV_AssetCategoriesTree  QBEDbObject = new  DbV_AssetCategoriesTree () ;
            QBEDbObject.Init(this.DbConfig);

            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();
            QBEForm.FKeyEnabled = false;
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.SelectedRows;
            QBEForm.Text = "Search for " + this.Text;
            QBEForm.DbObject = QBEDbObject;
            QBEForm.QueryDbObject = this.dbT_AssetCategories ;
            QBEForm.AutoLoadAll = true;
            QBEForm.DbColumnsMapping.Add(QBEDbObject.DbC_id , this.dbT_AssetCategories.DbC_id);
            QBEForm.QBEColumns.Add(QBEDbObject.DbC_codepath, "Code", "", "", true, true, -1);
            QBEForm.QBEColumns.Add(QBEDbObject.DbC_id , "ID", "", "",true, true);
            QBEForm.QBEColumns.Add(QBEDbObject.DbC_nodepath, "Full Description", "", "", true, true,-2);
            QBEForm.DbObject.OrderBy = QBEDbObject.DbC_codepath.DbColumnName;
            QBEForm.UseExactSearchForString = true;

            QBEForm.QBEColumns.GetItem(QBEDbObject.DbC_codepath).Font = new System.Drawing.Font("Arial", 20, System.Drawing.FontStyle.Bold);
            QBEForm.QBEColumns.GetItem(QBEDbObject.DbC_codepath).Aligment = DataGridViewContentAlignment.TopCenter;
            QBEForm.QBEColumns.GetItem(QBEDbObject.DbC_codepath).ForeColor = System.Drawing.Color.Red;

            QBEForm.ShowQBE(this);
        }

        private void qbe_Store()
        {
            //DbT_dbo_stores QBEDbObject = new DbT_dbo_stores();
            //QBEDbObject.Init(this.DbConfig.Clone());
            //BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();
            //QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            //QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.BoundControls;
            //QBEForm.Text = "Search for Store";
            //QBEForm.DbObject = QBEDbObject;
            //QBEForm.AutoLoadAll = true;
            //QBEForm.BoundControls.Add(QBEDbObject .DbC_stor_id ,this.txt_stor_id ,"text");
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
                if (this.treeView.SelectedNode!=null)
                    this.tvc_AssetCategories_ParentID.SelectedItem = this.treeView .SelectedNode;
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
                if (this.dataNavigator1 .DbObject .ExecutionResult.Success)
                    this.treeView.SelectedNode.Remove();

            }
            else
            {
               
                if (this.dataNavigator1.DataGrid != null)
                    this.dataNavigator1.DataGrid_Delete();
            }
        }

        private void dataNavigator1_eMoveFirst()
        {

            this.treeView.SelectedNode = this.treeView.Nodes[0];

            //if (this.dataNavigator1.DataGridActive == false)
            //{
            //    this.dataNavigator1.DbObject.MoveFirst();
            //}
            //else
            //{
            //    if (this.dataNavigator1.DataGrid != null)
            //        this.dataNavigator1.DataGrid_MoveFirst();
            //}

        }

        private void dataNavigator1_eMoveLast()
        {

            this.treeView.SelectedNode = this.treeView.Nodes[this.treeView.Nodes.Count -1];
            //if (this.dataNavigator1.DataGridActive == false)
            //{
            //    this.dataNavigator1.DbObject.MoveLast();
            //}
            //else
            //{
            //    if (this.dataNavigator1.DataGrid != null)
            //        this.dataNavigator1.DataGrid_MoveLast();
            //}
        }

        private void dataNavigator1_eMoveNext()
        {

            if (this.treeView.SelectedNode.NextVisibleNode  == null)
            {
                this.treeView.SelectedNode = this.treeView.Nodes[this.treeView.Nodes .Count -1];
            }
            else
            {
                this.treeView.SelectedNode = this.treeView.SelectedNode.NextVisibleNode;
            }

            //if (this.dataNavigator1.DataGridActive == false)
            //{
            //    this.dataNavigator1.DbObject.MoveNext();
            //}
            //else
            //{
            //    if (this.dataNavigator1.DataGrid != null)
            //        this.dataNavigator1.DataGrid_MoveNext();
            //}
        }

        private void dataNavigator1_eMovePrevious()
        {
            if (this.treeView.SelectedNode.PrevVisibleNode == null)
            {
                this.treeView.SelectedNode = this.treeView.Nodes[0];
            }
            else
            {
                this.treeView.SelectedNode = this.treeView.SelectedNode.PrevVisibleNode;
            }
            
            //if (this.dataNavigator1.DataGridActive == false)
            //{
            //    this.dataNavigator1.DbObject.MovePrevious();
            //}
            //else
            //{
            //    if (this.dataNavigator1.DataGrid != null)
            //        this.dataNavigator1.DataGrid_MovePrevious();
            //}
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


         //   MessageBox.Show("SelectedValue" + this.tvc_AssetCategories_ParentID.SelectedValue);

            if (this.dataNavigator1.AddNewPending == true && this.appConfig.IsPublicDemo == true)
            {
                MessageBox.Show(this.appConfig.PublicDemoMessage, String.Format("{0} - {1}", Application.ProductName, this.Text));
                this.dataNavigator1.Undo();
                return;
            }

            if (this.dataNavigator1.DataGridActive == false)
            {
                string NodeName = "";
                string NewParent = "";
                if (this.dataNavigator1.AddNewPending == false)
                    NodeName = this.txt_AssetCategories_ID.Text;
                if (this.tvc_AssetCategories_ParentID.SelectedItem!=null )
                    NewParent=this.tvc_AssetCategories_ParentID.SelectedItem.Name;

                if (NodeName ==NewParent )
                {
                    MessageBox.Show(@"L'elemento non può essere essere Padre di se stesso!");
                    return;
                }

                if (this.tvc_AssetCategories_ParentID.SelectedItem != null)
                {
                    this.dbT_AssetCategories.DbC_parentid.Value = Convert.ToInt32(NewParent);
                }
                else
                {
                    this.dbT_AssetCategories.DbC_parentid.Value = DBNull.Value;
                }

                this.dbT_AssetCategories .Update();
                NodeName = this.txt_AssetCategories_ID.Text;
                this.LoadCategoryTreeView(false);
                this.LoadComboCategoryTreeView();
                this.treeView.SelectedNode = AssetEasy.Utilities.GetTreeNodeByName(this.treeView.Nodes, NodeName);
                if (this.treeView.SelectedNode != null)
                    this.treeView.SelectedNode.Expand();

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
                TreeNode node = AssetEasy.Utilities.GetTreeNodeByName(this.tvc_AssetCategories_ParentID.Nodes, this.dbT_AssetCategories.DbC_parentid.Value .ToString());
                if (node != null)
                {
                    this.tvc_AssetCategories_ParentID.SelectedItem = node;
                }
                else
                {
                    this.tvc_AssetCategories_ParentID.SelectedItem = null;
                }
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



        private void dataNavigator1_eBoundCompleted()
        {

        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            this.InitDataContext();
        }

       

       

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null)
                return;

            this.txt_NodeFullPath.Text = e.Node.FullPath.ToString();
            this.GetSelectedCategory(e.Node.Name, ref this.dbT_AssetCategories);
            if (e.Node.Parent != null)
            {
                this.tvc_AssetCategories_ParentID.SelectedItem = e.Node.Parent;
            }
            else
            {
                this.tvc_AssetCategories_ParentID.SelectedItem = null;
            }
        }

        private void LoadCategoryForm(string NodeName, ref DbT_AssetCategories dbT_AssetCategories )
        {
            this.GetSelectedCategory(NodeName, ref this.dbT_AssetCategories);
        }

        private BasicDAL.ExecutionResult  GetSelectedCategory(string ID, ref DbT_AssetCategories dbT_AssetCategories) 
        {
            BasicDAL.ExecutionResult er;
            BasicDAL.DbFilters dbFilters = new BasicDAL.DbFilters();
            dbFilters.Add(dbT_AssetCategories.DbC_id, BasicDAL.ComparisionOperator.Equal, ID);
            dbT_AssetCategories.FiltersGroup.Clear();
            dbT_AssetCategories.FiltersGroup.Add(dbFilters);
            dbT_AssetCategories.Open(true);
            er = dbT_AssetCategories.ExecutionResult;
            if (er.Failed == false)
            {
                this.GetAssetCategoryFullMnemonicCode(dbT_AssetCategories.DbC_id.Value .ToString (), ref this.dbV_AssetCategoriesTreeCodePath);
            }
            return er;

        }
            

        private void splitContainer1_Panel1_ToolClick(object sender, ToolClickEventArgs e)
        {
            switch (e.Tool .Name.ToLower())
            {

                case "expand":
                    this.treeView.ExpandAll();
                break;

                case "collapse":
                    this.treeView.CollapseAll();
                break;

                case "refresh":

                    this.LoadCategoryTreeView(true);
                    this.LoadComboCategoryTreeView();
                    if (this.treeView.SelectedNode.Parent == null)
                    {
                        this.tvc_AssetCategories_ParentID.SelectedValue = null;
                    }
                    break;

                default:
                break;
            }
        }

    
    }
}
