// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputNumberWithMessage(string message)
{
System.Console.Write(message);
int value = Convert.ToInt32(Console.ReadLine());
return value;
}

int SummingDigitsInNumber(int number)
{
    int summ = 0;
    while (number>0)
    {
        summ += number%10;
        number=number/10;
    }
    return summ;
}

int result = InputNumberWithMessage("Введите число: ");
System.Console.WriteLine(SummingDigitsInNumber(result));
