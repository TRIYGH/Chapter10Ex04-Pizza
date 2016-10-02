//Thurman Ward  9/28/14

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trwCh10Ex4___Pizza
{
    public partial class Form1 : Form
    {
        decimal sizeCost = 0.00M;
        decimal totalOrder = 0.00M;
        decimal toppingCost = 0.00M;
        decimal sideOrderCost = 0.00M;
        decimal beerCost = 0.00M;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadyButton.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = true;
            textBox2.SendToBack();
            TotalOrderBeer.Visible = true;
            TotalOrderBreads.Visible = true;
            TotalOrderPizza.Visible = true;
            TotalAmountBeer.Visible = true;
            TotalAmountBreads.Visible = true;
            TotalAmountPizza.Visible = true;
            TotalAmount.Visible = true;
            CalcButton.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            checkBox4.Visible = true;
            checkBox5.Visible = true;
            checkBox6.Visible = true;
            checkBox7.Visible = true;
            checkBox8.Visible = true;
            checkBox9.Visible = true;
            checkBox10.Visible = true;
            checkBox11.Visible = true;
            checkBox12.Visible = true;

            sizeCost = 8.00M;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            checkBox4.Visible = true;
            checkBox5.Visible = true;
            checkBox6.Visible = true;
            checkBox7.Visible = true;
            checkBox8.Visible = true;
            checkBox9.Visible = true;
            checkBox10.Visible = true;
            checkBox11.Visible = true;
            checkBox12.Visible = true;

            sizeCost = 10.00M;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            checkBox4.Visible = true;
            checkBox5.Visible = true;
            checkBox6.Visible = true;
            checkBox7.Visible = true;
            checkBox8.Visible = true;
            checkBox9.Visible = true;
            checkBox10.Visible = true;
            checkBox11.Visible = true;
            checkBox12.Visible = true;

            sizeCost = 12.00M;
        }
        // I SHOULD HAVE USED AN ARRAY AND 1 EVENT - RAN OUT OF TIME, CAN RE-PROGRAM   -    bad me !!!!!!
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                toppingCost += 0.75M;

            if (checkBox1.Checked == false)
                toppingCost -= 0.75M;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                toppingCost += 0.75M;

            if (checkBox2.Checked == false)
                toppingCost -= 0.75M;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                toppingCost += 0.75M;

            if (checkBox3.Checked == false)
                toppingCost -= 0.75M;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                toppingCost += 0.75M;

            if (checkBox4.Checked == false)
                toppingCost -= 0.75M;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
                toppingCost += 0.75M;

            if (checkBox5.Checked == false)
                toppingCost -= 0.75M;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
                toppingCost += 0.75M;

            if (checkBox6.Checked == false)
                toppingCost -= 0.75M;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
                toppingCost += 0.75M;

            if (checkBox7.Checked == false)
                toppingCost -= 0.75M;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
                toppingCost += 0.75M;

            if (checkBox8.Checked == false)
                toppingCost -= 0.75M;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
                toppingCost += 0.75M;

            if (checkBox9.Checked == false)
                toppingCost -= 0.75M;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
                toppingCost += 0.75M;

            if (checkBox10.Checked == false)
                toppingCost -= 0.75M;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
                toppingCost += 0.75M;

            if (checkBox11.Checked == false)
                toppingCost -= 0.75M;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
                toppingCost += 0.75M;

            if (checkBox12.Checked == false)
                toppingCost -= 0.75M;
        }

        private void BreadstickCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BreadstickCheckBox.Checked)
                sideOrderCost += 4.99M;

            if (BreadstickCheckBox.Checked == false)
                sideOrderCost -= 4.99M;
        }

        private void wingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (wingCheckBox.Checked)
                sideOrderCost += 6.99M;

            if (wingCheckBox.Checked == false)
                sideOrderCost -= 6.99M;
        }



        private void cheeseyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cheeseyCheckBox.Checked)
                sideOrderCost += 3.99M;

            if (cheeseyCheckBox.Checked == false)
                sideOrderCost -= 3.99M;

        }

        private void DosEquisCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            TotalAmountBeer.Text = Convert.ToString(beerCost);

            TotalAmountBreads.Text = Convert.ToString(sideOrderCost);

            TotalAmountPizza.Text = Convert.ToString(toppingCost + sizeCost);

            TotalAmount.Text = Convert.ToString(beerCost + sideOrderCost + toppingCost + sizeCost);

        }

        private void BEERCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int beerCount = 0;
            if (DosEquisCheckBox.Checked)
                beerCount++;

            if (DELightCheckBox.Checked)
                beerCount++;

            if (CoronaCheckBox.Checked)
                beerCount++;

            if (HeinCheckBox.Checked)
                beerCount++;

            beerCost = beerCount * 4.00M;
        }


    }
}
