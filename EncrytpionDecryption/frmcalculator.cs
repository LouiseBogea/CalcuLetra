using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncrytpionDecryption
{
    public partial class frmcalculator : Form
    {
        public frmcalculator ()
        {
            InitializeComponent();
            lblInput.Text = string.Empty;
        }
        #region GLoabal Variables
        bool DotIsPressed = false;
        bool OperatorisPressed = false;

        string FirstNumber = string.Empty;
        string SecondNumber = string.Empty;
        double GrandTotal;
       //./ char Operator;

        int clear = 1;
        decimal result, mresult;
        string Operator;

        #region methods

        int CLear ( int op )
        {
            switch ( op )
            {
                case 1:  // this case will clear fields when first number is entered and operator is provided and now 2nd numbers is going to be added


                    {
                        lblInput.Text = "";
                        
                    }
                    break;

                case 2:   // When we want to clear the all fields means Both textBoxs or Labels then Clear State will be 2
                    {
                        lblInput.Text = "";
                        lblDetailInfo.Text = "";
                        Operator = "";
                    }
                    break;
                
                case 3:
                    {
                        lblInput.Text = "";
                        lblDetailInfo.Text = lblDetailInfo.Text.Remove( lblDetailInfo.Text.IndexOf( 'r' ) );
                    }
                    break;
                case 4:
                    {
                        lblInput.Text = "";
                        lblDetailInfo.Text = lblDetailInfo.Text.Remove( lblDetailInfo.Text.IndexOf( 's' ) );
                    }
                    break;
                case 5:
                    {
                        lblInput.Text = "";
                        lblDetailInfo.Text = lblDetailInfo.Text.Remove( lblDetailInfo.Text.IndexOf( ' ' ) +1 );
                    }
                    break;
                   
            }
            return 0;
        }

        decimal Evalue ( string Operator )
        {
            try
            {
                switch ( Operator )
                {
                    case "+":
                        {
                           
                           
                            result = result + Convert.ToDecimal( lblInput.Text );
                            lblInput.Text = "";
                            clear = 1;
                            break;
                        }
                    case "-":
                        {
                            result = result - Convert.ToDecimal( lblInput.Text );
                            lblInput.Text = "";
                            clear = 1;
                            break;
                        }
                    case "*":
                        {
                            result = result * Convert.ToDecimal( lblInput.Text );
                            lblInput.Text = "";
                            clear = 1;
                            break;
                        }
                    case "/":
                        {
                            result = result / Convert.ToDecimal( lblInput.Text );
                            lblInput.Text = "";
                            clear = 1;
                            break;
                        }

                    case "mod":
                        {
                           string [] TempResult = lblDetailInfo.Text.Split( ' ' );
                           decimal MytempResult = Convert.ToDecimal( TempResult [ 0 ] );
                           result = MytempResult;
                            result = result % Convert.ToDecimal( lblInput.Text );
                            lblInput.Text = "";
                            clear = 1;
                            break;
                        }
                    default: result = Convert.ToDecimal( lblInput.Text ); break;
                }
            }
            catch ( System.OverflowException )
            {

                lblDetailInfo.Text = "";
                lblDetailInfo.Text = "Overflow";
                clear = 2;
                SystemSounds.Asterisk.Play();
            }
            catch ( DivideByZeroException )
            {
                lblDetailInfo.Text = "";
                lblDetailInfo.Text = "Cannot divide by Zero";
                clear = 2;
                SystemSounds.Asterisk.Play();
            }
            return result;
        }
        #endregion


        #endregion

        private void btnZero_Click ( object sender, EventArgs e )
        {
            clear = CLear( clear );
            if ( lblInput.Text.Length < 28 )
            {
                lblInput.Text += "0";
            }
            else SystemSounds.Beep.Play();
        }

        private void btnOne_Click ( object sender, EventArgs e )
        {
           // lblInput.Text += 1;
            clear = CLear( clear );
            if ( lblInput.Text.Length < 28 )
            {
                lblInput.Text += "1";
            }
            else SystemSounds.Beep.Play();
        }

        private void btnTwo_Click ( object sender, EventArgs e )
        {
            
            clear = CLear( clear );
            if ( lblInput.Text.Length < 28 )
            {
                lblInput.Text += "2";
            }
            else SystemSounds.Beep.Play();
           
        }

        private void btnThree_Click ( object sender, EventArgs e )
        {
           
            clear = CLear( clear );
            if ( lblInput.Text.Length < 28 )
            {
                lblInput.Text += "3";
            }
            else SystemSounds.Beep.Play();
        }

        private void btnFour_Click ( object sender, EventArgs e )
        {
         
            clear = CLear( clear );
            if ( lblInput.Text.Length < 28 )
            {
                lblInput.Text += "4";
            }
            else SystemSounds.Beep.Play();
        }

        private void btnFive_Click ( object sender, EventArgs e )
        {
            clear = CLear( clear );
            if ( lblInput.Text.Length < 28 )
            {
                lblInput.Text += "5";
            }
        }

        private void btnSix_Click ( object sender, EventArgs e )
        {
            clear = CLear( clear );
            if ( lblInput.Text.Length < 28 )
            {
                lblInput.Text += "6";
            }
            else SystemSounds.Beep.Play();
        }

        private void btnSeven_Click ( object sender, EventArgs e )
        {
            clear = CLear( clear );
            if ( lblInput.Text.Length < 28 )
            {
                lblInput.Text += "7";
            }
            else SystemSounds.Beep.Play();
        }

        private void btnEight_Click ( object sender, EventArgs e )
        {
            clear = CLear( clear );
            if ( lblInput.Text.Length < 28 )
            {
                lblInput.Text += "8";
            }
            else SystemSounds.Beep.Play();
        }

        private void btnNine_Click ( object sender, EventArgs e )
        {
            clear = CLear( clear );
            if ( lblInput.Text.Length < 28 )
            {
                lblInput.Text += "9";
            }
            else SystemSounds.Beep.Play();
        }

        private void btn2Zero_Click ( object sender, EventArgs e )
        {
            clear = CLear( clear );
            if ( lblInput.Text.Length < 28 )
            {
                lblInput.Text += "00";
            }
            else SystemSounds.Beep.Play();

        }

        private void btndot_Click ( object sender, EventArgs e )
        {
            //if ( DotIsPressed == false )
            //{
            //    lblInput.Text += ".";
            //    DotIsPressed = true;
            //}
            if(lblInput.Text.Contains('.'))
                SystemSounds.Beep.Play();
            else
                lblInput.Text = ".";

        }

        private void btnOne_KeyPress ( object sender, KeyPressEventArgs e )
        {
            lblInput.Text += 1;
        }

        private void btnTwo_KeyPress ( object sender, KeyPressEventArgs e )
        {
            lblInput.Text += 2;
        }

        private void btnThree_KeyPress ( object sender, KeyPressEventArgs e )
        {
            lblInput.Text += 3;
        }

        private void btnFour_KeyPress ( object sender, KeyPressEventArgs e )
        {
            lblInput.Text += 4;
        }

        private void btnFive_KeyPress ( object sender, KeyPressEventArgs e )
        {
            lblInput.Text += 5;

        }

        private void btnSix_KeyPress ( object sender, KeyPressEventArgs e )
        {
            lblInput.Text += 6;

        }

        private void btnSeven_KeyPress ( object sender, KeyPressEventArgs e )
        {
            lblInput.Text += 7;

        }

        private void btnEight_KeyPress ( object sender, KeyPressEventArgs e )
        {
            lblInput.Text += 8;

        }

        private void btnNine_KeyPress ( object sender, KeyPressEventArgs e )
        {
            lblInput.Text += 9;

        }

        private void btnZero_KeyPress ( object sender, KeyPressEventArgs e )
        {
        }

        private void btn2Zero_KeyPress ( object sender, KeyPressEventArgs e )
        {

        }

        private void btndot_KeyPress ( object sender, KeyPressEventArgs e )
        {

        }

        private void lblInput_KeyPress ( object sender, KeyPressEventArgs e )
        {
            if ( DotIsPressed == false )
            {
                e.Handled = char.IsNumber( e.KeyChar ) || e.KeyChar == 8 || e.KeyChar == 46 ? false : true;
                if ( e.KeyChar == 46 )
                    DotIsPressed = true;
            }
            else
            {
                e.Handled = char.IsNumber( e.KeyChar ) || e.KeyChar == 8 ? false : true;
            }
        }

        private void btnPlus_Click ( object sender, EventArgs e )
        {
            if ( clear == 3 || clear == 4 || clear == 5 )
            {
                lblDetailInfo.Text = " + " + lblDetailInfo.Text;
            }
            else
            {
                lblDetailInfo.Text = lblDetailInfo.Text+ lblInput.Text + " + ";
                Operator = "+";
              
               lblInput.Text = Evalue( Operator ).ToString();
              
                //result++;
            }

        }

        private void btnMinus_Click ( object sender, EventArgs e )
        {
            if ( clear == 3 || clear == 4 || clear == 5 )
            {
                lblDetailInfo.Text += " - ";
            }
            else
            {
                lblDetailInfo.Text += lblInput.Text + " - ";
                Operator = "-";
                lblInput.Text = Evalue( Operator ).ToString();
               
            }

        }
        private void btnMultiply_Click ( object sender, EventArgs e )
        {
            if ( clear == 3 || clear == 4 || clear == 5 )
            {
                lblDetailInfo.Text += " * ";
            }
            else
            {
                lblDetailInfo.Text += lblInput.Text + " * ";
                Operator = "*";
                lblInput.Text = Evalue( Operator ).ToString();
               
            }
        }
        private void btnDivision_Click ( object sender, EventArgs e )
        {
            if ( clear == 3 || clear == 4 || clear == 5 )
            {
                lblDetailInfo.Text += " / ";
            }
            else
            {
                lblDetailInfo.Text += lblInput.Text + " / ";
                Operator = "/";
                lblInput.Text = Evalue( Operator ).ToString();
               
            }
        }

        private void richTextBox1_KeyPress ( object sender, KeyPressEventArgs e )
        {

        }

        private void frmcalculator_Load ( object sender, EventArgs e )
        {
            lblInput.Text = "0";
        }

        private void frmcalculator_KeyDown ( object sender, KeyEventArgs e )
        {
            lblInput.Text = string.Empty;

        }

        private void btnMod_Click ( object sender, EventArgs e )
        {
            if ( clear == 3 || clear == 4 || clear == 5 )
            {
                lblDetailInfo.Text += " mod ";
            }
            else
            {
                result = Convert.ToDecimal( lblInput.Text );
                lblDetailInfo.Text += lblInput.Text + " mod ";
                Operator = "mod";

                lblInput.Text = Evalue( Operator ).ToString();
               
            }
        }

        private void btnOneOverSix_Click(object sender, EventArgs e)
        {
            if(lblDetailInfo.Text.Contains("reciprocal of "))
            {
                lblDetailInfo.Text = lblDetailInfo.Text.Insert(lblDetailInfo.Text.IndexOf('r'),"reciprocal of (");
                lblDetailInfo.Text = lblDetailInfo.Text.Insert(lblDetailInfo.Text.IndexOf(')'),")");
            }
            else
            {
                lblDetailInfo.Text += " reciprocal of ( "+ lblInput.Text+" )";
                lblInput.Text = ( 1 / Convert.ToDecimal(lblInput.Text)).ToString();
                clear = 3;
            }

        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
             if(lblDetailInfo.Text.Contains("sqrt of "))
            {
                lblDetailInfo.Text = lblDetailInfo.Text.Insert(lblDetailInfo.Text.IndexOf('s'),"sqrt of (");
                lblDetailInfo.Text = lblDetailInfo.Text.Insert(lblDetailInfo.Text.IndexOf(')'),")");
            }
            else
            {
                lblDetailInfo.Text += " sqrt of ( "+ lblInput.Text+" )";
                lblInput.Text = (Math.Sqrt ( Convert.ToDouble(lblInput.Text)).ToString());
                 clear = 3;
            }
        }

        private void btnPercentage_Click ( object sender, EventArgs e )
        {
            lblInput.Text = ( result * Convert.ToDecimal( lblInput.Text ) ).ToString();
            lblDetailInfo.Text += lblInput.Text;
            clear = 5;



        }

        private void btnPlusMinus_Click ( object sender, EventArgs e )
        {
            if ( lblInput.Text.Contains( '-' ) )
            {
                lblInput.Text = lblInput.Text.Remove( lblInput.Text.IndexOf( '-' ), 1 );
            }
            else
                lblInput.Text = lblInput.Text+"-";
        }

        private void btnEqual_Click ( object sender, EventArgs e )
        {
            if ( clear != 3 && clear != 4 && clear != 5 )
            {
                lblDetailInfo.Text += lblInput.Text;
                lblInput.Text = Evalue( Operator ).ToString();
                clear = 2;

            }
        }

        private void btnCE_Click ( object sender, EventArgs e )
        {
            CLear( 2 );
            clear = 1;
            lblInput.Text = "0";
            result = 0;
        }

        private void ButtonC_Click ( object sender, EventArgs e )
        {
            CLear( 1 );
            clear = 1;
            lblInput.Text = "0";
        }

        private void btnMS_Click ( object sender, EventArgs e )
        {
            
            mresult = Convert.ToDecimal( lblInput.Text );
            clear = 1;
        }

        private void btnMR_Click ( object sender, EventArgs e )
        {
            lblInput.Text = mresult.ToString();
            clear = 1;

        }

        private void btnMPlus_Click ( object sender, EventArgs e )
        {
            mresult += Convert.ToDecimal( lblInput.Text );
            clear = 1;
        }

        private void btnMMinus_Click ( object sender, EventArgs e )
        {
            mresult -= Convert.ToDecimal( lblInput.Text );
            clear = 1;
        }

        private void btnMC_Click ( object sender, EventArgs e )
        {
            mresult = 0; clear = 1;
        }

        private void lblInput_Click ( object sender, EventArgs e )
        {
           

        }

        private void lblInput_TextChanged ( object sender, EventArgs e )
        {
            if ( lblInput.Text.Length <= 20 )
            {
                Font CustomizedFont = new Font( "Consolas", 26, FontStyle.Regular );
                lblInput.Font = CustomizedFont;
            }
            else
                if ( lblInput.Text.Length <= 25 && lblInput.Text.Length > 20 )
                {
                    Font CustomizedFont = new Font( "Consolas", 23, FontStyle.Regular );
                    lblInput.Font = CustomizedFont;
                }
                else
                {
                    Font CustomizedFont = new Font( "Consolas", 18, FontStyle.Regular );
                    lblInput.Font = CustomizedFont;
                }
        }
        

       
    }
}
