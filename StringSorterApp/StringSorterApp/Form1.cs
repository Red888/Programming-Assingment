using System;
using System.Windows.Forms;

namespace LetterSortApp
{
    public partial class Form1 : Form
    {
        private Controller controller;

        public Form1()
        {
            InitializeComponent();

            Model model = new Model();                                      // Create instances of the Model, View, and Controller
            View view = new View(textBoxInput, labelResult, comboBoxStrategy, buttonSort);
            controller = new Controller(model, view);
        }

        private void Form1_Load(object sender, EventArgs e)                 // Event handler for the form's Load event
        {
            textBoxInput.Text = "Input text here";
            textBoxInput.ForeColor = Color.LightGray;
            comboBoxStrategy.SelectedIndex = 0;                             // Default selection Bubble Sort in combobox
        }


        private void textBoxInput_Enter(object sender, EventArgs e)
        {
            if (textBoxInput.Text == "Input text here")
            {
                textBoxInput.Text = "";
                textBoxInput.ForeColor = Color.Black;

            }
        }

        private void textBoxInput_Leave(object sender, EventArgs e)
        {
            if (textBoxInput.Text == "")
            {
                textBoxInput.Text = "Input text here";
                textBoxInput.ForeColor = Color.LightGray;

            }
        }
    }
}