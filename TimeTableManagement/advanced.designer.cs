
namespace TimeTableManagement.Advanced
{
    partial class advanced
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
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton = new MetroFramework.Controls.MetroButton();
            this.tabControlSession = new MetroFramework.Controls.MetroTabControl();
            this.consecutiveSessions = new MetroFramework.Controls.MetroTabPage();
            this.consecSearchBox = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.sesCmb02 = new MetroFramework.Controls.MetroComboBox();
            this.sesCmb01 = new MetroFramework.Controls.MetroComboBox();
            this.consecData = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sessions01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sessions2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.addConBtn = new MetroFramework.Controls.MetroButton();
            this.consecSearchDrpDown = new MetroFramework.Controls.MetroComboBox();
            this.parallelSessions = new MetroFramework.Controls.MetroTabPage();
            this.parSesTimeSlotCmbEnd = new MetroFramework.Controls.MetroComboBox();
            this.parSesTimeSlotCmbStart = new MetroFramework.Controls.MetroComboBox();
            this.parSesDurationCmb = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.parSesCmbBox02 = new MetroFramework.Controls.MetroComboBox();
            this.parSesCmbBox01 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.parSesDayCmb = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.addParBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.shouldNotOverlap = new MetroFramework.Controls.MetroTabPage();
            this.notOverlapSesTimeSlotCmbBoxEnd = new MetroFramework.Controls.MetroComboBox();
            this.notOverlapSesTimeSlotCmbBoxStart = new MetroFramework.Controls.MetroComboBox();
            this.notOverlapSesDurationCmbBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.notOverlapSesCmbBox02 = new MetroFramework.Controls.MetroComboBox();
            this.notOverlapSesCmbBox01 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.notOverlapSesDayCmbBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.addNotOverlapSesBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tabControlSession.SuspendLayout();
            this.consecutiveSessions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consecData)).BeginInit();
            this.parallelSessions.SuspendLayout();
            this.shouldNotOverlap.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Advanced";
            // 
            // metroButton
            // 
            this.metroButton.BackColor = System.Drawing.Color.White;
            this.metroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton.ForeColor = System.Drawing.Color.Black;
            this.metroButton.Location = new System.Drawing.Point(331, 27);
            this.metroButton.Name = "metroButton";
            this.metroButton.Size = new System.Drawing.Size(115, 41);
            this.metroButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton.TabIndex = 117;
            this.metroButton.Text = "Home";
            this.metroButton.UseCustomBackColor = true;
            this.metroButton.UseCustomForeColor = true;
            this.metroButton.UseSelectable = true;
            this.metroButton.Click += new System.EventHandler(this.metroButton_Click);
            // 
            // tabControlSession
            // 
            this.tabControlSession.Controls.Add(this.consecutiveSessions);
            this.tabControlSession.Controls.Add(this.parallelSessions);
            this.tabControlSession.Controls.Add(this.shouldNotOverlap);
            this.tabControlSession.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.tabControlSession.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.tabControlSession.Location = new System.Drawing.Point(82, 91);
            this.tabControlSession.Name = "tabControlSession";
            this.tabControlSession.SelectedIndex = 0;
            this.tabControlSession.Size = new System.Drawing.Size(1105, 610);
            this.tabControlSession.Style = MetroFramework.MetroColorStyle.Blue;
            this.tabControlSession.TabIndex = 118;
            this.tabControlSession.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabControlSession.UseCustomBackColor = true;
            this.tabControlSession.UseCustomForeColor = true;
            this.tabControlSession.UseSelectable = true;
            // 
            // consecutiveSessions
            // 
            this.consecutiveSessions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consecutiveSessions.Controls.Add(this.consecSearchBox);
            this.consecutiveSessions.Controls.Add(this.metroButton1);
            this.consecutiveSessions.Controls.Add(this.metroLabel3);
            this.consecutiveSessions.Controls.Add(this.sesCmb02);
            this.consecutiveSessions.Controls.Add(this.sesCmb01);
            this.consecutiveSessions.Controls.Add(this.consecData);
            this.consecutiveSessions.Controls.Add(this.metroLabel10);
            this.consecutiveSessions.Controls.Add(this.addConBtn);
            this.consecutiveSessions.Controls.Add(this.consecSearchDrpDown);
            this.consecutiveSessions.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consecutiveSessions.HorizontalScrollbarBarColor = true;
            this.consecutiveSessions.HorizontalScrollbarHighlightOnWheel = false;
            this.consecutiveSessions.HorizontalScrollbarSize = 10;
            this.consecutiveSessions.Location = new System.Drawing.Point(4, 34);
            this.consecutiveSessions.Name = "consecutiveSessions";
            this.consecutiveSessions.Size = new System.Drawing.Size(1097, 572);
            this.consecutiveSessions.TabIndex = 1;
            this.consecutiveSessions.Text = "Consecutive";
            this.consecutiveSessions.VerticalScrollbarBarColor = true;
            this.consecutiveSessions.VerticalScrollbarHighlightOnWheel = false;
            this.consecutiveSessions.VerticalScrollbarSize = 10;
            this.consecutiveSessions.Click += new System.EventHandler(this.consecutiveSessions_Click);
            // 
            // consecSearchBox
            // 
            // 
            // 
            // 
            this.consecSearchBox.CustomButton.Image = null;
            this.consecSearchBox.CustomButton.Location = new System.Drawing.Point(188, 2);
            this.consecSearchBox.CustomButton.Name = "";
            this.consecSearchBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.consecSearchBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.consecSearchBox.CustomButton.TabIndex = 1;
            this.consecSearchBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.consecSearchBox.CustomButton.UseSelectable = true;
            this.consecSearchBox.CustomButton.Visible = false;
            this.consecSearchBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.consecSearchBox.Lines = new string[0];
            this.consecSearchBox.Location = new System.Drawing.Point(807, 97);
            this.consecSearchBox.MaxLength = 32767;
            this.consecSearchBox.Name = "consecSearchBox";
            this.consecSearchBox.PasswordChar = '\0';
            this.consecSearchBox.PromptText = "Search";
            this.consecSearchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.consecSearchBox.SelectedText = "";
            this.consecSearchBox.SelectionLength = 0;
            this.consecSearchBox.SelectionStart = 0;
            this.consecSearchBox.ShortcutsEnabled = true;
            this.consecSearchBox.Size = new System.Drawing.Size(216, 30);
            this.consecSearchBox.TabIndex = 137;
            this.consecSearchBox.UseSelectable = true;
            this.consecSearchBox.WaterMark = "Search";
            this.consecSearchBox.WaterMarkColor = System.Drawing.Color.DimGray;
            this.consecSearchBox.WaterMarkFont = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consecSearchBox.TextChanged += new System.EventHandler(this.consecSearchBox_TextChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.SystemColors.Highlight;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(73, 391);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(286, 41);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButton1.TabIndex = 135;
            this.metroButton1.Text = "Clear";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(432, 360);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(0, 0);
            this.metroLabel3.TabIndex = 100;
            // 
            // sesCmb02
            // 
            this.sesCmb02.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.sesCmb02.FormattingEnabled = true;
            this.sesCmb02.ItemHeight = 24;
            this.sesCmb02.Location = new System.Drawing.Point(73, 231);
            this.sesCmb02.Name = "sesCmb02";
            this.sesCmb02.PromptText = "Select Sessions 02";
            this.sesCmb02.Size = new System.Drawing.Size(286, 30);
            this.sesCmb02.Style = MetroFramework.MetroColorStyle.Blue;
            this.sesCmb02.TabIndex = 97;
            this.sesCmb02.UseSelectable = true;
            // 
            // sesCmb01
            // 
            this.sesCmb01.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.sesCmb01.FormattingEnabled = true;
            this.sesCmb01.ItemHeight = 24;
            this.sesCmb01.Location = new System.Drawing.Point(73, 165);
            this.sesCmb01.Name = "sesCmb01";
            this.sesCmb01.PromptText = "Select Session 01";
            this.sesCmb01.Size = new System.Drawing.Size(286, 30);
            this.sesCmb01.Style = MetroFramework.MetroColorStyle.Blue;
            this.sesCmb01.TabIndex = 96;
            this.sesCmb01.UseSelectable = true;
            // 
            // consecData
            // 
            this.consecData.AllowUserToResizeRows = false;
            this.consecData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.consecData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consecData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.consecData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.consecData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.consecData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consecData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Sessions01,
            this.Sessions2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.consecData.DefaultCellStyle = dataGridViewCellStyle2;
            this.consecData.EnableHeadersVisualStyles = false;
            this.consecData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.consecData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.consecData.Location = new System.Drawing.Point(432, 162);
            this.consecData.Name = "consecData";
            this.consecData.ReadOnly = true;
            this.consecData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.consecData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.consecData.RowHeadersVisible = false;
            this.consecData.RowHeadersWidth = 51;
            this.consecData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.consecData.RowTemplate.Height = 24;
            this.consecData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.consecData.Size = new System.Drawing.Size(609, 298);
            this.consecData.TabIndex = 95;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // Sessions01
            // 
            this.Sessions01.DataPropertyName = "Sessions01";
            this.Sessions01.HeaderText = "Session 01";
            this.Sessions01.MinimumWidth = 6;
            this.Sessions01.Name = "Sessions01";
            this.Sessions01.ReadOnly = true;
            this.Sessions01.Width = 200;
            // 
            // Sessions2
            // 
            this.Sessions2.DataPropertyName = "Sessions2";
            this.Sessions2.HeaderText = "Session 02";
            this.Sessions2.MinimumWidth = 6;
            this.Sessions2.Name = "Sessions2";
            this.Sessions2.ReadOnly = true;
            this.Sessions2.Width = 200;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(432, 13);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(245, 25);
            this.metroLabel10.TabIndex = 92;
            this.metroLabel10.Text = "Add Consecutive Sessions ";
            // 
            // addConBtn
            // 
            this.addConBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.addConBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.addConBtn.Highlight = true;
            this.addConBtn.Location = new System.Drawing.Point(73, 319);
            this.addConBtn.Name = "addConBtn";
            this.addConBtn.Size = new System.Drawing.Size(286, 41);
            this.addConBtn.Style = MetroFramework.MetroColorStyle.Teal;
            this.addConBtn.TabIndex = 84;
            this.addConBtn.Text = "Add Consecutive Session";
            this.addConBtn.UseCustomBackColor = true;
            this.addConBtn.UseSelectable = true;
            this.addConBtn.Click += new System.EventHandler(this.addConBtn_Click);
            // 
            // consecSearchDrpDown
            // 
            this.consecSearchDrpDown.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.consecSearchDrpDown.FormattingEnabled = true;
            this.consecSearchDrpDown.ItemHeight = 24;
            this.consecSearchDrpDown.Items.AddRange(new object[] {
            "ID",
            "Session01",
            "Session02"});
            this.consecSearchDrpDown.Location = new System.Drawing.Point(459, 97);
            this.consecSearchDrpDown.Name = "consecSearchDrpDown";
            this.consecSearchDrpDown.PromptText = "Select Sessions";
            this.consecSearchDrpDown.Size = new System.Drawing.Size(218, 30);
            this.consecSearchDrpDown.Style = MetroFramework.MetroColorStyle.Blue;
            this.consecSearchDrpDown.TabIndex = 78;
            this.consecSearchDrpDown.UseSelectable = true;
            // 
            // parallelSessions
            // 
            this.parallelSessions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.parallelSessions.Controls.Add(this.parSesTimeSlotCmbEnd);
            this.parallelSessions.Controls.Add(this.parSesTimeSlotCmbStart);
            this.parallelSessions.Controls.Add(this.parSesDurationCmb);
            this.parallelSessions.Controls.Add(this.metroLabel12);
            this.parallelSessions.Controls.Add(this.parSesCmbBox02);
            this.parallelSessions.Controls.Add(this.parSesCmbBox01);
            this.parallelSessions.Controls.Add(this.metroLabel13);
            this.parallelSessions.Controls.Add(this.parSesDayCmb);
            this.parallelSessions.Controls.Add(this.metroLabel14);
            this.parallelSessions.Controls.Add(this.metroLabel15);
            this.parallelSessions.Controls.Add(this.metroButton2);
            this.parallelSessions.Controls.Add(this.addParBtn);
            this.parallelSessions.Controls.Add(this.metroLabel11);
            this.parallelSessions.Font = new System.Drawing.Font("Microsoft Uighur", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parallelSessions.HorizontalScrollbarBarColor = true;
            this.parallelSessions.HorizontalScrollbarHighlightOnWheel = false;
            this.parallelSessions.HorizontalScrollbarSize = 10;
            this.parallelSessions.Location = new System.Drawing.Point(4, 34);
            this.parallelSessions.Name = "parallelSessions";
            this.parallelSessions.Size = new System.Drawing.Size(1097, 572);
            this.parallelSessions.TabIndex = 0;
            this.parallelSessions.Text = "Parallel";
            this.parallelSessions.VerticalScrollbarBarColor = true;
            this.parallelSessions.VerticalScrollbarHighlightOnWheel = false;
            this.parallelSessions.VerticalScrollbarSize = 10;
            this.parallelSessions.Click += new System.EventHandler(this.tabPageLecAdd_Click);
            // 
            // parSesTimeSlotCmbEnd
            // 
            this.parSesTimeSlotCmbEnd.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.parSesTimeSlotCmbEnd.FormattingEnabled = true;
            this.parSesTimeSlotCmbEnd.ItemHeight = 24;
            this.parSesTimeSlotCmbEnd.Items.AddRange(new object[] {
            "8.30 am",
            "9.00 am",
            "9.30 am",
            "10.00 am ",
            "10.30 am",
            "11.00 am ",
            "11.30 am ",
            "12.00 noon",
            "12.30 noon",
            "1.00 pm",
            "1.30 pm",
            "2.00 pm",
            "2.30 pm",
            "3.00 pm",
            "3.30 pm",
            "4.00 pm",
            "4.30 pm",
            "5.00 pm",
            "5.30 pm"});
            this.parSesTimeSlotCmbEnd.Location = new System.Drawing.Point(817, 339);
            this.parSesTimeSlotCmbEnd.Name = "parSesTimeSlotCmbEnd";
            this.parSesTimeSlotCmbEnd.PromptText = "Select End Time";
            this.parSesTimeSlotCmbEnd.Size = new System.Drawing.Size(239, 30);
            this.parSesTimeSlotCmbEnd.Style = MetroFramework.MetroColorStyle.Blue;
            this.parSesTimeSlotCmbEnd.TabIndex = 122;
            this.parSesTimeSlotCmbEnd.UseSelectable = true;
            // 
            // parSesTimeSlotCmbStart
            // 
            this.parSesTimeSlotCmbStart.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.parSesTimeSlotCmbStart.FormattingEnabled = true;
            this.parSesTimeSlotCmbStart.ItemHeight = 24;
            this.parSesTimeSlotCmbStart.Items.AddRange(new object[] {
            "8.30 am",
            "9.00 am",
            "9.30 am",
            "10.00 am ",
            "10.30 am",
            "11.00 am ",
            "11.30 am ",
            "12.00 noon",
            "12.30 noon",
            "1.00 pm",
            "1.30 pm",
            "2.00 pm",
            "2.30 pm",
            "3.00 pm",
            "3.30 pm",
            "4.00 pm",
            "4.30 pm",
            "5.00 pm",
            "5.30 pm"});
            this.parSesTimeSlotCmbStart.Location = new System.Drawing.Point(534, 339);
            this.parSesTimeSlotCmbStart.Name = "parSesTimeSlotCmbStart";
            this.parSesTimeSlotCmbStart.PromptText = "Select Start Time";
            this.parSesTimeSlotCmbStart.Size = new System.Drawing.Size(239, 30);
            this.parSesTimeSlotCmbStart.Style = MetroFramework.MetroColorStyle.Blue;
            this.parSesTimeSlotCmbStart.TabIndex = 121;
            this.parSesTimeSlotCmbStart.UseSelectable = true;
            // 
            // parSesDurationCmb
            // 
            this.parSesDurationCmb.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.parSesDurationCmb.FormattingEnabled = true;
            this.parSesDurationCmb.ItemHeight = 24;
            this.parSesDurationCmb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.parSesDurationCmb.Location = new System.Drawing.Point(244, 271);
            this.parSesDurationCmb.Name = "parSesDurationCmb";
            this.parSesDurationCmb.PromptText = "Select Duration";
            this.parSesDurationCmb.Size = new System.Drawing.Size(239, 30);
            this.parSesDurationCmb.Style = MetroFramework.MetroColorStyle.Blue;
            this.parSesDurationCmb.TabIndex = 120;
            this.parSesDurationCmb.UseSelectable = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(39, 271);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(71, 20);
            this.metroLabel12.TabIndex = 119;
            this.metroLabel12.Text = "Duration";
            // 
            // parSesCmbBox02
            // 
            this.parSesCmbBox02.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.parSesCmbBox02.FormattingEnabled = true;
            this.parSesCmbBox02.ItemHeight = 24;
            this.parSesCmbBox02.Location = new System.Drawing.Point(244, 205);
            this.parSesCmbBox02.Name = "parSesCmbBox02";
            this.parSesCmbBox02.PromptText = "Select Session 02";
            this.parSesCmbBox02.Size = new System.Drawing.Size(239, 30);
            this.parSesCmbBox02.Style = MetroFramework.MetroColorStyle.Blue;
            this.parSesCmbBox02.TabIndex = 118;
            this.parSesCmbBox02.UseSelectable = true;
            // 
            // parSesCmbBox01
            // 
            this.parSesCmbBox01.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.parSesCmbBox01.FormattingEnabled = true;
            this.parSesCmbBox01.ItemHeight = 24;
            this.parSesCmbBox01.Location = new System.Drawing.Point(244, 142);
            this.parSesCmbBox01.Name = "parSesCmbBox01";
            this.parSesCmbBox01.PromptText = "Select Session 01";
            this.parSesCmbBox01.Size = new System.Drawing.Size(239, 30);
            this.parSesCmbBox01.Style = MetroFramework.MetroColorStyle.Blue;
            this.parSesCmbBox01.TabIndex = 117;
            this.parSesCmbBox01.UseSelectable = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.Location = new System.Drawing.Point(39, 205);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(83, 20);
            this.metroLabel13.TabIndex = 116;
            this.metroLabel13.Text = "Session 02";
            // 
            // parSesDayCmb
            // 
            this.parSesDayCmb.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.parSesDayCmb.FormattingEnabled = true;
            this.parSesDayCmb.ItemHeight = 24;
            this.parSesDayCmb.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.parSesDayCmb.Location = new System.Drawing.Point(244, 339);
            this.parSesDayCmb.Name = "parSesDayCmb";
            this.parSesDayCmb.PromptText = "Select Day";
            this.parSesDayCmb.Size = new System.Drawing.Size(239, 30);
            this.parSesDayCmb.Style = MetroFramework.MetroColorStyle.Blue;
            this.parSesDayCmb.TabIndex = 115;
            this.parSesDayCmb.UseSelectable = true;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel14.Location = new System.Drawing.Point(39, 339);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(105, 20);
            this.metroLabel14.TabIndex = 114;
            this.metroLabel14.Text = "Day and Time";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.Location = new System.Drawing.Point(39, 142);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(83, 20);
            this.metroLabel15.TabIndex = 113;
            this.metroLabel15.Text = "Session 01";
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(593, 445);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(265, 53);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButton2.TabIndex = 112;
            this.metroButton2.Text = "Clear";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // addParBtn
            // 
            this.addParBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addParBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.addParBtn.Highlight = true;
            this.addParBtn.Location = new System.Drawing.Point(280, 445);
            this.addParBtn.Name = "addParBtn";
            this.addParBtn.Size = new System.Drawing.Size(265, 53);
            this.addParBtn.Style = MetroFramework.MetroColorStyle.Teal;
            this.addParBtn.TabIndex = 111;
            this.addParBtn.Text = "Add  Parallel Session";
            this.addParBtn.UseCustomBackColor = true;
            this.addParBtn.UseSelectable = true;
            this.addParBtn.Click += new System.EventHandler(this.addParBtn_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(439, 37);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(198, 25);
            this.metroLabel11.TabIndex = 93;
            this.metroLabel11.Text = "Add Parallel Sessions";
            // 
            // shouldNotOverlap
            // 
            this.shouldNotOverlap.Controls.Add(this.notOverlapSesTimeSlotCmbBoxEnd);
            this.shouldNotOverlap.Controls.Add(this.notOverlapSesTimeSlotCmbBoxStart);
            this.shouldNotOverlap.Controls.Add(this.notOverlapSesDurationCmbBox);
            this.shouldNotOverlap.Controls.Add(this.metroLabel1);
            this.shouldNotOverlap.Controls.Add(this.notOverlapSesCmbBox02);
            this.shouldNotOverlap.Controls.Add(this.notOverlapSesCmbBox01);
            this.shouldNotOverlap.Controls.Add(this.metroLabel2);
            this.shouldNotOverlap.Controls.Add(this.notOverlapSesDayCmbBox);
            this.shouldNotOverlap.Controls.Add(this.metroLabel4);
            this.shouldNotOverlap.Controls.Add(this.metroLabel5);
            this.shouldNotOverlap.Controls.Add(this.metroButton3);
            this.shouldNotOverlap.Controls.Add(this.addNotOverlapSesBtn);
            this.shouldNotOverlap.Controls.Add(this.metroLabel6);
            this.shouldNotOverlap.HorizontalScrollbarBarColor = true;
            this.shouldNotOverlap.HorizontalScrollbarHighlightOnWheel = false;
            this.shouldNotOverlap.HorizontalScrollbarSize = 10;
            this.shouldNotOverlap.Location = new System.Drawing.Point(4, 34);
            this.shouldNotOverlap.Name = "shouldNotOverlap";
            this.shouldNotOverlap.Size = new System.Drawing.Size(1097, 572);
            this.shouldNotOverlap.TabIndex = 2;
            this.shouldNotOverlap.Text = "Not Overlapping";
            this.shouldNotOverlap.VerticalScrollbarBarColor = true;
            this.shouldNotOverlap.VerticalScrollbarHighlightOnWheel = false;
            this.shouldNotOverlap.VerticalScrollbarSize = 10;
            // 
            // notOverlapSesTimeSlotCmbBoxEnd
            // 
            this.notOverlapSesTimeSlotCmbBoxEnd.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.notOverlapSesTimeSlotCmbBoxEnd.FormattingEnabled = true;
            this.notOverlapSesTimeSlotCmbBoxEnd.ItemHeight = 24;
            this.notOverlapSesTimeSlotCmbBoxEnd.Items.AddRange(new object[] {
            "8.30 am",
            "9.00 am",
            "9.30 am",
            "10.00 am ",
            "10.30 am",
            "11.00 am ",
            "11.30 am ",
            "12.00 noon",
            "12.30 noon",
            "1.00 pm",
            "1.30 pm",
            "2.00 pm",
            "2.30 pm",
            "3.00 pm",
            "3.30 pm",
            "4.00 pm",
            "4.30 pm",
            "5.00 pm",
            "5.30 pm"});
            this.notOverlapSesTimeSlotCmbBoxEnd.Location = new System.Drawing.Point(818, 358);
            this.notOverlapSesTimeSlotCmbBoxEnd.Name = "notOverlapSesTimeSlotCmbBoxEnd";
            this.notOverlapSesTimeSlotCmbBoxEnd.PromptText = "Select End Time";
            this.notOverlapSesTimeSlotCmbBoxEnd.Size = new System.Drawing.Size(239, 30);
            this.notOverlapSesTimeSlotCmbBoxEnd.Style = MetroFramework.MetroColorStyle.Blue;
            this.notOverlapSesTimeSlotCmbBoxEnd.TabIndex = 135;
            this.notOverlapSesTimeSlotCmbBoxEnd.UseSelectable = true;
            // 
            // notOverlapSesTimeSlotCmbBoxStart
            // 
            this.notOverlapSesTimeSlotCmbBoxStart.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.notOverlapSesTimeSlotCmbBoxStart.FormattingEnabled = true;
            this.notOverlapSesTimeSlotCmbBoxStart.ItemHeight = 24;
            this.notOverlapSesTimeSlotCmbBoxStart.Items.AddRange(new object[] {
            "8.30 am",
            "9.00 am",
            "9.30 am",
            "10.00 am ",
            "10.30 am",
            "11.00 am ",
            "11.30 am ",
            "12.00 noon",
            "12.30 noon",
            "1.00 pm",
            "1.30 pm",
            "2.00 pm",
            "2.30 pm",
            "3.00 pm",
            "3.30 pm",
            "4.00 pm",
            "4.30 pm",
            "5.00 pm",
            "5.30 pm"});
            this.notOverlapSesTimeSlotCmbBoxStart.Location = new System.Drawing.Point(535, 358);
            this.notOverlapSesTimeSlotCmbBoxStart.Name = "notOverlapSesTimeSlotCmbBoxStart";
            this.notOverlapSesTimeSlotCmbBoxStart.PromptText = "Select Start Time";
            this.notOverlapSesTimeSlotCmbBoxStart.Size = new System.Drawing.Size(239, 30);
            this.notOverlapSesTimeSlotCmbBoxStart.Style = MetroFramework.MetroColorStyle.Blue;
            this.notOverlapSesTimeSlotCmbBoxStart.TabIndex = 134;
            this.notOverlapSesTimeSlotCmbBoxStart.UseSelectable = true;
            // 
            // notOverlapSesDurationCmbBox
            // 
            this.notOverlapSesDurationCmbBox.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.notOverlapSesDurationCmbBox.FormattingEnabled = true;
            this.notOverlapSesDurationCmbBox.ItemHeight = 24;
            this.notOverlapSesDurationCmbBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.notOverlapSesDurationCmbBox.Location = new System.Drawing.Point(245, 290);
            this.notOverlapSesDurationCmbBox.Name = "notOverlapSesDurationCmbBox";
            this.notOverlapSesDurationCmbBox.PromptText = "Select Duration";
            this.notOverlapSesDurationCmbBox.Size = new System.Drawing.Size(239, 30);
            this.notOverlapSesDurationCmbBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.notOverlapSesDurationCmbBox.TabIndex = 133;
            this.notOverlapSesDurationCmbBox.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(40, 290);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 20);
            this.metroLabel1.TabIndex = 132;
            this.metroLabel1.Text = "Duration";
            // 
            // notOverlapSesCmbBox02
            // 
            this.notOverlapSesCmbBox02.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.notOverlapSesCmbBox02.FormattingEnabled = true;
            this.notOverlapSesCmbBox02.ItemHeight = 24;
            this.notOverlapSesCmbBox02.Location = new System.Drawing.Point(245, 224);
            this.notOverlapSesCmbBox02.Name = "notOverlapSesCmbBox02";
            this.notOverlapSesCmbBox02.PromptText = "Select Session 02";
            this.notOverlapSesCmbBox02.Size = new System.Drawing.Size(239, 30);
            this.notOverlapSesCmbBox02.Style = MetroFramework.MetroColorStyle.Blue;
            this.notOverlapSesCmbBox02.TabIndex = 131;
            this.notOverlapSesCmbBox02.UseSelectable = true;
            // 
            // notOverlapSesCmbBox01
            // 
            this.notOverlapSesCmbBox01.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.notOverlapSesCmbBox01.FormattingEnabled = true;
            this.notOverlapSesCmbBox01.ItemHeight = 24;
            this.notOverlapSesCmbBox01.Location = new System.Drawing.Point(245, 161);
            this.notOverlapSesCmbBox01.Name = "notOverlapSesCmbBox01";
            this.notOverlapSesCmbBox01.PromptText = "Select Session 01";
            this.notOverlapSesCmbBox01.Size = new System.Drawing.Size(239, 30);
            this.notOverlapSesCmbBox01.Style = MetroFramework.MetroColorStyle.Blue;
            this.notOverlapSesCmbBox01.TabIndex = 130;
            this.notOverlapSesCmbBox01.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(40, 224);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 20);
            this.metroLabel2.TabIndex = 129;
            this.metroLabel2.Text = "Session 02";
            // 
            // notOverlapSesDayCmbBox
            // 
            this.notOverlapSesDayCmbBox.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.notOverlapSesDayCmbBox.FormattingEnabled = true;
            this.notOverlapSesDayCmbBox.ItemHeight = 24;
            this.notOverlapSesDayCmbBox.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.notOverlapSesDayCmbBox.Location = new System.Drawing.Point(245, 358);
            this.notOverlapSesDayCmbBox.Name = "notOverlapSesDayCmbBox";
            this.notOverlapSesDayCmbBox.PromptText = "Select Day";
            this.notOverlapSesDayCmbBox.Size = new System.Drawing.Size(239, 30);
            this.notOverlapSesDayCmbBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.notOverlapSesDayCmbBox.TabIndex = 128;
            this.notOverlapSesDayCmbBox.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(40, 358);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(105, 20);
            this.metroLabel4.TabIndex = 127;
            this.metroLabel4.Text = "Day and Time";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(40, 161);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(83, 20);
            this.metroLabel5.TabIndex = 126;
            this.metroLabel5.Text = "Session 01";
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton3.Highlight = true;
            this.metroButton3.Location = new System.Drawing.Point(594, 464);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(265, 53);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButton3.TabIndex = 125;
            this.metroButton3.Text = "Clear";
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // addNotOverlapSesBtn
            // 
            this.addNotOverlapSesBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addNotOverlapSesBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.addNotOverlapSesBtn.Highlight = true;
            this.addNotOverlapSesBtn.Location = new System.Drawing.Point(281, 464);
            this.addNotOverlapSesBtn.Name = "addNotOverlapSesBtn";
            this.addNotOverlapSesBtn.Size = new System.Drawing.Size(265, 53);
            this.addNotOverlapSesBtn.Style = MetroFramework.MetroColorStyle.Teal;
            this.addNotOverlapSesBtn.TabIndex = 124;
            this.addNotOverlapSesBtn.Text = "Add  Parallel Session";
            this.addNotOverlapSesBtn.UseCustomBackColor = true;
            this.addNotOverlapSesBtn.UseSelectable = true;
            this.addNotOverlapSesBtn.Click += new System.EventHandler(this.addNotOverlapSesBtn_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(440, 56);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(282, 25);
            this.metroLabel6.TabIndex = 123;
            this.metroLabel6.Text = "Add Not Overlapping Sessions";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // advanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::TimeTableManagement.Properties.Resources.Background;
            this.BackMaxSize = 960;
            this.ClientSize = new System.Drawing.Size(1280, 738);
            this.Controls.Add(this.tabControlSession);
            this.Controls.Add(this.metroButton);
            this.Controls.Add(this.label1);
            this.Name = "advanced";
            this.Load += new System.EventHandler(this.Advanced_Load);
            this.tabControlSession.ResumeLayout(false);
            this.consecutiveSessions.ResumeLayout(false);
            this.consecutiveSessions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consecData)).EndInit();
            this.parallelSessions.ResumeLayout(false);
            this.parallelSessions.PerformLayout();
            this.shouldNotOverlap.ResumeLayout(false);
            this.shouldNotOverlap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton;
        private MetroFramework.Controls.MetroTabControl tabControlSession;
        private MetroFramework.Controls.MetroTabPage consecutiveSessions;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox sesCmb02;
        private MetroFramework.Controls.MetroComboBox sesCmb01;
        private MetroFramework.Controls.MetroGrid consecData;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton addConBtn;
        private MetroFramework.Controls.MetroComboBox consecSearchDrpDown;
        private MetroFramework.Controls.MetroTabPage parallelSessions;
        private MetroFramework.Controls.MetroComboBox parSesDurationCmb;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroComboBox parSesCmbBox02;
        private MetroFramework.Controls.MetroComboBox parSesCmbBox01;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroComboBox parSesDayCmb;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton addParBtn;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTabPage shouldNotOverlap;
        private MetroFramework.Controls.MetroTextBox consecSearchBox;
        private MetroFramework.Controls.MetroComboBox parSesTimeSlotCmbEnd;
        private MetroFramework.Controls.MetroComboBox parSesTimeSlotCmbStart;
        private MetroFramework.Controls.MetroComboBox notOverlapSesTimeSlotCmbBoxEnd;
        private MetroFramework.Controls.MetroComboBox notOverlapSesTimeSlotCmbBoxStart;
        private MetroFramework.Controls.MetroComboBox notOverlapSesDurationCmbBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox notOverlapSesCmbBox02;
        private MetroFramework.Controls.MetroComboBox notOverlapSesCmbBox01;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox notOverlapSesDayCmbBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton addNotOverlapSesBtn;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sessions01;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sessions2;
    }
}