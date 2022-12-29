// Написать программу, которая из имеющегося массива строк формирует массив из строк,  
// длина которых меньше или равна 3 символам. 

int max_length = 3;
void ChangeArray(string[] array)

{
    int length = array.Length;
    string[] newArray = new string[length];
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= max_length)
        {
            newArray[count] = array[i];
        }
        count++;
    }
    Console.WriteLine('[' + string.Join(", ", newArray) + ']');




}



Console.WriteLine("Source array:");
string[] Array1 = { " hello", "2", "world", "Russia", "me " };
Console.WriteLine('[' + string.Join(", ", Array1) + ']');
ChangeArray(Array1);
