////// Integer
//var M = int.Parse(Console.ReadLine());
//int Tonna;
//Tonna = M / 1000;
//Console.WriteLine(Tonna + "  tonna");

//// 3
//var bayt = int.Parse(Console.ReadLine());
//int Kbayt;
//Kbayt = bayt / 1024;
//Console.WriteLine(Kbayt + "  Kbayt");

// 6
//var ikkixonali = int.Parse(Console.ReadLine());
//int onlar = ikkixonali / 10;
//int birlar= ikkixonali % 10;
//Console.WriteLine($"onlar: {onlar}  birlar:  {birlar}");

// 7
//var ikkixonali = int.Parse(Console.ReadLine());
//int onlar = ikkixonali / 10;
//int birlar = ikkixonali % 10;
//Console.WriteLine($"yigindi: {onlar + birlar}  kopaytma:  {birlar * onlar}");

//8
//var ikkixonali = int.Parse(Console.ReadLine());
//int onlar = ikkixonali / 10;
//int birlar = ikkixonali % 10;
//Console.WriteLine($"hosil bolgan son {birlar * 10 + onlar}");

// 9
//var uchxona = int.Parse(Console.ReadLine());
//int yuzlarxonasi = uchxona / 100;
//Console.WriteLine(yuzlarxonasi);

//11
//var number = int.Parse(Console.ReadLine());
//int count = 0;
//int sum = 1;
//for  (int i = 0; i < 3; i++)
//{
//    count += number % 10;
//    sum *= number % 10;
//    number /= 10;
//}
//Console.WriteLine($"yigindisi  {count}  kopaytmasi  {sum}");

//12
//var uchxona = int.Parse(Console.ReadLine());
//int yuzlarxonasi = uchxona % 10;
//int onlarxonasi = uchxona / 10 % 10;
//int birlarxonasi = uchxona / 100;
//Console.WriteLine($"{yuzlarxonasi * 100 + onlarxonasi * 10 + birlarxonasi }");

// 19
//var vaqt = int.Parse(Console.ReadLine());
//int minut = vaqt / 60;
//Console.WriteLine($"O'tgan minut {minut} ");

//20
//var vaqt = int.Parse(Console.ReadLine());
//int soat = vaqt / 3600;
//Console.WriteLine($"O'tgan soat {soat} ");


//// Boolean
//var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
//bool toq = A[0] % 2 == 1;
//Console.WriteLine(toq);

// 6
//var burchak = Console.ReadLine().Split().Select(int.Parse).ToArray();
//int A = burchak[0];
//int B = burchak[1];
//int C = burchak[2];
//bool res = A <= B  && B <= C;
//Console.WriteLine(res);

////16
//int ikkixona = int.Parse(Console.ReadLine());
//bool ras = ikkixona > 9 && ikkixona < 100 && ikkixona % 2 == 0;
//Console.WriteLine(ras);

//17
//int ikkixona = int.Parse(Console.ReadLine());
//bool ras = ikkixona > 99 && ikkixona < 1000 && ikkixona % 2 == 1;
//Console.WriteLine(ras);


//// Boolean 36  Ruxning yuriwi
//var tomon = Console.ReadLine().Split().Select(int.Parse).ToArray();
//int a = tomon[0];
//int b = tomon[1];
//int c = tomon[2];
//int d = tomon[3];
//bool res = a == c || b == d;
//Console.WriteLine(res);

//// Boolean 37     Shohning yturiwi
//var tomon = Console.ReadLine().Split().Select(int.Parse).ToArray();
//int a = tomon[0];
//int b = tomon[1];
//int c = tomon[2];
//int d = tomon[3];
//bool res = Math.Abs(a - 1) == c || Math.Abs(b - 1) == d || Math.Abs(c - 1) == a || Math.Abs(d - 1) == b;
//Console.WriteLine(res);

//// Boolean 38     Filning yuriwi
//var tomon = Console.ReadLine().Split().Select(int.Parse).ToArray();
//int a = tomon[0];
//int b = tomon[1];
//int c = tomon[2];
//int d = tomon[3];
//bool res = Math.Abs(a - c) == Math.Abs(b - d);
//Console.WriteLine(res);

//// Boolean 39     Farzinning yuriwi
//var tomon = Console.ReadLine().Split().Select(int.Parse).ToArray();
//int a = tomon[0];
//int b = tomon[1];
//int c = tomon[2];
//int d = tomon[3];
//bool res = Math.Abs(a - c) == Math.Abs(b - d) || a == c|| b == d;
//Console.WriteLine(res);

//// Boolean 40  OTning yuriwi
//var tomon = Console.ReadLine().Split().Select(int.Parse).ToArray();
//int a = tomon[0];
//int b = tomon[1];
//int c = tomon[2];
//int d = tomon[3];
//bool res = Math.Abs(a - c) == 1 && Math.Abs(b - d) == 2 || Math.Abs(a - c) == 2 && Math.Abs(b - d) == 1;
//Console.WriteLine(res);


// If-else
//5
//var butun = Console.ReadLine().Split().Select(int.Parse).ToArray();
//int a = butun[0];
//int b = butun[1];
//int c = butun[2];
//if (a != 0 || b != 0 || c != 0)
//{
//    if (a > 0 &&  b > 0 && c > 0)
//    {
//        Console.WriteLine("3 ta musbat");
//    }
//    else if (a > 0 && b < 0 && c > 0 || a > 0 && b > 0 && c < 0 || a < 0 && b > 0 && c > 0)
//    {
//        Console.WriteLine(" 2 ta musbat  1 ta manfiy");
//    }
//    else if (a > 0 && b < 0 && c < 0 || a < 0 && b > 0 && c < 0 || a < 0 && b < 0 && c > 0)
//    {
//        Console.WriteLine("1 ta musbat 2 ta manfiy ");
//    }
//    else
//    {
//        Console.WriteLine("3 ta manfiy");
//    }
//}
//else
//{
//    Console.WriteLine("Iltimos 0 raqamini kiritmang");
//}

//// 7 
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//if (a > b)
//{
//    Console.WriteLine("kichigi 2 ");
//}
//else if (a < b)
//{
//    Console.WriteLine("kichigi 1 ");
//}
//else
//{
//    Console.WriteLine("bu sonlar teng");
//}

// 8
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//if ( a > b )
//{
//    Console.WriteLine("kattasi  " + a);
//    Console.WriteLine("kichikgi  " + b);
//}
//else if ( b > a )
//{
//    Console.WriteLine("kattasi  " + b);
//    Console.WriteLine("kichikgi  " + a);
//}
//else
//{
//    Console.WriteLine("bu sonlar afsuski teng");
//}


// 12
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());

//if (a == b && b != c || c == b && b != a || a == c && b != c)
//{
//    if (a >= b && b >= c || b >= a && b >= c && a >= c)
//    {
//        Console.WriteLine("kichigi : " + c);
//    }
//    else if (a <= b && b <= c || a <= b && c <= b && a <= c)
//    {
//        Console.WriteLine("kichigi : " + a);
//    }
//    else if (b <= a && a <= c || b <= a && c <= a && b <= a)
//    {
//        Console.WriteLine("kichigi : " + b);
//    }
//}
//else
//{
//    Console.WriteLine(" hamma son teng");
//}

// 13
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());

//Console.WriteLine((a + b + c) / 3);


// 14
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());

//if (a == b && b != c || c == b && b != a || a == c && b != c)
//{
//    if (a >= b && b >= c || b >= a && b >= c && a >= c)
//    {
//        Console.WriteLine("kichigi : " + c  + "kattasi  "  + a);
//    }  
//    else if (a <= b && b <= c || a <= b && c <= b && a <= c)
//    {
//        Console.WriteLine("kichigi : " + a + "kattasi  " + c);
//    }
//    else if (b <= a && a <= c || b <= a && c <= a && b <= a)
//    {
//        Console.WriteLine("kichigi : " + b + "kattasi  " + a);
//    }
//}
//else
//{
//    Console.WriteLine(" hamma son teng");
//}

// 30 
//int son = int.Parse(Console.ReadLine());
//if  (son > 9 &&  son < 100)
//{
//    if ((son % 2) == 0)
//    {
//        Console.WriteLine("ikki xonali juft son ");
//    }
//    else 
//    {
//        Console.WriteLine("ikki xonali toq son");
//    }
//}
//else if (son > 99 && son <1000)
//{
//    if (son % 2 == 0) 
//    {
//        Console.WriteLine("uchxonali juft son");
//    }
//    else
//    {
//        Console.WriteLine("uchxonali toq son");
//    }
//}
//else
//{
//    Console.WriteLine("bu son ikki va uch xonali emas");
//}