//Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами
Console.Clear();
int rows = GetNumberFromUser("Введите количество строк массива: ","Ошибка ввода!");
int columns = GetNumberFromUser("Введите количество столбцов массива: ","Ошибка ввода!");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
PrintAnswer(array);

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
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
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

// Печатаем Среднее арифметическое каждого столбца
void PrintAnswer(int[,] inArray)
{
   Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sum += inArray[i, j];
        }
        double avg = (double)sum / inArray.GetLength(0);
        Console.Write($"{avg}; ");
    }
}

