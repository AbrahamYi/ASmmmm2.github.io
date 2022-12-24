using System;

namespace Project_asm_Quan_ly_khach_san
{
    public class Room
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Floor { get; set; }
        public int PersonalMax { get; set; }
        public string RoomType { get; set; }
        public string NO { get; set; }
        public Room(){}
        public void Input()
        {
            Console.WriteLine("Enter Room's name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter room Type: ");
            RoomType = Console.ReadLine();
            Console.WriteLine("Room price: ");
            Price =Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter floor: ");
            Floor = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter max people in a room: ");
            PersonalMax = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter room no: ");
            NO = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("Room Information (Room's name: {0},Room Type {1}, Price: {2}, Floor: {3}; Max people in room: {4}, Room no: {5})", 
                Name, RoomType, Price, Floor,PersonalMax, NO);
        }
    }
}