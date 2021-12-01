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
    //2018-12-07 강동현 삽입
    public partial class Professor_Main_출석현황 : Form
    {
        new Professor_Main Parent;
        static string connectionString = "User Id=projectcheck; Password=check; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.141.55)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
        OracleConnection myConnection = new OracleConnection(connectionString);

        public Professor_Main_출석현황()
        {
            InitializeComponent();
        }

        private void Professor_Main_출석현황_Load(object sender, EventArgs e)
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
                string commandString = "select to_char(기록일시, 'DL') from 출석, 수강, 학생 where 수강.수강코드 = '" + cbPfsClass.Text.Substring(0, 10) + "' and 학생.학번 = '0000000' and 출석.수강코드 = 수강.수강코드 and 학생.학번 = 출석.학생학번";
                OracleCommand myCommand = new OracleCommand(commandString, myConnection);
                myConnection.Open();
                OracleDataReader MR;
                MR = myCommand.ExecuteReader();

                ClassDateList.Items.Clear();

                while (MR.Read())
                {
                    ListViewItem item = new ListViewItem(MR[0].ToString());
                    ClassDateList.Items.Add(item);
                }
                MR.Close();
            }
            finally { myConnection.Close(); }
        }

        private void ClassDateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int Lesindex;
                string selectLesNum;

                Lesindex = ClassDateList.FocusedItem.Index;
                selectLesNum = ClassDateList.Items[Lesindex].SubItems[0].Text;

                string commandString = "select 학생학번, 이름, 출석정보 from 출석, 수강, 학생 where 수강.수강코드= '" + cbPfsClass.Text.Substring(0, 10) + "' and to_char(출석.기록일시, 'DL')='" + selectLesNum.Trim() + "' and 출석.수강코드=수강.수강코드 and 학생.학번=출석.학생학번";
                OracleCommand myCommand = new OracleCommand(commandString, myConnection);
                myConnection.Open();
                OracleDataReader MR;
                MR = myCommand.ExecuteReader();

                StdCheckList.Items.Clear();
                
                while (MR.Read())
                {
                    ListViewItem item = new ListViewItem(MR[0].ToString());
                    item.SubItems.Add(MR[1].ToString());
                    item.SubItems.Add(MR[2].ToString());
                    StdCheckList.Items.Add(item);
                }
                MR.Close();
            }
            finally { myConnection.Close(); }
        }
    }
}
