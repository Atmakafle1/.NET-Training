using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class Default : System.Web.UI.Page
    {
        int option;
        string store;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnZero_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = txtBoxResult.Text + "0";
        }

        protected void btnOne_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = txtBoxResult.Text + "1";
        }

        protected void btnTwo_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = txtBoxResult.Text + "2";
        }

        protected void btnThree_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = txtBoxResult.Text + "3";
        }

        protected void btnFour_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = txtBoxResult.Text + "4";
        }

        protected void btnFive_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = txtBoxResult.Text + "5";
        }

        protected void btnSix_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = txtBoxResult.Text + "6";
        }

        protected void btnSeven_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = txtBoxResult.Text + "7";
        }

        protected void btnEight_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = txtBoxResult.Text + "8";
        }

        protected void btnNine_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = txtBoxResult.Text + "9";
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = string.Empty;
        }

        protected void btnMultiply_Click(object sender, EventArgs e)
        {
            option = 1;
            store = txtBoxResult.Text;
            txtBoxResult.Text = string.Empty;
        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
            store = txtBoxResult.Text;
            option = 2;
            txtBoxResult.Text = string.Empty;
        }

        protected void btnMinus_Click(object sender, EventArgs e)
        {
            option = 3;
            store = txtBoxResult.Text;
            txtBoxResult.Text = string.Empty;
        }

        protected void btnPlus_Click(object sender, EventArgs e)
        {
            option = 4;
            store = txtBoxResult.Text;
            txtBoxResult.Text = string.Empty;
        }

        protected void btnEqual_Click(object sender, EventArgs e)
        {
            switch (option)
            {
                case 1:                    
                    txtBoxResult.Text = Convert.ToString(Convert.ToDouble(store) * Convert.ToDouble(txtBoxResult.Text));
                    break;
                case 2:
                    txtBoxResult.Text = Convert.ToString(Convert.ToDouble(store) / Convert.ToDouble(txtBoxResult.Text));
                    break;
                case 3:
                    txtBoxResult.Text = Convert.ToString(Convert.ToDouble(store) - Convert.ToDouble(txtBoxResult.Text));
                    break;
                case 4:
                    txtBoxResult.Text = Convert.ToString(Convert.ToDouble(store) + Convert.ToDouble(txtBoxResult.Text));
                    break;
                
            }
        }

        protected void txtBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}