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
    public partial class frmProbabilityScale : Form
    {
        public static double MiniMumProbability;
        public static double AverageProbability;
        public static double MaxiMumProbability;
        public static double MiniMumEntropy;
        public static double MaxiMumEntropy;
        public static double AverageEntropy;

        private List<DetailLetterEntropy> objDetailListEntropy = new List<DetailLetterEntropy>();

        public frmProbabilityScale()
        {
            InitializeComponent();
        }

        public static List<ProbabilityBussinessObjectLayer.clsSaveToFinalDB> lstShowScale { get; set; }

        private void frmProbabilityScale_Load(object sender, EventArgs e)
        {

            dgvLettersEntropy.DataSource = lstShowScale;



        }

        private void btnShowDetail_Click(object sender, EventArgs e)
        {
            objDetailListEntropy = new List<DetailLetterEntropy>();
            List<double> Probability = lstShowScale.AsEnumerable().Select(x => x.Probability).ToList();
            List<double> NotKnowingProb = lstShowScale.AsEnumerable().Select(x => x.NotKnowingProbability).ToList();
            List<double> KnowingProbability = lstShowScale.AsEnumerable().Select(x => x.KnowingProbability).ToList();
            List<double> FinalEntropia = lstShowScale.AsEnumerable().Select(x => x.FinalEntropia).ToList();

           // DetailLetterEntropy objProbability = new DetailLetterEntropy();
           // objProbability.Name = "Probability";
           // objProbability.Maximum = Math.Round(Probability.Max(), 2).ToString();
           // objProbability.Minimum = Math.Round(Probability.Min(), 2).ToString();
           //// objProbability.Average = Math.Round(Probability.Average(), 2).ToString();
           // objDetailListEntropy.Add(objProbability);

            DetailLetterEntropy objNotKnowingProb = new DetailLetterEntropy();
            objNotKnowingProb.Item = "Probabilidade do Desconhecimento";
            objNotKnowingProb.Máximo  = Math.Round(NotKnowingProb.Max(), 2).ToString();
            objNotKnowingProb.Mínimo = Math.Round(NotKnowingProb.Min(), 2).ToString();
            objNotKnowingProb.Média  = Math.Round(NotKnowingProb.Average(), 2).ToString();
            objDetailListEntropy.Add(objNotKnowingProb);

            DetailLetterEntropy objKnowingProbability = new DetailLetterEntropy();
            objKnowingProbability.Item  = "Probabilidade do Conhecimento";
            objKnowingProbability.Máximo = Math.Round(KnowingProbability.Max(), 2).ToString();
            objKnowingProbability.Mínimo = Math.Round(KnowingProbability.Min(), 2).ToString();
            objKnowingProbability.Média  = Math.Round(KnowingProbability.Average(), 2).ToString();
            objDetailListEntropy.Add(objKnowingProbability);

            DetailLetterEntropy objFinalEntropia = new DetailLetterEntropy();
            objFinalEntropia.Item = "Entropia Final";
            objFinalEntropia.Máximo = Math.Round(FinalEntropia.Max(), 2).ToString();
            objFinalEntropia.Mínimo  = Math.Round(FinalEntropia.Min(), 2).ToString();
           objFinalEntropia.Média  = Math.Round(FinalEntropia.Average(), 2).ToString();
            objDetailListEntropy.Add(objFinalEntropia);

            dgvDetailLetterEntropy.DataSource = objDetailListEntropy;


            lblAverageEntropy.Text = "Entropia Média          " + AverageEntropy.ToString();
            lblMinEntropy.Text = "Entropia Mínima:        " + MiniMumEntropy.ToString();
            lblMaxEntropy.Text = "Entropia Máxima:        " + MaxiMumEntropy.ToString();
            lblAverageProbaility.Text = "Probabilidade Média:    " + Math.Round(Probability.Average(), 2).ToString();
            lblMinProbability.Text = "Probabilidade Mínima:   " + Math.Round(Probability.Min(), 2).ToString();
            lblMaxProbability.Text = "Probabilidade Máxima:   " + Math.Round(Probability.Max(), 2).ToString();

        }

        public class DetailLetterEntropy
        {
            public  string Item { get; set; }
            public string Máximo { get; set; }
            public string Mínimo { get; set; }
           public string Média { get; set; }
        }
    }
}
