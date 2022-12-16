namespace SqlExample
{
    partial class Update
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddButton = new System.Windows.Forms.Button();
            this.GradeBox = new System.Windows.Forms.TextBox();
            this.GroupIdBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChooseList = new System.Windows.Forms.ListBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 336);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(281, 33);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Обновить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // GradeBox
            // 
            this.GradeBox.Location = new System.Drawing.Point(82, 70);
            this.GradeBox.Name = "GradeBox";
            this.GradeBox.Size = new System.Drawing.Size(210, 23);
            this.GradeBox.TabIndex = 6;
            // 
            // GroupIdBox
            // 
            this.GroupIdBox.Location = new System.Drawing.Point(82, 41);
            this.GroupIdBox.Name = "GroupIdBox";
            this.GroupIdBox.Size = new System.Drawing.Size(210, 23);
            this.GroupIdBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID группы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Оценка:";
            // 
            // ChooseList
            // 
            this.ChooseList.FormattingEnabled = true;
            this.ChooseList.ItemHeight = 15;
            this.ChooseList.Location = new System.Drawing.Point(12, 101);
            this.ChooseList.Name = "ChooseList";
            this.ChooseList.Size = new System.Drawing.Size(280, 229);
            this.ChooseList.TabIndex = 10;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(82, 12);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(210, 23);
            this.NameBox.TabIndex = 7;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 379);
            this.Controls.Add(this.ChooseList);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.GradeBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.GroupIdBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Update";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddButton;
        private TextBox GradeBox;
        private TextBox GroupIdBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox ChooseList;
        private TextBox NameBox;
    }
}