using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace exercise4
{
  
    class Program
    {
        public static string[] loginMain = new string[5];
        public static string[] passwordMain = new string[5];
        public static bool LogPass(string log)//, string pass)
        {
            int i = 0;
            while (log != loginMain[i])
            {
                Console.WriteLine("Введите логин: ");
                log = Console.ReadLine();
                i++;
            }
            while ()
            {

            }

            return true;
        }


        public static void info(string[] login, string[] password)
        {
            StreamReader logins = new StreamReader("login.txt");
            StreamReader passwords = new StreamReader("password.txt");

            for (int i = 0; i < login.Length; i++)
            {
                login[i] = logins.ReadLine();
            }
            Console.WriteLine("brrr");
            for (int i = 0; i < password.Length; i++)
            {
                password[i] = passwords.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            info(loginMain, passwordMain);
            string a = Console.ReadLine();
            if (LogPass(a) == true) Console.WriteLine("yyyees");
            else Console.WriteLine("nooopee");


        }
    }
}
