using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using ClassLibrary;

namespace SimpleDemo
{
    public partial class MainWindow : Window
    {
        private List<Cloth> Clothes = new List<Cloth>();
        private List<Costume> Costumes = new List<Costume>();
        private ClothManager manager = new ClothManager();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddCloth_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtOutput.Clear();

                Gender gender = (Gender)Enum.Parse(typeof(Gender), ((ComboBoxItem)SelectGender.SelectedItem).Content.ToString());
                FabricType fabric = (FabricType)Enum.Parse(typeof(FabricType), ((ComboBoxItem)SelectFabricType.SelectedItem).Content.ToString());
                ClothType type = (ClothType)Enum.Parse(typeof(ClothType), ((ComboBoxItem)SelectClothType.SelectedItem).Content.ToString());

                int height = int.Parse(SelectHeight.Text);
                int width = int.Parse(SelectWidth.Text);
                string color = SelectColor.Text;

                Cloth cloth = null;

                switch (type)
                {
                    case ClothType.Trousers:
                        cloth = new Trousers(gender, height, width, fabric, color, true);
                        break;

                    case ClothType.Skirt:
                        cloth = new Skirt(gender, height, width, fabric, color, "Classic");
                        break;

                    case ClothType.Coat:
                        cloth = new Coat(gender, height, width, fabric, color, 3);
                        break;
                }

                Clothes.Add(cloth);
                txtOutput.Text = "Одежда добавлена.\n";
            }
            catch (Exception ex)
            {
                txtOutput.Text = ex.Message;
            }
        }

        private void btnAddCostume_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Clear();
            try
            {
                int topIndex = int.Parse(SelectTopOfCostume.Text);
                int bottomIndex = int.Parse(SelectBottomOfCostume.Text);

                if (topIndex < 0 || topIndex >= Clothes.Count ||
                    bottomIndex < 0 || bottomIndex >= Clothes.Count)
                {
                    txtOutput.Text = "Неверные индексы.";
                    return;
                }

                Cloth top = Clothes[topIndex];
                Cloth bottom = Clothes[bottomIndex];

                Costume costume = null;

                if (top is Coat && bottom is Skirt)
                {
                    costume = new Costume((Coat)top, (Skirt)bottom);
                }
                else if (top is Coat && bottom is Trousers)
                {
                    costume = new Costume((Coat)top, (Trousers)bottom);
                }
                else
                {
                    txtOutput.Text = "Костюм может быть только: Пальто + Юбка или Пальто + Брюки.";
                    return;
                }

                Costumes.Add(costume);
                txtOutput.Text = "Костюм добавлен.\n";
            }
            catch (Exception ex)
            {
                txtOutput.Text = ex.Message;
            }
        }

        private void BtnShowAll_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Clear();
            var btn = sender as FrameworkElement;

            switch (btn.Name)
            {
                case "btnShowAll":
                    ShowAllClothes();
                    break;

                case "btnShowCostumes":
                    ShowCostumes();
                    break;

                case "btnShowTrousers":
                    ShowRedTrousers();
                    break;

                case "btnShowAllCount":
                    ShowCountByGender();
                    break;
            }
        }

        private void ShowAllClothes()
        {
            txtOutput.Text += "ВСЯ ОДЕЖДА:\n";

            for (int i = 0; i < Clothes.Count; i++)
            {
                var c = Clothes[i];

                txtOutput.Text +=
                    $"{i}. {c.GetType().Name}, Gender={c.Gender}, Fabric={c.FabricType}, " +
                    $"Color={c.Color}, Size={c.Height}x{c.Width}\n";
            }
        }

        private void ShowCostumes()
        {
            txtOutput.Text += "ВСЕ КОСТЮМЫ:\n";

            foreach (var c in Costumes)
            {
                txtOutput.Text += $"Костюм ({c.Coat.Gender}): Coat={c.Coat.Color}, ";

                if (c.Trousers != null)
                    txtOutput.Text += $"Trousers={c.Trousers.Color}\n";
                else
                    txtOutput.Text += $"Skirt={c.Skirt.Color}\n";
            }

            txtOutput.Text += "\nЖЕНСКИЕ КОСТЮМЫ:\n";
            foreach (Costume c in Costumes)
            {
                if(c.Coat.Gender == Gender.Female || c.Coat.Gender == Gender.MaleAndFemale)
                {
                    txtOutput.Text += $"Костюм ({c.Coat.Gender}): Coat={c.Coat.Color}, ";

                    if (c.Trousers != null)
                        txtOutput.Text += $"Trousers={c.Trousers.Color}\n";
                    else
                        txtOutput.Text += $"Skirt={c.Skirt.Color}\n";
                }
               
            }

            txtOutput.Text += "\nМУЖСКИЕ КОСТЮМЫ:\n";
            foreach (Costume c in Costumes)
            {
                if (c.Coat.Gender == Gender.Male || c.Coat.Gender == Gender.MaleAndFemale)
                {
                    txtOutput.Text += $"Костюм ({c.Coat.Gender}): Coat={c.Coat.Color}, ";

                    if (c.Trousers != null)
                        txtOutput.Text += $"Trousers={c.Trousers.Color}\n";
                    else
                        txtOutput.Text += $"Skirt={c.Skirt.Color}\n";
                }
            }

            txtOutput.Text += "\nЖЕНСКИЕ С БРЮКАМИ:\n";
            foreach (var c in manager.GetFemaleCostumesWithTrousers(Costumes))
            {
                txtOutput.Text += $"Костюм ({c.Coat.Gender}): Coat={c.Coat.Color}, ";

                if (c.Trousers != null)
                    txtOutput.Text += $"Trousers={c.Trousers.Color}\n";
                else
                    txtOutput.Text += $"Skirt={c.Skirt.Color}\n";
            }
        }

        private void ShowRedTrousers()
        {
            txtOutput.Text += "КРАСНЫЕ БРЮКИ:\n";

            var allTrousers = Clothes.OfType<Trousers>().ToList();
            var trousersInCostumes = Costumes.Where(c => c.Trousers != null).Select(c => c.Trousers);

            foreach (var t in trousersInCostumes)
            {
                if (!allTrousers.Contains(t))
                    allTrousers.Add(t);
            }

            var red = manager.GetRedTrousers(allTrousers);

            foreach (var t in red)
            {
                txtOutput.Text +=
                    $"• Брюки, Gender={t.Gender}, Fabric={t.FabricType}, Size={t.Height}x{t.Width}, Color={t.Color}\n";
            }
        }

        private void ShowCountByGender()
        {
            txtOutput.Text += "КОЛИЧЕСТВО ДЛЯ МУЖЧИН:\n";
            var male = manager.GetCountOfClothTypeByGender(Clothes, Gender.Male);

            foreach (var kv in male)
                txtOutput.Text += $"{kv.Key}: {kv.Value}\n";

            txtOutput.Text += "\nКОЛИЧЕСТВО ДЛЯ ЖЕНЩИН:\n";
            var female = manager.GetCountOfClothTypeByGender(Clothes, Gender.Female);

            foreach (var kv in female)
                txtOutput.Text += $"{kv.Key}: {kv.Value}\n";
        }
    }
}
