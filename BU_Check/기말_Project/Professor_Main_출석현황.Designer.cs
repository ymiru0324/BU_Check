namespace 기말_Project
{
    partial class Professor_Main_출석현황
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
            this.cbPfsClass = new System.Windows.Forms.ComboBox();
            this.lbPfsClass = new System.Windows.Forms.Label();
            this.gbStdCheck = new System.Windows.Forms.GroupBox();
            this.StdCheckList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbDateList = new System.Windows.Forms.GroupBox();
            this.ClassDateList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.gbStdCheck.SuspendLayout();
            this.gbDateList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbPfsClass);
            this.panel1.Controls.Add(this.lbPfsClass);
            this.panel1.Controls.Add(this.gbStdCheck);
            this.panel1.Controls.Add(this.gbDateList);
            this.panel1.Font = new System.Drawing.Font("휴먼매직체", 11F);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 405);
            this.panel1.TabIndex = 0;
            // 
            // cbPfsClass
            // 
            this.cbPfsClass.FormattingEnabled = true;
            this.cbPfsClass.Location = new System.Drawing.Point(6, 25);
            this.cbPfsClass.Name = "cbPfsClass";
            this.cbPfsClass.Size = new System.Drawing.Size(233, 23);
            this.cbPfsClass.TabIndex = 8;
            this.cbPfsClass.SelectedIndexChanged += new System.EventHandler(this.cbPfsClass_SelectedIndexChanged);
            // 
            // lbPfsClass
            // 
            this.lbPfsClass.AutoSize = true;
            this.lbPfsClass.Location = new System.Drawing.Point(75, 3);
            this.lbPfsClass.Name = "lbPfsClass";
            this.lbPfsClass.Size = new System.Drawing.Size(59, 15);
            this.lbPfsClass.TabIndex = 7;
            this.lbPfsClass.Text = "강좌 목록";
            // 
            // gbStdCheck
            // 
            this.gbStdCheck.Controls.Add(this.StdCheckList);
            this.gbStdCheck.Location = new System.Drawing.Point(245, 3);
            this.gbStdCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbStdCheck.Name = "gbStdCheck";
            this.gbStdCheck.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbStdCheck.Size = new System.Drawing.Size(225, 396);
            this.gbStdCheck.TabIndex = 6;
            this.gbStdCheck.TabStop = false;
            this.gbStdCheck.Text = "학생 출결 정보";
            // 
            // StdCheckList
            // 
            this.StdCheckList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.StdCheckList.Location = new System.Drawing.Point(5, 22);
            this.StdCheckList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StdCheckList.Name = "StdCheckList";
            this.StdCheckList.Size = new System.Drawing.Size(214, 367);
            this.StdCheckList.TabIndex = 0;
            this.StdCheckList.UseCompatibleStateImageBehavior = false;
            this.StdCheckList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "학번";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "이름";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "출석정보";
            // 
            // gbDateList
            // 
            this.gbDateList.Controls.Add(this.ClassDateList);
            this.gbDateList.Location = new System.Drawing.Point(3, 53);
            this.gbDateList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDateList.Name = "gbDateList";
            this.gbDateList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDateList.Size = new System.Drawing.Size(236, 346);
            this.gbDateList.TabIndex = 5;
            this.gbDateList.TabStop = false;
            this.gbDateList.Text = "수업 일수";
            // 
            // ClassDateList
            // 
            this.ClassDateList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ClassDateList.Location = new System.Drawing.Point(5, 22);
            this.ClassDateList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassDateList.Name = "ClassDateList";
            this.ClassDateList.Size = new System.Drawing.Size(224, 317);
            this.ClassDateList.TabIndex = 4;
            this.ClassDateList.UseCompatibleStateImageBehavior = false;
            this.ClassDateList.View = System.Windows.Forms.View.Details;
            this.ClassDateList.SelectedIndexChanged += new System.EventHandler(this.ClassDateList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "기록일시";
            this.columnHeader1.Width = 220;
            // 
            // Professor_Main_출석현황
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(500, 424);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Professor_Main_출석현황";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Professor_Main_출석현황";
            this.Load += new System.EventHandler(this.Professor_Main_출석현황_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbStdCheck.ResumeLayout(false);
            this.gbDateList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView ClassDateList;
        private System.Windows.Forms.GroupBox gbDateList;
        private System.Windows.Forms.GroupBox gbStdCheck;
        private System.Windows.Forms.ListView StdCheckList;
        private System.Windows.Forms.ComboBox cbPfsClass;
        private System.Windows.Forms.Label lbPfsClass;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}