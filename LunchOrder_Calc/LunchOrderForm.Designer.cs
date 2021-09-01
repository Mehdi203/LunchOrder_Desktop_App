
namespace LunchOrder_Calc
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.groupBoxMainCourse = new System.Windows.Forms.GroupBox();
            this.radioButtonSalad = new System.Windows.Forms.RadioButton();
            this.radioButtonPizza = new System.Windows.Forms.RadioButton();
            this.radioButtonHam = new System.Windows.Forms.RadioButton();
            this.groupBoxOrderTotal = new System.Windows.Forms.GroupBox();
            this.labelOrderTotal = new System.Windows.Forms.Label();
            this.textBoxOrderTotal = new System.Windows.Forms.TextBox();
            this.labelTax = new System.Windows.Forms.Label();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.textBoxSubTotal = new System.Windows.Forms.TextBox();
            this.buttonPlaceOrder = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxMainCourse.SuspendLayout();
            this.groupBoxOrderTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMainCourse
            // 
            this.groupBoxMainCourse.BackColor = System.Drawing.Color.Khaki;
            this.groupBoxMainCourse.Controls.Add(this.radioButtonSalad);
            this.groupBoxMainCourse.Controls.Add(this.radioButtonPizza);
            this.groupBoxMainCourse.Controls.Add(this.radioButtonHam);
            this.groupBoxMainCourse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxMainCourse.Location = new System.Drawing.Point(21, 31);
            this.groupBoxMainCourse.Name = "groupBoxMainCourse";
            this.groupBoxMainCourse.Size = new System.Drawing.Size(187, 115);
            this.groupBoxMainCourse.TabIndex = 0;
            this.groupBoxMainCourse.TabStop = false;
            this.groupBoxMainCourse.Text = "Main Course";
            // 
            // radioButtonSalad
            // 
            this.radioButtonSalad.AutoSize = true;
            this.radioButtonSalad.Location = new System.Drawing.Point(15, 81);
            this.radioButtonSalad.Name = "radioButtonSalad";
            this.radioButtonSalad.Size = new System.Drawing.Size(119, 25);
            this.radioButtonSalad.TabIndex = 2;
            this.radioButtonSalad.TabStop = true;
            this.radioButtonSalad.Text = "Salad - $4.95";
            this.radioButtonSalad.UseVisualStyleBackColor = true;
            this.radioButtonSalad.CheckedChanged += new System.EventHandler(this.radioButtonSalad_CheckedChanged);
            // 
            // radioButtonPizza
            // 
            this.radioButtonPizza.AutoSize = true;
            this.radioButtonPizza.Location = new System.Drawing.Point(15, 56);
            this.radioButtonPizza.Name = "radioButtonPizza";
            this.radioButtonPizza.Size = new System.Drawing.Size(116, 25);
            this.radioButtonPizza.TabIndex = 1;
            this.radioButtonPizza.TabStop = true;
            this.radioButtonPizza.Text = "Pizza - $5.95";
            this.radioButtonPizza.UseVisualStyleBackColor = true;
            this.radioButtonPizza.CheckedChanged += new System.EventHandler(this.radioButtonPizza_CheckedChanged);
            // 
            // radioButtonHam
            // 
            this.radioButtonHam.AutoSize = true;
            this.radioButtonHam.Location = new System.Drawing.Point(15, 31);
            this.radioButtonHam.Name = "radioButtonHam";
            this.radioButtonHam.Size = new System.Drawing.Size(161, 25);
            this.radioButtonHam.TabIndex = 0;
            this.radioButtonHam.TabStop = true;
            this.radioButtonHam.Text = "Hamburger - $6.95";
            this.radioButtonHam.UseVisualStyleBackColor = true;
            this.radioButtonHam.CheckedChanged += new System.EventHandler(this.radioButtonHam_CheckedChanged);
            // 
            // groupBoxOrderTotal
            // 
            this.groupBoxOrderTotal.BackColor = System.Drawing.Color.LightBlue;
            this.groupBoxOrderTotal.Controls.Add(this.labelOrderTotal);
            this.groupBoxOrderTotal.Controls.Add(this.textBoxOrderTotal);
            this.groupBoxOrderTotal.Controls.Add(this.labelTax);
            this.groupBoxOrderTotal.Controls.Add(this.textBoxTax);
            this.groupBoxOrderTotal.Controls.Add(this.labelSubTotal);
            this.groupBoxOrderTotal.Controls.Add(this.textBoxSubTotal);
            this.groupBoxOrderTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxOrderTotal.Location = new System.Drawing.Point(21, 188);
            this.groupBoxOrderTotal.Name = "groupBoxOrderTotal";
            this.groupBoxOrderTotal.Size = new System.Drawing.Size(355, 227);
            this.groupBoxOrderTotal.TabIndex = 2;
            this.groupBoxOrderTotal.TabStop = false;
            this.groupBoxOrderTotal.Text = "Order Total";
            // 
            // labelOrderTotal
            // 
            this.labelOrderTotal.AutoSize = true;
            this.labelOrderTotal.Location = new System.Drawing.Point(25, 173);
            this.labelOrderTotal.Name = "labelOrderTotal";
            this.labelOrderTotal.Size = new System.Drawing.Size(87, 21);
            this.labelOrderTotal.TabIndex = 5;
            this.labelOrderTotal.Text = "Order Total";
            // 
            // textBoxOrderTotal
            // 
            this.textBoxOrderTotal.Location = new System.Drawing.Point(113, 161);
            this.textBoxOrderTotal.Multiline = true;
            this.textBoxOrderTotal.Name = "textBoxOrderTotal";
            this.textBoxOrderTotal.ReadOnly = true;
            this.textBoxOrderTotal.Size = new System.Drawing.Size(184, 44);
            this.textBoxOrderTotal.TabIndex = 4;
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(25, 111);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(67, 21);
            this.labelTax.TabIndex = 3;
            this.labelTax.Text = "Tax (5%)";
            // 
            // textBoxTax
            // 
            this.textBoxTax.Location = new System.Drawing.Point(113, 99);
            this.textBoxTax.Multiline = true;
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.ReadOnly = true;
            this.textBoxTax.Size = new System.Drawing.Size(184, 44);
            this.textBoxTax.TabIndex = 2;
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Location = new System.Drawing.Point(25, 54);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(66, 21);
            this.labelSubTotal.TabIndex = 1;
            this.labelSubTotal.Text = "Subtoal:";
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.Location = new System.Drawing.Point(113, 40);
            this.textBoxSubTotal.Multiline = true;
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.ReadOnly = true;
            this.textBoxSubTotal.Size = new System.Drawing.Size(184, 44);
            this.textBoxSubTotal.TabIndex = 0;
            // 
            // buttonPlaceOrder
            // 
            this.buttonPlaceOrder.BackColor = System.Drawing.Color.Lime;
            this.buttonPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlaceOrder.Location = new System.Drawing.Point(435, 200);
            this.buttonPlaceOrder.Name = "buttonPlaceOrder";
            this.buttonPlaceOrder.Size = new System.Drawing.Size(113, 39);
            this.buttonPlaceOrder.TabIndex = 3;
            this.buttonPlaceOrder.Text = "Place Order";
            this.buttonPlaceOrder.UseVisualStyleBackColor = false;
            this.buttonPlaceOrder.Click += new System.EventHandler(this.buttonPlaceOrder_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(435, 343);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(113, 39);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Yellow;
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.Location = new System.Drawing.Point(435, 266);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(113, 39);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(580, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Order
            // 
            this.AcceptButton = this.buttonPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(848, 440);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPlaceOrder);
            this.Controls.Add(this.groupBoxOrderTotal);
            this.Controls.Add(this.groupBoxMainCourse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Order";
            this.Text = "Lunch Order";
            this.groupBoxMainCourse.ResumeLayout(false);
            this.groupBoxMainCourse.PerformLayout();
            this.groupBoxOrderTotal.ResumeLayout(false);
            this.groupBoxOrderTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMainCourse;
        private System.Windows.Forms.RadioButton radioButtonSalad;
        private System.Windows.Forms.RadioButton radioButtonPizza;
        private System.Windows.Forms.RadioButton radioButtonHam;
        private System.Windows.Forms.GroupBox groupBoxOrderTotal;
        private System.Windows.Forms.Label labelOrderTotal;
        private System.Windows.Forms.TextBox textBoxOrderTotal;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.TextBox textBoxSubTotal;
        private System.Windows.Forms.Button buttonPlaceOrder;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

