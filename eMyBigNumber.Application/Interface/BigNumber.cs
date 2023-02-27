using eMyBigNumber.Application.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMyBigNumber.Application.Interface
{
    public class BigNumber : IBigNumber
    {
        public void Sum(MyBigNumber request)
        {
            
            int stn1 = int.Parse(request.Stn1);
            int stn2 = int.Parse(request.Stn2);
            int sum = 0;


            Console.WriteLine($"Cac buoc tinh tong {stn1} + {stn2}:");
            
            int place = 1;

            while (stn1 > 0 || stn2 > 0)
            {
                int digit1 = stn1 % 10;
                stn1 /= 10;

                int digit2 = stn2 % 10;
                stn2 /= 10;
                


                int result = digit1 + digit2;
                int reponse = result % 10;
                int remeber = result / 10;
                if (remeber == 1)
                {

                    Console.WriteLine($" Ta co: {digit1} + {digit2} = {result}, ghi {reponse}, nho {remeber}.");
                    Console.WriteLine($" Cong them 1 cho hang tiep theo cua so stn1!");
                    stn1++;

                }
                else if (digit1 == 0)
                {
                    Console.WriteLine($" Ta co: 0 + {digit2} = {digit2}, ghi {digit2} nho 1");
                    Console.WriteLine($" Cong them 1 cho hang tiep theo cua so stn1!");
                }
                else
                {

                    Console.WriteLine($" Ta co: {digit1} + {digit2} = {result}, ghi {reponse}, nho {remeber}");
                }
                   
                sum += place * reponse;
                place *= 10;
            }

            Console.WriteLine($"Tong: {sum}");
        }
    }
}
