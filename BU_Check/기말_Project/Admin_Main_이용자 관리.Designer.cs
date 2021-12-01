namespace 기말_Project
{
    partial class Admin_Main_이용자_관리
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.DBGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.이용자추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선택한이용자수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선택한이용자삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.DBGridView);
            this.panel1.Font = new System.Drawing.Font("휴먼매직체", 11F);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 298);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID 입력 : ";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(274, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 24);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(74, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(192, 24);
            this.txtSearch.TabIndex = 5;
            // 
            // DBGridView
            // 
            this.DBGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.DBGridView.Location = new System.Drawing.Point(4, 33);
            this.DBGridView.Name = "DBGridView";
            this.DBGridView.RowTemplate.Height = 23;
            this.DBGridView.Size = new System.Drawing.Size(361, 255);
            this.DBGridView.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.이용자추가ToolStripMenuItem,
            this.선택한이용자수정ToolStripMenuItem,
            this.선택한이용자삭제ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(179, 70);
            // 
            // 이용자추가ToolStripMenuItem
            // 
            this.이용자추가ToolStripMenuItem.Name = "이용자추가ToolStripMenuItem";
            this.이용자추가ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.이용자추가ToolStripMenuItem.Text = "이용자 추가";
            this.이용자추가ToolStripMenuItem.Click += new System.EventHandler(this.이용자추가ToolStripMenuItem_Click);
            // 
            // 선택한이용자수정ToolStripMenuItem
            // 
            this.선택한이용자수정ToolStripMenuItem.Name = "선택한이용자수정ToolStripMenuItem";
            this.선택한이용자수정ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.선택한이용자수정ToolStripMenuItem.Text = "선택한 이용자 수정";
            this.선택한이용자수정ToolStripMenuItem.Click += new System.EventHandler(this.선택한이용자수정ToolStripMenuItem_Click);
            // 
            // 선택한이용자삭제ToolStripMenuItem
            // 
            this.선택한이용자삭제ToolStripMenuItem.Name = "선택한이용자삭제ToolStripMenuItem";
            this.선택한이용자삭제ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.선택한이용자삭제ToolStripMenuItem.Text = "선택한 이용자 삭제";
            this.선택한이용자삭제ToolStripMenuItem.Click += new System.EventHandler(this.선택한이용자삭제ToolStripMenuItem_Click);
            // 
            // Admin_Main_이용자_관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(397, 319);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_Main_이용자_관리";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Main_이용자_관리";
            this.Load += new System.EventHandler(this.Admin_Main_이용자_관리_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DBGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolStripMenuItem 이용자추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선택한이용자수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선택한이용자삭제ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}