using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using XMlproect;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadEmloyees();
        }

        public void LoadEmloyees()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("XMLFile2.xml");

            foreach (XmlNode node in xml.DocumentElement)
            {
                string Name = node.Attributes[0].Value;
                int Age = int.Parse(node["Age"].InnerText);
                bool OnHoliday = bool.Parse(node["OnHoliday"].InnerText);
                listBox1.Items.Add(new Employee (Name, Age, OnHoliday));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != 1)
            {
                propertyGrid1.SelectedObject = listBox1.SelectedItem;
            }
        }
    }
}
