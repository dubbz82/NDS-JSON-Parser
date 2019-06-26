using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Json;
using System.Net;
using System.Windows.Forms;

namespace NDS_JSON_Parser
{
    public partial class Form1 : Form
    {
        public string fullJSON = "";
        public JsonValue full;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //get full JSON to allow searching by title...
            WebClient client = new WebClient();
            fullJSON = client.DownloadString("http://nds-library-api.glitch.me/");
            full = JsonValue.Parse(fullJSON);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //reset some stuff in case the form is being re-used for multiple searches...
            lblSDCardCompatibility.Text = "";
            lblSlot1Compatibility.Text = "";
            lbl3dsCompatibility.Text = "";
            lblDSiCompatibility.Text = "";
            lblCompatibility.Text = "";
            lblAdditionalNotes.Text = "";
            chk3DS.Checked = false;
            chkDSi.Checked = false;
            chkFileLocationSD.Checked = false;
            chkFileLocationSlot1.Checked = false;

            dgvSDCardTesters.DataSource = null;
            dgvAlieses.DataSource = null;
            pnlGameInfo.Hide();
            string gameID = txtGameID.Text.ToUpper();
            if (gameID != "")
            {
                WebClient client = new WebClient();
                try
                {
                    string jsonstring = client.DownloadString("http://nds-library-api.glitch.me/" + gameID);
                    JsonValue json = JsonValue.Parse(jsonstring);
                    lblTitle.Text = json["title"];
                    lblSDKVersion.Text = json["SDK"];
                    lblRegion.Text = json["region"];
                    lblCardType.Text = json["card-type"];
                    if (json["Anti-Piracy"] == true)
                    {
                        lblAntiPiracy.Text = "Yes";
                        lblAntiPiracy.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblAntiPiracy.Text = "No";
                        lblAntiPiracy.ForeColor = Color.Empty;
                    }

                    if (json.ContainsKey("aliases"))
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Alias");
                        foreach (JsonValue alias in json["aliases"])
                        {
                            dt.Rows.Add(alias.ToString().Substring(1, alias.ToString().Length -2));
                        }

                        dgvAlieses.AllowUserToResizeColumns = true;
                        dgvAlieses.DataSource = dt;
                        dgvAlieses.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                        foreach (DataGridViewColumn c in dgvAlieses.Columns)
                        {
                            c.Width = dgvAlieses.Width;
                        }  
                        dgvAlieses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                    }
                    if (json.ContainsKey("nds-bootstrap"))
                    {
                        JsonValue ndsbootstrap = json["nds-bootstrap"];
                        //iterate through both the sd-card and flashcard child elements to pull properties frome ach of them
                        if (ndsbootstrap.ContainsKey("flashcard"))
                        {

                        }
                        if (ndsbootstrap.ContainsKey("sd-card"))
                        {
                            JsonValue sdcard = ndsbootstrap["sd-card"];
                            lblVersion.Text = sdcard["version"];
                            if (sdcard.ContainsKey("file-location"))
                            {
                                JsonValue filelocation = sdcard["file-location"];
                                if (filelocation["sd"] != null)
                                {
                                    if (filelocation["sd"] == true)
                                    {
                                        chkFileLocationSD.Checked = true;
                                    }
                                    else
                                    {
                                        chkFileLocationSD.Checked = false;
                                    }
                                }
                                else
                                {
                                    lblSDCardCompatibility.Text = "No Info Available for SD card";
                                    lblSDCardCompatibility.ForeColor = Color.Red;
                                }
                                
                                if (filelocation["slot-1"] != null)
                                {
                                    if (filelocation["slot-1"] == true)
                                    {
                                        chkFileLocationSlot1.Checked = true;
                                    }
                                    else
                                    {
                                        chkFileLocationSlot1.Checked = false;
                                    }
                                }
                                else
                                {
                                    lblSlot1Compatibility.Text = "No Info Available for Slot-1";
                                    lblSlot1Compatibility.ForeColor = Color.Red;
                                }

                                //make display not look like crap if nothing available for either SD card or Slot-1
                                if (lblSDCardCompatibility.Text != "" && lblSlot1Compatibility.Text != "")
                                {
                                    lblSlot1Compatibility.Text = "";
                                    lblSDCardCompatibility.Text = "No Info Available for SD Card or Slot-1";
                                }
   
                            }

                            if (sdcard["clock-speed"] != null)
                            {
                                lblClockSpeed.Text = sdcard["clock-speed"];
                            }
                            else
                            {
                                lblClockSpeed.Text = "No Data Reported";
                            }

                            if (sdcard.ContainsKey("console"))
                            {
                                JsonValue console = sdcard["console"];
                                if (console["3DS"] != null)
                                {
                                    if (console["3DS"] == true)
                                    {
                                        chk3DS.Checked = true;
                                    }
                                    else
                                    {
                                        chk3DS.Checked = false;
                                    }
                                }
                                else
                                {
                                    lbl3dsCompatibility.Text = "No Info Available for 3DS";
                                    lbl3dsCompatibility.ForeColor = Color.Red;
                                }
                                if (console["DSi"] != null)
                                {
                                    if (console["DSi"] == true)
                                    {
                                        chkDSi.Checked = true;
                                    }
                                    else
                                    {
                                        chkDSi.Checked = false;
                                    }
                                }
                                else
                                {
                                    lblDSiCompatibility.Text = "No Info Available for DSi";
                                    lblDSiCompatibility.ForeColor = Color.Red;
                                }

                                //make the display not look like crap if both dsi and 3ds are unavailable...
                                if (lblDSiCompatibility.Text != "" && lbl3dsCompatibility.Text != "")
                                {
                                    lblDSiCompatibility.Text = "";
                                    lbl3dsCompatibility.Text = "No Info Available for 3DS or DSi";
                                }
                            }

                            if (sdcard["compatibility"] != null)
                            {
                                lblCompatibility.Text = sdcard["compatibility"];
                            }
                            else
                            {
                                lblCompatibility.Text = "No Compatibility Notes Found";
                            }

                            if (sdcard.ContainsKey("notes"))
                            {
                                lblAdditionalNotes.Text = sdcard["notes"];
                            }
                            if (sdcard["testers"] != null)
                            {
                                DataTable dt2 = new DataTable();
                                dt2.Columns.Add("Tester");
                                foreach (JsonValue v in sdcard["testers"])
                                {
                                    dt2.Rows.Add(v.ToString().Substring(1, v.ToString().Length - 2));
                                }
                                dgvSDCardTesters.DataSource = dt2;
                                dgvSDCardTesters.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                                foreach (DataGridViewColumn c in dgvSDCardTesters.Columns)
                                {
                                    c.Width = dgvSDCardTesters.Width;
                                }
                                dgvSDCardTesters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                            }
                            else
                            {

                            }

                        }

                    }


                    if (lblAntiPiracy.Text == "Yes")
                    {
                        //smack the user in the face with a message if there's known AP for the rom.
                        MessageBox.Show("Anti-Piracy checks are known to exist for this game, please use NDS Scene tool or a similar program to patch the rom if it is to be used with NDS Bootstrap!");
                    }
                    //everything's good so far, show the panel...
                    pnlGameInfo.Show();
                    //try and populate the coverart if we can..
                    getCoverart(gameID);
                    
                }
                catch (Exception ex)
                {

                    if (ex.ToString().Contains("(404)"))
                    {
                        MessageBox.Show("Game ID not Found!");
                    }
                    else
                    {
                        MessageBox.Show("Error Occurred: " + ex.ToString());
                    }
                    
                }
                
            }
            else
            {
                MessageBox.Show("Please Enter a Game ID!");
            }
            
        }


        private bool DownloadCoverArt(string gameID, string CountryCode)
        {
            try
            {
                using (WebClient myWebClient = new WebClient())
                {
                    string myStringWebResource = "https://art.gametdb.com/ds/coverS/" + CountryCode + "/" + gameID + ".png";
                    // Download the Web resource and save it into the current filesystem folder.
                    System.IO.Directory.CreateDirectory("Coverart");
                    myWebClient.DownloadFile(myStringWebResource, "Coverart/" + gameID + ".png");
                }
                return true;
            }
            
            catch (Exception e)
            {
                return false;
            }
        }
        private void getCoverart(string gameID)
        {
            //try and grab coverart locally first, if that fails grab it from https://art.gametdb.com/ds/coverS/%s/%s.png
            try
            {
                pboxArtwork.Image = Image.FromFile("Coverart/" + gameID + ".png");
                
            }
            catch (Exception e)
            {
                //no coverart exists, try and pull it from gametdb..
                bool coverartdownload = false; //track if coverart is successfully downloaded..
                coverartdownload = DownloadCoverArt(gameID, "US");
                if (coverartdownload == false)
                {
                    //fall through to next..there's probably much better ways of doing this...
                    coverartdownload = DownloadCoverArt(gameID, "FR");
                    if (coverartdownload == false)
                    {
                        coverartdownload = DownloadCoverArt(gameID, "DE");
                        if (coverartdownload == false)
                        {
                            coverartdownload = DownloadCoverArt(gameID, "IT");
                            if (coverartdownload == false)
                            {
                                coverartdownload = DownloadCoverArt(gameID, "ES");
                                if (coverartdownload == false)
                                {
                                    coverartdownload = DownloadCoverArt(gameID, "ZHCN");
                                    if (coverartdownload == false)
                                    {
                                        coverartdownload = DownloadCoverArt(gameID, "KO");
                                        if (coverartdownload == false)
                                        {
                                            coverartdownload = DownloadCoverArt(gameID, "JA");
                                            if (coverartdownload == false)
                                            {
                                                coverartdownload = DownloadCoverArt(gameID, "NL");
                                                if (coverartdownload == false)
                                                {
                                                    coverartdownload = DownloadCoverArt(gameID, "RU");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                if (coverartdownload == true)
                {
                    pboxArtwork.Image = new Bitmap("Coverart/" + gameID + ".png");
                }
                

            }
        }
        private void openRomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Nintendo DS Roms(*.nds)|*.nds";
            d.Multiselect = false;
            DialogResult r = d.ShowDialog();
            if (r == DialogResult.OK)
            {
                try
                {
                    string fpath = d.FileName;
                    string gameID = "";
                    using (System.IO.BinaryReader b = new System.IO.BinaryReader(System.IO.File.Open(fpath, System.IO.FileMode.Open)))
                    {

                        byte[] tmp = b.ReadBytes(16);
                        byte[] tmp2 = new byte[4];
                        tmp2[0] = tmp[12];
                        tmp2[1] = tmp[13];
                        tmp2[2] = tmp[14];
                        tmp2[3] = tmp[15];
                        gameID = System.Text.Encoding.UTF8.GetString(tmp2);
                        txtGameID.Text = gameID;
                        btnSearch.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Could not successfully retrieve game ID!");
                }
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
            
        {
            pnlGameInfo.Visible = false;
            DataTable searchResults = new DataTable();
            searchResults.Columns.Add("Title");
            searchResults.Columns.Add("CardID");
            searchResults.Columns.Add("Region");

            foreach (KeyValuePair<string, JsonValue> value in full)
            {
                JsonValue v = full[value.Key];
                if (v["title"].ToString().ToUpper().Contains(textBox1.Text.ToUpper()))
                {
                    searchResults.Rows.Add(v["title"].ToString().Substring(1, v["title"].ToString().Length - 2), value.Key, v["region"].ToString().Substring(1, v["region"].ToString().Length - 2));
                }
            }


          
            dgvSearchResults.DataSource = searchResults;
            dgvSearchResults.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvSearchResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            string text = dgvSearchResults.Rows[row].Cells[1].Value.ToString();
            txtGameID.Text = text;
            btnSearch.PerformClick();
        }
    }
}
