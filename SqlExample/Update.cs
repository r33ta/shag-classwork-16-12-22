using System.Data.SqlClient;
using static SqlExample.Form1;


/*
Задание: 

Написать приложение Windows Forms с несколькими формами:
1. Первая форма содержит три кнопки для перехода к остальным формам и список со студентами из таблицы Students.
2. Вторая форма содержит необходимые элементы для добавления студента в таблицу Students
3. Третья форма содержит необходимые элементы для удаления студента из таблицы Students
4. Четвертая форма содержит необходимые элементы для обновления студента в таблице Students

Получить студентов из таблицы
SELECT * FROM Students

Вставить студента в таблицу
INSERT INTO Students(name, groupId, grade) VALUES('Иван', 2, 3)

Удалить студента из таблицы
DELETE FROM Students WHERE id = 2

Обновить студента в таблице
UPDATE Students SET name = 'Петр', groupId = 2, grade = 2 WHERE id = 5
 */

namespace SqlExample;

public partial class Update : Form
{

    public string conStr = "Server=192.168.88.30;" +
"Database=University;User Id=root;Password=root;";
    public string CmdUpdate = "UPDATE Students set name = @name, groupId = @groupId, grade = @grade " +
        "WHERE id = @id";

    private SqlConnection con = new();
    private ListBox list;

    public Update(ListBox list)
    {
        InitializeComponent();

        this.list = list;

        con = new SqlConnection(conStr);
        con.Open();

        GetStudentsList();
    }
    ~Update()
    {
        con.Close();
    }
    private void UpdateButton_Click(object sender, EventArgs e)
    {
        Student student = (Student)ChooseList.SelectedItem;

        SqlCommand command = new(CmdUpdate, con);

        SqlParameter nameParam = new("@name", NameBox.Text);
        SqlParameter groupIdParam = new("@groupId", GroupIdBox.Text);
        SqlParameter gradeParam = new("@grade", GradeBox.Text);
        SqlParameter idParam = new("@id", student.id);

        command.Parameters.Add(nameParam);
        command.Parameters.Add(groupIdParam);
        command.Parameters.Add(gradeParam);
        command.Parameters.Add(idParam);

        if (command.ExecuteNonQuery() > 0)
        {
            MessageBox.Show("Обновление прошло успешно!");
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
