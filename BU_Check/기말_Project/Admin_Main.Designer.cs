namespace 기말_Project
{
    partial class Admin_Main
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
            this.gbCheckAdmin = new System.Windows.Forms.GroupBox();
            this.btnCheckSave = new System.Windows.Forms.Button();
            this.gbCheckAdminlabel2 = new System.Windows.Forms.Label();
            this.gbCheckAdminlabel1 = new System.Windows.Forms.Label();
            this.cbCheckAdmin = new System.Windows.Forms.ComboBox();
            this.gbCheck = new System.Windows.Forms.GroupBox();
            this.CheckList = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbStdList = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbStdYear = new System.Windows.Forms.Label();
            this.lbStdDp = new System.Windows.Forms.Label();
            this.cbStdYear = new System.Windows.Forms.ComboBox();
            this.cbStdDp = new System.Windows.Forms.ComboBox();
            this.StdList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbClassList = new System.Windows.Forms.GroupBox();
            this.ListClass = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.이용자관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.gbCheckAdmin.SuspendLayout();
            this.gbCheck.SuspendLayout();
            this.gbStdList.SuspendLayout();
            this.gbClassList.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.gbCheckAdmin);
            this.panel1.Controls.Add(this.gbCheck);
            this.panel1.Controls.Add(this.gbStdList);
            this.panel1.Controls.Add(this.gbClassList);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 412);
            this.panel1.TabIndex = 0;
            // 
            // gbCheckAdmin
            // 
            this.gbCheckAdmin.Controls.Add(this.btnCheckSave);
            this.gbCheckAdmin.Controls.Add(this.gbCheckAdminlabel2);
            this.gbCheckAdmin.Controls.Add(this.gbCheckAdminlabel1);
            this.gbCheckAdmin.Controls.Add(this.cbCheckAdmin);
            this.gbCheckAdmin.Font = new System.Drawing.Font("휴먼매직체", 11F);
            this.gbCheckAdmin.Location = new System.Drawing.Point(647, 272);
            this.gbCheckAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCheckAdmin.Name = "gbCheckAdmin";
            this.gbCheckAdmin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCheckAdmin.Size = new System.Drawing.Size(274, 134);
            this.gbCheckAdmin.TabIndex = 3;
            this.gbCheckAdmin.TabStop = false;
            this.gbCheckAdmin.Text = "출결 관리";
            // 
            // btnCheckSave
            // 
            this.btnCheckSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCheckSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckSave.Location = new System.Drawing.Point(6, 84);
            this.btnCheckSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckSave.Name = "btnCheckSave";
            this.btnCheckSave.Size = new System.Drawing.Size(262, 46);
            this.btnCheckSave.TabIndex = 3;
            this.btnCheckSave.Text = "완료";
            this.btnCheckSave.UseVisualStyleBackColor = false;
            this.btnCheckSave.Click += new System.EventHandler(this.btnCheckSave_Click);
            // 
            // gbCheckAdminlabel2
            // 
            this.gbCheckAdminlabel2.AutoSize = true;
            this.gbCheckAdminlabel2.Location = new System.Drawing.Point(143, 55);
            this.gbCheckAdminlabel2.Name = "gbCheckAdminlabel2";
            this.gbCheckAdminlabel2.Size = new System.Drawing.Size(85, 15);
            this.gbCheckAdminlabel2.TabIndex = 2;
            this.gbCheckAdminlabel2.Text = "로 변경합니다";
            // 
            // gbCheckAdminlabel1
            // 
            this.gbCheckAdminlabel1.AutoSize = true;
            this.gbCheckAdminlabel1.Location = new System.Drawing.Point(66, 28);
            this.gbCheckAdminlabel1.Name = "gbCheckAdminlabel1";
            this.gbCheckAdminlabel1.Size = new System.Drawing.Size(143, 15);
            this.gbCheckAdminlabel1.TabIndex = 1;
            this.gbCheckAdminlabel1.Text = "해당 학생의 출결 여부를";
            // 
            // cbCheckAdmin
            // 
            this.cbCheckAdmin.FormattingEnabled = true;
            this.cbCheckAdmin.Items.AddRange(new object[] {
            "출석",
            "지각",
            "결석"});
            this.cbCheckAdmin.Location = new System.Drawing.Point(56, 53);
            this.cbCheckAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCheckAdmin.Name = "cbCheckAdmin";
            this.cbCheckAdmin.Size = new System.Drawing.Size(82, 23);
            this.cbCheckAdmin.TabIndex = 0;
            // 
            // gbCheck
            // 
            this.gbCheck.Controls.Add(this.CheckList);
            this.gbCheck.Font = new System.Drawing.Font("휴먼매직체", 11F);
            this.gbCheck.Location = new System.Drawing.Point(647, 24);
            this.gbCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCheck.Name = "gbCheck";
            this.gbCheck.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCheck.Size = new System.Drawing.Size(274, 246);
            this.gbCheck.TabIndex = 2;
            this.gbCheck.TabStop = false;
            this.gbCheck.Text = "출결 정보";
            // 
            // CheckList
            // 
            this.CheckList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.CheckList.Location = new System.Drawing.Point(5, 22);
            this.CheckList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckList.Name = "CheckList";
            this.CheckList.Size = new System.Drawing.Size(264, 220);
            this.CheckList.TabIndex = 0;
            this.CheckList.UseCompatibleStateImageBehavior = false;
            this.CheckList.View = System.Windows.Forms.View.Details;
            this.CheckList.SelectedIndexChanged += new System.EventHandler(this.CheckList_SelectedIndexChanged);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "기록일시";
            this.columnHeader9.Width = 190;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "출석정보";
            this.columnHeader10.Width = 70;
            // 
            // gbStdList
            // 
            this.gbStdList.Controls.Add(this.btnOK);
            this.gbStdList.Controls.Add(this.lbStdYear);
            this.gbStdList.Controls.Add(this.lbStdDp);
            this.gbStdList.Controls.Add(this.cbStdYear);
            this.gbStdList.Controls.Add(this.cbStdDp);
            this.gbStdList.Controls.Add(this.StdList);
            this.gbStdList.Font = new System.Drawing.Font("휴먼매직체", 11F);
            this.gbStdList.Location = new System.Drawing.Point(3, 24);
            this.gbStdList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbStdList.Name = "gbStdList";
            this.gbStdList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbStdList.Size = new System.Drawing.Size(295, 385);
            this.gbStdList.TabIndex = 2;
            this.gbStdList.TabStop = false;
            this.gbStdList.Text = "학생 목록";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Location = new System.Drawing.Point(114, 51);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(167, 27);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbStdYear
            // 
            this.lbStdYear.AutoSize = true;
            this.lbStdYear.Location = new System.Drawing.Point(13, 57);
            this.lbStdYear.Name = "lbStdYear";
            this.lbStdYear.Size = new System.Drawing.Size(42, 15);
            this.lbStdYear.TabIndex = 7;
            this.lbStdYear.Text = "학년 :";
            // 
            // lbStdDp
            // 
            this.lbStdDp.AutoSize = true;
            this.lbStdDp.Location = new System.Drawing.Point(12, 26);
            this.lbStdDp.Name = "lbStdDp";
            this.lbStdDp.Size = new System.Drawing.Size(43, 15);
            this.lbStdDp.TabIndex = 6;
            this.lbStdDp.Text = "학과 :";
            // 
            // cbStdYear
            // 
            this.cbStdYear.FormattingEnabled = true;
            this.cbStdYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbStdYear.Location = new System.Drawing.Point(66, 54);
            this.cbStdYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStdYear.Name = "cbStdYear";
            this.cbStdYear.Size = new System.Drawing.Size(42, 23);
            this.cbStdYear.TabIndex = 5;
            // 
            // cbStdDp
            // 
            this.cbStdDp.FormattingEnabled = true;
            this.cbStdDp.Location = new System.Drawing.Point(66, 23);
            this.cbStdDp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStdDp.Name = "cbStdDp";
            this.cbStdDp.Size = new System.Drawing.Size(215, 23);
            this.cbStdDp.TabIndex = 5;
            // 
            // StdList
            // 
            this.StdList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.StdList.Location = new System.Drawing.Point(5, 83);
            this.StdList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StdList.Name = "StdList";
            this.StdList.Size = new System.Drawing.Size(285, 297);
            this.StdList.TabIndex = 2;
            this.StdList.UseCompatibleStateImageBehavior = false;
            this.StdList.View = System.Windows.Forms.View.Details;
            this.StdList.SelectedIndexChanged += new System.EventHandler(this.StdList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "학번";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "이름";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "학년";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "반";
            this.columnHeader4.Width = 50;
            // 
            // gbClassList
            // 
            this.gbClassList.Controls.Add(this.ListClass);
            this.gbClassList.Font = new System.Drawing.Font("휴먼매직체", 11F);
            this.gbClassList.Location = new System.Drawing.Point(303, 24);
            this.gbClassList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbClassList.Name = "gbClassList";
            this.gbClassList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbClassList.Size = new System.Drawing.Size(338, 385);
            this.gbClassList.TabIndex = 2;
            this.gbClassList.TabStop = false;
            this.gbClassList.Text = "수업 목록";
            // 
            // ListClass
            // 
            this.ListClass.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.ListClass.Location = new System.Drawing.Point(6, 22);
            this.ListClass.Name = "ListClass";
            this.ListClass.Size = new System.Drawing.Size(327, 358);
            this.ListClass.TabIndex = 5;
            this.ListClass.UseCompatibleStateImageBehavior = false;
            this.ListClass.View = System.Windows.Forms.View.Details;
            this.ListClass.SelectedIndexChanged += new System.EventHandler(this.ListClass_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "수강코드";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "교과목명";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "지도교수";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "교과구분";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.이용자관리ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(924, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "출석관리";
            // 
            // 이용자관리ToolStripMenuItem
            // 
            this.이용자관리ToolStripMenuItem.Font = new System.Drawing.Font("휴먼매직체", 11F);
            this.이용자관리ToolStripMenuItem.Name = "이용자관리ToolStripMenuItem";
            this.이용자관리ToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.이용자관리ToolStripMenuItem.Text = "이용자 관리";
            this.이용자관리ToolStripMenuItem.Click += new System.EventHandler(this.이용자관리ToolStripMenuItem_Click);
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
            this.프로그램종료ToolStripMenuItem.Name = "프로그램종료ToolStripMenuItem";
            this.프로그램종료ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.프로그램종료ToolStripMenuItem.Text = "프로그램 종료";
            this.프로그램종료ToolStripMenuItem.Click += new System.EventHandler(this.프로그램종료ToolStripMenuItem_Click);
            // 
            // 로그아웃ToolStripMenuItem
            // 
            this.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
            this.로그아웃ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.로그아웃ToolStripMenuItem.Text = "로그아웃";
            this.로그아웃ToolStripMenuItem.Click += new System.EventHandler(this.로그아웃ToolStripMenuItem_Click);
            // 
            // Admin_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(950, 430);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Main";
            this.Load += new System.EventHandler(this.Admin_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbCheckAdmin.ResumeLayout(false);
            this.gbCheckAdmin.PerformLayout();
            this.gbCheck.ResumeLayout(false);
            this.gbStdList.ResumeLayout(false);
            this.gbStdList.PerformLayout();
            this.gbClassList.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로그램종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그아웃ToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbStdList;
        private System.Windows.Forms.ListView StdList;
        private System.Windows.Forms.GroupBox gbCheck;
        private System.Windows.Forms.GroupBox gbCheckAdmin;
        private System.Windows.Forms.Label gbCheckAdminlabel2;
        private System.Windows.Forms.Label gbCheckAdminlabel1;
        private System.Windows.Forms.ComboBox cbCheckAdmin;
        private System.Windows.Forms.Button btnCheckSave;
        private System.Windows.Forms.Label lbStdYear;
        private System.Windows.Forms.Label lbStdDp;
        private System.Windows.Forms.ComboBox cbStdYear;
        private System.Windows.Forms.ComboBox cbStdDp;
        private System.Windows.Forms.GroupBox gbClassList;
        private System.Windows.Forms.ListView CheckList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView ListClass;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ToolStripMenuItem 이용자관리ToolStripMenuItem;
    }
}