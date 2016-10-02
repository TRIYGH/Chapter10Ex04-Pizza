namespace trwCh10Ex4___Pizza
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuTab = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.CalcButton = new System.Windows.Forms.Button();
            this.TotalAmount = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.TotalAmountBeer = new System.Windows.Forms.TextBox();
            this.TotalAmountBreads = new System.Windows.Forms.TextBox();
            this.TotalAmountPizza = new System.Windows.Forms.TextBox();
            this.TotalOrderBeer = new System.Windows.Forms.TextBox();
            this.TotalOrderBreads = new System.Windows.Forms.TextBox();
            this.TotalOrderPizza = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ReadyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pizzaTab = new System.Windows.Forms.TabPage();
            this.ToppingsLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.breadsticksTab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cheeseyCheckBox = new System.Windows.Forms.CheckBox();
            this.wingCheckBox = new System.Windows.Forms.CheckBox();
            this.BreadstickCheckBox = new System.Windows.Forms.CheckBox();
            this.beerTab = new System.Windows.Forms.TabPage();
            this.BeerLabel = new System.Windows.Forms.Label();
            this.HeinCheckBox = new System.Windows.Forms.CheckBox();
            this.CoronaCheckBox = new System.Windows.Forms.CheckBox();
            this.DELightCheckBox = new System.Windows.Forms.CheckBox();
            this.DosEquisCheckBox = new System.Windows.Forms.CheckBox();
            this.menuTab.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.pizzaTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.breadsticksTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.beerTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTab
            // 
            this.menuTab.Controls.Add(this.mainTab);
            this.menuTab.Controls.Add(this.pizzaTab);
            this.menuTab.Controls.Add(this.breadsticksTab);
            this.menuTab.Controls.Add(this.beerTab);
            this.menuTab.Location = new System.Drawing.Point(2, 2);
            this.menuTab.Name = "menuTab";
            this.menuTab.SelectedIndex = 0;
            this.menuTab.Size = new System.Drawing.Size(607, 535);
            this.menuTab.TabIndex = 0;
            // 
            // mainTab
            // 
            this.mainTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainTab.BackgroundImage")));
            this.mainTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainTab.Controls.Add(this.CalcButton);
            this.mainTab.Controls.Add(this.TotalAmount);
            this.mainTab.Controls.Add(this.TotalTextBox);
            this.mainTab.Controls.Add(this.TotalAmountBeer);
            this.mainTab.Controls.Add(this.TotalAmountBreads);
            this.mainTab.Controls.Add(this.TotalAmountPizza);
            this.mainTab.Controls.Add(this.TotalOrderBeer);
            this.mainTab.Controls.Add(this.TotalOrderBreads);
            this.mainTab.Controls.Add(this.TotalOrderPizza);
            this.mainTab.Controls.Add(this.textBox2);
            this.mainTab.Controls.Add(this.textBox1);
            this.mainTab.Controls.Add(this.ReadyButton);
            this.mainTab.Controls.Add(this.label1);
            this.mainTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTab.Location = new System.Drawing.Point(4, 22);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainTab.Size = new System.Drawing.Size(599, 509);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Big Al\'s Pizza  -  MENU";
            this.mainTab.UseVisualStyleBackColor = true;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(216, 325);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(161, 23);
            this.CalcButton.TabIndex = 12;
            this.CalcButton.Text = "Calculate My Order";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Visible = false;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // TotalAmount
            // 
            this.TotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount.Location = new System.Drawing.Point(334, 264);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(86, 22);
            this.TotalAmount.TabIndex = 11;
            this.TotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalAmount.Visible = false;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextBox.Location = new System.Drawing.Point(169, 264);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(130, 22);
            this.TotalTextBox.TabIndex = 10;
            this.TotalTextBox.Text = "TOTAL:";
            this.TotalTextBox.Visible = false;
            // 
            // TotalAmountBeer
            // 
            this.TotalAmountBeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountBeer.Location = new System.Drawing.Point(334, 215);
            this.TotalAmountBeer.Name = "TotalAmountBeer";
            this.TotalAmountBeer.Size = new System.Drawing.Size(86, 22);
            this.TotalAmountBeer.TabIndex = 9;
            this.TotalAmountBeer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalAmountBeer.Visible = false;
            // 
            // TotalAmountBreads
            // 
            this.TotalAmountBreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountBreads.Location = new System.Drawing.Point(334, 187);
            this.TotalAmountBreads.Name = "TotalAmountBreads";
            this.TotalAmountBreads.Size = new System.Drawing.Size(86, 22);
            this.TotalAmountBreads.TabIndex = 8;
            this.TotalAmountBreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalAmountBreads.Visible = false;
            // 
            // TotalAmountPizza
            // 
            this.TotalAmountPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountPizza.Location = new System.Drawing.Point(334, 159);
            this.TotalAmountPizza.Name = "TotalAmountPizza";
            this.TotalAmountPizza.Size = new System.Drawing.Size(86, 22);
            this.TotalAmountPizza.TabIndex = 7;
            this.TotalAmountPizza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalAmountPizza.Visible = false;
            // 
            // TotalOrderBeer
            // 
            this.TotalOrderBeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalOrderBeer.Location = new System.Drawing.Point(169, 215);
            this.TotalOrderBeer.Name = "TotalOrderBeer";
            this.TotalOrderBeer.Size = new System.Drawing.Size(130, 22);
            this.TotalOrderBeer.TabIndex = 6;
            this.TotalOrderBeer.Text = "Beer:";
            this.TotalOrderBeer.Visible = false;
            // 
            // TotalOrderBreads
            // 
            this.TotalOrderBreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalOrderBreads.Location = new System.Drawing.Point(169, 187);
            this.TotalOrderBreads.Name = "TotalOrderBreads";
            this.TotalOrderBreads.Size = new System.Drawing.Size(130, 22);
            this.TotalOrderBreads.TabIndex = 5;
            this.TotalOrderBreads.Text = "Bread & Wings:";
            this.TotalOrderBreads.Visible = false;
            // 
            // TotalOrderPizza
            // 
            this.TotalOrderPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalOrderPizza.Location = new System.Drawing.Point(169, 159);
            this.TotalOrderPizza.Name = "TotalOrderPizza";
            this.TotalOrderPizza.Size = new System.Drawing.Size(130, 22);
            this.TotalOrderPizza.TabIndex = 4;
            this.TotalOrderPizza.Text = "Pizza:";
            this.TotalOrderPizza.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 99);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(302, 275);
            this.textBox2.TabIndex = 3;
            this.textBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(181, 113);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 173);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "We Offer Pizza, Breadsticks / Wings and Beer on the following pages.\r\n\r\nPlease ma" +
    "ke your selections and check back here to submit your order.\r\n\r\nThank you and en" +
    "joy,\r\n\r\nBig Al";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReadyButton
            // 
            this.ReadyButton.Location = new System.Drawing.Point(20, 453);
            this.ReadyButton.Name = "ReadyButton";
            this.ReadyButton.Size = new System.Drawing.Size(140, 23);
            this.ReadyButton.TabIndex = 1;
            this.ReadyButton.Text = "I\'m Ready To Order";
            this.ReadyButton.UseVisualStyleBackColor = true;
            this.ReadyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(102, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "........................... Big Al\'s Pizza - Since 526 BC ......................." +
    "....";
            // 
            // pizzaTab
            // 
            this.pizzaTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pizzaTab.BackgroundImage")));
            this.pizzaTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pizzaTab.Controls.Add(this.ToppingsLabel);
            this.pizzaTab.Controls.Add(this.groupBox2);
            this.pizzaTab.Controls.Add(this.groupBox1);
            this.pizzaTab.Location = new System.Drawing.Point(4, 22);
            this.pizzaTab.Name = "pizzaTab";
            this.pizzaTab.Padding = new System.Windows.Forms.Padding(3);
            this.pizzaTab.Size = new System.Drawing.Size(599, 509);
            this.pizzaTab.TabIndex = 1;
            this.pizzaTab.Text = "Pizza";
            this.pizzaTab.UseVisualStyleBackColor = true;
            // 
            // ToppingsLabel
            // 
            this.ToppingsLabel.AutoSize = true;
            this.ToppingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToppingsLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ToppingsLabel.Location = new System.Drawing.Point(288, 451);
            this.ToppingsLabel.Name = "ToppingsLabel";
            this.ToppingsLabel.Size = new System.Drawing.Size(176, 15);
            this.ToppingsLabel.TabIndex = 3;
            this.ToppingsLabel.Text = "* Toppings are $0.75 each";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox12);
            this.groupBox2.Controls.Add(this.checkBox11);
            this.groupBox2.Controls.Add(this.checkBox10);
            this.groupBox2.Controls.Add(this.checkBox9);
            this.groupBox2.Controls.Add(this.checkBox8);
            this.groupBox2.Controls.Add(this.checkBox7);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(273, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 304);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TOPPINGS";
            this.groupBox2.Visible = false;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(25, 273);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(127, 20);
            this.checkBox12.TabIndex = 11;
            this.checkBox12.Text = "Tomato Slices";
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.Visible = false;
            this.checkBox12.CheckedChanged += new System.EventHandler(this.checkBox12_CheckedChanged);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(25, 250);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(68, 20);
            this.checkBox11.TabIndex = 10;
            this.checkBox11.Text = "Garlic";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.Visible = false;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(25, 227);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(106, 20);
            this.checkBox10.TabIndex = 9;
            this.checkBox10.Text = "Mushrooms";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.Visible = false;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(25, 204);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(106, 20);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "Pineapples";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.Visible = false;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(25, 181);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(119, 20);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "Red Peppers";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.Visible = false;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(25, 158);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(132, 20);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Green Peppers";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.Visible = false;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(25, 135);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(75, 20);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Onions";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.Visible = false;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(25, 112);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(89, 20);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Sausage";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.Visible = false;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(25, 89);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(113, 20);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Ground Beef";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Visible = false;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(25, 66);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(99, 20);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Pepperoni";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Visible = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(25, 43);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(110, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Extra Sauce";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(25, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Extra Cheese";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(68, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SIZE";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(25, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(134, 20);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Large      $12.00";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(25, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(132, 20);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Medium  $10.00";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(25, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(133, 20);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Small      $  8.00";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // breadsticksTab
            // 
            this.breadsticksTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("breadsticksTab.BackgroundImage")));
            this.breadsticksTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.breadsticksTab.Controls.Add(this.groupBox3);
            this.breadsticksTab.Location = new System.Drawing.Point(4, 22);
            this.breadsticksTab.Name = "breadsticksTab";
            this.breadsticksTab.Padding = new System.Windows.Forms.Padding(3);
            this.breadsticksTab.Size = new System.Drawing.Size(599, 509);
            this.breadsticksTab.TabIndex = 2;
            this.breadsticksTab.Text = "Breadsticks & Wings";
            this.breadsticksTab.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cheeseyCheckBox);
            this.groupBox3.Controls.Add(this.wingCheckBox);
            this.groupBox3.Controls.Add(this.BreadstickCheckBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox3.Location = new System.Drawing.Point(26, 403);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(545, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Breadsticks, Wings & Bread";
            // 
            // cheeseyCheckBox
            // 
            this.cheeseyCheckBox.AutoSize = true;
            this.cheeseyCheckBox.Location = new System.Drawing.Point(340, 40);
            this.cheeseyCheckBox.Name = "cheeseyCheckBox";
            this.cheeseyCheckBox.Size = new System.Drawing.Size(183, 20);
            this.cheeseyCheckBox.TabIndex = 2;
            this.cheeseyCheckBox.Text = "Cheesey Bread - $3.99";
            this.cheeseyCheckBox.UseVisualStyleBackColor = true;
            this.cheeseyCheckBox.CheckedChanged += new System.EventHandler(this.cheeseyCheckBox_CheckedChanged);
            // 
            // wingCheckBox
            // 
            this.wingCheckBox.AutoSize = true;
            this.wingCheckBox.Location = new System.Drawing.Point(197, 40);
            this.wingCheckBox.Name = "wingCheckBox";
            this.wingCheckBox.Size = new System.Drawing.Size(119, 20);
            this.wingCheckBox.TabIndex = 1;
            this.wingCheckBox.Text = "Wings - $6.99";
            this.wingCheckBox.UseVisualStyleBackColor = true;
            this.wingCheckBox.CheckedChanged += new System.EventHandler(this.wingCheckBox_CheckedChanged);
            // 
            // BreadstickCheckBox
            // 
            this.BreadstickCheckBox.AutoSize = true;
            this.BreadstickCheckBox.Location = new System.Drawing.Point(23, 41);
            this.BreadstickCheckBox.Name = "BreadstickCheckBox";
            this.BreadstickCheckBox.Size = new System.Drawing.Size(158, 20);
            this.BreadstickCheckBox.TabIndex = 0;
            this.BreadstickCheckBox.Text = "Breadsticks - $4.99";
            this.BreadstickCheckBox.UseVisualStyleBackColor = true;
            this.BreadstickCheckBox.CheckedChanged += new System.EventHandler(this.BreadstickCheckBox_CheckedChanged);
            // 
            // beerTab
            // 
            this.beerTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("beerTab.BackgroundImage")));
            this.beerTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.beerTab.Controls.Add(this.BeerLabel);
            this.beerTab.Controls.Add(this.HeinCheckBox);
            this.beerTab.Controls.Add(this.CoronaCheckBox);
            this.beerTab.Controls.Add(this.DELightCheckBox);
            this.beerTab.Controls.Add(this.DosEquisCheckBox);
            this.beerTab.Location = new System.Drawing.Point(4, 22);
            this.beerTab.Name = "beerTab";
            this.beerTab.Padding = new System.Windows.Forms.Padding(3);
            this.beerTab.Size = new System.Drawing.Size(599, 509);
            this.beerTab.TabIndex = 3;
            this.beerTab.Text = "Beer";
            this.beerTab.UseVisualStyleBackColor = true;
            // 
            // BeerLabel
            // 
            this.BeerLabel.AutoSize = true;
            this.BeerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeerLabel.Location = new System.Drawing.Point(191, 18);
            this.BeerLabel.Name = "BeerLabel";
            this.BeerLabel.Size = new System.Drawing.Size(245, 25);
            this.BeerLabel.TabIndex = 4;
            this.BeerLabel.Text = "Beer - $4.00  ( bottle )";
            // 
            // HeinCheckBox
            // 
            this.HeinCheckBox.AutoSize = true;
            this.HeinCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeinCheckBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.HeinCheckBox.Location = new System.Drawing.Point(428, 159);
            this.HeinCheckBox.Name = "HeinCheckBox";
            this.HeinCheckBox.Size = new System.Drawing.Size(117, 20);
            this.HeinCheckBox.TabIndex = 3;
            this.HeinCheckBox.Text = "Heineylichen";
            this.HeinCheckBox.UseVisualStyleBackColor = true;
            this.HeinCheckBox.CheckedChanged += new System.EventHandler(this.BEERCheckBox_CheckedChanged);
            // 
            // CoronaCheckBox
            // 
            this.CoronaCheckBox.AutoSize = true;
            this.CoronaCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoronaCheckBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CoronaCheckBox.Location = new System.Drawing.Point(264, 329);
            this.CoronaCheckBox.Name = "CoronaCheckBox";
            this.CoronaCheckBox.Size = new System.Drawing.Size(77, 20);
            this.CoronaCheckBox.TabIndex = 2;
            this.CoronaCheckBox.Text = "Corona";
            this.CoronaCheckBox.UseVisualStyleBackColor = true;
            this.CoronaCheckBox.CheckedChanged += new System.EventHandler(this.BEERCheckBox_CheckedChanged);
            // 
            // DELightCheckBox
            // 
            this.DELightCheckBox.AutoSize = true;
            this.DELightCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELightCheckBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DELightCheckBox.Location = new System.Drawing.Point(46, 266);
            this.DELightCheckBox.Name = "DELightCheckBox";
            this.DELightCheckBox.Size = new System.Drawing.Size(135, 20);
            this.DELightCheckBox.TabIndex = 1;
            this.DELightCheckBox.Text = "Dos Equis Light";
            this.DELightCheckBox.UseVisualStyleBackColor = true;
            this.DELightCheckBox.CheckedChanged += new System.EventHandler(this.BEERCheckBox_CheckedChanged);
            // 
            // DosEquisCheckBox
            // 
            this.DosEquisCheckBox.AutoSize = true;
            this.DosEquisCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DosEquisCheckBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DosEquisCheckBox.Location = new System.Drawing.Point(60, 216);
            this.DosEquisCheckBox.Name = "DosEquisCheckBox";
            this.DosEquisCheckBox.Size = new System.Drawing.Size(98, 20);
            this.DosEquisCheckBox.TabIndex = 0;
            this.DosEquisCheckBox.Text = "Dos Equis";
            this.DosEquisCheckBox.UseVisualStyleBackColor = true;
            this.DosEquisCheckBox.CheckedChanged += new System.EventHandler(this.BEERCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 565);
            this.Controls.Add(this.menuTab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuTab.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.mainTab.PerformLayout();
            this.pizzaTab.ResumeLayout(false);
            this.pizzaTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.breadsticksTab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.beerTab.ResumeLayout(false);
            this.beerTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menuTab;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ReadyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage pizzaTab;
        private System.Windows.Forms.TabPage breadsticksTab;
        private System.Windows.Forms.TabPage beerTab;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cheeseyCheckBox;
        private System.Windows.Forms.CheckBox wingCheckBox;
        private System.Windows.Forms.CheckBox BreadstickCheckBox;
        private System.Windows.Forms.Label BeerLabel;
        private System.Windows.Forms.CheckBox HeinCheckBox;
        private System.Windows.Forms.CheckBox CoronaCheckBox;
        private System.Windows.Forms.CheckBox DELightCheckBox;
        private System.Windows.Forms.CheckBox DosEquisCheckBox;
        private System.Windows.Forms.TextBox TotalAmount;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox TotalAmountBeer;
        private System.Windows.Forms.TextBox TotalAmountBreads;
        private System.Windows.Forms.TextBox TotalAmountPizza;
        private System.Windows.Forms.TextBox TotalOrderBeer;
        private System.Windows.Forms.TextBox TotalOrderBreads;
        private System.Windows.Forms.TextBox TotalOrderPizza;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Label ToppingsLabel;
    }
}

