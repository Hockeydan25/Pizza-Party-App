using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_party
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double price = 0.0;          //declaring variable and their values, price will change as program runs.
        double lPrice = 20.00;      //declaring variable and their values, Large pizza.
        double mPrice = 15.00;       //declaring variable and their values, medium pizza.
        double sPrice = 12.00;           //declaring variable and their values, samall pizza.
        double pPrice = 10.00;           //declaring variable and their values, personal size pizza.
        double dPrice = 2.00;            //declaring variable and their values, price for drink.
        double toppings = 3.00;          //declaring variable and their values, topping meat, or veggies.
        double bwdPrice = 5.00;           //declaring variable and their values, bread, wings dessert price.

        private void btnCalculate_Click(object sender, EventArgs e)  //works will form to calculate .
        {
            if (IsValidData())                                          //method to check data validation.
            {

                string size = Convert.ToString(combosize.SelectedItem);  //declaring size combobox user will seelction from drop down list on form

                listBox1.Items.Add(size);                         //declaring size to add items to list box 1. 
                listBox2.Items.Add("Total:");                     //adding Total for display in listbox2 for cost.  
                listBox2.Items.Add("------------");               //addd lines for seperation readability to the listbox totals.  


                if (combosize.SelectedIndex == 0)           // chceks index 0 is checked, and completes if true, this is Large. 
                {
                    listBox1.Items.Add(lPrice.ToString("c"));   //optput to listbox displaying the price
                    price = price + lPrice;                      //price for large size is added to price if selected.                                     
                }

                else if (combosize.SelectedIndex == 1)  // chceks index 0 is checked, and completes if true, this is Large. 
                {
                    price = price + mPrice;                      //price for medium size is added to price if selected.
                    listBox1.Items.Add(mPrice.ToString("c")); //optput to listbox displaying the price.
                }
                else if (combosize.SelectedIndex == 2)  // chceks index 0 is checked, and completes if true, this is Large. 
                {
                    price = price + sPrice;                     //price for small size is added to price if selected. 
                    listBox1.Items.Add(sPrice.ToString("c")); //optput to listbox displaying the price

                }
                else if (combosize.SelectedIndex == 3)  // chceks index 0 is checked, and completes if true, this is Large. 
                {
                    price = price + pPrice;                 //price for personal size is added to price if selected. 
                    listBox1.Items.Add(pPrice.ToString("c")); //optput to listbox displaying the price
                }
                listBox1.Items.Add("------------");   //addd lines for seperation readability to the listbox. 


                foreach (string meat in chkListMeats.CheckedItems)
                {
                    price = price + toppings;                    //price for addional selected itmes is added to price.
                    listBox1.Items.Add(meat);                       //displays meats selected to listbox.
                    listBox1.Items.Add(toppings.ToString("c"));   //output to listbox displaying,price total and adding topping cost.  
                    listBox1.Items.Add("------------");         //addd lines for seperation readability to the listbox totals. 
                }

                foreach (string veggie in chkListVeggies.CheckedItems)
                {
                    price = price + toppings;                    //price for addional selected itmes are added to price. 
                    listBox1.Items.Add(veggie);                 //displays veggie selected to listbox.
                    listBox1.Items.Add(toppings.ToString("c"));  //output to listbox displaying,price total and adding topping cost.
                    listBox1.Items.Add("------------");  //addd lines for seperation readability to the listbox. 
                }

                foreach (string drink in chkListDrinks.CheckedItems)
                {
                    price = price + dPrice;                      //price for addional selected itmes are added to price.
                    listBox1.Items.Add(drink);                  //displays drinks selected to listbox.
                    listBox1.Items.Add(dPrice.ToString("c"));  //output to listbox displaying,price total and adding drink cost.
                    listBox1.Items.Add("------------");   //addd lines for seperation readability to the listbox. 
                }

                foreach (string extras in chkListExtras.CheckedItems)
                {
                    price = price + bwdPrice;                //price for addional selected itmes are added to price. 
                    listBox1.Items.Add(extras);                 //displays extras selected to listbox.
                    listBox1.Items.Add(bwdPrice.ToString("c"));  //output to listbox displaying,price total and adding extras cost.
                    listBox1.Items.Add("------------");   //addd lines for seperation readability to the listbox. 
                }

                string tprice = price.ToString("c");       //output to listbox displaying the Total price     
                listBox2.Items.Add(tprice);                //varible delared holding the total price from all check items.        
            }
        }
        private bool IsValidData()         //code for data validation. We are checking box is checked
        {
            if (combosize.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a pizza size.",
                                "Entry Error");
                combosize.Focus();
                return false;
            }
            return true;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();              //clearing items from the list of selected pizza items   
            listBox2.Items.Clear();             // clearing the cost totals
            combosize.SelectedIndex = -1;       //clearing out the combobox
            price = 0.0;                        //clearing the price value so we can recalculate the cost.
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // accidental click not needed/or used
        private void pictureBox1_Click(object sender, EventArgs e)//accidental click not needed/or used
        {
        }
        // accidental click not needed/or used
        //not used 
        private void btnAdd_Click(object sender, EventArgs e) //not used  
        {
            //not used 
        }
    }
}
