// #9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и
// показывает наибольшую цифру числа.



void MyVariant()
  {
   Console.WriteLine("Метод");
   System.Random numberGenerator = new System.Random();
   int number = numberGenerator.Next(10, 100);
   Console.WriteLine();
   int ferstDigit = number / 10;
   int secondDigit = number % 10;
   //Вариант 1
   if (ferstDigit > secondDigit)
   {
    Console.WriteLine(ferstDigit);
   }
   else
   {
    Console.WriteLine(secondDigit);
   }
  }

void EvgeniyVariant()
  {
    Console.WriteLine("Метод 2");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine();
    int ferstDigit = number / 10;
    int secondDigit = number % 10;
    //Вариант Евгения
    Console.WriteLine((ferstDigit > secondDigit) ? ferstDigit : secondDigit);
  } 

void CharVariant()
 { 
    Console.WriteLine("Метод 3");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);
    //Вариант char
    char[] charArray = number.ToString().ToCharArray();
    Console.WriteLine(((int)charArray[0] > (int)charArray[1]) ? charArray[0] : charArray[1]);
 }
 
MyVariant();

//EvgeniyVariant();

CharVariant();
