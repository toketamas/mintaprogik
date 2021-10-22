using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        List<Item> class1List;
        public MainForm()
        {
            InitializeComponent();
            class1List = new List<Item>();
            class1List.Add(new Item(DateTime.UtcNow.Date.ToString(), "Helló"));
            class1List.Add(new Item(DateTime.UtcNow.Date.ToString(), "Szia"));
            class1List.Add(new Item(DateTime.UtcNow.Date.ToString(), "Szevasz"));
            refreshDataGrid(class1List);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            PopUpForm f2 = new PopUpForm(this, class1List, dateTimePicker1);
            f2.Show();
        }

        public void refreshDataGrid(List<Item> class1s)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = class1s;
            dataGridView1.Refresh();
        }
    }
}
