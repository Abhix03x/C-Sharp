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
        Transpose t = new Transpose();
        t.transpose();


    }
}
