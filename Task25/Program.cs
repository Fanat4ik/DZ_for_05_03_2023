// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int InputNumberWithMessage(string message)
{
System.Console.Write(message);
int value = Convert.ToInt32(Console.ReadLine());
return value;
}

int RaisingAToThePowerOfB(int a, int b)
{
    for (int i = 1; i < b; i++)
    {
        a*=a;
    }
    return a;
}

int a = InputNumberWithMessage("Введите А:" );
int b = InputNumberWithMessage("Введите B:" );

    System.Console.WriteLine(RaisingAToThePowerOfB(a,b));
