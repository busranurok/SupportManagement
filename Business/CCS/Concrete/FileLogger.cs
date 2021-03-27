using System;
using Business.CCS.Abstract;

namespace Business.CCS.Concrete
{
    public class FileLogger : ILogger
    {
        public FileLogger()
        {
        }

        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
