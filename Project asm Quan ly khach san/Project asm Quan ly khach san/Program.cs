using System;
using System.Collections.Generic;
namespace Project_asm_Quan_ly_khach_san
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Customer> customerList = new List<Customer>();
            List<Hotel> hotelList = new List<Hotel>();
            List<Book> bookList = new List<Book>();
            
            int opt;
            do
            {
                ShowMenu();
                opt=Int32.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Input(hotelList);
                        break;
                    case 2:
                        Display(hotelList);
                        break;
                    case 3:
                        InputBook(bookList,customerList,hotelList);
                        break;
                    case 4:
                        SearchAvailableBook(bookList, hotelList);
                        break;
                    case 5:
                        Search(bookList, hotelList);
                        break;
                    case  6:
                        Console.WriteLine("Exit Program!!!");
                        break;
                    default:
                        Console.WriteLine("Input Failed!!!w");
                        break;
                }
                
            } while (opt !=6);
        }

        static void Search(List<Book> bookList, List<Hotel> hotelList)
        {
            Console.WriteLine("Enter Customer's ID: ");
            string cmtnd = Console.ReadLine();
            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].Equals(cmtnd))
                {
                    Hotel hotel = GetHoteByNo(hotelList, bookList[i].HotelNo);
                    if (hotel!= null)
                    {
                        hotel.DisplayBase();
                    }
                }
            }
        }

        static Hotel GetHoteByNo(List<Hotel> hotelList, string hotelNo)
        {
            for (int i = 0; i < hotelList.Count; i++)
            {
                if (hotelList[i].No.Equals(hotelNo))
                {
                    return hotelList[i];
                }
            }

            return null;
        }

        static void SearchAvailableBook(List<Book> bookList, List<Hotel> hotelList)
        {
            int checkIn, CheckOut;
            Console.WriteLine("Enter checkin day:  ");
            checkIn = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter checkout day: ");
            CheckOut = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < hotelList.Count; i++)
            {
                hotelList[i].DisplayBase();
                Console.WriteLine("------Available Room List------");
                List<Room> rooms = hotelList[i].roomList;
                for (int j = 0; j < rooms.Count; j++)
                {
                    if (checkAvailableRoom(bookList, hotelList[i].No, rooms[j].NO,checkIn,CheckOut))
                    {
                        rooms[i].Display();
                    }
                }
            }
        }

        static bool checkAvailableRoom(List<Book> bookList,string hotelNo, string roomNo, int checkIn, int checkOut)
        {
            for (int i = 0; i < bookList.Count; i++)
            {
                Book book = bookList[i];
                if (book.HotelNo.Equals(hotelNo) && book.RoomNo.Equals(roomNo)&& (book.CheckIn >= book.CheckIn
                        && book.CheckIn<= book.CheckOut||(book.CheckOut >= checkIn && book.CheckOut<= checkOut) ))
                {
                    return false;
                }
            }

            return true;
        }
        static void Input(List<Hotel> hotelList)
        {
            Console.WriteLine("Enter the hotel number to add: ");
            int N =Int32.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Hotel hotel = new Hotel();
                hotel.Input();
                hotelList.Add(hotel);
            }
        }

        static void Display(List<Hotel> hotelList)
        {
            for (int i = 0; i < hotelList.Count; i++)
            {
                hotelList[i].Display();
            }
        }

        static void InputBook(List<Book> bookList, List<Customer> customerList, List<Hotel> hotelList)
        {
            Book book = new Book();
            book.Input(customerList, hotelList);
            bookList.Add(book);
        }

        static void ShowMenu()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Option 1: Enter Hotel Information");
            Console.WriteLine("Option 2: Display hotel Information");
            Console.WriteLine("Option 3: Book room");
            Console.WriteLine("Option 4: Find available room");
            Console.WriteLine("Option 5: Find Customer Information");
            Console.WriteLine("Option 6: EXIT");
            Console.WriteLine("Choose option: ");
            Console.WriteLine("-----------------------------------");
        }
    }
}