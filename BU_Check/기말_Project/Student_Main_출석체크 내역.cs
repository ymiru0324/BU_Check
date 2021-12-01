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
  
        1633009 강동현, 1633008 김현우 작성

*/

namespace 기말_Project
{
    // 2018-11-29(목)강동현
    // 2018-12-04 김현우 수정
    public partial class Student_Main_출석체크_내역 : Form
    {
        string connectionString = "User Id=projectcheck; Password=check; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.141.55)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";

        new Student_Main Parent;

        public Student_Main_출석체크_내역()
        {
            InitializeComponent();
        }

        private void btnGradeCheck_Click(object sender, EventArgs e)
        {
            Student_Main_성적열람 std_grade = new Student_Main_성적열람();
            std_grade.Owner = this;
            std_grade.ShowDialog();
            std_grade.Dispose();
        }

        private void Student_Main_출석체크_내역_Load(object sender, EventArgs e)
        {
            Parent = (Student_Main)Owner;
            OracleConnection myConnection = new OracleConnection(connectionString);
            string commandString = "select 교과목명, P.이름, 요일, 시작시간, 마침시간, 교과구분 from 과목 G, 수강 S, 교수 P, 수강목록 A, 학생 D, 이용자 K where K.아이디 = '" + Parent.ID.Trim() + "' and D.학번 = A.학번 and K.아이디 = D.아이디 and G.과목코드 = S.과목코드 and S.수강코드 = A.수강코드 and G.지도교수코드 = P.교직원번호";
            OracleCommand myCommand = new OracleCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = commandString;
            myConnection.Open();
            OracleDataReader MR;
            MR = myCommand.ExecuteReader();
            while (MR.Read())
            {
                ListViewItem item = new ListViewItem(MR[0].ToString());
                item.SubItems.Add(MR[1].ToString());
                item.SubItems.Add(MR[2].ToString());
                item.SubItems.Add(MR[3].ToString());
                item.SubItems.Add(MR[4].ToString());
                item.SubItems.Add(MR[5].ToString());
                StdClassList.Items.Add(item);
            }
            MR.Close();
            myConnection.Close();
        }

        private void StdClassList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Parent = (Student_Main)Owner;
            int Lesindex;
            string selectLesNum;
            int check = 0, late = 0, absent = 0;

            Lesindex = StdClassList.FocusedItem.Index;
            selectLesNum = StdClassList.Items[Lesindex].SubItems[0].Text;

            OracleConnection myConnection = new OracleConnection(connectionString);
            string commandString =
                "select TO_CHAR(출석.기록일시, 'YYYY-MM-DD AM HH:MI:SS'), 출석정보 from 출석, 수강목록, 과목, 수강 where 과목.교과목명='" + selectLesNum.Trim() + "' and 출석.학생학번 = '" + Parent.StdNum.Trim() + "' and 출석.학생학번=수강목록.학번 and 수강목록.수강코드=출석.수강코드 and 과목.과목코드=수강.과목코드 and 수강.수강코드=수강목록.수강코드";

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
                if (MR[1].ToString() == "출석")
                    check++;
                if (MR[1].ToString() == "지각")
                    late++;
                if (MR[1].ToString() == "결석")
                    absent++;
            }
            MR.Close();

            txtAt.Text = check.ToString();
            txtLate.Text = late.ToString();
            txtAb.Text = absent.ToString();
            myConnection.Close();
        }
    }
}