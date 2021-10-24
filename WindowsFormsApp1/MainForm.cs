using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        List<Item> itemList;
        public MainForm()
        {
            InitializeComponent();
            itemList = new List<Item>();
            refreshDataGrid(new Item(DateTime.Now.Date.ToString(), "Helló"));
            refreshDataGrid(new Item(DateTime.Now.Date.ToString(), "Szia"));
            refreshDataGrid(new Item(DateTime.Now.Date.ToString(), "Szevasz"));            
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            buttonIsEnable(false);
            new PopUpForm(this, dateTimePicker1.Value).Show();            
        }

        public void refreshDataGrid(Item item)
        {
            itemList.Add(item);
            dataGridView1.DataSource = null;            
            dataGridView1.DataSource = itemList;
            dataGridView1.Refresh();
        }

        public void buttonIsEnable(bool value)
        {
            button1.Enabled = value;
        }
    }
}
