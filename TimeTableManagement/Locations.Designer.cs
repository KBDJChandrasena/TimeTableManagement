
namespace TimeTableManagement
{
    partial class Locations
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.clearBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.roomTypeCB = new System.Windows.Forms.ComboBox();
            this.capacityTxt = new System.Windows.Forms.TextBox();
            this.roomTxt = new System.Windows.Forms.TextBox();
            this.buildingTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.clearBtnUpdate = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.roomTypeCBUpdate = new System.Windows.Forms.ComboBox();
            this.capacityTxtUpdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.roomTxtUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buildingTxtUpdate = new System.Windows.Forms.TextBox();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchCB = new System.Windows.Forms.ComboBox();
            this.table = new System.Windows.Forms.DataGridView();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Location = new System.Drawing.Point(164, 91);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1105, 610);
            this.tabControl1.TabIndex = 4;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.clearBtn);
            this.tab1.Controls.Add(this.saveBtn);
            this.tab1.Controls.Add(this.roomTypeCB);
            this.tab1.Controls.Add(this.capacityTxt);
            this.tab1.Controls.Add(this.roomTxt);
            this.tab1.Controls.Add(this.buildingTxt);
            this.tab1.Controls.Add(this.label5);
            this.tab1.Controls.Add(this.label4);
            this.tab1.Controls.Add(this.label3);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Location = new System.Drawing.Point(4, 25);
            this.tab1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab1.Size = new System.Drawing.Size(1097, 581);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Add Location";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(808, 189);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(167, 23);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(808, 114);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(167, 23);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Add Location";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // roomTypeCB
            // 
            this.roomTypeCB.FormattingEnabled = true;
            this.roomTypeCB.Items.AddRange(new object[] {
            "Level 1",
            "Level 2",
            "Level 3"});
            this.roomTypeCB.Location = new System.Drawing.Point(205, 190);
            this.roomTypeCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomTypeCB.Name = "roomTypeCB";
            this.roomTypeCB.Size = new System.Drawing.Size(458, 24);
            this.roomTypeCB.TabIndex = 7;
            this.roomTypeCB.Text = "Level 1";
            // 
            // capacityTxt
            // 
            this.capacityTxt.Location = new System.Drawing.Point(205, 254);
            this.capacityTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.capacityTxt.Name = "capacityTxt";
            this.capacityTxt.Size = new System.Drawing.Size(458, 22);
            this.capacityTxt.TabIndex = 6;
            // 
            // roomTxt
            // 
            this.roomTxt.Location = new System.Drawing.Point(205, 114);
            this.roomTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomTxt.Name = "roomTxt";
            this.roomTxt.Size = new System.Drawing.Size(458, 22);
            this.roomTxt.TabIndex = 5;
            // 
            // buildingTxt
            // 
            this.buildingTxt.Location = new System.Drawing.Point(205, 42);
            this.buildingTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buildingTxt.Name = "buildingTxt";
            this.buildingTxt.Size = new System.Drawing.Size(458, 22);
            this.buildingTxt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Room Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Capacity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Building";
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.clearBtnUpdate);
            this.tab2.Controls.Add(this.deleteBtn);
            this.tab2.Controls.Add(this.updateBtn);
            this.tab2.Controls.Add(this.label9);
            this.tab2.Controls.Add(this.roomTypeCBUpdate);
            this.tab2.Controls.Add(this.capacityTxtUpdate);
            this.tab2.Controls.Add(this.label8);
            this.tab2.Controls.Add(this.label7);
            this.tab2.Controls.Add(this.roomTxtUpdate);
            this.tab2.Controls.Add(this.label6);
            this.tab2.Controls.Add(this.buildingTxtUpdate);
            this.tab2.Controls.Add(this.searchTxt);
            this.tab2.Controls.Add(this.searchCB);
            this.tab2.Controls.Add(this.table);
            this.tab2.Location = new System.Drawing.Point(4, 25);
            this.tab2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab2.Size = new System.Drawing.Size(1097, 581);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "View Location";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // clearBtnUpdate
            // 
            this.clearBtnUpdate.Location = new System.Drawing.Point(710, 302);
            this.clearBtnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtnUpdate.Name = "clearBtnUpdate";
            this.clearBtnUpdate.Size = new System.Drawing.Size(349, 23);
            this.clearBtnUpdate.TabIndex = 13;
            this.clearBtnUpdate.Text = "Clear";
            this.clearBtnUpdate.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(912, 252);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(147, 24);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(710, 252);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(145, 24);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(710, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Room Type";
            // 
            // roomTypeCBUpdate
            // 
            this.roomTypeCBUpdate.FormattingEnabled = true;
            this.roomTypeCBUpdate.Location = new System.Drawing.Point(825, 146);
            this.roomTypeCBUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomTypeCBUpdate.Name = "roomTypeCBUpdate";
            this.roomTypeCBUpdate.Size = new System.Drawing.Size(234, 24);
            this.roomTypeCBUpdate.TabIndex = 9;
            this.roomTypeCBUpdate.Text = "Level 1";
            // 
            // capacityTxtUpdate
            // 
            this.capacityTxtUpdate.Location = new System.Drawing.Point(825, 194);
            this.capacityTxtUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.capacityTxtUpdate.Name = "capacityTxtUpdate";
            this.capacityTxtUpdate.Size = new System.Drawing.Size(234, 22);
            this.capacityTxtUpdate.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(710, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Capacity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(710, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Room";
            // 
            // roomTxtUpdate
            // 
            this.roomTxtUpdate.Location = new System.Drawing.Point(825, 98);
            this.roomTxtUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomTxtUpdate.Name = "roomTxtUpdate";
            this.roomTxtUpdate.Size = new System.Drawing.Size(234, 22);
            this.roomTxtUpdate.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(710, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Building";
            // 
            // buildingTxtUpdate
            // 
            this.buildingTxtUpdate.Location = new System.Drawing.Point(825, 43);
            this.buildingTxtUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buildingTxtUpdate.Name = "buildingTxtUpdate";
            this.buildingTxtUpdate.Size = new System.Drawing.Size(234, 22);
            this.buildingTxtUpdate.TabIndex = 3;
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(214, 14);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(174, 22);
            this.searchTxt.TabIndex = 2;
            // 
            // searchCB
            // 
            this.searchCB.FormattingEnabled = true;
            this.searchCB.Items.AddRange(new object[] {
            "id",
            "building",
            "room",
            "room_type",
            "capacity"});
            this.searchCB.Location = new System.Drawing.Point(14, 14);
            this.searchCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchCB.Name = "searchCB";
            this.searchCB.Size = new System.Drawing.Size(175, 24);
            this.searchCB.TabIndex = 1;
            this.searchCB.Text = "id";
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(14, 43);
            this.table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 29;
            this.table.Size = new System.Drawing.Size(674, 282);
            this.table.TabIndex = 0;
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
            this.table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellContentClick);
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
            this.metroButton1.TabIndex = 119;
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
            this.label1.Size = new System.Drawing.Size(141, 36);
            this.label1.TabIndex = 118;
            this.label1.Text = " Location";
            // 
            // Locations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TimeTableManagement.Properties.Resources.Background;
            this.BackImage = global::TimeTableManagement.Properties.Resources.Background;
            this.BackMaxSize = 960;
            this.ClientSize = new System.Drawing.Size(1280, 738);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Locations";
            this.Text = "Locations";
            this.Load += new System.EventHandler(this.Locations_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox roomTypeCB;
        private System.Windows.Forms.TextBox capacityTxt;
        private System.Windows.Forms.TextBox roomTxt;
        private System.Windows.Forms.TextBox buildingTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Button clearBtnUpdate;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox roomTypeCBUpdate;
        private System.Windows.Forms.TextBox capacityTxtUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox roomTxtUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox buildingTxtUpdate;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.ComboBox searchCB;
        private System.Windows.Forms.DataGridView table;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label label1;
    }
}