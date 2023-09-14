using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{

    //AUTHOR: Romeo Mcdonald
    //CLASS DISCRIPTION: Class conatains the values of Ticket

    internal class Ticket
    {

        //Declaring the strings and ints for ticket class

     
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
       

    }
}
