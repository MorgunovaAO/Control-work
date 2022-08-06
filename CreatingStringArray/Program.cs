string[] CreateArray (int length)  
{  
    string[] array = new string[length]; 
    Console.WriteLine("Creating array here: ");  
    for (int i = 0; i < length; i++)  
    {  
        Console.Write($"Input {i + 1} element: "); 
        array[i] = Console.ReadLine();  
    }  
    Console.WriteLine();  
    return array;  
}  

void ShowArray(string[] array) 
{  
    for (int i = 0; i < array.Length; i++)  
        Console.Write($"'{array[i]}' ");  
    Console.WriteLine(); 
}  

void ShowNewArray(string[] newArray) 
{  
    for (int i = 0; i < newArray.Length; i++)  
        if (newArray[i].Length <= 3) 
            Console.Write($"'{newArray[i]}' "); 
    Console.WriteLine(); 
}  

Console.Write("Input size of array: ");  
int size = Convert.ToInt32(Console.ReadLine());  
string[] firstArray = CreateArray(size); 

Console.WriteLine("Your array:");
ShowArray(firstArray); 
Console.WriteLine(); 

Console.WriteLine("New array:"); 
ShowNewArray(firstArray);