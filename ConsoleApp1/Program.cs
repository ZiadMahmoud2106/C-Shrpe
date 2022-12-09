using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{

	class Area
	{
		//member
		///1- Field 
		///2- Method  
		///3- Constractor
		///4- Property
	
		

	}


    class Program
	{
		static void Main(string[] args)
		{

		}
	}
}



#region OverLoding
//static void Area(int w=5, int h=5) => Console.WriteLine(w * h);
///// Main 
//Area(h: 6, w: 10);



////////////////////////////////////////////////////////////////////
// static void Area(int w,int h)=> Console.WriteLine(w * h);
// static void Area(int l)=> Console.WriteLine(l * l);
// static void Area(double r)=> Console.WriteLine(Math.PI * Math.Pow(r, 2));
// static void Area(float w, float h) => Console.WriteLine(w * h/2);

///// Main 
//Area(5,5);
//Area(5);
//Area(5.0);
//Area(5.0f,5.0f);

#endregion
#region Method

/// => Arrow Function (لو الكود اللي بعد الميثود هيكون سطر واحد بس )

//static void Sum(int num1, int num2) => Console.WriteLine(num1 + num2);
//static void Sub(int num1, int num2) => Console.WriteLine(num1 - num2);
//static void Mul(int num1, int num2) => Console.WriteLine(num1 * num2);
//static void Div(int num1, int num2) => Console.WriteLine(num2 > 0 ? num1 / num2 : throw new DivideByZeroException());


//static int Sum(int num1, int num2) => num1 + num2;
//static int Sub(int num1, int num2) => num1 - num2;
//static int Mul(int num1, int num2) => num1 * num2;
//static int Div(int num1, int num2) => num2 > 0 ? num1 / num2 : throw new DivideByZeroException();

////////Main
//Console.WriteLine(Sum(5, 4));
//Console.WriteLine(Sub(5, 4));
//Console.WriteLine(Mul(5, 4));
//Console.WriteLine(Div(5, 4));



#endregion
#region Array

//int[] num = new int[500];

//for (int i = 0; i < 500; i++)
//{
//	Console.Write(value: $"Enter number {i + 1} : ");
//	num[i] = int.Parse(Console.ReadLine());
//}

//int sum = 0;
//for (int i = 0; i < 500; i++) sum = sum + num[i];
//Console.WriteLine(sum);



//Console.Write($"Enter number : ");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write($"Enter number : ");
//int num2 = int.Parse(Console.ReadLine());
//Console.Write($"Enter number : ");
//int num3 = int.Parse(Console.ReadLine());
//Console.Write($"Enter number : ");
//int num4 = int.Parse(Console.ReadLine());
//Console.Write($"Enter number : ");
//int num5 = int.Parse(Console.ReadLine());
//Console.Write($"Enter number : ");
//int num6 = int.Parse(Console.ReadLine());
//Console.Write($"Enter number : ");
//int num7 = int.Parse(Console.ReadLine());
//Console.Write($"Enter number : ");
//int num8 = int.Parse(Console.ReadLine());
//Console.Write($"Enter number : ");
//int num9 = int.Parse(Console.ReadLine());
//Console.Write($"Enter number : ");
//int num10 = int.Parse(Console.ReadLine());

//Console.WriteLine(num10 + num9 + num8 + num7 + num6 + num5 + num4 + num3 + num2 + num1);





//Console.Write("Enter number : ");
//num[0]=int.Parse(Console.ReadLine());
//Console.WriteLine(num[0]);

//Console.WriteLine(num[1]);


#endregion
#region Continue && break
//for (int i = 1; i < 25; i++)
//{
//	//if (!(i % 3 == 0 && i % 7 == 0))   //	continue
//	//	Console.WriteLine(i);


//	//if (i % 3 == 0 && i % 7 == 0)
//	//	continue;


//	//if (i % 3 == 0 && i % 7 == 0)
//	//	break;




//	//if (i % 3 == 0 && i % 7 == 0)
//	//{
//	//	continue;
//	//	Console.WriteLine(22);
//	//}

//	//if (i % 3 == 0 && i % 7 == 0)
//	//	continue;
//	//Console.WriteLine(i);


//}
#endregion
#region Math

//Console.WriteLine(Math.Ceiling(2.1));//3
//Console.WriteLine(Math.Ceiling(2.4));//3
//Console.WriteLine(Math.Ceiling(2.5));//3
//Console.WriteLine(Math.Ceiling(2.9));//3


//Console.WriteLine(Math.Floor(2.1));//2
//Console.WriteLine(Math.Floor(2.4));//2
//Console.WriteLine(Math.Floor(2.5));//2
//Console.WriteLine(Math.Floor(2.9));//2



//Console.WriteLine(Math.Pow(2,3));// 2 ^ 3=8
//Console.WriteLine(Math.Sqrt(9)); // 9 ^ 0.5=3

//Console.WriteLine(Math.Sin(30*(Math.PI/180)));
//Console.WriteLine(Math.Cos(30*(Math.PI/180)));
//Console.WriteLine(Math.Tan(45*(Math.PI/180)));


//Console.WriteLine(Math.Abs(-1));//1
//Console.WriteLine(Math.Max(5,9));//9
//Console.WriteLine(Math.Min (5,9));//5
//Console.WriteLine(Math.PI );//3.141592653589793



#endregion
#region LOOOOP

// for
// While
// do while
// foreach


//01234
//string x = Console.ReadLine();

//for (int i = 0; i <x.Length ; i+=1)
//	Console.WriteLine(x[i]);

//Console.WriteLine(11);



//string x = Console.ReadLine();  
//foreach (int x1 in x)
//	Console.Write((char)(x1-32));



//for (int i = 1; i <= 6; i+=1)
//	Console.WriteLine(i);

//int i = 10;
//do
//{
//	Console.WriteLine(1);
//	i--;
//} while (i>5);


//int i = 1;
//while (i == 6)
//{
//	Console.WriteLine(i);
//	i += 1;
//}


//int x = 5;
//Console.WriteLine(x=x+1); // x=x+1  ==> x++ ==> x+=1


#endregion
#region Switch
//Console.Write("enter number : ");
//byte numofday = byte.Parse(Console.ReadLine());
//switch (numofday)
//{
//	case 1: Console.WriteLine("1"); break;
//	case 2: Console.WriteLine("2"); break;
//	case 3: Console.WriteLine("3"); break;
//	case 4: Console.WriteLine("4"); break;
//	case 5: Console.WriteLine("5"); break;
//	case 6: Console.WriteLine("6"); break;
//	case 7: Console.WriteLine("7"); break;
//	default: Console.WriteLine("enter invaild number !!!!"); break;
//}

//if (numofday == 1) Console.WriteLine(1);
//else if (numofday == 2) Console.WriteLine(2);
//else if (numofday == 3) Console.WriteLine(3);
//else if (numofday == 4) Console.WriteLine(4);
//else if (numofday == 5) Console.WriteLine(5);
//else if (numofday == 6) Console.WriteLine(6);
//else if (numofday == 7) Console.WriteLine(7);
//else Console.WriteLine("enter invaild number !!!!");
#endregion
#region Double

//Console.Write("Enter 1st Number: ");
//double Number2 = double.Parse(Console.ReadLine());
//Console.Write("Enter 2nd Number: ");
//double Number = double.Parse(Console.ReadLine());

//double Sum = Number2 + Number;
//double sub = Number2 - Number;
//double Mul = Number2 * Number;
//double Div = Number2 / Number;

//Console.WriteLine("Sum= " + Sum);
//Console.WriteLine("Sub= {0}", sub);
//Console.WriteLine($"Mul = {Mul}");
//Console.WriteLine("Div" + Div);

#endregion
#region Console.Write

//int x = 5;
//int y = 50;

//Console.WriteLine("{0},{1}",x,y);
//Console.WriteLine($"{x},{y}");
//Console.WriteLine(x+","+y);
#endregion
#region If Math.Max

//Console.Write("Enter Number 1 : ");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Enter Number 2 : ");
//int num2 = int.Parse(Console.ReadLine());
//Console.Write("Enter Number 3 : ");
//int num3 = int.Parse(Console.ReadLine());
//Console.Write("Enter Number 4 : ");
//int num4 = int.Parse(Console.ReadLine());
//Console.WriteLine(Math.Max(num1,Math.Max(num2,Math.Max(num3,num4))));




//if (num1 % 3 == 0 && num1 % 7 == 0)
//	Console.WriteLine(num1);




//int x=num1 > num2 ? num1: num2>num1?num2:num1;
//Console.WriteLine(x);


//Console.WriteLine(Math.Max(num1,num2));


//Console.Write("Enter Number 1 : ");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Enter Number 2 : ");
//int num2 = int.Parse(Console.ReadLine());

//if (num1 > num2)
//{
//    Console.WriteLine(num1);
//}
//else if (num1 < num2)
//{
//    Console.WriteLine(num2);
//}
//else
//{
//    Console.WriteLine("==");
//}



//if (num1 > num2)
//{
//	Console.WriteLine(num1);
//}

//if (num1 < num2)
//{
//	Console.WriteLine(num2);
//}

//if (num1 == num2)
//{
//	Console.WriteLine("==");
//}



#endregion
#region String


//           //0123
//string dd = "ziad";

//Console.WriteLine(dd+"1");

//char z = 'z';
//char i = 'i';
//char a = 'a';
//char d = 'd';


//Console.WriteLine(z + "" + i + "" + a + "" + d+"2");
//Console.WriteLine($"{z}{i}{a}{d}3");



//char z1 = dd[3];
//Console.WriteLine(z1);


//Console.WriteLine((char)(z + i + a + d));

//Console.WriteLine((char)(a-32));
//Console.WriteLine(z);




#endregion
