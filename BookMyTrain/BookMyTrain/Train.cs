using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    internal class Train
    {
        //AUTHOR: Romeo Mcdonald
        //CLASS DISCRIPTION: Class conatains the values of booking


        //Declaring the strings and ints for train class

        private string trainId;
        private string departure;
        private string destination;
        private string stoppingAt;
        private string seatType;
        private string departureTime;
        private string departureDate;


        //public getters and setters
        public Train()
        {
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


        public string StoppingAt
        {
            get { return stoppingAt; }
            set { stoppingAt = value; }
        }

        public string TrainId
        {
            get { return trainId; }
            set { trainId = value; }
        }
        public string SeatType
        {
            get { return seatType; }
            set { seatType = value; }
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

    }
}
