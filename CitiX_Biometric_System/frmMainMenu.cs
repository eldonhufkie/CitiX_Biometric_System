using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CitiX_Biometric_System
{
    public partial class frmMainMenu : Form
    {
        string inputPin;
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ClearEverything_Click(object sender, EventArgs e)
        {
            inputPin = "";
            txtPin.Text = inputPin;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            inputPin += "0";
            txtPin.Text = inputPin;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            inputPin += "1";
            txtPin.Text = inputPin;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            inputPin += "2";
            txtPin.Text = inputPin;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            inputPin += "3";
            txtPin.Text = inputPin;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            inputPin += "4";
            txtPin.Text = inputPin;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            inputPin += "5";
            txtPin.Text = inputPin;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            inputPin += "6";
            txtPin.Text = inputPin;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            inputPin += "7";
            txtPin.Text = inputPin;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            inputPin += "8";
            txtPin.Text = inputPin;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            inputPin += "9";
            txtPin.Text = inputPin;
        }

        private void frmMainMenu_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
