//Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами
Console.Clear();
int rows = GetNumberFromUser("Введите количество строк массива: ","Ошибка ввода!");
int columns = GetNumberFromUser("Введите количество столбцов массива: ","Ошибка ввода!");
int[,] array = GetArray(rows, columns);
int UserNumber = GetNumberFromUser("Введите число: ","Ошибка ввода!");
PrintAnswer(array, UserNumber);
PrintArray(array);

//////////////////////////////////////////////////////////////////////////////////

// Выводит в консоль сообщение message,
// преобразовывает введённую пользователем строку в число типа int.
// В случае ошибки выводит в консоль сообщение errorMessage
int GetNumberFromUser(string message, string errorMessage)
{ 
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect) return userNumber;
        Console.WriteLine(errorMessage);
    } 
}

/// Создаем 2-х мерный массив
int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = GetNumberFromUser("Введите элемент массива: ","Ошибка ввода!");
        }
    }
    return result;
}

/// Печатаем  2-х мерный массив

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintAnswer(int[,] inArray, int inNumber)
{
    int flag = 0; 
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] == inNumber) flag = 1;
        }
    }
    if (flag == 1)
    {
         Console.WriteLine($"Число {inNumber} есть в массиве");
    }
    else
    {
        Console.WriteLine($"Числа {inNumber} нет в массиве");
    }
}
