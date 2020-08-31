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
    public partial class oef2 : Form
    {
        public oef2()
        {
            InitializeComponent();
        }
        Dictionary<string, string> mijnWoordenboek = new Dictionary<string, string>();
        private void oef2_Load(object sender, EventArgs e)
        {
            
            mijnWoordenboek.Add("Toetsenbord", "Keyboard");
            mijnWoordenboek.Add("Muis", "Mouse");
            mijnWoordenboek.Add("Schijf", "Drive");
            comboBox1.DataSource = new BindingSource(mijnWoordenboek, null);
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<string, string> pair = (KeyValuePair<string, string>)comboBox1.SelectedItem;
            label1.Text = pair.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                mijnWoordenboek.Add(textBox1.Text, textBox2.Text);
                textBox1.Clear();
                textBox2.Clear();
            }
            comboBox1.DataSource = new BindingSource(mijnWoordenboek, null);
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text != "" && textBox2.Text != "")
            //{
            //    mijnWoordenboek.Remove(textBox1.Text);
            //    textBox1.Clear();
            //    textBox2.Clear();
            //}
            KeyValuePair<string, string> pair = (KeyValuePair<string, string>)comboBox1.SelectedItem;
            mijnWoordenboek.Remove(pair.Key);
            comboBox1.DataSource = new BindingSource(mijnWoordenboek, null);
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";

        }
    }
}
