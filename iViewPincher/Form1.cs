using System.Net;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;

namespace iViewPincher {
    public partial class Form1 :Form {
        public Form1() {
            InitializeComponent();
        }

        public List<Episode> GetData()
        {
            List<Episode> output = new List<Episode>();
            string[] endpoints = new string[] { "ABC1", "ABC2", "ABC3", "ABC4KIDS", "NEWS", "ABCARTS", "ARTS", "IVIEW", "DOCS", "COMEDY", "LIFESTYLE", "DRAMA", "EDUCATION", "PANEL", "SPORT" };
            using (WebClient wc = new WebClient())
            {
                for (var i = 0; i < endpoints.Length; i++)
                {
                    label1.Text = string.Format("Loading {0}...", endpoints[i]);
                    var text = wc.DownloadString("http://iview.abc.net.au/api/channel/" + endpoints[i]);
                    Channel response = JsonConvert.DeserializeObject<Channel>(text);
                    foreach (IndexObject index in response.Index)
                    {
                        foreach (Episode episode in index.Episodes)
                        {
                            if (output.Any(item => item.EpisodeHouseNumber == episode.EpisodeHouseNumber)) continue;
                            episode.PrettyTitle = episode.SeriesTitle;
                            if (episode.Title != null)
                            {
                                episode.PrettyTitle = episode.PrettyTitle + " " + episode.Title;
                            }
                            label1.Text = string.Format("[{0}] Processing {1}...", endpoints[i], episode.PrettyTitle);
                            output.Add(episode);
                        }
                    }
                }
            }
            output.Sort((ep1, ep2) => ep1.PrettyTitle.CompareTo(ep2.PrettyTitle));
            return output;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            List<Episode> data = GetData();
            foreach (Episode episode in data)
            {
                listBox1.Items.Add(episode.PrettyTitle);
            }
        }
    }
}
