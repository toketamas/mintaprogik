using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinformEvents
{
    public partial class Form1 : Form
    {
        List<Element> list;

        public Form1()
        {
            InitializeComponent();
            list = new List<Element>();
           

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(((CheckBox)sender).Name);
        }


        //Ha megváltozik a szöveg a textboxban
        private void textBox_TextChanged(object sender, EventArgs e)
        {
          //A sender objektumot Textboxra kasztoljuk
            TextBox textBox = ((TextBox)sender);
            Debug.WriteLine(textBox.Name);
           //Megkeresi a listában az element objektumot ami ezt a textboxot tartalmazza 
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i].ObjectType == "TextBox")
                {
                    if (list[i].TextBox.Name == textBox.Name)
                    {
                        Debug.WriteLine("Régi szöveg: " + list[i].OrigString + "     Új szöveg: " + textBox.Text);
                    }
                }else if (list[i].ObjectType == "CheckBox")
                {
                    //ide jön az amit a checkboxal kellene csinálni és így tovább.
                }

            }
        }       

        //Ha rákattintunk a textboxra
        private void textBox_Click(object sender, EventArgs e)
        {
            //Létrehoz egy element objektumot úgy hogy a sendert textboxá kasztolja
            Element element = new Element((TextBox)sender);
            //megnézi név alapján, tartalmazza e a lista ezt a textboxot ha nem hozzáadja
            bool cond = false;
            for(int i = 0; i < list.Count; i++)
            {
                if (element.TextBox.Name == list[i].TextBox.Name)
                {
                    cond = true;
                }
            }
            if (!cond)
            {
                list.Add(element);
            }           
            //Kiírja a textboxok neveit amelyek a listában szerepelnek
            foreach(Element value in list)
            {
                Debug.WriteLine(value.TextBox.Name);
            }
            Debug.WriteLine("\n");

        }

        private void checkBox_Click(object sender, EventArgs e)
        {
            CheckBox checkBox= (CheckBox)sender;
            Debug.WriteLine("Rákattintottál a " + checkBox.Name + " checkboxra."+"Az állapota: "+ checkBox.Checked+ "  Az előző állapota: " + !checkBox.Checked);
            
        }
    }
}
