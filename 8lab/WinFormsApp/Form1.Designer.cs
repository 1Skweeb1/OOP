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
            listBoxFigures = new ListBox();
            btnLoad = new Button();
            btnSortByArea = new Button();
            btnPerimeters = new Button();
            btnCircleLengths = new Button();
            SuspendLayout();
            // 
            // listBoxFigures
            // 
            listBoxFigures.FormattingEnabled = true;
            listBoxFigures.Location = new Point(296, 127);
            listBoxFigures.Name = "listBoxFigures";
            listBoxFigures.Size = new Size(603, 464);
            listBoxFigures.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(36, 22);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(128, 52);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Загрузить";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += BtnLoad_Click;
            // 
            // btnSortByArea
            // 
            btnSortByArea.Location = new Point(185, 24);
            btnSortByArea.Name = "btnSortByArea";
            btnSortByArea.Size = new Size(162, 59);
            btnSortByArea.TabIndex = 2;
            btnSortByArea.Text = "Сорт по площади";
            btnSortByArea.UseVisualStyleBackColor = true;
            btnSortByArea.Click += BtnSortByArea_Click;
            // 
            // btnPerimeters
            // 
            btnPerimeters.Location = new Point(353, 20);
            btnPerimeters.Name = "btnPerimeters";
            btnPerimeters.Size = new Size(194, 59);
            btnPerimeters.TabIndex = 3;
            btnPerimeters.Text = "Периметры квадратов в нескольких четвертях";
            btnPerimeters.UseVisualStyleBackColor = true;
            btnPerimeters.Click += BtnPerimeters_Click;
            // 
            // btnCircleLengths
            // 
            btnCircleLengths.Location = new Point(570, 22);
            btnCircleLengths.Name = "btnCircleLengths";
            btnCircleLengths.Size = new Size(233, 62);
            btnCircleLengths.TabIndex = 4;
            btnCircleLengths.Text = "Длины окружностей по убыванию";
            btnCircleLengths.UseVisualStyleBackColor = true;
            btnCircleLengths.Click += BtnCircleLengths_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1429, 660);
            Controls.Add(btnCircleLengths);
            Controls.Add(btnPerimeters);
            Controls.Add(btnSortByArea);
            Controls.Add(btnLoad);
            Controls.Add(listBoxFigures);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxFigures;
        private Button btnLoad;
        private Button btnSortByArea;
        private Button btnPerimeters;
        private Button btnCircleLengths;
    }
}
