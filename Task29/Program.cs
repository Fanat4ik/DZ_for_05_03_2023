// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//заполнение массива случайными цифрами (до 100)
void FillArrayRandomNumbers(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
}

//заполнение массива из консоли
void FillArrayConsoleNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Введите значение {i} элемента массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        System.Console.Write(array[i]);
        else
        System.Console.Write(array[i] + ", ");
    }
    System.Console.WriteLine("]");
}

int[] arrey = new int[8];
FillArrayRandomNumbers(arrey);
PrintArray(arrey);
int[] arrey2 = new int[8];
FillArrayConsoleNumbers(arrey2);
PrintArray(arrey2);
