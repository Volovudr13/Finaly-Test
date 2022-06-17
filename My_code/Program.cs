// Написать программу которая из имеющегося одномерноего массива строк , сформирует новый, одномерный массив, длинна строк которого меньше или равна трём элементам.


string [] Array = {"Bravo", "No", "8", "Master",
                   "Hi", "12", "Beautifule", "A" 
                  };
 
Console.WriteLine();

void Print_Arr (string [] My)              
{                                           
 for (int i = 0; i < My.Length; i++)
    {                                        // Можно добавить проверку:
        Console.Write(My[i] + " ");         // if (My.Length == 0)
                                              // Console.Write("[]");
    }                                       // else
}                                             // Console.Write(My[i] + " ");
                                               
Print_Arr(Array);


string [] Final (string [] MyArray)
{
    string [] Itog = new string [MyArray.Length];
    for (int i = 0; i < MyArray.Length; i++)
    {
        if (MyArray[i].Length <= 3)
        {
            Itog[i] = MyArray[i];
           
        }
    }
    return Itog;
}
Console.Write("=>");
Print_Arr(Final(Array));

