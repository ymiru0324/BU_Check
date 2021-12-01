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
    public partial class Student_Main_출석체크 : Form
    {
        // 2018-12-07 김현우 작성
        Student_Main _parent;
        string SubjectCode;
        string StartTime;
        string EndTime;
        string Check;
        DateTime checktime;

        static string connectionString = "User Id=projectcheck; Password=check; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.141.55)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
        OracleConnection myConnection = new OracleConnection(connectionString);

        public Student_Main_출석체크(Student_Main inform1)
        {
            InitializeComponent();
            _parent = inform1;
        }

        private void Student_Main_출석체크_Load(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString("yy-MM-dd (ddd) tt hh:mm:ss");
            _parent.NOSubject = true;

            string commandString = "select 수강목록.수강코드, 과목.교과목명, 교수.이름, 수강.시작시간, 수강.마침시간 from 수강목록, 수강, 과목, 교수, 학생 where 수강목록.학번 = '" + _parent.StdNum.Trim() + "' and 수강.요일 = '" + DateTime.Now.ToString("ddd") + "' and 수강.시작시간 <= '" + DateTime.Now.AddMinutes(10).ToString("HH:mm") + "' and 수강.마침시간 >= '" + DateTime.Now.AddMinutes(0).ToString("HH:mm") + "' and 수강.과목코드 = 과목.과목코드 and 과목.지도교수코드 = 교수.교직원번호 and 수강.수강코드 = 수강목록.수강코드 and 수강목록.학번 = 학생.학번";
            OracleCommand myCommand = new OracleCommand(commandString, myConnection);
            myConnection.Open();
            OracleDataReader MR;
            MR = myCommand.ExecuteReader();
            while (MR.Read())
            {
                SubjectCode = MR[0].ToString();
                txtClass.Text = MR[1].ToString();
                txtPfsName.Text = (MR[2].ToString());
                StartTime = (MR[3].ToString());
                EndTime = (MR[4].ToString());
                _parent.NOSubject = false;
            }

            if (_parent.NOSubject)
            {
                txtClass.Text = "수업이 없습니다.";
                txtPfsName.Text = "수업이 없으니 교수님도 안계시지";
            }

            MR.Close();
            myConnection.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                _parent.NOSubject = true;
                myConnection.Open();
                timer1.Start();
                txtTime.Text = DateTime.Now.ToString("yy-MM-dd (ddd) tt hh:mm:ss");

                string commandString = "select 수강목록.수강코드, 과목.교과목명, 교수.이름, 수강.시작시간, 수강.마침시간 from 수강목록, 수강, 과목, 교수, 학생 where 수강목록.학번 = '" + _parent.StdNum.Trim() + "' and 수강.요일 = '" + DateTime.Now.ToString("ddd") + "' and 수강.시작시간 <= '" + DateTime.Now.AddMinutes(10).ToString("HH:mm") + "' and 수강.마침시간 >= '" + DateTime.Now.AddMinutes(0).ToString("HH:mm") + "' and 수강.과목코드 = 과목.과목코드 and 과목.지도교수코드 = 교수.교직원번호 and 수강.수강코드 = 수강목록.수강코드 and 수강목록.학번 = 학생.학번";
                OracleCommand myCommand = new OracleCommand(commandString, myConnection);
                OracleDataReader MR;
                MR = myCommand.ExecuteReader();
                while (MR.Read())
                {
                    SubjectCode = MR[0].ToString().Trim();
                    txtClass.Text = MR[1].ToString().Trim();
                    txtPfsName.Text = (MR[2].ToString().Trim());
                    StartTime = (MR[3].ToString().Trim());
                    EndTime = (MR[4].ToString().Trim());
                    _parent.NOSubject = false;
                }
                MR.Close();
                myConnection.Close();

                if (_parent.NOSubject)
                {
                    txtClass.Text = "수업이 없습니다.";
                    txtPfsName.Text = "수업이 없으니 교수님도 안계시지";
                }
                else
                {
                    if (!_parent.complite)
                    {
                        DateTime.TryParse(EndTime, out checktime);
                        int absence = DateTime.Compare(DateTime.Now, checktime);
                        if (absence == 0)
                        {
                            Check = "결석";
                            myConnection.Open();
                            commandString = "insert into 출석 (수강코드, 학생학번, 기록일시, 출석정보) values ('" + SubjectCode.Trim() + "', '" + _parent.StdNum.Trim() + "', '" + DateTime.Now.ToString("yy-MM-dd") + "', '" + Check.Trim() + "')";
                            myCommand = new OracleCommand(commandString, myConnection);
                            myCommand.ExecuteNonQuery();

                            commandString = "update 성적 set 성적.출석 = 성적.출석 - 3 where 성적.수강코드 = '" + SubjectCode.Trim() + "' and 성적.학생학번 = '" + _parent.StdNum.Trim() + "'";
                            myCommand.ExecuteNonQuery();

                            myConnection.Close();
                            _parent.complite = true;
                        }
                    }
                }
            }
            catch (DataException DE)
            {
                myConnection.Close();
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                myConnection.Close();
                MessageBox.Show(DE.Message);
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtClass.Text == "수업이 없습니다.")
                {
                    _parent.NOSubject = true;
                    MessageBox.Show("출석가능한 과목이 없습니다.");
                }
                if (!_parent.NOSubject && !_parent.complite)
                {
                    DateTime.TryParse(StartTime, out checktime);
                    int check = DateTime.Compare(DateTime.Now.AddMinutes(-10), checktime);
                    if (check > 0)
                    {
                        Check = "지각";
                        myConnection.Open();
                        string commandString = "insert into 출석 (수강코드, 학생학번, 기록일시, 출석정보) values ('" + SubjectCode.Trim() + "', '" + _parent.StdNum.Trim() + "', '" + DateTime.Now.ToString("yy-MM-dd") + "', '" + Check.Trim() + "')";
                        OracleCommand myCommand = new OracleCommand(commandString, myConnection);
                        myCommand.ExecuteNonQuery();

                        commandString = "update 성적 set 성적.출석 = 성적.출석 - 1 where 성적.수강코드 = '" + SubjectCode.Trim() + "' and 성적.학생학번 = '" + _parent.StdNum.Trim()  + "'";
                        OracleCommand myCommand2 = new OracleCommand(commandString, myConnection);
                        myCommand2.ExecuteNonQuery();

                        myConnection.Close();
                        MessageBox.Show("지각 처리 되었습니다.", "처리완료", MessageBoxButtons.OK);
                        _parent.complite = true;
                        this.Close();
                    }
                    else if (check < 0)
                    {
                        Check = "출석";
                        myConnection.Open();
                        string commandString = "insert into 출석 (수강코드, 학생학번, 기록일시, 출석정보) values ('" + SubjectCode.Trim() + "', '" + _parent.StdNum.Trim() + "', '" + DateTime.Now.ToString("yy-MM-dd") + "', '" + Check.Trim() + "')";
                        OracleCommand myCommand = new OracleCommand(commandString, myConnection);
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();
                        MessageBox.Show("출석 처리 되었습니다.", "처리완료", MessageBoxButtons.OK);
                        _parent.complite = true;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("이미 출결 완료한 수업입니다.", "오류", MessageBoxButtons.OK);
                }
            }
            catch (DataException DE)
            {
                myConnection.Close();
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                myConnection.Close();
                MessageBox.Show(DE.Message);
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                }
            }
        }
    }
}