using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = HavaApi.HavaApi.SehirListesiVer();
            comboBox1.ValueMember = "sehir";
            comboBox1.DisplayMember = "sehir";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var snc = HavaApi.HavaApi.HavaDurumu(comboBox1.SelectedValue.ToString());
            webBrowser1.Navigate(snc.SvgUrl);
            labelDurum.Text = snc.Durum;
            labelSıcaklık.Text = $"{snc.EnYuksek}° / {snc.EnDusuk}°";
            labelŞehir.Text = snc.Sehir;
        }
    }
}
