using System;
using System.Linq;

public class Model                                                      // This line declares a new class named Model.
{
    public static string BubbleSort(string input)                       // Method for performing Bubble Sort on the input string
    {
        char[] letters = input.ToCharArray();                           // Convert the input string to an array of characters
        int n = letters.Length;                                         // Get the length of the array
        for (int i = 0; i < n - 1; i++)                                 // Outer loop iterates n-1 times
        {
            for (int j = 0; j < n - i - 1; j++)                         // Inner loop iterates from 0 to n-i-1
            {
                if (letters[j] > letters[j + 1])                        // Compare adjacent characters and swap them if out of order
                {
                    char temp = letters[j];
                    letters[j] = letters[j + 1];
                    letters[j + 1] = temp;
                }
            }
        }
        return new string(letters);                                     // Convert the sorted array back to a string and return it
    }

    public static string MergeSort(string input)                        // Method for performing Merge Sort on the input string
    {
        if (input.Length <= 1)                                          // Base case: if the input string has 1 or fewer characters, return it as is
            return input;

        int middle = input.Length / 2;                                  // Calculate the middle index of the input string
        string left = input.Substring(0, middle);                       // Split the input into left and right halves
        string right = input.Substring(middle);

        left = MergeSort(left);                                         // Recursively sort the left and right halves
        right = MergeSort(right);

        return Merge(left, right);                                      // Merge the sorted left and right halves and return the result
    }

    private static string Merge(string left, string right)              // Helper method for merging two sorted strings
    {
        char[] result = new char[left.Length + right.Length];           // Create a character array to store the merged result
        int leftIndex = 0, rightIndex = 0, resultIndex = 0;             // Initialize indices for left, right, and result

        while (leftIndex < left.Length && rightIndex < right.Length)    // Compare characters from left and right and merge them in sorted order
        {
            if (left[leftIndex] < right[rightIndex])
                result[resultIndex++] = left[leftIndex++];
            else
                result[resultIndex++] = right[rightIndex++];
        }

        while (leftIndex < left.Length)                                 // Copy any remaining characters from the left and right strings
            result[resultIndex++] = left[leftIndex++];

        while (rightIndex < right.Length)
            result[resultIndex++] = right[rightIndex++];

        return new string(result);                                      // Copy any remaining characters from the left and right strings
    }
}
