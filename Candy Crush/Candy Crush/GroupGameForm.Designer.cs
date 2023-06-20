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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupGameForm));
            this.label1 = new System.Windows.Forms.Label();
            this.CalDataGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ApplicantId = new Guna.UI2.WinForms.Guna2TextBox();
            this.Acceptbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.RejectAPbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Friendlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FriendsDatagridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Friendcodetxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Sendbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CalDataGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendsDatagridview)).BeginInit();
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
            this.CalDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.CalDataGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CalDataGridview.ThemeStyle.HeaderStyle.Height = 4;
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
            // Friendlbl
            // 
            this.Friendlbl.AutoSize = true;
            this.Friendlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Friendlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Friendlbl.ForeColor = System.Drawing.Color.Khaki;
            this.Friendlbl.Location = new System.Drawing.Point(234, 291);
            this.Friendlbl.Name = "Friendlbl";
            this.Friendlbl.Size = new System.Drawing.Size(317, 29);
            this.Friendlbl.TabIndex = 6;
            this.Friendlbl.Text = "You don\'t have any friend yet";
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
            this.Friendcodetxt.PlaceholderText = "Friend Id";
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
            // GroupGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1514, 722);
            this.Controls.Add(this.Friendlbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FriendsDatagridview);
            this.Controls.Add(this.RejectAPbtn);
            this.Controls.Add(this.Sendbtn);
            this.Controls.Add(this.Acceptbtn);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView CalDataGridview;
        private Guna.UI2.WinForms.Guna2TextBox ApplicantId;
        private Guna.UI2.WinForms.Guna2GradientButton Acceptbtn;
        private Guna.UI2.WinForms.Guna2GradientButton RejectAPbtn;
        private System.Windows.Forms.Label Friendlbl;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView FriendsDatagridview;
        private Guna.UI2.WinForms.Guna2TextBox Friendcodetxt;
        private Guna.UI2.WinForms.Guna2GradientButton Sendbtn;
        private System.Windows.Forms.Label label3;
    }
}