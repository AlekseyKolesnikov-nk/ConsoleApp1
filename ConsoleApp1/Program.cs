using System;
using System.ComponentModel.Design;
class MainClass
{
    public static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Введите количество пользователей");
        n = Convert.ToInt32(Console.ReadLine());
        
        for (int k = 0; k < n ; k++)
        {
            (string Name1, string Name2, string Login, int LoginLenght, bool Pet, double Age, string [] favColors) User;

            Console.WriteLine("Введите имя");
            User.Name1 = Console.ReadLine();

            Console.WriteLine("Введите Фамилию");
            User.Name2 = Console.ReadLine();

            Console.WriteLine("Введите логин");
            User.Login = Console.ReadLine();
            User.LoginLenght = User.Login.Length;

            Console.WriteLine("Есть ли у вас животные? Да или Нет");
            var res = Console.ReadLine();
            if (res == "Да")
            {
                User.Pet = true;
            }
            else
            {
                User.Pet = false;
            }

            Console.WriteLine("Введите возраст пользователя");
            User.Age = double.Parse(Console.ReadLine());

            User.favColors = new string[3];
            Console.WriteLine("Введите три любимых цвета пользователя");
            for (int i = 0; i < User.favColors.Length; i++)
            {
                User.favColors[i] = Console.ReadLine();
            }
            Console.WriteLine();
        }
    }
}


//Работа с кортежем

        //(string Name, string Type, double Age, int NameCount) Pet;

        //Console.WriteLine("Имя питомца:");
        //Pet.Name = Console.ReadLine();
        //Console.WriteLine(Pet.Name);
        //Pet.NameCount = Pet.Name.Length;
        //Console.WriteLine(Pet.NameCount);

        //Console.WriteLine("Порода питомца:");
        //Pet.Type = Console.ReadLine();
        //Console.WriteLine(Pet.Type);

        //Console.WriteLine("Возраст питомца:");
        //Pet.Age = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(Pet.Age);

// ---------------------------------------------------------------------------
        //var (name, age) = ("Алексей", 59);
        //Console.WriteLine("Мое имя: {0}", name);
        //Console.WriteLine("Мой возраст: {0}" ,age);
        
        //Console.WriteLine("Введите Ваше имя: ");
        //name = Console.ReadLine();

        //Console.WriteLine("Введите Ваш возраст цифрами: ");
        //age = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine();

        //Console.WriteLine("Ваше имя: {0}", name);
        //Console.WriteLine("Ваш возраст: {0}" ,age);

//------------------------------------------------------------------------------------

//var anketa = (name: "Алексей", age: 59, plant: "ЕЗСМК", city: "Новокузнецк");

//Console.WriteLine("Ваше имя: {0}", anketa.name);
//Console.WriteLine("Ваш возраст: {0}", anketa.age);
//Console.WriteLine("Ваше предприятие: {0}", anketa.plant);
//Console.WriteLine("Ваш город: {0}", anketa.city);





//int[,] mmm = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

//// формируем построчный вывод массива без сортировки
//for (int v = 0; v < mmm.GetUpperBound(0) + 1; v++)
//{
//    for (int w = 0; w < mmm.GetUpperBound(1) + 1; w++)
//        Console.Write(mmm[v, w] + " ");
//    Console.WriteLine();
//}

//Console.WriteLine();
//int x;

//// формируем построчный вывод массива без сортировки
//for (int i = 0; i <= mmm.GetUpperBound(0); i++)
//{
//    for (int j = 0; j <= mmm.GetUpperBound(1); j++)
//    {
//        for (int k = j + 1; k <= mmm.GetUpperBound(1); k++)
//            if (mmm[i, j] > mmm[i, k])
//            {
//                x = mmm[i, k];
//                mmm[i, k] = mmm[i, j];
//                mmm[i, j] = x;
//    }
//}

//// формируем построчный вывод массива с сортировкой
//for (int v = 0; v < mmm.GetUpperBound(0) + 1; v++)
//{
//    for (int w = 0; w < mmm.GetUpperBound(1) + 1; w++)
//        Console.Write(mmm[v, w] + " ");
//    Console.WriteLine();
//}

//class MainClass
//{
//  public static void Main(string[] args)
//{
//  int[,] mmm = { { 2, -5, 8, 4, 1, -9}, { 13, 83, -12, 15, -77, -30 } };
//int x = 0; int y = 0;

//        for (int i = 0; i < mmm.GetUpperBound(0) + 1; i++)
//      {
//        for (int j = 0; j < mmm.GetUpperBound(1); j++)
//      { 
//        if (mmm[i, j] > 0)
//          x++;
//}
//        }
//      Console.Write(x);

//    foreach (var z in mmm)
//  {
//    if (z > 0)
//      y++;
//        }
//      Console.Write(" " + x);
// }
//}


//class MainClass
//{
//  public static void Main(string[] args)
//{ 
//  var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
//int x;
//        x = 0;
//      for (int i = 0; i < arr.Length; i++)
//    {
//      x = x + arr[i];

//}
//    Console.Write(x);
//  }
//}


//class MainClass
//{
//    public static void Main(string[] args)
//  {
//    var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
//  int x, n, m;

//for (int i = 0; i < arr.Length; i++)
//        {
//          for (int j = i + 1; j < arr.Length; j++)
//        {
//          if (arr[i] > arr[j])
//        {
//          x = arr[i];
//        arr[i] = arr[j];
//      arr[j] = x;
//    n = arr[i];
//  m = arr[j];
//m = m;
//                }
//          }
//    }
//  foreach (var item in arr)
//{
//  Console.Write(item);
//        }
//  }
//}


//        int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 10, 11, 12 }, {20, 21, 22 }, {31, 32, 33} };
//      Console.WriteLine(array.Length);

//    for(int i = 0; i < array.GetUpperBound(1) + 1; i++) 
//  {
//    for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
//      Console.Write(array[k, i] + " ");

//Console.WriteLine();
//}



//Console.WriteLine(array[0,0]);
//        foreach (var item in array) ;
//        {
//            Console.Write(item + " ");
//        }
//}
//}
//        string[] favcolors = new string[3];
//
//      for (int i = 0; i < favcolors.Length; i++)
//    {
//      Console.WriteLine("Введите любимый номер цвета {0}", i + 1);
//    favcolors[i] = Console.ReadLine();
//}

//        foreach(var color in favcolors) 
//      {

//            switch (Console.ReadLine())
//          {
//            case "red":
//              Console.BackgroundColor = ConsoleColor.Red;
//            Console.ForegroundColor = ConsoleColor.Black;

//          Console.WriteLine("Your color is red!");
//        break;

//  case "green":
//    Console.BackgroundColor = ConsoleColor.Green;
//  Console.ForegroundColor = ConsoleColor.Black;

//Console.WriteLine("Your color is green!");
//                    break;

//              default:
//                Console.BackgroundColor = ConsoleColor.Cyan;
//              Console.ForegroundColor = ConsoleColor.Black;

//            Console.WriteLine("Your color is cyan!");
//          break;
//}
//        }
//    }
//}