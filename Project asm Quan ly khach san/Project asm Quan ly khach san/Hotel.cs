using System;
using System.Collections.Generic;

namespace Project_asm_Quan_ly_khach_san
{
    public class Hotel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string No { get; set; }
        public List<Room> roomList = new List<Room>();
        public Hotel()
        {
        }

        public void Input()
        {
            Console.WriteLine("Enter ID hotel: ");
            No = Console.ReadLine();
            Console.WriteLine("Enter Hotel's name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter address: ");
            Address = Console.ReadLine();
            //
            Console.WriteLine("Enter room want to add: ");
            int N =Int32.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Room room = new Room();
                room.Input();
                roomList.Add(room);
            }
        }

        public void Display()
        {
            Console.WriteLine("Hotel (Name of Hotel: {0}, Address: {1})", Name,Address);
            for (int i = 0; i < roomList.Count; i++)
            {
                roomList[i].Display();
            }
        }
        public void DisplayBase()
        {
            Console.WriteLine("Hotel (Name of Hotel: {0}, Address: {1})", Name,Address);
        }
    }
}