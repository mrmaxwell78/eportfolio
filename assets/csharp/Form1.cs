using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //include for file reading/writing

namespace CDApplication
{
    public partial class Form1 : Form
    { //declare an instance of a list for adding to the text file
        cd myCD = new cd();

        //create a list of cds
        List<cd> myCDList = new List<cd>();

        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //create the text file for appending - if the file already exists, this will 
            //append the data and if it does not yet exist, this will create the file and 
            //write the data.
            FileStream outfile = new FileStream("cds.csv", FileMode.Append);

            //create an instance of a StreamWriter object to write the data
            StreamWriter binWriter = new StreamWriter(outfile);

            //store the user's data that they entered in the text boxes into my cd
            myCD.Artist = txtArtist.Text;
            myCD.Genre = txtGenre.Text;
            myCD.Title = txtTitle.Text;
            myCD.ReleaseDate = Convert.ToInt32(txtDate.Text);

            //write the data to the file
            binWriter.WriteLine(myCD.Title + "," + myCD.Artist + "," + myCD.Genre + "," + myCD.ReleaseDate);

            //close file
            binWriter.Close();

            //close FileStream
            outfile.Close();

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //read in data from cds.txt and store into myCDList

            //temp cd
            cd tempCD = new cd();

            //counter
            int counter = 0;
            //clear out list
            myCDList.Clear();
            try
            {
                //create an instance of a FileStream for reading
                FileStream infile = new FileStream("cds.csv", FileMode.Open);

                //create an instance of a StreamReader
                StreamReader myreader = new StreamReader(infile);

                //declare a temp string
                string line;

                //read in a line from the file
                //priming read
                line = myreader.ReadLine();

                string[] fields = new string[4];
                char[] sep = new char[1];

                sep[0] = ',';

                while(line != null)
                {
                    tempCD = new cd();

                    fields = line.Split(sep);

                    tempCD.Title = fields[0];
                    tempCD.Artist = fields[1];
                    tempCD.Genre = fields[2];
                    tempCD.ReleaseDate = Convert.ToInt32(fields[3]);

                    //add tempCD to myCDList
                    myCDList.Add(tempCD);

                    //add to counter
                    counter++;

                    //read in next line
                    line = myreader.ReadLine();
                }
                //close filestream and filereader
                infile.Close();
                myreader.Close();
                
            }

            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found!\n");
            }

            //for loop to display all cd titles in the lstCDs (listbox)
            lstCDs.Items.Clear();
            foreach(cd tempcd in myCDList)
            {
                //add to lstCDs on front end
                lstCDs.Items.Add(tempcd.Title);
            }

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            StreamReader infile = new StreamReader(openFileDialog1.FileName);

            MessageBox.Show(openFileDialog1.FileName);

            infile.Close();
        }

        private void addToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create the text file for appending - if the file already exists, this will 
            //append the data and if it does not yet exist, this will create the file and 
            //write the data.
            FileStream outfile = new FileStream("cds.txt", FileMode.Append);

            //create an instance of a StreamWriter object to write the data
            StreamWriter binWriter = new StreamWriter(outfile);

            //store the user's data that they entered in the text boxes into my cd
            myCD.Artist = txtArtist.Text;
            myCD.Genre = txtGenre.Text;
            myCD.Title = txtTitle.Text;
            myCD.ReleaseDate = Convert.ToInt32(txtDate.Text);

            //write the data to the file
            binWriter.WriteLine(myCD.Title + "," + myCD.Artist + "," + myCD.Genre + "," + myCD.ReleaseDate);

            //close file
            binWriter.Close();

            //close FileStream
            outfile.Close();
        }
    }
}
