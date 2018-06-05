using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProbabilityDAL;

namespace ProbabilityBLL
{
    public class ProbBLL
    {

        

        public bool SaveToDB ( List<ProbabilityBussinessObjectLayer.FinalProb> lstContainingAllRecordToSaveInDB )
        {
            return ProbabilityDataAccessLayer.SaveToDB( lstContainingAllRecordToSaveInDB );
        }

        public bool SaveListOfWordsInDatabase ( ProbabilityBussinessObjectLayer.ProbabilityCommon CommControler )
        {
            return ProbabilityDataAccessLayer.SaveListOfWordsInDatabase( CommControler );
        }




        public bool SaveToDBNew ( List<EncrytpionDecryption.ClassWordsProbability> listOfWordsOccerence )
        {
            return ProbabilityDataAccessLayer.SaveToDBNew( listOfWordsOccerence );
        }

        public bool GetUser(string pStrUserName, string pStrPassword)
        {
            return ProbabilityDataAccessLayer.GetUser(pStrUserName,pStrPassword);
        }

        public ProbabilityBussinessObjectLayer.dsDistinctWords GetDSOfDistinctWorld ()
        {
            return ProbabilityDataAccessLayer.GetDSOfDistinctWorld();
        }

        public List<double> GetSomeNcessaryDate ()
        {
            return ProbabilityDataAccessLayer.GetSomeNcessaryDate();
        }

        public bool SaveInNewDataBase ( List<ProbabilityBussinessObjectLayer.clsSaveToFinalDB> lstSAveInDB )
        {
            return ProbabilityDataAccessLayer.SaveInNewDataBase( lstSAveInDB );
        }

        public System.Data.DataTable getTableNew ()
        {
            return ProbabilityDataAccessLayer.GetTableNew();
        }

        public bool UpdateNewTableFinally ( List<ProbabilityBussinessObjectLayer.clsSaveToFinalDB> lstSAveInTbleNew )
        {
            return ProbabilityDataAccessLayer.UpdateNewTableFinally( lstSAveInTbleNew );
        }

        public double GEtFrequencyOfThisWod ( string WordsIs )
        {
            return ProbabilityDataAccessLayer.GEtFrequencyOfThisWod( WordsIs );
        }

        public List<ProbabilityBussinessObjectLayer.clsSaveToFinalDB> ThisMethodWillCoverEverything ( List<string> TempDisntinctWOrd )
        {
            return ProbabilityDataAccessLayer.ProbabilityBussinessObjectLayer( TempDisntinctWOrd );
        }

        public ProbabilityBussinessObjectLayer.dsShowScale ShowProbabilityScale (string MatchingWords)
        {
            return ProbabilityDataAccessLayer.ShowProbabilityScale(MatchingWords);
        }

        public List<double> GetDetailOfProbabilityAndEntropy ()
        {
            return ProbabilityDataAccessLayer.GetDetailOfProbabilityAndEntropy();
        }

        public bool SaveImportDataToDB(DataSet dSet)
        {
            return ProbabilityDataAccessLayer.SaveImportDataToDB(dSet);
        }

        public bool ResetDatabase()
        {
            return ProbabilityDataAccessLayer.ResetDatabase();
        }

        public bool CreateAccount(string pStrUserName,string pStrPAsssword)
        {
            return ProbabilityDataAccessLayer.CreateAccount(pStrUserName, pStrPAsssword);
        }
    }
}
