using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        /* Money */
        private int money = 1000;

        /* Animal Prices */
        private const int ChickenMalePrice = 250;
        private const int ChickenFemalePrice = 200;
        private const int CowMalePrice = 300;
        private const int CowFemalePrice = 300;

        /*  Total Price */
        private int totalprice = 0;

        private List<Animal> barn = new List<Animal>();

        public Form1()
        {
            InitializeComponent();
            UpdateMoneyLabel();
            //LoadBarn();
        }

        private void UpdateMoneyLabel()
        {
            moneyLabel.Text = $"{money}$";
        }

        private void LoadBarn()
        {
            UpdateBarn(AnimalType.Chicken);
            UpdateBarn(AnimalType.Cow);
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
            {
                barn.Add(animal);
                MessageBox.Show($"{animalType} ({gender}) added to the {animalType.ToString().ToLower()} pen.", "Animal Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateBarn(animal.Type);
            }
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

        private void dataGridChicken_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }
    }
}