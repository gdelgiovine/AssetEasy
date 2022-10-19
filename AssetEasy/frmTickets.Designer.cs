
namespace AssetEasy
{
    partial class frmTickets
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
            Wisej.Web.ComponentTool componentTool7 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool8 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool9 = new Wisej.Web.ComponentTool();
            this.tabDataNavigator = new Wisej.Web.TabControl();
            this.tabForm = new Wisej.Web.TabPage();
            this.pnl_Details = new Wisej.Web.Panel();
            this.dgv_Details = new Wisej.Web.DataGridView();
            this.dgvc_EventID = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dgvc_EventTicketID = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dgvc_EventParentID = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dgvc_EventDate = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dgvc_EventTime = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dgvc_EventCustomerNotes = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dgvc_EventOperatorNotes = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dgvc_EventDueDate = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dgvc_EventDueTime = new Wisej.Web.DataGridViewTextBoxColumn();
            this.pnl_Master = new Wisej.Web.Panel();
            this.cmb_ticket_priority = new Wisej.Web.ComboBox();
            this.cmb_ticket_severity = new Wisej.Web.ComboBox();
            this.txt_tickets_status = new Wisej.Web.TextBox();
            this.txt_operators_id = new Wisej.Web.TextBox();
            this.txt_operators_name = new Wisej.Web.TextBox();
            this.txt_tickets_creationoperatorid = new BasicDALWisejControls.DbLookUpTextBox(this.components);
            this.txt_issuecategory_id = new Wisej.Web.TextBox();
            this.txt_issuecategories_description = new Wisej.Web.TextBox();
            this.txt_tickets_issuecategoryid = new BasicDALWisejControls.DbLookUpTextBox(this.components);
            this.txt_tickets_parentid = new Wisej.Web.TextBox();
            this.button1 = new Wisej.Web.Button();
            this.txt_tickets_creationtime = new Wisej.Web.TextBox();
            this.txt_tickets_id = new Wisej.Web.TextBox();
            this.txt_tickets_mnemoniccode = new Wisej.Web.TextBox();
            this.txt_customers_id = new Wisej.Web.TextBox();
            this.txt_customers_fullname = new Wisej.Web.TextBox();
            this.txt_tickets_customerid = new BasicDALWisejControls.DbLookUpTextBox(this.components);
            this.dtp_tickets_creationdate = new Wisej.Web.DateTimePicker();
            this.tabList = new Wisej.Web.TabPage();
            this.dgvList = new Wisej.Web.DataGridView();
            this.tabNotes = new Wisej.Web.TabPage();
            this.txt_tickets_operatornotes = new Wisej.Web.TextBox();
            this.txt_tickets_customernotes = new Wisej.Web.TextBox();
            this.tabDetails = new Wisej.Web.TabPage();
            this.dataNavigator1 = new BasicDALWisejControls.DataNavigator();
            this.txt_tickets_requestername = new Wisej.Web.TextBox();
            this.txt_tickets_requesteremail = new Wisej.Web.TextBox();
            this.txt_tickets_requesterphone = new Wisej.Web.TextBox();
            this.label2 = new Wisej.Web.Label();
            this.tabDataNavigator.SuspendLayout();
            this.tabForm.SuspendLayout();
            this.pnl_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Details)).BeginInit();
            this.pnl_Master.SuspendLayout();
            this.tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.tabNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDataNavigator
            // 
            this.tabDataNavigator.Controls.Add(this.tabForm);
            this.tabDataNavigator.Controls.Add(this.tabList);
            this.tabDataNavigator.Controls.Add(this.tabNotes);
            this.tabDataNavigator.Controls.Add(this.tabDetails);
            this.tabDataNavigator.Dock = Wisej.Web.DockStyle.Fill;
            this.tabDataNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabDataNavigator.Name = "tabDataNavigator";
            this.tabDataNavigator.PageInsets = new Wisej.Web.Padding(0, 41, 2, 2);
            this.tabDataNavigator.Size = new System.Drawing.Size(1205, 526);
            this.tabDataNavigator.TabIndex = 1;
            this.tabDataNavigator.SelectedIndexChanged += new System.EventHandler(this.tabDataNavigator_SelectedIndexChanged_1);
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.pnl_Details);
            this.tabForm.Controls.Add(this.pnl_Master);
            this.tabForm.Location = new System.Drawing.Point(0, 41);
            this.tabForm.Name = "tabForm";
            this.tabForm.Size = new System.Drawing.Size(1203, 483);
            this.tabForm.Text = "Master";
            // 
            // pnl_Details
            // 
            this.pnl_Details.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.pnl_Details.Controls.Add(this.label2);
            this.pnl_Details.Controls.Add(this.dgv_Details);
            this.pnl_Details.Location = new System.Drawing.Point(3, 195);
            this.pnl_Details.Name = "pnl_Details";
            this.pnl_Details.Size = new System.Drawing.Size(1192, 283);
            this.pnl_Details.TabIndex = 33;
            // 
            // dgv_Details
            // 
            this.dgv_Details.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dgv_Details.AutoGenerateColumns = false;
            this.dgv_Details.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.dgvc_EventID,
            this.dgvc_EventTicketID,
            this.dgvc_EventParentID,
            this.dgvc_EventDate,
            this.dgvc_EventTime,
            this.dgvc_EventCustomerNotes,
            this.dgvc_EventOperatorNotes,
            this.dgvc_EventDueDate,
            this.dgvc_EventDueTime});
            this.dgv_Details.Location = new System.Drawing.Point(3, 31);
            this.dgv_Details.Name = "dgv_Details";
            this.dgv_Details.Size = new System.Drawing.Size(1185, 242);
            this.dgv_Details.TabIndex = 0;
            // 
            // dgvc_EventID
            // 
            this.dgvc_EventID.DataPropertyName = "ID";
            this.dgvc_EventID.HeaderText = "Event ID";
            this.dgvc_EventID.Name = "dgvc_EventID";
            // 
            // dgvc_EventTicketID
            // 
            this.dgvc_EventTicketID.DataPropertyName = "TicketID";
            this.dgvc_EventTicketID.HeaderText = "Ticket ID";
            this.dgvc_EventTicketID.Name = "dgvc_EventTicketID";
            // 
            // dgvc_EventParentID
            // 
            this.dgvc_EventParentID.DataPropertyName = "ParentID";
            this.dgvc_EventParentID.HeaderText = "Parent Event ID";
            this.dgvc_EventParentID.Name = "dgvc_EventParentID";
            // 
            // dgvc_EventDate
            // 
            this.dgvc_EventDate.DataPropertyName = "Date";
            this.dgvc_EventDate.HeaderText = "Date";
            this.dgvc_EventDate.Name = "dgvc_EventDate";
            // 
            // dgvc_EventTime
            // 
            this.dgvc_EventTime.DataPropertyName = "Time";
            this.dgvc_EventTime.HeaderText = "Time";
            this.dgvc_EventTime.Name = "dgvc_EventTime";
            // 
            // dgvc_EventCustomerNotes
            // 
            this.dgvc_EventCustomerNotes.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvc_EventCustomerNotes.DataPropertyName = "CustomerNotes";
            this.dgvc_EventCustomerNotes.HeaderText = "Customer Notes";
            this.dgvc_EventCustomerNotes.Name = "dgvc_EventCustomerNotes";
            // 
            // dgvc_EventOperatorNotes
            // 
            this.dgvc_EventOperatorNotes.DataPropertyName = "OperatorNotes";
            this.dgvc_EventOperatorNotes.HeaderText = "Operator Notes";
            this.dgvc_EventOperatorNotes.Name = "dgvc_EventOperatorNotes";
            // 
            // dgvc_EventDueDate
            // 
            this.dgvc_EventDueDate.DataPropertyName = "DueDate";
            this.dgvc_EventDueDate.HeaderText = "Due Date";
            this.dgvc_EventDueDate.Multiline = true;
            this.dgvc_EventDueDate.Name = "dgvc_EventDueDate";
            // 
            // dgvc_EventDueTime
            // 
            this.dgvc_EventDueTime.DataPropertyName = "DuteTime";
            this.dgvc_EventDueTime.HeaderText = "Due Time";
            this.dgvc_EventDueTime.Name = "dgvc_EventDueTime";
            // 
            // pnl_Master
            // 
            this.pnl_Master.Controls.Add(this.txt_tickets_requesterphone);
            this.pnl_Master.Controls.Add(this.txt_tickets_requesteremail);
            this.pnl_Master.Controls.Add(this.txt_tickets_requestername);
            this.pnl_Master.Controls.Add(this.cmb_ticket_priority);
            this.pnl_Master.Controls.Add(this.cmb_ticket_severity);
            this.pnl_Master.Controls.Add(this.txt_tickets_status);
            this.pnl_Master.Controls.Add(this.txt_operators_id);
            this.pnl_Master.Controls.Add(this.txt_operators_name);
            this.pnl_Master.Controls.Add(this.txt_tickets_creationoperatorid);
            this.pnl_Master.Controls.Add(this.txt_issuecategory_id);
            this.pnl_Master.Controls.Add(this.txt_issuecategories_description);
            this.pnl_Master.Controls.Add(this.txt_tickets_issuecategoryid);
            this.pnl_Master.Controls.Add(this.txt_tickets_parentid);
            this.pnl_Master.Controls.Add(this.button1);
            this.pnl_Master.Controls.Add(this.txt_tickets_creationtime);
            this.pnl_Master.Controls.Add(this.txt_tickets_id);
            this.pnl_Master.Controls.Add(this.txt_tickets_mnemoniccode);
            this.pnl_Master.Controls.Add(this.txt_customers_id);
            this.pnl_Master.Controls.Add(this.txt_customers_fullname);
            this.pnl_Master.Controls.Add(this.txt_tickets_customerid);
            this.pnl_Master.Controls.Add(this.dtp_tickets_creationdate);
            this.pnl_Master.Location = new System.Drawing.Point(4, 3);
            this.pnl_Master.Name = "pnl_Master";
            this.pnl_Master.Size = new System.Drawing.Size(1187, 173);
            this.pnl_Master.TabIndex = 32;
            // 
            // cmb_ticket_priority
            // 
            this.cmb_ticket_priority.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cmb_ticket_priority.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_ticket_priority.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.cmb_ticket_priority.LabelText = "Priority";
            this.cmb_ticket_priority.Location = new System.Drawing.Point(825, 119);
            this.cmb_ticket_priority.Name = "cmb_ticket_priority";
            this.cmb_ticket_priority.Size = new System.Drawing.Size(264, 35);
            this.cmb_ticket_priority.TabIndex = 20;
            // 
            // cmb_ticket_severity
            // 
            this.cmb_ticket_severity.AllowHtml = true;
            this.cmb_ticket_severity.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cmb_ticket_severity.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_ticket_severity.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.cmb_ticket_severity.LabelText = "Severity";
            this.cmb_ticket_severity.Location = new System.Drawing.Point(552, 119);
            this.cmb_ticket_severity.Name = "cmb_ticket_severity";
            this.cmb_ticket_severity.Size = new System.Drawing.Size(268, 35);
            this.cmb_ticket_severity.TabIndex = 19;
            // 
            // txt_tickets_status
            // 
            this.txt_tickets_status.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tickets_status.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_tickets_status.LabelText = "Ticket Status";
            this.txt_tickets_status.Location = new System.Drawing.Point(697, 3);
            this.txt_tickets_status.MaxLength = 50;
            this.txt_tickets_status.Name = "txt_tickets_status";
            this.txt_tickets_status.Size = new System.Drawing.Size(68, 35);
            this.txt_tickets_status.TabIndex = 18;
            // 
            // txt_operators_id
            // 
            this.txt_operators_id.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_operators_id.Focusable = false;
            this.txt_operators_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_operators_id.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_operators_id.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_operators_id.LabelText = "ID";
            this.txt_operators_id.Location = new System.Drawing.Point(458, 41);
            this.txt_operators_id.Margin = new Wisej.Web.Padding(0);
            this.txt_operators_id.Name = "txt_operators_id";
            this.txt_operators_id.ReadOnly = true;
            this.txt_operators_id.Size = new System.Drawing.Size(82, 35);
            this.txt_operators_id.TabIndex = 17;
            // 
            // txt_operators_name
            // 
            this.txt_operators_name.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_operators_name.Focusable = false;
            this.txt_operators_name.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_operators_name.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_operators_name.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_operators_name.LabelText = "Operator Name";
            this.txt_operators_name.Location = new System.Drawing.Point(127, 41);
            this.txt_operators_name.Margin = new Wisej.Web.Padding(0);
            this.txt_operators_name.Name = "txt_operators_name";
            this.txt_operators_name.ReadOnly = true;
            this.txt_operators_name.Size = new System.Drawing.Size(329, 35);
            this.txt_operators_name.TabIndex = 16;
            // 
            // txt_tickets_creationoperatorid
            // 
            this.txt_tickets_creationoperatorid.CharacterCasing = Wisej.Web.CharacterCasing.Upper;
            this.txt_tickets_creationoperatorid.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tickets_creationoperatorid.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_tickets_creationoperatorid.LabelText = "Creation Operator ID";
            this.txt_tickets_creationoperatorid.Location = new System.Drawing.Point(3, 41);
            this.txt_tickets_creationoperatorid.Name = "txt_tickets_creationoperatorid";
            this.txt_tickets_creationoperatorid.Size = new System.Drawing.Size(122, 35);
            this.txt_tickets_creationoperatorid.TabIndex = 15;
            componentTool7.ImageSource = "icon-search";
            componentTool7.Name = "search";
            componentTool7.ToolTipText = "Search Record Code";
            this.txt_tickets_creationoperatorid.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool7});
            this.txt_tickets_creationoperatorid.ToolClick += new Wisej.Web.ToolClickEventHandler(this.txt_tickets_creationoperatorid_ToolClick);
            // 
            // txt_issuecategory_id
            // 
            this.txt_issuecategory_id.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_issuecategory_id.Focusable = false;
            this.txt_issuecategory_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_issuecategory_id.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_issuecategory_id.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_issuecategory_id.LabelText = "ID";
            this.txt_issuecategory_id.Location = new System.Drawing.Point(458, 119);
            this.txt_issuecategory_id.Margin = new Wisej.Web.Padding(0);
            this.txt_issuecategory_id.Name = "txt_issuecategory_id";
            this.txt_issuecategory_id.ReadOnly = true;
            this.txt_issuecategory_id.Size = new System.Drawing.Size(82, 35);
            this.txt_issuecategory_id.TabIndex = 14;
            // 
            // txt_issuecategories_description
            // 
            this.txt_issuecategories_description.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_issuecategories_description.Focusable = false;
            this.txt_issuecategories_description.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_issuecategories_description.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_issuecategories_description.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_issuecategories_description.LabelText = "Issue Category Description";
            this.txt_issuecategories_description.Location = new System.Drawing.Point(127, 119);
            this.txt_issuecategories_description.Margin = new Wisej.Web.Padding(0);
            this.txt_issuecategories_description.Name = "txt_issuecategories_description";
            this.txt_issuecategories_description.ReadOnly = true;
            this.txt_issuecategories_description.Size = new System.Drawing.Size(329, 35);
            this.txt_issuecategories_description.TabIndex = 13;
            // 
            // txt_tickets_issuecategoryid
            // 
            this.txt_tickets_issuecategoryid.CharacterCasing = Wisej.Web.CharacterCasing.Upper;
            this.txt_tickets_issuecategoryid.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tickets_issuecategoryid.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_tickets_issuecategoryid.LabelText = "Issue Category ID";
            this.txt_tickets_issuecategoryid.Location = new System.Drawing.Point(3, 121);
            this.txt_tickets_issuecategoryid.Name = "txt_tickets_issuecategoryid";
            this.txt_tickets_issuecategoryid.Size = new System.Drawing.Size(122, 35);
            this.txt_tickets_issuecategoryid.TabIndex = 12;
            componentTool8.ImageSource = "icon-search";
            componentTool8.Name = "search";
            componentTool8.ToolTipText = "Search Record Code";
            this.txt_tickets_issuecategoryid.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool8});
            this.txt_tickets_issuecategoryid.ToolClick += new Wisej.Web.ToolClickEventHandler(this.txt_tickets_issuecategoryid_ToolClick);
            // 
            // txt_tickets_parentid
            // 
            this.txt_tickets_parentid.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tickets_parentid.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_tickets_parentid.LabelText = "Parent ID";
            this.txt_tickets_parentid.Location = new System.Drawing.Point(623, 3);
            this.txt_tickets_parentid.MaxLength = 50;
            this.txt_tickets_parentid.Name = "txt_tickets_parentid";
            this.txt_tickets_parentid.Size = new System.Drawing.Size(68, 35);
            this.txt_tickets_parentid.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(820, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            // 
            // txt_tickets_creationtime
            // 
            this.txt_tickets_creationtime.InputType.Max = "24";
            this.txt_tickets_creationtime.InputType.Min = "0";
            this.txt_tickets_creationtime.InputType.Mode = Wisej.Web.TextBoxMode.Numeric;
            this.txt_tickets_creationtime.InputType.Step = 1D;
            this.txt_tickets_creationtime.InputType.Type = Wisej.Web.TextBoxType.Time;
            this.txt_tickets_creationtime.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tickets_creationtime.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_tickets_creationtime.LabelText = "Creation Time";
            this.txt_tickets_creationtime.Location = new System.Drawing.Point(183, 3);
            this.txt_tickets_creationtime.Name = "txt_tickets_creationtime";
            this.txt_tickets_creationtime.Size = new System.Drawing.Size(93, 35);
            this.txt_tickets_creationtime.TabIndex = 4;
            this.txt_tickets_creationtime.Text = "00:00:00";
            // 
            // txt_tickets_id
            // 
            this.txt_tickets_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tickets_id.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_tickets_id.LabelText = "ID";
            this.txt_tickets_id.Location = new System.Drawing.Point(3, 3);
            this.txt_tickets_id.Name = "txt_tickets_id";
            this.txt_tickets_id.Size = new System.Drawing.Size(63, 35);
            this.txt_tickets_id.TabIndex = 0;
            this.txt_tickets_id.TextChanged += new System.EventHandler(this.txt_tickets_id_TextChanged);
            // 
            // txt_tickets_mnemoniccode
            // 
            this.txt_tickets_mnemoniccode.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tickets_mnemoniccode.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_tickets_mnemoniccode.LabelText = "MnemonicCode";
            this.txt_tickets_mnemoniccode.Location = new System.Drawing.Point(280, 3);
            this.txt_tickets_mnemoniccode.Name = "txt_tickets_mnemoniccode";
            this.txt_tickets_mnemoniccode.Size = new System.Drawing.Size(337, 35);
            this.txt_tickets_mnemoniccode.TabIndex = 5;
            // 
            // txt_customers_id
            // 
            this.txt_customers_id.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_customers_id.Focusable = false;
            this.txt_customers_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_customers_id.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_customers_id.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_customers_id.LabelText = "ID";
            this.txt_customers_id.Location = new System.Drawing.Point(1007, 41);
            this.txt_customers_id.Margin = new Wisej.Web.Padding(0);
            this.txt_customers_id.Name = "txt_customers_id";
            this.txt_customers_id.ReadOnly = true;
            this.txt_customers_id.Size = new System.Drawing.Size(82, 35);
            this.txt_customers_id.TabIndex = 10;
            // 
            // txt_customers_fullname
            // 
            this.txt_customers_fullname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_customers_fullname.Focusable = false;
            this.txt_customers_fullname.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_customers_fullname.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_customers_fullname.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_customers_fullname.LabelText = "Customer Name";
            this.txt_customers_fullname.Location = new System.Drawing.Point(676, 41);
            this.txt_customers_fullname.Margin = new Wisej.Web.Padding(0);
            this.txt_customers_fullname.Name = "txt_customers_fullname";
            this.txt_customers_fullname.ReadOnly = true;
            this.txt_customers_fullname.Size = new System.Drawing.Size(329, 35);
            this.txt_customers_fullname.TabIndex = 9;
            // 
            // txt_tickets_customerid
            // 
            this.txt_tickets_customerid.CharacterCasing = Wisej.Web.CharacterCasing.Upper;
            this.txt_tickets_customerid.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tickets_customerid.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_tickets_customerid.LabelText = "Customer ID";
            this.txt_tickets_customerid.Location = new System.Drawing.Point(552, 41);
            this.txt_tickets_customerid.Name = "txt_tickets_customerid";
            this.txt_tickets_customerid.Size = new System.Drawing.Size(122, 35);
            this.txt_tickets_customerid.TabIndex = 8;
            componentTool9.ImageSource = "icon-search";
            componentTool9.Name = "search";
            componentTool9.ToolTipText = "Search Issue Categories";
            this.txt_tickets_customerid.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool9});
            this.txt_tickets_customerid.ToolClick += new Wisej.Web.ToolClickEventHandler(this.txt_tickets_customerid_ToolClick);
            // 
            // dtp_tickets_creationdate
            // 
            this.dtp_tickets_creationdate.CustomFormat = "dd/MM/yyyy";
            this.dtp_tickets_creationdate.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtp_tickets_creationdate.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_tickets_creationdate.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.dtp_tickets_creationdate.LabelText = "Creation Date";
            this.dtp_tickets_creationdate.Location = new System.Drawing.Point(70, 3);
            this.dtp_tickets_creationdate.Name = "dtp_tickets_creationdate";
            this.dtp_tickets_creationdate.Size = new System.Drawing.Size(112, 35);
            this.dtp_tickets_creationdate.TabIndex = 3;
            this.dtp_tickets_creationdate.Value = new System.DateTime(((long)(0)));
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.dgvList);
            this.tabList.Location = new System.Drawing.Point(0, 41);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new Wisej.Web.Padding(3);
            this.tabList.Size = new System.Drawing.Size(1203, 483);
            this.tabList.Text = "List View";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToOrderColumns = true;
            this.dgvList.Dock = Wisej.Web.DockStyle.Fill;
            this.dgvList.KeepSameRowHeight = true;
            this.dgvList.Location = new System.Drawing.Point(3, 3);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.Size = new System.Drawing.Size(1197, 477);
            this.dgvList.TabIndex = 0;
            // 
            // tabNotes
            // 
            this.tabNotes.Controls.Add(this.txt_tickets_operatornotes);
            this.tabNotes.Controls.Add(this.txt_tickets_customernotes);
            this.tabNotes.Location = new System.Drawing.Point(0, 41);
            this.tabNotes.Name = "tabNotes";
            this.tabNotes.Size = new System.Drawing.Size(1203, 483);
            this.tabNotes.Text = "Notes";
            // 
            // txt_tickets_operatornotes
            // 
            this.txt_tickets_operatornotes.AcceptsReturn = true;
            this.txt_tickets_operatornotes.AcceptsTab = true;
            this.txt_tickets_operatornotes.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.txt_tickets_operatornotes.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tickets_operatornotes.LabelText = "Operator Notes";
            this.txt_tickets_operatornotes.Location = new System.Drawing.Point(526, 269);
            this.txt_tickets_operatornotes.Multiline = true;
            this.txt_tickets_operatornotes.Name = "txt_tickets_operatornotes";
            this.txt_tickets_operatornotes.Size = new System.Drawing.Size(595, 138);
            this.txt_tickets_operatornotes.TabIndex = 13;
            // 
            // txt_tickets_customernotes
            // 
            this.txt_tickets_customernotes.AcceptsReturn = true;
            this.txt_tickets_customernotes.AcceptsTab = true;
            this.txt_tickets_customernotes.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.txt_tickets_customernotes.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tickets_customernotes.LabelText = "Customer Notes";
            this.txt_tickets_customernotes.Location = new System.Drawing.Point(14, 269);
            this.txt_tickets_customernotes.Multiline = true;
            this.txt_tickets_customernotes.Name = "txt_tickets_customernotes";
            this.txt_tickets_customernotes.Size = new System.Drawing.Size(595, 138);
            this.txt_tickets_customernotes.TabIndex = 12;
            // 
            // tabDetails
            // 
            this.tabDetails.Location = new System.Drawing.Point(0, 41);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.Size = new System.Drawing.Size(1203, 483);
            this.tabDetails.Text = "Details";
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Caption = "Locations";
            this.dataNavigator1.Dock = Wisej.Web.DockStyle.Bottom;
            this.dataNavigator1.FKeyEnabled = true;
            this.dataNavigator1.HeaderBackColor = System.Drawing.Color.FromName("@primary");
            this.dataNavigator1.HeaderForeColor = System.Drawing.Color.White;
            this.dataNavigator1.Location = new System.Drawing.Point(0, 526);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(1205, 60);
            this.dataNavigator1.TabIndex = 31;
            // 
            // txt_tickets_requestername
            // 
            this.txt_tickets_requestername.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tickets_requestername.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_tickets_requestername.LabelText = "Requester Name";
            this.txt_tickets_requestername.Location = new System.Drawing.Point(3, 80);
            this.txt_tickets_requestername.Name = "txt_tickets_requestername";
            this.txt_tickets_requestername.Size = new System.Drawing.Size(370, 35);
            this.txt_tickets_requestername.TabIndex = 21;
            // 
            // txt_tickets_requesteremail
            // 
            this.txt_tickets_requesteremail.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tickets_requesteremail.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_tickets_requesteremail.LabelText = "Requester Email";
            this.txt_tickets_requesteremail.Location = new System.Drawing.Point(377, 80);
            this.txt_tickets_requesteremail.Name = "txt_tickets_requesteremail";
            this.txt_tickets_requesteremail.Size = new System.Drawing.Size(370, 35);
            this.txt_tickets_requesteremail.TabIndex = 22;
            // 
            // txt_tickets_requesterphone
            // 
            this.txt_tickets_requesterphone.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tickets_requesterphone.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_tickets_requesterphone.LabelText = "Requester Phone";
            this.txt_tickets_requesterphone.Location = new System.Drawing.Point(752, 80);
            this.txt_tickets_requesterphone.Name = "txt_tickets_requesterphone";
            this.txt_tickets_requesterphone.Size = new System.Drawing.Size(337, 35);
            this.txt_tickets_requesterphone.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("defaultBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ticket  Events (Details)";
            // 
            // frmTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 586);
            this.Controls.Add(this.tabDataNavigator);
            this.Controls.Add(this.dataNavigator1);
            this.Name = "frmTickets";
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.frmTickets_Load);
            this.tabDataNavigator.ResumeLayout(false);
            this.tabForm.ResumeLayout(false);
            this.pnl_Details.ResumeLayout(false);
            this.pnl_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Details)).EndInit();
            this.pnl_Master.ResumeLayout(false);
            this.pnl_Master.PerformLayout();
            this.tabList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.tabNotes.ResumeLayout(false);
            this.tabNotes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.TabControl tabDataNavigator;
        private Wisej.Web.TabPage tabForm;
        private Wisej.Web.Panel pnl_Details;
        private Wisej.Web.DataGridView dgv_Details;
        private Wisej.Web.DataGridViewTextBoxColumn dgvc_EventID;
        private Wisej.Web.DataGridViewTextBoxColumn dgvc_EventTicketID;
        private Wisej.Web.DataGridViewTextBoxColumn dgvc_EventParentID;
        private Wisej.Web.DataGridViewTextBoxColumn dgvc_EventDate;
        private Wisej.Web.DataGridViewTextBoxColumn dgvc_EventTime;
        private Wisej.Web.DataGridViewTextBoxColumn dgvc_EventCustomerNotes;
        private Wisej.Web.DataGridViewTextBoxColumn dgvc_EventOperatorNotes;
        private Wisej.Web.DataGridViewTextBoxColumn dgvc_EventDueDate;
        private Wisej.Web.Panel pnl_Master;
        private Wisej.Web.TextBox txt_tickets_parentid;
        private Wisej.Web.Button button1;
        private Wisej.Web.TextBox txt_tickets_creationtime;
        private Wisej.Web.TextBox txt_tickets_id;
        private Wisej.Web.TextBox txt_customers_id;
        private Wisej.Web.TextBox txt_customers_fullname;
        private BasicDALWisejControls.DbLookUpTextBox txt_tickets_customerid;
        private Wisej.Web.DateTimePicker dtp_tickets_creationdate;
        private Wisej.Web.TabPage tabList;
        private Wisej.Web.DataGridView dgvList;
        private Wisej.Web.TabPage tabNotes;
        private Wisej.Web.TextBox txt_tickets_customernotes;
        private Wisej.Web.TabPage tabDetails;
        private Wisej.Web.TextBox txt_issuecategory_id;
        private Wisej.Web.TextBox txt_issuecategories_description;
        private BasicDALWisejControls.DbLookUpTextBox txt_tickets_issuecategoryid;
        private Wisej.Web.TextBox txt_tickets_mnemoniccode;
        private Wisej.Web.TextBox txt_tickets_status;
        private Wisej.Web.TextBox txt_operators_id;
        private Wisej.Web.TextBox txt_operators_name;
        private BasicDALWisejControls.DbLookUpTextBox txt_tickets_creationoperatorid;
        private Wisej.Web.TextBox txt_tickets_operatornotes;
        private BasicDALWisejControls.DataNavigator dataNavigator1;
        private Wisej.Web.DataGridViewTextBoxColumn dgvc_EventDueTime;
        private Wisej.Web.ComboBox cmb_ticket_priority;
        private Wisej.Web.ComboBox cmb_ticket_severity;
        private Wisej.Web.TextBox txt_tickets_requesterphone;
        private Wisej.Web.TextBox txt_tickets_requesteremail;
        private Wisej.Web.TextBox txt_tickets_requestername;
        private Wisej.Web.Label label2;
    }
}