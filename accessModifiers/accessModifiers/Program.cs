using System;

namespace accessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("istifadeci adinizi daxil edin: ");
            string username = Console.ReadLine();
            Console.WriteLine("parolunuzu daxil edin: ");
            string password = Console.ReadLine();

            User user = new User(username);
            user.Password = password;

            Console.WriteLine($"istifadeci adi: {user.Username} - parol: {user.Password}");
        }
    }
}
