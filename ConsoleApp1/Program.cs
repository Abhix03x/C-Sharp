using C;
using ConsoleApp1;
using System.Xml.Schema;

class Test
{
    void sub()
    {
        int a, b;
        double d = 0;
        Console.WriteLine("enter the first no");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the second number");
        b = Convert.ToInt32(Console.ReadLine());
        d = (double)a - b;
        Console.WriteLine(d);
    }
    void add()
    {
        int a, b;
        double d = 0;
        Console.WriteLine("enter the first no");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the second number");
        b = Convert.ToInt32(Console.ReadLine());
        d = (double)a + b;
        Console.WriteLine(d);
    }
    void div()
    {
        int a, b;
        double d = 0;
        Console.WriteLine("enter the first no");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the second number");
        b = Convert.ToInt32(Console.ReadLine());
        d = (double)a / b;
        Console.WriteLine(d);
    }
    void mul()
    {
        int a, b;
        double d = 0;
        Console.WriteLine("enter the first no");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the second number");
        b = Convert.ToInt32(Console.ReadLine());
        d = (double)a * b;
        Console.WriteLine(d);
    }
    public static void Main(string[] args)
    {
        //Test obj = new Test();
        //obj.sub();
        //obj.add();
        //obj.div();
        //obj.mul();
        //Pattern P = new Pattern();
        //P.pattern();
        //P.pattern1();
        //P.pattern2();
        //P.pattern3();
        //P.pattern4();
        //Sstring s = new Sstring();
        //s.fibonacci();
        //s.prime();
        //s.factorial();
        //s.reverse();
        //s.multable();
        //s.palindrome(); 
        //Numb n = new Numb();
        //n.multiple();
        //n.interchange();
        //n.swap();
        //n.arms();
        //n.sumrange();
        //Aarray a = new Aarray();
        //a.search();
        //a.sum();

        //int a = Convert.ToInt32(Console.ReadLine());
        //int b = Convert.ToInt32(Console.ReadLine());
        //Funct f = new Funct();
        //f.sum(a, b);
        //Arraysort a = new Arraysort();
        //a.sort();
        //Arraysum s = new Arraysum();
        //s.sum();
        //Frequency s = new Frequency();
        //s.frequency();
        //TwoD_Array d = new TwoD_Array();
        //d._2d();
        //Matrix_sum s = new Matrix_sum();
        //s.sum();
        //Matrix_mul m = new Matrix_mul();
        //m.mul();
        //Transpose t = new Transpose();
        //t.transpose();
        //-----------------Factorial using recursion--------------------
        //Console.WriteLine("enter the number");
        //int n =Convert.ToInt32(Console.ReadLine());
        //int fact = Factorial_rec.fact(n);
        //Console.WriteLine($"the factorial is {fact}");
        //-----------------simple calculator using function--------------------
        //Console.WriteLine("enter the numbers");
        //int n=Convert.ToInt32(Console.ReadLine());
        //int m=Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("enter choice");
        //Console.WriteLine("1.Add\n2.Sub\n3.Mul\n4.Div");
        //int choice = Convert.ToInt32(Console.ReadLine());
        //double result = 0;
        //switch (choice) {
        //    case 1:
        //        result = Simple_calc.add(n, m); break;
        //    case 2:
        //        result = Simple_calc.sub(n, m); break;
        //    case 3:
        //        result=Simple_calc.mul(n, m);break;
        //    case 4:
        //        result =Simple_calc.div(n, m); break;
        //    default:
        //        Console.WriteLine("enter a valid option");
        //        break;
        //}
        //Console.WriteLine($"Result :{result}");
        //-----------------parametrized--------------------
        //int[] arr = new int[5];
        //Console.WriteLine("enter the elements");
        //int i;
        //for (i = 0; i < arr.Length; i++)
        //{
        //    arr[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //int sum = Parametrized.sum(arr);
        //Console.WriteLine($"{sum}");
        //-----------------Reverse of a number using constructor--------------------
        //Const_rev s = new Const_rev();
        //Console.WriteLine(s.rev);
        //-----------------Sum of digits using constructor--------------------
        //Const_digit s= new Const_digit();
        //-----------------Simple calc using constructor--------------------
        //Const_calc s = new Const_calc();
        //Digit d = new Digit();
        //-----------------calculator--------------------
        //Calculator c = new Calculator(); 
        //Fun_eg.Start();
        //----------------- inheritance--------------------
        //Inheritance.child m = new Inheritance.child();
        //m.msg();
        //m.reply();
        //-----------------Multi level inheritance--------------------
        //Multilv_inh.A3 a = new Multilv_inh.A3();
        //a.Work();
        //a.study();
        //a.run();
        //-----------------Heirarchial inheritance--------------------
        //Heirar_inh.A2 m=new Heirar_inh.A2();
        //m.read();
        //m.sum();
        //Heirar_inh.A3 s=new Heirar_inh.A3();
        //s.read();
        //s.product();
        //-----------------Multiple inheritance--------------------
        //Console.WriteLine("enter the nos");
        //int a=Convert.ToInt32(Console.ReadLine());
        //int b=Convert.ToInt32(Console.ReadLine());
        //Mul_inh.mul_inh m = new Mul_inh.mul_inh();
        //m.sum(a,b);
        //int rslt = m.product();
        //Console.WriteLine(rslt);
        //------------------Abstract class-------------------
        //Abstcs n = new Abstcs();
        //n.display();
        //n.abmethod();
        //Console.ReadKey();
        //------------------Sealed class-------------------
        //Sealed s=new Sealed();
        //s.run();
        //------------------Function overloading-------------------
        //Fun_ovl f = new Fun_ovl();
        //f.sum();
        //int a, b;
        //double c, d;
        //Console.WriteLine("ENTER the int values");
        //a = Convert.ToInt32(Console.ReadLine());
        //b = Convert.ToInt32(Console.ReadLine());
        //int s = f.sum(a,b);
        //Console.WriteLine(s);
        //Console.WriteLine("Enter the double values");
        //c = Convert.ToDouble(Console.ReadLine());
        //d =Convert.ToDouble(Console.ReadLine());
        //double h = f.sum(c,d);
        //Console.WriteLine(h);
        //------------------Function overriding-------------------
        //Fun_ovr n = new Fun_ovr();
        //n.display();
        //------------------Collection Classes-------------------
        //ArrayListeg n = new ArrayListeg();
        //n.arrayList();
        //HashTableeg h = new HashTableeg();
        //h.hashTable();
        //SortedListEg s = new SortedListEg();
        //s.sortedlist();
        nonGenericCollection n=new nonGenericCollection();
        n.arrayList();
        n.hashtable();
        n.queue();
        n.stack();











    }
}
