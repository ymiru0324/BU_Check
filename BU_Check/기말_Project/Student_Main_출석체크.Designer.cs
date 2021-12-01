namespace 기말_Project
{
    partial class Student_Main_출석체크
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbClass = new System.Windows.Forms.GroupBox();
            this.lbPfsName = new System.Windows.Forms.Label();
            this.txtPfsName = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.lbClass = new System.Windows.Forms.Label();
            this.gbTime = new System.Windows.Forms.GroupBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.gbClass.SuspendLayout();
            this.gbTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.gbClass);
            this.panel1.Controls.Add(this.gbTime);
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Font = new System.Drawing.Font("휴먼매직체", 11F);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 400);
            this.panel1.TabIndex = 0;
            // 
            // gbClass
            // 
            this.gbClass.Controls.Add(this.lbPfsName);
            this.gbClass.Controls.Add(this.txtPfsName);
            this.gbClass.Controls.Add(this.txtClass);
            this.gbClass.Controls.Add(this.lbClass);
            this.gbClass.Location = new System.Drawing.Point(3, 66);
            this.gbClass.Name = "gbClass";
            this.gbClass.Size = new System.Drawing.Size(301, 88);
            this.gbClass.TabIndex = 2;
            this.gbClass.TabStop = false;
            this.gbClass.Text = "교과 정보";
            // 
            // lbPfsName
            // 
            this.lbPfsName.AutoSize = true;
            this.lbPfsName.Location = new System.Drawing.Point(8, 59);
            this.lbPfsName.Name = "lbPfsName";
            this.lbPfsName.Size = new System.Drawing.Size(81, 15);
            this.lbPfsName.TabIndex = 2;
            this.lbPfsName.Text = "담당 교수님 :";
            // 
            // txtPfsName
            // 
            this.txtPfsName.Location = new System.Drawing.Point(105, 57);
            this.txtPfsName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPfsName.Name = "txtPfsName";
            this.txtPfsName.ReadOnly = true;
            this.txtPfsName.Size = new System.Drawing.Size(184, 24);
            this.txtPfsName.TabIndex = 1;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(138, 25);
            this.txtClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(151, 24);
            this.txtClass.TabIndex = 1;
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Location = new System.Drawing.Point(8, 27);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(110, 15);
            this.lbClass.TabIndex = 0;
            this.lbClass.Text = "출석 가능한 과목 :";
            // 
            // gbTime
            // 
            this.gbTime.Controls.Add(this.txtTime);
            this.gbTime.Controls.Add(this.lbTime);
            this.gbTime.Location = new System.Drawing.Point(3, 3);
            this.gbTime.Name = "gbTime";
            this.gbTime.Size = new System.Drawing.Size(301, 56);
            this.gbTime.TabIndex = 1;
            this.gbTime.TabStop = false;
            this.gbTime.Text = "시간 설정";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(95, 22);
            this.txtTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(194, 24);
            this.txtTime.TabIndex = 1;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(8, 24);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(73, 15);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "현재 시간 :";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCheck.Location = new System.Drawing.Point(3, 160);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(301, 233);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "출 석 체 크";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Student_Main_출석체크
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(332, 423);
            this.Controls.Add(this.panel1);
            this.Name = "Student_Main_출석체크";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Main_출석체크";
            this.Load += new System.EventHandler(this.Student_Main_출석체크_Load);
            this.panel1.ResumeLayout(false);
            this.gbClass.ResumeLayout(false);
            this.gbClass.PerformLayout();
            this.gbTime.ResumeLayout(false);
            this.gbTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbClass;
        private System.Windows.Forms.GroupBox gbTime;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lbPfsName;
        private System.Windows.Forms.TextBox txtPfsName;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Timer timer1;
    }
}