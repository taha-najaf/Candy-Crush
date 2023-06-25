namespace Candy_Crush
{
    partial class GroupGameForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupGameForm));
            this.label1 = new System.Windows.Forms.Label();
            this.CalDataGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ApplicantId = new Guna.UI2.WinForms.Guna2TextBox();
            this.Acceptbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.RejectAPbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.FriendsDatagridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Friendcodetxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Sendbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.PendingMatchDataGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MatchIDtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.CalDataGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendsDatagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PendingMatchDataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contest Applications List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CalDataGridview
            // 
            this.CalDataGridview.AllowUserToAddRows = false;
            this.CalDataGridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CalDataGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CalDataGridview.BackgroundColor = System.Drawing.Color.Silver;
            this.CalDataGridview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CalDataGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CalDataGridview.ColumnHeadersHeight = 20;
            this.CalDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CalDataGridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.CalDataGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CalDataGridview.Location = new System.Drawing.Point(19, 49);
            this.CalDataGridview.Name = "CalDataGridview";
            this.CalDataGridview.ReadOnly = true;
            this.CalDataGridview.RowHeadersVisible = false;
            this.CalDataGridview.RowHeadersWidth = 51;
            this.CalDataGridview.RowTemplate.Height = 24;
            this.CalDataGridview.Size = new System.Drawing.Size(754, 127);
            this.CalDataGridview.TabIndex = 1;
            this.CalDataGridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CalDataGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CalDataGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CalDataGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CalDataGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CalDataGridview.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.CalDataGridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CalDataGridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CalDataGridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CalDataGridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalDataGridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CalDataGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CalDataGridview.ThemeStyle.HeaderStyle.Height = 20;
            this.CalDataGridview.ThemeStyle.ReadOnly = true;
            this.CalDataGridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CalDataGridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CalDataGridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalDataGridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CalDataGridview.ThemeStyle.RowsStyle.Height = 24;
            this.CalDataGridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CalDataGridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ApplicantId
            // 
            this.ApplicantId.Animated = true;
            this.ApplicantId.BorderColor = System.Drawing.Color.Gray;
            this.ApplicantId.BorderRadius = 3;
            this.ApplicantId.BorderThickness = 3;
            this.ApplicantId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ApplicantId.DefaultText = "";
            this.ApplicantId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ApplicantId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ApplicantId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ApplicantId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ApplicantId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ApplicantId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ApplicantId.ForeColor = System.Drawing.Color.Black;
            this.ApplicantId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ApplicantId.Location = new System.Drawing.Point(813, 102);
            this.ApplicantId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ApplicantId.Name = "ApplicantId";
            this.ApplicantId.PasswordChar = '\0';
            this.ApplicantId.PlaceholderText = "Applicant Id";
            this.ApplicantId.SelectedText = "";
            this.ApplicantId.Size = new System.Drawing.Size(231, 45);
            this.ApplicantId.TabIndex = 2;
            // 
            // Acceptbtn
            // 
            this.Acceptbtn.Animated = true;
            this.Acceptbtn.BorderColor = System.Drawing.Color.Gray;
            this.Acceptbtn.BorderRadius = 3;
            this.Acceptbtn.BorderThickness = 3;
            this.Acceptbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Acceptbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Acceptbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Acceptbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Acceptbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Acceptbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Acceptbtn.FillColor2 = System.Drawing.Color.Yellow;
            this.Acceptbtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acceptbtn.ForeColor = System.Drawing.Color.Black;
            this.Acceptbtn.Location = new System.Drawing.Point(1080, 102);
            this.Acceptbtn.Name = "Acceptbtn";
            this.Acceptbtn.Size = new System.Drawing.Size(180, 45);
            this.Acceptbtn.TabIndex = 3;
            this.Acceptbtn.Text = "Accept";
            this.Acceptbtn.Click += new System.EventHandler(this.Acceptbtn_Click);
            // 
            // RejectAPbtn
            // 
            this.RejectAPbtn.BorderColor = System.Drawing.Color.DimGray;
            this.RejectAPbtn.BorderRadius = 5;
            this.RejectAPbtn.BorderThickness = 3;
            this.RejectAPbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RejectAPbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RejectAPbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RejectAPbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RejectAPbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RejectAPbtn.FillColor = System.Drawing.Color.Red;
            this.RejectAPbtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RejectAPbtn.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.RejectAPbtn.ForeColor = System.Drawing.Color.White;
            this.RejectAPbtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.RejectAPbtn.Location = new System.Drawing.Point(1286, 102);
            this.RejectAPbtn.Name = "RejectAPbtn";
            this.RejectAPbtn.Size = new System.Drawing.Size(180, 45);
            this.RejectAPbtn.TabIndex = 3;
            this.RejectAPbtn.Text = "Reject";
            this.RejectAPbtn.Click += new System.EventHandler(this.RejectAPbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(12, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Friends:";
            // 
            // FriendsDatagridview
            // 
            this.FriendsDatagridview.AllowUserToAddRows = false;
            this.FriendsDatagridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.FriendsDatagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.FriendsDatagridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.FriendsDatagridview.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FriendsDatagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.FriendsDatagridview.ColumnHeadersHeight = 20;
            this.FriendsDatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FriendsDatagridview.DefaultCellStyle = dataGridViewCellStyle6;
            this.FriendsDatagridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FriendsDatagridview.Location = new System.Drawing.Point(12, 230);
            this.FriendsDatagridview.Name = "FriendsDatagridview";
            this.FriendsDatagridview.ReadOnly = true;
            this.FriendsDatagridview.RowHeadersVisible = false;
            this.FriendsDatagridview.RowHeadersWidth = 51;
            this.FriendsDatagridview.RowTemplate.Height = 24;
            this.FriendsDatagridview.Size = new System.Drawing.Size(761, 134);
            this.FriendsDatagridview.TabIndex = 4;
            this.FriendsDatagridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.FriendsDatagridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.FriendsDatagridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.FriendsDatagridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.FriendsDatagridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.FriendsDatagridview.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.FriendsDatagridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FriendsDatagridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.FriendsDatagridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.FriendsDatagridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendsDatagridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.FriendsDatagridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.FriendsDatagridview.ThemeStyle.HeaderStyle.Height = 20;
            this.FriendsDatagridview.ThemeStyle.ReadOnly = true;
            this.FriendsDatagridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.FriendsDatagridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FriendsDatagridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendsDatagridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FriendsDatagridview.ThemeStyle.RowsStyle.Height = 24;
            this.FriendsDatagridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FriendsDatagridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FriendsDatagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FriendsDatagridview_CellContentClick);
            // 
            // Friendcodetxt
            // 
            this.Friendcodetxt.Animated = true;
            this.Friendcodetxt.BorderColor = System.Drawing.Color.Gray;
            this.Friendcodetxt.BorderRadius = 3;
            this.Friendcodetxt.BorderThickness = 3;
            this.Friendcodetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Friendcodetxt.DefaultText = "";
            this.Friendcodetxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Friendcodetxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Friendcodetxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Friendcodetxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Friendcodetxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Friendcodetxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Friendcodetxt.ForeColor = System.Drawing.Color.Black;
            this.Friendcodetxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Friendcodetxt.Location = new System.Drawing.Point(1017, 291);
            this.Friendcodetxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Friendcodetxt.Name = "Friendcodetxt";
            this.Friendcodetxt.PasswordChar = '\0';
            this.Friendcodetxt.PlaceholderText = "Friend code";
            this.Friendcodetxt.SelectedText = "";
            this.Friendcodetxt.Size = new System.Drawing.Size(231, 45);
            this.Friendcodetxt.TabIndex = 2;
            // 
            // Sendbtn
            // 
            this.Sendbtn.Animated = true;
            this.Sendbtn.BorderColor = System.Drawing.Color.Gray;
            this.Sendbtn.BorderRadius = 3;
            this.Sendbtn.BorderThickness = 3;
            this.Sendbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Sendbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Sendbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Sendbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Sendbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Sendbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Sendbtn.FillColor2 = System.Drawing.Color.Yellow;
            this.Sendbtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sendbtn.ForeColor = System.Drawing.Color.Black;
            this.Sendbtn.Location = new System.Drawing.Point(1297, 291);
            this.Sendbtn.Name = "Sendbtn";
            this.Sendbtn.Size = new System.Drawing.Size(180, 45);
            this.Sendbtn.TabIndex = 3;
            this.Sendbtn.Text = "Send";
            this.Sendbtn.Click += new System.EventHandler(this.Sendbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Chocolate;
            this.label3.Location = new System.Drawing.Point(808, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 87);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter code of\r\nyour friend\r\nto send request\r\n";
            // 
            // PendingMatchDataGridview
            // 
            this.PendingMatchDataGridview.AllowUserToAddRows = false;
            this.PendingMatchDataGridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.PendingMatchDataGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.PendingMatchDataGridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.PendingMatchDataGridview.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PendingMatchDataGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.PendingMatchDataGridview.ColumnHeadersHeight = 20;
            this.PendingMatchDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PendingMatchDataGridview.DefaultCellStyle = dataGridViewCellStyle9;
            this.PendingMatchDataGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PendingMatchDataGridview.Location = new System.Drawing.Point(12, 465);
            this.PendingMatchDataGridview.Name = "PendingMatchDataGridview";
            this.PendingMatchDataGridview.ReadOnly = true;
            this.PendingMatchDataGridview.RowHeadersVisible = false;
            this.PendingMatchDataGridview.RowHeadersWidth = 51;
            this.PendingMatchDataGridview.RowTemplate.Height = 24;
            this.PendingMatchDataGridview.Size = new System.Drawing.Size(761, 134);
            this.PendingMatchDataGridview.TabIndex = 4;
            this.PendingMatchDataGridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PendingMatchDataGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PendingMatchDataGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PendingMatchDataGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PendingMatchDataGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PendingMatchDataGridview.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.PendingMatchDataGridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PendingMatchDataGridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PendingMatchDataGridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PendingMatchDataGridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingMatchDataGridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PendingMatchDataGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PendingMatchDataGridview.ThemeStyle.HeaderStyle.Height = 20;
            this.PendingMatchDataGridview.ThemeStyle.ReadOnly = true;
            this.PendingMatchDataGridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PendingMatchDataGridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PendingMatchDataGridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingMatchDataGridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PendingMatchDataGridview.ThemeStyle.RowsStyle.Height = 24;
            this.PendingMatchDataGridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PendingMatchDataGridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PendingMatchDataGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Chocolate;
            this.label5.Location = new System.Drawing.Point(14, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pending Matches:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Chocolate;
            this.label6.Location = new System.Drawing.Point(808, 496);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 116);
            this.label6.TabIndex = 5;
            this.label6.Text = "Enter the id \r\nof match\r\nto play\r\n\r\n";
            // 
            // MatchIDtxt
            // 
            this.MatchIDtxt.Animated = true;
            this.MatchIDtxt.BorderColor = System.Drawing.Color.Gray;
            this.MatchIDtxt.BorderRadius = 3;
            this.MatchIDtxt.BorderThickness = 3;
            this.MatchIDtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MatchIDtxt.DefaultText = "";
            this.MatchIDtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MatchIDtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MatchIDtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MatchIDtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MatchIDtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MatchIDtxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MatchIDtxt.ForeColor = System.Drawing.Color.Black;
            this.MatchIDtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MatchIDtxt.Location = new System.Drawing.Point(1017, 526);
            this.MatchIDtxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MatchIDtxt.Name = "MatchIDtxt";
            this.MatchIDtxt.PasswordChar = '\0';
            this.MatchIDtxt.PlaceholderText = "Match Id";
            this.MatchIDtxt.SelectedText = "";
            this.MatchIDtxt.Size = new System.Drawing.Size(231, 45);
            this.MatchIDtxt.TabIndex = 2;
            this.MatchIDtxt.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.BorderColor = System.Drawing.Color.Gray;
            this.guna2GradientButton1.BorderRadius = 3;
            this.guna2GradientButton1.BorderThickness = 3;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Khaki;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton1.Location = new System.Drawing.Point(1306, 526);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(180, 45);
            this.guna2GradientButton1.TabIndex = 3;
            this.guna2GradientButton1.Text = "Play";
            this.guna2GradientButton1.Click += new System.EventHandler(this.Pendingbtn);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BorderColor = System.Drawing.Color.DimGray;
            this.guna2GradientButton2.BorderRadius = 5;
            this.guna2GradientButton2.BorderThickness = 3;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.Red;
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton2.Location = new System.Drawing.Point(1173, 643);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(180, 45);
            this.guna2GradientButton2.TabIndex = 3;
            this.guna2GradientButton2.Text = "Logout";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // GroupGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1514, 722);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PendingMatchDataGridview);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FriendsDatagridview);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.RejectAPbtn);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.Sendbtn);
            this.Controls.Add(this.Acceptbtn);
            this.Controls.Add(this.MatchIDtxt);
            this.Controls.Add(this.Friendcodetxt);
            this.Controls.Add(this.ApplicantId);
            this.Controls.Add(this.CalDataGridview);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GroupGameForm";
            this.Text = "GroupGameForm";
            this.Load += new System.EventHandler(this.GroupGameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CalDataGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendsDatagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PendingMatchDataGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView CalDataGridview;
        private Guna.UI2.WinForms.Guna2TextBox ApplicantId;
        private Guna.UI2.WinForms.Guna2GradientButton Acceptbtn;
        private Guna.UI2.WinForms.Guna2GradientButton RejectAPbtn;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView FriendsDatagridview;
        private Guna.UI2.WinForms.Guna2TextBox Friendcodetxt;
        private Guna.UI2.WinForms.Guna2GradientButton Sendbtn;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView PendingMatchDataGridview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox MatchIDtxt;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
    }
}