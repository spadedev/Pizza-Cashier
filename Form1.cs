using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Cashier
{
    public partial class PizzaCashier : Form
    {
        public PizzaCashier()
        {
            InitializeComponent();
        }

        private void deluxe_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (deluxe_rb.Checked)
                cheese_cb.Checked = true;
            bah_cb.Checked = true;
            oac_cb.Checked = true;

            price_txtbox.Text = "Php 185.00";
        }

        private void special_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (special_rb.Checked)
                cheese_cb.Checked = true;
            pepper_cb.Checked = true;
            bah_cb.Checked = true;
            mush_cb.Checked = true;
            oac_cb.Checked = true;

            price_txtbox.Text = "Php 275.00";
        }

        private void primo_rb_CheckedChanged(object sender, EventArgs e)
        {
            if(primo_rb.Checked)
                cheese_cb.Checked = true;
            pepper_cb.Checked = true;
            bah_cb.Checked = true;
            mush_cb.Checked = true;
            oac_cb.Checked = true;
            tap_cb.Checked = true;
            salami_cb.Checked = true;

            price_txtbox.Text = "Php 350.00";
        }

        private void compute_btn_Click(object sender, EventArgs e)
        {
            double price = 0;
            double quantity = 0;
            double total = 0;

            if (deluxe_rb.Checked)
                price = 185;
            if (special_rb.Checked)
                price = 275;
            if (primo_rb.Checked)
                price = 350;

            quantity = Convert.ToDouble(quantity_txtbox.Text);
            total = price * quantity;

            price_txtbox.Text = price.ToString();
            quantity_txtbox.Text = quantity.ToString();
            total_txtbox.Text = total.ToString();
        }
    }
}
