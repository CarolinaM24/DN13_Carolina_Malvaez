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
           // Console.WriteLine(timeStampi.TotalMicroseconds);

            string test = "15";

            string booleanValue = "True";

            bool isTrue = bool.Parse(booleanValue);

            age = int.Parse(test);

            // Ejercicio 3

            List<Customer> customerList = new List<Customer>();

            for (int i = 1; i <= 10; i++)
            {
                Customer customer = new Customer($"Cliente {i}", DateTime.Now);
                customerList.Add(customer);
            }

            Console.WriteLine("Recorrido con el bucle foreach:");
            foreach (Customer customer in customerList)
            {
                Console.WriteLine($"Nombre del cliente: {customer.Name}, Fecha de registro: {customer.RegistrationDate}");
            }


            Console.WriteLine("\nRecorrido con el bucle for:");
            for (int i = 0; i < customerList.Count; i++)
            {
                Console.WriteLine($"Nombre del cliente: {customerList[i].Name}, Fecha de registro: {customerList[i].RegistrationDate}");
            }

            Console.WriteLine("\nRecorrido con el bucle while:");
            int j = 0;
            while (j < customerList.Count)
            {
                Console.WriteLine($"Nombre del cliente: {customerList[j].Name}, Fecha de registro: {customerList[j].RegistrationDate}");
                j++;
            }
            Console.WriteLine("\nRecorrido con el blucle do while:");
            int k = 0;
            do
            {
                Console.WriteLine($"Nombre del cliente: {customerList[k].Name}, Fecha de registro: {customerList[k].RegistrationDate}");
                k++;
            } while (k < customerList.Count);

            Console.ReadKey();

        }
    }
    class Customer
    {
        public string Name { get; set; }
        public DateTime RegistrationDate { get; set; }

        public Customer(string name, DateTime registrationDate)
        {
            Name = name;
            RegistrationDate = registrationDate;
        }
    }
}