using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVS_Toolkit
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        public string FileLoc = "";
        public bool EnableDebug;

        private void WriteOutput(string input, bool debug = false)
        {
            debug = EnableDebug;

            if (!debug)
            {
                string Message = DateTime.UtcNow + " :: " + input;
                LstOutput.Items.Add(Message);
                Console.WriteLine(Message);
            }
            else
            {
                string Message = "DEBUG :: " + DateTime.UtcNow + " :: " + input;
                LstOutput.Items.Add(Message);
                Console.WriteLine(Message);
            }

        }

        private void WorkThroughTXT(string TXTLocation)
        {
            WriteOutput("//////////////////////////////");
            WriteOutput("New Subroutine: WorkThroughTXT");
            WriteOutput("//////////////////////////////");

            int count = 0;
            string LINE, stringA, stringB;

            //read the file, display l-b-l
            WriteOutput("Reading file from location -> [" + TXTLocation + "]");
            System.IO.StreamReader file = new System.IO.StreamReader(TXTLocation);

            while ((LINE = file.ReadLine()) != null)
            {
                WriteOutput("Iteration: " + count);
                WriteOutput(LINE);
                count++;
            }

            WriteOutput("//////////////////////////////");
            WriteOutput("End Subroutine: WorkThroughTXT");
            WriteOutput("//////////////////////////////");
        }

        private bool Compare(string string1, string string2)
        {



            return false;

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            WriteOutput("Form loaded successfully...");
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            //Show Dialog and continue on if ok is clicked
            WriteOutput("Showing browse dialog...");
            if (BrowseDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //set file loc to selected file
                    WriteOutput("Setting file location to -> [" + BrowseDialog.FileName + "]");
                    FileLoc = BrowseDialog.FileName;
                    TxtFileLoc.Text = FileLoc;
                    WriteOutput("FileLoc set to -> [" + FileLoc + "]");
                }
                catch (Exception err)
                {
                    //Write the error msg to output 
                    WriteOutput(err.Message);
                }
            }
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            WriteOutput("Setting File Location to textbox location -> [" + TxtFileLoc.Text + "]");
            FileLoc = TxtFileLoc.Text;
            WriteOutput("Attempting to work through the text file line by line...");
            WorkThroughTXT(TxtFileLoc.Text);
        }
    }
}
