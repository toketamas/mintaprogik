using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PopUpForm : Form
    {
        MainForm form1;
        List<Item> class1s;
        DateTimePicker date;

        public PopUpForm()
        {
            InitializeComponent();
        }


        public PopUpForm(MainForm form1, List<Item> class1s,DateTimePicker datePicker)
        {
            this.form1 = form1;
            this.class1s = class1s;
            this.date = datePicker;            
            InitializeComponent();
            dateTimePicker1.Value = datePicker.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            class1s.Add(new Item(dateTimePicker1.Value.ToString(), textBox1.Text));           
            form1.refreshDataGrid(class1s);
            this.Close();
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.button1.Enabled = true;           
        }
    }
}
