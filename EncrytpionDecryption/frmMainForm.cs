using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
//using Word = Microsoft.Office.Interop.Word;
using ProbabilityBLL;
using ProbabilityBussinessObjectLayer;
using System.IO;
using ExcelDataReader;
using System.Data.OleDb;

namespace EncrytpionDecryption
{
    public partial class frmMainForm : Form
    {
        #region Variable

        System.Drawing.Point LastClick;
        private ProbBLL BussinessLogicLayerControler;
        private ProbabilityCommon CommControler;
        // bool DontSaveItCauseItCameWithError = false;
        int NumberOfWords = 0;
        string exMystringAfterRemovingAllSpaces;
        List<ClassWordsProbability> listOfWordsOccerence = new List<ClassWordsProbability>();
        List<ClassLettersProbability> listOfAlphabetsOccerence = new List<ClassLettersProbability>();
        List<ClassWordsEntropy> lstWordsEntropy = new List<ClassWordsEntropy>();
        List<ClassLettersEntropy> lstLettersEntropy = new List<ClassLettersEntropy>();
        bool OKButtonIsChecked;
        decimal count;
        double TotalLetterENtropy = 0, TotalWordsEntropy = 0;
        double LettersMinimumEntropy = 0, LetterMaximumEntropy = 0;
        double WordsMinimumentropy = 0, WordsMaximumEntropy = 0;
        int CountForMe = 0; // this count will count when a word is founded in Normalized List. If its more than One then it will not add that word otherwise it will add that word in Normalized LIst.
        bool CheckIfWordsProbabilityIsClicked = true;
        bool CheckIfLettersProbabilitIsClicked = true;
        List<string> MyListWhichHoldNormalizedstring = new List<string>();
        string MystrWhichHoldNormalizedstring = string.Empty;
        decimal SumofProbability = 0;

        #endregion

        #region FormEvent
        public frmMainForm()
        {
            InitializeComponent();
            BussinessLogicLayerControler = new ProbBLL();
            CommControler = new ProbabilityCommon();
        }
        private void frmMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           System.Windows.Forms.Application.Exit();
            //            Environment.Exit(1);
        }
        private void frmMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastClick = e.Location;
        }
        private void frmMainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastClick.X;
                this.Top += e.Y - LastClick.Y;
            }
        }
        private void frmMainForm_Load(object sender, EventArgs e)
        {
            ToggleBold();
            //txtSearch.GotFocus += TxtSearch_GotFocus;
            //txtSearch.LostFocus += TxtSearch_LostFocus;
            this.Location = new System.Drawing.Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            btnScale.Visible = false;
        }

        private void TxtSearch_LostFocus(object sender, EventArgs e)
        {
            txtSearch.Text = "Search here...";
        }

        private void TxtSearch_GotFocus(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
        }

        private void frmMainForm_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void frmMainForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmMainForm_KeyDown(object sender, KeyEventArgs e)
        {

        }
        #endregion

        #region private Method
        private bool CheckShowScaleValidation(string str)
        {
            bool isDigitPresent = false;


            bool isDigitPresent1 = str.Any(c => char.IsDigit(c));
            bool isDigitPresent2 = str.Any(c => char.IsPunctuation(c));


            if (isDigitPresent1 == true || isDigitPresent2 == true)
            {
                isDigitPresent = true;
            }
            return isDigitPresent;
        }
        private bool CheckIftherIsAnySymbolOrNumber2(string str)
        {
            bool isDigitPresent = false;


            bool isDigitPresent1 = str.Any(c => char.IsDigit(c));
            bool isDigitPresent2 = str.Any(c => char.IsPunctuation(c));
            // bool isDigitPresent2 = false;

            if (isDigitPresent1 == true || isDigitPresent2 == true)
            {
                isDigitPresent = true;
            }
            return isDigitPresent;
        }
        private bool CheckIftherIsAnySymbolOrNumber(string str)
        {
            bool isDigitPresent = false;


            bool isDigitPresent1 = str.Any(c => char.IsDigit(c));
            bool isDigitPresent2 = str.Any(c => char.IsPunctuation(c));
            //bool isDigitPresent2 = false;

            if (isDigitPresent1 == true || isDigitPresent2 == true)
            {
                isDigitPresent = true;
            }
            return isDigitPresent;
        }
        private void ToggleBold()
        {
            if (rtbINput.SelectionFont != null)
            {
                System.Drawing.Font currentFont = rtbINput.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (rtbINput.SelectionFont.Bold == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Bold;
                }

                rtbINput.SelectionFont = new System.Drawing.Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }
        #endregion

        #region ButtonEvent

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmcalculator frmcl = new frmcalculator();
            frmcl.Show();
        }

        private void btnEntropy_Click(object sender, EventArgs e)
        {
            frmEntropy frme = new frmEntropy();
            frme.ShowDialog();
        }

        private void btnResultDetail_Click(object sender, EventArgs e)
        {
            if (OKButtonIsChecked == true)
            {

                WordsMaximumEntropy = 0;
                WordsMinimumentropy = 0;
                TotalWordsEntropy = 0;


                CheckIfWordsProbabilityIsClicked = true;
                CheckIfLettersProbabilitIsClicked = false;
                dgvLettersProbability.Visible = false;
                dgvWordsProbability.Visible = true;
                btnScale.Visible = true;
                btnEntropy.Visible = true;
                // DontSaveItCauseItCameWithError = false;

                #region Getting Normalized occurrence of words in paragraph. These Normalized words will be further used to Count those words in Text

                if (rtbINput.Text != "")
                {
                    MyListWhichHoldNormalizedstring.Clear();
                    MyListWhichHoldNormalizedstring = new List<string>();
                    MystrWhichHoldNormalizedstring = string.Empty;


                    string[] Responses = new string[exMystringAfterRemovingAllSpaces.Trim().Split(' ').Length];
                    Responses = exMystringAfterRemovingAllSpaces.ToUpper().Trim().Split(' ', ',', '.'); // To Calculate the No of words and chars, we split the words on the basis of space


                    for (int loop = 0; loop < Responses.Length; loop++)
                    {
                        if (loop == 0)
                        {

                            string CheckIfitCOntainNumbers = Responses[loop].ToString();


                            bool Success = CheckIftherIsAnySymbolOrNumber(CheckIfitCOntainNumbers);
                            if (Success == false)
                            {
                                MyListWhichHoldNormalizedstring.Add(Responses[loop].ToString());
                                //Max = Responses [ loop ].Length;
                                MystrWhichHoldNormalizedstring += Responses[loop].ToString() + " ";

                            }


                        }
                        else
                        {


                            //CountForMe = 0;
                            //if ( Responses [ loop ].Length > Max )
                            //    Max = Responses [ loop ].Length;
                            //int n = MyListWhichHoldNormalizedstring.Count;
                            //for ( int myloop = 0 ; myloop < n ; myloop++ )
                            //{

                            //    if ( Responses [ loop ].ToUpper() == MyListWhichHoldNormalizedstring [ myloop ].ToUpper() )
                            //    {
                            //        CountForMe++; /// agar string pehly list my save hogi to 
                            //        break;        /// count more than one ho jaye jiska matblb ha 
                            //                      /// ye word pehly list my mojood ha so ko dobara add karny k zaroorat ni ha


                            //        break;
                            //    }

                            //}

                            string CurrentWord = Responses[loop].ToUpper().ToString();

                            CountForMe = 0;

                            try
                            {
                                foreach (Match m in Regex.Matches(@MystrWhichHoldNormalizedstring, "\\b" + CurrentWord + "\\b"))

                                {
                                    CountForMe++;
                                    break;
                                }
                            }
                            catch (Exception ex)
                            {

                                //MessageBox.Show( "Please Remove these symbols and Characters: " + Environment.NewLine + " (), [] , {} _ , ? + / , \\, ~ = " + Environment.NewLine );
                                //DontSaveItCauseItCameWithError = true;
                                continue;
                            }

                            if (CountForMe == 0)  /// Jab count == 0 hoga to iska matlb ha k ye new word ha
                                                  /// 
                            {
                                //string strToAddinNormaizedList = Responses[loop];
                                if (Responses[loop] != string.Empty)
                                {
                                    string CheckIfitCOntainNumbers = Responses[loop].ToString();  ///Check kary gy ye number

                                    bool Success = CheckIftherIsAnySymbolOrNumber(CheckIfitCOntainNumbers);
                                    if (Success == false)
                                    {
                                        MyListWhichHoldNormalizedstring.Add(Responses[loop].ToString());
                                        MystrWhichHoldNormalizedstring += Responses[loop].ToString() + " ";

                                    }



                                }

                            }
                        }

                    }
                    //richTextBox1.Clear();

                    // MyListWhichHoldNormalizedstring.Clear();

                    #endregion

                    #region Caculating the No Occurrence of words in Text for Probability

                    List<int> lstOccurerrenceOfWords = new List<int>();
                    listOfWordsOccerence = new List<ClassWordsProbability>();
                    dgvWordsProbability.DataSource = null;
                    //int CountedWords = 0;
                    //richTextBox1.Text += " palavras" + "            Número de Ocorrências" + "      probabilidade" + Environment.NewLine;

                    //string strUpperTextString = exMystringAfterRemovingAllSpaces.ToUpper();

                    if (listOfWordsOccerence.Count != 0)
                    {


                        dgvWordsProbability.DataSource = null;
                        listOfWordsOccerence = new List<ClassWordsProbability>();



                    }
                    string ThisStringGetAllTextFromRichText = rtbINput.Text.ToUpper();
                    int TimesOfOccurreence = 0;
                    for (int OccurenceLoop = 0; OccurenceLoop < MyListWhichHoldNormalizedstring.Count; OccurenceLoop++)
                    {

                        TimesOfOccurreence = 0;
                        string tempstr = MyListWhichHoldNormalizedstring[OccurenceLoop].ToString();

                        try
                        {
                            foreach (Match m in Regex.Matches(@ThisStringGetAllTextFromRichText, "\\b" + tempstr + "\\b"))
                            {
                                TimesOfOccurreence++;

                            }
                        }
                        catch (Exception ex)
                        {


                            continue;

                        }


                        if (TimesOfOccurreence != 0)
                        {



                            int TotalNoOfWords = MyListWhichHoldNormalizedstring.Count;
                            ClassWordsProbability cl = new ClassWordsProbability();
                            cl.Palavras = MyListWhichHoldNormalizedstring[OccurenceLoop].ToString();
                            cl.Frequência = TimesOfOccurreence;
                            cl.Probabilidade = Math.Round((Convert.ToDecimal(TimesOfOccurreence * 100.00) / NumberOfWords), 6);

                            listOfWordsOccerence.Add(cl);


                            ClassWordsEntropy ClsE = new ClassWordsEntropy();

                            double tempProb = Convert.ToDouble(cl.Probabilidade);
                            double QuantityInfoI = Math.Log(1 / (tempProb), 2);
                            string FinalEntropy = (Math.Round((QuantityInfoI * tempProb), 6)).ToString();
                            ClsE.WordsName = cl.Palavras;
                            ClsE.WordsEntropy = FinalEntropy;
                            ClsE.WordsQuantityInformation = Math.Round(QuantityInfoI, 6).ToString();

                            lstWordsEntropy.Add(ClsE);
                            if (WordsMinimumentropy == 0 && WordsMaximumEntropy == 0)
                            {
                                WordsMinimumentropy = Convert.ToDouble(FinalEntropy);
                                WordsMaximumEntropy = Convert.ToDouble(FinalEntropy);

                            }
                            else
                            {
                                if (WordsMinimumentropy > Convert.ToDouble(FinalEntropy))
                                    WordsMinimumentropy = Convert.ToDouble(FinalEntropy);
                                if (WordsMaximumEntropy < Convert.ToDouble(FinalEntropy))
                                    WordsMaximumEntropy = Convert.ToDouble(FinalEntropy);
                            }
                            TotalWordsEntropy += Convert.ToDouble(FinalEntropy);

                        }

                    }



                    #endregion

                    dgvWordsProbability.DataSource = listOfWordsOccerence;
                    frmEntropy.ListOfWordsEntropy = lstWordsEntropy;
                    frmEntropy.TotalWordsEntropy = TotalWordsEntropy;
                    frmEntropy.WordsMinimumentropI = WordsMinimumentropy;
                    frmEntropy.WordsMaximumEntropI = WordsMaximumEntropy;
                    frmEntropy.AverageOfWordsEntropI = TotalWordsEntropy / exMystringAfterRemovingAllSpaces.Trim().Split(' ').Length;
                    frmEntropy.ShowWordsEntropy = true;
                    frmEntropy.ShowLettersEntropy = false;
                    //if ( DontSaveItCauseItCameWithError == false )
                    //{
                    //    bool Success = BussinessLogicLayerControler.SaveToDBNew(listOfWordsOccerence);
                    //    if (Success == true)
                    //    {
                    //        MessageBox.Show("Os dados foram salvos no banco", "o banco de dados foi atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    }
                    //}


                }
                else
                    MessageBox.Show("Por favor, digite um texto.", "Nenhum texto encontrado.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Por favor, conte as letras ou palavras para obter os seus detalhes.", "Contagem inválida.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbINput.Text = string.Empty;
            lblWords.Text = string.Empty;
            lblLetters.Text = string.Empty;
            lblSentences.Text = string.Empty;
            lblParaghraph.Text = string.Empty;
            dgvWordsProbability.DataSource = null;
            listOfWordsOccerence = new List<ClassWordsProbability>();
            dgvLettersProbability.DataSource = null;
            listOfAlphabetsOccerence = new List<ClassLettersProbability>();
            OKButtonIsChecked = false;
            btnEntropy.Visible = false;
            btnScale.Visible = false;
            btnLettersProbability.Visible = false;
            btnResultDetail.Visible = false;
           
        }

        /// <summary>
        /// Global Words
        /// this string array will hold that text which will go for process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(rtbINput.Text))
            {
                return;
            }
            btnEntropy.Visible = false;
            btnLettersProbability.Visible = true;
            btnResultDetail.Visible = true;
            btnScale.Visible = false;
            if (rtbINput.Text != "")
            {
                count = 0;
                NumberOfWords = 0;
                OKButtonIsChecked = true;
                List<string> lstWordsFilterByNumbers = new List<string>();
                #region No of words and Letters


                string str = rtbINput.Text;  // getting Text Document in a string.

                exMystringAfterRemovingAllSpaces = rtbINput.Text;    // New Logic, It will remove all empty spaces in throughout the whole document.So lets give this string to this variable

                exMystringAfterRemovingAllSpaces = String.Join(" ", exMystringAfterRemovingAllSpaces.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)); // This line is going to do the magic to remove all empty spaces.



                string[] stplitedstr = exMystringAfterRemovingAllSpaces.Trim().Split(' ', ';', ':', '.'); // To Calculate the No of words and chars, we split the words on the basis of space



                for (int loop = 0; loop < stplitedstr.Length; loop++) // Loop to go through the each splited string to get No of characters and  No of words
                {

                    // MessageBox.Show( stplitedstr [ loop ].Trim().ToString() ); // this is just test mesage to display all splited words

                    //if ( stplitedstr [ loop ].ToString() != string.Empty )
                    //    count += Convert.ToInt32( stplitedstr [ loop ].Length );
                    string CheckIfitCOntainNumbers = stplitedstr[loop].ToString().Trim();
                    if (CheckIfitCOntainNumbers != string.Empty)
                    {
                        bool Success = CheckIftherIsAnySymbolOrNumber2(CheckIfitCOntainNumbers);
                        if (Success == false)
                        {
                            NumberOfWords++;
                            if (stplitedstr[loop].ToString() != string.Empty)
                                count += Convert.ToInt32(stplitedstr[loop].Length);
                            lstWordsFilterByNumbers.Add(CheckIfitCOntainNumbers);
                            // arrstrWordsFilterByNumbers += CheckIfitCOntainNumbers.ToString();
                        }
                    }


                }
                #endregion

                string tempwordstring = rtbINput.Text;
                string[] temparraywordsstring = tempwordstring.Trim().Split('.');


                lblLetters.Visible = true;
                lblSentences.Visible = true;
                lblWords.Visible = true;
                lblParaghraph.Visible = true;
                lblLetters.Text = "Número de letras: " + count.ToString();
                string words = rtbINput.Text;
                lblWords.Text = "Número de palavras:" + NumberOfWords.ToString();
                int sentences = words.Split('.', ';').Length - 1;
                int Paraghraph = words.Split('\n').Length;
                
                    lblParaghraph.Text = "Número de parágrafo: " + Paraghraph.ToString();
               
                
                
                if (sentences == 0)
                    lblSentences.Text = "Não há sentenças completas.";
                else
                    lblSentences.Text = "Número de sentenças: " + sentences.ToString();
            }
            else
                MessageBox.Show("Não há texto a ser quantificado.", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ToggleBold();
            //MessageBox.Show( "Total No of Chars are..> " + count.ToString() );

        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tu realmente desejas fechar este programa?", "Confirmaçãode saída", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        
        static DataSet GetDataFromExcel(string fileName)
        {
            DataSet data = new DataSet();
            try
            {
                //string connectionString = string.Format("provider=Microsoft.Jet.OLEDB.4.0; data source={0};Extended Properties=Excel 8.0;", fileName);
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=Excel 12.0;";
                foreach (var sheetName in GetExcelSheetNames(connectionString))
                {
                    using (OleDbConnection con = new OleDbConnection(connectionString))
                    {
                        var dataTable = new System.Data.DataTable();
                        string query = string.Format("SELECT * FROM [{0}]", sheetName);
                        con.Open();
                        OleDbDataAdapter adapter = new OleDbDataAdapter(query, con);
                        adapter.Fill(dataTable);
                        data.Tables.Add(dataTable);
                    }
                }

                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        static string[] GetExcelSheetNames(string connectionString)
        {
            OleDbConnection con = null;
            System.Data.DataTable dt = null;
            con = new OleDbConnection(connectionString);
            con.Open();
            dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            if (dt == null)
            {
                return null;
            }

            String[] excelSheetNames = new String[dt.Rows.Count];
            int i = 0;

            foreach (DataRow row in dt.Rows)
            {
                excelSheetNames[i] = row["TABLE_NAME"].ToString();
                i++;
            }

            return excelSheetNames;
        }

        private void btnSaveDistinctWords_Click(object sender, EventArgs e)
        {
            //double MaxProbability;
            //double AverageProbability;
            List<clsSaveToFinalDB> lstSAveInDB = new List<clsSaveToFinalDB>();
            //   List<double>  lstSomeData = new List<double>();

            // lstSomeData = BussinessLogicLayerControler.GetSomeNcessaryDate();
            dsDistinctWords ds = new dsDistinctWords();
            ds = BussinessLogicLayerControler.GetDSOfDistinctWorld();
            // double TotalNofDistinctWords = ds.Tables [ "tblDistinctWords" ].Rows.Count;
            List<string> TempDisntinctWOrd = new List<string>();

            foreach (System.Data.DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (object item in row.ItemArray)
                    {
                        if (item.ToString().ToString().Trim() != string.Empty)


                            TempDisntinctWOrd.Add(item.ToString().Trim());
                        break;
                    }
                }
            }
            // MessageBox.Show("Test");
            List<clsSaveToFinalDB> lstNewFInalList = new List<clsSaveToFinalDB>();
            lstNewFInalList = BussinessLogicLayerControler.ThisMethodWillCoverEverything(TempDisntinctWOrd);

            //int NoAllWordsInDB = ds.Tables [ "tblWordsPb" ].Rows.Count;

            //for ( int LoopValue = 0 ; LoopValue < TotalNofDistinctWords ; LoopValue++ )
            //{
            //    double tempFrequency = 0;
            //    double Probability;
            //    clsSaveToFinalDB clsObj = new clsSaveToFinalDB();
            //    string WordsIs = ds.Tables [ 1 ].Rows [ LoopValue ] [ "Word" ].ToString().Trim();

            //    if ( WordsIs != string.Empty && WordsIs.Length >1 )
            //    {
            //        tempFrequency = BussinessLogicLayerControler.GEtFrequencyOfThisWod( WordsIs );

            //        //for ( int loop2 = 0 ; loop2 < NoAllWordsInDB ; loop2++ ) /// is loop mein hum database k tamam words to one by
            //        //                                                        /// one check karein gy jo k distinct Words mein ha.
            //        //                                                        /// Taky hum us word ki frequency nikal saky
            //        //{
            //        //    if ( WordsIs == ds.Tables [ "tblWordsPb" ].Rows [ loop2 ] [ "Word" ].ToString().Trim() )
            //        //    {
            //        //        tempFrequency += Convert.ToDouble( ds.Tables [ "tblWordsPb" ].Rows [ loop2 ] [ "Frequency" ].ToString().Trim() );
            //        //    }

            //        //}

            //        if ( tempFrequency > 0 )
            //        {
            //            Probability = Math.Round( ( ( tempFrequency * 100 ) / NoAllWordsInDB ), 6 );

            //            clsObj.Word = WordsIs;
            //            clsObj.Frequency = tempFrequency;
            //            clsObj.Probability = Probability;

            //            lstSAveInDB.Add( clsObj );
            //        }



            //    }
            //}

            bool success = BussinessLogicLayerControler.SaveInNewDataBase(lstNewFInalList);/// Yahan hum jo new words aye hain distinct unko
                                                                                           /// new database my save kary gy


            //if ( success == true )
            //{
            //    DataTable dt = new DataTable();
            //    dt = BussinessLogicLayerControler.getTableNew();

            //    lstSomeData = BussinessLogicLayerControler.GetSomeNcessaryDate();
            //    MaxProbability = lstSomeData [ 0 ];
            //    AverageProbability = lstSomeData [ 1 ] ;
            //    List<clsSaveToFinalDB> lstSAveInTbleNew = new List<clsSaveToFinalDB>();
            //    for ( int loop = 0 ; loop < dt.Rows.Count ; loop++ )
            //    {
            //        if ( loop == 2345 )
            //        { 
            //        }
            //        clsSaveToFinalDB objcls = new clsSaveToFinalDB();
            //        int id = Convert.ToInt32( dt.Rows [ loop ] [ "Id" ] );
            //        string word = dt.Rows [ loop ] [ "Word" ].ToString().Trim();
            //        double ProbabilityOfWords = Convert.ToDouble(dt.Rows [ loop ] [ "Probability" ]);

            //        double KnowingProbability = Math.Round( ( ( ProbabilityOfWords - AverageProbability ) + ( 0.5 * MaxProbability ) ) / MaxProbability, 4 ) * 100;

            //        double NotKnowingProbability = 100.00 - KnowingProbability;
            //        //if ( NotKnowingProbability < 0 )
            //        //    NotKnowingProbability *= -1;

            //        double InformationQuantity = Math.Log( ( 1.0 / (NotKnowingProbability/10000) ), 2 );
            //     // double xce = Convert.ToDouble(InformationQuantity);
            //        double FinalEntropy = InformationQuantity * NotKnowingProbability;
            //        if ( FinalEntropy < 0 )
            //            FinalEntropy *= -1;

            //        objcls.Id = id;
            //        objcls.Word = word;
            //        objcls.KnowingProbability = KnowingProbability;
            //        objcls.NotKnowingProbability = NotKnowingProbability;
            //        objcls.InformationQuantity = InformationQuantity;
            //        objcls.FinalEntropia = FinalEntropy;
            //        lstSAveInTbleNew.Add( objcls );

            //    }

            //    bool SuccessFinal = BussinessLogicLayerControler.UpdateNewTableFinally( lstSAveInTbleNew );
            if (success == true) MessageBox.Show("Seu banco de dados foi definido.", "Inserção de DataBase concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void btnScale_Click(object sender, EventArgs e)
        {
            string MatchingWords = string.Empty;
            string strTemp;
            List<string> lstTemp = new List<string>();
            strTemp = rtbINput.Text.ToUpper();    // New Logic, It will remove all empty spaces in throughout the whole document.So lets give this string to this variable
            strTemp = String.Join(" ", strTemp.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)); // This line is going to do the magic to remove all empty spaces.
            string[] ArrayTemp = strTemp.Split(' ', '.');
            foreach (var item in ArrayTemp)
            {
                if (item.Trim() != string.Empty)
                {
                    bool succes = CheckShowScaleValidation(item.Trim());
                    if (succes == false)
                    {
                        lstTemp.Add(item.Trim());
                        MatchingWords += "'" + item.Trim() + "',";
                    }
                }
            }

            frmProbabilityScale frmps = new frmProbabilityScale();
            dsShowScale dsss = new dsShowScale();
            List<clsSaveToFinalDB> lstShowScale = new List<clsSaveToFinalDB>();
            dsss = BussinessLogicLayerControler.ShowProbabilityScale(MatchingWords.TrimEnd(','));
            double tempSumOfProb = 0.0;
            double tempSumOfEntropia = 0.0;

            #region Commented
            ////foreach ( var WordIs in lstTemp )
            ////{
            ////    wordFound = false;
            ////    foreach ( DataTable table in dsss.Tables )
            ////    {
            ////        foreach ( DataRow row in table.Rows )
            ////        {
            ////            clsSaveToFinalDB clsObjshowScale = new clsSaveToFinalDB();


            ////            
            ////            ////foreach ( object item in row.ItemArray )
            ////            ////{
            ////            ////    if ( row.ItemArray [ 0 ].ToString() != WordIs )
            ////            ////    {
            ////            ////        break;
            ////            ////    }

            ////            ////    else
            ////            ////        if ( item.ToString().Trim() != string.Empty && row.ItemArray [ 0 ].ToString() == WordIs )
            ////            ////    {

            ////            ////        clsObjshowScale.Word = row.ItemArray [ 0 ].ToString();
            ////            ////        clsObjshowScale.Frequency = Convert.ToDouble(row.ItemArray [ 1]);
            ////            ////        clsObjshowScale.Probability = Convert.ToDouble( row.ItemArray [ 2 ] );
            ////            ////        clsObjshowScale.KnowingProbability = Convert.ToDouble( row.ItemArray [ 3 ] );
            ////            ////        clsObjshowScale.NotKnowingProbability = Convert.ToDouble( row.ItemArray [ 4 ] );
            ////            ////        clsObjshowScale.InformationQuantity = Convert.ToDouble( row.ItemArray [ 5 ] );
            ////            ////        clsObjshowScale.FinalEntropia = Convert.ToDouble( row.ItemArray [ 7 ] );
            ////            ////        lstShowScale.Add( clsObjshowScale );
            ////            ////        wordFound = true;
            ////            ////        tempSumOfProb += clsObjshowScale.Probability;
            ////            ////        tempSumOfEntropia += clsObjshowScale.Probability; 

            ////            ////            if (MiniMumProbabilityOfScale == 0.0)

            ////            ////        {
            ////            ////            MiniMumProbabilityOfScale = clsObjshowScale.Probability;

            ////            ////        }
            ////            ////        else
            ////            ////            if( MiniMumProbabilityOfScale > clsObjshowScale.Probability)
            ////            ////            {
            ////            ////                MiniMumProbabilityOfScale = clsObjshowScale.Probability;
            ////            ////            }

            ////            ////           //...................................................

            ////            ////             if (MaximumProbabilityofScale == 0.0)

            ////            ////        {
            ////            ////            MaximumProbabilityofScale = clsObjshowScale.Probability;

            ////            ////        }
            ////            ////        else
            ////            ////            if( MaximumProbabilityofScale < clsObjshowScale.Probability)
            ////            ////            {
            ////            ////                MaximumProbabilityofScale = clsObjshowScale.Probability;
            ////            ////            }
            ////            ////            //...................................................

            ////            ////             if (MinimumEntropyOfScale == 0.0)

            ////            ////        {
            ////            ////            MinimumEntropyOfScale =  clsObjshowScale.FinalEntropia;

            ////            ////        }
            ////            ////        else
            ////            ////                 if (MinimumEntropyOfScale > clsObjshowScale.FinalEntropia)
            ////            ////            {
            ////            ////                MinimumEntropyOfScale = clsObjshowScale.FinalEntropia;
            ////            ////            }
            ////            ////            //...................................................

            ////            ////             if (MaximumEntropyOfScale == 0.0)
            ////            ////             {
            ////            ////                 MaximumEntropyOfScale = clsObjshowScale.FinalEntropia;

            ////            ////             }
            ////            ////             else
            ////            ////                 if (MaximumEntropyOfScale < clsObjshowScale.FinalEntropia)
            ////            ////                 {
            ////            ////                     MaximumEntropyOfScale = clsObjshowScale.FinalEntropia;
            ////            ////                 }
            ////            ////             //...................................................



            ////            ////            break;
            ////            ////    }
            ////            ////}
            ////         

            ////            if (wordFound == true)
            ////            {
            ////                break;
            ////            }
            ////        }
            ////        if (wordFound == true)
            ////            break;
            ////    }
            ////    if (wordFound == false)
            ////    {

            ////        clsSaveToFinalDB ss = new clsSaveToFinalDB();
            ////        ss.Word = WordIs;
            ////        ss.Frequency = 0.0;
            ////        ss.Probability = 0.0;
            ////        ss.KnowingProbability = 0.0;
            ////        ss.NotKnowingProbability = 0.0;
            ////        ss.InformationQuantity = 0.0;
            ////        ss.FinalEntropia = 0.0;
            ////        lstShowScale.Add(ss);
            ////    }

            ////}

            #endregion Commented

            if (dsss != null && dsss.Tables.Count > 0)
            {
                System.Data.DataTable dtFoundStrings = dsss.Tables[0];

                if (dtFoundStrings != null && dtFoundStrings.Rows.Count > 0)
                {
                    ////double.TryParse(dtFoundStrings.Compute("MAX([Probability])","").ToString(), out MaximumProbabilityofScale);
                    ////double.TryParse(dtFoundStrings.Compute("MIN([Probability])", "").ToString(), out MiniMumProbabilityOfScale);
                    ////double.TryParse(dtFoundStrings.Compute("AVG([Probability])", "").ToString(), out AverageProbabilityofScale);

                    ////double.TryParse(dtFoundStrings.Compute("MAX([KnowingProbability])", "").ToString(), out MaximumKnowingProbabilityOfScale );
                    ////double.TryParse(dtFoundStrings.Compute("MIN([KnowingProbability])", "").ToString(), out MimimumKnowingProbabilityOfScale);
                    ////double.TryParse(dtFoundStrings.Compute("AVG([KnowingProbability])", "").ToString(), out AverageKnowingProbabilityOfScale);

                    ////double.TryParse(dtFoundStrings.Compute("MAX([NotknowingProbability])", "").ToString(), out MaximumNotKnowingProbabilityOfScale);
                    ////double.TryParse(dtFoundStrings.Compute("MIN([NotknowingProbability])", "").ToString(), out MimimumNotKnowingProbabilityOfScale);
                    ////double.TryParse(dtFoundStrings.Compute("AVG([NotknowingProbability])", "").ToString(), out AverageNotKnowingProbabilityOfScale);

                    ////double.TryParse(dtFoundStrings.Compute("MAX([CommunicationEntropy])", "").ToString(), out MaximumEntropyOfScale);
                    ////double.TryParse(dtFoundStrings.Compute("MIN([CommunicationEntropy])", "").ToString(), out MinimumEntropyOfScale);
                    ////double.TryParse(dtFoundStrings.Compute("AVG([CommunicationEntropy])", "").ToString(), out AverageEntropyOfScale);

                    ////double.TryParse(dtFoundStrings.Compute("MAX([InformationQuantity])", "").ToString(), out MaximumInformationQuantityOfScale);
                    ////double.TryParse(dtFoundStrings.Compute("MIN([InformationQuantity])", "").ToString(), out MimimumInformationQuantityOfScale);
                    ////double.TryParse(dtFoundStrings.Compute("AVG([InformationQuantity])", "").ToString(), out AverageInformationQuantityOfScale);


                    foreach (DataRow row in dtFoundStrings.Rows)
                    {
                        clsSaveToFinalDB clsObjshowScale = new clsSaveToFinalDB();
                        clsObjshowScale.Word = row.ItemArray[0].ToString();
                        clsObjshowScale.Frequency = Convert.ToDouble(row.ItemArray[1]);
                        clsObjshowScale.Probability = Convert.ToDouble(row.ItemArray[2]);
                        clsObjshowScale.KnowingProbability = Convert.ToDouble(row.ItemArray[3]);
                        clsObjshowScale.NotKnowingProbability = Convert.ToDouble(row.ItemArray[4]);
                        clsObjshowScale.InformationQuantity = Convert.ToDouble(row.ItemArray[5]);
                        clsObjshowScale.FinalEntropia = Convert.ToDouble(row.ItemArray[7]);
                        lstShowScale.Add(clsObjshowScale);
                        tempSumOfProb += clsObjshowScale.Probability;
                        tempSumOfEntropia += clsObjshowScale.Probability;
                    }
                }
            }
            //List<double> lstDetail = new List<double>();
            //lstDetail = BussinessLogicLayerControler.GetDetailOfProbabilityAndEntropy();

            //frmProbabilityScale.MiniMumEntropy = Math.Round(MinimumEntropyOfScale, 2); ;
            //frmProbabilityScale.MaxiMumEntropy = Math.Round(MaximumEntropyOfScale, 2); ;
            //frmProbabilityScale.AverageEntropy = Math.Round(tempSumOfEntropia / lstShowScale.Count, 2); ;

            //frmProbabilityScale.MiniMumProbability = Math.Round(MiniMumProbabilityOfScale, 2); ;
            //frmProbabilityScale.MaxiMumProbability = Math.Round(MaximumProbabilityofScale, 2); ;
            //frmProbabilityScale.AverageProbability = Math.Round(tempSumOfProb / lstShowScale.Count, 2); ;

            frmProbabilityScale.lstShowScale = lstShowScale;
            frmps.ShowDialog();



        }

        private void btnLettersProbability_Click(object sender, EventArgs e)
        {

            if (OKButtonIsChecked == true)
            {
                if (!string.IsNullOrEmpty(rtbINput.Text))
                {
                    LettersMinimumEntropy = 0;
                    LetterMaximumEntropy = 0;
                    CheckIfWordsProbabilityIsClicked = false;
                    CheckIfLettersProbabilitIsClicked = true;
                    dgvLettersProbability.Visible = true;
                    dgvWordsProbability.Visible = false;
                    lstLettersEntropy = new List<ClassLettersEntropy>();
                    lstWordsEntropy = new List<ClassWordsEntropy>();
                    btnScale.Visible = true;
                    btnEntropy.Visible = true;
                    if (listOfAlphabetsOccerence.Count != 0)
                    {
                        dgvLettersProbability.DataSource = null;
                        listOfAlphabetsOccerence = new List<ClassLettersProbability>();


                    }


                    string[] PortugueseAlphabets = new string[26];
                    string[] CountPortugueseAlphabets = new string[26];
                    string TempPortugueseAlphabets = "a b c d e f g h i j k l m n o p q r s t u v w x y z";
                    PortugueseAlphabets = TempPortugueseAlphabets.Split(' ');
                    string tempstr;
                    string strUpperTextString = rtbINput.Text.ToLower();
                    int CountedLetters = 0;
                    decimal Probability;
                    for (int letterloop = 0; letterloop < PortugueseAlphabets.Length; letterloop++)
                    {

                        tempstr = PortugueseAlphabets[letterloop].ToString(); // getting Letter or char to compare with alphabets
                        if (letterloop == 0 || letterloop == 2 || letterloop == 4 || letterloop == 8 || letterloop == 14 || letterloop == 20)
                        {
                            int SwtichCaseVariable = letterloop;
                            switch (SwtichCaseVariable)
                            {
                                case 0: // in this case we will match all chars or Letters and get the total of them: a á   à   ã   â
                                    string[] mytempcharsA = new string[5];
                                    mytempcharsA = "a á à ã â".Split(' ');
                                    for (int CaseLoop = 0; CaseLoop <= 4; CaseLoop++)
                                    {
                                        string tempA = mytempcharsA[CaseLoop];

                                        foreach (Match m in Regex.Matches(strUpperTextString, tempA))
                                        {
                                            CountedLetters++;
                                        }
                                    }

                                    break;


                                case 2: // in this case we will match all chars or Letters and get the total of them: c ç

                                    string[] mytempcharsC = new string[2];
                                    mytempcharsC = "c ç".Split(' ');
                                    for (int loopA = 0; loopA <= 1; loopA++)
                                    {
                                        string tempA = mytempcharsC[loopA];

                                        foreach (Match m in Regex.Matches(strUpperTextString, tempA))
                                        {
                                            CountedLetters++;
                                        }
                                    }
                                    break;


                                case 4:// in this case we will match all chars or Letters and get the total of them: e é ê
                                    string[] mytempcharsE = new string[2];
                                    mytempcharsE = "e é ê".Split(' ');
                                    for (int loopE = 0; loopE <= 2; loopE++)
                                    {
                                        string tempA = mytempcharsE[loopE];

                                        foreach (Match m in Regex.Matches(strUpperTextString, tempA))
                                        {
                                            CountedLetters++;
                                        }
                                    }

                                    break;


                                case 8:// in this case we will match all chars or Letters and get the total of them: i í
                                    string[] mytempcharsI = new string[2];
                                    mytempcharsI = "i í".Split(' ');
                                    for (int loopI = 0; loopI <= 1; loopI++)
                                    {
                                        string tempA = mytempcharsI[loopI];

                                        foreach (Match m in Regex.Matches(strUpperTextString, tempA))
                                        {
                                            CountedLetters++;
                                        }
                                    }
                                    break;

                                case 14:// in this case we will match all chars or Letters and get the total of them: o ó ô õ

                                    string[] mytempcharsO = new string[2];
                                    mytempcharsO = "o ó ô õ".Split(' ');
                                    for (int loopI = 0; loopI <= 3; loopI++)
                                    {
                                        string tempA = mytempcharsO[loopI];

                                        foreach (Match m in Regex.Matches(strUpperTextString, tempA))
                                        {
                                            CountedLetters++;
                                        }
                                    }

                                    break;

                                case 20:// in this case we will match all chars or Letters and get the total of them: u ú

                                    string[] mytempcharsU = new string[2];
                                    mytempcharsU = "u ú".Split(' ');
                                    for (int loopI = 0; loopI <= 1; loopI++)
                                    {
                                        string tempA = mytempcharsU[loopI];

                                        foreach (Match m in Regex.Matches(strUpperTextString, tempA))
                                        {
                                            CountedLetters++;
                                        }
                                    }

                                    break;





                                default:
                                    break;
                            }
                        }
                        else
                        {



                            //if ( tempstr == "á" || tempstr == "à" || tempstr == "ã" || tempstr == "â" )
                            //{
                            //    tempstr = "a";

                            //}
                            foreach (Match m in Regex.Matches(strUpperTextString, tempstr))
                            {
                                CountedLetters++;
                            }
                        }
                        ClassLettersProbability classlp = new ClassLettersProbability();
                        if (CountedLetters != 0)
                        {
                            classlp.Letras = PortugueseAlphabets[letterloop].ToString();
                            // decimal tempcount = Convert.ToDecimal(Math.Round( count, 2 ));
                            Probability = Math.Round(Convert.ToDecimal((CountedLetters * 100) / count) / 100, 6);
                            SumofProbability += Probability;
                            classlp.Frequência = CountedLetters;
                            classlp.Probablidade = Probability;
                            listOfAlphabetsOccerence.Add(classlp);




                            double tempProb = Convert.ToDouble(classlp.Probablidade);
                            double QuantityInfoI = Math.Log(1 / (tempProb), 2);
                            string FinalEntropy = (Math.Round((QuantityInfoI * tempProb), 6)).ToString();
                            ClassLettersEntropy ClsLE = new ClassLettersEntropy();  /// a class that will hold data of Entropy of Letters
                                                                                    /// 


                            ClsLE.LetterName = classlp.Letras;                     /// we are saving the Name of letter with its entropy value.
                                                                                   /// .
                                                                                   /// 
                            ClsLE.LetterEntropy = FinalEntropy;
                            ClsLE.LetterQuantityInformation = (Math.Round(QuantityInfoI, 6)).ToString();

                            lstLettersEntropy.Add(ClsLE);                        /// add that object in a list then we'll add new letter and its entropy

                            TotalLetterENtropy += Convert.ToDouble(FinalEntropy);
                            if (LettersMinimumEntropy == 0 && LetterMaximumEntropy == 0)
                            {
                                LettersMinimumEntropy = Convert.ToDouble(FinalEntropy);
                                LetterMaximumEntropy = Convert.ToDouble(FinalEntropy);

                            }
                            else
                            {
                                if (LettersMinimumEntropy > Convert.ToDouble(FinalEntropy))
                                    LettersMinimumEntropy = Convert.ToDouble(FinalEntropy);
                                if (LetterMaximumEntropy < Convert.ToDouble(FinalEntropy))
                                    LetterMaximumEntropy = Convert.ToDouble(FinalEntropy);
                            }
                            CountedLetters = 0;

                        }
                    }
                    dgvLettersProbability.DataSource = listOfAlphabetsOccerence;

                    frmEntropy.ListOfLettersEntropy = lstLettersEntropy;
                    frmEntropy.TotalLetterENtropy = TotalLetterENtropy;
                    frmEntropy.AverageOfLetterEntropI = TotalLetterENtropy / 26;
                    frmEntropy.LetterMaximumEntropI = LetterMaximumEntropy;
                    frmEntropy.LettersMinimumEntropI = LettersMinimumEntropy;
                    frmEntropy.ShowLettersEntropy = true;
                    frmEntropy.ShowWordsEntropy = false;
                }
                else
                    MessageBox.Show("Por favor, digite um texto.", "Nenhum texto encontrado.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Por favor, conte as letras ou palavras para obter os seus detalhes.", "Contagem inválida.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region OtherEvent
        private void rtbINput_TextChanged(object sender, EventArgs e)
        {

        }
        private void rtbINput_MouseMove(object sender, MouseEventArgs e)
        {
        }
        private void CMSPaste_Click(object sender, EventArgs e)
        {
            rtbINput.Text += Clipboard.GetText();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbINput.Text = string.Empty;
        }

        private void rtbINput_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (String.IsNullOrEmpty(rtbINput.Text))
            //{
            //    btnScale.Enabled = false;
            //}
            //else
            //{
            //    btnScale.Enabled = true;
            //}
        }

        private void frmMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           System.Windows.Forms.Application.Exit();
        }

        private void btnImportFromExcel_Click(object sender, EventArgs e)
        {
            try
            {
                ImportFileDialogue.Filter = "Excel (*.xls,*.xlsx,*.csv) | *.xls;*.xlsx;*.csv";
                DialogResult result = ImportFileDialogue.ShowDialog(); // Show the dialog.
                ImportFileDialogue.RestoreDirectory = true;
                if (result == DialogResult.OK) // Test result.
                {   
                    string FilePath = ImportFileDialogue.FileName;
                    //string FilePath = @"C:\Users\zains\Desktop\zahid\ExportData\Entropy.xls";
                   DataSet dSetImportFile = GetDataFromExcel(FilePath);
                    SaveImportDataToDB(dSetImportFile);
                }
            }
            catch (Exception ex)
            {

            }   
        }
         private void SaveImportDataToDB(DataSet dSet)
        {
            try
            {
                ProbBLL objBLL = new ProbBLL();
                bool Success = objBLL.SaveImportDataToDB(dSet);
                if (Success == true){
                    MessageBox.Show("Os dados foram importados com sucesso","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else{
                    MessageBox.Show("Parece que os dados não estavam no formato correto. Por favor, o formato se o erro ainda existe, em seguida, entre em contato com o administrador do banco de dados.","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void menuStripImportData_Click(object sender, EventArgs e)
        {
            try
            {
                ImportFileDialogue.Filter = "Excel (*.xls,*.xlsx,*.csv) | *.xls;*.xlsx;*.csv";
                DialogResult result = ImportFileDialogue.ShowDialog(); // Show the dialog.
                ImportFileDialogue.RestoreDirectory = true;
                if (result == DialogResult.OK) // Test result.
                {
                    string FilePath = ImportFileDialogue.FileName;
                    //string FilePath = @"C:\Users\zains\Desktop\zahid\ExportData\Entropy.xls";
                    DataSet dSetImportFile = GetDataFromExcel(FilePath);
                    SaveImportDataToDB(dSetImportFile);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void menuStripResetData_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ImportResult = MessageBox.Show("Tem certeza de que deseja redefinir o banco de dados?", "Redefinir banco de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ImportResult == DialogResult.Yes)
                {
                    ProbBLL objBLL = new ProbBLL();
                   bool Success =  objBLL.ResetDatabase();
                    if (Success == true)
                        {
                            MessageBox.Show("Seu banco de dados foi redefinido.","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }else{
                            MessageBox.Show("Não foi possível redefinir seu banco de dados. entre em contato com o seu administrador de banco de dados.","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
        
            catch (Exception ex)
            {
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cLoseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tu realmente desejas fechar este programa?", "Confirmaçãode saída", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();

            }
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (rtbINput.Text != string.Empty)
            {
                //( dgvWordsProbability.DataSource as DataTable ).DefaultView.RowFilter = string.Format( "coldgvWords = '{0}'", txtSearch.Text.ToUpper() );
                //string rowFilter = string.Format( "[{0}] = '{1}'", coldgvWords, txtSearch.Text.ToUpper() );
                //( dgvWordsProbability.DataSource as DataTable ).DefaultView.RowFilter = rowFilter;


                //bs.Filter = string.Format( "coldgvWords LIKE '%{0}%'", txtSearch.Text.ToUpper() );
                ////bs.Filter = coldgvWords + " like '%" + txtSearch.Text + "%'";
                //dgvWordsProbability.DataSource = bs;
                //dataGridView1.DataSource = bs;
                //dataGridView1.Refresh();
                //DataTable dt = new DataTable();
                if (CheckIfWordsProbabilityIsClicked == true)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dgvWordsProbability.DataSource;
                    BindingList<ClassWordsProbability> filtered = new BindingList<ClassWordsProbability>(listOfWordsOccerence.Where(obj => obj.Palavras.Contains(txtSearch.Text.ToUpper())).ToList());

                    dgvWordsProbability.DataSource = filtered;
                    dgvWordsProbability.Update();
                }
                else
                {
                    if (CheckIfLettersProbabilitIsClicked == true)
                    {
                        BindingSource bsLetters = new BindingSource();
                        bsLetters.DataSource = dgvLettersProbability.DataSource;
                        BindingList<ClassLettersProbability> filtered = new BindingList<ClassLettersProbability>(listOfAlphabetsOccerence.Where(obj => obj.Letras.Contains(txtSearch.Text.ToLower())).ToList());

                        dgvLettersProbability.DataSource = filtered;
                        dgvLettersProbability.Update();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, digite um texto.", "Não há texto ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch.Clear();
            }


        }
        private void roundButton2_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvWordsProbability.DataSource;
            bs.Filter = coldgvWords + " like '%" + txtSearch.Text + "%'";
            dgvWordsProbability.DataSource = bs;
            System.Data.DataTable dt = new System.Data.DataTable();

        }
        #endregion
    }
}
