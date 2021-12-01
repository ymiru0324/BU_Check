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
    public partial class Professor_Main_성적확인 : Form
    {  
        new Professor_Main Parent;
        static string connectionString = "User Id=projectcheck; Password=check; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.141.55)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
        OracleConnection myConnection = new OracleConnection(connectionString);

        public Professor_Main_성적확인()
        {
            InitializeComponent();
        }
        private void Professor_Main_성적확인_Load(object sender, EventArgs e)
        {
            try
            {
                Parent = (Professor_Main)Owner;

                string commandString = "select 수강코드, 교과목명, 수강반 from 과목, 교수, 수강 where 교수.아이디='" + Parent.ID.Trim() + "' and 과목.지도교수코드=교수.교직원번호 and 과목.과목코드=수강.과목코드";
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
            finally { myConnection.Close(); }
        }

        private void cbPfsClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string commandString = "select 학과명, 학생.학번, 학생.학년, 반, 학생.이름, 출석, 과제, 중간, 기말, 출석+과제+중간+기말 AS 총점, 성적.학점, to_char(성적.기록일시,'yyyy-mm-dd') from 교수, 수강, 학과, 학생, 성적, 수강목록, 과목 where 교수.아이디='" + Parent.ID.Trim() + "' and 수강.수강코드='" + cbPfsClass.Text.Substring(0, 10) + "' and 학과.학과코드 = 학생.소속학과코드 and 학생.학번 = 성적.학생학번 and 학생.학번 = 수강목록.학번 and 성적.수강코드 = 수강.수강코드 and 수강.수강코드 = 수강목록.수강코드 and 수강.과목코드 = 과목.과목코드 and 과목.지도교수코드 = 교수.교직원번호";
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
                    item.SubItems.Add(MR[4].ToString());
                    item.SubItems.Add(MR[5].ToString());
                    item.SubItems.Add(MR[6].ToString());
                    item.SubItems.Add(MR[7].ToString());
                    item.SubItems.Add(MR[8].ToString());
                    item.SubItems.Add(MR[9].ToString());
                    item.SubItems.Add(MR[10].ToString());
                    item.SubItems.Add(MR[11].ToString());
                    PfsClassInfoList.Items.Add(item);
                }
                MR.Close();
            }
            finally { myConnection.Close(); }
        }
    }
}
