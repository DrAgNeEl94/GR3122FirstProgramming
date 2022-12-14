int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

//1 2 3 4 5 6
//1 4 9 16 25 36
string LineNumbers(int numberN, int pow)
{
    int i = 1;
    string outLine = string.Empty;
    while (i < numberN)
    {
        outLine = outLine + Math.Pow(i,pow) + "\t";
        ++i;
    }
    outLine = outLine + Math.Pow(numberN,pow);
    return outLine;
}
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите число N:");

PrintResult(LineNumbers(num,1));
PrintResult(LineNumbers(num,2));