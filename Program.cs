using System.Globalization;
using System.Runtime.Serialization.Json;

string[] original_array_1 = new string[] {"Hello", "2", "world", ":-)"};

string[] original_array_2 = new string[] {"1234", "1567", "-2", "computer science"};

string[] original_array_3 = new string[] {"Russia", "Denmark", "Kazan"};

string[] Selecting_short_elements(string[] Arr)
{
    int N = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        string a = Arr[i];
        if (a.Length < 4)
        {
            N++;
        }
    }

    string[] new_array = new string[N];
    int j = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        string a = Arr[i];
        if (a.Length < 4)
        {
            new_array[j] = a;
            j++;
        }
    }
    return new_array;

}

void Displaying_array_elements(string[] Arr)
{
    foreach(string e in Arr)
    {
        Console.WriteLine(e);
    }
}

string[] final_array_1 = Selecting_short_elements(original_array_1);
Displaying_array_elements(final_array_1);

string[] final_array_2 = Selecting_short_elements(original_array_2);
Displaying_array_elements(final_array_2);

string[] final_array_3 = Selecting_short_elements(original_array_3);
Displaying_array_elements(final_array_3);
