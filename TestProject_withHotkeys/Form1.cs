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
            ghk = new Hotkeys.GlobalHotkey(Constants.SHIFT, Keys.F1, this);
            Debug.WriteLine("I am here in the form init");
        }
 
        private void HandleHotkey()
        {
            WriteLine("Hotkey pressed!");
        }
 
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Hotkeys.Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("I am here in the form load function");

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
            // Create a new WebClient instance.
            string remoteUri = "http://smartsign.imtc.gatech.edu/videos?keywords=";
            remoteUri = remoteUri + textBox2.Text;
            WebClient myWebClient = new WebClient();
            // Download home page data.
            Debug.WriteLine("Downloading " + remoteUri);
            // Download the Web resource and save it into a data buffer. 
            byte[] myDataBuffer = myWebClient.DownloadData(remoteUri);

            // Display the downloaded data. 
            string download = Encoding.ASCII.GetString(myDataBuffer);
            Debug.WriteLine(download);

            // Process the resulting XML
            string youTubeID = Regex.Match(download, @"^\[\s*{\s*""id"":\s*""(\w*)"",.*").Groups[1].Value;
            string youTubeBase = "http://www.youtube.com/v/";
            axShockwaveFlash1.Movie = youTubeBase + youTubeID;
        }

        private void CheckforEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                GetResults();
            }             
        }

    }
}

