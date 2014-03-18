using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotkeys;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;


namespace TestProject_withHotkeys
{
    public partial class Form1 : Form
    {
        private Hotkeys.GlobalHotkey ghk;

        public Form1()
        {
            InitializeComponent();
            InitializeFlash();
            ghk = new Hotkeys.GlobalHotkey(Constants.SHIFT, Keys.F1, this);
            createSearchTextFile();
            LogLocation.Text = path;
        }

        public void InitializeFlash()
        {
            this.sidePicList = new PictureBox[10]{ pictureBox1, pictureBox2, pictureBox3, pictureBox4,
               pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10 };
            this.sideLabelList = new Label[10]{ label1, label2, label3, label4, label5, label6,
                label7, label8, label9, label10 };
        }
 
        private void HandleHotkey()
        {
            WriteLine("Hotkey pressed!");
            // save old clipboard
            IDataObject oldClipboardData = Clipboard.GetDataObject();
            // send copy command to grab highlighted data
            SendKeys.Send("^(C)");
            string copiedClipboardText = Clipboard.GetText();
            Debug.WriteLine(copiedClipboardText);
            searchBox.Text = copiedClipboardText;
            GetResults();

            // return data to clipboard
            Clipboard.SetDataObject(oldClipboardData);

        }
 
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Hotkeys.Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
            WriteLine("Trying to register SHIFT+F1");
            if (ghk.Register())
                WriteLine("Hotkey registered.");
            else
                WriteLine("Hotkey failed to register");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ghk.Unregiser())
                MessageBox.Show("Hotkey failed to unregister!");
        }

        private void WriteLine(string text)
        {
            textBox1.Text += text + Environment.NewLine;
        }

        // This function grabs the text in the search textbox and searches the database for the video and displays the video
        private void GetResults()
        {
            writeSearchToFile(searchBox.Text);
            // Create a new WebClient instance.
            string remoteUri = "http://smartsign.imtc.gatech.edu/videos?keywords=";
            
            //TODO capture multiple words and return multiple videos
            string[] queryKeywords = searchBox.Text.Split(' ');
            string completeUri;
            WebClient myWebClient = new WebClient();
            string youTubeBase = "http://www.youtube.com/v/";
            int count = 0;                              // in order to know if it is the first video
            string cleanWord;

            foreach (string word in queryKeywords)
            {
                cleanWord = Regex.Replace( word, @"\s+", string.Empty );
              
                completeUri = remoteUri + cleanWord;

                // Download the Web resource and save it into a data buffer. 
                byte[] myDataBuffer = myWebClient.DownloadData(completeUri);

                // Display the downloaded data. 
                string download = Encoding.ASCII.GetString(myDataBuffer);

                // Process the resulting XML
                string youTubeID = Regex.Match(download, @"^\[\s*{\s*""id"":\s*""(\w*)"",.*").Groups[1].Value;
                string thumbnailLink = Regex.Match(download, @"""thumbnail"":\s*""(.*)"",").Groups[1].Value;
                string title = Regex.Match(download, @"""title"":\s*""(.*)""").Groups[1].Value;

                if( count < 10 & !String.IsNullOrEmpty(youTubeID) )
                {
                    if (count == 0)
                    {
                        mainFlash.Movie = youTubeBase + youTubeID;
                    }
                    sidePicList[count].Visible = true;
                    sidePicList[count].ImageLocation = thumbnailLink;
                    sidePicList[count].Text = youTubeBase + youTubeID;
                    sideLabelList[count].Text = title;
                    sideLabelList[count].Enabled = true;
                    count++;
                }

            }
            while (count < 10)
            {
                sidePicList[count].Visible = false;
                sideLabelList[count].Enabled = false;
                sideLabelList[count].Text = "";
                count++;
            }
        }

        private void ClearTextBox(TextBox textBox)
        {
            textBox.Clear();
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckforEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                GetResults();
                ClearTextBox(searchBox);
            }   
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // When a sidePicture is clicked the video loads into the main frame
        private void loadSideVideo(object sender, MouseEventArgs e)
        {
            PictureBox sidePicture = (PictureBox)sender;
            mainFlash.LoadMovie(0, (string)sidePicture.Text);
        }

        private void createSearchTextFile()
        {
            // path is a global variable
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path = path + @"\SMARTSign-Assistant_Search_Log.txt";
        
            // Create or open file to write to. 
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(path, true)) 
            {
                sw.WriteLine("SMARTSign-Assistant Started");
                sw.WriteLine("Date: "+ DateTime.Now );
                sw.WriteLine("------------------------------------------------------------------------");
                sw.WriteLine();
            }
        }
        private void writeSearchToFile(string text)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
                file.WriteLine( DateTime.Now + ":  " + text.Trim());
        }

        private void openLogFile(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", path);
        }

        private void clearText(object sender, MouseEventArgs e)
        {
            searchBox.Text = "";
        }

        private void changePointertoHand(object sender, EventArgs e)
        {
            Control currentPictureBox = (Control)sender;
            if( currentPictureBox.Enabled )
                currentPictureBox.Cursor = Cursors.Hand;
        }

        private void changeHandtoPointer(object sender, EventArgs e)
        {
            Control currentPictureBox = (Control)sender;
            if( currentPictureBox.Enabled )
                currentPictureBox.Cursor = Cursors.Default;
        }
    }
}

