using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IpAndEmailChecker
{
    class Program
    {
        String ipAddress;
        String email;

        public Program()
        {
            setIpAddress();
            setEmail();
        }

        private void setIpAddress()
        {
            Console.WriteLine("Podaj IP: ");
            ipAddress = Console.ReadLine();
            checkIpAddress();
        }

        private void checkIpAddress()
        {
            String ipPattern = "^([01]?\\d\\d?|2[0-4]\\d|25[0-5])\\." +
            "([01]?\\d\\d?|2[0-4]\\d|25[0-5])\\." +
            "([01]?\\d\\d?|2[0-4]\\d|25[0-5])\\." +
            "([01]?\\d\\d?|2[0-4]\\d|25[0-5])$"; ;
            if (Regex.IsMatch(ipAddress,ipPattern))
            {
                Console.WriteLine("IP address ok!");
            }
            else
            {
                Console.WriteLine("Wrong IP address");
                setIpAddress();
            }
        }

        private void setEmail()
        {
            Console.WriteLine("Podaj Email: ");
            email = Console.ReadLine();
            checkEmail();
        }

        private void checkEmail()
        {
            if (Regex.IsMatch(email,""))
            {
                Console.WriteLine("email ok!");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Wrong email");
                setEmail();
            }
        }




        static void Main(string[] args)
        {
            new Program();
        }
    }
}
