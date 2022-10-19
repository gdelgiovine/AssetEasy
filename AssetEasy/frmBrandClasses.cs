using System;
using Wisej.Web;
using AssetEasy.DataModel;
using System.Collections.Generic;

namespace AssetEasy
{
    public partial class frmBrandClasses : Form
    {

        public AppConfig appConfig;

        private BasicDAL.DbConfig DbConfig;
        private DbV_BrandClassesTree dbV_BrandClassesTree = new DbV_BrandClassesTree();
        private DbV_BrandClassesTree dbV_BrandClassesTreeCodePath = new DbV_BrandClassesTree();
        private DbT_BrandClasses dbT_BrandClasses = new DbT_BrandClasses();
        private DbT_BrandClasses dbT_BrandClassesParent = new DbT_BrandClasses();
        private bool FormInit = false;
        private bool DataNavigatorHandlerInitialized = false;

        public frmBrandClasses()
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

            this.DbConfig = this.appConfig.DbConfig.Clone();
            BasicDALWisejControls.BasicDALMessageBox BasicDALMessageBox = new BasicDALWisejControls.BasicDALMessageBox();
            this.DbConfig.RedirectErrorsNotificationTo = BasicDALMessageBox;

            InitDataNavigatorHandler();

            //Initialize DBObjects
            this.dbT_BrandClasses.Init(this.DbConfig);
            this.dbT_BrandClasses.DataBinding = BasicDAL.DataBoundControlsBehaviour.BasicDALDataBinding;
            this.dbT_BrandClassesParent.Init(this.DbConfig);
            this.dbV_BrandClassesTree.Init(this.DbConfig);
            this.dbV_BrandClassesTreeCodePath.Init(this.DbConfig);


            //binding for BasicDAL DbObject columns into UI objects.
            // EX: this.DbObject.dbstringcolumn.BoundControls.Add(this.txt_dbstringcolumn, "text");
            this.dbT_BrandClasses.DbC_id.BoundControls.Add(this.txt_Categories_ID, "text");
            this.dbT_BrandClasses.DbC_description.BoundControls.Add(this.txt_Categories_Description, "text");
            this.dbT_BrandClasses.DbC_mnemoniccode.BoundControls.Add(this.txt_Categories_MnemonicCode, "text");
            this.dbT_BrandClasses.DbC_notes.BoundControls.Add(this.txt_Categories_Notes, "text");

            // Set up DbLookUp for Store
            //this.dbl_stor_id .DbObject  = this.dbT_Dbo_Stores ;
            //this.dbl_stor_id.Filters.AddBoundControl(this.dbT_Dbo_Stores .DbC_stor_id , BasicDAL.ComparisionOperator.Equal, this.txt_stor_id, "text" );
            //this.dbl_stor_id.BoundControls.Add(this.dbT_Dbo_Stores.DbC_stor_name , this.txt_stor_name, "text");
            //this.dbl_stor_id.BoundControls.Add(this.dbT_Dbo_Stores.DbC_city , this.txt_stor_city, "text");




            this.dataNavigator1.DbObject = this.dbT_BrandClasses;
            this.dataNavigator1.ManageNavigation = false;
            this.tabList.Hidden = true;
            //this.dataNavigator1.DataGridListView = this.dgvList;
            //this.dataNavigator1.InitDataNavigator(true);

            this.LoadBrandTreeView(true);
            this.LoadComboCategoryTreeView();
        }

        private void LoadBrandTreeView(bool SelectFirsNode = true)
        {

            this.dbV_BrandClassesTree.FiltersGroup.Clear();
            this.dbV_BrandClassesTree.Open(true);
            this.treeView.Nodes.Clear();
            AssetEasy.Utilities.TreeViewLoad(ref this.treeView, DBNull.Value, null, this.dbV_BrandClassesTree.DataTable, "ID", "ParentID", "Description", "CodePath", "Level, CodePath");
            if (SelectFirsNode == true)
                this.treeView.SelectedNode = this.treeView.Nodes[0];
        }
        private void LoadComboCategoryTreeView(string selectedNodeName = "")
        {
            this.dbV_BrandClassesTree.FiltersGroup.Clear();
            this.dbV_BrandClassesTree.Open(true);
            this.tvc_Categories_ParentID.Nodes.Clear();
            this.tvc_Categories_ParentID.Nodes.Add("0", "0 - NO PARENT");
            AssetEasy.Utilities.TreeViewComboBoxLoad(ref this.tvc_Categories_ParentID, DBNull.Value, null, this.dbV_BrandClassesTree.DataTable, "ID", "ParentID", "Description", "CodePath", "Level, CodePath");
            if (selectedNodeName != null)
            {
                TreeNode node = AssetEasy.Utilities.GetTreeNodeByName(this.tvc_Categories_ParentID.Nodes, selectedNodeName);
                if (node != null)
                    this.tvc_Categories_ParentID.SelectedItem = node;
            }

        }


        private void GetBrandClassCodePath(string CategoryID, ref DbV_BrandClassesTree dbVCodePath)
        {
            BasicDAL.DbFilters DbF = new BasicDAL.DbFilters();
            DbF.Add(dbVCodePath.DbC_id, BasicDAL.ComparisionOperator.Equal, CategoryID);
            dbVCodePath.FiltersGroup.Clear();
            dbVCodePath.FiltersGroup.Add(DbF);
            dbVCodePath.DoQuery();
            if (dbVCodePath.RowCount > 0)
            {
                this.txt_Categories_FullMnemonicCode.Text = dbVCodePath.DbC_codepath.Value.ToString();
            }
            else
            {
                this.txt_Categories_FullMnemonicCode.Text = dbVCodePath.DbC_codepath.Value.ToString();
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

            this.qbe_Discounts();

        }

        private void qbe_Discounts()
        {
            //DbT_dbo_discounts QBEDbObject = new DbT_dbo_discounts() ;
            //QBEDbObject.Init(this.DbConfig.Clone());

            //BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();
            //QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            //QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.SelectedRows;
            //QBEForm.Text = "Search for " + this.Text;
            //QBEForm.DbObject = QBEDbObject;
            //QBEForm.QueryDbObject = this.dbT_Dbo_Discounts;
            //QBEForm.AutoLoadAll = true;
            //QBEForm.DbColumnsMapping.Add(QBEDbObject.DbC_discount_id , this.dbT_Dbo_Discounts .DbC_discount_id);
            ////QBEForm.QBEColumns.Add(QBEDbObject.dbint, "DB INT", "", "1", true, true);
            //QBEForm.ShowQBE(this);
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
                if (this.treeView.SelectedNode != null)
                    this.tvc_Categories_ParentID.SelectedItem = this.treeView.SelectedNode;
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
                if (this.dataNavigator1.DbObject.ExecutionResult.Success)
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

            this.treeView.SelectedNode = this.treeView.Nodes[this.treeView.Nodes.Count - 1];
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

            if (this.treeView.SelectedNode.NextVisibleNode == null)
            {
                this.treeView.SelectedNode = this.treeView.Nodes[this.treeView.Nodes.Count - 1];
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
                    NodeName = this.txt_Categories_ID.Text;
                if (this.tvc_Categories_ParentID.SelectedItem != null)
                    NewParent = this.tvc_Categories_ParentID.SelectedItem.Name;

                if (this.tvc_Categories_ParentID.SelectedItem != null)
                    NewParent = this.tvc_Categories_ParentID.SelectedItem.Name;

                if (NodeName == NewParent)
                {
                    MessageBox.Show(@"L'elemento non può essere essere Padre di se stesso!");
                    return;
                }

                if (this.tvc_Categories_ParentID.SelectedItem != null)
                {
                    this.dbT_BrandClasses.DbC_parentid.Value = Convert.ToInt32(NewParent);
                }
                else
                {
                    this.dbT_BrandClasses.DbC_parentid.Value = DBNull.Value;
                }

                this.dbT_BrandClasses.Update();
                NodeName = this.txt_Categories_ID.Text;
                this.LoadBrandTreeView(false);
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
                TreeNode node = AssetEasy.Utilities.GetTreeNodeByName(this.tvc_Categories_ParentID.Nodes, this.dbT_BrandClasses.DbC_parentid.Value.ToString());
                if (node != null)
                {
                    this.tvc_Categories_ParentID.SelectedItem = node;
                }
                else
                {
                    this.tvc_Categories_ParentID.SelectedItem = null;
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




        private void txt_stor_id_ToolClick(object sender, ToolClickEventArgs e)
        {
            if (e.Tool.Name.ToLower() == "search")
            {
                this.qbe_Store();
            }
            if (e.Tool.Name.ToLower() == "clear")
            {
                // this.txt_stor_id .Text="";
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null)
                return;
            string Name = e.Node.Name;
            this.txt_NodeFullPath.Text = e.Node.FullPath.ToString();
            if (this.GetSelectedBrand(Name, ref dbT_BrandClasses, ref dbV_BrandClassesTreeCodePath).Failed == false)
            {
                if (e.Node.Parent != null)
                {
                    this.tvc_Categories_ParentID.SelectedItem = e.Node.Parent;
                }
                else
                {
                    this.tvc_Categories_ParentID.SelectedItem = null;
                }
            }

        }


        private BasicDAL.ExecutionResult GetSelectedBrand(string ID, ref DbT_BrandClasses dbT, ref DbV_BrandClassesTree dbVCodePath)
        {
            BasicDAL.ExecutionResult er;
            BasicDAL.DbFilters dbFilters = new BasicDAL.DbFilters();
            dbFilters.Add(dbT.DbC_id, BasicDAL.ComparisionOperator.Equal, ID);
            dbT.FiltersGroup.Clear();
            dbT.FiltersGroup.Add(dbFilters);
            dbT.Open(true);
            er = dbT.ExecutionResult;
            if (er.Failed == false)
            {
                this.GetBrandClassCodePath(dbT.DbC_id.Value.ToString(), ref dbVCodePath);
            }
            return er;

        }


        private void splitContainer1_Panel1_ToolClick(object sender, ToolClickEventArgs e)
        {
            switch (e.Tool.Name.ToLower())
            {

                case "expand":
                    this.treeView.ExpandAll();
                    break;

                case "collapse":
                    this.treeView.CollapseAll();
                    break;

                case "refresh":

                    this.LoadBrandTreeView(true);
                    this.LoadComboCategoryTreeView();
                    if (this.treeView.SelectedNode != null)
                    {
                        if (this.treeView.SelectedNode.Parent == null)
                        {
                            this.tvc_Categories_ParentID.SelectedValue = null;
                        }
                    }
                    break;

                default:
                    break;
            }
        }

        private void frmBrandCategories_Load(object sender, EventArgs e)
        {
            this.InitDataContext();
        }

        private void frmBrandClasses_Load(object sender, EventArgs e)
        {
            this.InitDataContext();

        }
    }
}
