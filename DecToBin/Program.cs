using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecToBin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an unsigned integer number");
            var bIsRightNumber = (uint.TryParse(Console.ReadLine(), out var uNumber)) &&
                                 (uNumber <= uint.MaxValue);
            if (!bIsRightNumber)
            {
                Console.WriteLine("Invalid number format or number too big");
                Console.Read();
                return;
            }
            var strBinNum = "";
            var uTempVal = uNumber;
            while (uTempVal > 0)
            {
                strBinNum = (uTempVal % 2) + strBinNum;
                uTempVal /= 2;
            }
            if (strBinNum.Length == 0)
                strBinNum = "0";
            Console.WriteLine
            (
                "The binary equavalent of the decimal number {0} is: {1}",
                uNumber, strBinNum
            );
            Console.Read();
        }
    }
}
