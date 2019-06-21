using System;
using System.Data;
using System.Drawing;
using System.Json;
using System.Net;
using System.Windows.Forms;

namespace NDS_JSON_Parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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
                    
                }
                catch
                {
                    if (e.ToString() == "System.Windows.Forms.MouseEventArgs")
                    {
                        MessageBox.Show("Game ID not Found!");
                    }
                    else
                    {
                        MessageBox.Show("Error Occurred: " + e.ToString());
                    }
                    
                }
                
            }
            else
            {
                MessageBox.Show("Please Enter a Game ID!");
            }
            
        }
    }
}
