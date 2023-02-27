using eMyBigNumber.Application.Class;
using eMyBigNumber.Application.Interface;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap stn1: ");
       string stn1=Console.ReadLine();
        Console.WriteLine("Nhap stn2 ");
        string stn2 = Console.ReadLine();
        var request = new MyBigNumber()
        {
            Stn1 = stn1,
            Stn2 = stn2,
        };
        IBigNumber sum = new BigNumber();
        sum.Sum(request); 
    }
}