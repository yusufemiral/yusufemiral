using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToolTip_uygulaması_form_tasarım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(txtAd, "Adınızı Giriniz");
            tt.SetToolTip(txtSoyad, "Soyadınızı Giriniz");
            tt.SetToolTip(txtDtarihi, "Doğum tarihinizi gg/aa/yyyy şeklinde giriniz.");
            tt.SetToolTip(txtAdres, "Adresinizi Giriniz");
            tt.SetToolTip(btnKaydet, "Kaydetmek İçin Tıklayınız");
        }
    }
}
