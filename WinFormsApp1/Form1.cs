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
        private const int ChickenMalePrice = 250;
        private const int ChickenFemalePrice = 200;
        private const int CowMalePrice = 300;
        private const int CowFemalePrice = 300;

        /* Egg Price & Milk Price*/
        private const int eggPrice = 10;
        private const int milkPrice = 20;
        private Random random = new Random();


        /*  Total Price */
        private int totalprice = 0;

        private List<Animal> barn = new List<Animal>();
        private System.Windows.Forms.Timer eggTimer;
        private System.Windows.Forms.Timer milkTimer5;

        public Form1()
        {
            InitializeComponent();
            UpdateMoneyLabel();
            eggPriceLabel.Text = $"{eggPrice}$ per egg";
            milkPriceLabel.Text = $"{milkPrice}$ per milk";

            /* Egg Timer */
            eggTimer = new System.Windows.Forms.Timer();
            eggTimer.Interval = 5000;
            eggTimer.Tick += EggTimer_Tick;
            eggTimer.Start();

            /* Milk Timer */
            milkTimer5 = new System.Windows.Forms.Timer();
            milkTimer5.Interval = 7000;
            milkTimer5.Tick += MilkTimer_Tick;
            milkTimer5.Start();
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

        private void AddToBarn(AnimalType animalType, AnimalGender gender)
        {
            Animal animal = animalType switch
            {
                AnimalType.Chicken => new Chicken(gender, null),
                AnimalType.Cow => new Cow(gender, null),
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
            MessageBox.Show($"{animalType} ({gender}) added to the barn.", "Animal Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    AddToBarn(chickenMaleBut.Checked ? AnimalType.Chicken : AnimalType.Chicken, chickenMaleBut.Checked ? AnimalGender.Male : AnimalGender.Female);
                }
                else if (item.ToString().Contains("Cow"))
                {
                    AddToBarn(cowMaleBut.Checked ? AnimalType.Cow : AnimalType.Cow, cowMaleBut.Checked ? AnimalGender.Male : AnimalGender.Female);
                }
            }

            cartListBox.Items.Clear();
            totalprice = 0;
            textBox1.Text = "0";

        }

        private void AddToCart(string item, int price)
        {
            totalprice += price;
            cartListBox.Items.Add(item);
            textBox1.Text = (Convert.ToInt32(textBox1.Text) + price).ToString();
        }

        private void chickenPictureBox_Click(object sender, EventArgs e)
        {
            if (chickenMaleBut.Checked)
                AddToCart("Chicken : Male = 250 $", ChickenMalePrice);
            else if (chickenFemaleBut.Checked)
                AddToCart("Chicken : Female = 200 $", ChickenFemalePrice);
        }

        private void cowPictureBox_Click(object sender, EventArgs e)
        {
            if (cowMaleBut.Checked)
                AddToCart("Cow : Male = 300 $", CowMalePrice);
            else if (cowFemaleBut.Checked)
                AddToCart("Cow : Female = 300 $", CowFemalePrice);
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

    }
}