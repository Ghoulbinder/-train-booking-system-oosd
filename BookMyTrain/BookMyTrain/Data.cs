using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Formats.Asn1.AsnWriter;

namespace Business
{
    //AUTHOR: Romeo Mcdonald
    //CLASS DISCRIPTION: Class conatains the values of booking

    internal class Data
    {
        //saves in the bin folder becasue we didnt give it a path
        private static string _filename = "Trains.xml";

        //lisT
        public List<Train> TrainsData
        {
            get;
            private set;
        }
        public List<Train> Trains
        { 
            get;
            private set;
        }
       public List<Booking> Bookings
        {
            get;
            private set;
        }
        public List<Ticket> Tickets
        {
            get;
            private set;
        }

        public Data()
           : this(new List<Train>())
           
            
        {

        }

        //update methods for train, ticket and booking database
        public Data(List<Train> trains)
        {
            Trains = trains;
            UpdateData();
        }
        public void Add(Train train)
        {

            Trains.Add(train);
            

        }
        public Data(List<Booking> bookings)
        {
            Bookings = bookings;
            UpdateData();
        }
        public void Add(Booking booking)
        {

            Bookings.Add(booking);


        }
        public Data(List<Ticket> tickets)
        {
            Tickets = tickets;
            UpdateData();
        }
        public void Add(Ticket tickets)
        {

            Tickets.Add(tickets);


        }

        //load data stored
        public static Data Load()
        {
            //if the file doesnt exist- create a new "data manager"
            if (!File.Exists(_filename))
                return new Data();

            //otherwise load the trains
            using (var reader = new StreamReader(new FileStream(_filename, FileMode.Open)))
            {
                var serilizer = new XmlSerializer(typeof(List<Train>));
                var trains = (List<Train>)serilizer.Deserialize(reader);
                return new Data(trains);
            }
            
        }


        //update data stored
        public void UpdateData()
        {
            TrainsData = Trains.Take(4).ToList();//takes the first 4 trains
        }


        //serializer to save data
        public static void Save(Data dataManager)
        {
            //orders the files if it already exists
            using (var writer = new StreamWriter(new FileStream(_filename, FileMode.Create)))
            {
                var serilizer = new XmlSerializer(typeof(List<Train>));
                serilizer.Serialize(writer, dataManager.Trains);
            }
        }
    }
}
