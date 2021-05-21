
namespace TimeTableManagement
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.LecStat_tabpage = new System.Windows.Forms.TabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.total_lecturers = new MetroFramework.Controls.MetroTextBox();
            this.lbldept = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.StuGStat_tabpage = new System.Windows.Forms.TabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.stdgrpcount_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SubStat_tabpage = new System.Windows.Forms.TabPage();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.subject_count_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroButton9 = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.faclec_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.deptLec_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progrpcount_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.subyear_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroTabControl1.SuspendLayout();
            this.LecStat_tabpage.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.StuGStat_tabpage.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SubStat_tabpage.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faclec_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptLec_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progrpcount_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subyear_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Statistics";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.White;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(273, 26);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(115, 41);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 123;
            this.metroButton1.Text = "Home";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.LecStat_tabpage);
            this.metroTabControl1.Controls.Add(this.StuGStat_tabpage);
            this.metroTabControl1.Controls.Add(this.SubStat_tabpage);
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.metroTabControl1.Location = new System.Drawing.Point(164, 91);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(1051, 567);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl1.TabIndex = 124;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTabControl1.UseCustomBackColor = true;
            this.metroTabControl1.UseCustomForeColor = true;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // LecStat_tabpage
            // 
            this.LecStat_tabpage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LecStat_tabpage.Controls.Add(this.metroPanel1);
            this.LecStat_tabpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecStat_tabpage.Location = new System.Drawing.Point(4, 37);
            this.LecStat_tabpage.Margin = new System.Windows.Forms.Padding(9);
            this.LecStat_tabpage.Name = "LecStat_tabpage";
            this.LecStat_tabpage.Padding = new System.Windows.Forms.Padding(4);
            this.LecStat_tabpage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LecStat_tabpage.Size = new System.Drawing.Size(1043, 526);
            this.LecStat_tabpage.TabIndex = 0;
            this.LecStat_tabpage.Text = "Lecturers";
            this.LecStat_tabpage.UseVisualStyleBackColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Lavender;
            this.metroPanel1.Controls.Add(this.metroPanel4);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(1, 0);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1036, 518);
            this.metroPanel1.TabIndex = 16;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.deptLec_chart);
            this.metroPanel4.Controls.Add(this.faclec_chart);
            this.metroPanel4.Controls.Add(this.total_lecturers);
            this.metroPanel4.Controls.Add(this.lbldept);
            this.metroPanel4.Controls.Add(this.metroButton2);
            this.metroPanel4.Controls.Add(this.metroLabel11);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 12;
            this.metroPanel4.Location = new System.Drawing.Point(-3, -1);
            this.metroPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(1037, 516);
            this.metroPanel4.TabIndex = 3;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 13;
            // 
            // total_lecturers
            // 
            // 
            // 
            // 
            this.total_lecturers.CustomButton.Image = null;
            this.total_lecturers.CustomButton.Location = new System.Drawing.Point(47, 1);
            this.total_lecturers.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.total_lecturers.CustomButton.Name = "";
            this.total_lecturers.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.total_lecturers.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.total_lecturers.CustomButton.TabIndex = 1;
            this.total_lecturers.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.total_lecturers.CustomButton.UseSelectable = true;
            this.total_lecturers.CustomButton.Visible = false;
            this.total_lecturers.Lines = new string[0];
            this.total_lecturers.Location = new System.Drawing.Point(541, 30);
            this.total_lecturers.Margin = new System.Windows.Forms.Padding(4);
            this.total_lecturers.MaxLength = 32767;
            this.total_lecturers.Name = "total_lecturers";
            this.total_lecturers.PasswordChar = '\0';
            this.total_lecturers.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.total_lecturers.SelectedText = "";
            this.total_lecturers.SelectionLength = 0;
            this.total_lecturers.SelectionStart = 0;
            this.total_lecturers.ShortcutsEnabled = true;
            this.total_lecturers.Size = new System.Drawing.Size(79, 33);
            this.total_lecturers.TabIndex = 44;
            this.total_lecturers.UseSelectable = true;
            this.total_lecturers.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.total_lecturers.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbldept
            // 
            this.lbldept.AutoSize = true;
            this.lbldept.BackColor = System.Drawing.Color.Transparent;
            this.lbldept.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbldept.Location = new System.Drawing.Point(595, 98);
            this.lbldept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldept.Name = "lbldept";
            this.lbldept.Size = new System.Drawing.Size(221, 20);
            this.lbldept.TabIndex = 42;
            this.lbldept.Text = "Department vs Lecturer Count";
            this.lbldept.UseCustomBackColor = true;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.Navy;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.ForeColor = System.Drawing.SystemColors.Control;
            this.metroButton2.Location = new System.Drawing.Point(339, 26);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(196, 37);
            this.metroButton2.TabIndex = 39;
            this.metroButton2.Text = "Total Lecturer Count";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(43, 98);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(186, 20);
            this.metroLabel11.TabIndex = 30;
            this.metroLabel11.Text = "Faculty vs Lecturer Count";
            this.metroLabel11.UseCustomBackColor = true;
            // 
            // StuGStat_tabpage
            // 
            this.StuGStat_tabpage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StuGStat_tabpage.Controls.Add(this.metroPanel2);
            this.StuGStat_tabpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuGStat_tabpage.Location = new System.Drawing.Point(4, 37);
            this.StuGStat_tabpage.Margin = new System.Windows.Forms.Padding(4);
            this.StuGStat_tabpage.Name = "StuGStat_tabpage";
            this.StuGStat_tabpage.Size = new System.Drawing.Size(1043, 526);
            this.StuGStat_tabpage.TabIndex = 1;
            this.StuGStat_tabpage.Text = "Student Groups";
            this.StuGStat_tabpage.UseVisualStyleBackColor = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.progrpcount_chart);
            this.metroPanel2.Controls.Add(this.stdgrpcount_txt);
            this.metroPanel2.Controls.Add(this.metroButton6);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 12;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1037, 516);
            this.metroPanel2.TabIndex = 4;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 13;
            // 
            // stdgrpcount_txt
            // 
            // 
            // 
            // 
            this.stdgrpcount_txt.CustomButton.Image = null;
            this.stdgrpcount_txt.CustomButton.Location = new System.Drawing.Point(50, 1);
            this.stdgrpcount_txt.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.stdgrpcount_txt.CustomButton.Name = "";
            this.stdgrpcount_txt.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.stdgrpcount_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.stdgrpcount_txt.CustomButton.TabIndex = 1;
            this.stdgrpcount_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.stdgrpcount_txt.CustomButton.UseSelectable = true;
            this.stdgrpcount_txt.CustomButton.Visible = false;
            this.stdgrpcount_txt.Lines = new string[0];
            this.stdgrpcount_txt.Location = new System.Drawing.Point(545, 31);
            this.stdgrpcount_txt.Margin = new System.Windows.Forms.Padding(4);
            this.stdgrpcount_txt.MaxLength = 32767;
            this.stdgrpcount_txt.Name = "stdgrpcount_txt";
            this.stdgrpcount_txt.PasswordChar = '\0';
            this.stdgrpcount_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.stdgrpcount_txt.SelectedText = "";
            this.stdgrpcount_txt.SelectionLength = 0;
            this.stdgrpcount_txt.SelectionStart = 0;
            this.stdgrpcount_txt.ShortcutsEnabled = true;
            this.stdgrpcount_txt.Size = new System.Drawing.Size(80, 31);
            this.stdgrpcount_txt.TabIndex = 42;
            this.stdgrpcount_txt.UseSelectable = true;
            this.stdgrpcount_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.stdgrpcount_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton6
            // 
            this.metroButton6.BackColor = System.Drawing.Color.Navy;
            this.metroButton6.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton6.ForeColor = System.Drawing.SystemColors.Control;
            this.metroButton6.Location = new System.Drawing.Point(275, 26);
            this.metroButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(244, 37);
            this.metroButton6.TabIndex = 39;
            this.metroButton6.Text = "Total Student Group Count";
            this.metroButton6.UseCustomBackColor = true;
            this.metroButton6.UseCustomForeColor = true;
            this.metroButton6.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(307, 100);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(264, 20);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Programme vs Student Group Count";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // SubStat_tabpage
            // 
            this.SubStat_tabpage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubStat_tabpage.Controls.Add(this.metroPanel3);
            this.SubStat_tabpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubStat_tabpage.Location = new System.Drawing.Point(4, 37);
            this.SubStat_tabpage.Margin = new System.Windows.Forms.Padding(4);
            this.SubStat_tabpage.Name = "SubStat_tabpage";
            this.SubStat_tabpage.Size = new System.Drawing.Size(1043, 526);
            this.SubStat_tabpage.TabIndex = 2;
            this.SubStat_tabpage.Text = "Subjects";
            this.SubStat_tabpage.UseVisualStyleBackColor = true;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.subyear_chart);
            this.metroPanel3.Controls.Add(this.subject_count_txt);
            this.metroPanel3.Controls.Add(this.metroButton9);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 12;
            this.metroPanel3.Location = new System.Drawing.Point(0, 0);
            this.metroPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(1037, 516);
            this.metroPanel3.TabIndex = 5;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 13;
            // 
            // subject_count_txt
            // 
            // 
            // 
            // 
            this.subject_count_txt.CustomButton.Image = null;
            this.subject_count_txt.CustomButton.Location = new System.Drawing.Point(47, 1);
            this.subject_count_txt.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.subject_count_txt.CustomButton.Name = "";
            this.subject_count_txt.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.subject_count_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.subject_count_txt.CustomButton.TabIndex = 1;
            this.subject_count_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.subject_count_txt.CustomButton.UseSelectable = true;
            this.subject_count_txt.CustomButton.Visible = false;
            this.subject_count_txt.Lines = new string[0];
            this.subject_count_txt.Location = new System.Drawing.Point(537, 30);
            this.subject_count_txt.Margin = new System.Windows.Forms.Padding(4);
            this.subject_count_txt.MaxLength = 32767;
            this.subject_count_txt.Name = "subject_count_txt";
            this.subject_count_txt.PasswordChar = '\0';
            this.subject_count_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.subject_count_txt.SelectedText = "";
            this.subject_count_txt.SelectionLength = 0;
            this.subject_count_txt.SelectionStart = 0;
            this.subject_count_txt.ShortcutsEnabled = true;
            this.subject_count_txt.Size = new System.Drawing.Size(79, 33);
            this.subject_count_txt.TabIndex = 45;
            this.subject_count_txt.UseSelectable = true;
            this.subject_count_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.subject_count_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton9
            // 
            this.metroButton9.BackColor = System.Drawing.Color.Navy;
            this.metroButton9.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton9.ForeColor = System.Drawing.SystemColors.Control;
            this.metroButton9.Location = new System.Drawing.Point(319, 26);
            this.metroButton9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButton9.Name = "metroButton9";
            this.metroButton9.Size = new System.Drawing.Size(200, 37);
            this.metroButton9.TabIndex = 39;
            this.metroButton9.Text = "Total Subject Count";
            this.metroButton9.UseCustomBackColor = true;
            this.metroButton9.UseCustomForeColor = true;
            this.metroButton9.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(341, 100);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(159, 20);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "Year vs Subject Count";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // faclec_chart
            // 
            chartArea5.Name = "ChartArea1";
            this.faclec_chart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.faclec_chart.Legends.Add(legend5);
            this.faclec_chart.Location = new System.Drawing.Point(43, 148);
            this.faclec_chart.Margin = new System.Windows.Forms.Padding(4);
            this.faclec_chart.Name = "faclec_chart";
            this.faclec_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.faclec_chart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))),
        System.Drawing.Color.Olive,
        System.Drawing.Color.Teal,
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.faclec_chart.Series.Add(series5);
            this.faclec_chart.Size = new System.Drawing.Size(417, 321);
            this.faclec_chart.TabIndex = 2;
            this.faclec_chart.Text = "chart1";
            this.faclec_chart.Click += new System.EventHandler(this.faclec_chart_Click);
            // 
            // deptLec_chart
            // 
            chartArea6.Name = "ChartArea1";
            this.deptLec_chart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.deptLec_chart.Legends.Add(legend6);
            this.deptLec_chart.Location = new System.Drawing.Point(521, 148);
            this.deptLec_chart.Margin = new System.Windows.Forms.Padding(4);
            this.deptLec_chart.Name = "deptLec_chart";
            this.deptLec_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.deptLec_chart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))),
        System.Drawing.Color.Olive,
        System.Drawing.Color.Teal,
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.deptLec_chart.Series.Add(series6);
            this.deptLec_chart.Size = new System.Drawing.Size(449, 321);
            this.deptLec_chart.TabIndex = 41;
            this.deptLec_chart.Text = "chart2";
            // 
            // progrpcount_chart
            // 
            chartArea7.Name = "ChartArea1";
            this.progrpcount_chart.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.progrpcount_chart.Legends.Add(legend7);
            this.progrpcount_chart.Location = new System.Drawing.Point(253, 146);
            this.progrpcount_chart.Margin = new System.Windows.Forms.Padding(4);
            this.progrpcount_chart.Name = "progrpcount_chart";
            this.progrpcount_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.progrpcount_chart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))),
        System.Drawing.Color.Olive,
        System.Drawing.Color.Teal,
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.progrpcount_chart.Series.Add(series7);
            this.progrpcount_chart.Size = new System.Drawing.Size(449, 321);
            this.progrpcount_chart.TabIndex = 2;
            this.progrpcount_chart.Text = "chart1";
            // 
            // subyear_chart
            // 
            chartArea8.Name = "ChartArea1";
            this.subyear_chart.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.subyear_chart.Legends.Add(legend8);
            this.subyear_chart.Location = new System.Drawing.Point(197, 167);
            this.subyear_chart.Margin = new System.Windows.Forms.Padding(4);
            this.subyear_chart.Name = "subyear_chart";
            this.subyear_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.subyear_chart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))),
        System.Drawing.Color.Olive,
        System.Drawing.Color.Teal,
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.subyear_chart.Series.Add(series8);
            this.subyear_chart.Size = new System.Drawing.Size(449, 321);
            this.subyear_chart.TabIndex = 2;
            this.subyear_chart.Text = "chart1";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::TimeTableManagement.Properties.Resources.Background;
            this.BackMaxSize = 960;
            this.ClientSize = new System.Drawing.Size(1262, 691);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label1);
            this.Name = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.LecStat_tabpage.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.StuGStat_tabpage.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.SubStat_tabpage.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faclec_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptLec_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progrpcount_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subyear_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage LecStat_tabpage;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroTextBox total_lecturers;
        private MetroFramework.Controls.MetroLabel lbldept;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.TabPage StuGStat_tabpage;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox stdgrpcount_txt;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TabPage SubStat_tabpage;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroTextBox subject_count_txt;
        private MetroFramework.Controls.MetroButton metroButton9;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart deptLec_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart faclec_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart progrpcount_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart subyear_chart;
    }
}