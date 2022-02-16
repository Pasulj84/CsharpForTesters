using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._06_Modyfikatory
{
    public class TestyModyfikatorow
    {
        public static void Main(string[] args)
        {
            Modyfikatory filmos = new Modyfikatory("Park", "St Spiel", "Ada Kazmi", 242781);
            filmos.budzet += 2000;
            User u = new User();
            u.setAge(20);
            u.setAge(170);
            u.setAge(-10);

            Console.WriteLine(u.getAge());
        }
        
        
    }
}
