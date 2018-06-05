using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Microsoft.Win32;
using System.Media;
using ProbabilityBLL;

namespace EncrytpionDecryption
{
    public partial class frmLogin : Form
    {

        private static string Key = "2_asd2asd9O22_asd2asd9O22_asd2as";
        private static string iv = "asdwesdfgasdfasd";
        frmMainForm frmmf;
        public frmLogin ()
        {
            InitializeComponent();
            frmmf = new frmMainForm();
        }






        #region Button Events
        private void btnLogin_Click ( object sender, EventArgs e )
        {
            ProbBLL objBLL = new ProbBLL();
            bool success = objBLL.GetUser(txtUserName.Text, txtPassoword.Text);
            if (success)
            {
                frmmf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid UserName and password.");
            }
            //if ( txtUserName.Text == "LouiseBogea" )
            //{
            //if ( txtPassoword.Text != string.Empty )
            //    {
            //        RegistryKey MyregistryKey = Registry.CurrentUser.OpenSubKey( "ZahidEncryptor" );
            //        string mypassword = MyregistryKey.GetValue( "Password" ).ToString();
            //        string result = Decryption( mypassword );

            //        if ( txtPassoword.Text == Decryption( mypassword ) )
            //        {
            //            MessageBox.Show( "Fantástico!", "Tu estás conectado!", MessageBoxButtons.OK, MessageBoxIcon.Information );
            //            SystemSounds.Question.Play();
            //            frmmf.Show();
            //            this.Hide();

            //        }
            //        else
            //        {
            //            MessageBox.Show( "Há algo errado!", "", MessageBoxButtons.OK, MessageBoxIcon.Error );
            //            this.txtPassoword.Focus();
            //            txtPassoword.SelectAll();
            //        }

            //    }
            //    else
            //    {
            //        MessageBox.Show( "Por favor, coloque a senha correta.", "Senha inválida.", MessageBoxButtons.OK, MessageBoxIcon.Error );
            //        txtPassoword.Focus();
            //        return;
            //    }
                //}
                //else
                //    MessageBox.Show( "Há algo errado!" );
            }
        private void btnCLose_Click ( object sender, EventArgs e )
        {
            this.Close();
        }

        #endregion


        #region Methods
        private static string Encrypt ( string _UserName )
        {
            Byte [] PlainTextBytes = System.Text.ASCIIEncoding.ASCII.GetBytes( _UserName );
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = System.Text.ASCIIEncoding.ASCII.GetBytes( Key );
            aes.IV = System.Text.ASCIIEncoding.ASCII.GetBytes( iv );
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform CrtyptoTransform = aes.CreateEncryptor( aes.Key, aes.IV );
            byte [] encrypted = CrtyptoTransform.TransformFinalBlock( PlainTextBytes, 0, PlainTextBytes.Length );
            //byte [] encrypted = CrtyptoTransform.TransformFinalBlock(
            CrtyptoTransform.Dispose();


            return Convert.ToBase64String( encrypted );


        }
        public static string Decryption ( string encrypted )
        {
            byte [] encryptedBytes = Convert.FromBase64String( encrypted );
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = System.Text.ASCIIEncoding.ASCII.GetBytes( Key );
            aes.IV = System.Text.ASCIIEncoding.ASCII.GetBytes( iv );
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;

            ICryptoTransform CrtyptoTransform = aes.CreateDecryptor( aes.Key, aes.IV );
            byte [] secret = CrtyptoTransform.TransformFinalBlock( encryptedBytes, 0, encryptedBytes.Length );
            CrtyptoTransform.Dispose();
            string rs = System.Text.ASCIIEncoding.ASCII.GetString( secret );
            return System.Text.ASCIIEncoding.ASCII.GetString( secret );
        }
        
        private void EnableAndDisable(Boolean pblnEnableDisable )
        {
            if (pblnEnableDisable)
            {
                btnCloseSignup.Visible = true;
                btnSignup.Visible = true;
                btnLogin.Visible = false;
                btnCLose.Visible = false;
                btnCloseSignup.Location = btnCLose.Location;
                btnSignup.Location = btnLogin.Location;
                Linklabel.Visible = false;
            }
            else
            {
                btnCloseSignup.Visible = false;
                btnSignup.Visible = false;
                btnLogin.Visible = true;
                btnCLose.Visible = true;
                Linklabel.Visible = true;
            }
        }
            
        
        #endregion

        private void frmLogin_Load ( object sender, EventArgs e )
        {
            
            this.txtUserName.Focus();
            EnableAndDisable(false);
        }

        private void Linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            EnableAndDisable(true);
           
        }

        private void btnCloseSignup_Click(object sender, EventArgs e)
        {
            EnableAndDisable(false);
          
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()) && string.IsNullOrEmpty(txtPassoword.Text))
            {
                MessageBox.Show("Mome de usuário ou senha está faltando.", "Invalid credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                    }
            try
            {
                ProbBLL objBLL = new ProbBLL();


                bool Success = objBLL.CreateAccount(txtUserName.Text, txtPassoword.Text);
                if (Success)
                {
                    string Password = Encrypt(txtPassoword.Text);
                    RegistryKey MyregistryKey = Registry.CurrentUser.CreateSubKey("ZahidEncryptor");
                    MyregistryKey.SetValue("Password", Password);
                    MessageBox.Show("Your Account has been setup.", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EnableAndDisable(false);
                }
                else
                {
                    MessageBox.Show("User name already exists.", "user exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EnableAndDisable(true);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

