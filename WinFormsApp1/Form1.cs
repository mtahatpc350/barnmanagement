using System.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int money = 1000;
        private int eggCount = 0;
        private int milkCount = 0;

        private const int ChickenPrice = 250;
        private const int CowPrice = 300;

        private const int eggPrice = 5;
        private const int milkPrice = 10;

        private int totalprice = 0;

        private List<Animal> barn = new List<Animal>();

        public Form1()
        {
            InitializeComponent();
            UpdateMoneyLabel();
            eggPriceLabel.Text = $"{eggPrice}$ per egg";
            milkPriceLabel.Text = $"{milkPrice}$ per milk";

            ProductionTimer.Start();
            eggTimer.Start();
            milkTimer.Start();
            ageTimer.Start();

        }
        private void UpdateMoneyLabel()
        {
            moneyLabel.Text = $"{money}$";
        }

        private void UpdateBarn(AnimalType animalType)
        {
            var filteredAnimals = barn.Where(x => x.Type == animalType).ToList();
            if (animalType == AnimalType.Chicken)
                dataGridChicken.DataSource = filteredAnimals;
            else if (animalType == AnimalType.Cow)
                dataGridCow.DataSource = filteredAnimals;
        }

        private void AddToBarn(AnimalType animalType)
        {
            Animal animal = animalType switch
            {
                AnimalType.Chicken => new Chicken(null),
                AnimalType.Cow => new Cow(null),
            };

            if (animal == null) return;

            barn.Add(animal);
            if (animalType == AnimalType.Chicken)
            {
                UpdateBarn(AnimalType.Chicken);
            }
            else if (animalType == AnimalType.Cow)
            {
                UpdateBarn(AnimalType.Cow);
            }
            UpdateBarn(animal.Type);
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if (totalprice > money)
            {
                MessageBox.Show("You don't have enough money!", "To inform", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            money -= totalprice;
            UpdateMoneyLabel();

            int chickenCount = 0;
            int cowCount = 0;

            foreach (var item in cartListBox.Items)
            {
                if (item.ToString().Contains("Chicken"))
                {
                    chickenCount++;
                }
                else if (item.ToString().Contains("Cow"))
                {
                    cowCount++;
                }
            }

            for (int i = 0; i < chickenCount; i++)
            {
                AddToBarn(AnimalType.Chicken);
            }

            for (int i = 0; i < cowCount; i++)
            {
                AddToBarn(AnimalType.Cow);
            }

            if (chickenCount == 1)
            {
                MessageBox.Show("A chicken was added to the barn.", "Animal Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (chickenCount > 1)
            {
                MessageBox.Show($"chickens were added to the barn.", "Animals Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (cowCount == 1)
            {
                MessageBox.Show("A cow was added to the barn.", "Animal Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cowCount > 1)
            {
                MessageBox.Show($"cows were added to the barn.", "Animals Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            cartListBox.Items.Clear();
            totalprice = 0;
            textBox1.Text = "0";

        }
        private void emptyCartButton_Click(object sender, EventArgs e)
        {
            if (cartListBox.SelectedItem != null)
            {
                string selectedItem = cartListBox.SelectedItem.ToString();
                cartListBox.Items.Remove(selectedItem);

                if (selectedItem.Contains("Chicken"))
                {
                    totalprice -= ChickenPrice;
                }
                else if (selectedItem.Contains("Cow"))
                {
                    totalprice -= CowPrice;
                }

                textBox1.Text = totalprice.ToString();
            }
            else
            {
                MessageBox.Show("Please select an item to remove!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void AddToCart(string item, int price)
        {
            totalprice += price;
            cartListBox.Items.Add(item);
            textBox1.Text = (Convert.ToInt32(textBox1.Text) + price).ToString();
        }

        private void chickenPictureBox_Click(object sender, EventArgs e)
        {
            AddToCart("Chicken = 250 $", ChickenPrice);
        }

        private void cowPictureBox_Click(object sender, EventArgs e)
        {
            AddToCart("Cow = 300 $", CowPrice);
        }

        private void ProductionTimer_Tick(object sender, EventArgs e)
        {

            var chickensIsBarn = barn.Where(animal => animal.Type == AnimalType.Chicken && animal.IsAlive).Cast<Chicken>().ToList();
            foreach (var chicken in chickensIsBarn)
            {

                chicken.ProductionTime += 1000;

                dataGridChicken.Refresh();
            }

            var cowInBarn = barn.Where(animal => animal.Type == AnimalType.Cow && animal.IsAlive).Cast<Cow>().ToList();
            foreach (var cow in cowInBarn)
            {
                if (cow.ProductionTime >= milkTimer.Interval)
                {
                    cow.ProductionTime = 0;
                }
                else
                {
                    cow.ProductionTime += 1000;
                }
                dataGridCow.Refresh();
            }

        }

        private void AgeAnimals_Tick(object sender, EventArgs e)
        {
            foreach (var animal in barn.ToList())
            {
                if (animal.Type == AnimalType.Chicken)
                {
                    animal.Age++;

                    if (animal.Age >= 5)
                    {
                        barn.Remove(animal);
                        UpdateBarn(AnimalType.Chicken);
                    }
                }
                else if (animal.Type == AnimalType.Cow)
                {
                    animal.Age++;

                    if (animal.Age >= 7)
                    {
                        barn.Remove(animal);
                        UpdateBarn(AnimalType.Cow);
                    }
                }
            }
            dataGridChicken.Refresh();
            dataGridCow.Refresh();
        }

        private void eggSellButton_Click(object sender, EventArgs e)
        {
            money += eggCount * eggPrice;
            eggCount = 0;
            maskedTextBox1.Text = eggCount.ToString();
            UpdateMoneyLabel();
        }

        private void milkSellButton_Click(object sender, EventArgs e)
        {
            money += milkCount * milkPrice;
            milkCount = 0;
            maskedTextBox2.Text = milkCount.ToString();
            UpdateMoneyLabel();
        }

        private void dataGridChicken_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dataGridChicken.Columns["ProgressBar"].Index && e.RowIndex >= 0)
            {
                e.PaintBackground(e.ClipBounds, true);

                var chicken = barn.Where(a => a.Type == AnimalType.Chicken).ElementAtOrDefault(e.RowIndex) as Chicken;
                if (chicken != null)
                {
                    int progress = (int)((double)chicken.ProductionTime / eggTimer.Interval * 100); // 4 saniyede 100%

                    var rect = e.CellBounds;
                    var progressBarRect = new Rectangle(rect.X + 2, rect.Y + 2, rect.Width - 4, rect.Height - 4);

                    using (var progressBarBrush = new SolidBrush(Color.LightGreen))
                    {
                        e.Graphics.FillRectangle(progressBarBrush, progressBarRect.X, progressBarRect.Y,
                                                 progressBarRect.Width * progress / 100, progressBarRect.Height);
                    }
                    if (progress >= 100)
                    {
                        chicken.ProductionTime = 0;
                        eggCount++;
                        maskedTextBox1.Text = eggCount.ToString();
                    }
                }

                e.PaintContent(e.ClipBounds);
                e.Handled = true;
            }
        }

        private void dataGridCow_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dataGridCow.Columns["ProgressBar"].Index && e.RowIndex >= 0)
            {
                e.PaintBackground(e.ClipBounds, true);

                var cow = barn.Where(a => a.Type == AnimalType.Cow).ElementAtOrDefault(e.RowIndex) as Cow;
                if (cow != null)
                {
                    int progress = (int)((double)cow.ProductionTime / milkTimer.Interval * 100); // 7 saniyede 100%

                    var rect = e.CellBounds;
                    var progressBarRect = new Rectangle(rect.X + 2, rect.Y + 2, rect.Width - 4, rect.Height - 4);

                    using (var progressBarBrush = new SolidBrush(Color.LightGreen))
                    {
                        e.Graphics.FillRectangle(progressBarBrush, progressBarRect.X, progressBarRect.Y,
                                                 progressBarRect.Width * progress / 100, progressBarRect.Height);
                    }
                    if (progress >= 100)
                    {
                        cow.ProductionTime = 0;
                        milkCount++;
                        maskedTextBox2.Text = milkCount.ToString();
                    }
                }

                e.PaintContent(e.ClipBounds);
                e.Handled = true;
            }
        }

    }
}