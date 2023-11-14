using System;
using System.Linq;


namespace CourseProject
{
    class SalesReceipt
    {
        //setting variables
        public static string firstName;
        public static string lastName;
        public static string phoneNumber;
        public static string emailAddress;
        public static string address;


        static void Main(string[] args)
        {
            //asking for customer input information 
            Console.WriteLine("Create a sales receipt for a customer");

            Console.WriteLine("Enter the first name of the customer:");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter the last name of the customer:");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter the customer phone number:");
            phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter the email address for the customer:");
            emailAddress = Console.ReadLine();

            Console.WriteLine("Enter full customer address:");
            address = Console.ReadLine();

            //loop to ask for price of items and ends at 5. 
            int[] itemsPrice = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the sales price for the item " + ++i);
                i--;
                itemsPrice[i] = Convert.ToInt16(Console.ReadLine());


            }

            int sum = itemsPrice.Sum();
            //output statements that will show the totals with the custoemr name that can be used as receipt. 
            Console.WriteLine("Total price for 5 purchased items is: $" + sum);
            Console.WriteLine("Tota price for all 5 items including sales tax is: $" + (sum + (sum * 0.04))+"\n\n");
            Console.WriteLine("Customer Name\t"+"Customer Phone Number\t"+"Customer Email\t"+"Customer Address");
            Console.WriteLine(firstName+" "+lastName+"\t"+phoneNumber+"\t\t"+emailAddress+"\t"+address );
            Console.WriteLine("Total\t\t"+"Tax\t\t"+"Total with tax");
            Console.WriteLine("$"+sum + "\t\t" + "$"+(sum * 0.04) + "\t\t"+ "$"+(sum + (sum * 0.04)));
           

        }
    }
}
