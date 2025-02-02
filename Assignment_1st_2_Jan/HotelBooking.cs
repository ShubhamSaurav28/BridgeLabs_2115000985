//using System;

//public class HotelBooking{
//    public string GuestName;
//    public string RoomType;
//    public int Nights;
//    public HotelBooking(){
//        GuestName = "Unknown";
//        RoomType = "Standard";
//        Nights = 1;
//    }
//    public HotelBooking(string guestName,string roomType,int nights){
//        GuestName = guestName;
//        RoomType = roomType;
//        Nights = nights;
//    }
//    public HotelBooking(HotelBooking other){
//        GuestName = other.GuestName;
//        RoomType = other.RoomType;
//        Nights = other.Nights;
//    }
//    public void DisplayBookingDetails(){
//        Console.WriteLine($"Guest Name: {GuestName}, Room Type: {RoomType}, Nights: {Nights}");
//    }
//}

//public class Program{
//    public static void Main(string[] args){
//        HotelBooking h1 = new HotelBooking();
//        h1.DisplayBookingDetails();
//        HotelBooking h2 = new HotelBooking("Shubham","Deluxe",3);
//        h2.DisplayBookingDetails();
//        HotelBooking h3 = new HotelBooking(h2);
//        h3.DisplayBookingDetails();
//    }
//}
