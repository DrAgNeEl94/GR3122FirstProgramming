//=============================================
// # 5 Напишите программу, которая которая на вход принимает
// одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//=============================================

string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int inputNumberN = int.Parse(inputLineN);
    if (inputNumberN > 0)
    {
       int starNumber = (-1)*inputNumberN;
       while(starNumber<inputNumberN)
       {
            Console.Write(starNumber+", ");
            starNumber=starNumber+1;
       }
       Console.Write(inputNumberN);
    }
}