using System;
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
        public bool EnableDebug = false;
        public string FinalOutput = "", TrueFinalOutput = "";
        public int PlusCount, MinusCount, LineCount;

        private void WriteOutput(string input, bool debug = false)
        {
            //     debug = EnableDebug;
            EnableDebug = debug;

            if (!EnableDebug)
            {

                string Message = DateTime.UtcNow + " :: " + input;
                LstOutput.Items.Add(Message);
                Console.WriteLine(Message);
            }
            else
            {
                string Message = "DEBUG :: " + DateTime.UtcNow + " :: " + input;
                Console.WriteLine(Message);
            }

        }

        private void WorkThroughTXT(string TXTLocation)
        {
            WriteOutput("//////////////////////////////", true);
            WriteOutput("New Subroutine: WorkThroughTXT", true);
            WriteOutput("//////////////////////////////", true);

            int count = 0;
            string LINE;
            string stringA = "";
            string stringB = "";

            //read the file, display l-b-l
            WriteOutput("Reading file from location -> [" + TXTLocation + "]", true);
            System.IO.StreamReader file = new System.IO.StreamReader(TXTLocation);
            WriteOutput("Begin file output");
            WriteOutput("_______________________________");

            while ((LINE = file.ReadLine()) != null)
            {
                WriteOutput("Iteration: " + count, true);
                WriteOutput(LINE);
                LineCount++;
                //if count = odd
                if (!(count % 2 != 0))
                {
                    stringA = LINE;
                    WriteOutput("ODD NUMBER, STRING A = " + stringA, true);

                }
                else
                {
                    stringB = LINE;
                    WriteOutput("EVEN NUMBER, STRING B = " + stringB, true);

                    WriteOutput("Comparing stringA to stringB, removing dupes", true);
                    Compare(stringA, stringB);
                }




                count++;
            }


            WriteOutput("_______________________________");
            WriteOutput("File output finished, " + count + " lines iterated");

            WriteOutput("//////////////////////////////", true);
            WriteOutput("End Subroutine: WorkThroughTXT", true);
            WriteOutput("//////////////////////////////", true);
        }

        private void Compare(string String1ToComp, string String2ToComp)
        {
            string TruncatedA = "", TruncatedB = "";

            if (String1ToComp.StartsWith("+"))
            {
                WriteOutput("+++++++ DETECTED +++++++ [String1]", true);
                //add code to remove the + and compare here
                TruncatedA = String1ToComp.TrimStart('+');
                WriteOutput("Truncated output: " + TruncatedA, true);
                FinalOutput += TruncatedA + Environment.NewLine;




                PlusCount++;
            }
            else if (String1ToComp.StartsWith("-"))
            {
                WriteOutput("------- DETECTED ------- [String1]", true);
                //add code to remove the - and compare here
                TruncatedA = String1ToComp.TrimStart('-');
                WriteOutput("Truncated output: " + TruncatedA, true);
                FinalOutput += TruncatedA + Environment.NewLine;

                MinusCount++;
            }

            if (String2ToComp.StartsWith("+"))
            {
                WriteOutput("+++++++ DETECTED +++++++ [String2]", true);
                //add code to remove the + and compare here
                TruncatedB = String2ToComp.TrimStart('-');
                WriteOutput("Truncated output: " + TruncatedB, true);
                FinalOutput += TruncatedB + Environment.NewLine;

                PlusCount++;
            }
            else if (String2ToComp.StartsWith("-"))
            {
                WriteOutput("------- DETECTED ------- [String2]", true);
                //add code to remove the - and compare here
                TruncatedB = String2ToComp.TrimStart('-');
                WriteOutput("Truncated output: " + TruncatedB, true);
                FinalOutput += TruncatedB + Environment.NewLine;

                MinusCount++;
            }

            //Now we compare A + B, if they're the same we keep the removed +/-, else ignore it

            if (TruncatedA == TruncatedB)
            {
                WriteOutput("Found a duplicated, removing...");

                WriteOutput(TruncatedA + " & " + TruncatedB + " are the same, removing one of them...");

                TrueFinalOutput += TruncatedA + Environment.NewLine;


            }
            else
            {
                TrueFinalOutput += TruncatedA + Environment.NewLine;
            }

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            WriteOutput("Program loaded successfully...");
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
                    WriteOutput("File Selected");
                    WriteOutput("Setting file location to -> [" + BrowseDialog.FileName + "]", true);
                    FileLoc = BrowseDialog.FileName;
                    TxtFileLoc.Text = FileLoc;
                    WriteOutput("FileLoc set to -> [" + FileLoc + "]", true);
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
            WriteOutput("Setting File Location to textbox location -> [" + TxtFileLoc.Text + "]", true);
            FileLoc = TxtFileLoc.Text;
            WriteOutput("Attempting to work through the text file line by line...");
            WorkThroughTXT(TxtFileLoc.Text);
            WriteOutput("/////// FINAL OUTPUT ///////", true);
            WriteOutput(FinalOutput, true);
            WriteOutput("/////// FINAL OUTPUT ///////", true);

            WriteOutput("/////// TFINAL OUTPUT ///////", true);
            WriteOutput(TrueFinalOutput, true);
            WriteOutput("/////// TFINAL OUTPUT ///////", true);

            WriteStatistics();

            WriteOutput("Done.");
        }

        private void WriteStatistics()
        {
            WriteOutput("Program Stastics: |           |");
            WriteOutput("Count of Plus :   | " + PlusCount);
            WriteOutput("Count of Minus:   | " + MinusCount);
            WriteOutput("Lines Iterated:   | " + LineCount);


        }
    }
}
