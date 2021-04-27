using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
class  MyExecption:ApplicationException
{
    public void  MyExecption()
    {
 Console.WriteLine("An Exception Occured");       
}
public void MyDivideException()
{
    Console.Writeline("Exception Occured,divisor should not be zero");
}
}
class Class4
{
    public static void Main()
    {
        int x = 5, y =0, z;
        try
        {
            if(y==0)
            {
                throw new MyException();
            }
        }
        catch(MyException ex)
        {
            ex.MyDivideException;
        }
        Console.ReadLine();
    }
}
}