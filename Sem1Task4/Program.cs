//=============================================
// # 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из
// этих чисел.
//=============================================

string? inputLineA = Console.ReadLine(); // Читаем данные
string? inputLineB = Console.ReadLine(); //
string? inputLineC = Console.ReadLine();

int inputNumberA = int.Parse(inputLineA);
int inputNumberB = int.Parse(inputLineB);
int inputNumberC = int.Parse(inputLineC);

if (inputNumberA > inputNumberB)
{
    if (inputNumberA > inputNumberC)
    {
        Console.WriteLine("максимальное число A"); //
    }
    else 
    {  
        Console.WriteLine("максимальное число C"); //
    }
    if (inputNumberB > inputNumberC)
    {
        Console.WriteLine("максимальное число B"); //
    }
    else 
    {
    Console.WriteLine("максимальное число C"); //
    }
}