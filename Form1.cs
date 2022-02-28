using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arraylist_Sehirler_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList sehirler = new ArrayList();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            sehirler.Add(txtSehirAdi.Text);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sehirler.Count; i++)
            {
                lbListe.Items.Add(sehirler[i]);
            }
        }
    }
}
