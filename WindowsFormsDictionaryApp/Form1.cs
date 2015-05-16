using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDictionaryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string,string> myDictionary=new Dictionary<string, string>();

            myDictionary.Add("101","CSE101");
            myDictionary.Add("102", "CSE102");
            myDictionary.Add("103", "CSE103");
            myDictionary.Add("104", "CSE104");

            if (myDictionary.ContainsKey(code.Text))
            {
                MessageBox.Show(myDictionary[TextBox.]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
