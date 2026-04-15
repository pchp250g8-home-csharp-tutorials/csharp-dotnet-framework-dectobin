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
            const uint MAX_INT = uint.MaxValue;
            Console.WriteLine("Input an unsigned integer number");
            var bIsRightNumber = (uint.TryParse(Console.ReadLine(), out var uNumber)) &&
                                 (uNumber <= MAX_INT);
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
                uint nBinDigit = uTempVal % 2;
                char chBinDigit = (char)(nBinDigit + '0');
                strBinNum = chBinDigit + strBinNum;
                uTempVal /= 2;
            }
            if (strBinNum.Length == 0)
                strBinNum = "0";
            Console.WriteLine
            (
                "The binary equivalent of the decimal number {0} is: {1}",
                uNumber, strBinNum
            );
            Console.Read();
        }
    }
}
