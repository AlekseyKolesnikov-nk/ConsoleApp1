using System;

class MainClass
{
    int array = 0;
    public static void Main(string[] args)
    {
        int num = 0;
        GetArrayFromConsole(ref num);
    }

    static int[] GetArrayFromConsole(ref int num)
    {
        ChangeNum(ref num);
        var result = new int[num];
        int[] array = new int[num];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
            array[i] = result[i];
        }
        Console.WriteLine();

        int[] sorteddecs;
        int[] sortedacs;
        SortArray(in array, out sorteddecs, out sortedacs);

        return result;
    }

    static int ChangeNum(ref int newnum)
    {
        Console.WriteLine("Введите количество элементов масива");
        newnum = Convert.ToInt32(Console.ReadLine());

        return newnum;
    }

    static void SortArray(in int[] array, out int[] sorteddecs, out int[] sortedacs)
    {
        sortedacs = SortArrayAsc(array);
        Console.WriteLine();
        sorteddecs = SortArrayDecs(array);
    }

    static int[] SortArrayAsc(int[] result)
    {
        int temp = 0;
        for (int i = 0; i < result.Length; i++)
            for (int j = i + 1; j < result.Length; j++)
                if (result[i] > result[j])
                {
                    temp = result[i];
                    result[i] = result[j];
                    result[j] = temp;
                }
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
        return result;
    }

    static int[] SortArrayDecs(int[] result)
    {
        int temp = 0;
        for (int i = 0; i < result.Length; i++)
            for (int j = i + 1; j < result.Length; j++)
                if (result[i] < result[j])
                {
                    temp = result[i];
                    result[i] = result[j];
                    result[j] = temp;
                }
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
        return result;
    }
}




// Методы

// 5.3.13 Передача в метод размерость массива по ссылке, сортировка, обратная сортировка
//class MainClass
//{
//    int array = 0;
//    public static void Main(string[] args)
//    {
//        int num = 0;
//        GetArrayFromConsole(ref num);
//    }

//    static int[] GetArrayFromConsole(ref int num)
//    {
//        ChangeNum(ref num); 
//        var result = new int[num];
//        int[] array = new int[num];

//        for (int i = 0; i < result.Length; i++)
//        {
//            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
//            result[i] = int.Parse(Console.ReadLine());
//            array[i] = result[i];
//        }
//        Console.WriteLine();

//        int[] sorteddecs;
//        int[] sortedacs;
//        SortArray(in array, out sorteddecs, out sortedacs);

//        return result;
//     }

//    static int ChangeNum(ref int newnum)
//    {
//        Console.WriteLine("Введите количество элементов масива");
//        newnum = Convert.ToInt32(Console.ReadLine());

//        return newnum;
//    }

//    static void SortArray(in int[] array, out int[] sorteddecs, out int[] sortedacs)
//    {
//        sortedacs = SortArrayAsc(array);
//        Console.WriteLine();
//        sorteddecs = SortArrayDecs(array);
//    }

//    static int[] SortArrayAsc(int[] result)
//    {
//        int temp = 0;
//        for (int i = 0; i < result.Length; i++)
//            for (int j = i + 1; j < result.Length; j++)
//                if (result[i] > result[j])
//                {
//                    temp = result[i];
//                    result[i] = result[j];
//                    result[j] = temp;
//                }
//        for (int i = 0; i < result.Length; i++)
//        {
//            Console.WriteLine(result[i]);
//        }
//        return result;
//     }

//    static int[] SortArrayDecs(int[] result)
//    {
//        int temp = 0;
//        for (int i = 0; i < result.Length; i++)
//            for (int j = i + 1; j < result.Length; j++)
//                if (result[i] < result[j])
//                {
//                    temp = result[i];
//                    result[i] = result[j];
//                    result[j] = temp;
//                }
//        for (int i = 0; i < result.Length; i++)
//        {
//            Console.WriteLine(result[i]);
//        }
//        return result;
//    }
//}
// -------------------------------------------------------------------------------------------------

// 5.3.8 Передача в метод размерость массива по ссылке ---------------------------------------------
//class MainClass
//{

//    public static void Main(string[] args)

//    {
//        GetArrayFromConsole();
//    }

//    static int[] GetArrayFromConsole()
//    {
//        int num = 0;
//        ChangeNum(ref num);
//        var result = new int[num];

//        for (int i = 0; i < result.Length; i++)
//        {
//            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
//            result[i] = int.Parse(Console.ReadLine());
//        }
//        Console.WriteLine();
//        SortArray(result);

//        return result;
//    }

//    static int ChangeNum(ref int newnum)
//    {
//        Console.WriteLine("Введите количество элементов масива");
//        newnum = Convert.ToInt32(Console.ReadLine());

//        return newnum;
//    }

//    static int[] SortArray(int[] result)
//    {
//        int temp = 0;
//        for (int i = 0; i < result.Length; i++)
//            for (int j = i + 1; j < result.Length; j++)
//                if (result[i] > result[j])
//                {
//                    temp = result[i];
//                    result[i] = result[j];
//                    result[j] = temp;
//                }
//        for (int i = 0; i < result.Length; i++)
//        {
//            Console.WriteLine(result[i]);
//        }
//        return result;
//    }
//}


// -------------------------------------------------------------------------------------------------
//5.3.6 Использование ref и in

//class Program
//{
//	public static void Main(string[] args)
//	{
//		var arr = new int[] { 1, 2, 3 };
//		var data = 5; 

//		BigDataOperation(arr, ref data);

//		Console.WriteLine(arr[0]);

//		  Console.ReadKey();
//}

//	static void BigDataOperation(int[] arr, ref int data)
//	{
//		data = 7;
//		arr[0] = 14;
//	}
//}

// 5.3.2. Передача перемнной по ссылке -----------------------------------------------------------------
//namespace FirstApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var myAge = 30;

//            Console.WriteLine(myAge);

//            ChangeAge(ref myAge);

//            Console.WriteLine(myAge);

//            Console.ReadKey();
//        }

//        static void ChangeAge(ref int age)
//        {
//            Console.WriteLine("Введите возраст");
//            age = Convert.ToInt32(Console.ReadLine());
//        }
//    }
//}


// 5.2.8. ------------------------------------------------------------------------

//public static void Main(string[] args)
//{
//    GetArrayFromConsole();
//}

//    static int[] GetArrayFromConsole()
//    {
//        var result = new int[5];

//        for (int i = 0; i < result.Length; i++)
//        {
//            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
//            result[i] = int.Parse(Console.ReadLine());
//        }
//    Console.WriteLine();
//    SortArray(result);

//    return result;

//}

//static int[] SortArray(int[] result)
//    {
//        //var result = new int[5];
//        int temp = 0;
//        for (int i = 0; i < result.Length; i++)
//            for (int j = i + 1; j < result.Length; j++)
//                if (result[i] > result[j])
//                {
//                    temp = result[i];
//                    result[i] = result[j];
//                    result[j] = temp;
//                }
//        for (int i = 0; i < result.Length; i++)
//        {
//            Console.WriteLine(result[i]);
//        }
//        return result;
//    }

// -----------------------------------------------------------------------------------
//5.2.7 Массив с двумя параметрами ---------------------------------------------------
//static string ShowColor(string username, int userage)
//{
//    var color = Console.ReadLine();

//    switch (color)
//    {
//        case "red":
//            Console.BackgroundColor = ConsoleColor.Red;
//            Console.ForegroundColor = ConsoleColor.Black;

//            Console.WriteLine("Your color is red!");
//            break;

//        case "green":
//            Console.BackgroundColor = ConsoleColor.Green;
//            Console.ForegroundColor = ConsoleColor.Black;

//            Console.WriteLine("Your color is green!");
//            break;
//        case "cyan":
//            Console.BackgroundColor = ConsoleColor.Cyan;
//            Console.ForegroundColor = ConsoleColor.Black;

//            Console.WriteLine("Your color is cyan!");
//            break;
//        default:
//            Console.BackgroundColor = ConsoleColor.Yellow;
//            Console.ForegroundColor = ConsoleColor.Red;

//            Console.WriteLine("Your color is yellow!");
//            break;
//    }
//            return color;
//}

//{

//    var (name, age) = ("Евгения", 27);

//    Console.WriteLine("Мое имя: {0}", name);
//    Console.WriteLine("Мой возраст: {0}", age);

//    Console.Write("Введите имя: ");
//    name = Console.ReadLine();
//    Console.Write("Введите возраст с цифрами:");
//    age = Convert.ToInt32(Console.ReadLine());

//    var favcolors = new string[3];

//    for (int i = 0; i < favcolors.Length; i++)
//    {
//        Console.WriteLine("{0}, {1} лет", name, age);
//        Console.WriteLine("Введите любимый цвет :");
//        favcolors[i] = ShowColor(name, age);
//    }
//    Console.WriteLine("{0}, {1}", name, age);
//    Console.WriteLine("Ваши любимые цвета:");
//    foreach (var color in favcolors)
//    {
//        Console.WriteLine(color);
//    }

//    Console.ReadKey();
//}

// -----------------------------------------------------------------------------------
// 5.1.6 Ввод массива с клавиатуры + сортировка по возрастанию, выод на экран --------
//    GetArrayFromConsole();
//}
//static int[] GetArrayFromConsole()
//{
//    var result = new int[5];

//    for (int i = 0; i < result.Length; i++)
//    {
//        Console.WriteLine("Введите элемент массива номер {0}", i + 1);
//        result[i] = int.Parse(Console.ReadLine());
//    }
//    int temp = 0;
//    for (int i = 0; i < result.Length; i++)
//        for (int j = i + 1; j < result.Length; j++)
//            if (result[i] > result[j])
//            {
//                temp = result[i];
//                result[i] = result[j];
//                result[j] = temp;
//            }
//    for (int i = 0; i < result.Length; i++)
//    {
//        Console.WriteLine(result[i]);
//    }
//    return result;


// 5.1.5 Ввод 3 цветов, вывод на экран____________________________________________________________________________________
//class MainClass
//{

//    static string ShowColor()
//    {
//        Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
//        var color = Console.ReadLine();

//        switch (color)
//        {
//            case "red":
//                Console.BackgroundColor = ConsoleColor.Red;
//                Console.ForegroundColor = ConsoleColor.Black;

//                Console.WriteLine("Your color is red!");
//                break;

//            case "green":
//                Console.BackgroundColor = ConsoleColor.Green;
//                Console.ForegroundColor = ConsoleColor.Black;

//                Console.WriteLine("Your color is green!");
//                break;
//            case "cyan":
//                Console.BackgroundColor = ConsoleColor.Cyan;
//                Console.ForegroundColor = ConsoleColor.Black;

//                Console.WriteLine("Your color is cyan!");
//                break;
//            default:
//                Console.BackgroundColor = ConsoleColor.Yellow;
//                Console.ForegroundColor = ConsoleColor.Red;

//                Console.WriteLine("Your color is yellow!");
//                break;
//        }
//                return color;
//    }

//    public static void Main(string[] args)
//    {

//        var (name, age) = ("Евгения", 27);

//        Console.WriteLine("Мое имя: {0}", name);
//        Console.WriteLine("Мой возраст: {0}", age);

//        Console.Write("Введите имя: ");
//        name = Console.ReadLine();
//        Console.Write("Введите возрас с цифрами:");
//        age = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Ваше имя: {0}", name);
//        Console.WriteLine("Ваш возраст: {0}", age);

//        var favcolors = new string[3];

//        for (int i = 0; i < favcolors.Length; i++)
//        {
//            favcolors[i] = ShowColor();
//        }

//        //ShowColor();

//        Console.ReadKey();
//    }
//}




//Работа с кортежем
// ___________________________________________________________________

//(string Name, string[] favBludo) User;

//Console.WriteLine("Введите имя");
//User.Name = Console.ReadLine();

//User.favBludo = new string[5];
//Console.WriteLine("Введите 5 Ваших любимых блюд");
//for (int i = 0; i < User.favBludo.Length; i++)
//    {
//        User.favBludo[i] = Console.ReadLine();
//    }
//Console.WriteLine();

// -----------------------------------------------------------------

//int n;
//Console.WriteLine("Введите количество пользователей");
//n = Convert.ToInt32(Console.ReadLine());

//for (int k = 0; k < n ; k++)
//{
//    ;

//    Console.WriteLine("Введите имя");
//    User.Name1 = Console.ReadLine();

//    Console.WriteLine("Введите Фамилию");
//    User.Name2 = Console.ReadLine();

//    Console.WriteLine("Введите логин");
//    User.Login = Console.ReadLine();
//    User.LoginLenght = User.Login.Length;

//    Console.WriteLine("Есть ли у вас животные? Да или Нет");
//    var res = Console.ReadLine();
//    if (res == "Да")
//    {
//        User.Pet = true;
//    }
//    else
//    {
//        User.Pet = false;
//    }

//    Console.WriteLine("Введите возраст пользователя");
//    User.Age = double.Parse(Console.ReadLine());

//    User.favColors = new string[3];
//    Console.WriteLine("Введите три любимых цвета пользователя");
//    for (int i = 0; i < User.favColors.Length; i++)
//    {
//        User.favColors[i] = Console.ReadLine();
//    }
//    Console.WriteLine();
//}

// --------------------------------------------------------------------

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