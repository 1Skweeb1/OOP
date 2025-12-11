using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ClassLibrary;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private FigureManager manager = new FigureManager();

        public Form1()
        {
            InitializeComponent();

            listBoxFigures.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxFigures.DrawItem += ListBoxFigures_DrawItem;

        }

        private void RefreshListBox()
        {
            listBoxFigures.Items.Clear();
            var infos = manager.GetFiguresInfo();
            foreach (var item in infos)
                listBoxFigures.Items.Add(new ListBoxItem(item.info, item.color));
        }

        private void ListBoxFigures_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            var item = (ListBoxItem)listBoxFigures.Items[e.Index];
            string text = item.Text;
            string colorName = item.ColorName;

            Color brushColor = Color.Black;
            if (!string.IsNullOrEmpty(colorName))
            {
                try { brushColor = Color.FromName(colorName); } catch { }
            }

            e.DrawBackground();
            using (SolidBrush brush = new SolidBrush(brushColor))
                e.Graphics.DrawString(text, e.Font, brush, e.Bounds);
            e.DrawFocusRectangle();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    manager.LoadFromFile(ofd.FileName);
                    RefreshListBox();
                }
            }
        }

        private void BtnSortByArea_Click(object sender, EventArgs e)
        {
            listBoxFigures.Items.Clear();
            var sorted = manager.GetFiguresSortedByArea();
            foreach (var f in sorted)
            {
                string color = (f is Circle c) ? c.Color : null;
                listBoxFigures.Items.Add(new ListBoxItem(f.GetInfo(), color));
            }
        }

        private void BtnPerimeters_Click(object sender, EventArgs e)
        {
            listBoxFigures.Items.Clear();

            var squares = manager.Figures.OfType<Square>();
            int count = 1;

            foreach (var square in squares)
            {
                if (!square.IsInOneTerm())
                {
                    string text = $"{square.GetInfo()}; Perimeter: {square.GetPerimeter():0.##}";
                    listBoxFigures.Items.Add(new ListBoxItem(text));
                    count++;
                }
            }
        }

        private void BtnCircleLengths_Click(object sender, EventArgs e)
        {
            listBoxFigures.Items.Clear();

            var circles = manager.Figures.OfType<Circle>();

            var sortedCircles = new List<Circle>(circles);
            sortedCircles.Sort((c1, c2) => c2.CircleLength().CompareTo(c1.CircleLength()));

            // Выводим информацию полностью + длина
            int count = 1;
            foreach (var circle in sortedCircles)
            {
                string text = $"{circle.GetInfo()}; Length: {circle.CircleLength():0.##}";
                listBoxFigures.Items.Add(new ListBoxItem(text, circle.Color));
                count++;
            }
        }

    }
}
