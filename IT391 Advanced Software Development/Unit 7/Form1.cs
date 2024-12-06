using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace IT391_Crooks_Unit7
{
    //Start the form code (this apparently has to be the first class in the program):
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Initialize the form, update the form title, and display the grade statistics.
            InitializeComponent();
            this.Text = "Student Grades Readout";
            displayStats();
        }

        //When the exit button is clicked, shut down the program.
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Start the display statistics code; the front-end meat of the program.
        public void displayStats()
        {
            //Initialize three character variables, and set them to G so that if they don't get updated, we know there's a problem.
            char avgGradeLetter = 'G';
            char maxGradeLetter = 'G';
            char minGradeLetter = 'G';
            //Create a new object to parse through student grades XML data.
            StudentGrades sg = new StudentGrades("https://zadar.us/pug/it-391/source-code/StudentGrades.xml");

            //Start a switch statement looking at the tens place of the grade populated in Average Grades
            switch (sg.AvgGrade / 10)
            {
                //If it's 100%, set the grade to A and the background colour to green.
                case 10:
                    txtMeanGrd.BackColor = Color.PaleGreen;
                    avgGradeLetter = 'A';
                    break;
                //If it's 90%, set the grade to A and the background colour to green.
                case 9:
                    txtMeanGrd.BackColor = Color.PaleGreen;
                    avgGradeLetter = 'A';
                    break;
                //If it's 80%, set the grade to B and the background colour to blue.
                case 8:
                    txtMeanGrd.BackColor = Color.PaleTurquoise;
                    avgGradeLetter = 'B';
                    break;
                //If it's 70%, set the grade to C and the background colour to yellow.
                case 7:
                    txtMeanGrd.BackColor = Color.LemonChiffon;
                    avgGradeLetter = 'C';
                    break;
                //If it's 60%, set the grade to D and the background colour to orange.
                case 6:
                    txtMeanGrd.BackColor = Color.LightSalmon;
                    avgGradeLetter = 'D';
                    break;
                //If it's below 60%, set the grade to F and the background colour to red.
                default:
                    txtMeanGrd.BackColor = Color.Pink;
                    avgGradeLetter = 'F';
                    break;
            }

            switch (sg.MaxGrade / 10)
            {
                //If it's 100%, set the grade to A and the background colour to green.
                case 10:
                    txtMaxGrd.BackColor = Color.PaleGreen;
                    maxGradeLetter = 'A';
                    break;
                //If it's 90%, set the grade to A and the background colour to green.
                case 9:
                    txtMaxGrd.BackColor = Color.PaleGreen;
                    maxGradeLetter = 'A';
                    break;
                //If it's 80%, set the grade to B and the background colour to blue.
                case 8:
                    txtMaxGrd.BackColor = Color.PaleTurquoise;
                    maxGradeLetter = 'B';
                    break;
                //If it's 70%, set the grade to C and the background colour to yellow.
                case 7:
                    txtMaxGrd.BackColor = Color.LemonChiffon;
                    maxGradeLetter = 'C';
                    break;
                //If it's 60%, set the grade to D and the background colour to orange.
                case 6:
                    txtMaxGrd.BackColor = Color.LightSalmon;
                    maxGradeLetter = 'D';
                    break;
                //If it's below 60%, set the grade to F and the background colour to red.
                default:
                    txtMaxGrd.BackColor = Color.Pink;
                    maxGradeLetter = 'F';
                    break;
            }

            switch (sg.MinGrade / 10)
            {
                //If it's 100%, set the grade to A and the background colour to green.
                case 10:
                    txtMinGrd.BackColor = Color.PaleGreen;
                    minGradeLetter = 'A';
                    break;
                //If it's 90%, set the grade to A and the background colour to green.
                case 9:
                    txtMinGrd.BackColor = Color.PaleGreen;
                    minGradeLetter = 'A';
                    break;
                //If it's 80%, set the grade to B and the background colour to blue.
                case 8:
                    txtMinGrd.BackColor = Color.PaleTurquoise;
                    minGradeLetter = 'B';
                    break;
                //If it's 70%, set the grade to C and the background colour to yellow.
                case 7:
                    txtMinGrd.BackColor = Color.LemonChiffon;
                    minGradeLetter = 'C';
                    break;
                //If it's 60%, set the grade to D and the background colour to orange.
                case 6:
                    txtMinGrd.BackColor = Color.LightSalmon;
                    minGradeLetter = 'D';
                    break;
                //If it's below 60%, set the grade to F and the background colour to red.
                default:
                    txtMinGrd.BackColor = Color.Pink;
                    minGradeLetter = 'F';
                    break;
            }

            //Set the label texts to be their associated values using XML calculations.
            //These labels are already set to Read Only in the Form Designer, so setting
            //them in C# is not necessary.
            txtMeanGrd.Text = (sg.AvgGrade.ToString() + "% (" + avgGradeLetter + ")");
            txtMaxGrd.Text = (sg.MaxGrade.ToString() + "% (" + maxGradeLetter + ")");
            txtMinGrd.Text = (sg.MinGrade.ToString() + "% (" + minGradeLetter + ")");
        }
    }
    //Start the back-end code:
    public class StudentGrades
    {
        //Initialize an ArrayList, and three ints to keep track of grade data.
        private ArrayList GradeList;
        public int MaxGrade = 0;
        public int MinGrade = 0;
        public int AvgGrade = 0;

        //Start a public method to create a new GradeList arraylist.
        public StudentGrades()
        {
            GradeList = new ArrayList();
        }

        //Start a public method to set the Average, Maximum, and Minimum grades using calculation methods from our XML data.
        public StudentGrades (string gradefileName)
        {
            GradeList = new ArrayList();
            REadGradeDataFromXML(gradefileName);
            AvgGrade = CalculateAverage();
            MaxGrade = CalculateMax();
            MinGrade = CalculateMin();
        }

        //Create a method to add a grade to the gradeList arraylist.
        private void addGrade (int grade)
        {
            GradeList.Add(grade);
        }

        //Create a method to calculate the minimum grade by sorting the list, and choosing the lowest result.
        private int CalculateMin()
        {
            GradeList.Sort();
            return (int)GradeList[0];
        }

        //Create a method to calculate the minimum grade by sorting the list, and choosing the highest result.
        private int CalculateMax()
        {
            GradeList.Sort();
            return (int)GradeList[GradeList.Count - 1];
        }

        //Create a method to calculate the average grade.
        private int CalculateAverage()
        {
            //Set an int to keep track of the sum.
            int sum = 0;
            //for each grade in grades,
            foreach (int grade in GradeList)
            {
                //Add the current grade to the total sum.
                sum += grade;
            }
            //Return the sum of the grades, divided by the total grade count.
            return (sum / (GradeList.Count));
        }
        //Create a private method to read data from the XML document. 
        private void REadGradeDataFromXML(string gradefileName)
        {
            //Create a new XML reader object to use for the grade list.
            XmlTextReader reader = new XmlTextReader(gradefileName);
            //While we are still reading the document,
            while (reader.Read())
            {
                //start a switch statement based on the type of node we hit,
                switch (reader.NodeType)
                {
                    //If it's an element that is not the end,
                    case XmlNodeType.Element:
                        //Write debug elements to keep track of the reader's progress, and break the switch.
                        System.Diagnostics.Debug.Write("<" + reader.Name);
                        System.Diagnostics.Debug.Write(">");
                        break;
                    //If it is a grade,
                    case XmlNodeType.Text:
                        //Write to debug to keep track of the reader's progress.
                        System.Diagnostics.Debug.Write(reader.Value);
                        //Convert the grade from the string into an int,
                        int val = Convert.ToInt32(reader.Value);
                        //And add it to the grade list.
                        addGrade(val);
                        //break the switch.
                        break;
                    //If it's an end element,
                    case XmlNodeType.EndElement:
                        //Write debug elements to keep track of the reader's progress,
                        System.Diagnostics.Debug.Write("</" + reader.Name);
                        System.Diagnostics.Debug.WriteLine(">");
                        //and break the switch.
                        break;
                }
            }
        }
    }
}
