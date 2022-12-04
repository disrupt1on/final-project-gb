
void fillNewArray(string[] array, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
}

void printNewArray(string[] newArray)
{
    Console.Write("Новый массив из строк, длина которых меньше либо равна 3: ");
    for (int i = 0; i <= newArray.Length - 1; i++)
    {
        Console.Write($"{newArray[i]} ");
    }
    Console.WriteLine();
}

string[] array = new string[4] { "1234", "1567", "-2", "computer science" };
for (int i = 0; i < array.Length - 1; i++)
{
    Console.Write(array[i] + ", ");
}
Console.Write(array[array.Length - 1]);

string[] newArray = new string[array.Length];

fillNewArray(array, newArray);
printNewArray(newArray);

