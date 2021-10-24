using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PopUpForm : Form
    {
        MainForm main;
             

        public PopUpForm()
        {
            InitializeComponent();
        }


        public PopUpForm(MainForm main,DateTime date)
        {
            this.main = main;                                  
            InitializeComponent();
            dateTimePicker1.Value = date;
        }

        private void button1_Click(object sender, EventArgs e)
        {                       
            main.refreshDataGrid(new Item(dateTimePicker1.Value.ToString(), textBox1.Text));
            this.Close();            
        }     

        private void PopUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.buttonIsEnable(true);
        }
    }
}
