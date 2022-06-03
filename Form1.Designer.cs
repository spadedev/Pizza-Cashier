
namespace Pizza_Cashier
{
    partial class PizzaCashier
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.price_txtbox = new System.Windows.Forms.TextBox();
            this.quantity_txtbox = new System.Windows.Forms.TextBox();
            this.compute_btn = new System.Windows.Forms.Button();
            this.total_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cheese_cb = new System.Windows.Forms.CheckBox();
            this.pepper_cb = new System.Windows.Forms.CheckBox();
            this.bah_cb = new System.Windows.Forms.CheckBox();
            this.mush_cb = new System.Windows.Forms.CheckBox();
            this.oac_cb = new System.Windows.Forms.CheckBox();
            this.tap_cb = new System.Windows.Forms.CheckBox();
            this.salami_cb = new System.Windows.Forms.CheckBox();
            this.deluxe_rb = new System.Windows.Forms.RadioButton();
            this.special_rb = new System.Windows.Forms.RadioButton();
            this.primo_rb = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.primo_rb);
            this.groupBox1.Controls.Add(this.special_rb);
            this.groupBox1.Controls.Add(this.deluxe_rb);
            this.groupBox1.Location = new System.Drawing.Point(23, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizza:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.salami_cb);
            this.groupBox2.Controls.Add(this.tap_cb);
            this.groupBox2.Controls.Add(this.oac_cb);
            this.groupBox2.Controls.Add(this.mush_cb);
            this.groupBox2.Controls.Add(this.bah_cb);
            this.groupBox2.Controls.Add(this.pepper_cb);
            this.groupBox2.Controls.Add(this.cheese_cb);
            this.groupBox2.Location = new System.Drawing.Point(274, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 235);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingredients:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity:";
            // 
            // price_txtbox
            // 
            this.price_txtbox.Location = new System.Drawing.Point(127, 204);
            this.price_txtbox.Name = "price_txtbox";
            this.price_txtbox.Size = new System.Drawing.Size(132, 20);
            this.price_txtbox.TabIndex = 4;
            // 
            // quantity_txtbox
            // 
            this.quantity_txtbox.Location = new System.Drawing.Point(127, 234);
            this.quantity_txtbox.Name = "quantity_txtbox";
            this.quantity_txtbox.Size = new System.Drawing.Size(132, 20);
            this.quantity_txtbox.TabIndex = 5;
            // 
            // compute_btn
            // 
            this.compute_btn.Location = new System.Drawing.Point(127, 279);
            this.compute_btn.Name = "compute_btn";
            this.compute_btn.Size = new System.Drawing.Size(252, 23);
            this.compute_btn.TabIndex = 6;
            this.compute_btn.Text = "Compute Now!";
            this.compute_btn.UseVisualStyleBackColor = true;
            this.compute_btn.Click += new System.EventHandler(this.compute_btn_Click);
            // 
            // total_txtbox
            // 
            this.total_txtbox.Location = new System.Drawing.Point(127, 328);
            this.total_txtbox.Name = "total_txtbox";
            this.total_txtbox.Size = new System.Drawing.Size(132, 20);
            this.total_txtbox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Amount:";
            // 
            // cheese_cb
            // 
            this.cheese_cb.AutoSize = true;
            this.cheese_cb.Location = new System.Drawing.Point(35, 45);
            this.cheese_cb.Name = "cheese_cb";
            this.cheese_cb.Size = new System.Drawing.Size(62, 17);
            this.cheese_cb.TabIndex = 0;
            this.cheese_cb.Text = "Cheese";
            this.cheese_cb.UseVisualStyleBackColor = true;
            // 
            // pepper_cb
            // 
            this.pepper_cb.AutoSize = true;
            this.pepper_cb.Location = new System.Drawing.Point(35, 68);
            this.pepper_cb.Name = "pepper_cb";
            this.pepper_cb.Size = new System.Drawing.Size(60, 17);
            this.pepper_cb.TabIndex = 1;
            this.pepper_cb.Text = "Pepper";
            this.pepper_cb.UseVisualStyleBackColor = true;
            // 
            // bah_cb
            // 
            this.bah_cb.AutoSize = true;
            this.bah_cb.Location = new System.Drawing.Point(35, 91);
            this.bah_cb.Name = "bah_cb";
            this.bah_cb.Size = new System.Drawing.Size(103, 17);
            this.bah_cb.TabIndex = 2;
            this.bah_cb.Text = "Bacon and Ham";
            this.bah_cb.UseVisualStyleBackColor = true;
            // 
            // mush_cb
            // 
            this.mush_cb.AutoSize = true;
            this.mush_cb.Location = new System.Drawing.Point(35, 114);
            this.mush_cb.Name = "mush_cb";
            this.mush_cb.Size = new System.Drawing.Size(75, 17);
            this.mush_cb.TabIndex = 3;
            this.mush_cb.Text = "Mushroom";
            this.mush_cb.UseVisualStyleBackColor = true;
            // 
            // oac_cb
            // 
            this.oac_cb.AutoSize = true;
            this.oac_cb.Location = new System.Drawing.Point(35, 137);
            this.oac_cb.Name = "oac_cb";
            this.oac_cb.Size = new System.Drawing.Size(102, 17);
            this.oac_cb.TabIndex = 4;
            this.oac_cb.Text = "Onions and Chili";
            this.oac_cb.UseVisualStyleBackColor = true;
            // 
            // tap_cb
            // 
            this.tap_cb.AutoSize = true;
            this.tap_cb.Location = new System.Drawing.Point(35, 160);
            this.tap_cb.Name = "tap_cb";
            this.tap_cb.Size = new System.Drawing.Size(133, 17);
            this.tap_cb.TabIndex = 5;
            this.tap_cb.Text = "Tomato and Pineapple";
            this.tap_cb.UseVisualStyleBackColor = true;
            // 
            // salami_cb
            // 
            this.salami_cb.AutoSize = true;
            this.salami_cb.Location = new System.Drawing.Point(35, 183);
            this.salami_cb.Name = "salami_cb";
            this.salami_cb.Size = new System.Drawing.Size(57, 17);
            this.salami_cb.TabIndex = 6;
            this.salami_cb.Text = "Salami";
            this.salami_cb.UseVisualStyleBackColor = true;
            // 
            // deluxe_rb
            // 
            this.deluxe_rb.AutoSize = true;
            this.deluxe_rb.Location = new System.Drawing.Point(32, 44);
            this.deluxe_rb.Name = "deluxe_rb";
            this.deluxe_rb.Size = new System.Drawing.Size(58, 17);
            this.deluxe_rb.TabIndex = 0;
            this.deluxe_rb.TabStop = true;
            this.deluxe_rb.Text = "Deluxe";
            this.deluxe_rb.UseVisualStyleBackColor = true;
            this.deluxe_rb.CheckedChanged += new System.EventHandler(this.deluxe_rb_CheckedChanged);
            // 
            // special_rb
            // 
            this.special_rb.AutoSize = true;
            this.special_rb.Location = new System.Drawing.Point(32, 90);
            this.special_rb.Name = "special_rb";
            this.special_rb.Size = new System.Drawing.Size(63, 17);
            this.special_rb.TabIndex = 1;
            this.special_rb.TabStop = true;
            this.special_rb.Text = "Special ";
            this.special_rb.UseVisualStyleBackColor = true;
            this.special_rb.CheckedChanged += new System.EventHandler(this.special_rb_CheckedChanged);
            // 
            // primo_rb
            // 
            this.primo_rb.AutoSize = true;
            this.primo_rb.Location = new System.Drawing.Point(32, 136);
            this.primo_rb.Name = "primo_rb";
            this.primo_rb.Size = new System.Drawing.Size(51, 17);
            this.primo_rb.TabIndex = 2;
            this.primo_rb.TabStop = true;
            this.primo_rb.Text = "Primo";
            this.primo_rb.UseVisualStyleBackColor = true;
            this.primo_rb.CheckedChanged += new System.EventHandler(this.primo_rb_CheckedChanged);
            // 
            // PizzaCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 378);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.total_txtbox);
            this.Controls.Add(this.compute_btn);
            this.Controls.Add(this.quantity_txtbox);
            this.Controls.Add(this.price_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PizzaCashier";
            this.Text = "Pizza Cashier";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton primo_rb;
        private System.Windows.Forms.RadioButton special_rb;
        private System.Windows.Forms.RadioButton deluxe_rb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox salami_cb;
        private System.Windows.Forms.CheckBox tap_cb;
        private System.Windows.Forms.CheckBox oac_cb;
        private System.Windows.Forms.CheckBox mush_cb;
        private System.Windows.Forms.CheckBox bah_cb;
        private System.Windows.Forms.CheckBox pepper_cb;
        private System.Windows.Forms.CheckBox cheese_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox price_txtbox;
        private System.Windows.Forms.TextBox quantity_txtbox;
        private System.Windows.Forms.Button compute_btn;
        private System.Windows.Forms.TextBox total_txtbox;
        private System.Windows.Forms.Label label3;
    }
}

