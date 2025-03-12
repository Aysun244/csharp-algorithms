//int num = 73;
//if (num % 2 == 0)
//{
//    Console.WriteLine("Eded cut ededdir");
//}
//else
//{
//    Console.WriteLine("Eded tek ededdir");
//}

//string Username = "Admin", Password = "Admin123";
//if (Username == "Admin" && Password == "Admin123")
//{
//    Console.WriteLine("Xosh gelmisiniz");
//}
//else
//{
//    Console.WriteLine("Username ve ya password yanlisdir!");
//}

//int num = 124, num1 = 8;
//if (num % 2 == 0 && num1 % 2 == 0)
//{
//    Console.WriteLine(num + num1);
//}
//else
//{
//    Console.WriteLine("daxil olunan ededler cut olmalidir!");
//}

//int num = 76;
//if (num >= 91 && num <= 100)
//{
//    Console.WriteLine("A");
//}
//else if (num >= 81 && num <= 90)
//{
//    Console.WriteLine("B");
//}
//else if (num >= 71 && num <= 80)
//{
//    Console.WriteLine("C");
//}
//else if (num >= 61 && num <= 70)
//{
//    Console.WriteLine("D");
//}
//else if (num >= 51 && num <= 60)
//{
//    Console.WriteLine("E");
//}
//else
//{
//    Console.WriteLine("Terbrikler kesilmisiniz!");
//}

//int numA = 10, numB = 2245, numC = 42;
//int sum = 0;
//if (numA % 5 == 0) sum += numA;
//if (numB % 5 == 0) sum += numB;
//if (numC % 5 == 0) sum += numC;
//if (sum == 0)
//{
//    Console.WriteLine("Hec bir eded 5e tam bolunmur");
//}
//else
//{
//    Console.WriteLine(sum);
//}

//int num =29;
//int b = num;
//int a;
//num %= 10;
//a = (b - num) / 10;
//if (a > num)
//{
//    Console.WriteLine("Onluq mertebe vahidi boyukdu");
//}
//else
//{
//    Console.WriteLine("Teklik mertebe vahidi boyukdur");
//}

int n = 10;
int a = 1, b = 1, sum = 0;
for (int i=0; i<n; i++)
{
    sum += a;
    int num = a + b;
    a = b;
    b = num;

}
{
    Console.WriteLine("Cem" + sum);
}
