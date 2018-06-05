using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilityDAL
{
    public class ProbabilityDataAccessLayer
    {

        public static bool SaveToDB ( List<ProbabilityBussinessObjectLayer.FinalProb> lstContainingAllRecordToSaveInDB )
        {
            bool Success = false;
            SqlConnection con = new SqlConnection();
            //List<ProbabilityBussinessObjectLayer.FinalProb> objlst = new List<ProbabilityBussinessObjectLayer.FinalProb>();
            //double x = objlst[1].Frequency;
            //double sx = lstContainingAllRecordToSaveInDB[2].Frequency;

            con.ConnectionString = "Data Source=(localdb)\\Projects;Initial Catalog=ProbabilityCalculator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
            
            try
            {
                con.Open();
                for (int i = 0; i < lstContainingAllRecordToSaveInDB.Count-1; i++)
			{
			    string Query = "insert into tblWordsPb (Word,Frequency,Probability) values ('"+lstContainingAllRecordToSaveInDB[i].Word+"','"+lstContainingAllRecordToSaveInDB[i].Frequency+"','"+lstContainingAllRecordToSaveInDB[i].Probability+"')";
                SqlCommand cmd = new SqlCommand( Query, con );
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
            catch ( Exception ex )
            {

                throw ex;
            }
            
            return Success;
        }

        public static bool SaveListOfWordsInDatabase ( ProbabilityBussinessObjectLayer.ProbabilityCommon CommControler )
        {
            bool Success = false;
                
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(localdb)\\Projects;Initial Catalog=ProbabilityCalculator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
                
                string Query = "insert into tblMinMax (MinProb,MaxProb,AverageProb) values ('"+CommControler.MiniMumProbability+"','"+CommControler.MaximumProbability+"','"+CommControler.AverageProbability+"')";
                SqlCommand cmd = new SqlCommand( Query, con );
                cmd.CommandType = CommandType.Text;    

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

                con.Close();
                con = null;
                Success = true;

            }
            catch ( Exception ex )
            {

                throw ex;
            }

            return Success;
        }
    }
}
