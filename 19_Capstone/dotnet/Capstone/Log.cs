using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone
{
    public class Log
    {

        public static void FeedMoneyLog(decimal moneyFed, decimal newBalance)
        {
            WriteLog("FEED MONEY", moneyFed, newBalance);
        }

        public static void PurchaseLog(string selection, string name, decimal oldBalance, decimal balance)
        {
            WriteLog(name, oldBalance, balance);
        }

        public static void ChangeLog(decimal oldBalance, decimal balance)
        {
            WriteLog("Give Change", oldBalance, balance);
        }

        private static void WriteLog(string message, decimal firstValue, decimal secondValue)
        {
            using (StreamWriter sw = new StreamWriter("transactionlog.txt", true))
            {
                sw.WriteLine($"{DateTime.Now.ToString().PadRight(21)}" +
                             $"{message.PadRight(21)}" +
                             $"{firstValue.ToString("C").PadRight(7)}" +
                             $"{secondValue.ToString("C").PadRight(7)}");
            }
        }
    }
}
