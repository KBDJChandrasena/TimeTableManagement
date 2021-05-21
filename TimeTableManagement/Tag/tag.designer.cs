
namespace TimetableManagementSystem.Tag
{
    partial class Tag
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlSession = new MetroFramework.Controls.MetroTabControl();
            this.consecutiveSessions = new MetroFramework.Controls.MetroTabPage();
            this.tagNameTxt = new MetroFramework.Controls.MetroTextBox();
            this.tagNameDltBtn = new MetroFramework.Controls.MetroButton();
            this.tagNameEditBtn = new MetroFramework.Controls.MetroButton();
            this.tagNameSearchBox = new MetroFramework.Controls.MetroTextBox();
            this.tagNameClrBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tagNameData = new MetroFramework.Controls.MetroGrid();
            this.tagNameAddBtn = new MetroFramework.Controls.MetroButton();
            this.tagNameSrtDrpDwn = new MetroFramework.Controls.MetroComboBox();
            this.tabControlSession.SuspendLayout();
            this.consecutiveSessions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagNameData)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.White;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.ForeColor = System.Drawing.Color.Black;
            this.metroButton1.Location = new System.Drawing.Point(331, 27);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(115, 41);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 117;
            this.metroButton1.Text = "Home";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 36);
            this.label1.TabIndex = 116;
            this.label1.Text = "   Add Tag";
            // 
            // tabControlSession
            // 
            this.tabControlSession.Controls.Add(this.consecutiveSessions);
            this.tabControlSession.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.tabControlSession.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.tabControlSession.Location = new System.Drawing.Point(82, 91);
            this.tabControlSession.Name = "tabControlSession";
            this.tabControlSession.SelectedIndex = 0;
            this.tabControlSession.Size = new System.Drawing.Size(1105, 610);
            this.tabControlSession.Style = MetroFramework.MetroColorStyle.Blue;
            this.tabControlSession.TabIndex = 119;
            this.tabControlSession.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabControlSession.UseCustomBackColor = true;
            this.tabControlSession.UseCustomForeColor = true;
            this.tabControlSession.UseSelectable = true;
            // 
            // consecutiveSessions
            // 
            this.consecutiveSessions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consecutiveSessions.Controls.Add(this.tagNameTxt);
            this.consecutiveSessions.Controls.Add(this.tagNameDltBtn);
            this.consecutiveSessions.Controls.Add(this.tagNameEditBtn);
            this.consecutiveSessions.Controls.Add(this.tagNameSearchBox);
            this.consecutiveSessions.Controls.Add(this.tagNameClrBtn);
            this.consecutiveSessions.Controls.Add(this.metroLabel3);
            this.consecutiveSessions.Controls.Add(this.tagNameData);
            this.consecutiveSessions.Controls.Add(this.tagNameAddBtn);
            this.consecutiveSessions.Controls.Add(this.tagNameSrtDrpDwn);
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
            // 
            // tagNameTxt
            // 
            // 
            // 
            // 
            this.tagNameTxt.CustomButton.Image = null;
            this.tagNameTxt.CustomButton.Location = new System.Drawing.Point(254, 1);
            this.tagNameTxt.CustomButton.Name = "";
            this.tagNameTxt.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.tagNameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tagNameTxt.CustomButton.TabIndex = 1;
            this.tagNameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tagNameTxt.CustomButton.UseSelectable = true;
            this.tagNameTxt.CustomButton.Visible = false;
            this.tagNameTxt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tagNameTxt.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.tagNameTxt.Lines = new string[0];
            this.tagNameTxt.Location = new System.Drawing.Point(146, 248);
            this.tagNameTxt.MaxLength = 32767;
            this.tagNameTxt.Name = "tagNameTxt";
            this.tagNameTxt.PasswordChar = '\0';
            this.tagNameTxt.PromptText = "Type Tag Name";
            this.tagNameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tagNameTxt.SelectedText = "";
            this.tagNameTxt.SelectionLength = 0;
            this.tagNameTxt.SelectionStart = 0;
            this.tagNameTxt.ShortcutsEnabled = true;
            this.tagNameTxt.Size = new System.Drawing.Size(286, 33);
            this.tagNameTxt.TabIndex = 140;
            this.tagNameTxt.UseSelectable = true;
            this.tagNameTxt.WaterMark = "Type Tag Name";
            this.tagNameTxt.WaterMarkColor = System.Drawing.Color.DimGray;
            this.tagNameTxt.WaterMarkFont = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tagNameDltBtn
            // 
            this.tagNameDltBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.tagNameDltBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.tagNameDltBtn.Highlight = true;
            this.tagNameDltBtn.Location = new System.Drawing.Point(843, 500);
            this.tagNameDltBtn.Name = "tagNameDltBtn";
            this.tagNameDltBtn.Size = new System.Drawing.Size(168, 31);
            this.tagNameDltBtn.Style = MetroFramework.MetroColorStyle.Teal;
            this.tagNameDltBtn.TabIndex = 139;
            this.tagNameDltBtn.Text = "Delete";
            this.tagNameDltBtn.UseCustomBackColor = true;
            this.tagNameDltBtn.UseSelectable = true;
            this.tagNameDltBtn.Click += new System.EventHandler(this.tagNameDltBtn_Click);
            // 
            // tagNameEditBtn
            // 
            this.tagNameEditBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.tagNameEditBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.tagNameEditBtn.Highlight = true;
            this.tagNameEditBtn.Location = new System.Drawing.Point(536, 500);
            this.tagNameEditBtn.Name = "tagNameEditBtn";
            this.tagNameEditBtn.Size = new System.Drawing.Size(168, 31);
            this.tagNameEditBtn.Style = MetroFramework.MetroColorStyle.Teal;
            this.tagNameEditBtn.TabIndex = 138;
            this.tagNameEditBtn.Text = "Edit Tag";
            this.tagNameEditBtn.UseCustomBackColor = true;
            this.tagNameEditBtn.UseSelectable = true;
            this.tagNameEditBtn.Click += new System.EventHandler(this.tagNameEditBtn_Click);
            // 
            // tagNameSearchBox
            // 
            // 
            // 
            // 
            this.tagNameSearchBox.CustomButton.Image = null;
            this.tagNameSearchBox.CustomButton.Location = new System.Drawing.Point(188, 2);
            this.tagNameSearchBox.CustomButton.Name = "";
            this.tagNameSearchBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tagNameSearchBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tagNameSearchBox.CustomButton.TabIndex = 1;
            this.tagNameSearchBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tagNameSearchBox.CustomButton.UseSelectable = true;
            this.tagNameSearchBox.CustomButton.Visible = false;
            this.tagNameSearchBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tagNameSearchBox.Lines = new string[0];
            this.tagNameSearchBox.Location = new System.Drawing.Point(809, 97);
            this.tagNameSearchBox.MaxLength = 32767;
            this.tagNameSearchBox.Name = "tagNameSearchBox";
            this.tagNameSearchBox.PasswordChar = '\0';
            this.tagNameSearchBox.PromptText = "Search";
            this.tagNameSearchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tagNameSearchBox.SelectedText = "";
            this.tagNameSearchBox.SelectionLength = 0;
            this.tagNameSearchBox.SelectionStart = 0;
            this.tagNameSearchBox.ShortcutsEnabled = true;
            this.tagNameSearchBox.Size = new System.Drawing.Size(216, 30);
            this.tagNameSearchBox.TabIndex = 137;
            this.tagNameSearchBox.UseSelectable = true;
            this.tagNameSearchBox.WaterMark = "Search";
            this.tagNameSearchBox.WaterMarkColor = System.Drawing.Color.DimGray;
            this.tagNameSearchBox.WaterMarkFont = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagNameSearchBox.TextChanged += new System.EventHandler(this.tagNameSearchBox_TextChanged);
            this.tagNameSearchBox.Click += new System.EventHandler(this.tagNameSearchBox_Click);
            // 
            // tagNameClrBtn
            // 
            this.tagNameClrBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.tagNameClrBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.tagNameClrBtn.Highlight = true;
            this.tagNameClrBtn.Location = new System.Drawing.Point(146, 394);
            this.tagNameClrBtn.Name = "tagNameClrBtn";
            this.tagNameClrBtn.Size = new System.Drawing.Size(286, 41);
            this.tagNameClrBtn.Style = MetroFramework.MetroColorStyle.Teal;
            this.tagNameClrBtn.TabIndex = 135;
            this.tagNameClrBtn.Text = "Clear";
            this.tagNameClrBtn.UseCustomBackColor = true;
            this.tagNameClrBtn.UseSelectable = true;
            this.tagNameClrBtn.Click += new System.EventHandler(this.tagNameClrBtn_Click);
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
            // tagNameData
            // 
            this.tagNameData.AllowUserToResizeRows = false;
            this.tagNameData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tagNameData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tagNameData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tagNameData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tagNameData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tagNameData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tagNameData.DefaultCellStyle = dataGridViewCellStyle2;
            this.tagNameData.EnableHeadersVisualStyles = false;
            this.tagNameData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tagNameData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tagNameData.Location = new System.Drawing.Point(571, 168);
            this.tagNameData.Name = "tagNameData";
            this.tagNameData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tagNameData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tagNameData.RowHeadersVisible = false;
            this.tagNameData.RowHeadersWidth = 51;
            this.tagNameData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tagNameData.RowTemplate.Height = 24;
            this.tagNameData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tagNameData.Size = new System.Drawing.Size(440, 298);
            this.tagNameData.TabIndex = 95;
            this.tagNameData.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tagNameData_RowHeaderMouseClick);
            // 
            // tagNameAddBtn
            // 
            this.tagNameAddBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.tagNameAddBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.tagNameAddBtn.Highlight = true;
            this.tagNameAddBtn.Location = new System.Drawing.Point(146, 322);
            this.tagNameAddBtn.Name = "tagNameAddBtn";
            this.tagNameAddBtn.Size = new System.Drawing.Size(286, 41);
            this.tagNameAddBtn.Style = MetroFramework.MetroColorStyle.Teal;
            this.tagNameAddBtn.TabIndex = 84;
            this.tagNameAddBtn.Text = "Add Tag";
            this.tagNameAddBtn.UseCustomBackColor = true;
            this.tagNameAddBtn.UseSelectable = true;
            this.tagNameAddBtn.Click += new System.EventHandler(this.tagNameAddBtn_Click);
            // 
            // tagNameSrtDrpDwn
            // 
            this.tagNameSrtDrpDwn.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.tagNameSrtDrpDwn.FormattingEnabled = true;
            this.tagNameSrtDrpDwn.ItemHeight = 24;
            this.tagNameSrtDrpDwn.Items.AddRange(new object[] {
            "Tag Name",
            "ID"});
            this.tagNameSrtDrpDwn.Location = new System.Drawing.Point(546, 97);
            this.tagNameSrtDrpDwn.Name = "tagNameSrtDrpDwn";
            this.tagNameSrtDrpDwn.PromptText = "Select Tag";
            this.tagNameSrtDrpDwn.Size = new System.Drawing.Size(218, 30);
            this.tagNameSrtDrpDwn.Style = MetroFramework.MetroColorStyle.Blue;
            this.tagNameSrtDrpDwn.TabIndex = 78;
            this.tagNameSrtDrpDwn.UseSelectable = true;
            // 
            // Tag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::TimetableManagementSystem.Properties.Resources.Background;
            this.BackMaxSize = 960;
            this.ClientSize = new System.Drawing.Size(1280, 738);
            this.Controls.Add(this.tabControlSession);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label1);
            this.Name = "Tag";
            this.Load += new System.EventHandler(this.Tag_Load);
            this.tabControlSession.ResumeLayout(false);
            this.consecutiveSessions.ResumeLayout(false);
            this.consecutiveSessions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagNameData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabControl tabControlSession;
        private MetroFramework.Controls.MetroTabPage consecutiveSessions;
        private MetroFramework.Controls.MetroTextBox tagNameSearchBox;
        private MetroFramework.Controls.MetroButton tagNameClrBtn;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroGrid tagNameData;
        private MetroFramework.Controls.MetroButton tagNameAddBtn;
        private MetroFramework.Controls.MetroComboBox tagNameSrtDrpDwn;
        private MetroFramework.Controls.MetroButton tagNameDltBtn;
        private MetroFramework.Controls.MetroButton tagNameEditBtn;
        private MetroFramework.Controls.MetroTextBox tagNameTxt;
    }
}