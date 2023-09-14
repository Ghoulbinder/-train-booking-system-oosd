using BookMyTrain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    //AUTHOR: Romeo Mcdonald
    //CLASS DISCRIPTION: Class conatains the values of booking
    internal class Booking
    {

        //Declaring the strings and ints for booking class


       
        private string trainid;
        private string departure;
        private string destination;
        public string departureTime;
        public string departureDate;
        public string stoppingAt;
        public string seatType;
        private string clientid;
        private int numoftikets;
        private int ticketcost;
        public string mealIncluded;
        private string seatReservation;
        private int seatTotal;


        //public getters and setters


        public string TrainId
        {
            get { return trainid; }
            set { trainid = value; }
        }
      
        public string Departure
        {
            get { return departure; }
            set { departure = value; }
        }
        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        public string DepartureTime
        {
            get { return departureTime; }
            set { departureTime = value; }
        }
        public string DepartureDate
        {
            get { return departureDate; }
            set { departureDate = value; }
        }
        public string ClientID
        {
            get { return clientid; }
            set { clientid = value; }
        }
        public int NumOfTickets
        {
            get { return numoftikets; }
            set { numoftikets = value; }

        }
        public int TicketCost
        {
            get { return ticketcost; }
            set { ticketcost = value; }
        }
        public string StoppingAt
        {
            get { return stoppingAt; }
            set { stoppingAt = value; }
        }
        public string SeatType
        {
            get { return seatType; }
            set { seatType = value; }
        }
        public string MealIncluded
        {
            get { return mealIncluded; }
            set { mealIncluded = value; }
        }
        public string SeatReservation
        {
            get { return seatReservation; }
            set { seatReservation = value; }
        }
        public int SeatTotal
        {
            get { return seatTotal; }
            set { seatTotal = value; }
        }


        //calculator for ticket cost
        public int TicketCalculator(Train train, Booking booking)
        {
            int price = 0;
            if ((train.Departure == "Edinburgh Waverley" || train.Departure == "London King's Cross") &&
                (train.Destination == "Edinburgh Waverley" || train.Destination == "London King's Cross"))
            {
                price += 50;
            }
            else
            {
                price += 25;
            }
            if (booking.seatType == "FirstClassSeat")
            {
                price += 10;
            }
            if (booking.seatReservation == "Yes")
            {
                price += 5;
            }
            if (booking.NumOfTickets != 1)
            {
                price += price * booking.NumOfTickets;
            }
            return price;
        }
       
     



    }
}
