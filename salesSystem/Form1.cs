using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace salesSystem
{
    public partial class Form1 : Form
    {
        public struct Order
        {
            public string items;
            public double price;
        }
//const double TAX = 0.06;        
            //static double subTotal = 0;
            static double Total= 0;//total after removal of tax
            //static double totalTaxes = 0;
            Order order = new Order();
            string finalbill = "Final Bill \n ";
        public Form1()
        {
            InitializeComponent();
        }
        public void getValue(string custOrder)
        {
            order.items = custOrder.Split('#')[0];
            order.price = Convert.ToDouble( custOrder.Split('#')[1]);
            listBox1.Items.Add("\nPrice : " + order.price);
            finalbill += "ordered item : " + order.items + "\nPrice : " + order.price.ToString("C2")+"\n";
            updateBill();
        }
        private void updateBill()
        {
            //subTotal += order.price;
            //totalTaxes += order.price ;
            Total += order.price;
            listBox1.Items.Clear(); ;
            listBox1.Items.AddRange(finalbill.Split('\n'));
            //listBox1.Items.Add("totalTaxes : " + totalTaxes.ToString("C2"));
            //listBox1.Items.Add("SubTotal : " + subTotal.ToString("C2"));
            listBox1.Items.Add("Total : " +"N"+Total.ToString());
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              //subTotal = 0;
              Total= 0;//total after removal of tax
              //totalTaxes = 0;
             listBox1.Items.Clear();
             finalbill = "";
        }

        private void beverageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == beverageBox)
            {
                getValue(beverageBox.SelectedItem.ToString());
            }
            else if (sender == maincourseBox)
            {
                getValue(maincourseBox.SelectedItem.ToString());
            }
            else if (sender == appetizerBox)
            {
                getValue(appetizerBox.SelectedItem.ToString());
            }
            else 
            {
                getValue(dessertBox.SelectedItem.ToString());
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }
    }
}
