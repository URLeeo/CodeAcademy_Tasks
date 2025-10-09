#region C# Introduction

#region Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.

//Console.ForegroundColor = ConsoleColor.Cyan;
//Console.WriteLine("Ededi daxil edin:");
//Console.ResetColor();
//int n = Convert.ToInt32(Console.ReadLine());
//if (n % 3 == 0 && n % 7 == 0)
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine("Eded 3 e ve 7 ye qaliqsiz bolunur.");
//    Console.ResetColor();
//}
//else
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Eded 3 e ve 7 ye qaliqsiz bolunmur.");
//    Console.ResetColor();
//}

#endregion

#region n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.

//Console.ForegroundColor = ConsoleColor.Cyan;
//Console.WriteLine("Birinci ededi daxil edin:");
//Console.ResetColor();

//int n = Convert.ToInt32(Console.ReadLine());

//Console.ForegroundColor = ConsoleColor.Cyan;
//Console.WriteLine("Ikinci ededi daxil edin:");
//Console.ResetColor();

//int m = Convert.ToInt32(Console.ReadLine());

//if (n % 2 == 0 && m % 2 == 0)
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine($"Ededlerin cemi: {n + m}");
//    Console.ResetColor();
//}
//else
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Ededlerden en az biri cut deyil.");
//    Console.ResetColor();
//}

#endregion

#region Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.

//Console.ForegroundColor = ConsoleColor.Cyan;
//Console.WriteLine("Birinci ededi daxil edin:");
//Console.ResetColor();

//int n = Convert.ToInt32(Console.ReadLine());

//Console.ForegroundColor = ConsoleColor.Cyan;
//Console.WriteLine("Ikinci ededi daxil edin:");
//Console.ResetColor();

//int m = Convert.ToInt32(Console.ReadLine());

//int sum = 0;
//if (n < m)
//{
//    for (int i = n+1; i < m; i++)
//    {
//        if (i % 2 != 0)
//        {
//            sum += i;
//        }
//    }
//    if (sum == 0)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Verdiyiniz araliqda her hansi tek eded yerlesmir.");
//        Console.ResetColor();
//    }
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine($"Tek ededlerin cemi: {sum}");
//    Console.ResetColor();
//}
//else
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("n ededi m ededinden kicik olmalidir.");
//    Console.ResetColor();
//}

#endregion

#region Verilmish arrayin icindeki tek ededlerin cemini tapin.

//Console.ForegroundColor = ConsoleColor.Cyan;
//Console.Write("Arrayin element sayini daxil edin: ");
//Console.ResetColor();

//int n = Convert.ToInt32(Console.ReadLine());
//int[] numbers = new int[n];

//for (int i = 0; i < n; i++)
//{
//    Console.ForegroundColor = ConsoleColor.Yellow;
//    Console.Write($"Element {i + 1}-i daxil edin: ");
//    Console.ResetColor();
//    numbers[i] = Convert.ToInt32(Console.ReadLine());
//}

//int sum = 0;
//bool hasOdd = false;

//for (int j = 0; j < n; j++ )
//{
//    if (numbers[j] % 2 != 0)
//    {
//        sum += numbers[j];
//        hasOdd = true;
//    }
//}

//if (hasOdd)
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine($"Arraydaki tek ededlerin cemi: {sum}");
//}
//else
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Arrayda hec bir tek eded yoxdur!");
//}
//Console.ResetColor();

#endregion

#region Verilmish arrayin icindeki cut ededlerin sayini tapin.
//Console.ForegroundColor = ConsoleColor.Cyan;
//Console.Write("Arrayin element sayini daxil edin: ");
//Console.ResetColor();

//int n = Convert.ToInt32(Console.ReadLine());
//int[] numbers = new int[n];

//for (int i = 0; i < n; i++)
//{
//    Console.ForegroundColor = ConsoleColor.Yellow;
//    Console.Write($"Element {i + 1}-i daxil edin: ");
//    Console.ResetColor();
//    numbers[i] = Convert.ToInt32(Console.ReadLine());
//}

//int sum = 0;
//bool hasEven = false;

//for (int j = 0; j < n; j++)
//{
//    if (numbers[j] % 2 == 0)
//    {
//        sum += numbers[j];
//        hasEven = true;
//    }
//}

//if (hasEven)
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine($"Arraydaki tek ededlerin cemi: {sum}");
//}
//else
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Arrayda hec bir tek eded yoxdur!");
//}
//Console.ResetColor();
#endregion

#endregion