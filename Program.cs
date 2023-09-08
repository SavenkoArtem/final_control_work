// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


int Promt(string msg)
{
    System.Console.WriteLine(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {   
        System.Console.Write("Enter your value: ");
        array[i] = System.Console.ReadLine();        
    }
}

string[] CreateNewArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;            
        }        
    }

    string[] new_array = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            new_array[j] = array[i];
            j++;
        }        
    }


    return new_array;
}

void PrintArray(string[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"\"{array[i]}\"");
        if (i != array.Length -1)
        {
            System.Console.Write(", ");
        }
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

int lenght_array = Promt("Enter length array: ");
string[] array = new string[lenght_array];
FillArray(array);
string[] new_array = CreateNewArray(array);
System.Console.WriteLine();
System.Console.WriteLine("Current array:");
PrintArray(array);
System.Console.WriteLine("New array:");
PrintArray(new_array);

