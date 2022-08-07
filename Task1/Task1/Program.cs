using System;
class Program
{
    static void Main(string[] args)
    {
        string fullName = "Torzhertski Zakhar Vitalievich";
        string email = "torzhetski@mail.ru";

        byte age = 18;//врядли кому - то больше 255

        //сделал баллы по предметам дробными, т.к. в задании было указано что тип переменной должен быть с плавающей запятой
        float math = 10F;
        float physics = 8.75F;
        float programming = 8.5F;
        Console.WriteLine($"My full name is {fullName}, im {age} years old\n here you can see my marks:" +
            $"\n math - {math}\n physics - {physics}\n programming - {programming}\n you can keep in touch with me using this email - {email}");
        Console.ReadKey();
        double sum = math + physics + programming;
        double average = sum/3;
        Console.WriteLine("sum of all marks is {0} and there is only 3 subjects, so the avarege is {1:0.00}", sum, average);
    }
}
