using System;
namespace DataTypes
{
    class Program
    {
        static void Main(string[]args)
        {
            string text = "This is a string";
            int age = 35;
            DateTime now = DateTime.Now;
            double amount = 0;

            string string2 = text + " a second string" + age + now + amount;

            string string3 = string.Format("The age is {0}, the tame is {1}, and amout is {2} ", age, now, amount);

            string string4 = $"The age is {age}, the tame is {now}, and amout is {amount}";

            char sampleChar = 'C';

            char[] arrayChar = string4.ToCharArray();

            amount = (double) 10 / (double) 3;

            DateTime dateTime = new DateTime(2000, 1, 1);

            TimeSpan timeStampi = now - dateTime;
            //var otherText = "this is a text";
            Console.WriteLine(timeStampi.TotalMicroseconds);

            string test = "15";

            string booleanValue = "True";

            bool isTrue = bool.Parse(booleanValue);

            age = int.Parse(test);

            Console.ReadKey();

        }
    }
}