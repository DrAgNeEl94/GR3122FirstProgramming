//-----------------------------------------------------------------------------------------------------------
//  Задача 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//  Если второе число некратно первому, то программа выводит о статок от деления .
//-------------------------------------------------------------------------------------------------

//Вариант Константина
void Variant1()
 {
    Console.WriteLine("Введите первое число: ");
    string? inputLineA = Console.ReadLine();
    Console.Write("Введите второе число: ");
    string? inputLineB = Console.ReadLine();

    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);

    Console.WriteLine((inputNumberB % inputNumberA == 0) ? ("Второе число кратно первому") : ("Остаток от деления: " + inputNumberB % inputNumberA));
 }
Variant1();

//Вариант Евгения
void Variant2()
 {
  string? inputLineA = Console.ReadLine();
  string? inputLineB = Console.ReadLine();

  if (inputLineA !=null && inputLineB !=null)
  {
    int inputNumberA = (int)int.Parse(inputLineA);
    int inputNumberB = (int)int.Parse(inputLineB);
    Console.WriteLine(inputNumberB % inputNumberA == 0 ? "Является кратным" : inputNumberB % inputNumberA);
  }
 }
Variant2();

int inputNumberA = 0;
int inputNumberB = 0;
bool result = false;

//Получаем два числа пользователя
void ReadData() 
 {
    Console.WriteLine("Введите первое число: ");
    string? inputLineA = Console.ReadLine();
    Console.Write("Введите второе число: ");
    string? inputLineB = Console.ReadLine();

    inputNumberA = int.Parse(inputLineA);
    inputNumberB = int.Parse(inputLineB);

 }
ReadData();

//Определяем кратность чисел
void ConculateData()
 {
    result = (inputNumberB % inputNumberA == 0);
 }
ConculateData();

//Выводы данные вычислителя
void PrintData()
 {
    if(result)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        Console.WriteLine("Остаток от давления: " + inputNumberB % inputNumberA);
    }
 }
PrintData();