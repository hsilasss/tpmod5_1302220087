using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod5
{
    internal class Program
    {
        public class Datageneric<T>
        {
            private T data;

            public Datageneric(T data)
            {
                this.data = data;
            }

            public void printInfo()
            {
                Console.WriteLine("Data yang tersimpan =  " + this.data);
            }
        }

        public class HaloGeneric
        {
            public static void SapaUser<T>(T data)
            {
                Console.WriteLine("Halo User " + data);
            }
        }

        private static void Main(string[] args)
        {
            HaloGeneric.SapaUser<string>("Henri");
            Datageneric<String> test = new Datageneric<String>("1302220087");
            test.printInfo();
        }
            
        }
    }

