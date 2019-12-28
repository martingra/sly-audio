using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoundFingerprinting;
using SoundFingerprinting.Audio;
using SoundFingerprinting.Builder;
using SoundFingerprinting.DAO.Data;
using SoundFingerprinting.Data;
using SoundFingerprinting.InMemory;

namespace SoundTest
{
    public partial class frmCheckPattern : Form
    {

        private readonly IModelService modelService = new InMemoryModelService(); // store fingerprints in RAM
        private readonly IAudioService audioService = new SoundFingerprintingAudioService(); // default audio library

        public frmCheckPattern()
        {
            InitializeComponent();
            
        }

        public async Task StoreForLaterRetrievalAsync(string pathToAudioFile)
        {
            var track = new TrackInfo("GBBKS1200164", "Skyfall", "Adele", 290d);


            // create fingerprints
            var hashedFingerprints = await FingerprintCommandBuilder.Instance
                                        .BuildFingerprintCommand()
                                        .From(pathToAudioFile)
                                        .UsingServices(audioService)
                                        .Hash();

            // store hashes in the database for later retrieval
            modelService.Insert(track, hashedFingerprints);

        }



        public async void GetBestMatchForSong(string queryAudioFile)
        {
            int secondsToAnalyze = Int32.Parse(this.txtDuracion.Text); // number of seconds to analyze from query file
            Double startAtSecond = 0; // start at the begining
            int matchesCount = 0;
           
            while (true)
            {
                var queryResult = await QueryCommandBuilder.Instance.BuildQueryCommand()
                                                 .From(queryAudioFile, secondsToAnalyze, startAtSecond)
                                                 .UsingServices(modelService, audioService)
                                                 .Query();

                

                if (queryResult.ContainsMatches)
                {
                    matchesCount++;
                    startAtSecond += queryResult.BestMatch.QueryMatchStartsAt + queryResult.BestMatch.QueryMatchLength;
                }
                else
                {
                    txtCantidadOcurrencias.Text = matchesCount.ToString();
                    return;
                }
            }
        }

        public async Task<TrackData> GetMatch(string queryAudioFile)
        {


            int secondsToAnalyze = Int32.Parse(this.txtDuracion.Text); // number of seconds to analyze from query file
            int startAtSecond = Int32.Parse(this.txtDesde.Text); // start at the begining

            // query the underlying database for similar audio sub-fingerprints
            var queryResult = await QueryCommandBuilder.Instance.BuildQueryCommand()
                                                 .From(queryAudioFile, secondsToAnalyze, startAtSecond)
                                                 .UsingServices(modelService, audioService)
                                                 .Query();

            if (queryResult.ContainsMatches)
            {
                txtCantidadOcurrencias.Text = Math.Round(1 / queryResult.BestMatch.Confidence, 0).ToString();

                txtCoverage.Text = queryResult.BestMatch.Coverage.ToString();
                txtConfidence.Text = queryResult.BestMatch.Confidence.ToString();
                txtEstimatedCoverage.Text = queryResult.BestMatch.EstimatedCoverage.ToString();
                txtMatchStartsAt.Text = queryResult.BestMatch.QueryMatchStartsAt.ToString();
                txtMatchLength.Text = queryResult.BestMatch.QueryMatchLength.ToString();
                return queryResult.BestMatch.Track;

            }
            else
            {
                txtCantidadOcurrencias.Text = "0";
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetBestMatchForSong(txtContenedor.Text);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            StoreForLaterRetrievalAsync(txtPatron.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GetMatch(txtContenedor.Text);
        }
    }
}
