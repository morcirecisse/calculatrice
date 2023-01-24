using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TP_TDI_2
{
    public partial class frmCaculatrice : Form
    {
        public frmCaculatrice()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlScientifique_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)

        {


        }

        double memo;
        char op;

        public void ecrire(string valeur)
        {
            if (txtR.Text == "0" || txtR.Text == "Div par zéro impossible") 
            {
                txtR.Text = valeur;
            }
            else
            {
                txtR.Text = txtR.Text + valeur;

            }
        }
        //-----------------------------------------------------------------------------------------
        public void operation(char p)
        {
            memo = double.Parse(txtR.Text);
            op = p;
            txtR.Text = "0";
        }
        private void frmCaculatrice_Load(object sender, EventArgs e)
        {
            this.Width = pnlStandard.Width;
            txtR.Width = this.Width - 29;
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Width = pnlStandard.Width;
            txtR.Width = this.Width - 29;
        }

        private void scientiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = pnlStandard.Width +pnlScientifique.Width;
            txtR.Width = this.Width - 29;
        }

        private void txtR_TextChanged(object sender, EventArgs e)
        {

        }

        private void MC_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            ecrire("7");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

            ecrire("1");
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ecrire("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ecrire("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ecrire("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ecrire("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ecrire("6");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ecrire("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ecrire("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ecrire("0");
        }

        private void btnPlusOuMoins_Click(object sender, EventArgs e)
        {
            memo = (double.Parse(txtR.Text)) * (-1);
            txtR.Text = memo.ToString();
        }

        private void btnXMultiplication_Click(object sender, EventArgs e)
        {
            operation('*');
        }

        private void btn1surX_Click(object sender, EventArgs e)
        {
            memo = 1/(double.Parse(txtR.Text));
            txtR.Text = memo.ToString();
        }

        private void btnXAuCarré_Click(object sender, EventArgs e)
        {
            memo = Math.Pow((double.Parse(txtR.Text)),2);
            txtR.Text = memo.ToString();
        }

        private void btnRacineAuCarré_Click(object sender, EventArgs e)
        {
            memo = Math.Sqrt((double.Parse(txtR.Text)));
            txtR.Text = memo.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

            operation('+');
        }

        private void btnEgale_Click(object sender, EventArgs e)
        {
            if(op=='+')
            {
                memo = memo + double.Parse(txtR.Text);
                txtR.Text = memo.ToString();
            }
            if (op == '-')
            {
                memo = memo - double.Parse(txtR.Text);
                txtR.Text = memo.ToString();
            }
            if (op == '*')
            {
                memo = memo * double.Parse(txtR.Text);
                txtR.Text = memo.ToString();
            }
            if (op == '/')
            {
                if (txtR.Text == "0")
                {
                    txtR.Text = "Div par zéro impossible";
                }
                else
                {
                    memo = memo / double.Parse(txtR.Text);
                    txtR.Text = memo.ToString();
              

                }
            }
        }

        private void btnMoins_Click(object sender, EventArgs e)
        {
            operation('-');
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operation('/');
        }

        private void btnVirgule_Click(object sender, EventArgs e)
        {
            if(txtR.Text.Contains(",")==false)
            {
                txtR.Text = txtR.Text + ",";
            }
                
           
           
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            txtR.Text = "0";
           
        }

        private void txtOperations_TextChanged(object sender, EventArgs e)
        {
                btnRetour.Enabled = txtR.Text.Length > 0;
        }

        private void btnpourcentage_Click(object sender, EventArgs e)
        {
           

           
        }

        private void button58_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {

        }

        private void button47_Click(object sender, EventArgs e)
        {

        }

        private void button51_Click(object sender, EventArgs e)
        {

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtR.Text = "0";
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
           txtR.Text="3.141526535897323";
        }

        private void btnLogarithme_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txtR.Text);
            ilog = Math.Log10(ilog);
            txtR.Text = System.Convert.ToString(ilog);
        }
    }
    
}
