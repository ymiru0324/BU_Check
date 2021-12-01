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
    public partial class Student_Main_성적열람 : Form
    {
        //2018-12-04 강동현 미완
        //2018-12-06 강동현 완
        string connectionString = "User Id=projectcheck; Password=check; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.141.55)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";

        new Student_Main Parent;

        public Student_Main_성적열람()
        {
            InitializeComponent();
        }

        private void Student_Main_성적열람_Load(object sender, EventArgs e)
        {
            Parent = (Student_Main)Owner;

            OracleConnection myConnection = new OracleConnection(connectionString);
            string commandString =
                "select 교과목명, 교수.이름, 교과구분, 출석, 과제, 중간, 기말, 출석+과제+중간+기말, 성적.학점 from 과목, 학생, 수강목록, 수강, 교수, 성적 where 학생.학번='" + Parent.StdNum.Trim() + "' and 수강.과목코드=과목.과목코드 and 수강목록.학번=학생.학번 and 수강.수강코드=수강목록.수강코드 and 교수.교직원번호=과목.지도교수코드 and 수강목록.수강코드=성적.수강코드 and 학생.학번=성적.학생학번";

            OracleCommand myCommand = new OracleCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = commandString;
            myConnection.Open();

            OracleDataReader MR;
            MR = myCommand.ExecuteReader();

            double grade = 0;
            
            while (MR.Read())
            {
                ListViewItem item = new ListViewItem(MR[0].ToString()); //교과목명
                item.SubItems.Add(MR[1].ToString()); //이름
                item.SubItems.Add(MR[2].ToString()); //교과구분
                item.SubItems.Add(MR[3].ToString()); //출석
                item.SubItems.Add(MR[4].ToString()); //과제
                item.SubItems.Add(MR[5].ToString()); //중간
                item.SubItems.Add(MR[6].ToString()); //기말
                item.SubItems.Add(MR[7].ToString()); //합계
                item.SubItems.Add(MR[8].ToString()); //학점
                StdGradeCheckList.Items.Add(item);

                if (MR[8].ToString() == "A+")
                    grade += 4.5;
                else if (MR[8].ToString() == "A0")
                    grade += 4.0;
                else if (MR[8].ToString() == "B+")
                    grade += 3.5;
                else if (MR[8].ToString() == "B0")
                    grade += 3.0;
                else if (MR[8].ToString() == "C+")
                    grade += 2.5;
                else if (MR[8].ToString() == "C0")
                    grade += 2.0;
                else if (MR[8].ToString() == "D+")
                    grade += 1.5;
                else if (MR[8].ToString() == "D0")
                    grade += 1.0;
                else if (MR[8].ToString() == "F")
                    grade += 0.0;
            }
            MR.Close();
            int credit = StdGradeCheckList.Items.Count;
            double avg = grade / credit;

            txtGrade.Text = avg.ToString("N2");

            myConnection.Close();
        }
    }
}
