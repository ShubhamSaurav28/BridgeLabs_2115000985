/* using System;

class Node{
    public int TicketID;
    public string CustomerName;
    public string MovieName;
    public string SeatNumber;
    public DateTime BookingTime;
    public Node Next;
    public Node(int ticketID,string customerName,string movieName,string seatNumber){
        TicketID = ticketID;
        CustomerName = customerName;
        MovieName = movieName;
        SeatNumber = seatNumber;
        BookingTime = DateTime.Now;
        Next = null;
    }
}

class TicketReservationSystem{
    private Node head = null;
    private Node tail = null;
    private int ticketCount = 0;
    public void AddTicket(int ticketID,string customerName,string movieName,string seatNumber){
        Node newTicket = new Node(ticketID,customerName,movieName,seatNumber);
        if(head==null){
            head = newTicket;
            tail = newTicket;
            newTicket.Next = head;
        }
        else{
            tail.Next = newTicket;
            tail = newTicket;
            tail.Next = head;
        }
        ticketCount++;
        Console.WriteLine($"Ticket booked successfully! Ticket ID: {ticketID}, Movie: {movieName}, Seat: {seatNumber}");
    }
    public void RemoveTicket(int ticketID){
        if(head==null){
            Console.WriteLine("No tickets to remove.");
            return;
        }
        Node current = head;
        Node prev = null;
        do{
            if(current.TicketID==ticketID){
                if(current==head && current==tail){
                    head = null;
                    tail = null;
                }
                else if(current==head){
                    head = head.Next;
                    tail.Next = head;
                }
                else if(current==tail){
                    prev.Next = head;
                    tail = prev;
                }
                else{
                    prev.Next = current.Next;
                }
                ticketCount--;
                Console.WriteLine($"Ticket {ticketID} has been removed successfully.");
                return;
            }
            prev = current;
            current = current.Next;
        }while(current!=head);
        Console.WriteLine($"Ticket ID {ticketID} not found.");
    }
    public void DisplayTickets(){
        if(head==null){
            Console.WriteLine("No tickets booked.");
            return;
        }
        Node current = head;
        Console.WriteLine("\n--- Current Ticket Reservations ---");
        do{
            Console.WriteLine($"Ticket ID: {current.TicketID}, Customer: {current.CustomerName}, Movie: {current.MovieName}, Seat: {current.SeatNumber}, Booking Time: {current.BookingTime}");
            current = current.Next;
        }while(current!=head);
    }
    public void SearchTicket(string searchQuery){
        if(head==null){
            Console.WriteLine("No tickets booked.");
            return;
        }
        Node current = head;
        bool found = false;
        do{
            if (current.CustomerName.Equals(searchQuery,StringComparison.OrdinalIgnoreCase) || current.MovieName.Equals(searchQuery,StringComparison.OrdinalIgnoreCase)){
                Console.WriteLine($"Found Ticket -> ID: {current.TicketID}, Customer: {current.CustomerName}, Movie: {current.MovieName}, Seat: {current.SeatNumber}, Booking Time: {current.BookingTime}");
                found = true;
            }
            current = current.Next;
        }while(current!=head);
        if (!found)
        {
            Console.WriteLine($"No tickets found for '{searchQuery}'.");
        }
    }
    public int TotalTickets(){
        return ticketCount;
    }
}

class Program{
    public static void Main(){
        TicketReservationSystem reservationSystem = new TicketReservationSystem();
        reservationSystem.AddTicket(101,"Alice","Inception","A1");
        reservationSystem.AddTicket(102,"Bob","Avatar","B5");
        reservationSystem.AddTicket(103,"Charlie","Interstellar","C3");
        reservationSystem.DisplayTickets();
        reservationSystem.SearchTicket("Alice");
        reservationSystem.SearchTicket("Avatar");
        reservationSystem.RemoveTicket(102);
        reservationSystem.DisplayTickets();
        Console.WriteLine($"Total tickets booked: {reservationSystem.TotalTickets()}");
    }
}
 */