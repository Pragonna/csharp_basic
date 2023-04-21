using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;
using System.Data;
using System.Configuration;

namespace CourseManagmentRepair
{
    public partial class CourseManagment : Form
    {
        const string Database = @" Data Source=PRAGONNA\SQLEXPRESS;Initial Catalog = CourseManagementDB; Integrated Security = True;Encrypt=False";
        SqlConnection conn = new SqlConnection(Database);
        public CourseManagment()
        {
            InitializeComponent();
            CourseIntoCmb();
            DataGridViewFill();
        }
        private void Clear_Text()
        {
            txtName_S.Clear();
            txtSurname_S.Clear();
        }
        #region Course Syncronize to ComboBox
        private void CourseIntoCmb()
        {
            foreach (var c in Course)
            {
                cmbCourse.Items.Add(c.Name);
            }
        }
        #endregion
        #region COURSE LIST
        public List<Course> Course
        {
            get
            {
                var courses = new List<Course>();
                var cmd = new SqlCommand("SELECT Id,CourseName,StartDate,EndDate,Duration,StudentCount FROM tblCourse", conn);
                conn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var course = new Course
                    {
                        CourseId = dr.GetInt32(0),
                        Name = dr.GetString(1),
                        StartDate = dr.GetDateTime(2),
                        EndDate = dr.GetDateTime(3),
                        Duration = dr.GetInt32(4),
                        StudentCount = dr.GetInt32(5)
                    };
                    courses.Add(course);
                }
                conn.Close();
                return courses;
            }
        }
        #endregion
        #region STUDENT LIST
        public List<Student> Student
        {
            get
            {
                var students = new List<Student>();
                var cmd = new SqlCommand("SELECT Id,Name,Surname,BirthDate,StartDate,EndDate,CourseId,Progress FROM tblStudent", conn);
                conn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var student = new Student
                    {
                        Id = dr.GetInt32(0),
                        Name = dr.GetString(1),
                        Surname = dr.GetString(2),
                        DateOfBirth = dr.GetDateTime(3),
                        StartDate = dr.GetDateTime(4),
                        EndDate = dr.GetDateTime(5),
                        CourseId = dr.GetInt32(6),
                        Progress = dr.GetString(7)
                    };
                    students.Add(student);
                }
                conn.Close();
                return students;
            }
        }
        #endregion
        #region TEACHER LIST
        public List<Teacher> Teacher
        {
            get
            {
                var teachers = new List<Teacher>();
                var cmd = new SqlCommand("SELECT Id,TeacherName,TeacherSurname,BirthDate,ProfessionId,Profession FROM tblTeacher", conn);
                conn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var teacher = new Teacher
                    {
                        Id = dr.GetInt32(0),
                        Name = dr.GetString(1),
                        Surname = dr.GetString(2),
                        DateOfBirth = dr.GetDateTime(3),
                        CourseId = dr.GetInt32(4),
                        Profession = dr.GetString(5)
                    };
                    teachers.Add(teacher);
                }
                conn.Close();
                return teachers;
            }
        }
        #endregion
        #region DataGridViewFill
        private void DataGridViewFill()
        {
            var cmd = new SqlCommand("select s.Id,s.Name,s.Surname,s.BirthDate,c.CourseName,c.StartDate,c.EndDate,t.TeacherName,t.TeacherSurname,s.Progress from tblManagment mg join tblStudent s on mg.StudentId=s.Id join tblCourse c on mg.CourseId=c.Id join tblTeacher t on mg.TeacherId=t.Id", conn);
            var da = new SqlDataAdapter(cmd);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView_Managment.DataSource = ds.Tables[0];
            //label_ID_S.Text = (Student[Student.Count - 1].Id+1).ToString();
        }
        #endregion
        private void CourseManagment_Load(object sender, EventArgs e)
        {
            DataGridViewFill();
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            DataGridViewFill();
        }
        #region ADD (STUDENT)
        private void btnAdd_S_Click(object sender, EventArgs e)
        {
            string progress = string.Empty;
            try
            {
                var filteredCourse = Course.Where(c => c.Name == cmbCourse.Text).ToList();
                var filteredStudent = Student.Where(s => s.CourseId == filteredCourse[0].CourseId).ToList();
                var filteredTeacher = Teacher.Where(t => t.CourseId == filteredCourse[0].CourseId).ToList();

                var cmd = new SqlCommand("INSERT INTO tblStudent(Name,Surname,BirthDate,CourseId,StartDate,EndDate,Progress)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", conn);
                cmd.Parameters.AddWithValue("@p1", txtName_S.Text);
                cmd.Parameters.AddWithValue("@p2", txtSurname_S.Text);
                cmd.Parameters.AddWithValue("@p3", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@p4", filteredCourse[0].CourseId);
                cmd.Parameters.AddWithValue("@p5", filteredCourse[0].StartDate);
                cmd.Parameters.AddWithValue("@p6", filteredCourse[0].EndDate);

                if (filteredStudent.Count + 1 == filteredCourse[0].StudentCount)
                {
                    progress = "Started..";
                    SetDate(ref filteredCourse);
                }
                else if (filteredStudent.Count < filteredCourse[0].StudentCount)
                    progress = $"{filteredStudent.Count + 1}/{filteredCourse[0].StudentCount}";
                else
                {
                    MessageBox.Show("Course is full");
                    return;
                }
                cmd.Parameters.AddWithValue("@p7", progress);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Added");

                int cId = filteredCourse[0].CourseId,
                    sId = Student[Student.Count - 1].Id,
                    tId = filteredTeacher[0].CourseId;
                InsertIntoManagment(ref cId, ref sId, ref tId);
                DataGridViewFill();
                Clear_Text();
            }
            catch
            {
                MessageBox.Show("Please fill all the line");
                return;
            }
        }
        #endregion
        #region Course SET data
        private void SetDate(ref List<Course> filteredCourse)
        {
            var cmd = new SqlCommand("update tblCourse set StartDate=@p1 ,EndDate=@p2 where Id=@p3", conn);
            cmd.Parameters.AddWithValue("@p1", DateTime.Now);
            cmd.Parameters.AddWithValue("@p2", DateTime.Now.AddMonths(filteredCourse[0].Duration));
            cmd.Parameters.AddWithValue("@p3", filteredCourse[0].CourseId);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        #endregion
        #region Insert into Managment
        private void InsertIntoManagment(ref int cId, ref int sId, ref int tId)
        {
            var cmd = new SqlCommand("insert into tblManagment(CourseId,StudentId,TeacherId)values(@p1,@p2,@p3)", conn);
            cmd.Parameters.AddWithValue("@p1", cId);
            cmd.Parameters.AddWithValue("@p2", sId);
            cmd.Parameters.AddWithValue("@p3", tId);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        #endregion
        #region UPDATE (STUDENT)
        private void btnUpdate_S_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(label_ID_S.Text);
            int temp = 0;
           // int idForUpdateProgress = 0;
            foreach (var s in Student)

            {
                if (s.Id == id)
                {
                    temp++;
                    //idForUpdateProgress = s.Id;
                }
            }
            if (temp == 0)
            {
                MessageBox.Show("Student doesnt exist");
                return;
            }
            //UpdateProgress(ref idForUpdateProgress);
            var cmd = new SqlCommand("Update  tblStudent set Name=@p2,Surname=@p3,BirthDate=@p4 where Id=@p1", conn);
            cmd.Parameters.AddWithValue("@p1", id);
            cmd.Parameters.AddWithValue("@p2", txtName_S.Text);
            cmd.Parameters.AddWithValue("@p3", txtSurname_S.Text);
            cmd.Parameters.AddWithValue("@p4", dateTimePicker1.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Student`s information updated.");
            Clear_Text();
            DataGridViewFill();
        }
        #endregion
        #region UPDATE PROGRESS
        private void UpdateProgress(ref int idForUpdateProgress)
        {
            int temp = 1;
            var filterCourse = new List<Course>();
            int id = idForUpdateProgress;
            
            var filteredStudent = Student.Where(s => s.Id == id).ToList();
            filterCourse = Course.Where(c => filteredStudent[0].CourseId == c.CourseId).ToList();
            foreach (var s in Student)
            {
                if (s.CourseId == filterCourse[0].CourseId)
                {
                    var progress = temp>1?$"{temp-1}/{filterCourse[0].StudentCount}": $"{temp}/{filterCourse[0].StudentCount}";
                    var cmd = new SqlCommand("update tblStudent set Progress=@p1 where Id=@p2", conn);
                    cmd.Parameters.AddWithValue("@p1", progress);
                    cmd.Parameters.AddWithValue("@p2", s.Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    temp++; ;
                }
            }
        }
        #endregion
        #region DELETE(STUDENT)
        private void btnDelete_S_Click(object sender, EventArgs e)
        {
            var dialogResult=MessageBox.Show("Are You sure?", "Delete Student", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
                return;
            try
            {
                int id = Convert.ToInt32(label_ID_S.Text);
                int temp = 0;
                int idForUpdateProgress = 0;
                foreach (var s in Student)
                
                {
                    if (s.Id == id)
                    {
                        temp++;
                        idForUpdateProgress = s.Id;
                    }
                }
                if (temp == 0)
                {
                    MessageBox.Show("Student doesnt exist");
                    return;
                }
                UpdateProgress(ref idForUpdateProgress);
                var cmd = new SqlCommand("DELETE FROM tblStudent where Id=@p1", conn);
                cmd.Parameters.AddWithValue("@p1", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                DeleteIntoManagment(ref id);
                MessageBox.Show("Student has been deleted.");
                Clear_Text();

            }
            catch
            {
                MessageBox.Show("Please select Student in the rows");
                return;
            }
            DataGridViewFill();
        }
        private void DeleteIntoManagment(ref int id)
        {
            var cmd = new SqlCommand("delete from tblManagment where StudentId=@p1", conn);
            cmd.Parameters.AddWithValue("@p1", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        #endregion
        #region  DataGrid SelectedCells in the rows
        private void dataGridView_Managment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView_Managment.SelectedCells[0].RowIndex;
            label_ID_S.Text = dataGridView_Managment.Rows[i].Cells[0].Value.ToString();
            txtName_S.Text = dataGridView_Managment.Rows[i].Cells[1].Value.ToString();
            txtSurname_S.Text = dataGridView_Managment.Rows[i].Cells[2].Value.ToString();
        }
        #endregion
    }

    interface ICourseDate
    {
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
    }
    public abstract class CourseManager
    {
        abstract public int CourseId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
    public class Student : CourseManager, ICourseDate
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public override int CourseId { get; set; }
        public string Description { get; set; }
        public string Progress { get; set; }

    }
    public class Teacher : CourseManager
    {
        public int Id { get; set; }
        public string Profession { get; set; }
        public override int CourseId { get; set; }
    }
    public class Course : CourseManager, ICourseDate
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public override int CourseId { get; set; }
        public int Duration { get; set; }
        public int StudentCount { get; set; }

    }
}