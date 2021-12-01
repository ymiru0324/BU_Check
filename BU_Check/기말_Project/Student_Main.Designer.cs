namespace 기말_Project
{
    partial class Student_Main
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
            this.pbBcu = new System.Windows.Forms.PictureBox();
            this.gbStdinfo = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtStdNum = new System.Windows.Forms.TextBox();
            this.txtDp = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbClass = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbStdNum = new System.Windows.Forms.Label();
            this.lbDp = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.gbTimetable = new System.Windows.Forms.GroupBox();
            this.TimetableList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.테스트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.출석체크내역ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.성적열람ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBcu)).BeginInit();
            this.gbStdinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbTimetable.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pbBcu);
            this.panel1.Controls.Add(this.gbStdinfo);
            this.panel1.Controls.Add(this.gbTimetable);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 416);
            this.panel1.TabIndex = 1;
            // 
            // pbBcu
            // 
            this.pbBcu.Image = global::기말_Project.Properties.Resources.bcu;
            this.pbBcu.Location = new System.Drawing.Point(83, 256);
            this.pbBcu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBcu.Name = "pbBcu";
            this.pbBcu.Size = new System.Drawing.Size(154, 154);
            this.pbBcu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBcu.TabIndex = 4;
            this.pbBcu.TabStop = false;
            // 
            // gbStdinfo
            // 
            this.gbStdinfo.Controls.Add(this.pictureBox1);
            this.gbStdinfo.Controls.Add(this.txtClass);
            this.gbStdinfo.Controls.Add(this.txtYear);
            this.gbStdinfo.Controls.Add(this.txtStdNum);
            this.gbStdinfo.Controls.Add(this.txtDp);
            this.gbStdinfo.Controls.Add(this.txtName);
            this.gbStdinfo.Controls.Add(this.txtID);
            this.gbStdinfo.Controls.Add(this.lbClass);
            this.gbStdinfo.Controls.Add(this.lbYear);
            this.gbStdinfo.Controls.Add(this.lbStdNum);
            this.gbStdinfo.Controls.Add(this.lbDp);
            this.gbStdinfo.Controls.Add(this.lbName);
            this.gbStdinfo.Controls.Add(this.lbID);
            this.gbStdinfo.Font = new System.Drawing.Font("휴먼매직체", 11F);
            this.gbStdinfo.Location = new System.Drawing.Point(3, 27);
            this.gbStdinfo.Name = "gbStdinfo";
            this.gbStdinfo.Size = new System.Drawing.Size(322, 224);
            this.gbStdinfo.TabIndex = 3;
            this.gbStdinfo.TabStop = false;
            this.gbStdinfo.Text = "학생 정보";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::기말_Project.Properties.Resources.bono;
            this.pictureBox1.Location = new System.Drawing.Point(19, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(210, 185);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(96, 24);
            this.txtClass.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(70, 185);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(84, 24);
            this.txtYear.TabIndex = 1;
            // 
            // txtStdNum
            // 
            this.txtStdNum.Location = new System.Drawing.Point(181, 109);
            this.txtStdNum.Name = "txtStdNum";
            this.txtStdNum.ReadOnly = true;
            this.txtStdNum.Size = new System.Drawing.Size(125, 24);
            this.txtStdNum.TabIndex = 1;
            // 
            // txtDp
            // 
            this.txtDp.Location = new System.Drawing.Point(70, 149);
            this.txtDp.Name = "txtDp";
            this.txtDp.ReadOnly = true;
            this.txtDp.Size = new System.Drawing.Size(236, 24);
            this.txtDp.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(181, 72);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(125, 24);
            this.txtName.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(181, 35);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(125, 24);
            this.txtID.TabIndex = 1;
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Font = new System.Drawing.Font("휴먼매직체", 11F);
            this.lbClass.Location = new System.Drawing.Point(174, 188);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(30, 15);
            this.lbClass.TabIndex = 0;
            this.lbClass.Text = "반 :";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Font = new System.Drawing.Font("휴먼매직체", 11F);
            this.lbYear.Location = new System.Drawing.Point(17, 188);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(42, 15);
            this.lbYear.TabIndex = 0;
            this.lbYear.Text = "학년 :";
            // 
            // lbStdNum
            // 
            this.lbStdNum.AutoSize = true;
            this.lbStdNum.Font = new System.Drawing.Font("휴먼매직체", 11F);
            this.lbStdNum.Location = new System.Drawing.Point(129, 111);
            this.lbStdNum.Name = "lbStdNum";
            this.lbStdNum.Size = new System.Drawing.Size(42, 15);
            this.lbStdNum.TabIndex = 0;
            this.lbStdNum.Text = "학번 :";
            // 
            // lbDp
            // 
            this.lbDp.AutoSize = true;
            this.lbDp.Font = new System.Drawing.Font("휴먼매직체", 11F);
            this.lbDp.Location = new System.Drawing.Point(16, 151);
            this.lbDp.Name = "lbDp";
            this.lbDp.Size = new System.Drawing.Size(43, 15);
            this.lbDp.TabIndex = 0;
            this.lbDp.Text = "학과 :";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("휴먼매직체", 11F);
            this.lbName.Location = new System.Drawing.Point(132, 74);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(39, 15);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "이름 :";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("휴먼매직체", 11F);
            this.lbID.Location = new System.Drawing.Point(142, 38);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(31, 15);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID :";
            // 
            // gbTimetable
            // 
            this.gbTimetable.Controls.Add(this.TimetableList);
            this.gbTimetable.Font = new System.Drawing.Font("휴먼매직체", 11F);
            this.gbTimetable.Location = new System.Drawing.Point(331, 26);
            this.gbTimetable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTimetable.Name = "gbTimetable";
            this.gbTimetable.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTimetable.Size = new System.Drawing.Size(500, 385);
            this.gbTimetable.TabIndex = 2;
            this.gbTimetable.TabStop = false;
            this.gbTimetable.Text = "시간표";
            // 
            // TimetableList
            // 
            this.TimetableList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader8,
            this.columnHeader9});
            this.TimetableList.Location = new System.Drawing.Point(5, 22);
            this.TimetableList.Name = "TimetableList";
            this.TimetableList.Size = new System.Drawing.Size(489, 357);
            this.TimetableList.TabIndex = 0;
            this.TimetableList.UseCompatibleStateImageBehavior = false;
            this.TimetableList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "과목";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "교수님";
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
            // columnHeader8
            // 
            this.columnHeader8.Text = "강의실";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "교과구분";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.테스트ToolStripMenuItem,
            this.출석체크내역ToolStripMenuItem,
            this.성적열람ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 테스트ToolStripMenuItem
            // 
            this.테스트ToolStripMenuItem.Font = new System.Drawing.Font("휴먼매직체", 11F);
            this.테스트ToolStripMenuItem.Name = "테스트ToolStripMenuItem";
            this.테스트ToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.테스트ToolStripMenuItem.Text = "출석체크(테스트)";
            this.테스트ToolStripMenuItem.Click += new System.EventHandler(this.테스트ToolStripMenuItem_Click);
            // 
            // 출석체크내역ToolStripMenuItem
            // 
            this.출석체크내역ToolStripMenuItem.Font = new System.Drawing.Font("휴먼매직체", 11F);
            this.출석체크내역ToolStripMenuItem.Name = "출석체크내역ToolStripMenuItem";
            this.출석체크내역ToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.출석체크내역ToolStripMenuItem.Text = "출석체크 내역";
            this.출석체크내역ToolStripMenuItem.Click += new System.EventHandler(this.출석체크내역ToolStripMenuItem_Click);
            // 
            // 성적열람ToolStripMenuItem
            // 
            this.성적열람ToolStripMenuItem.Font = new System.Drawing.Font("휴먼매직체", 11F);
            this.성적열람ToolStripMenuItem.Name = "성적열람ToolStripMenuItem";
            this.성적열람ToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.성적열람ToolStripMenuItem.Text = "성적 열람";
            this.성적열람ToolStripMenuItem.Click += new System.EventHandler(this.성적열람ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.프로그램종료ToolStripMenuItem,
            this.로그아웃ToolStripMenuItem});
            this.종료ToolStripMenuItem.Font = new System.Drawing.Font("휴먼매직체", 11F);
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.종료ToolStripMenuItem.Text = "종료";
            // 
            // 프로그램종료ToolStripMenuItem
            // 
            this.프로그램종료ToolStripMenuItem.Font = new System.Drawing.Font("휴먼매직체", 11F);
            this.프로그램종료ToolStripMenuItem.Name = "프로그램종료ToolStripMenuItem";
            this.프로그램종료ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.프로그램종료ToolStripMenuItem.Text = "프로그램 종료";
            this.프로그램종료ToolStripMenuItem.Click += new System.EventHandler(this.프로그램종료ToolStripMenuItem_Click);
            // 
            // 로그아웃ToolStripMenuItem
            // 
            this.로그아웃ToolStripMenuItem.Font = new System.Drawing.Font("휴먼매직체", 11F);
            this.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
            this.로그아웃ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.로그아웃ToolStripMenuItem.Text = "로그아웃";
            this.로그아웃ToolStripMenuItem.Click += new System.EventHandler(this.로그아웃ToolStripMenuItem_Click);
            // 
            // Student_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(864, 440);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Student_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Maincs";
            this.Load += new System.EventHandler(this.Student_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBcu)).EndInit();
            this.gbStdinfo.ResumeLayout(false);
            this.gbStdinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbTimetable.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 출석체크내역ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 성적열람ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로그램종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그아웃ToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbTimetable;
        private System.Windows.Forms.GroupBox gbStdinfo;
        private System.Windows.Forms.TextBox txtDp;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbStdNum;
        private System.Windows.Forms.Label lbDp;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.ListView TimetableList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripMenuItem 테스트ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbBcu;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox txtStdNum;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtYear;
    }
}