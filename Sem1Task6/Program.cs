//=============================================
// # 6 Напишите программу, которая на вход принимает число и выдаёт, является ли число
// чётным (делится ли оно на два без остатка).
//=============================================

string? inputLineA = Console.ReadLine();
int inputNumberA = int.Parse(inputLineA);
int inputLineR = (inputNumberA % 2);
if (inputLineR == 0)
{
    Console.WriteLine ("четное");
}
else 
{
    Console.WriteLine ("не четное");
}