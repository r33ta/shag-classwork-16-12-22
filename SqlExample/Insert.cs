using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Xml.Linq;
using static SqlExample.Form1;

namespace SqlExample;

public partial class Insert : Form
{
    private string CmdInsert = "INSERT INTO Students(name, groupId, grade) VALUES(@name, @groupId, @grade)";
    public string conStr = "Server=192.168.88.30;" +
    "Database=University;User Id=root;Password=root;";

    private SqlConnection con = new();
    private ListBox list;

    public Insert(ListBox list)
    {
        InitializeComponent();
        this.list = list;

        con = new SqlConnection(conStr);
        con.Open();
    }
    ~Insert()
    {
        con.Close();
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        SqlCommand command = new(CmdInsert, con);

        SqlParameter nameParam = new("@name", NameBox.Text);
        SqlParameter groupIdParam = new("@groupId", GroupIdBox.Text);
        SqlParameter gradeParam = new("@grade", GradeBox.Text);

        command.Parameters.Add(nameParam);
        command.Parameters.Add(groupIdParam);
        command.Parameters.Add(gradeParam);

        if (command.ExecuteNonQuery() > 0)
        {
            MessageBox.Show("Вставка успешна!");
        }

        GetStudentsList();
    }

    private void GetStudentsList()
    {
        list.Items.Clear();

        SqlCommand command = new("SELECT * FROM Students", con);
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
}
