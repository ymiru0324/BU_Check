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
    public partial class Admin_Main_이용자_관리_입력 : Form
    {
        /*
        * 킹용민 작성
        * 2018-12-05-오후 3시 50분
        */
        private OracleConnection odpConn = new OracleConnection();
        Admin_Main_이용자_관리 _parent;

        public Admin_Main_이용자_관리_입력(Admin_Main_이용자_관리 inform1)
        {
            InitializeComponent();
            _parent = inform1;
        }

        private void Admin_Main_이용자_관리_입력_Load(object sender, EventArgs e)
        {
            if (_parent.getstrCommand == "삭제")
            {
                btnOK.Text = "삭제";
                txtID.Enabled = false;
                txtPassword.Enabled = false;
                cbCommand.Enabled = false;
                initialTextBoxes();
            }
            else if (_parent.getstrCommand == "수정")
            {
                btnOK.Text = "수정";
                txtID.Enabled = false;
                initialTextBoxes();
            }
            else btnOK.Text = "추가";
        }

        private void initialTextBoxes()
        {
            try
            {
                odpConn.ConnectionString = "User Id = projectcheck; Password = check; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.141.55)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
                odpConn.Open();
                string strqry = "SELECT * FROM 이용자 WHERE 아이디=:아이디";
                OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
                OraCmd.Parameters.Add("아이디", OracleDbType.Char, 10).Value = _parent.getID.Trim();
                OracleDataReader odr = OraCmd.ExecuteReader();
                while (odr.Read())
                {
                    txtID.Text = Convert.ToString(odr.GetValue(0));
                    txtPassword.Text = Convert.ToString(odr.GetValue(1));
                    cbCommand.Text = Convert.ToString(odr.GetValue(2));

                }
                odr.Close();
                odpConn.Close();
            }
            catch (DataException DE)
            { MessageBox.Show(DE.Message); }
            catch (Exception DE)
            { MessageBox.Show(DE.Message); }
            finally
            {
                if (odpConn.State != ConnectionState.Closed)
                {
                    odpConn.Close();
                }
            }
        }
        
        private int INSERTRow()
        {
            odpConn.ConnectionString = "User Id = projectcheck; Password = check; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.141.55)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
            odpConn.Open();
            string strqry = "INSERT INTO 이용자 VALUES (:아이디, :비밀번호, :권한)";
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
            OraCmd.Parameters.Add("아이디", OracleDbType.Char, 10).Value = txtID.Text.Trim();
            OraCmd.Parameters.Add("비밀번호", OracleDbType.Varchar2, 20).Value = txtPassword.Text.Trim();
            OraCmd.Parameters.Add("권한", OracleDbType.Varchar2, 20).Value = cbCommand.Text.Trim();
            return OraCmd.ExecuteNonQuery(); //추가되는 행수 반환
        }
        private int DELETERow()
        {
            odpConn.ConnectionString = "User Id = projectcheck; Password = check; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.141.55)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
            odpConn.Open();
            string strqry = "DELETE FROM 이용자 WHERE 아이디=:아이디";
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
            OraCmd.Parameters.Add("아이디", OracleDbType.Char, 10).Value = _parent.getID.Trim();
            return OraCmd.ExecuteNonQuery();
        }
        private int UPDATERow()
        {
            odpConn.ConnectionString = "User Id = projectcheck; Password = check; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.141.55)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
            odpConn.Open();
            string strqry = "UPDATE 이용자 SET 아이디 =:아이디, 비밀번호=:비밀번호, 권한=:권한 WHERE 아이디=:아이디";
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
            OraCmd.Parameters.Add("아이디", OracleDbType.Char, 10).Value = _parent.getID.Trim();
            OraCmd.Parameters.Add("비밀번호", OracleDbType.Varchar2, 20).Value = txtPassword.Text.Trim();
            OraCmd.Parameters.Add("권한", OracleDbType.Varchar2, 20).Value = cbCommand.Text.Trim();
            return OraCmd.ExecuteNonQuery(); //업데이트되는 행수 반환
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
                if (btnOK.Text == "추가")
                {
                    if (INSERTRow() > 0)
                    {
                        MessageBox.Show("정상적으로 데이터 행이 추가됨.");
                    }
                    else MessageBox.Show("데이터 행이 추가되지 않음!");
                    this.Close();
                }
                else if (btnOK.Text == "삭제")
                {
                    if (DELETERow() > 0)
                    {
                        MessageBox.Show("정상적으로 데이터 행이 삭제됨!");
                    }
                    else MessageBox.Show("데이터 행이 삭제되지 않음!");
                    this.Close();
                }
                else
                {
                    if (UPDATERow() > 0)
                    {
                        MessageBox.Show("정상적으로 데이터가 업데이트됨!");
                    }
                    else MessageBox.Show("데이터 행이 업데이트되지 않음!");
                    this.Close();
                }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("취소되었습니다.");
            this.Close();
        }
    }
}
