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
    public partial class Professor_Main : Form
    {
        // 용민 11-29 오후 2시 작성

        static string connectionString = "User Id=projectcheck; Password=check; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.141.55)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
        OracleConnection myConnection = new OracleConnection(connectionString);

        static string grade;
        public Professor_Main()
        {
            InitializeComponent();
        }

        public string ID
        {
            get { return lblPfsID.Text; }
            set { lblPfsID.Text = value; }
        }

        private void 출석현황ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Professor_Main_출석현황 pfs_check = new Professor_Main_출석현황();
            pfs_check.Owner = this;
            pfs_check.ShowDialog();
            pfs_check.Dispose();
        }

        // 2018-11-29 김현우 작성
        private void Professor_Main_Load(object sender, EventArgs e)
        {
            try
            {
                int cbClassindex = cbPfsClass.SelectedIndex;

                string commandString = "select 수강.수강코드, 과목.교과목명, 수강.수강반 from 교수, 과목, 수강 where 교수.아이디 = '" + lblPfsID.Text.Trim() + "' and 교수.교직원번호 = 과목.지도교수코드 and 과목.과목코드 = 수강.과목코드";
                OracleCommand myCommand = new OracleCommand(commandString, myConnection);
                myConnection.Open();
                OracleDataReader MR;
                MR = myCommand.ExecuteReader();
                while (MR.Read())
                {
                    cbPfsClass.Items.Add(MR[0].ToString().Trim() + " :: " + MR[1].ToString().Trim() + " [" + MR[2].ToString().Trim() + "반]");
                }
                MR.Close();
            }
            catch (DataException DE)
            { MessageBox.Show(DE.Message); }
            catch (Exception DE)
            { MessageBox.Show(DE.Message); }
            finally { myConnection.Close(); }
        }

        // 2018-11-29 김현우 작성
        private void cbPfsClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string commandString = "select 학생.이름, 학과.학과명, 학생.학년, 학생.학번 from 학생, 학과, 수강목록 where 수강목록.수강코드 = '" + cbPfsClass.Text.Substring(0, 10) + "' and 학생.소속학과코드 = 학과.학과코드 and 수강목록.학번 = 학생.학번";
                OracleCommand myCommand = new OracleCommand(commandString, myConnection);
                myConnection.Open();
                OracleDataReader MR;
                MR = myCommand.ExecuteReader();

                StdList.Items.Clear();

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

        // 2018-11-29 2:40 김현우 수정
        private void StdList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int Stdindex = StdList.FocusedItem.Index;

                txtStdName.Text = StdList.Items[Stdindex].SubItems[0].Text;
                txtDp.Text = StdList.Items[Stdindex].SubItems[1].Text;
                txtYear.Text = StdList.Items[Stdindex].SubItems[2].Text;
                txtStdNum.Text = StdList.Items[Stdindex].SubItems[3].Text;

                string commandString = "select TO_CHAR(출석.기록일시, 'YYYY-MM-DD AM HH:MI:SS'), 출석정보 from 출석, 수강목록 where 출석.수강코드 = '" + cbPfsClass.Text.Substring(0, 10).Trim() + "' and 출석.학생학번 = '" + txtStdNum.Text.Trim() + "' and 출석.학생학번 = 수강목록.학번 and 출석.수강코드 = 수강목록.수강코드";
                OracleCommand myCommand = new OracleCommand(commandString, myConnection);
                myConnection.Open();
                OracleDataReader MR;
                MR = myCommand.ExecuteReader();

                StdCheckList.Items.Clear();

                while (MR.Read())
                {
                    ListViewItem item = new ListViewItem(MR[0].ToString());
                    item.SubItems.Add(MR[1].ToString());
                    StdCheckList.Items.Add(item);
                }
                MR.Close();

                commandString = "select 출석, 과제, 중간, 기말, 학점 from 성적, 학생, 수강목록 where 성적.학생학번 = '" + txtStdNum.Text.Trim() + "' and 성적.수강코드 = '" + cbPfsClass.Text.Substring(0, 10) + "' and 성적.수강코드 = 수강목록.수강코드 and 수강목록.학번 = 학생.학번 and 성적.학생학번 = 학생.학번";
                myCommand.CommandText = commandString;
                MR = myCommand.ExecuteReader();


                while (MR.Read())
                {
                    txtAt.Text = MR[0].ToString();
                    txtProject.Text = MR[1].ToString();
                    txtMiddle.Text = MR[2].ToString();
                    txtFinally.Text = MR[3].ToString();
                    grade = MR[4].ToString();
                }
                MR.Close();

                int total = 0;
                total += Int32.Parse(txtAt.Text);
                total += Int32.Parse(txtProject.Text);
                total += Int32.Parse(txtMiddle.Text);
                total += Int32.Parse(txtFinally.Text);

                txtTotal.Text = total.ToString();

                if (total >= 95)
                    grade = "A+";
                else if ((total >= 90) && (total < 95))
                    grade = "A0";
                else if ((total >= 85) && (total < 90))
                    grade = "B+";
                else if ((total >= 80) && (total < 85))
                    grade = "B0";
                else if ((total >= 75) && (total < 80))
                    grade = "C+";
                else if ((total >= 70) && (total < 75))
                    grade = "C0";
                else if ((total >= 65) && (total < 70))
                    grade = "D+";
                else if ((total >= 60) && (total < 65))
                    grade = "D0";
                else if ((total >= 0) && (total < 60))
                    grade = "F";

                txtGrade.Text = grade;
            }
            catch (DataException DE)
            { MessageBox.Show(DE.Message); }
            catch (Exception DE)
            { MessageBox.Show(DE.Message); }
            finally { myConnection.Close(); }
        }

        // 2018-11-29 김현우 작성
        private void btnGradeinput_Click(object sender, EventArgs e)
        {
            try
            {
                myConnection.Open();
                if (Int32.Parse(txtAt.Text) <= 20 && Int32.Parse(txtProject.Text) <= 20 && Int32.Parse(txtMiddle.Text) <= 30 && Int32.Parse(txtFinally.Text) <= 30)
                {
                    OracleCommand myCommand = new OracleCommand();
                    myCommand.Connection = myConnection;
                    myCommand.CommandText = "update 성적 set 성적.기록일시 = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', 과제 = '" + txtProject.Text.Trim() + "', 중간 = '" + txtMiddle.Text.Trim() + "', 기말 = '" + txtFinally.Text.Trim() + "' where 성적.학생학번 = '" + txtStdNum.Text.Trim() + "' and 성적.수강코드 = '" + cbPfsClass.Text.Substring(0, 10) + "'";
                    myCommand.ExecuteNonQuery();

                    int total = 0;
                    total += Int32.Parse(txtAt.Text);
                    total += Int32.Parse(txtProject.Text);
                    total += Int32.Parse(txtMiddle.Text);
                    total += Int32.Parse(txtFinally.Text);

                    txtTotal.Text = total.ToString();

                    if (total >= 95)
                        grade = "A+";
                    else if ((total >= 90) && (total < 95))
                        grade = "A0";
                    else if ((total >= 85) && (total < 90))
                        grade = "B+";
                    else if ((total >= 80) && (total < 85))
                        grade = "B0";
                    else if ((total >= 75) && (total < 80))
                        grade = "C+";
                    else if ((total >= 70) && (total < 75))
                        grade = "C0";
                    else if ((total >= 65) && (total < 70))
                        grade = "D+";
                    else if ((total >= 60) && (total < 65))
                        grade = "D0";
                    else if ((total >= 0) && (total < 60))
                        grade = "F";

                    txtGrade.Text = grade;

                    myCommand.CommandText = "update 성적 set 학점 = '" + txtGrade.Text.Trim() + "' where 성적.학생학번 = '" + txtStdNum.Text.Trim() + "' and 성적.수강코드 = '" + cbPfsClass.Text.Substring(0, 10) + "'";
                    myCommand.ExecuteNonQuery();

                    myConnection.Close();
                }
                else
                {
                    txtProject.Clear();
                    txtMiddle.Clear();
                    txtFinally.Clear();
                    txtProject.Focus();
                    MessageBox.Show("입력범위를 초과했습니다.", "에러", MessageBoxButtons.OK);
                }
            }
            catch (DataException DE)
            { MessageBox.Show(DE.Message); }
            catch (Exception DE)
            { MessageBox.Show(DE.Message); }
            finally { myConnection.Close(); }
        }

        // <--김용민 11/30 오후 1시 25분 작성
        private void btnGradeCheck_Click(object sender, EventArgs e)
        {
            Professor_Main_성적확인 pfs_grand_check = new Professor_Main_성적확인();
            pfs_grand_check.ShowDialog();
        }

        private void 전체성적확인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Professor_Main_성적확인 pfs_grand_check = new Professor_Main_성적확인();
            pfs_grand_check.Owner = this;
            pfs_grand_check.ShowDialog();
            pfs_grand_check.Dispose();
        }
        // 김용민 11/30 오후 1시 25분 작성 -->
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
