using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Dictionary<Int32, string> di = new Dictionary<Int32, string>();

            di.Add(43, "Maj");
            di.Add(54, "Telefon");
            di.Add(62, "Avgust");
            di.Add(89, "Tocak");
            di.Add(74, "Motor");
            di.Add(67, "Avion");
            di.Add(42, "Brod");

            Dictionary<string, string> di2 = new Dictionary<string, string>();

            di2.Add("UK", "London");

            Dictionary<string, Button> di3 = new Dictionary<string, Button>();

            di3.Add("Button1",btnRead);

        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {

                Dictionary<Int32, string> di = new Dictionary<Int32, string>();

                di.Add(43, "Maj");
                di.Add(54, "Telefon");
                di.Add(62, "Avgust");
                di.Add(89, "Tocak");
                di.Add(74, "Motor");
                di.Add(67, "Avion");
                di.Add(42, "Brod");

                Int32 key;
                Int32.TryParse(txtKey.Text, out key);

                Text = di[key];
            }
            catch
            {
                MessageBox.Show("Not Found");
            }              
            
        }
        private void btnWrite_Click(object sender, EventArgs e)
        {

            Dictionary<Int32, string> di = new Dictionary<Int32, string>();

            di.Add(43, "Maj");
            di.Add(54, "Telefon");
            di.Add(62, "Avgust");
            di.Add(89, "Tocak");
            di.Add(74, "Motor");
            di.Add(67, "Avion");
            di.Add(42, "Brod");

            Int32 key;
            Int32.TryParse(txtKey.Text, out key);

            di[key] = "Test";
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            Dictionary<Int32, string> di = new Dictionary<Int32, string>();

            di.Add(43, "Maj");
            di.Add(54, "Telefon");
            di.Add(62, "Avgust");
            di.Add(89, "Tocak");
            di.Add(74, "Motor");
            di.Add(67, "Avion");
            di.Add(42, "Brod");

            Int32 key;
            Int32.TryParse(txtKey.Text, out key);

            Boolean r;
            r = di.Remove(key);

            if (r==true)
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Noo Deleted");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {

            Dictionary<Int32, string> di = new Dictionary<Int32, string>();

            di.Add(43, "Maj");
            di.Add(54, "Telefon");
            di.Add(62, "Avgust");
            di.Add(89, "Tocak");
            di.Add(74, "Motor");
            di.Add(67, "Avion");
            di.Add(42, "Brod");

            txtKey.Text = di.Count().ToString();
        }
        private void button6_Click(object sender, EventArgs e)
        {

            Dictionary<Int32, string> di = new Dictionary<Int32, string>();

            di.Add(43, "Maj");
            di.Add(54, "Telefon");
            di.Add(62, "Avgust");
            di.Add(89, "Tocak");
            di.Add(74, "Motor");
            di.Add(67, "Avion");
            di.Add(42, "Brod");

            foreach (var item in di)
            {
                keyListBox.Items.Add(item.Key);
                ValueListBox.Items.Add(item.Value);
            }
            //------------------------------------------
            keyListBox.Items.Clear();
            ValueListBox.Items.Clear();

            foreach (KeyValuePair <Int32, string> item in di)
            {
                keyListBox.Items.Add(item.Key);
                ValueListBox.Items.Add(item.Value);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {

            Dictionary<Int32, string> di = new Dictionary<Int32, string>();

            di.Add(43, "Maj");
            di.Add(54, "Telefon");
            di.Add(62, "Avgust");
            di.Add(89, "Tocak");
            di.Add(74, "Motor");
            di.Add(67, "Avion");
            di.Add(42, "Brod");

            di.Clear();
        }
        private void button8_Click(object sender, EventArgs e)
        {

            Dictionary<Int32, string> di = new Dictionary<Int32, string>();

            di.Add(43, "Maj");
            di.Add(54, "Telefon");
            di.Add(62, "Avgust");
            di.Add(89, "Tocak");
            di.Add(74, "Motor");
            di.Add(67, "Avion");
            di.Add(42, "Brod");

            Int32[] target_keys = new Int32[di.Count()];
            di.Keys.CopyTo(target_keys, 0);

            //-------------------------------------------------------
            string[] target_values = new string[di.Count()];
            di.Values.CopyTo(target_values, 0);
        }
        private void button9_Click(object sender, EventArgs e)
        {

            Dictionary<Int32, string> di = new Dictionary<Int32, string>();

            di.Add(43, "Maj");
            di.Add(54, "Telefon");
            di.Add(62, "Avgust");
            di.Add(89, "Tocak");
            di.Add(74, "Motor");
            di.Add(67, "Avion");

            Int32 key;
            Int32.TryParse(txtKeyy.Text, out key);
            Boolean r;
            r = di.ContainsKey(key);

            if (r == true)
            {
                MessageBox.Show("Fond");
            }
            else
            {
                MessageBox.Show("Not found");
            }

        }
        private void button10_Click(object sender, EventArgs e)
        {

            Dictionary<Int32, string> di = new Dictionary<Int32, string>();

            di.Add(43, "Maj");
            di.Add(54, "Telefon");
            di.Add(62, "Avgust");
            di.Add(89, "Tocak");
            di.Add(74, "Motor");
            di.Add(67, "Avion");

            //string key;
            //string.TryParse(txtValue.Text, out key);
            Boolean r;
            r = di.ContainsValue(txtValue.Text);

            if (r == true)
            {
                MessageBox.Show("Fond");
            }
            else
            {
                MessageBox.Show("Not found");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            SortedDictionary<Int32, string> di = new SortedDictionary<Int32, string>();

            di.Add(43, "Maj");
            di.Add(54, "Telefon");
            di.Add(62, "Avgust");
            di.Add(89, "Tocak");
            di.Add(74, "Motor");
            di.Add(67, "Avion");
        }
    }
}
