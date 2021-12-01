using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

/*
  
        1633031 김용민 작성

*/

namespace 기말_Project
{

    /*
     * 킹용민 작성
     * 2018-12-05-오후 3시 50분
     */
    public partial class Admin_Main_이용자_관리 : Form
    {
        public Admin_Main_이용자_관리()
        {
            InitializeComponent();
        }

        private string ID; //ID 필드 설정
        private string strCommand; //데이터 삭제, 추가, 업데이트 인지를 설정할 문자열 필드
        private OracleConnection odpConn = new OracleConnection();
        public string getID
        { get { return ID; } }
        public string getstrCommand
        { get { return strCommand; } }

        private void Admin_Main_이용자_관리_Load(object sender, EventArgs e)
        {
            ShowDBGridView();
        }

        private void ShowDBGridView()
        {
            try
            {
                odpConn.ConnectionString = "User Id=projectcheck; Password=check; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.141.55)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
                odpConn.Open();
                OracleDataAdapter oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand("SELECT * from 이용자", odpConn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                odpConn.Close();
                DBGridView.DataSource = dt;
                DBGridView.AutoResizeColumns();
                DBGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DBGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DBGridView.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("에러 발생 : " + ex.ToString());
                odpConn.Close();
            }
        }

        private void 이용자추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strCommand = "추가";
            Admin_Main_이용자_관리_입력 form2 = new Admin_Main_이용자_관리_입력(this);
            form2.ShowDialog();
            form2.Dispose();
            ShowDBGridView();
        }

        private void 선택한이용자수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strCommand = "수정";
            ID = DBGridView.SelectedCells[0].Value.ToString();
            Admin_Main_이용자_관리_입력 form2 = new Admin_Main_이용자_관리_입력(this);
            form2.ShowDialog();
            form2.Dispose();
            ShowDBGridView();
        }

        private void 선택한이용자삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strCommand = "삭제";
            ID = DBGridView.SelectedCells[0].Value.ToString();
            Admin_Main_이용자_관리_입력 form2 = new Admin_Main_이용자_관리_입력(this);
            form2.ShowDialog();
            form2.Dispose();
            ShowDBGridView();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            try
            {
                odpConn.ConnectionString = "User Id=projectcheck; Password=check; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.141.55)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
                odpConn.Open();
                OracleDataAdapter oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand("SELECT * from 이용자 where 아이디='"+txtSearch.Text+"'", odpConn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                odpConn.Close();
                DBGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("에러 발생 : " + ex.ToString());
                odpConn.Close();
            }
            
        }
    }
}
