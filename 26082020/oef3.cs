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
    public partial class oef3 : Form
    {
        public oef3()
        {
            InitializeComponent();
        }
        public List<string> Woorden = new List<string>() { "Engels", "Frans", "Spanish", "Italian", "German" };
        public Dictionary<string, List<string>> mijnWoordenboek = new Dictionary<string, List<string>>();
        private void oef3_Load(object sender, EventArgs e)
        {
            mijnWoordenboek.Add("Huis", new List<string> { "Home", "Maison", "Casa", "Casa", "Haus" });
           mijnWoordenboek.Add("Liefde", new List<string> { "Love", "L'amour", "Amor", "Amore", "Liebe" });
            mijnWoordenboek.Add("Aarde", new List<string> { "Earth", "Terre", "Tierra","Terra", "Erde" });
            mijnWoordenboek.Add("Aarde", new List<string> { "Earth", "Terre", "Tierra", "Terra", "Erde" });
            mijnWoordenboek.Add("Aarde", new List<string> { "Earth", "Terre", "Tierra", "Terra", "Erde" });
            mijnWoordenboek.Add("Aarde", new List<string> { "Earth", "Terre", "Tierra", "Terra", "Erde" });

            comboBox1.DataSource = new BindingSource(mijnWoordenboek, null);
            comboBox1.DisplayMember = "Key";
            //foreach (var key in mijnWoordenboek.Keys)
            //{
            //    comboBox1.Items.Add(key);
            //}
            comboBox1.SelectedIndex = 0;
        }

       

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            label1.Text = "";
            KeyValuePair<string, List<string>> dic = (KeyValuePair<string, List<string>>)comboBox1.SelectedItem;
            int count = 0;
            foreach (var item in dic.Value)
            {
                label1.Text += Woorden[count] +" : "+item + "\n";
                count++;
            }

        }
        
}
}
