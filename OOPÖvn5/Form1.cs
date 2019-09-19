using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPÖvn5
{
    public partial class Form1 : Form
    {
        Rapport[] tidRapport = new Rapport[10];
        int antal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string kund = tbxKund.Text;
            int tid = int.Parse(tbxTid.Text);

            Rapport nyTidR = new Rapport(kund, tid);
            tidRapport[antal++] = nyTidR;

            libx.Items.Add(nyTidR.ToString());

            tbxKund.Clear();
            tbxTid.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string Gammalt = tbxGNamn.Text;
            string Nytt = tbxNNamn.Text;

            MessageBox.Show("Hallå!");

            for (int i = 0; i > antal; i++)
            {
                if(Gammalt == tidRapport[i].Kund)
                {
                    tidRapport[i].Kund = Nytt;
                    MessageBox.Show(tidRapport[i].Kund);
                    libx.Items.Add((tidRapport[i].Kund = Nytt).ToString());
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int timarvode = int.Parse(tbxT.Text);
            
        }
    }
}
