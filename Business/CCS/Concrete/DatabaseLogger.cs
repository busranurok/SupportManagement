using System;
using Business.CCS.Abstract;

namespace Business.CCS.Concrete
{
    public class DatabaseLogger : ILogger
    {
        public DatabaseLogger()
        {
        }

        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
