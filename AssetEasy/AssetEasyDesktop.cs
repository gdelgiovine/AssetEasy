using System;
using Wisej.Web;

namespace AssetEasy
{
	public partial class AssetEasyDesktop : Desktop
	{
        public AppConfig appConfig = new AppConfig();
      
		public AssetEasyDesktop()
		{
			InitializeComponent();
		}


        private void LoadAppConfig()
        {

            this.appConfig.DbConfig.Name = "Main";
            this.appConfig.DbConfig.RuntimeUI = BasicDAL.RuntimeUI.Wisej;
            this.appConfig.DbConfig.RedirectErrorsNotificationTo = new BasicDALWisejControls.BasicDALMessageBox();
            this.appConfig.DbConfig.Provider = BasicDAL.Providers.SqlServer;
          
            if (!this.appConfig.ReadWebConfigAppConfig())
            {
                MessageBox.Show("Error reading Web.Config parameters!");
                Application.Exit();
            }

            //this.appConfig.DbConfig.DbConnectionKeepOpen = false;
        }
        private void Desktop_Load(object sender, EventArgs e)
        {
            this.LoadAppConfig();
            //this.txt_CurrentUser.Text = this.appConfig.CurrentWebAppUser.UserName;
        }
        private void mnuBar1_MenuItemClicked(object sender, MenuItemEventArgs e)
        {
            ManageMenuBar(e.MenuItem.Name);
        }

        private void ManageMenuBar(string MenuItemName)
        {
            switch (MenuItemName)
            {
                case "mnuFile_Exit":
                    break;

                case "mnuDiscounts":
                    //frmDiscounts frmDiscounts = new frmDiscounts();
                    //BasicDALWisejControls.Utilities.SetFixedWindowStyles(frmDiscounts);
                    //frmDiscounts.appConfig = this.appConfig;
                    //frmDiscounts.Show();
                    break;


                case "mnuLogin":

                    if (MessageBox.Show("Confirm Logout?", "Wisej Pubs Demo App", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        CloseAllOpenForms();
                        Application.Desktop = null;
                        frmLogin frmLogin = new frmLogin();
                        frmLogin.Show();
                    }
                    break;

                default:
                    break;
            }
        }


        private void CloseAllOpenForms(Form DoNotCloseForm = null)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (DoNotCloseForm == null)
                {
                    Application.OpenForms[i].Close();
                }
                else
                {
                    if (Application.OpenForms[i].Name != DoNotCloseForm.Name)
                        Application.OpenForms[i].Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAssetCategories frmAssetCategories = new frmAssetCategories();
            frmAssetCategories.appConfig = this.appConfig;
            frmAssetCategories.Show();
        }

        private void AssetEasyDesktop_Load(object sender, EventArgs e)
        {
            
            this.LoadAppConfig();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBrandCategories  frmBrandCategories = new frmBrandCategories();
            frmBrandCategories.appConfig = this.appConfig;
            frmBrandCategories.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmIssueCategories frmIssueCategories = new frmIssueCategories();
            frmIssueCategories.appConfig = this.appConfig;
            frmIssueCategories.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmOperatorCategories frmOperatorCategories = new frmOperatorCategories();
            frmOperatorCategories.appConfig = this.appConfig;
            frmOperatorCategories.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmVendorCategories frm = new frmVendorCategories();
            frm.appConfig = this.appConfig;
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmAssets frm = new frmAssets ();
            frm.appConfig = this.appConfig;
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmBrandClasses  frm = new frmBrandClasses ();
            frm.appConfig = this.appConfig;
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmLocations  frm = new frmLocations ();
            frm.appConfig = this.appConfig;
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmOwners frm = new frmOwners();
            frm.appConfig = this.appConfig;
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        [Wisej.Core.WebMethod]
        public static string WebMethod(string par1)
        {
            return "Par1 = " + par1;
        }

        private void AssetEasyDesktop_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
            this.label1.Text = e.KeyCode.ToString();
        }

        private void AssetEasyDesktop_KeyDown(object sender, KeyEventArgs e)
        {
            this.label1.Text = e.KeyCode.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            frmVendors frm = new frmVendors ();
            frm.appConfig = this.appConfig;
            frm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frmVAT frm = new frmVAT();
            frm.appConfig = this.appConfig;
            frm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            frmRecordCodes frm = new frmRecordCodes();
            frm.appConfig = this.appConfig;
            frm.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Application.CurrentCulture = new System.Globalization.CultureInfo("en-EN");

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.CurrentCulture = new System.Globalization.CultureInfo("it-IT");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            frmRecords frm = new frmRecords();
            frm.appConfig = this.appConfig;
            frm.Show();



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Application.LoadTheme(this.comboBox1.Text);


        }

        private void button17_Click(object sender, EventArgs e)
        {

            frmTickets  frm = new frmTickets ();
            frm.appConfig = this.appConfig;
            frm.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {

            frmTicketEvents frm = new frmTicketEvents();
            frm.appConfig = this.appConfig;
            frm.Show();
        }
    }
}
   
