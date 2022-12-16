using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SqlExample.Form1;
using static System.Windows.Forms.ListBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SqlExample;

public partial class Delete : Form
{
    public string conStr = "Server=192.168.88.30;" +
    "Database=University;User Id=root;Password=root;";
    public string CmdDelete = "DELETE FROM Students WHERE id = @id";

    private SqlConnection con = new();
    private ListBox list;

    public Delete(ListBox list)
    {
        InitializeComponent();

        this.list = list;

        con = new SqlConnection(conStr);
        con.Open();

        GetStudentsList();
    }

    private void DeleteButton_Click(object sender, EventArgs e)
    {
        Student student = (Student)ChooseList.SelectedItem;

        SqlCommand command = new(CmdDelete, con);

        SqlParameter idParam = new("@id", student.id);

        command.Parameters.Add(idParam);

        if (command.ExecuteNonQuery() > 0)
        {
            MessageBox.Show("Удаление прошло успешно!");
        }

        GetStudentsList();
    }
    private void GetStudentsList()
    {
        ChooseList.Items.Clear();
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

                    ChooseList.Items.Add(student);
                    list.Items.Add(student);
                }
            }
        }
    }

}
