using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;

namespace SqlExample;

public partial class Form1 : Form
{
    public SqlConnection con;
    public string conStr = "Server=192.168.88.30;" +
    "Database=University;User Id=root;Password=root;";

    public string cmdSelectStudents = "SELECT * FROM Students";
    public class Student
    {
        public int id;
        public string name;
        public int groupId;
        public int grade;

        public override string ToString()
        {
            return "Имя: " + name + ", оценка: " + grade;
        }
    }

    public Form1()
    {
        InitializeComponent();

        con = new SqlConnection(conStr);
        con.Open();

        GetStudentsList();
    }
    ~Form1()
    {
        con.Close();
    }

    private void ExitBtn_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    private void GetStudentsList()
    {
        list.Items.Clear();

        SqlCommand command = new(cmdSelectStudents, con);
        using (SqlDataReader reader = command.ExecuteReader())
        {
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Student student = new Student
                    {
                        id = reader.GetInt32(0),
                        name = reader.GetString(1).Trim(),
                        groupId = reader.GetInt32(2),
                        grade = reader.GetInt32(3)
                    };

                    list.Items.Add(student);
                }
            }
        }
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        Insert insert = new(list);
        insert.Show();
    }

    private void DeleteButton_Click(object sender, EventArgs e)
    {
        Delete delete = new(list);
        delete.Show();
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        Update update = new(list);
        update.Show();
    }
}