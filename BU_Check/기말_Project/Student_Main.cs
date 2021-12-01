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
  
        1633009 강동현 작성

*/

namespace 기말_Project
{
    /*2018-11-29(목)강동현*/
    // 2018-12-05 김현우 프로퍼티 추가
    // 2018-12-07 김현우 멤버변수 추가
    public partial class Student_Main : Form
    {
        public bool complite = false;
        public bool NOSubject = true;

        public Student_Main()
        {
            InitializeComponent();
        }

        public string ID
        {
            get { return txtID.Text; }
            set { txtID.Text = value; }
        }
        public string StdNum
        {
            get { return txtStdNum.Text; }
            set { txtStdNum.Text = value; }
        }
        public string StdLevel
        {
            get { return txtYear.Text; }
            set { txtYear.Text = value; }
        }
        public string StdClass
        {
            get { return txtClass.Text; }
            set { txtClass.Text = value; }
        }

        private void 출석체크내역ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Main_출석체크_내역 std_check_list = new Student_Main_출석체크_내역();
            std_check_list.Owner = this;
            std_check_list.ShowDialog();
            std_check_list.Dispose();
        }

        private void 성적열람ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*2018-11-30(금)강동현*/
            Student_Main_성적열람 std_grade = new Student_Main_성적열람();
            std_grade.Owner = this;
            std_grade.ShowDialog();
            std_grade.Dispose();
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

        private void 테스트ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Main_출석체크 std_test = new Student_Main_출석체크(this);
            std_test.ShowDialog();
        }

        private void Student_Main_Load(object sender, EventArgs e)
        {
            string connectionString = "User Id=projectcheck; Password=check; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.141.55)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
            OracleConnection myConnection = new OracleConnection(connectionString);

            myConnection.Open();
            OracleCommand myCommand = new OracleCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = "select 이름, 학번, 학과명, 학년, 반 from 이용자, 학생, 학과 where 이용자.아이디 = '" + txtID.Text.Trim() + "' and 이용자.아이디=학생.아이디 and 학생.소속학과코드=학과.학과코드";
            myCommand.ExecuteNonQuery();

            OracleDataReader MR;
            MR = myCommand.ExecuteReader();

            while (MR.Read())
            {
                string Name = MR["이름"].ToString();
                string StdNum = MR["학번"].ToString();
                string Dp = MR["학과명"].ToString();
                string Year = MR["학년"].ToString();
                string Class = MR["반"].ToString();

                txtName.Text = Name;
                txtStdNum.Text = StdNum;
                txtDp.Text = Dp;
                txtYear.Text = Year;
                txtClass.Text = Class;
            }
            MR.Close();
            myCommand.CommandText = "select 교과목명, 교수.이름, 요일, 시작시간, 마침시간, 강의실, 교과구분 from 과목, 수강, 교수, 수강목록, 학생, 이용자 where 이용자.아이디 = '" + txtID.Text.Trim() + "' and 학생.학번 = 수강목록.학번 and 이용자.아이디 = 학생.아이디 and 과목.과목코드 = 수강.과목코드 and 수강.수강코드 = 수강목록.수강코드 and 과목.지도교수코드 = 교수.교직원번호";
            MR = myCommand.ExecuteReader();
            while (MR.Read())
            {
                ListViewItem item = new ListViewItem(MR[0].ToString());
                item.SubItems.Add(MR[1].ToString());
                item.SubItems.Add(MR[2].ToString());
                item.SubItems.Add(MR[3].ToString());
                item.SubItems.Add(MR[4].ToString());
                item.SubItems.Add(MR[5].ToString());
                item.SubItems.Add(MR[6].ToString());
                TimetableList.Items.Add(item);
            }
            MR.Close();
            myConnection.Close();
        }
    }
}
