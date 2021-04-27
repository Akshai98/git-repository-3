using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
class Program
{
    public void Main()
    {
        int x =1;
        int y;
        try 
        {
            y = x/0;
            Console.Write(y);
            
        }
        catch 
        {
            Console.WriteLine("some error");
        }
        Console.ReadLine();
    }
}
}