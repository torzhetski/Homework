using System;
class Program
{
    static void Main(string[] args)
    {
        string fullName = "Torzhertski Zakhar Vitalievich";
        string email = "torzhetski@mail.ru";
        int age = 18;
        double math = 10;
        double physics = 8.75;
        double programming = 8.5;
        Console.WriteLine($"My full name is {fullName}, im {age} years old\n here you can see my marks:" +
            $"\n math - {math}\n physics - {physics}\n programming - {programming}\n you can keep in touch with me using this email - {email}");
    }
}
