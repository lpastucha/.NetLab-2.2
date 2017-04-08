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

        const String EMAIL_PATTERN = @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*(?<=[0-9a-zA-Z])@)))"
                                    +@"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-z]\.)+[a-zA-Z]{2,6}))$";
       
        const String IP_PATTERN = "^([01]?\\d\\d?|2[0-4]\\d|25[0-5])\\." +
          "([01]?\\d\\d?|2[0-4]\\d|25[0-5])\\." +
          "([01]?\\d\\d?|2[0-4]\\d|25[0-5])\\." +
          "([01]?\\d\\d?|2[0-4]\\d|25[0-5])$";
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
          
            if (Regex.IsMatch(ipAddress,IP_PATTERN))
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
            

            if (Regex.IsMatch(email,EMAIL_PATTERN))
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
