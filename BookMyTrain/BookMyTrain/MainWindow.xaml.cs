using Business;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookMyTrain
{

    //AUTHOR: Romeo Mcdonald
    //CLASS DISCRIPTION: Class conatains the values of booking
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //decalring instances
        Train train = new Train();
        Ticket ticket = new Ticket();
        Booking booking = new Booking();
        Client client = new Client();

        //data manager for storing trains
        private Data _dataManager;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
       
        //on button click create client, train, tikcet and booking
        private void Create_Bookng_Click(object sender, RoutedEventArgs e)
        {


            //creating client
            //if user does not input a name show message box
            if (client.ClientId == "" )
            {
                MessageBox.Show("Please Enter a Name");
            }
            // Else customer's first name is what was entered in the Name box
            else
            {
                client.ClientId = Client_Name_Box.Text;
            }
           
            

            //creating train
            train = new Train();
            train.Departure = cmbx_From.Text;
            train.Destination = cmbx_Destination.Text;
            train.TrainId = cmbx_Train.Text;
            train.DepartureTime = cmbx_Departure_Time.Text;
            train.DepartureDate = cmbx_Departure_Date.Text;
            train.SeatType = cmbx_Seat_Selection.Text;
            train.StoppingAt = cmbx_Stopping_At.Text;


            //creating ticket
            ticket = new Ticket();
            ticket.Departure = cmbx_From.Text;
            ticket.Destination = cmbx_Destination.Text;
            ticket.TrainId = cmbx_Train.Text;
            ticket.DepartureTime = cmbx_Departure_Time.Text;
            ticket.DepartureDate = cmbx_Departure_Date.Text;
            ticket.SeatType = cmbx_Seat_Selection.Text;
            ticket.StoppingAt = cmbx_Stopping_At.Text;
            ticket.ClientID = Client_Name_Box.Text;
            ticket.TicketCost = booking.TicketCalculator(train, booking);
           


            //Creating booking
            booking = new Booking();
            booking.Departure = cmbx_From.Text;
            booking.Destination = cmbx_Destination.Text;
            booking.TrainId = cmbx_Train.Text;
            booking.DepartureTime = cmbx_Departure_Time.Text;
            booking.DepartureDate = cmbx_Departure_Date.Text;
            booking.SeatType = cmbx_Seat_Selection.Text;
            booking.StoppingAt = cmbx_Stopping_At.Text;
            booking.ClientID = Client_Name_Box.Text;
            booking.TicketCost = booking.TicketCalculator(train, booking); 
            booking.MealIncluded = cmbx_Meal_Selection.Text;
            booking.SeatReservation = cmbx_Reservation.Text;

            //Message box incase user doesnt input the number of tickets required
            //if number of tickets is blank show message
            if (num_of_tickets_Box.Text == "")
            {
                MessageBox.Show("Please enter the number of tickets as an Integer(eg 1, eg 2, eg 3)");
            }
            // Else users number of tickets is that which was entered in the num of ticket box
            else
            {
                booking.NumOfTickets = Convert.ToInt32(num_of_tickets_Box.Text);
                ticket.NumOfTickets = Convert.ToInt32(num_of_tickets_Box.Text);
            }


            //code for diplay box 
            tbx_Display.Text = "Booking information: "+ "\n" +
                                "\n" + "Train ID: " +train.TrainId + "          " + "Client Name: " + booking.ClientID + "\n" +
                                "Departing From: " + train.Departure + "          "+ "Destination: " + train.Destination + "\n" +
                               "Train departs at: " + train.DepartureTime + "          " + "Date of departure: " + train.DepartureDate + "\n" + 
                               "Type of seat: " + train.SeatType + "          " + "Train Stopping at: " + train.StoppingAt + "\n" + 
                               "Total Cost: " + booking.TicketCost * booking.NumOfTickets +"          " + "Number of Tikcets booked: "+ booking.NumOfTickets + "\n" +
                               "Meal Included: " + booking.mealIncluded + "          " + "Seat Reserved: " + booking.SeatReservation;




            //save the booking once it is created
            //Data.Save(_dataManager);
        }


        
    }
}
