Random r = new Random();
void FillArray(int[,] arr, int lowBorder, int highBorder)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = r.Next(lowBorder, highBorder);
        }
    }
}
void ShowArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int SumOfAllElements(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
    }
    return sum;
}
int BiggestElement(int[,] arr)
{
    int biggestElement = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] > biggestElement) 
            {
                biggestElement = arr[i, j];
            } 
        }
    }
    return biggestElement;
}
int SmallestElement(int[,] arr)
{
    int smallestElement = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < smallestElement)
            {
                smallestElement = arr[i, j];
            }
        }
    }
    return smallestElement;
}
int AmountOfNegative(int[,] arr)
{
    int amountOfNegative = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 0)
            {
                amountOfNegative++;
            }
        }
    }
    return amountOfNegative;
}
int AmountOfPositive(int[,] arr)
{
    int amountOfPositive = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] > 0)
            {
                amountOfPositive++;
            }
        }
    }
    return amountOfPositive;
}
double AverageOfAllElements(int[,] arr)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
    }
    double average = sum / (arr.GetLength(0) * arr.GetLength(1));
    return average;
}
void TranspositionOfArray(ref int[,] arr)
{
    int[,] transposedArr = new int[arr.GetLength(1), arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            transposedArr[j, i] = arr[i, j];
        }
    }
    arr = transposedArr;
}
void SortBySumInLines(ref int[,] arr)
{
    int[,] sortedArray = new int[arr.GetLength(0), arr.GetLength(1)];

}
bool program = true;
int action;
int numberOfLines;
int numberOfColumns;
Console.WriteLine("Введите количество строк");
if(!int.TryParse(Console.ReadLine(), out numberOfLines))
{
    Console.WriteLine("Введено не число или неположительное число, используется 5 строчек");
    numberOfLines = 5;
    Thread.Sleep(2000);
}
Console.Clear();
Console.WriteLine("Введите количество столбцов");
if(!int.TryParse(Console.ReadLine(), out numberOfColumns))
{
    Console.WriteLine("Введено не число или неположительное число, используется 5 столбцов");
    numberOfColumns = 5;
    Thread.Sleep(2000);
}
int[,] arr = new int[numberOfLines, numberOfColumns];
while (program)
{
    Console.Clear();
    Console.WriteLine("Выберите действие");
    Console.WriteLine("1 - заполнить и вывести массив");
    Console.WriteLine("2 - найти сумму всех элементов");
    Console.WriteLine("3 - найти наибольший элемент");
    Console.WriteLine("4 - найти наименьший элемент");
    Console.WriteLine("5 - посчитать количество отрицательных элементов");
    Console.WriteLine("6 - посчитать количество положительных элементов");
    Console.WriteLine("7 - найти среднее арифметическое всех элементов");
    Console.WriteLine("8 - транспонирование массива");
    Console.WriteLine("9 - упорядочить строки по возрастанию сумм их элементов");
    Console.WriteLine("10 - ?");
    Console.WriteLine("11 - вывести массив");
    Console.WriteLine("0 - выйти из программы");
    if (int.TryParse(Console.ReadLine(), out action))
    {
        Console.Clear();
        switch (action)
        {
            case 0:
                program = false;
                break;
            case 1:
                Console.Clear();
                int lowBorder = 0;
                int highBorder = 0;
                Console.WriteLine("Введите нижнюю границу");
                if (int.TryParse (Console.ReadLine(), out lowBorder))
                {
                    Console.Clear();
                    Console.WriteLine("Введите верхнюю границу");
                    if (!int.TryParse (Console.ReadLine(), out highBorder) || lowBorder > highBorder)
                    {
                        Console.WriteLine("Введено не число или верхняя граница меньше нижней, используются границы от 0 до 10");
                        lowBorder = 0;
                        highBorder = 10;
                        Thread.Sleep(2000);
                    }
                }
                else
                {
                    Console.WriteLine("Введено не число, используются границы от 0 до 10");
                    lowBorder = 0;
                    highBorder = 10;
                    Thread.Sleep(2000);
                }
                Console.Clear();
                FillArray(arr, lowBorder, highBorder + 1);
                ShowArray(arr);
                Thread.Sleep(5000);
                break;
            case 2:
                Console.WriteLine($"Сумма всех элементов - {SumOfAllElements(arr)}");
                Thread.Sleep(2000);
                break;
            case 3:
                Console.WriteLine($"Наибольший элемент - {BiggestElement(arr)}");
                Thread.Sleep(2000);
                break;
            case 4:
                Console.WriteLine($"Наименьший элемент - {SmallestElement(arr)}");
                Thread.Sleep(2000);
                break;
            case 5:
                Console.WriteLine($"Отрицательных элементов - {AmountOfNegative(arr)}");
                Thread.Sleep(2000);
                break;
            case 6:
                Console.WriteLine($"Положительных элементов - {AmountOfPositive(arr)}");
                Thread.Sleep(2000);
                break;
            case 7:
                Console.WriteLine($"Среднее арифметическое всех элементов - {AverageOfAllElements(arr)}");
                Thread.Sleep(2000);
                break;
            case 8:
                TranspositionOfArray(ref arr);
                Console.WriteLine("Массив успешно транспонирован");
                Thread.Sleep(1500);
                break;
            case 9:

                break;
            case 11:
                ShowArray(arr);
                Thread.Sleep(5000);
                break;
            default:
                Console.WriteLine("Нет такого действия");
                Thread.Sleep(1500);
                break;
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Нет такого дейсвия");
        Thread.Sleep(1500);
    }
}