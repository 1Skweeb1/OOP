namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StudentName = new TextBox();
            StudentGroup = new ComboBox();
            AddStudent = new Button();
            OOP = new Label();
            OS = new Label();
            OOPGrade = new NumericUpDown();
            OSGrade = new NumericUpDown();
            SYAPGrade = new NumericUpDown();
            SYAP = new Label();
            VYAP = new Label();
            VYAPGrade = new NumericUpDown();
            DISCRETKAGrade = new NumericUpDown();
            DISKRETKA = new Label();
            FIO = new Label();
            AverageBySubject = new Button();
            AverageByGroup = new Button();
            GetBadStudents = new Button();
            StudentGroup2 = new ComboBox();
            Subjects = new ComboBox();
            Answer1 = new Label();
            Answer2 = new Label();
            Answer3 = new Label();
            StudentsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)OOPGrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OSGrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SYAPGrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VYAPGrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DISCRETKAGrade).BeginInit();
            SuspendLayout();
            // 
            // StudentName
            // 
            StudentName.Location = new Point(76, 17);
            StudentName.Name = "StudentName";
            StudentName.Size = new Size(208, 27);
            StudentName.TabIndex = 0;
            // 
            // StudentGroup
            // 
            StudentGroup.FormattingEnabled = true;
            StudentGroup.Location = new Point(304, 17);
            StudentGroup.Name = "StudentGroup";
            StudentGroup.Size = new Size(68, 28);
            StudentGroup.TabIndex = 2;
            // 
            // AddStudent
            // 
            AddStudent.Location = new Point(24, 152);
            AddStudent.Name = "AddStudent";
            AddStudent.Size = new Size(152, 29);
            AddStudent.TabIndex = 6;
            AddStudent.Text = "Добавить студента";
            AddStudent.UseVisualStyleBackColor = true;
            AddStudent.Click += AddStudent_Click;
            // 
            // OOP
            // 
            OOP.AutoSize = true;
            OOP.Location = new Point(24, 66);
            OOP.Name = "OOP";
            OOP.Size = new Size(46, 20);
            OOP.TabIndex = 7;
            OOP.Text = "OOP :";
            // 
            // OS
            // 
            OS.AutoSize = true;
            OS.Location = new Point(24, 104);
            OS.Name = "OS";
            OS.Size = new Size(35, 20);
            OS.TabIndex = 9;
            OS.Text = "OS :";
            // 
            // OOPGrade
            // 
            OOPGrade.Location = new Point(76, 64);
            OOPGrade.Name = "OOPGrade";
            OOPGrade.Size = new Size(45, 27);
            OOPGrade.TabIndex = 10;
            // 
            // OSGrade
            // 
            OSGrade.Location = new Point(76, 102);
            OSGrade.Name = "OSGrade";
            OSGrade.Size = new Size(45, 27);
            OSGrade.TabIndex = 11;
            // 
            // SYAPGrade
            // 
            SYAPGrade.Location = new Point(191, 64);
            SYAPGrade.Name = "SYAPGrade";
            SYAPGrade.Size = new Size(45, 27);
            SYAPGrade.TabIndex = 13;
            // 
            // SYAP
            // 
            SYAP.AutoSize = true;
            SYAP.Location = new Point(139, 66);
            SYAP.Name = "SYAP";
            SYAP.Size = new Size(49, 20);
            SYAP.TabIndex = 12;
            SYAP.Text = "SYAP :";
            // 
            // VYAP
            // 
            VYAP.AutoSize = true;
            VYAP.Location = new Point(135, 104);
            VYAP.Name = "VYAP";
            VYAP.Size = new Size(50, 20);
            VYAP.TabIndex = 14;
            VYAP.Text = "VYAP :";
            // 
            // VYAPGrade
            // 
            VYAPGrade.Location = new Point(191, 102);
            VYAPGrade.Name = "VYAPGrade";
            VYAPGrade.Size = new Size(45, 27);
            VYAPGrade.TabIndex = 15;
            // 
            // DISCRETKAGrade
            // 
            DISCRETKAGrade.Location = new Point(358, 64);
            DISCRETKAGrade.Name = "DISCRETKAGrade";
            DISCRETKAGrade.Size = new Size(45, 27);
            DISCRETKAGrade.TabIndex = 17;
            // 
            // DISKRETKA
            // 
            DISKRETKA.AutoSize = true;
            DISKRETKA.Location = new Point(260, 66);
            DISKRETKA.Name = "DISKRETKA";
            DISKRETKA.Size = new Size(92, 20);
            DISKRETKA.TabIndex = 16;
            DISKRETKA.Text = "DISCRETKA :";
            // 
            // FIO
            // 
            FIO.AutoSize = true;
            FIO.Location = new Point(24, 20);
            FIO.Name = "FIO";
            FIO.Size = new Size(38, 20);
            FIO.TabIndex = 18;
            FIO.Text = "FIO :";
            // 
            // AverageBySubject
            // 
            AverageBySubject.Location = new Point(24, 252);
            AverageBySubject.Name = "AverageBySubject";
            AverageBySubject.Size = new Size(260, 29);
            AverageBySubject.TabIndex = 19;
            AverageBySubject.Text = "Средний балл по всем предметам";
            AverageBySubject.UseVisualStyleBackColor = true;
            AverageBySubject.Click += AverageBySubject_Click;
            // 
            // AverageByGroup
            // 
            AverageByGroup.Location = new Point(323, 252);
            AverageByGroup.Name = "AverageByGroup";
            AverageByGroup.Size = new Size(260, 29);
            AverageByGroup.TabIndex = 20;
            AverageByGroup.Text = "Средний балл по группе";
            AverageByGroup.UseVisualStyleBackColor = true;
            AverageByGroup.Click += AverageByGroup_Click;
            // 
            // GetBadStudents
            // 
            GetBadStudents.Location = new Point(628, 252);
            GetBadStudents.Name = "GetBadStudents";
            GetBadStudents.Size = new Size(260, 29);
            GetBadStudents.TabIndex = 21;
            GetBadStudents.Text = "Количество студентов с неудом";
            GetBadStudents.UseVisualStyleBackColor = true;
            GetBadStudents.Click += GetBadStudents_Click;
            // 
            // StudentGroup2
            // 
            StudentGroup2.FormattingEnabled = true;
            StudentGroup2.Location = new Point(358, 207);
            StudentGroup2.Name = "StudentGroup2";
            StudentGroup2.Size = new Size(68, 28);
            StudentGroup2.TabIndex = 22;
            // 
            // Subjects
            // 
            Subjects.FormattingEnabled = true;
            Subjects.Location = new Point(656, 207);
            Subjects.Name = "Subjects";
            Subjects.Size = new Size(68, 28);
            Subjects.TabIndex = 23;
            // 
            // Answer1
            // 
            Answer1.Location = new Point(27, 303);
            Answer1.Name = "Answer1";
            Answer1.Size = new Size(257, 193);
            Answer1.TabIndex = 24;
            // 
            // Answer2
            // 
            Answer2.Location = new Point(333, 303);
            Answer2.Name = "Answer2";
            Answer2.Size = new Size(250, 329);
            Answer2.TabIndex = 25;
            // 
            // Answer3
            // 
            Answer3.Location = new Point(628, 294);
            Answer3.Name = "Answer3";
            Answer3.Size = new Size(260, 202);
            Answer3.TabIndex = 26;
            // 
            // StudentsLabel
            // 
            StudentsLabel.Location = new Point(911, 20);
            StudentsLabel.Name = "StudentsLabel";
            StudentsLabel.Size = new Size(471, 653);
            StudentsLabel.TabIndex = 27;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1394, 682);
            Controls.Add(StudentsLabel);
            Controls.Add(Answer3);
            Controls.Add(Answer2);
            Controls.Add(Answer1);
            Controls.Add(Subjects);
            Controls.Add(StudentGroup2);
            Controls.Add(GetBadStudents);
            Controls.Add(AverageByGroup);
            Controls.Add(AverageBySubject);
            Controls.Add(FIO);
            Controls.Add(DISCRETKAGrade);
            Controls.Add(DISKRETKA);
            Controls.Add(VYAPGrade);
            Controls.Add(VYAP);
            Controls.Add(SYAPGrade);
            Controls.Add(SYAP);
            Controls.Add(OSGrade);
            Controls.Add(OOPGrade);
            Controls.Add(OS);
            Controls.Add(OOP);
            Controls.Add(AddStudent);
            Controls.Add(StudentGroup);
            Controls.Add(StudentName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)OOPGrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)OSGrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)SYAPGrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)VYAPGrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)DISCRETKAGrade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox StudentName;
        public ComboBox StudentGroup;
        public Button AddStudent;
        private Label OOP;
        private Label OS;
        private NumericUpDown OOPGrade;
        private NumericUpDown OSGrade;
        private NumericUpDown SYAPGrade;
        private Label SYAP;
        private Label VYAP;
        private NumericUpDown VYAPGrade;
        private NumericUpDown DISCRETKAGrade;
        private Label DISKRETKA;
        private Label FIO;
        public Button AverageBySubject;
        public Button AverageByGroup;
        public Button GetBadStudents;
        public ComboBox StudentGroup2;
        public ComboBox Subjects;
        private Label Answer1;
        public Label Answer2;
        public Label Answer3;
        public Label StudentsLabel;
    }
}
