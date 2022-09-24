//=============================================
// # 8 Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.
//=============================================

string? inputLineA = Console.ReadLine();
int inputNumberA = int.Parse(inputLineA);
int inputNumberB = 1;
while (inputNumberB < inputNumberA)
{
   if (inputNumberB % 2 == 0)
   {
       Console.Write(inputNumberB + ' ');
   }
inputNumberB = inputNumberB + 1;
}