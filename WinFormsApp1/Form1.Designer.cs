namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox2 = new GroupBox();
            cowMalePrice = new Label();
            chickenMalePrice = new Label();
            payButton = new Button();
            label2 = new Label();
            cowPictureBox = new PictureBox();
            label1 = new Label();
            chickenPictureBox = new PictureBox();
            groupBox4 = new GroupBox();
            milkPriceLabel = new Label();
            eggPriceLabel = new Label();
            label5 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            label6 = new Label();
            milkSellButton = new Button();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label3 = new Label();
            eggSellButton = new Button();
            pictureBox3 = new PictureBox();
            moneyLabel = new Label();
            label7 = new Label();
            label8 = new Label();
            cartListBox = new ListBox();
            label9 = new Label();
            label11 = new Label();
            textBox1 = new TextBox();
            dataGridChicken = new DataGridView();
            dataGridCow = new DataGridView();
            milkTimer = new System.Windows.Forms.Timer(components);
            ageTimer = new System.Windows.Forms.Timer(components);
            emptyCartButton = new Button();
            ProductionTimer = new System.Windows.Forms.Timer(components);
            eggTimer = new System.Windows.Forms.Timer(components);
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cowPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chickenPictureBox).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridChicken).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCow).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cowMalePrice);
            groupBox2.Controls.Add(chickenMalePrice);
            groupBox2.Controls.Add(payButton);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cowPictureBox);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(chickenPictureBox);
            groupBox2.Location = new Point(794, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(242, 507);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Animal Market";
            // 
            // cowMalePrice
            // 
            cowMalePrice.AutoSize = true;
            cowMalePrice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cowMalePrice.Location = new Point(103, 290);
            cowMalePrice.Name = "cowMalePrice";
            cowMalePrice.Size = new Size(36, 17);
            cowMalePrice.TabIndex = 13;
            cowMalePrice.Text = "300$";
            // 
            // chickenMalePrice
            // 
            chickenMalePrice.AutoSize = true;
            chickenMalePrice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            chickenMalePrice.Location = new Point(103, 135);
            chickenMalePrice.Name = "chickenMalePrice";
            chickenMalePrice.Size = new Size(36, 17);
            chickenMalePrice.TabIndex = 11;
            chickenMalePrice.Text = "250$";
            // 
            // payButton
            // 
            payButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            payButton.Location = new Point(57, 355);
            payButton.Name = "payButton";
            payButton.Size = new Size(141, 75);
            payButton.TabIndex = 10;
            payButton.Text = "Pay And Send it to farm";
            payButton.UseVisualStyleBackColor = true;
            payButton.Click += payButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(95, 266);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 7;
            label2.Text = "Cow";
            // 
            // cowPictureBox
            // 
            cowPictureBox.Cursor = Cursors.Hand;
            cowPictureBox.Image = (Image)resources.GetObject("cowPictureBox.Image");
            cowPictureBox.Location = new Point(67, 177);
            cowPictureBox.Name = "cowPictureBox";
            cowPictureBox.Size = new Size(100, 86);
            cowPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            cowPictureBox.TabIndex = 4;
            cowPictureBox.TabStop = false;
            cowPictureBox.Click += cowPictureBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(89, 111);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 3;
            label1.Text = "Chicken";
            // 
            // chickenPictureBox
            // 
            chickenPictureBox.Cursor = Cursors.Hand;
            chickenPictureBox.Image = (Image)resources.GetObject("chickenPictureBox.Image");
            chickenPictureBox.Location = new Point(69, 22);
            chickenPictureBox.Name = "chickenPictureBox";
            chickenPictureBox.Size = new Size(100, 86);
            chickenPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            chickenPictureBox.TabIndex = 0;
            chickenPictureBox.TabStop = false;
            chickenPictureBox.Click += chickenPictureBox_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(milkPriceLabel);
            groupBox4.Controls.Add(eggPriceLabel);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(maskedTextBox2);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(milkSellButton);
            groupBox4.Controls.Add(pictureBox4);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(maskedTextBox1);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(eggSellButton);
            groupBox4.Controls.Add(pictureBox3);
            groupBox4.Location = new Point(30, 367);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(469, 203);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Market";
            // 
            // milkPriceLabel
            // 
            milkPriceLabel.AutoSize = true;
            milkPriceLabel.Location = new Point(333, 154);
            milkPriceLabel.Name = "milkPriceLabel";
            milkPriceLabel.Size = new Size(59, 15);
            milkPriceLabel.TabIndex = 11;
            milkPriceLabel.Text = "Milk Price";
            // 
            // eggPriceLabel
            // 
            eggPriceLabel.AutoSize = true;
            eggPriceLabel.Location = new Point(111, 154);
            eggPriceLabel.Name = "eggPriceLabel";
            eggPriceLabel.Size = new Size(56, 15);
            eggPriceLabel.TabIndex = 10;
            eggPriceLabel.Text = "Egg Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(265, 154);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 9;
            label5.Text = "Liter Price :";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(339, 121);
            maskedTextBox2.Mask = "000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.ReadOnly = true;
            maskedTextBox2.Size = new Size(69, 23);
            maskedTextBox2.TabIndex = 3;
            maskedTextBox2.Text = "0";
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(234, 129);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 7;
            label6.Text = "Liter Of Milk :";
            // 
            // milkSellButton
            // 
            milkSellButton.Location = new Point(333, 174);
            milkSellButton.Name = "milkSellButton";
            milkSellButton.Size = new Size(75, 23);
            milkSellButton.TabIndex = 6;
            milkSellButton.Text = "Sell";
            milkSellButton.UseVisualStyleBackColor = true;
            milkSellButton.Click += milkSellButton_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(317, 22);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(107, 93);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 154);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 4;
            label4.Text = "Piece Price :";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.AccessibleRole = AccessibleRole.None;
            maskedTextBox1.Location = new Point(111, 121);
            maskedTextBox1.Mask = "000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.ReadOnly = true;
            maskedTextBox1.Size = new Size(69, 23);
            maskedTextBox1.TabIndex = 3;
            maskedTextBox1.Text = "0";
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 129);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 2;
            label3.Text = "Number Of Eggs :";
            // 
            // eggSellButton
            // 
            eggSellButton.Location = new Point(105, 174);
            eggSellButton.Name = "eggSellButton";
            eggSellButton.Size = new Size(75, 23);
            eggSellButton.TabIndex = 1;
            eggSellButton.Text = "Sell";
            eggSellButton.UseVisualStyleBackColor = true;
            eggSellButton.Click += eggSellButton_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(89, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(107, 93);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // moneyLabel
            // 
            moneyLabel.AutoSize = true;
            moneyLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            moneyLabel.Location = new Point(932, 545);
            moneyLabel.Name = "moneyLabel";
            moneyLabel.Size = new Size(112, 37);
            moneyLabel.TabIndex = 5;
            moneyLabel.Text = "WALLET";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(169, 6);
            label7.Name = "label7";
            label7.Size = new Size(82, 25);
            label7.TabIndex = 8;
            label7.Text = "Chicken";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(553, 6);
            label8.Name = "label8";
            label8.Size = new Size(51, 25);
            label8.TabIndex = 9;
            label8.Text = "Cow";
            // 
            // cartListBox
            // 
            cartListBox.FormattingEnabled = true;
            cartListBox.ItemHeight = 15;
            cartListBox.Location = new Point(537, 395);
            cartListBox.Name = "cartListBox";
            cartListBox.Size = new Size(217, 124);
            cartListBox.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.Location = new Point(615, 367);
            label9.Name = "label9";
            label9.Size = new Size(47, 25);
            label9.TabIndex = 11;
            label9.Text = "Cart";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(553, 555);
            label11.Name = "label11";
            label11.Size = new Size(68, 15);
            label11.TabIndex = 14;
            label11.Text = "Total Price :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(627, 549);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 15;
            textBox1.Text = "0";
            // 
            // dataGridChicken
            // 
            dataGridChicken.AllowUserToAddRows = false;
            dataGridChicken.AllowUserToDeleteRows = false;
            dataGridChicken.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridChicken.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridChicken.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridChicken.Location = new Point(30, 34);
            dataGridChicken.Name = "dataGridChicken";
            dataGridChicken.ReadOnly = true;
            dataGridChicken.Size = new Size(345, 304);
            dataGridChicken.TabIndex = 16;
            dataGridChicken.CellPainting += dataGridChicken_CellPainting;
            // 
            // dataGridCow
            // 
            dataGridCow.AllowUserToAddRows = false;
            dataGridCow.AllowUserToDeleteRows = false;
            dataGridCow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCow.Location = new Point(409, 34);
            dataGridCow.Name = "dataGridCow";
            dataGridCow.ReadOnly = true;
            dataGridCow.Size = new Size(345, 304);
            dataGridCow.TabIndex = 17;
            dataGridCow.CellPainting += dataGridCow_CellPainting;
            // 
            // milkTimer
            // 
            milkTimer.Enabled = true;
            milkTimer.Interval = 7000;
            // 
            // ageTimer
            // 
            ageTimer.Enabled = true;
            ageTimer.Interval = 60000;
            ageTimer.Tick += AgeAnimals_Tick;
            // 
            // emptyCartButton
            // 
            emptyCartButton.Location = new Point(576, 521);
            emptyCartButton.Name = "emptyCartButton";
            emptyCartButton.Size = new Size(136, 22);
            emptyCartButton.TabIndex = 18;
            emptyCartButton.Text = "Empty The Cart";
            emptyCartButton.UseVisualStyleBackColor = true;
            emptyCartButton.Click += emptyCartButton_Click;
            // 
            // ProductionTimer
            // 
            ProductionTimer.Interval = 1000;
            ProductionTimer.Tick += ProductionTimer_Tick;
            // 
            // eggTimer
            // 
            eggTimer.Enabled = true;
            eggTimer.Interval = 4000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1048, 591);
            Controls.Add(emptyCartButton);
            Controls.Add(dataGridCow);
            Controls.Add(textBox1);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(cartListBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(moneyLabel);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(dataGridChicken);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Animal Farm";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cowPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)chickenPictureBox).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridChicken).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox2;
        private PictureBox chickenPictureBox;
        private Label label1;
        private Label label2;
        private PictureBox cowPictureBox;
        private GroupBox groupBox4;
        private MaskedTextBox maskedTextBox1;
        private Label label3;
        private Button eggSellButton;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label5;
        private MaskedTextBox maskedTextBox2;
        private Label label6;
        private Button milkSellButton;
        private PictureBox pictureBox4;
        private Label moneyLabel;
        private Label label7;
        private Label label8;
        private Button payButton;
        private ListBox cartListBox;
        private Label label9;
        private Label label11;
        private TextBox textBox1;
        private Label chickenMalePrice;
        private Label cowMalePrice;
        private DataGridView dataGridChicken;
        private DataGridView dataGridCow;
        private System.Windows.Forms.Timer milkTimer;
        private Label eggPriceLabel;
        private Label milkPriceLabel;
        private System.Windows.Forms.Timer ageTimer;
        private Button emptyCartButton;
        private System.Windows.Forms.Timer ProductionTimer;
        private System.Windows.Forms.Timer eggTimer;
    }
}
