using System;
using System.Windows.Forms;

public class View                                           // This line declares a new class named View.
{
    // Properties to represent the UI components
    public TextBox TextBoxInput { get; set; }
    public Label LabelResult { get; set; }
    public ComboBox ComboBoxStrategy { get; set; }
    public Button ButtonSort { get; set; }


    // Constructor that takes UI components as parameters and assigns them to properties
    public View(TextBox textBoxInput, Label labelResult, ComboBox comboBoxStrategy, Button buttonSort)     
    {
        TextBoxInput = textBoxInput;
        LabelResult = labelResult;
        ComboBoxStrategy = comboBoxStrategy;
        ButtonSort = buttonSort;
    }

    public event EventHandler SortClicked;               // Event declaration for the "SortClicked" event

    public string GetSelectedSortStrategy()             // Method to get the selected sorting strategy from the ComboBox
    {
        return ComboBoxStrategy.SelectedItem.ToString();  
        
    }
    
    public string GetInputText()                        // Method to get the input text from the TextBox
    {
        return TextBoxInput.Text;
    }

    public void SetResultText(string result)             // Method to set the text of the Label to display the sorting result
    {
        LabelResult.Text = result;
    }
    
    public void AttachEvents()                          // Method to attach an event handler to the "Click" event of the "Sort" button
    {
        ButtonSort.Click += (sender, e) => SortClicked?.Invoke(sender, e);
    }
}
