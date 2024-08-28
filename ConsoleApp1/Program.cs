using System;

class MainClass
{
    public static void Main(string[] args)
    { 
        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
        int x;
        x = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            x = x + arr[i];

        }
    Console.Write(x);
    }
}


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