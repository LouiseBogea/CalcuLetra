using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncrytpionDecryption
{
    public partial class frmEntropy : Form
    {

        public static List<ClassLettersEntropy> ListOfLettersEntropy;
        public static List<ClassWordsEntropy> ListOfWordsEntropy;
        public static bool ShowLettersEntropy;
        public static bool ShowWordsEntropy;
        public static double TotalWordsEntropy;
        public static double TotalLetterENtropy;
        public static double AverageOfLetterEntropI;
        public static double AverageOfWordsEntropI;
        public static double LettersMinimumEntropI;
        public static double LetterMaximumEntropI;
        public static double WordsMinimumentropI;
        public static double WordsMaximumEntropI;
        
        public frmEntropy ()
        {
            InitializeComponent();
        }

        private void frmEntropy_Load ( object sender, EventArgs e )
        {
            if ( ShowLettersEntropy == true && ShowWordsEntropy == false )
            {
                lblEntropIAverage.Text = string.Empty;
                lblTotalENtropy.Text = string.Empty;
                dgvLettersEntropy.Visible = true;
                dgvLettersEntropy.DataSource = ListOfLettersEntropy;
                dgvWordsProbability.Visible = false;
                lblTotalENtropy.Text = "Entropia Total: " + Math.Round( TotalLetterENtropy, 4 ).ToString();
              lblEntropIAverage.Text = "Entropia Média: " + Math.Round( AverageOfLetterEntropI, 4 );
                  lblMinEntropi.Text = "Menor Entropia: " + LettersMinimumEntropI.ToString();
                 lblMaxEntropia.Text = "Maior Entropia: " + LetterMaximumEntropI.ToString();

            }
            else
                if ( ShowWordsEntropy == true && ShowLettersEntropy == false )
                {
                    dgvLettersEntropy.Visible = false;
                    dgvWordsProbability.Visible = true;
                    lblEntropIAverage.Text = string.Empty;
                    lblTotalENtropy.Text = string.Empty;
                    dgvWordsProbability.DataSource = ListOfWordsEntropy;
                    lblTotalENtropy.Text = TotalWordsEntropy.ToString();
                    lblTotalENtropy.Text = "Entropia Total: " + Math.Round( TotalWordsEntropy, 4 ).ToString();
                  lblEntropIAverage.Text = "Entropia Média: " + Math.Round( AverageOfWordsEntropI, 4 );
                  lblMinEntropi.Text = "Menor Entropia: " + WordsMinimumentropI.ToString();
                  lblMaxEntropia.Text = "Maior Entropia: " + WordsMaximumEntropI.ToString();
                }


            if ( ShowWordsEntropy == false && ShowLettersEntropy == false )
            {
                //dgvLettersEntropy.Visible = false;
                //dgvWordsProbability.Visible = false;
            
                MessageBox.Show( "Please first Get the Probability" );
                this.Hide();
            }

        }

        private void dgvLettersEntropy_CellContentClick ( object sender, DataGridViewCellEventArgs e )
        {

        }

        private void lblLetters_Click ( object sender, EventArgs e )
        {

        }
    }
}
