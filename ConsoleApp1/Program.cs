
using ConsoleApp2;

namespace ConsoleApp1
{

	interface IShape
	{
		void Area(int h, int w);
		void Perimeter(params int[] a);
	}

	class Rectangle : IShape
	{
		public void Area(int h, int w) => Console.WriteLine(h * w);
		public void Perimeter(params int[] a) => Console.WriteLine((a[0] + a[1]) * 2);
	}

	class Traingle : IShape
	{
		public void Area(int h, int w) => Console.WriteLine(h * w / 2);

		public void Perimeter(params int[] a) => Console.WriteLine(a[0] + a[1] + a[2]);
	}

	class Squre : IShape
	{
		public void Area(int h, int w = 0) => Console.WriteLine(h * h);
		public void Perimeter(params int[] a) => Console.WriteLine(a[0] * 4);
	}


	class Program
	{
		static void Main(string[] args)
		{
			IShape shape = new Rectangle();
			shape.Area(5, 1);	
		}
	}
}





#region Inheritance
//class H
//{
//	private int Id { get; set; }
//	public string Name { get; set; }
//	public int Age { get; set; }
//	public string color { get; set; }

//	public virtual void print()
//	{
//		Console.WriteLine("H");
//	}
//	//public  void print()
//	//{
//	//	Console.WriteLine("H");
//	//}

//}
//class P : H
//{
//	private string eyecolor { get; set; }
//	public override void print()
//	{
//		base.print();
//		Console.WriteLine("P");
//	}
//	//public void print()
//	//{
//	//	//base.print();
//	//	Console.WriteLine("P");
//	//}

//}
//class Child : P
//{
//	public override void print()
//	{
//		base.print();
//		Console.WriteLine("C");
//	}
//	//public void print()
//	//{
//	//	base.print();
//	//	Console.WriteLine("C");
//	//}
//	/*
//	 static void Main(string[] args)
//	{

//		//Child child = new Child();//HPC
//		//child.print();//C==>C
//		//Console.WriteLine("==========================");
//		//P Pchild = new Child();//HPC
//		//Pchild.print();//P===>C
//		//Console.WriteLine("==========================");

//		//H Hchild = new Child();//HPC
//		//Hchild.print();//H==C
//		//Console.WriteLine("==========================");

//		//{لو عامل اوفر رايد هياخد الميثود اللي في الابن لو مش عامل هياخد الي ف الاب}

//		H Hchild = new Child();
//		Hchild.print();//	
//		P Pchild = new Child();
//		Pchild.print();// 
//	}
//	 */
//}
#endregion
#region Class Area
class Area
{
	//	//member
	//	///1- Field 
	//	///2- Method  
	//	///3- Constractor ==> this
	//	///4- Property

	//	/// Access Modifiers




	//	private  int x;

	//	private string name;

	//	public string Name
	//	{
	//		get { return name; }
	//		set { name = value; }
	//	}
	//	/*
	//	 string fristName
	//	 public string FristName
	//	{
	//		get { return fristName; }
	//		set { fristName = value; }
	//	}
	//	 */
	//	public string FristName { get; set; }






	//	public void SetName(string name)=>this.name = name;
	//	//public void GetName() => Console.WriteLine(name);	
	//	public string GetName()=> name;



	//	public void Print() => Console.WriteLine(name+x);  // 11 10
	//	public Area() {} 
	//	public Area(string name) => this.name = name;
	//	public Area(int x,string name) : this(name)=> this.x = x;

	//	///Main{
	//	//Area area = new Area(10,"11");
	//	//Area area = new Area("11");
	//	/*Area a = new Area();
	//	a.Name = Console.ReadLine();
	//		Console.WriteLine(a.Name);
	//		a.FristName = Console.ReadLine();
	//		Console.WriteLine(a.FristName);
	//		a.SetName(Console.ReadLine());
	//		Console.WriteLine(a.GetName());
	//		//a.Print();*/
	//	///}
}
#endregion
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

//static void Sum(int name1, int name2) => Console.WriteLine(name1 + name2);
//static void Sub(int name1, int name2) => Console.WriteLine(name1 - name2);
//static void Mul(int name1, int name2) => Console.WriteLine(name1 * name2);
//static void Div(int name1, int name2) => Console.WriteLine(name2 > 0 ? name1 / name2 : throw new DivideByZeroException());


//static int Sum(int name1, int name2) => name1 + name2;
//static int Sub(int name1, int name2) => name1 - name2;
//static int Mul(int name1, int name2) => name1 * name2;
//static int Div(int name1, int name2) => name2 > 0 ? name1 / name2 : throw new DivideByZeroException();

////////Main
//Console.WriteLine(Sum(5, 4));
//Console.WriteLine(Sub(5, 4));
//Console.WriteLine(Mul(5, 4));
//Console.WriteLine(Div(5, 4));



#endregion
#region Array

//int[] name = new int[500];

//for (int i = 0; i < 500; i++)
//{
//	Console.Write(value: $"Enter nameber {i + 1} : ");
//	name[i] = int.Parse(Console.ReadLine());
//}

//int sum = 0;
//for (int i = 0; i < 500; i++) sum = sum + name[i];
//Console.WriteLine(sum);



//Console.Write($"Enter nameber : ");
//int name1 = int.Parse(Console.ReadLine());
//Console.Write($"Enter nameber : ");
//int name2 = int.Parse(Console.ReadLine());
//Console.Write($"Enter nameber : ");
//int name3 = int.Parse(Console.ReadLine());
//Console.Write($"Enter nameber : ");
//int name4 = int.Parse(Console.ReadLine());
//Console.Write($"Enter nameber : ");
//int name5 = int.Parse(Console.ReadLine());
//Console.Write($"Enter nameber : ");
//int name6 = int.Parse(Console.ReadLine());
//Console.Write($"Enter nameber : ");
//int name7 = int.Parse(Console.ReadLine());
//Console.Write($"Enter nameber : ");
//int name8 = int.Parse(Console.ReadLine());
//Console.Write($"Enter nameber : ");
//int name9 = int.Parse(Console.ReadLine());
//Console.Write($"Enter nameber : ");
//int name10 = int.Parse(Console.ReadLine());

//Console.WriteLine(name10 + name9 + name8 + name7 + name6 + name5 + name4 + name3 + name2 + name1);





//Console.Write("Enter nameber : ");
//name[0]=int.Parse(Console.ReadLine());
//Console.WriteLine(name[0]);

//Console.WriteLine(name[1]);


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
//Console.Write("enter nameber : ");
//byte nameofday = byte.Parse(Console.ReadLine());
//switch (nameofday)
//{
//	case 1: Console.WriteLine("1"); break;
//	case 2: Console.WriteLine("2"); break;
//	case 3: Console.WriteLine("3"); break;
//	case 4: Console.WriteLine("4"); break;
//	case 5: Console.WriteLine("5"); break;
//	case 6: Console.WriteLine("6"); break;
//	case 7: Console.WriteLine("7"); break;
//	default: Console.WriteLine("enter invaild nameber !!!!"); break;
//}

//if (nameofday == 1) Console.WriteLine(1);
//else if (nameofday == 2) Console.WriteLine(2);
//else if (nameofday == 3) Console.WriteLine(3);
//else if (nameofday == 4) Console.WriteLine(4);
//else if (nameofday == 5) Console.WriteLine(5);
//else if (nameofday == 6) Console.WriteLine(6);
//else if (nameofday == 7) Console.WriteLine(7);
//else Console.WriteLine("enter invaild nameber !!!!");
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
//int name1 = int.Parse(Console.ReadLine());
//Console.Write("Enter Number 2 : ");
//int name2 = int.Parse(Console.ReadLine());
//Console.Write("Enter Number 3 : ");
//int name3 = int.Parse(Console.ReadLine());
//Console.Write("Enter Number 4 : ");
//int name4 = int.Parse(Console.ReadLine());
//Console.WriteLine(Math.Max(name1,Math.Max(name2,Math.Max(name3,name4))));




//if (name1 % 3 == 0 && name1 % 7 == 0)
//	Console.WriteLine(name1);




//int x=name1 > name2 ? name1: name2>name1?name2:name1;
//Console.WriteLine(x);


//Console.WriteLine(Math.Max(name1,name2));


//Console.Write("Enter Number 1 : ");
//int name1 = int.Parse(Console.ReadLine());
//Console.Write("Enter Number 2 : ");
//int name2 = int.Parse(Console.ReadLine());

//if (name1 > name2)
//{
//    Console.WriteLine(name1);
//}
//else if (name1 < name2)
//{
//    Console.WriteLine(name2);
//}
//else
//{
//    Console.WriteLine("==");
//}



//if (name1 > name2)
//{
//	Console.WriteLine(name1);
//}

//if (name1 < name2)
//{
//	Console.WriteLine(name2);
//}

//if (name1 == name2)
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
