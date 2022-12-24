using System;
using System.Collections.Generic;
using System.Collections.Generic;
namespace Project_asm_Quan_ly_khach_san
{
    public class Book
    {
        public int CheckIn { get; set; }
        public int CheckOut { get; set; }
        public string CMTND { get; set; }
        public string HotelNo { get; set; }
        public string RoomNo { get; set; }
        
        public Book()
        {
        }

        public void Input(List<Customer> customerList, List<Hotel> hotelList)
        {
            Console.WriteLine("Enter Customer ID: ");
            CMTND = Console.ReadLine();
            bool isFind = false;
            for (int i = 0; i < customerList.Count; i++)
            {
                if (customerList[i].CMTND.Equals(CMTND))
                {
                    isFind = true;
                    break;
                }
            }

            if (!isFind)
            {
                Console.WriteLine("Invalid Customer >> Input Customer");
                Customer customer = new Customer();
                customer.CMTND = CMTND;
                customer.InputWithoutCMTND();
                customerList.Add(customer);
            }
            // nhap ma ks
            DisplayHotelMenu(hotelList);
            Hotel hotel = null;
            while (true)
            {
                HotelNo= Console.ReadLine();
                //check ma ks coi dung chua
                isFind = false;
                for (int i = 0; i < hotelList.Count; i++)
                {
                    if (hotelList[i].No.Equals(HotelNo))
                    {
                        isFind = true;
                        hotel = hotelList[i];
                        break;
                    }
                }

                if (isFind)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid ID's Hotel>> Enter again!: ");
                }
            } 
            //nhap ma phong
            DisplayRoomMenu(hotel);
            while (true)
            {
                RoomNo = Console.ReadLine();
                isFind = false;
                for (int i = 0; i < hotel.roomList.Count; i++)
                {
                    if (hotel.roomList[i].NO.Equals(RoomNo))
                    {
                        isFind = true;
                        break;
                    }
                }

                if (isFind)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Room no>> Enter again!: ");
                }
            }
            // check in/out
            Console.WriteLine("Enter CheckIn day: ");
            CheckIn = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter CheckOut day: ");
            CheckOut = Int32.Parse(Console.ReadLine());
        }
        
        public void DisplayHotelMenu(List<Hotel> hotelList)
        {
            for (int i = 0; i < hotelList.Count; i++)
            {
                Console.WriteLine("{0}. {1} - {2}",i+1,hotelList[i].Name, hotelList[i].No);
            }

            Console.WriteLine("Enter ID's Hotel");
        }

        public void DisplayRoomMenu(Hotel hotel)
        {
            for (int i = 0; i < hotel.roomList.Count; i++)
            {
                Console.WriteLine("{0}. {1} - {2}",i+1,hotel.roomList[i].Name, hotel.roomList[i].NO);
            }

            Console.WriteLine("Enter Room no: ");
        }
    }
}