using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int[,] mmm = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

        // формируем построчный вывод массива без сортировки
        for (int v = 0; v < mmm.GetUpperBound(0) + 1; v++)
        {
            for (int w = 0; w < mmm.GetUpperBound(1) + 1; w++)
                Console.Write(mmm[v, w] + " ");
            Console.WriteLine();
        }
        
        Console.WriteLine();
        int x;

        // формируем построчный вывод массива без сортировки
        for (int i = 0; i <= mmm.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= mmm.GetUpperBound(1); j++)
            {
                for (int k = j + 1; k <= mmm.GetUpperBound(1); k++)
                    if (mmm[i, j] > mmm[i, k])
                    {
                        x = mmm[i, k];
                        mmm[i, k] = mmm[i, j];
                        mmm[i, j] = x;
            }
        }

        // формируем построчный вывод массива с сортировкой
        for (int v = 0; v < mmm.GetUpperBound(0) + 1; v++)
        {
            for (int w = 0; w < mmm.GetUpperBound(1) + 1; w++)
                Console.Write(mmm[v, w] + " ");
            Console.WriteLine();
        }
    }
}

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