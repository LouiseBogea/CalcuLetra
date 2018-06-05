using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProbabilityBussinessObjectLayer;
namespace ProbabilityDAL
{
    public class ProbabilityDataAccessLayer
    {
       // public static string ConnectionString = "Data Source=DESKTOP-5COL69B;Initial Catalog=ProbabilityCalculator;user id = sa; password = sql12345; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        public static string ConnectionString = @"Data Source=CLIENTE-PC\SQLSERVER;Initial Catalog=ProbabilityCalculator; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        public static bool SaveToDB(List<ProbabilityBussinessObjectLayer.FinalProb> lstContainingAllRecordToSaveInDB)
        {
            bool Success = false;
            SqlConnection con = new SqlConnection();

            con.ConnectionString = ConnectionString;//"Data Source=(localdb)\\Projects;Initial Catalog=ProbabilityCalculator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

            try
            {
                con.Open();
                for (int i = 8802; i < lstContainingAllRecordToSaveInDB.Count - 1; i++)
                {

                    //i += 1;

                    string Query = "insert into tblWordsPb (Word,Frequency,Probability) values ('" + lstContainingAllRecordToSaveInDB[i].Word + "','" + lstContainingAllRecordToSaveInDB[i].Frequency + "','" + lstContainingAllRecordToSaveInDB[i].Probability + "')";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                con = null;
                Success = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return Success;
        }

        public static bool GetUser(string pStrUserName, string pStrPassword)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConnectionString;
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM tblUser WHERE username='" + pStrUserName + "' AND password='" + pStrPassword + "'", con);
                DataTable lObjDt = new DataTable();
                sda.Fill(lObjDt);
                if (lObjDt.Rows[0][0].ToString() == "1")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
        public static bool SaveListOfWordsInDatabase(ProbabilityBussinessObjectLayer.ProbabilityCommon CommControler)
        {
            bool Success = false;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectionString;//"Data Source=(localdb)\\Projects;Initial Catalog=ProbabilityCalculator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";


            string Query = "insert into tblMinMax (MinProb,MaxProb,AverageProb) values ('" + CommControler.MiniMumProbability + "','" + CommControler.MaximumProbability + "','" + CommControler.AverageProbability + "')";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.CommandType = CommandType.Text;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

                con.Close();
                con = null;
                Success = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return Success;
        }

        public static bool CreateAccount(string pStrUserName, string pStrPAsssword)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectionString;
            try
            {
                con.Open();
                {
                    string Query = "insert into tblUser (username,password) values ('" + pStrUserName + "','" + pStrPAsssword + "')"; 
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool ResetDatabase()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectionString;
            try
            {
                con.Open();
                {
                    string Query = "TRUNCATE TABLE tblNew";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        public static bool SaveImportDataToDB(DataSet dSet)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // make sure to enable triggers
                    // more on triggers in next post
                    SqlBulkCopy bulkCopy =
                        new SqlBulkCopy
                        (
                        connection,
                        SqlBulkCopyOptions.TableLock |
                        SqlBulkCopyOptions.FireTriggers |
                        SqlBulkCopyOptions.UseInternalTransaction,
                        null
                        );

                    // set the destination table name
                    bulkCopy.DestinationTableName = "tblNew";//dSet.Tables[0].TableName;
                    connection.Open();

                    // write the data in the "dataTable"
                    bulkCopy.WriteToServer(dSet.Tables[0]);
                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool SaveToDBNew(List<EncrytpionDecryption.ClassWordsProbability> listOfWordsOccerence)
        {
            bool Success = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectionString;//"Data Source=(localdb)\\Projects;Initial Catalog=ProbabilityCalculator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

            try
            {
                con.Open();
                for (int i = 0; i < listOfWordsOccerence.Count; i++)
                {

                    //i += 1;

                    string Query = "insert into tblWordsPb (Word,Frequency,Probability) values ('" + listOfWordsOccerence[i].Palavras + "','" + listOfWordsOccerence[i].Frequência + "','" + listOfWordsOccerence[i].Probabilidade + "')";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }

                //if ( (cmd.ExecuteNonQuery()  )
                //{

                //}

                con.Close();
                con = null;
                Success = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return Success;
        }



        public static ProbabilityBussinessObjectLayer.dsDistinctWords GetDSOfDistinctWorld()
        {

            dsDistinctWords ds = new dsDistinctWords();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectionString;//"Data Source=(localdb)\\Projects;Initial Catalog=ProbabilityCalculator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
            con.Open();
            //string querry = "select * from tblWordsPb";
            //string Query = "select * from tblWordsPb order by word asc";
            string Query = "select distinct word from tblWordsPb order by word asc";
            // SqlDataAdapter da = new SqlDataAdapter( querry, con );
            // da.Fill( ds.Tables [ "tblWordsPb" ] );


            //   da.Dispose();
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            da.Fill(ds.Tables["tblDistinctWords"]);
            con.Close();
            da.Dispose();
            con.Close();

            return ds;
        }



        public static List<double> GetSomeNcessaryDate()
        {
            List<double> lstTemp = new List<double>();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectionString;//"Data Source=(localdb)\\Projects;Initial Catalog=ProbabilityCalculator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
            string QueryMax = "select max(probability) from tblNew";
            string QuerySumOfProb = "select AVG(probability) from tblNew";

            double max, SumOfProb;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(QueryMax, con);
                SqlCommand cmdsum = new SqlCommand(QuerySumOfProb, con);
                //cmd.ExecuteReader().ToString();
                max = Convert.ToDouble(cmd.ExecuteScalar());
                SumOfProb = Convert.ToDouble(cmdsum.ExecuteScalar());
                lstTemp.Add(max);
                lstTemp.Add(SumOfProb);
                con.Close();
                con = null;


            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lstTemp;
        }

        public static bool SaveInNewDataBase(List<clsSaveToFinalDB> lstSAveInDB)
        {
            bool success = false;
            SqlConnection con = new SqlConnection();

            con.ConnectionString = ConnectionString;//"Data Source=(localdb)\\Projects;Initial Catalog=ProbabilityCalculator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

            try
            {
                con.Open();
                foreach (var item in lstSAveInDB)
                {


                    string Query = "insert into [dbo].[tblNew] (Word,Frequency,Probability,KnowingProbability,NotknowingProbability,InformationQuantity,CommunicationEntropy) values ('" + item.Word + "','" + item.Frequency + "','" + item.Probability + "','" + item.KnowingProbability + "','" + item.NotKnowingProbability + "','" + item.InformationQuantity + "','" + item.FinalEntropia + "')";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                con = null;
                success = true;

            }
            catch (Exception ex)
            {

                throw ex;
            }


            return success;

        }

        public static DataTable GetTableNew()
        {
            DataTable dt = new DataTable();
            try
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConnectionString; //"Data Source=(localdb)\\Projects;Initial Catalog=ProbabilityCalculator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
                con.Open();
                string querry = "select * from tblNew";

                SqlDataAdapter da = new SqlDataAdapter(querry, con);
                da.Fill(dt);


                da.Dispose();

                con.Close();
                da.Dispose();
                con.Close();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

        public static bool UpdateNewTableFinally(List<clsSaveToFinalDB> lstSAveInTbleNew)
        {
            bool success = false;
            SqlConnection con = new SqlConnection();

            con.ConnectionString = ConnectionString; //"Data Source=(localdb)\\Projects;Initial Catalog=ProbabilityCalculator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

            try
            {
                con.Open();
                for (int i = 0; i < lstSAveInTbleNew.Count - 1; i++)
                {
                    string Query = "update tblNew set KnowingProbability = '" + lstSAveInTbleNew[i].KnowingProbability + "', NotknowingProbability =  '" + lstSAveInTbleNew[i].NotKnowingProbability + "', InformationQuantity = '" + lstSAveInTbleNew[i].InformationQuantity + "', CommunicationEntropy = '" + lstSAveInTbleNew[i].FinalEntropia + "' where id  = '" + lstSAveInTbleNew[i].Id + "'";

                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                con = null;
                success = true;

            }
            catch (Exception ex)
            {

                con.Close();
                con = null;
                success = false;
                throw ex;

            }


            return success;
        }

        public static double GEtFrequencyOfThisWod(string WordsIs)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectionString; //"Data Source=(localdb)\\Projects;Initial Catalog=ProbabilityCalculator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

            string Query = "select isnull (sum(frequency),-1) from tblWordsPb where word = '" + WordsIs + "'";


            double Frequency;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);

                Frequency = Convert.ToDouble(cmd.ExecuteScalar());

                con.Close();
                con = null;


            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Frequency;
        }

        public static List<clsSaveToFinalDB> ProbabilityBussinessObjectLayer(List<string> TempDisntinctWOrd)
        {
            List<clsSaveToFinalDB> lst = new List<clsSaveToFinalDB>();


            SqlConnection con = new SqlConnection();

            con.ConnectionString = ConnectionString; //"Data Source=(localdb)\\Projects;Initial Catalog=ProbabilityCalculator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

            try
            {
                con.Open();
                string QToatalNofWords = "select count(*) from tblWordsPb";
                string QAverage = "select AVG(probability) from tblWordsPb";
                double MaxProbability = 0;
                SqlCommand cmd = new SqlCommand(QToatalNofWords, con);
                int TotalNoWords = Convert.ToInt32(cmd.ExecuteScalar());
                cmd = new SqlCommand(QAverage, con);
                double AverageProbability = Convert.ToDouble(cmd.ExecuteScalar());
                List<clsSaveToFinalDB> TTemplst = new List<clsSaveToFinalDB>();

                foreach (var item in TempDisntinctWOrd)
                {

                    clsSaveToFinalDB TempCls = new clsSaveToFinalDB();
                    string Query = "select isnull (sum(frequency),-1) from tblWordsPb where word = '" + item + "'";

                    cmd = new SqlCommand(Query, con);

                    double Frequency = Convert.ToDouble(cmd.ExecuteScalar());
                    if (Frequency > 0)
                    {
                        double Probability = Math.Round(((Frequency * 100) / TotalNoWords), 6);
                        if (MaxProbability == 0)
                        {
                            MaxProbability = Probability;
                        }
                        else
                        {
                            if (MaxProbability < Probability)
                            {
                                MaxProbability = Probability;
                            }
                        }
                        TempCls.Word = item;
                        TempCls.Frequency = Frequency;
                        TempCls.Probability = Probability;
                        TTemplst.Add(TempCls);




                    }
                }
                con.Close();
                con = null;

                foreach (var item in TTemplst)
                {

                    string word = item.Word;
                    double Frequency = item.Frequency;
                    double prob = item.Probability;
                    double KnowingProbability = Math.Round(((prob - AverageProbability) + (0.5 * MaxProbability)) / MaxProbability, 4) * 100;
                    double NotKnowingProbability = 100.00 - KnowingProbability;
                    if (NotKnowingProbability < 0)
                        NotKnowingProbability *= -1;
                    double InformationQuantity = Math.Log((1.0 / (NotKnowingProbability / 10000)), 2);
                    double FinalEntropy = InformationQuantity * NotKnowingProbability;
                    if (FinalEntropy < 0)
                        FinalEntropy *= -1;
                    clsSaveToFinalDB clsObj = new clsSaveToFinalDB();

                    clsObj.Word = word;
                    clsObj.Frequency = Math.Round(Frequency, 5);
                    clsObj.Probability = Math.Round(prob, 5);
                    clsObj.KnowingProbability = Math.Round(KnowingProbability, 5);
                    clsObj.NotKnowingProbability = Math.Round(NotKnowingProbability, 5);
                    clsObj.InformationQuantity = Math.Round(InformationQuantity, 5);
                    clsObj.FinalEntropia = Math.Round(FinalEntropy, 5);
                    lst.Add(clsObj);

                }



            }
            catch (Exception ex)
            {

                throw ex;
            }




            return lst;
        }

        public static dsShowScale ShowProbabilityScale(string MatchingWords)
        {
            dsShowScale dsss = new dsShowScale();
            try
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConnectionString;//"Data Source=(localdb)\\Projects;Initial Catalog=ProbabilityCalculator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
                con.Open();
                string Query = "SELECT  [Word]  ,[Frequency] ,[Probability] ,[KnowingProbability] ,[NotknowingProbability] ,[InformationQuantity] ,[CommunicationEntropy]   FROM [ProbabilityCalculator].[dbo].[tblNew] WHERE Word IN (" + MatchingWords + ") order by word";
                SqlDataAdapter da = new SqlDataAdapter(Query, con);
                da.Fill(dsss.Tables["dtShowScale"]);
                con.Close();
                da.Dispose();
                con.Close();


            }
            catch (Exception ex)
            {

                throw;
            }
            return dsss;
        }

        public static List<double> GetDetailOfProbabilityAndEntropy()
        {
            List<double> lstTemp = new List<double>();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectionString; //"Data Source=(localdb)\\Projects;Initial Catalog=ProbabilityCalculator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
            string EntropyDetail = "select Min([CommunicationEntropy]), MAX([CommunicationEntropy]),AVG([CommunicationEntropy]) from tblNew";
            string QueryProbability = "select Min([Probability]), MAX([Probability]),AVG([Probability]) from tblNew";
            SqlDataReader reader;

            try
            {
                con.Open();


                SqlCommand cmdEntropia = new SqlCommand(EntropyDetail, con);
                SqlCommand cmdsum = new SqlCommand(QueryProbability, con);

                reader = cmdEntropia.ExecuteReader();
                while (reader.Read())
                {
                    lstTemp.Add(Convert.ToDouble(reader[0]));
                    lstTemp.Add(Convert.ToDouble(reader[1]));
                    lstTemp.Add(Convert.ToDouble(reader[2]));

                }
                reader.Close();
                reader.Dispose();

                reader = cmdsum.ExecuteReader(); // reader has now Probability Information
                while (reader.Read())
                {
                    lstTemp.Add(Convert.ToDouble(reader[0]));
                    lstTemp.Add(Convert.ToDouble(reader[1]));
                    lstTemp.Add(Convert.ToDouble(reader[2]));

                }

                con.Close();
                con = null;
                reader.Close();
                reader.Dispose();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lstTemp;
        }
    }
}
