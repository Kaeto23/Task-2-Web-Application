using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2_Web_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBlueTagtask1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Formula for Blue Tag Task 1:\nA, B, C, D, T inputs required.";
            double A = GetInput("Enter value for A:");
            double b = GetInput("Enter value for B:");
            double C = GetInput("Enter value for C:");
            double D = GetInput("Enter value for D:");
            double T = GetInput("Enter value for T:");

            double resultValue = ((Math.Sqrt(A * b) / (2 * D)) * 3 -
                                  (Math.Sqrt(Math.Sqrt((T * C))) / (2 * D) *
                                  (Math.Sqrt((T * C))) / (2 * D))) / (4 * A * C);
            textBox1.AppendText($"\nYour Answer is: {resultValue}");
        }

       private void buttonareaofcircle_Click(object sender, EventArgs e)
        {
            // C# Program to Find Area of a Circle
            const double pi = 3.14; // Define the constant for π
            textBox1.Text = "Area of Circle Formula: A = πr²";

            // Prompt for user input
            string input = Interaction.InputBox("Enter the value for radius:", "Input required", "0");

            // Validate input and parse it
            if (string.IsNullOrWhiteSpace(input))
    {
                MessageBox.Show("Input cannot be empty. Please enter a valid radius.");
                return; // Exit the method if input is invalid
            }

            if (!double.TryParse(input, out double radius))
            {
                MessageBox.Show("Invalid input. Please enter a numeric value for the radius.");
                return; // Exit the method if parsing fails
            }

            // Calculate the area
            double area = pi * radius * radius;
            textBox1.AppendText($"\nArea of Circle = {area}");
}

        private void buttonquadraticequationsolver_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Quadratic Equation: ax² + bx + c = 0";

            // Prompt for user input with validation
            double a = GetInput("Enter the value for a:");
            double b = GetInput("Enter the value for b:");
            double c = GetInput("Enter the value for c:");

            // Calculate the discriminant
            double discriminant = b * b - 4 * a * c;

            // Display the results based on the discriminant
            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                textBox1.AppendText($"\nThe solutions are:\nx1 = {x1}\nx2 = {x2}");
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                textBox1.AppendText($"\nThe solution is:\nx = {x}");
            }
            else
            {
                textBox1.AppendText("\nThe equation has no real solutions.");
            }
        }

    private void buttonpythagoreamsolver_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Pythagorean Theorem: a² + b² = c²";
            double A = GetInput("Enter side A:");
            double B = GetInput("Enter side B:");
            double C = Math.Sqrt((A * A) + (B * B));
            textBox1.AppendText($"\nThe hypotenuse is: {C}");
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private double GetInput(string message, double defaultValue = 0)
        {
            double result;
            string input;
            int attempts = 0;
            const int maxAttempts = 3;

            do
            {
                input = Interaction.InputBox(message, "Input Required", defaultValue.ToString());

                // Validate input
                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Input cannot be empty. Please enter a valid number.");
                    attempts++;
                    continue;
                }

                // Try to parse the input
                if (!double.TryParse(input, out result))
                {
                    MessageBox.Show("Invalid input. Please enter a valid number.");
                    attempts++;
                }

                // Check if the maximum attempts have been reached
                if (attempts >= maxAttempts)
                {
                    MessageBox.Show("Maximum attempts reached. Exiting.");
                    return defaultValue; // or throw an exception
                }

            } while (!double.TryParse(input, out result));

            return result;
        }
    }
}
