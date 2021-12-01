namespace 기말_Project
{
    partial class Student_Main_출석체크_내역
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbStdChec = new System.Windows.Forms.GroupBox();
            this.StdCheckList = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtAt = new System.Windows.Forms.TextBox();
            this.lbAt1 = new System.Windows.Forms.Label();
            this.lbAt2 = new System.Windows.Forms.Label();
            this.lbLate2 = new System.Windows.Forms.Label();
            this.txtLate = new System.Windows.Forms.TextBox();
            this.lbLate1 = new System.Windows.Forms.Label();
            this.lbAb2 = new System.Windows.Forms.Label();
            this.txtAb = new System.Windows.Forms.TextBox();
            this.lbAb1 = new System.Windows.Forms.Label();
            this.StdClass = new System.Windows.Forms.GroupBox();
            this.StdClassList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.gbStdChec.SuspendLayout();
            this.StdClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.gbStdChec);
            this.panel1.Controls.Add(this.StdClass);
            this.panel1.Font = new System.Drawing.Font("휴먼매직체", 11F);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 382);
            this.panel1.TabIndex = 1;
            // 
            // gbStdChec
            // 
            this.gbStdChec.Controls.Add(this.StdCheckList);
            this.gbStdChec.Controls.Add(this.txtAt);
            this.gbStdChec.Controls.Add(this.lbAt1);
            this.gbStdChec.Controls.Add(this.lbAt2);
            this.gbStdChec.Controls.Add(this.lbLate2);
            this.gbStdChec.Controls.Add(this.txtLate);
            this.gbStdChec.Controls.Add(this.lbLate1);
            this.gbStdChec.Controls.Add(this.lbAb2);
            this.gbStdChec.Controls.Add(this.txtAb);
            this.gbStdChec.Controls.Add(this.lbAb1);
            this.gbStdChec.Location = new System.Drawing.Point(441, 2);
            this.gbStdChec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbStdChec.Name = "gbStdChec";
            this.gbStdChec.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbStdChec.Size = new System.Drawing.Size(284, 373);
            this.gbStdChec.TabIndex = 0;
            this.gbStdChec.TabStop = false;
            this.gbStdChec.Text = "출결정보";
            // 
            // StdCheckList
            // 
            this.StdCheckList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.StdCheckList.Location = new System.Drawing.Point(10, 16);
            this.StdCheckList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StdCheckList.Name = "StdCheckList";
            this.StdCheckList.Size = new System.Drawing.Size(264, 268);
            this.StdCheckList.TabIndex = 7;
            this.StdCheckList.UseCompatibleStateImageBehavior = false;
            this.StdCheckList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "기록일자";
            this.columnHeader7.Width = 190;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "출석정보";
            this.columnHeader8.Width = 70;
            // 
            // txtAt
            // 
            this.txtAt.Location = new System.Drawing.Point(102, 290);
            this.txtAt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAt.Name = "txtAt";
            this.txtAt.ReadOnly = true;
            this.txtAt.Size = new System.Drawing.Size(97, 24);
            this.txtAt.TabIndex = 9;
            // 
            // lbAt1
            // 
            this.lbAt1.AutoSize = true;
            this.lbAt1.Location = new System.Drawing.Point(56, 293);
            this.lbAt1.Name = "lbAt1";
            this.lbAt1.Size = new System.Drawing.Size(39, 15);
            this.lbAt1.TabIndex = 6;
            this.lbAt1.Text = "출석 :";
            // 
            // lbAt2
            // 
            this.lbAt2.AutoSize = true;
            this.lbAt2.Location = new System.Drawing.Point(205, 293);
            this.lbAt2.Name = "lbAt2";
            this.lbAt2.Size = new System.Drawing.Size(19, 15);
            this.lbAt2.TabIndex = 12;
            this.lbAt2.Text = "번";
            // 
            // lbLate2
            // 
            this.lbLate2.AutoSize = true;
            this.lbLate2.Location = new System.Drawing.Point(205, 320);
            this.lbLate2.Name = "lbLate2";
            this.lbLate2.Size = new System.Drawing.Size(19, 15);
            this.lbLate2.TabIndex = 10;
            this.lbLate2.Text = "번";
            // 
            // txtLate
            // 
            this.txtLate.Location = new System.Drawing.Point(102, 318);
            this.txtLate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLate.Name = "txtLate";
            this.txtLate.ReadOnly = true;
            this.txtLate.Size = new System.Drawing.Size(97, 24);
            this.txtLate.TabIndex = 7;
            // 
            // lbLate1
            // 
            this.lbLate1.AutoSize = true;
            this.lbLate1.Location = new System.Drawing.Point(56, 320);
            this.lbLate1.Name = "lbLate1";
            this.lbLate1.Size = new System.Drawing.Size(42, 15);
            this.lbLate1.TabIndex = 4;
            this.lbLate1.Text = "지각 :";
            // 
            // lbAb2
            // 
            this.lbAb2.AutoSize = true;
            this.lbAb2.Location = new System.Drawing.Point(205, 348);
            this.lbAb2.Name = "lbAb2";
            this.lbAb2.Size = new System.Drawing.Size(19, 15);
            this.lbAb2.TabIndex = 11;
            this.lbAb2.Text = "번";
            // 
            // txtAb
            // 
            this.txtAb.Location = new System.Drawing.Point(102, 345);
            this.txtAb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAb.Name = "txtAb";
            this.txtAb.ReadOnly = true;
            this.txtAb.Size = new System.Drawing.Size(97, 24);
            this.txtAb.TabIndex = 8;
            // 
            // lbAb1
            // 
            this.lbAb1.AutoSize = true;
            this.lbAb1.Location = new System.Drawing.Point(56, 348);
            this.lbAb1.Name = "lbAb1";
            this.lbAb1.Size = new System.Drawing.Size(41, 15);
            this.lbAb1.TabIndex = 5;
            this.lbAb1.Text = "결석 :";
            // 
            // StdClass
            // 
            this.StdClass.Controls.Add(this.StdClassList);
            this.StdClass.Location = new System.Drawing.Point(3, 2);
            this.StdClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StdClass.Name = "StdClass";
            this.StdClass.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StdClass.Size = new System.Drawing.Size(432, 373);
            this.StdClass.TabIndex = 0;
            this.StdClass.TabStop = false;
            this.StdClass.Text = "수업 목록";
            // 
            // StdClassList
            // 
            this.StdClassList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.StdClassList.Location = new System.Drawing.Point(5, 21);
            this.StdClassList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StdClassList.Name = "StdClassList";
            this.StdClassList.Size = new System.Drawing.Size(421, 342);
            this.StdClassList.TabIndex = 7;
            this.StdClassList.UseCompatibleStateImageBehavior = false;
            this.StdClassList.View = System.Windows.Forms.View.Details;
            this.StdClassList.SelectedIndexChanged += new System.EventHandler(this.StdClassList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "과목";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "지도교수";
            this.columnHeader2.Width = 55;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "요일";
            this.columnHeader3.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "시작";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "마침";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "교과구분";
            // 
            // Student_Main_출석체크_내역
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(757, 400);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Student_Main_출석체크_내역";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Main_출석체크_내역";
            this.Load += new System.EventHandler(this.Student_Main_출석체크_내역_Load);
            this.panel1.ResumeLayout(false);
            this.gbStdChec.ResumeLayout(false);
            this.gbStdChec.PerformLayout();
            this.StdClass.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbStdChec;
        private System.Windows.Forms.Label lbLate2;
        private System.Windows.Forms.TextBox txtLate;
        private System.Windows.Forms.Label lbLate1;
        private System.Windows.Forms.Label lbAb2;
        private System.Windows.Forms.TextBox txtAt;
        private System.Windows.Forms.Label lbAt2;
        private System.Windows.Forms.TextBox txtAb;
        private System.Windows.Forms.Label lbAt1;
        private System.Windows.Forms.Label lbAb1;
        private System.Windows.Forms.GroupBox StdClass;
        private System.Windows.Forms.ListView StdCheckList;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView StdClassList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}