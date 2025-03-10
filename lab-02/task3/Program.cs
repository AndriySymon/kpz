using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Authenticator auth1 = Authenticator.Instance;
            Authenticator auth2 = Authenticator.Instance;

            Console.WriteLine(auth1 == auth2 ? "Singleton works!" : "Singleton failed!");

            auth1.Authenticate("admin", "password123");
        }
    }
    public sealed class Authenticator
    {
        private static readonly object lockObject = new object();
        private static Authenticator instance = null;

        private Authenticator()
        {
            Console.WriteLine("Authenticator instance created.");
        }

        public static Authenticator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new Authenticator();
                        }
                    }
                }
                return instance;
            }
        }

        public void Authenticate(string username, string password)
        {
            Console.WriteLine($"Authenticating {username}...");
        }
    }
}
