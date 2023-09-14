namespace TestProject1
{
    //AUTHOR: Romeo Mcdonald
    //CLASS DISCRIPTION: Class conatains the values of booking
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

           //arrange
            Train train = new Train();
            train.trainId = "train1";
            train.departure = "Edinburgh Waverley";
            train.destination="London Kings Cross";
            train.stoppingAt="NewCastle, York";
            train.seatType="Standdard";
            train.departureTime="9.00";
            train.departureDate="1/11/22";

            Booking booking = new Booking();
            booking.trainId = "train1";
            booking.clientName = "Mark Smith";
            booking.departure = "Edinburgh Waverley";
            booking.destination = "London Kings Cross";
            booking.stoppingAt = "NewCastle, York";
            booking.seatType = "Standdard";
            booking.departureTime = "9.00";
            booking.departureDate = "1/11/22";
            booking.numberOfTickets = 1;
            booking.mealIncluded = "Yes";
            booking.seatReserved = "Yes";

            string expected = "train1"+"Mark Smith"+
                               "Edinburgh Waverley " + "london Kings Scorss"+
                               "9.00 " + "1/11/22" +
                               "Standard" + "NewCastle, York" + 
                               "50: " + "5: "  + 
                               "Yes" + "Yes";
            //Act
            string test = train.ToString();

            //Assert
            Assert.AreEqual(expected, test);

        }
        public void TestMethod2()
        {

            //arrange
            Train train = new Train();
            train.trainId = "train2";
            train.departure = "London Kings Cross";
            train.destination = "Edinburgh Waverley";
            train.stoppingAt = "Not Stopping";
            train.seatType = "FirstClass";
            train.departureTime = "10.00";
            train.departureDate = "1/11/22";

            Booking booking = new Booking();
            booking.trainId = "train2";
            booking.clientName = "Mark Jhonson";
            booking.departure = "London Kings Cross";
            booking.destination = "Edinburgh Waverley";
            booking.stoppingAt = "Not Stopping";
            booking.seatType = "FirstClass";
            booking.departureTime = "10.00";
            booking.departureDate = "1/11/22";
            booking.numberOfTickets = 5;
            booking.mealIncluded = "No";
            booking.seatReserved = "No";


            string expected = "train2" + "Mark Jhonson" +
                               "london Kings Scorss" + "Edinburgh Waverley " +
                               "1.00 " + "1/11/22" +
                               "FirstClass" + "Not Stopping" +
                               "250: " + "5: " +
                               "No" + "No";
            //Act
            string test = train.ToString();

            //Assert
            Assert.AreEqual(expected, test);

        }
    }
}