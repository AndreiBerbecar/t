using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soft_educational
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlInformatii.Visible = false;
            pnlTest.Visible = false;
        }

        private void btnInformatii_Click(object sender, EventArgs e)
        {
            pnlInformatii.Visible = true;
            pnlInformatii.Location = new Point(-9, 0);
            pnlInformatii.Size = new Size(730, 442);
            btnInformatii.Visible = false;
            btnTest.Visible = false;
            lblEuropa.Visible = false;
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            /*if(rdbLondra.Checked==true)
            {
                if(rdbTallinn.Checked==true)
                {
                    if(rdbVilnius.Checked==true)
                    {
                       MessageBox.Show("CORECT 3/3");
                    }
                }
               
            }*/
            if(rdbLondra.Checked == true & cbTallinn.Checked == true & cbRiga.Checked==true & txtLituania.Text=="Vilnius")
            {
                MessageBox.Show("CORECT 3/3");
            }
            if (rdbLondra.Checked == true)
            {
                if (cbTallinn.Checked == true & cbRiga.Checked==true)
                {
                    if (txtLituania.Text == "Vilnius")
                    {
                        MessageBox.Show("CORECT 3/3");
                    }
                    else
                    {
                        MessageBox.Show("CORECT 2/3");
                    }
                }

            }
            if (rdbLondra.Checked == true)
            {
                if (cbTallinn.Checked == false & cbRiga.Checked==false)
                {
                    if (txtLituania.Text == "Vilnius")
                    {
                        MessageBox.Show("CORECT 2/3");
                    }
                }

            }
            if (rdbLondra.Checked == true)
            {
                if (cbTallinn.Checked == false & cbRiga.Checked==false)
                {
                    if (txtLituania.Text=="Vilnius")
                    {
                        MessageBox.Show("CORECT 2/3");
                    }
                    else
                    {
                        MessageBox.Show("CORECT 1/3");
                    }
                }

            }
            if (rdbLondra.Checked == false)
            {
                if (cbTallinn.Checked == false & cbRiga.Checked == false)
                {
                    if (txtLituania.Text == "Vilnius")
                    {
                        MessageBox.Show("CORECT 1/3");
                    }
                    else
                    {
                        MessageBox.Show("INCORECT 0/3");
                    }
                }

            }
            if (rdbLondra.Checked == false)
            {
                if (cbTallinn.Checked == true & cbRiga.Checked==true)
                {
                    if (txtLituania.Text == "Vilnius")
                    {
                        MessageBox.Show("CORECT 2/3");
                    }
                    else
                    {
                        MessageBox.Show("CORECT 1/3");
                    }
                }

            }
            if (rdbLondra.Checked == false)
            {
                if (cbTallinn.Checked == true & cbRiga.Checked==true)
                {
                    if (txtLituania.Text == "Vilnius")
                    {
                        MessageBox.Show("CORECT 2/3");
                    }
                }

            }
            if (rdbLondra.Checked == false)
            {
                if (cbTallinn.Checked == false & cbRiga.Checked==false)
                {
                    if (txtLituania.Text == "Vilnius")
                    {
                        MessageBox.Show("CORECT 1/3");
                    }
                }

            }
            if (rdbLondra.Checked == false)
            {
                if (cbTallinn.Checked == true & cbRiga.Checked==true)
                {
                    if (txtLituania.Text == "Vilnius")
                    {
                        MessageBox.Show("CORECT 2/3");
                    }
                }

            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            pnlInformatii.Visible = false;
            pnlTest.Visible = true;
            pnlTest.Location = new Point(-6, -3);
            pnlTest.Size = new Size(727, 444);
            btnInformatii.Visible = false;
            btnTest.Visible = false;
            lblEuropa.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlInformatii.Visible = false;
            pnlTest.Visible = false;
            btnTest.Visible = true;
            btnInformatii.Visible = true;
            lblEuropa.Visible = true;
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            pnlInformatii.Visible = false;
            pnlTest.Visible = false;
            btnTest.Visible = true;
            btnInformatii.Visible = true;
            lblEuropa.Visible = true;
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
