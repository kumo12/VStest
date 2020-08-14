using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Interface
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(
                "{0} {1}",
                DateTime.Now.ToLocalTime(), message);
        }
    }


        class FileLogger : ILogger
        {
        private StreamWriter Writer;
            public FileLogger(string path)
            {
                Writer = File.CreateText(path);
                Writer.AutoFlush = true;
            }

            public void WriteLog(string message)
            {
                Writer.WriteLine("{0} {1}", DateTime.Now.ToShortDateString(), message);
            }
        }

        class ClimateMonitor
        {
            private ILogger Iogger;
            public ClimateMonitor(ILogger logger)
            {
                this.Iogger = logger;
            }

            public void start()
            {
                while (true)
                {
                    Console.WriteLine("온도를 입력해주세요.: ");
                    string temperature = Console.ReadLine();
                    if (temperature == " ")
                        break;

                    Iogger.WriteLog("현재 온도 : " + temperature);
                }
            }
        }

        class MainApp
        {
            static void Main(string[] args)
            {
                ClimateMonitor monitor = new ClimateMonitor(
                    new FileLogger("MyLog.txt"));

                monitor.start();
            }
        }
    }
