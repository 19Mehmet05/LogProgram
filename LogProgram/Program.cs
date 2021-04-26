using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int sayi = 0,sayi2=5;
                int sonuc = sayi2+sayi;
                LLog.Info("Sayılar Toplandı");
                LLog.Warn("Bu programı Mehmet yaptı :)");
            }
            catch (DivideByZeroException ex)
            {
               
               LLog.Error("hata",ex);
                Console.WriteLine("Kontrol");
            }
            
            Console.ReadKey();
        }
    }
}
