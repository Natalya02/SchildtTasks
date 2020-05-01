// Try to use Exception
using System;

public class ExceptionTest
{
    int[] i = new int[2];
    int[] j = new int[4];

    decimal div;

    public void show()
    {
        for (int a = 0; a < 2; a++)
            {
            Console.WriteLine("i = " + i[a]);
            }
        for (int a = 0; a < 4; a++)
        {
            Console.WriteLine("j = " + j[a]);
        }

        Console.WriteLine("div = " + div);
    }

    public ExceptionTest(int inum, int jnum) // It can generate exeption
    {
        for (int a = 0; a<2; a++)
        {
            i[a] = a;
        }

        for (int a = 0; a < 4; a++)
        {
            j[a] = a;
        }

        div = i[inum] / j[jnum];
    }

    public ExceptionTest()
    {
        for (int a = 0; a < 2; a++)
        {
            i[a] = a;
        }

        for (int a = 0; a < 4; a++)
        {
            j[a] = a;
        }

        div = 0;
    } 
}

class ExceptionDemo
{
    static void Main()
    {
        try
        {
            ExceptionTest A = new ExceptionTest();
            Console.WriteLine("Object A"); A.show();
            ExceptionTest B = new ExceptionTest(1,2) ;
            Console.WriteLine("Object B"); B.show();
            ExceptionTest B1 = new ExceptionTest(1, 0);
            Console.WriteLine("Object B1"); B1.show();
            ExceptionTest C = new ExceptionTest(5, 9);
            Console.WriteLine("Object C"); C.show();
            ExceptionTest D = new ExceptionTest(1, 3);
            Console.WriteLine("Object D"); D.show();

            
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Its imposible divide by zero");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("IndexOutOfRangeException");
        }

        Console.ReadLine();
    }
}