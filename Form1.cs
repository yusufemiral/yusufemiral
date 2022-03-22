using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Giriş_maskeleme_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                    }

        private void Form1_Load(object sender, EventArgs e)
        {
            maskTc.Mask = "00000000000";
            maskTelefon.Mask = "(999) 000 00 00";
            maskDTarihi.Mask = "00/00/0000";
            maskKart.Mask = "0000000000000000";
            maskIp.Mask = "###.###.###.###";
        }
    }
}
