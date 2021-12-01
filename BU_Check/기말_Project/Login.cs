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
  
        1633008 김현우 작성

*/

namespace 기말_Project
{
    public partial class Login : Form
    {
        private OracleConnection conn = new OracleConnection();
        string ConnectionString = "User Id=projectcheck; Password=check; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.141.55)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe)) );";
        
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                conn.ConnectionString = ConnectionString;
                conn.Open();
                string strqry = "select * from 이용자 where 아이디 = '" + txtID.Text.Trim() + "'and 비밀번호 = '" + txtPW.Text.Trim() + "'and 권한 = '" + lblAutho.Text.Trim() + "'";
                OracleCommand OraCmd = new OracleCommand(strqry, conn);
                OracleDataReader odr = OraCmd.ExecuteReader();
                if (odr.Read())
                {
                    if (radioButton1.Checked == true)
                    {
                        Student_Main info = new Student_Main();
                        info.ID = txtID.Text.Trim();
                        this.Hide();
                        info.ShowDialog();
                    }
                    else if (radioButton2.Checked == true)
                    {
                        Professor_Main info = new Professor_Main();
                        info.ID = txtID.Text.Trim();
                        this.Hide();
                        info.ShowDialog();
                    }
                    else if (radioButton3.Checked == true)
                    {
                        Admin_Main info = new Admin_Main();
                        this.Hide();
                        info.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("로그인 정보가 일치하지 않습니다.", "경고");
                    txtID.Clear();
                    txtPW.Clear();
                    txtID.Focus();
                }
            }
            catch (DataException DE)
            { MessageBox.Show(DE.Message); }
            catch (Exception DE)
            { MessageBox.Show(DE.Message); }
            finally
            {
                conn.Close();
            }
        }

        private void 프로그램종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료하시겠습니까?", "알림", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblAutho.Text = "학생"; 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblAutho.Text = "교수";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lblAutho.Text = "관리자";
        }
    }
}
