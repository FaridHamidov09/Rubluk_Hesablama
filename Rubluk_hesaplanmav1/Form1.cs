using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubluk_hesaplanmav1
{
    public partial class lobi : Form
    {
        public lobi()
        {
            InitializeComponent();
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proqram Fərid Həmidov tərəfindən hazırlanmışdır.", "TEXNOFA Studio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (secme5.Checked)
            {
                reqem5.Enabled = true;
            }
            else
            {
                reqem5.Enabled = false;
                reqem5.Text = "";
            }
        }

        private void secme1_CheckedChanged(object sender, EventArgs e)
        {
            if (secme1.Checked)
            {
                reqem1.Enabled = true;
            }
            else
            {
                reqem1.Enabled = false;
                reqem1.Text = "";
            }

        }

        private void secme2_CheckedChanged(object sender, EventArgs e)
        {
            if (secme2.Checked)
            {
                reqem2.Enabled = true;
            }
            else
            {
                reqem2.Enabled = false;
                reqem2.Text = "";
            }
        }

        private void secme3_CheckedChanged(object sender, EventArgs e)
        {
            if (secme3.Checked)
            {
                reqem3.Enabled = true;
            }
            else
            {
                reqem3.Enabled = false;
                reqem3.Text = "";
            }
        }

        private void secme4_CheckedChanged(object sender, EventArgs e)
        {
            if (secme4.Checked)
            {
                reqem4.Enabled = true;
            }
            else
            {
                reqem4.Enabled = false;
                reqem4.Text = "";
            }
        }

        private void hesabla_Click(object sender, EventArgs e)
        {
           if (secme1.Checked && secme2.Checked && secme3.Checked)
            {
                double ksq1, ksq2, ksq3, cavab1,cavab2,cavab3;

                ksq1 = Convert.ToInt32(reqem1.Text);
                ksq2 = Convert.ToInt32(reqem2.Text);
                ksq3 = Convert.ToInt32(reqem3.Text);

                cavab1 = ksq1 + ksq2 + ksq3;
                cavab2 = cavab1 / 3;
                cavab3 = Math.Round(cavab2);
                cavab.Text = cavab3.ToString();
            }
            if (secme1.Checked && secme2.Checked && secme3.Checked && secme5.Checked)
            {
                double ksq1, ksq2, ksq3, bsq, cavab1, cavab2, cavab3,cavab4,cavab5,cavab6;

                ksq1 = Convert.ToInt32(reqem1.Text);
                ksq2 = Convert.ToInt32(reqem2.Text);
                ksq3 = Convert.ToInt32(reqem3.Text);
                bsq = Convert.ToInt32(reqem5.Text);

                cavab1 = ksq1 + ksq2 + ksq3;
                cavab2 = cavab1 / 3;
                cavab3 = cavab2 * 0.4;
                cavab4 = bsq * 0.6;
                cavab5 = cavab4 + cavab3;
                cavab6 = Math.Round(cavab5);

                cavab.Text = cavab6.ToString();
            }
            if (secme1.Checked && secme2.Checked && secme3.Checked && secme4.Checked)
            {
                double ksq1, ksq2, ksq3, ksq4,cavab1,cavab2,cavab3;

                ksq1 = Convert.ToInt32(reqem1.Text);
                ksq2 = Convert.ToInt32(reqem2.Text);
                ksq3 = Convert.ToInt32(reqem3.Text);
                ksq4 = Convert.ToInt32(reqem4.Text);

                cavab1 = ksq1 + ksq2 + ksq3 + ksq4;
                cavab2 = cavab1 / 4;
                cavab3 = Math.Round(cavab2);

                cavab.Text = cavab3.ToString();
            }
            if (secme1.Checked && secme2.Checked && secme3.Checked && secme4.Checked && secme5.Checked)
            {
                double ksq1, ksq2, ksq3, ksq4, bsq, cavab1, cavab2, cavab3,cavab4,cavab5,cavab6;

                ksq1 = Convert.ToInt32(reqem1.Text);
                ksq2 = Convert.ToInt32(reqem2.Text);
                ksq3 = Convert.ToInt32(reqem3.Text);
                ksq4 = Convert.ToInt32(reqem4.Text);
                bsq = Convert.ToInt32(reqem5.Text);

                cavab1 = ksq1 + ksq2 + ksq3 + ksq4;
                cavab2 = cavab1 / 4;
                cavab3 = cavab2 * 0.4;
                cavab4 = bsq * 0.6;
                cavab5 = cavab3 + cavab4;
                cavab6 = Math.Round(cavab5);

                cavab.Text = cavab6.ToString();

            }
        }
    }
}
