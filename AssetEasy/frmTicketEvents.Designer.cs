namespace AssetEasy
{
    partial class frmTicketEvents
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
            Wisej.Web.ComponentTool componentTool3 = new Wisej.Web.ComponentTool();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicketEvents));
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle3 = new Wisej.Web.DataGridViewCellStyle();
            this.tabDataNavigator = new Wisej.Web.TabControl();
            this.tabForm = new Wisej.Web.TabPage();
            this.pnl_TicketEvents_Notes = new Wisej.Web.Panel();
            this.txt_TicketEvents_CustomerNotes = new Wisej.Web.TextBox();
            this.txt_TicketEvents_OperatorNotes = new Wisej.Web.TextBox();
            this.pnl_TicketEvents = new Wisej.Web.Panel();
            this.label2 = new Wisej.Web.Label();
            this.txt_ticketevents_requesterphone = new Wisej.Web.TextBox();
            this.txt_ticketevents_requesteremail = new Wisej.Web.TextBox();
            this.txt_ticketevents_requestername = new Wisej.Web.TextBox();
            this.txt_TicketEvents_TicketID = new Wisej.Web.TextBox();
            this.txt_TicketEvents_id = new Wisej.Web.TextBox();
            this.dtp_TicketEvents_DueTime = new Wisej.Web.TextBox();
            this.dtp_TicketEvents_Date = new Wisej.Web.DateTimePicker();
            this.dtp_TicketEvents_DueDate = new Wisej.Web.DateTimePicker();
            this.txt_TicketEvents_ParentID = new Wisej.Web.TextBox();
            this.txt_TicketEvents_OperatorID = new Wisej.Web.TextBox();
            this.dtp_TicketEvents_Time = new Wisej.Web.TextBox();
            this.txt_TicketEvents_OperatorName = new Wisej.Web.TextBox();
            this.dbl_TicketEvents_OperatorID = new BasicDALWisejControls.DbLookUpTextBox(this.components);
            this.pnl_Ticket = new Wisej.Web.Panel();
            this.txt_tickets_requesterphone = new Wisej.Web.TextBox();
            this.txt_tickets_requesteremail = new Wisej.Web.TextBox();
            this.txt_tickets_requestername = new Wisej.Web.TextBox();
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
            this.txt_tickets_creationtime = new Wisej.Web.TextBox();
            this.txt_tickets_id = new Wisej.Web.TextBox();
            this.txt_tickets_mnemoniccode = new Wisej.Web.TextBox();
            this.txt_customers_id = new Wisej.Web.TextBox();
            this.txt_customers_fullname = new Wisej.Web.TextBox();
            this.txt_tickets_customerid = new BasicDALWisejControls.DbLookUpTextBox(this.components);
            this.dtp_tickets_creationdate = new Wisej.Web.DateTimePicker();
            this.label1 = new Wisej.Web.Label();
            this.tabList = new Wisej.Web.TabPage();
            this.dgvList = new Wisej.Web.DataGridView();
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
            this.pnl_TicketEvents_Notes.SuspendLayout();
            this.pnl_TicketEvents.SuspendLayout();
            this.pnl_Ticket.SuspendLayout();
            this.tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.tabAttachments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Attachments)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDataNavigator
            // 
            this.tabDataNavigator.Controls.Add(this.tabForm);
            this.tabDataNavigator.Controls.Add(this.tabList);
            this.tabDataNavigator.Controls.Add(this.tabAttachments);
            this.tabDataNavigator.Dock = Wisej.Web.DockStyle.Fill;
            this.tabDataNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabDataNavigator.Name = "tabDataNavigator";
            this.tabDataNavigator.PageInsets = new Wisej.Web.Padding(0, 41, 2, 2);
            this.tabDataNavigator.Size = new System.Drawing.Size(1058, 597);
            this.tabDataNavigator.TabIndex = 25;
            this.tabDataNavigator.SelectedIndexChanged += new System.EventHandler(this.tabDataNavigator_SelectedIndexChanged);
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.pnl_TicketEvents_Notes);
            this.tabForm.Controls.Add(this.pnl_TicketEvents);
            this.tabForm.Controls.Add(this.pnl_Ticket);
            this.tabForm.Location = new System.Drawing.Point(0, 41);
            this.tabForm.Name = "tabForm";
            this.tabForm.Size = new System.Drawing.Size(1056, 554);
            this.tabForm.Text = "Form View";
            // 
            // pnl_TicketEvents_Notes
            // 
            this.pnl_TicketEvents_Notes.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.pnl_TicketEvents_Notes.Controls.Add(this.txt_TicketEvents_CustomerNotes);
            this.pnl_TicketEvents_Notes.Controls.Add(this.txt_TicketEvents_OperatorNotes);
            this.pnl_TicketEvents_Notes.Location = new System.Drawing.Point(4, 342);
            this.pnl_TicketEvents_Notes.Name = "pnl_TicketEvents_Notes";
            this.pnl_TicketEvents_Notes.Size = new System.Drawing.Size(1049, 208);
            this.pnl_TicketEvents_Notes.TabIndex = 45;
            // 
            // txt_TicketEvents_CustomerNotes
            // 
            this.txt_TicketEvents_CustomerNotes.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TicketEvents_CustomerNotes.LabelText = "Customer Notes";
            this.txt_TicketEvents_CustomerNotes.Location = new System.Drawing.Point(533, 3);
            this.txt_TicketEvents_CustomerNotes.Multiline = true;
            this.txt_TicketEvents_CustomerNotes.Name = "txt_TicketEvents_CustomerNotes";
            this.txt_TicketEvents_CustomerNotes.Size = new System.Drawing.Size(508, 202);
            this.txt_TicketEvents_CustomerNotes.TabIndex = 42;
            // 
            // txt_TicketEvents_OperatorNotes
            // 
            this.txt_TicketEvents_OperatorNotes.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TicketEvents_OperatorNotes.LabelText = "Operator Notes";
            this.txt_TicketEvents_OperatorNotes.Location = new System.Drawing.Point(3, 3);
            this.txt_TicketEvents_OperatorNotes.Multiline = true;
            this.txt_TicketEvents_OperatorNotes.Name = "txt_TicketEvents_OperatorNotes";
            this.txt_TicketEvents_OperatorNotes.Size = new System.Drawing.Size(508, 202);
            this.txt_TicketEvents_OperatorNotes.TabIndex = 41;
            // 
            // pnl_TicketEvents
            // 
            this.pnl_TicketEvents.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.pnl_TicketEvents.BackColor = System.Drawing.Color.LightYellow;
            this.pnl_TicketEvents.Controls.Add(this.label2);
            this.pnl_TicketEvents.Controls.Add(this.txt_ticketevents_requesterphone);
            this.pnl_TicketEvents.Controls.Add(this.txt_ticketevents_requesteremail);
            this.pnl_TicketEvents.Controls.Add(this.txt_ticketevents_requestername);
            this.pnl_TicketEvents.Controls.Add(this.txt_TicketEvents_TicketID);
            this.pnl_TicketEvents.Controls.Add(this.txt_TicketEvents_id);
            this.pnl_TicketEvents.Controls.Add(this.dtp_TicketEvents_DueTime);
            this.pnl_TicketEvents.Controls.Add(this.dtp_TicketEvents_Date);
            this.pnl_TicketEvents.Controls.Add(this.dtp_TicketEvents_DueDate);
            this.pnl_TicketEvents.Controls.Add(this.txt_TicketEvents_ParentID);
            this.pnl_TicketEvents.Controls.Add(this.txt_TicketEvents_OperatorID);
            this.pnl_TicketEvents.Controls.Add(this.dtp_TicketEvents_Time);
            this.pnl_TicketEvents.Controls.Add(this.txt_TicketEvents_OperatorName);
            this.pnl_TicketEvents.Controls.Add(this.dbl_TicketEvents_OperatorID);
            this.pnl_TicketEvents.Location = new System.Drawing.Point(4, 185);
            this.pnl_TicketEvents.Name = "pnl_TicketEvents";
            this.pnl_TicketEvents.Size = new System.Drawing.Size(1049, 151);
            this.pnl_TicketEvents.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("defaultBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(4, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ticket  Event";
            // 
            // txt_ticketevents_requesterphone
            // 
            this.txt_ticketevents_requesterphone.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ticketevents_requesterphone.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_ticketevents_requesterphone.LabelText = "Requester Phone";
            this.txt_ticketevents_requesterphone.Location = new System.Drawing.Point(693, 111);
            this.txt_ticketevents_requesterphone.Name = "txt_ticketevents_requesterphone";
            this.txt_ticketevents_requesterphone.Size = new System.Drawing.Size(348, 35);
            this.txt_ticketevents_requesterphone.TabIndex = 43;
            // 
            // txt_ticketevents_requesteremail
            // 
            this.txt_ticketevents_requesteremail.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ticketevents_requesteremail.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_ticketevents_requesteremail.LabelText = "Requester Email";
            this.txt_ticketevents_requesteremail.Location = new System.Drawing.Point(349, 111);
            this.txt_ticketevents_requesteremail.Name = "txt_ticketevents_requesteremail";
            this.txt_ticketevents_requesteremail.Size = new System.Drawing.Size(341, 35);
            this.txt_ticketevents_requesteremail.TabIndex = 42;
            // 
            // txt_ticketevents_requestername
            // 
            this.txt_ticketevents_requestername.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ticketevents_requestername.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_ticketevents_requestername.LabelText = "Requester Name";
            this.txt_ticketevents_requestername.Location = new System.Drawing.Point(4, 111);
            this.txt_ticketevents_requestername.Name = "txt_ticketevents_requestername";
            this.txt_ticketevents_requestername.Size = new System.Drawing.Size(342, 35);
            this.txt_ticketevents_requestername.TabIndex = 41;
            // 
            // txt_TicketEvents_TicketID
            // 
            this.txt_TicketEvents_TicketID.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TicketEvents_TicketID.LabelText = "Ticket ID";
            this.txt_TicketEvents_TicketID.Location = new System.Drawing.Point(3, 31);
            this.txt_TicketEvents_TicketID.Name = "txt_TicketEvents_TicketID";
            this.txt_TicketEvents_TicketID.Size = new System.Drawing.Size(71, 38);
            this.txt_TicketEvents_TicketID.TabIndex = 34;
            // 
            // txt_TicketEvents_id
            // 
            this.txt_TicketEvents_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TicketEvents_id.LabelText = "Ticket Event ID";
            this.txt_TicketEvents_id.Location = new System.Drawing.Point(76, 31);
            this.txt_TicketEvents_id.Name = "txt_TicketEvents_id";
            this.txt_TicketEvents_id.Size = new System.Drawing.Size(86, 38);
            this.txt_TicketEvents_id.TabIndex = 0;
            // 
            // dtp_TicketEvents_DueTime
            // 
            this.dtp_TicketEvents_DueTime.InputType.Max = "24";
            this.dtp_TicketEvents_DueTime.InputType.Min = "0";
            this.dtp_TicketEvents_DueTime.InputType.Mode = Wisej.Web.TextBoxMode.Numeric;
            this.dtp_TicketEvents_DueTime.InputType.Step = 1D;
            this.dtp_TicketEvents_DueTime.InputType.Type = Wisej.Web.TextBoxType.Time;
            this.dtp_TicketEvents_DueTime.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_TicketEvents_DueTime.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.dtp_TicketEvents_DueTime.LabelText = "Due Time";
            this.dtp_TicketEvents_DueTime.Location = new System.Drawing.Point(121, 72);
            this.dtp_TicketEvents_DueTime.Name = "dtp_TicketEvents_DueTime";
            this.dtp_TicketEvents_DueTime.ReadOnly = true;
            this.dtp_TicketEvents_DueTime.Size = new System.Drawing.Size(102, 35);
            this.dtp_TicketEvents_DueTime.TabIndex = 40;
            this.dtp_TicketEvents_DueTime.Text = "00:00:00";
            // 
            // dtp_TicketEvents_Date
            // 
            this.dtp_TicketEvents_Date.CustomFormat = "dd/MM/yyyy";
            this.dtp_TicketEvents_Date.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtp_TicketEvents_Date.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_TicketEvents_Date.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.dtp_TicketEvents_Date.LabelText = "Creation Date";
            this.dtp_TicketEvents_Date.Location = new System.Drawing.Point(248, 34);
            this.dtp_TicketEvents_Date.Name = "dtp_TicketEvents_Date";
            this.dtp_TicketEvents_Date.ReadOnly = true;
            this.dtp_TicketEvents_Date.Size = new System.Drawing.Size(112, 35);
            this.dtp_TicketEvents_Date.TabIndex = 21;
            this.dtp_TicketEvents_Date.Value = new System.DateTime(((long)(0)));
            // 
            // dtp_TicketEvents_DueDate
            // 
            this.dtp_TicketEvents_DueDate.CustomFormat = "dd/MM/yyyy";
            this.dtp_TicketEvents_DueDate.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtp_TicketEvents_DueDate.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_TicketEvents_DueDate.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.dtp_TicketEvents_DueDate.LabelText = "Due Date";
            this.dtp_TicketEvents_DueDate.Location = new System.Drawing.Point(3, 72);
            this.dtp_TicketEvents_DueDate.Name = "dtp_TicketEvents_DueDate";
            this.dtp_TicketEvents_DueDate.ReadOnly = true;
            this.dtp_TicketEvents_DueDate.Size = new System.Drawing.Size(112, 35);
            this.dtp_TicketEvents_DueDate.TabIndex = 39;
            this.dtp_TicketEvents_DueDate.Value = new System.DateTime(((long)(0)));
            // 
            // txt_TicketEvents_ParentID
            // 
            this.txt_TicketEvents_ParentID.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TicketEvents_ParentID.LabelText = "Parent Event ID";
            this.txt_TicketEvents_ParentID.Location = new System.Drawing.Point(165, 31);
            this.txt_TicketEvents_ParentID.Name = "txt_TicketEvents_ParentID";
            this.txt_TicketEvents_ParentID.Size = new System.Drawing.Size(81, 38);
            this.txt_TicketEvents_ParentID.TabIndex = 35;
            // 
            // txt_TicketEvents_OperatorID
            // 
            this.txt_TicketEvents_OperatorID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_TicketEvents_OperatorID.Focusable = false;
            this.txt_TicketEvents_OperatorID.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TicketEvents_OperatorID.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_TicketEvents_OperatorID.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_TicketEvents_OperatorID.LabelText = "ID";
            this.txt_TicketEvents_OperatorID.Location = new System.Drawing.Point(929, 34);
            this.txt_TicketEvents_OperatorID.Margin = new Wisej.Web.Padding(0);
            this.txt_TicketEvents_OperatorID.Name = "txt_TicketEvents_OperatorID";
            this.txt_TicketEvents_OperatorID.ReadOnly = true;
            this.txt_TicketEvents_OperatorID.Size = new System.Drawing.Size(82, 35);
            this.txt_TicketEvents_OperatorID.TabIndex = 38;
            // 
            // dtp_TicketEvents_Time
            // 
            this.dtp_TicketEvents_Time.InputType.Max = "24";
            this.dtp_TicketEvents_Time.InputType.Min = "0";
            this.dtp_TicketEvents_Time.InputType.Mode = Wisej.Web.TextBoxMode.Numeric;
            this.dtp_TicketEvents_Time.InputType.Step = 1D;
            this.dtp_TicketEvents_Time.InputType.Type = Wisej.Web.TextBoxType.Time;
            this.dtp_TicketEvents_Time.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_TicketEvents_Time.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.dtp_TicketEvents_Time.LabelText = "Creation Time";
            this.dtp_TicketEvents_Time.Location = new System.Drawing.Point(366, 34);
            this.dtp_TicketEvents_Time.Name = "dtp_TicketEvents_Time";
            this.dtp_TicketEvents_Time.ReadOnly = true;
            this.dtp_TicketEvents_Time.Size = new System.Drawing.Size(102, 35);
            this.dtp_TicketEvents_Time.TabIndex = 22;
            this.dtp_TicketEvents_Time.Text = "00:00:00";
            // 
            // txt_TicketEvents_OperatorName
            // 
            this.txt_TicketEvents_OperatorName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_TicketEvents_OperatorName.Focusable = false;
            this.txt_TicketEvents_OperatorName.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TicketEvents_OperatorName.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_TicketEvents_OperatorName.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_TicketEvents_OperatorName.LabelText = "Operator Name";
            this.txt_TicketEvents_OperatorName.Location = new System.Drawing.Point(598, 34);
            this.txt_TicketEvents_OperatorName.Margin = new Wisej.Web.Padding(0);
            this.txt_TicketEvents_OperatorName.Name = "txt_TicketEvents_OperatorName";
            this.txt_TicketEvents_OperatorName.ReadOnly = true;
            this.txt_TicketEvents_OperatorName.Size = new System.Drawing.Size(329, 35);
            this.txt_TicketEvents_OperatorName.TabIndex = 37;
            // 
            // dbl_TicketEvents_OperatorID
            // 
            this.dbl_TicketEvents_OperatorID.CharacterCasing = Wisej.Web.CharacterCasing.Upper;
            this.dbl_TicketEvents_OperatorID.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dbl_TicketEvents_OperatorID.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.dbl_TicketEvents_OperatorID.LabelText = "Creation Operator ID";
            this.dbl_TicketEvents_OperatorID.Location = new System.Drawing.Point(474, 34);
            this.dbl_TicketEvents_OperatorID.Name = "dbl_TicketEvents_OperatorID";
            this.dbl_TicketEvents_OperatorID.Size = new System.Drawing.Size(122, 35);
            this.dbl_TicketEvents_OperatorID.TabIndex = 36;
            componentTool3.ImageSource = "icon-search";
            componentTool3.Name = "search";
            componentTool3.ToolTipText = "Search Record Code";
            this.dbl_TicketEvents_OperatorID.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool3});
            // 
            // pnl_Ticket
            // 
            this.pnl_Ticket.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.pnl_Ticket.BackColor = System.Drawing.Color.FromName("@info");
            this.pnl_Ticket.Controls.Add(this.txt_tickets_requesterphone);
            this.pnl_Ticket.Controls.Add(this.txt_tickets_requesteremail);
            this.pnl_Ticket.Controls.Add(this.txt_tickets_requestername);
            this.pnl_Ticket.Controls.Add(this.cmb_ticket_priority);
            this.pnl_Ticket.Controls.Add(this.cmb_ticket_severity);
            this.pnl_Ticket.Controls.Add(this.txt_tickets_status);
            this.pnl_Ticket.Controls.Add(this.txt_operators_id);
            this.pnl_Ticket.Controls.Add(this.txt_operators_name);
            this.pnl_Ticket.Controls.Add(this.txt_tickets_creationoperatorid);
            this.pnl_Ticket.Controls.Add(this.txt_issuecategory_id);
            this.pnl_Ticket.Controls.Add(this.txt_issuecategories_description);
            this.pnl_Ticket.Controls.Add(this.txt_tickets_issuecategoryid);
            this.pnl_Ticket.Controls.Add(this.txt_tickets_parentid);
            this.pnl_Ticket.Controls.Add(this.txt_tickets_creationtime);
            this.pnl_Ticket.Controls.Add(this.txt_tickets_id);
            this.pnl_Ticket.Controls.Add(this.txt_tickets_mnemoniccode);
            this.pnl_Ticket.Controls.Add(this.txt_customers_id);
            this.pnl_Ticket.Controls.Add(this.txt_customers_fullname);
            this.pnl_Ticket.Controls.Add(this.txt_tickets_customerid);
            this.pnl_Ticket.Controls.Add(this.dtp_tickets_creationdate);
            this.pnl_Ticket.Controls.Add(this.label1);
            this.pnl_Ticket.Location = new System.Drawing.Point(3, 3);
            this.pnl_Ticket.Name = "pnl_Ticket";
            this.pnl_Ticket.Size = new System.Drawing.Size(1050, 176);
            this.pnl_Ticket.TabIndex = 33;
            // 
            // txt_tickets_requesterphone
            // 
            this.txt_tickets_requesterphone.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tickets_requesterphone.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_tickets_requesterphone.LabelText = "Requester Phone";
            this.txt_tickets_requesterphone.Location = new System.Drawing.Point(693, 97);
            this.txt_tickets_requesterphone.Name = "txt_tickets_requesterphone";
            this.txt_tickets_requesterphone.Size = new System.Drawing.Size(348, 35);
            this.txt_tickets_requesterphone.TabIndex = 26;
            // 
            // txt_tickets_requesteremail
            // 
            this.txt_tickets_requesteremail.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tickets_requesteremail.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_tickets_requesteremail.LabelText = "Requester Email";
            this.txt_tickets_requesteremail.Location = new System.Drawing.Point(349, 97);
            this.txt_tickets_requesteremail.Name = "txt_tickets_requesteremail";
            this.txt_tickets_requesteremail.Size = new System.Drawing.Size(341, 35);
            this.txt_tickets_requesteremail.TabIndex = 25;
            // 
            // txt_tickets_requestername
            // 
            this.txt_tickets_requestername.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tickets_requestername.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_tickets_requestername.LabelText = "Requester Name";
            this.txt_tickets_requestername.Location = new System.Drawing.Point(4, 97);
            this.txt_tickets_requestername.Name = "txt_tickets_requestername";
            this.txt_tickets_requestername.Size = new System.Drawing.Size(342, 35);
            this.txt_tickets_requestername.TabIndex = 24;
            // 
            // cmb_ticket_priority
            // 
            this.cmb_ticket_priority.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cmb_ticket_priority.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_ticket_priority.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.cmb_ticket_priority.LabelText = "Priority";
            this.cmb_ticket_priority.Location = new System.Drawing.Point(777, 136);
            this.cmb_ticket_priority.Name = "cmb_ticket_priority";
            this.cmb_ticket_priority.ReadOnly = true;
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
            this.cmb_ticket_severity.Location = new System.Drawing.Point(504, 136);
            this.cmb_ticket_severity.Name = "cmb_ticket_severity";
            this.cmb_ticket_severity.ReadOnly = true;
            this.cmb_ticket_severity.Size = new System.Drawing.Size(268, 35);
            this.cmb_ticket_severity.TabIndex = 19;
            // 
            // txt_tickets_status
            // 
            this.txt_tickets_status.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tickets_status.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_tickets_status.LabelText = "Ticket Status";
            this.txt_tickets_status.Location = new System.Drawing.Point(690, 20);
            this.txt_tickets_status.MaxLength = 50;
            this.txt_tickets_status.Name = "txt_tickets_status";
            this.txt_tickets_status.ReadOnly = true;
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
            this.txt_operators_id.Location = new System.Drawing.Point(431, 58);
            this.txt_operators_id.Margin = new Wisej.Web.Padding(0);
            this.txt_operators_id.Name = "txt_operators_id";
            this.txt_operators_id.ReadOnly = true;
            this.txt_operators_id.Size = new System.Drawing.Size(70, 35);
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
            this.txt_operators_name.Location = new System.Drawing.Point(127, 58);
            this.txt_operators_name.Margin = new Wisej.Web.Padding(0);
            this.txt_operators_name.Name = "txt_operators_name";
            this.txt_operators_name.ReadOnly = true;
            this.txt_operators_name.Size = new System.Drawing.Size(302, 35);
            this.txt_operators_name.TabIndex = 16;
            // 
            // txt_tickets_creationoperatorid
            // 
            this.txt_tickets_creationoperatorid.CharacterCasing = Wisej.Web.CharacterCasing.Upper;
            this.txt_tickets_creationoperatorid.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tickets_creationoperatorid.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_tickets_creationoperatorid.LabelText = "Creation Operator ID";
            this.txt_tickets_creationoperatorid.Location = new System.Drawing.Point(3, 58);
            this.txt_tickets_creationoperatorid.Name = "txt_tickets_creationoperatorid";
            this.txt_tickets_creationoperatorid.ReadOnly = true;
            this.txt_tickets_creationoperatorid.Size = new System.Drawing.Size(122, 35);
            this.txt_tickets_creationoperatorid.TabIndex = 15;
            // 
            // txt_issuecategory_id
            // 
            this.txt_issuecategory_id.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_issuecategory_id.Focusable = false;
            this.txt_issuecategory_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_issuecategory_id.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_issuecategory_id.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_issuecategory_id.LabelText = "ID";
            this.txt_issuecategory_id.Location = new System.Drawing.Point(431, 136);
            this.txt_issuecategory_id.Margin = new Wisej.Web.Padding(0);
            this.txt_issuecategory_id.Name = "txt_issuecategory_id";
            this.txt_issuecategory_id.ReadOnly = true;
            this.txt_issuecategory_id.Size = new System.Drawing.Size(70, 35);
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
            this.txt_issuecategories_description.Location = new System.Drawing.Point(127, 136);
            this.txt_issuecategories_description.Margin = new Wisej.Web.Padding(0);
            this.txt_issuecategories_description.Name = "txt_issuecategories_description";
            this.txt_issuecategories_description.ReadOnly = true;
            this.txt_issuecategories_description.Size = new System.Drawing.Size(302, 35);
            this.txt_issuecategories_description.TabIndex = 13;
            // 
            // txt_tickets_issuecategoryid
            // 
            this.txt_tickets_issuecategoryid.CharacterCasing = Wisej.Web.CharacterCasing.Upper;
            this.txt_tickets_issuecategoryid.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tickets_issuecategoryid.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_tickets_issuecategoryid.LabelText = "Issue Category ID";
            this.txt_tickets_issuecategoryid.Location = new System.Drawing.Point(3, 136);
            this.txt_tickets_issuecategoryid.Name = "txt_tickets_issuecategoryid";
            this.txt_tickets_issuecategoryid.ReadOnly = true;
            this.txt_tickets_issuecategoryid.Size = new System.Drawing.Size(122, 35);
            this.txt_tickets_issuecategoryid.TabIndex = 12;
            // 
            // txt_tickets_parentid
            // 
            this.txt_tickets_parentid.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tickets_parentid.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_tickets_parentid.LabelText = "Parent ID";
            this.txt_tickets_parentid.Location = new System.Drawing.Point(618, 20);
            this.txt_tickets_parentid.MaxLength = 50;
            this.txt_tickets_parentid.Name = "txt_tickets_parentid";
            this.txt_tickets_parentid.ReadOnly = true;
            this.txt_tickets_parentid.Size = new System.Drawing.Size(68, 35);
            this.txt_tickets_parentid.TabIndex = 2;
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
            this.txt_tickets_creationtime.Location = new System.Drawing.Point(183, 20);
            this.txt_tickets_creationtime.Name = "txt_tickets_creationtime";
            this.txt_tickets_creationtime.ReadOnly = true;
            this.txt_tickets_creationtime.Size = new System.Drawing.Size(93, 35);
            this.txt_tickets_creationtime.TabIndex = 4;
            this.txt_tickets_creationtime.Text = "00:00:00";
            // 
            // txt_tickets_id
            // 
            this.txt_tickets_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tickets_id.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_tickets_id.LabelText = "ID";
            this.txt_tickets_id.Location = new System.Drawing.Point(3, 20);
            this.txt_tickets_id.Name = "txt_tickets_id";
            this.txt_tickets_id.ReadOnly = true;
            this.txt_tickets_id.Size = new System.Drawing.Size(63, 35);
            this.txt_tickets_id.TabIndex = 0;
            this.txt_tickets_id.TextChanged += new System.EventHandler(this.txt_tickets_id_TextChanged);
            // 
            // txt_tickets_mnemoniccode
            // 
            this.txt_tickets_mnemoniccode.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tickets_mnemoniccode.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_tickets_mnemoniccode.LabelText = "MnemonicCode";
            this.txt_tickets_mnemoniccode.Location = new System.Drawing.Point(278, 20);
            this.txt_tickets_mnemoniccode.Name = "txt_tickets_mnemoniccode";
            this.txt_tickets_mnemoniccode.ReadOnly = true;
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
            this.txt_customers_id.Location = new System.Drawing.Point(933, 58);
            this.txt_customers_id.Margin = new Wisej.Web.Padding(0);
            this.txt_customers_id.Name = "txt_customers_id";
            this.txt_customers_id.ReadOnly = true;
            this.txt_customers_id.Size = new System.Drawing.Size(70, 35);
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
            this.txt_customers_fullname.Location = new System.Drawing.Point(629, 58);
            this.txt_customers_fullname.Margin = new Wisej.Web.Padding(0);
            this.txt_customers_fullname.Name = "txt_customers_fullname";
            this.txt_customers_fullname.ReadOnly = true;
            this.txt_customers_fullname.Size = new System.Drawing.Size(302, 35);
            this.txt_customers_fullname.TabIndex = 9;
            // 
            // txt_tickets_customerid
            // 
            this.txt_tickets_customerid.CharacterCasing = Wisej.Web.CharacterCasing.Upper;
            this.txt_tickets_customerid.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tickets_customerid.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.txt_tickets_customerid.LabelText = "Customer ID";
            this.txt_tickets_customerid.Location = new System.Drawing.Point(505, 58);
            this.txt_tickets_customerid.Name = "txt_tickets_customerid";
            this.txt_tickets_customerid.ReadOnly = true;
            this.txt_tickets_customerid.Size = new System.Drawing.Size(122, 35);
            this.txt_tickets_customerid.TabIndex = 8;
            // 
            // dtp_tickets_creationdate
            // 
            this.dtp_tickets_creationdate.CustomFormat = "dd/MM/yyyy";
            this.dtp_tickets_creationdate.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtp_tickets_creationdate.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_tickets_creationdate.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.dtp_tickets_creationdate.LabelText = "Creation Date";
            this.dtp_tickets_creationdate.Location = new System.Drawing.Point(68, 20);
            this.dtp_tickets_creationdate.Name = "dtp_tickets_creationdate";
            this.dtp_tickets_creationdate.ReadOnly = true;
            this.dtp_tickets_creationdate.Size = new System.Drawing.Size(112, 35);
            this.dtp_tickets_creationdate.TabIndex = 3;
            this.dtp_tickets_creationdate.Value = new System.DateTime(((long)(0)));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("defaultBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ticket ";
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.dgvList);
            this.tabList.Location = new System.Drawing.Point(0, 41);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new Wisej.Web.Padding(3);
            this.tabList.Size = new System.Drawing.Size(1056, 554);
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
            this.dgvList.Size = new System.Drawing.Size(1050, 548);
            this.dgvList.TabIndex = 0;
            // 
            // tabAttachments
            // 
            this.tabAttachments.Controls.Add(this.uploadAttachment);
            this.tabAttachments.Controls.Add(this.dgv_Attachments);
            this.tabAttachments.Location = new System.Drawing.Point(0, 41);
            this.tabAttachments.Name = "tabAttachments";
            this.tabAttachments.Size = new System.Drawing.Size(1056, 554);
            this.tabAttachments.Text = "Attachments";
            // 
            // uploadAttachment
            // 
            this.uploadAttachment.AllowedFileTypes = "audio/*,video/*,image/*,application/*,text/*";
            this.uploadAttachment.AllowMultipleFiles = true;
            this.uploadAttachment.HideValue = true;
            this.uploadAttachment.Location = new System.Drawing.Point(826, 307);
            this.uploadAttachment.Name = "uploadAttachment";
            this.uploadAttachment.Size = new System.Drawing.Size(219, 30);
            this.uploadAttachment.TabIndex = 46;
            this.uploadAttachment.Text = "Upload Attachment";
            this.uploadAttachment.Visible = false;
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
            this.dgv_Attachments.Location = new System.Drawing.Point(3, 343);
            this.dgv_Attachments.Name = "dgv_Attachments";
            this.dgv_Attachments.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("dgv_Attachments.ResponsiveProfiles"))));
            this.dgv_Attachments.Size = new System.Drawing.Size(1042, 207);
            this.dgv_Attachments.TabIndex = 45;
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
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dgvc_attachments_date.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.dataNavigator1.Caption = "Ticket Events";
            this.dataNavigator1.Dock = Wisej.Web.DockStyle.Bottom;
            this.dataNavigator1.FKeyEnabled = true;
            this.dataNavigator1.HeaderBackColor = System.Drawing.Color.FromName("@primary");
            this.dataNavigator1.Location = new System.Drawing.Point(0, 597);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(1058, 60);
            this.dataNavigator1.TabIndex = 26;
            // 
            // frmTicketEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 657);
            this.Controls.Add(this.tabDataNavigator);
            this.Controls.Add(this.dataNavigator1);
            this.Name = "frmTicketEvents";
            this.Text = "Ticket Events";
            this.Load += new System.EventHandler(this.frmTicketEvents_Load);
            this.tabDataNavigator.ResumeLayout(false);
            this.tabForm.ResumeLayout(false);
            this.pnl_TicketEvents_Notes.ResumeLayout(false);
            this.pnl_TicketEvents_Notes.PerformLayout();
            this.pnl_TicketEvents.ResumeLayout(false);
            this.pnl_TicketEvents.PerformLayout();
            this.pnl_Ticket.ResumeLayout(false);
            this.pnl_Ticket.PerformLayout();
            this.tabList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.tabAttachments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Attachments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.TabControl tabDataNavigator;
        private Wisej.Web.TabPage tabForm;
        private Wisej.Web.TextBox txt_TicketEvents_id;
        private Wisej.Web.TabPage tabList;
        private Wisej.Web.DataGridView dgvList;
        private BasicDALWisejControls.DataNavigator dataNavigator1;
        private Wisej.Web.Panel pnl_Ticket;
        private Wisej.Web.ComboBox cmb_ticket_priority;
        private Wisej.Web.ComboBox cmb_ticket_severity;
        private Wisej.Web.TextBox txt_tickets_status;
        private Wisej.Web.TextBox txt_operators_id;
        private Wisej.Web.TextBox txt_operators_name;
        private BasicDALWisejControls.DbLookUpTextBox txt_tickets_creationoperatorid;
        private Wisej.Web.TextBox txt_issuecategory_id;
        private Wisej.Web.TextBox txt_issuecategories_description;
        private BasicDALWisejControls.DbLookUpTextBox txt_tickets_issuecategoryid;
        private Wisej.Web.TextBox txt_tickets_parentid;
        private Wisej.Web.TextBox txt_tickets_creationtime;
        private Wisej.Web.TextBox txt_tickets_id;
        private Wisej.Web.TextBox txt_tickets_mnemoniccode;
        private Wisej.Web.TextBox txt_customers_id;
        private Wisej.Web.TextBox txt_customers_fullname;
        private BasicDALWisejControls.DbLookUpTextBox txt_tickets_customerid;
        private Wisej.Web.DateTimePicker dtp_tickets_creationdate;
        private Wisej.Web.TextBox dtp_TicketEvents_Time;
        private Wisej.Web.TextBox txt_TicketEvents_ParentID;
        private Wisej.Web.DateTimePicker dtp_TicketEvents_Date;
        private Wisej.Web.TextBox txt_TicketEvents_TicketID;
        private Wisej.Web.TextBox dtp_TicketEvents_DueTime;
        private Wisej.Web.DateTimePicker dtp_TicketEvents_DueDate;
        private Wisej.Web.TextBox txt_TicketEvents_OperatorID;
        private Wisej.Web.TextBox txt_TicketEvents_OperatorName;
        private BasicDALWisejControls.DbLookUpTextBox dbl_TicketEvents_OperatorID;
        private Wisej.Web.Panel pnl_TicketEvents;
        private Wisej.Web.TabPage tabAttachments;
        private Wisej.Web.Upload uploadAttachment;
        private Wisej.Web.DataGridView dgv_Attachments;
        private Wisej.Web.DataGridViewTextBoxColumn dgvc_attachments_id;
        private Wisej.Web.DataGridViewTextBoxColumn dgvc_attachments_parentobjecttype;
        private Wisej.Web.DataGridViewTextBoxColumn dgvc_attachments_parentobjectid;
        private Wisej.Web.DataGridViewImageColumn dgvc_attachments_icon;
        private Wisej.Web.DataGridViewTextBoxColumn dgvc_attachments_description;
        private Wisej.Web.DataGridViewTextBoxColumn dgvc_attachments_date;
        private Wisej.Web.DataGridViewTextBoxColumn dgvc_attachments_ranking;
        private Wisej.Web.DataGridViewTextBoxColumn dgvc_attachments_filename;
        private Wisej.Web.DataGridViewImageColumn dgvc_attachments_open;
        private Wisej.Web.DataGridViewImageColumn dgvc_attachments_upload;
        private Wisej.Web.DataGridViewImageColumn dgvc_attachments_camera;
        private Wisej.Web.DataGridViewTextBoxColumn dgvc_attachments_uniquefilename;
        private Wisej.Web.DataGridViewTextBoxColumn dgvc_attachments_contenttype;
        private Wisej.Web.DataGridViewTextBoxColumn dgvc_attachments_notes;
        private Wisej.Web.Panel pnl_TicketEvents_Notes;
        private Wisej.Web.TextBox txt_TicketEvents_CustomerNotes;
        private Wisej.Web.TextBox txt_TicketEvents_OperatorNotes;
        private Wisej.Web.TextBox txt_tickets_requesterphone;
        private Wisej.Web.TextBox txt_tickets_requesteremail;
        private Wisej.Web.TextBox txt_tickets_requestername;
        private Wisej.Web.TextBox txt_ticketevents_requesterphone;
        private Wisej.Web.TextBox txt_ticketevents_requesteremail;
        private Wisej.Web.TextBox txt_ticketevents_requestername;
        private Wisej.Web.Label label1;
        private Wisej.Web.Label label2;
    }
}