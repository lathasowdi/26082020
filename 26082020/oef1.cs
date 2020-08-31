using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26082020
{
    public partial class oef1 : Form
    {
        public oef1()
        {
            InitializeComponent();
        }
        Dictionary<int, string> mijnDictionary = new Dictionary<int, string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            mijnDictionary.Add(1, "Een");
            mijnDictionary.Add(2, "Twee");
            mijnDictionary.Add(3, "Drie");
            mijnDictionary.Add(4, "Vier");
            mijnDictionary.Add(5, "Vijf");
            mijnDictionary.Add(6, "Zes");
            mijnDictionary.Add(7, "Zeven");
            mijnDictionary.Add(8, "Acht");
            mijnDictionary.Add(9, "Negen");
            mijnDictionary.Add(10, "Tien");

            //comboBox1.DataSource = new BindingSource(mijnDictionary, null);
            //comboBox1.DisplayMember = "Key";
            //comboBox1.ValueMember = "Value";
            foreach (KeyValuePair<int, string> item in mijnDictionary)
            {
                comboBox1.Items.Add(item.Key);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        {
            //KeyValuePair<int, string> pair = (KeyValuePair<int, string>)comboBox1.SelectedItem;
            //label1.Text = pair.Value;

            label1.Text = mijnDictionary[comboBox1.SelectedIndex + 1];


        }
    }
}
