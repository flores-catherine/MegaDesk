using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void cancelQuote_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        //private void calcQuote_Click(object sender, EventArgs e)
        //{

        //}

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            var ReturnMainMenu = (MainMenu)Tag;
            ReturnMainMenu.Show();
        }

        private void WidthBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(int.TryParse(WidthTextBox.Text, out int WidthInput))
            {
                if(WidthInput < Desk.MINWIDTH || WidthInput > Desk.MAXWIDTH)
                {
                    MessageBox.Text = "Please enter a width from 24 to 96 inches squared.";
                    WidthTextBox.Text = String.Empty;
                    WidthTextBox.BackColor = Color.Red;
                    WidthTextBox.Focus();
                }
                else
                {
                    WidthTextBox.BackColor = Color.GreenYellow;
                    MessageBox.Text = String.Empty;
                }
            }
        }

        private void DepthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

    }
}
