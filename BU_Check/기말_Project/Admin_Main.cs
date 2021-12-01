using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
  
        1633008 김현우 작성

*/

namespace 기말_Project
{
    public partial class Admin_Main : Form
    {
        // 2018-11-29 2:08 김현우 작성함
        // 주요기능 완료

        static string connectionString = "User Id=projectcheck; Password=check; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.141.55)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
        OracleConnection myConnection = new OracleConnection(connectionString);

        int Lesindex, Stdindex, Chkindex;
        string selectLesNum, selectStdNum, selectChkNum;
        string oldCheck, Check;
        string qry;
        public Admin_Main()
        {
            InitializeComponent();
            cbStdDp.Text = "학과선택";
            cbStdYear.Text = "1";
            cbCheckAdmin.Text = "출석";
        }
        private void Admin_Main_Load(object sender, EventArgs e)
        {
            try
            {
                string commandString = "select 학과명 from 학과";
                OracleCommand myCommand = new OracleCommand(commandString, myConnection);
                myConnection.Open();
                OracleDataReader MR;
                MR = myCommand.ExecuteReader();
                while (MR.Read())
                {
                    cbStdDp.Items.Add(MR[0].ToString().Trim());
                }
                MR.Close();
                myConnection.Close();
            }
            catch (DataException DE)
            { MessageBox.Show(DE.Message); }
            catch (Exception DE)
            { MessageBox.Show(DE.Message); }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                StdList.Items.Clear();

                int cbDpIndex, cbYearIndex;
                cbDpIndex = cbStdDp.SelectedIndex;
                cbYearIndex = cbStdYear.SelectedIndex;

                string commandString = "select 학번, 이름, 학년, 반 from 학생, 학과 where 학과명 = '" + cbStdDp.Items[cbDpIndex].ToString().Trim() + "'and 학년 = '" + cbStdYear.Items[cbYearIndex].ToString().Trim() + "'and 학생.소속학과코드 = 학과.학과코드";
                OracleCommand myCommand = new OracleCommand(commandString, myConnection);
                myConnection.Open();
                OracleDataReader MR;
                MR = myCommand.ExecuteReader();
                while (MR.Read())
                {
                    ListViewItem item = new ListViewItem(MR[0].ToString());
                    item.SubItems.Add(MR[1].ToString());
                    item.SubItems.Add(MR[2].ToString());
                    item.SubItems.Add(MR[3].ToString());
                    StdList.Items.Add(item);
                }
                MR.Close();
            }
            catch (DataException DE)
            { MessageBox.Show(DE.Message); }
            catch (Exception DE)
            { MessageBox.Show(DE.Message); }
            finally { myConnection.Close(); }
        }

        private void StdList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListClass.Items.Clear();

                Stdindex = StdList.FocusedItem.Index;
                selectStdNum = StdList.Items[Stdindex].SubItems[0].Text;

                string commandString = "select 수강.수강코드, 과목.교과목명, 교수.이름, 과목.교과구분 from 과목, 수강, 수강목록, 교수 where 수강목록.학번 = '" + selectStdNum + "' and 과목.과목코드 = 수강.과목코드 and 수강.수강코드 = 수강목록.수강코드 and 과목.지도교수코드 = 교수.교직원번호";
                OracleCommand myCommand = new OracleCommand(commandString, myConnection);
                myConnection.Open();
                OracleDataReader MR;
                MR = myCommand.ExecuteReader();
                while (MR.Read())
                {
                    ListViewItem item = new ListViewItem(MR[0].ToString());
                    item.SubItems.Add(MR[1].ToString());
                    item.SubItems.Add(MR[2].ToString());
                    item.SubItems.Add(MR[3].ToString());
                    ListClass.Items.Add(item);
                }
                MR.Close();
            }
            catch (DataException DE)
            { MessageBox.Show(DE.Message); }
            catch (Exception DE)
            { MessageBox.Show(DE.Message); }
            finally { myConnection.Close(); }
        }



        private void ListClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Lesindex = ListClass.FocusedItem.Index;
                Stdindex = StdList.FocusedItem.Index;

                selectStdNum = StdList.Items[Stdindex].SubItems[0].Text;
                selectLesNum = ListClass.Items[Lesindex].SubItems[0].Text;

                string commandString = "select TO_CHAR(출석.기록일시, 'YYYY-MM-DD AM HH:MI:SS'), 출석정보 from 출석, 수강목록 where 출석.수강코드 = '" + selectLesNum.Trim() + "' and 출석.학생학번 = '" + selectStdNum.Trim() + "' and 출석.학생학번 = 수강목록.학번 and 출석.수강코드 = 수강목록.수강코드";
                OracleCommand myCommand = new OracleCommand(commandString, myConnection);
                myConnection.Open();
                OracleDataReader MR;
                MR = myCommand.ExecuteReader();

                CheckList.Items.Clear();

                while (MR.Read())
                {
                    ListViewItem item = new ListViewItem(MR[0].ToString());
                    item.SubItems.Add(MR[1].ToString());
                    CheckList.Items.Add(item);
                }
                MR.Close();
            }
            catch (DataException DE)
            { MessageBox.Show(DE.Message); }
            catch (Exception DE)
            { MessageBox.Show(DE.Message); }
            finally { myConnection.Close(); }
        }
        
        private void CheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chkindex = CheckList.FocusedItem.Index;
            cbCheckAdmin.Text = CheckList.Items[Chkindex].SubItems[1].Text;
            oldCheck = cbCheckAdmin.Text.Trim();
        }

        private void btnCheckSave_Click(object sender, EventArgs e)
        {
            try
            {
                selectLesNum = ListClass.Items[Lesindex].SubItems[0].Text;
                selectStdNum = StdList.Items[Stdindex].SubItems[0].Text;
                selectChkNum = CheckList.Items[Chkindex].SubItems[0].Text;

                myConnection.Open();
                OracleCommand myCommand = new OracleCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = "UPDATE 출석 SET 출석.출석정보 = '" + cbCheckAdmin.Text.Trim() + "' WHERE 출석.수강코드 = '" + selectLesNum.Trim() + "' AND 출석.학생학번 = '" + selectStdNum.Trim() + "' AND TO_CHAR(출석.기록일시, 'YYYY-MM-DD AM HH:MI:SS') = TO_CHAR('" + selectChkNum.Trim() + "')";
                myCommand.ExecuteNonQuery();

                myCommand.CommandText = "select TO_CHAR(출석.기록일시, 'YYYY-MM-DD AM HH:MI:SS'), 출석정보 from 출석, 수강목록 where 출석.수강코드 = '" + selectLesNum.Trim() + "' and 출석.학생학번 = '" + selectStdNum.Trim() + "' and 출석.학생학번 = 수강목록.학번 and 출석.수강코드 = 수강목록.수강코드";
                OracleDataReader MR;
                MR = myCommand.ExecuteReader();
                CheckList.Items.Clear();

                while (MR.Read())
                {
                    ListViewItem item = new ListViewItem(MR[0].ToString());
                    item.SubItems.Add(MR[1].ToString());
                    CheckList.Items.Add(item);
                }
                MR.Close();

                Check = cbCheckAdmin.Text.Trim();
                if (oldCheck == "출석" && Check == "지각")
                {
                    qry = "update 성적 set 성적.출석 = 성적.출석 - 1 where 성적.수강코드 = '" + selectLesNum.Trim() + "' and 성적.학생학번 = '" + selectStdNum.Trim() + "'";
                    OracleCommand myCommand2 = new OracleCommand(qry, myConnection);
                    myCommand2.ExecuteNonQuery();
                }
                else if (oldCheck == "출석" && Check == "결석")
                {
                    qry = "update 성적 set 성적.출석 = 성적.출석 - 3 where 성적.수강코드 = '" + selectLesNum.Trim() + "' and 성적.학생학번 = '" + selectStdNum.Trim() + "'";
                    OracleCommand myCommand2 = new OracleCommand(qry, myConnection);
                    myCommand2.ExecuteNonQuery();
                }
                else if (oldCheck == "지각" && Check == "출석")
                {
                    qry = "update 성적 set 성적.출석 = 성적.출석 + 1 where 성적.수강코드 = '" + selectLesNum.Trim() + "' and 성적.학생학번 = '" + selectStdNum.Trim() + "'";
                    OracleCommand myCommand2 = new OracleCommand(qry, myConnection);
                    myCommand2.ExecuteNonQuery();
                }
                else if (oldCheck == "결석" && Check == "출석")
                {
                    qry = "update 성적 set 성적.출석 = 성적.출석 + 3 where 성적.수강코드 = '" + selectLesNum.Trim() + "' and 성적.학생학번 = '" + selectStdNum.Trim() + "'";
                    OracleCommand myCommand2 = new OracleCommand(qry, myConnection);
                    myCommand2.ExecuteNonQuery();
                }

                MessageBox.Show("정상적으로 변경되었습니다.", "처리완료", MessageBoxButtons.OK);
            }
            catch (DataException DE)
            { MessageBox.Show(DE.Message); }
            catch (Exception DE)
            { MessageBox.Show(DE.Message); }
            finally { myConnection.Close(); }
        }

        private void 이용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_Main_이용자_관리 ad_user = new Admin_Main_이용자_관리();
            ad_user.ShowDialog();
        }
        private void 프로그램종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료하시겠습니까?", "알림", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login info = new 기말_Project.Login();
            info.Show();
            this.Close();
        }
    }
}
