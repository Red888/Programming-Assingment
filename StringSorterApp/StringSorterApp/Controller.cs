using System;
using System.Windows.Forms;

public class Controller                                             // This line declares a new class named Controller.
{
    private Model model;
    private View view;

    public Controller(Model model, View view)                       // Constructor for the Controller class that takes a Model and a View as parameters
    {
        this.model = model;                                         // Assign the provided Model and View instances to the private fields
        this.view = view;

        view.SortClicked += SortButton_Click;                       // Subscribe the SortButton_Click method to the SortClicked event in the View
        view.AttachEvents();                                        // Attach event handlers to the UI components in the View
    }

    private void SortButton_Click(object sender, EventArgs e)       // Event handler for the SortClicked event raised when the "Sort" button is clicked
    {
        string input = view.GetInputText();                         // Get the input text from the View's TextBox
        string strategy = view.GetSelectedSortStrategy();           // Get the selected sorting strategy from the View's ComboBox

        string result = strategy switch                             // Use a switch statement to determine the sorting strategy
        {
            "Bubble Sort" => Model.BubbleSort(input),               // If "Bubble Sort" is selected, call the BubbleSort method from the Model
            "Merge Sort" => Model.MergeSort(input),                 // If "Merge Sort" is selected, call the MergeSort method from the Model
            _ => throw new InvalidOperationException("Invalid sorting strategy selected."),         // If an invalid strategy is selected, throw an exception

        };

        view.SetResultText(result);                                 // Set the result text in the View's Label to display the sorted result
    }
}
