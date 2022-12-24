using System;

namespace Project_asm_Quan_ly_khach_san
{
    public class Customer
    {
        public string CMTND { get; set; }
        public string Fullname { get; set; }
        public int Old { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

        public Customer()
        {
        }

        public void Input()
        {
            Console.WriteLine("ID: ");
            CMTND = Console.ReadLine();
            Console.WriteLine("Full name: ");
            Fullname = Console.ReadLine();
            Console.WriteLine("Gender: ");
            Gender = Console.ReadLine();
            Console.WriteLine("Address: ");
            Address = Console.ReadLine();
            Console.WriteLine("Old: ");
            Old = Int32.Parse(Console.ReadLine()); 
        }
        
        public void InputWithoutCMTND()
        {
            Console.WriteLine("Full name: ");
            Fullname = Console.ReadLine();
            Console.WriteLine("Gender: ");
            Gender = Console.ReadLine();
            Console.WriteLine("Address: ");
            Address = Console.ReadLine();
            Console.WriteLine("Old: ");
            Old = Int32.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Customer's Information (Full Name: {0}, Age: {1}, ID: {2}), Gender: {3}, Address: {4}",
                Fullname,Old,CMTND,Gender,Address);
        }
    }
}