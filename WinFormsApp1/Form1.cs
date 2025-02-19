using WinFormsApp1.Models;
using System.Timers;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        /* Money */
        private int money = 1000;
        private int eggCount = 0;
        private int milkCount = 0;

        /* Animal Prices */
        private const int ChickenPrice = 250;
        private const int CowPrice = 300;

        /* Egg Price & Milk Price*/
        private const int eggPrice = 5;
        private const int milkPrice = 10;

        /*  Total Price */
        private int totalprice = 0;

        private List<Animal> barn = new List<Animal>();
        private System.Windows.Forms.Timer eggTimer;

        public Form1()
        {
            InitializeComponent();
            UpdateMoneyLabel();
            eggPriceLabel.Text = $"{eggPrice}$ per egg";
            milkPriceLabel.Text = $"{milkPrice}$ per milk";

            /* Egg Timer */
            eggTimer = new System.Windows.Forms.Timer();
            eggTimer.Interval = 4000;
            eggTimer.Tick += EggTimer_Tick;
            eggTimer.Start();

            /* Milk Timer */
            milkTimer = new System.Windows.Forms.Timer();
            milkTimer.Interval = 7500;
            milkTimer.Tick += MilkTimer_Tick;
            milkTimer.Start();

            /* Age Timer */
            ageTimer = new System.Windows.Forms.Timer();
            ageTimer.Interval = 60000;
            ageTimer.Tick += AgeAnimals_Tick;
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
            MessageBox.Show($"{animalType} added to the barn.", "Animal Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            foreach (var item in cartListBox.Items)
            {
                if (item.ToString().Contains("Chicken"))
                {
                    AddToBarn(AnimalType.Chicken);
                }
                else if (item.ToString().Contains("Cow"))
                {
                    AddToBarn(AnimalType.Cow);
                }
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

        private void EggTimer_Tick(object sender, EventArgs e)
        {
            var chickensInBarn = barn.Where(animal => animal.Type == AnimalType.Chicken && animal.IsAlive).Cast<Chicken>().ToList();

            foreach (var chicken in chickensInBarn)
            {
                eggCount++;
                maskedTextBox1.Text = eggCount.ToString();
            }
        }

        private void MilkTimer_Tick(object sender, EventArgs e)
        {
            var cowsInBarn = barn.Where(animal => animal.Type == AnimalType.Cow && animal.IsAlive).Cast<Cow>().ToList();

            foreach (var cow in cowsInBarn)
            {
                milkCount++;
                maskedTextBox2.Text = milkCount.ToString();
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
        //    //if (e.ColumnIndex == dataGridChicken.Columns["ProgressBar"].Index && e.RowIndex >= 0)
        //    {
        //        e.PaintBackground(e.ClipBounds, true);

        //        var chicken = barn.Where(a => a.Type == AnimalType.Chicken).ElementAtOrDefault(e.RowIndex) as Chicken;
        //        if (chicken != null)
        //        {
        //            int progress = (int)((double)chicken.ProductionTime / 3500 * 100); // 3.5 saniyede 100%

        //            var rect = e.CellBounds;
        //            var progressBarRect = new Rectangle(rect.X + 2, rect.Y + 2, rect.Width - 4, rect.Height - 4);

        //            using (var progressBarBrush = new SolidBrush(Color.LightGreen))
        //            {
        //                e.Graphics.FillRectangle(progressBarBrush, progressBarRect.X, progressBarRect.Y,
        //                                         progressBarRect.Width * progress / 100, progressBarRect.Height);
        //            }
        //        }

        //        e.PaintContent(e.ClipBounds);
        //        e.Handled = true;
        //    }
        }

        private void dataGridCow_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
        //    if (e.ColumnIndex == dataGridCow.Columns["ProgressBar"].Index && e.RowIndex >= 0)
        //    {
        //        e.PaintBackground(e.ClipBounds, true);

        //        var cow = barn.Where(a => a.Type == AnimalType.Cow).ElementAtOrDefault(e.RowIndex) as Cow;
        //        if (cow != null)
        //        {
        //            int progress = (int)((double)cow.ProductionTime / 6000 * 100); // 6 saniyede 100%

        //            var rect = e.CellBounds;
        //            var progressBarRect = new Rectangle(rect.X + 2, rect.Y + 2, rect.Width - 4, rect.Height - 4);

        //            using (var progressBarBrush = new SolidBrush(Color.LightBlue))
        //            {
        //                e.Graphics.FillRectangle(progressBarBrush, progressBarRect.X, progressBarRect.Y,
        //                                         progressBarRect.Width * progress / 100, progressBarRect.Height);
        //            }
        //        }

        //        e.PaintContent(e.ClipBounds);
        //        e.Handled = true;
        //    }
        }
    }
}