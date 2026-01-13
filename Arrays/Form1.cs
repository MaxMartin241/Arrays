using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        Random randgen = new Random();
        int[] numbers = new int[9];
        int[] numbers2 = new int[9];
        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            //array gen
            numbers = new int[9] { randgen.Next(1,10), randgen.Next(1, 10), randgen.Next(1, 10), randgen.Next(1, 10), randgen.Next(1, 10), randgen.Next(1, 10), randgen.Next(1, 10), randgen.Next(1, 10), randgen.Next(1,10)};
            
            //array 1 output
            array1Label.Text = "Array1: ";//clear label to begin
            //to output an array use a for loop and the array method .length
            for (int i = 0; i < numbers.Length; i++)
            { array1Label.Text += numbers[i] + "  "; }

            //array 2 gen
            numbers2 = new int[9] { randgen.Next(1, 10), randgen.Next(1, 10), randgen.Next(1, 10), randgen.Next(1, 10), randgen.Next(1, 10), randgen.Next(1, 10), randgen.Next(1, 10), randgen.Next(1, 10), randgen.Next(1, 10)};

            //Array 2 output
            array2Label.Text = "Array2: ";//clear label to begin
            //to output an array use a for loop and the array method .length
            for (int i = 0; i < numbers2.Length; i++)
            { array2Label.Text += numbers2[i] + "  "; }

            //number of matching numbers in matching spots
            int numOfMatching = 0;
            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] == numbers2[i])
                {
                    numOfMatching = numOfMatching + 1;
                }

            }
            numOfMatchingLabel.Text ="Number of matching \n numbers in the\n same spot: " + Convert.ToString(numOfMatching);

            //array 1 reverse 
            Array.Reverse(numbers);
            array1ReverseLabel.Text = "Array1 reverse: ";
            for (int i = 0; i < numbers.Length; i++)
            {
                array1ReverseLabel.Text += numbers[i] + " ";
            }

            //array 1 highest number
            Array.Sort(numbers);
            highestNumberLabel.Text = "Highest number: " + numbers[numbers.Length - 1].ToString();

            //array 1 avrege 
            Double sum = 0;
            double average = 0;
            avrageLabel.Text = "Avrage: ";
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + Convert.ToDouble(numbers[i]);
            }
            average = sum / numbers.Length;
            avrageLabel.Text += average.ToString("F");


            //array 1 sum of all even numbers
            int sumOfEvens = 0;
            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] % 2 == 0)
                {
                    sumOfEvens += numbers[i];
                }

            }
            sumOfAllEvenNums.Text = "Sum of all the \n even numbers: " + Convert.ToString(sumOfEvens);

            //number of 3's
            int numOf3 = 0;
            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] == 3)
                {
                    numOf3 = numOf3 + 1;
                }

            }
            numOf3Label.Text = "Number of 3's: " + Convert.ToString(numOf3);

        }

        private void array1ReverseLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
