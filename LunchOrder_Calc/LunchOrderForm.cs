/******************************
 This C# application that accepts a lunch order from the user
 and calculates the order subtotal and total with 5% tax added.
 ***************************/
/******************************
Created by:
Mehdi Noroozi

Date: August 31, 2021
 ***************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder_Calc
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        GroupBox groupBoxAddOn = new GroupBox();


        private void radioButtonHam_CheckedChanged(object sender, EventArgs e)
        {
            /******
             * Added a group box for the Add-on menue when the main course is Hamburger.
             * The items of this groupbox will chnage based on selection of main course.
             * Define groupBoxAddOn
            */
            int counter = groupBoxAddOn.Controls.Count;

            //Remove groupbox when deselecting a main course and select another main course 
            for (int i = counter - 1; i >= 0; i--)
            groupBoxAddOn.Controls.Remove(groupBoxAddOn.Controls[i]);

            //adding groupbox when the user select a main course
            this.Controls.Add(groupBoxAddOn);

            groupBoxAddOn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBoxAddOn.Location = new System.Drawing.Point(252, 31);
            groupBoxAddOn.Name = "groupBoxAddOn";
            groupBoxAddOn.Size = new System.Drawing.Size(252, 115);
            groupBoxAddOn.TabIndex = 6;
            groupBoxAddOn.TabStop = false;
            groupBoxAddOn.Text = "Add-on items ($0.75/each)";
            // 
            // checkBox1: creating first add-on for the add on when the main course is hamburger
            CheckBox checkBox1 = new CheckBox();
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(9, 81);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(113, 25);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "French Fries";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2:  creating second add-on for the add on when the main course is hamburger
            CheckBox checkBox2 = new CheckBox();
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new System.Drawing.Point(9, 56);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(226, 25);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Ketchup, mustard, and mayo";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3:  creating third add-on for the add on when the main course is hamburger
            CheckBox checkBox3 = new CheckBox();
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new System.Drawing.Point(9, 29);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new System.Drawing.Size(224, 25);
            checkBox3.TabIndex = 0;
            checkBox3.Text = "Lettuce, Tomato, and Onions";
            checkBox3.UseVisualStyleBackColor = true;

            groupBoxAddOn.Controls.Add(checkBox1);
            groupBoxAddOn.Controls.Add(checkBox2);
            groupBoxAddOn.Controls.Add(checkBox3);
            //// 
        }
        /******
 * Added a group box for the Add-on menue when the main course is Pizza.
 * The items of this groupbox will chnage based on selection of main course.
 * Define groupBoxAddOn
*/
        // Pizza Toppings

        private void radioButtonPizza_CheckedChanged(object sender, EventArgs e)
        {
            // groupBoxAddOn
            //
            int counter = groupBoxAddOn.Controls.Count;
            for (int i = counter - 1; i >= 0; i--)
            groupBoxAddOn.Controls.Remove(groupBoxAddOn.Controls[i]);

            this.Controls.Add(groupBoxAddOn);
            

            groupBoxAddOn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBoxAddOn.Location = new System.Drawing.Point(252, 31);
            groupBoxAddOn.Name = "groupBoxAddOn";
            groupBoxAddOn.Size = new System.Drawing.Size(252, 115);
            groupBoxAddOn.TabIndex = 6;
            groupBoxAddOn.TabStop = false;
            groupBoxAddOn.Text = "Add-on items ($0.5/each)";
            // 
            // checkBox1:creating first add-on for the add on when the main course is Pizza
            CheckBox checkBox1 = new CheckBox();
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(9, 81);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(113, 25);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Pepperoni";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2: creating 2nd add-on for the add on when the main course is Pizza
            CheckBox checkBox2 = new CheckBox();
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new System.Drawing.Point(9, 56);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(226, 25);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Sausage";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3:creating 3rd add-on for the add on when the main course is Pizza
            CheckBox checkBox3 = new CheckBox();
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new System.Drawing.Point(9, 29);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new System.Drawing.Size(224, 25);
            checkBox3.TabIndex = 0;
            checkBox3.Text = "Olives";
            checkBox3.UseVisualStyleBackColor = true;

            groupBoxAddOn.Controls.Add(checkBox1);
            groupBoxAddOn.Controls.Add(checkBox2);
            groupBoxAddOn.Controls.Add(checkBox3);
            ////
        }
        /******
 * Added a group box for the Add-on menue when the main course is Salad.
 * The items of this groupbox will chnage based on selection of main course.
 * Define groupBoxAddOn
*/
        //Salad Toppings
        private void radioButtonSalad_CheckedChanged(object sender, EventArgs e)
        {
            // groupBoxAddOn
            //
            int counter = groupBoxAddOn.Controls.Count;
            for (int i = counter - 1; i >= 0; i--)
                groupBoxAddOn.Controls.Remove(groupBoxAddOn.Controls[i]);

            this.Controls.Add(groupBoxAddOn);


            groupBoxAddOn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBoxAddOn.Location = new System.Drawing.Point(252, 31);
            groupBoxAddOn.Name = "groupBoxAddOn";
            groupBoxAddOn.Size = new System.Drawing.Size(252, 115);
            groupBoxAddOn.TabIndex = 6;
            groupBoxAddOn.TabStop = false;
            groupBoxAddOn.Text = "Add-on items ($0.25/each)";
            // 
            // checkBox1: creating first add-on for the add on when the main course is Salad
            CheckBox checkBox1 = new CheckBox();
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(9, 81);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(113, 25);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Croutons";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2: creating 2nd add-on for the add on when the main course is Salad
            CheckBox checkBox2 = new CheckBox();
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new System.Drawing.Point(9, 56);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(226, 25);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Bacon Bits";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3: creating 3rd add-on for the add on when the main course is Salad
            CheckBox checkBox3 = new CheckBox();
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new System.Drawing.Point(9, 29);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new System.Drawing.Size(224, 25);
            checkBox3.TabIndex = 0;
            checkBox3.Text = "Bread Sticks";
            checkBox3.UseVisualStyleBackColor = true;

            groupBoxAddOn.Controls.Add(checkBox1);
            groupBoxAddOn.Controls.Add(checkBox2);
            groupBoxAddOn.Controls.Add(checkBox3);

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

/****
 * ******
 * ***Main Calcualtion Section
 * ******
 *///
        private void buttonPlaceOrder_Click(object sender, EventArgs e)
        {
            decimal MainCoursePrice, TaxRate, SubTotal, AddonPrice=0.0m;

            TaxRate = 0.05m;

            if (radioButtonHam.Checked)
            { 
                MainCoursePrice = 6.95m;
                AddonPrice = 0.75m;
            }
            else if (radioButtonPizza.Checked)
            {
                MainCoursePrice = 5.95m;
                AddonPrice = 0.5m;
            }

            else
            {
                MainCoursePrice = 4.95m;
                AddonPrice = 0.25m;
            }

            //Calculate number of add-on items
            
            int AddonQuantity = groupBoxAddOn.Controls.OfType<CheckBox>().Count(x => x.Checked);
            

            SubTotal = MainCoursePrice + AddonQuantity * AddonPrice;
            textBoxSubTotal.Text = SubTotal.ToString("C");
            //textBoxTax.Text = Math.Round((SubTotal*TaxRate),2).ToString("C");
            //textBoxOrderTotal.Text = Math.Round((SubTotal + SubTotal * TaxRate),2).ToString("C");

            /*****************
             * Convert to method
             */

            //Define parametrs for the CalcTax method
            decimal OrderTotalCalc, TaxCalc;

            //output Tax and total order
            CalcTax(ref SubTotal, out TaxCalc, out OrderTotalCalc);
            
            //Pass tax and total order to the form
            textBoxTax.Text = TaxCalc.ToString("C");
            textBoxOrderTotal.Text = OrderTotalCalc.ToString("C");
        }

        //Define a Method to calculate tax and total order
        
        public static void CalcTax(ref decimal SubTotal,  
            out decimal TaxCalc, out decimal OrderTotalCalc, decimal TaxRate = 0.05m)
        {
            TaxCalc = Math.Round((TaxRate * SubTotal), 2); //calculate tax
            OrderTotalCalc = Math.Round((SubTotal + SubTotal * TaxRate), 2); //calculate total order
   
        }

        //Reset button
        private void buttonReset_Click(object sender, EventArgs e)
        {

            //Clear calculation section

            textBoxSubTotal.Clear();
            textBoxTax.Clear();
            textBoxOrderTotal.Clear();

            //Clear all check items in add-on groupbox
            foreach (CheckBox c in groupBoxAddOn.Controls.OfType<CheckBox>())
            {
                c.Checked = false;
            }

            radioButtonHam.Checked = true;


            
        }
    }
}
