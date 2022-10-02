// Задания 14. Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оноодновременно 7 и 23.


//Вариант Евгения
 Console.Write("Введите число: ");
 string? inputLineA = Console.ReadLine();
 int inputNumberA = int.Parse(inputLineA);

 if(inputNumberA%7==0 && inputNumberA%23==0)
 {
 Console.Write("Число кратно одновременно 7 и 23");
 }
 else
 {
 Console.Write("Число не кратно одновременно 7 и 23");
 }

// //Вариант Михаила

//  int number, resultA, resultB;

//  // запрашивает число у пользователь, в качестве аргумента принимает текст запроса и команду выхода из программы.
//  int RequestNumber(string text = "Enter number", string exitCmd = "q")
//  {
//     // цикле выполняется до введения целого число или команду выхода из программы
//  while (true) 
//  {
//   Console.Write(text + ": ");
//   string? inputLine = Console.ReadLine();
//   //Игнорируем число
//   if (inputLine == null)
//   {
//   continue;
//   }
//   //Выходим из программы
//   if (inputLine.ToLower() == exitCmd)
//   {
//       Environment.Exit(0);
//   }
//   //Выдаем полученное число
//   if (int.TryParse(inputLine, out int number))
//   {
//   return number;
//   }
//  }
//  }

//  // чтение данных из сонсоли
//  void ReadData()
//  {
//  number = RequestNumber("Enter number");
//  }

//  // Определяем крат
// //}