using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_SimpleCalculator
{
    public partial class Simple_Calculator : Form
    {
        public Simple_Calculator()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// calculates the 2 input boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            if (radBtnDrunk.Checked == true)
            {
                MessageBox.Show("You should not be drunk calculating Sober up and try again");
                
            }

            else
            {
                MessageBox.Show("How boring!");
            }
            txtbox_TotalClowns.Text = (int.Parse(txtbox_ClownsPerCar.Text)* int.Parse(txtbox_NumberOfCars.Text)).ToString();
        }
        /// <summary>
        /// makes the help button work with a pop up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Help_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Help Me!");
            frm_Help frm_Help = new frm_Help();

            frm_Help.ShowDialog();
        }

        private void radBtnDrunk_CheckedChanged(object sender, EventArgs e)
        {
            //show drunk messge
          // MessageBox.Show("You should not be drunk calculating Sober up and try again");
            //frm_DrunkMessage frm_DrunkMessage = new frm_DrunkMessage();
            //frm_DrunkMessage.ShowDialog();
        
        }

        private void radBtnNotDrunk_CheckedChanged(object sender, EventArgs e)
        {
            //show not drunk message
            //MessageBox.Show("How boring!");
        }
    }
}
