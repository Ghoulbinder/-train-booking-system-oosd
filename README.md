# BookMyTrain - Railway Ticket Booking System

A comprehensive train booking system built with WPF (Windows Presentation Foundation) demonstrating object-oriented software development principles, layered architecture, and database integration.

## 📋 About The Project

BookMyTrain is a desktop application that allows users to book train tickets with various options including seat selection, meal preferences, and route choices. The system implements a three-tier architecture (Presentation, Business, and Data layers) and demonstrates key OOSD principles including encapsulation, abstraction, and separation of concerns.

**Course**: Object-Oriented Software Development (OOSD)  
**Institution**: Edinburgh Napier University

## ✨ Key Features

### User Functionality
- **Client Management**: Register and manage customer information
- **Train Selection**: Choose from multiple trains (Train1-4)
- **Route Planning**: Select departure and destination stations
- **Seat Types**: Choose between Standard and First Class seating
- **Meal Options**: Add meal service to booking
- **Seat Reservation**: Reserve specific seats
- **Flexible Scheduling**: Select departure date and time
- **Intermediate Stops**: View trains with stops at Newcastle and York
- **Cost Calculation**: Automatic ticket price calculation based on selections
- **Multi-Ticket Booking**: Purchase multiple tickets in one transaction

### Available Routes
- Edinburgh Waverley
- Newcastle
- York  
- London King's Cross

### Departure Times
- 9:00 AM
- 10:00 AM
- 11:00 AM
- 12:00 PM

## 🏗️ Architecture & Design

### Three-Tier Architecture

```
┌─────────────────────────────────┐
│    Presentation Layer (WPF)     │
│  - MainWindow.xaml              │
│  - User Interface Controls      │
└─────────────────────────────────┘
              ↓
┌─────────────────────────────────┐
│       Business Layer            │
│  - Client.cs                    │
│  - Train.cs                     │
│  - Ticket.cs                    │
│  - Booking.cs                   │
└─────────────────────────────────┘
              ↓
┌─────────────────────────────────┐
│        Data Layer               │
│  - TicketDatabase               │
│  - TrainDatabase                │
│  - BookingDatabase              │
│  - BookingCounter               │
└─────────────────────────────────┘
```

### Class Structure

**Client Class**
```csharp
- ClientId: String
+ MakePayment()
+ BookTicket()
```

**Train Class**
```csharp
- TrainId: String
- NumOfTickets: Integer
- Departure: String
- Destination: String
- StoppingAt: String
- DepartureTime: String
- DepartureDate: String
- SeatType: String
```

**Ticket Class**
```csharp
- TrainId: String
- Departure: String
- Destination: String
- ClientId: String
- TicketCost: Integer
- NumOfTickets: String
- SeatType: String
- StoppingAt: String
- DepartureTime: String
- DepartureDate: String
+ CancelTicket()
```

**Booking Class**
```csharp
- TrainId: String
- Departure: String
- Destination: String
- DepartureDate: String
- DepartureTime: String
- StoppingAt: String
- SeatType: String
- ClientId: String
- NumOfTickets: String
- TicketCost: Integer
- MealIncluded: String
- SeatReservation: String
- SeatTotal: String
```

### Facade Pattern Implementation

The project uses the Facade design pattern to provide a simplified interface to the complex booking subsystem, encapsulating the interactions between Client, Train, Ticket, and Booking classes.

## 🛠️ Built With

- **C#** - Primary programming language
- **WPF (Windows Presentation Foundation)** - UI framework
- **XAML** - UI markup language
- **.NET Framework** - Application framework
- **Visual Studio** - Development environment

## 📁 Project Structure

```
BookMyTrain/
├── Presentation/
│   ├── MainWindow.xaml          # UI layout and design
│   └── MainWindow.xaml.cs       # UI logic and event handlers
├── Business/
│   ├── Client.cs                # Client entity and logic
│   ├── Train.cs                 # Train entity and logic
│   ├── Ticket.cs                # Ticket entity and logic
│   ├── Booking.cs               # Booking entity and calculations
│   └── Data.cs                  # Data management layer
├── Data/
│   ├── TicketDatabase.cs        # Ticket persistence
│   ├── TrainDatabase.cs         # Train data management
│   ├── BookingDatabase.cs       # Booking records
│   └── BookingCounter.cs        # Booking ID generation
├── Diagrams/
│   └── class_diagram.png        # UML class diagram
└── README.md                    # This file
```

## 🚀 Getting Started

### Prerequisites

- Windows 10 or later
- .NET Framework 4.7.2 or higher
- Visual Studio 2019 or later (with WPF workload)

### Installation

1. **Clone the repository**
```bash
git clone https://github.com/cloudsaber/train-booking-system-oosd.git
cd train-booking-system-oosd
```

2. **Open in Visual Studio**
```
- Open BookMyTrain.sln in Visual Studio
- Restore NuGet packages if prompted
```

3. **Build the solution**
```
- Build > Build Solution (Ctrl+Shift+B)
```

4. **Run the application**
```
- Debug > Start Debugging (F5)
```

## 💡 How to Use

### Making a Booking

1. **Enter Client Information**
   - Input customer name in the "Name" field

2. **Select Train Details**
   - Choose train from dropdown (Train1-4)
   - Select departure station
   - Select destination station
   - Choose departure time
   - Select departure date

3. **Configure Booking Options**
   - Select number of tickets
   - Choose seat type (Standard/First Class)
   - Add intermediate stops if desired
   - Reserve seat (Yes/No)
   - Include meal (Yes/No)

4. **Complete Booking**
   - Click "Book Ticket" button
   - View booking summary in display area
   - Total cost calculated automatically

### Booking Display Format
```
Booking Information:
Train ID: Train1          Client Name: John Smith
Departing From: Edinburgh Waverley          Destination: London King's Cross
Train departs at: 9:00          Date of departure: 1/12/22
Type of seat: FirstClassSeat          Train Stopping at: Newcastle, York
Total Cost: £150          Number of Tickets booked: 2
Meal Included: Yes          Seat Reserved: Yes
```

## 🎓 OOSD Principles Demonstrated

### Encapsulation
- Private fields with public getters/setters
- Data hiding within classes
- Controlled access to object properties

### Abstraction
- Separation of interface from implementation
- Facade interface simplifies complex subsystems
- Business logic abstracted from UI

### Inheritance
- Shared properties between related classes
- Code reusability through class hierarchies

### Polymorphism
- Method overriding in derived classes
- Interface implementations

### Separation of Concerns
- Three-tier architecture (Presentation, Business, Data)
- Each layer has distinct responsibilities
- Loose coupling between layers

### Design Patterns
- **Facade Pattern**: Simplifies booking subsystem interaction
- **Layered Architecture**: Organizes code into logical tiers
- **Data Access Object (DAO)**: Database classes handle persistence

## 📊 Features Breakdown

### Pricing System
The `TicketCalculator()` method in the Booking class calculates total cost based on:
- Base fare (distance between stations)
- Seat type multiplier (First Class costs more)
- Number of tickets
- Additional services (meals, reservations)

### Validation
- Name field validation (prevents empty bookings)
- Ticket quantity validation (requires integer input)
- Message boxes for user error feedback

### Data Persistence
- Database classes for storing bookings
- Save functionality for booking records
- Data retrieval for future reference

## 🔧 Technical Highlights

### WPF UI Components
```xaml
- ComboBox: Dropdown selections for trains, stations, times
- TextBox: User input for name and ticket quantity
- Button: Trigger booking creation
- Label: Display field names and information
- TextBlock: Show booking summary
- Grid: Layout management
```

### Event Handling
```csharp
- SelectionChanged: Monitor dropdown changes
- Click: Process booking button click
- Input validation on user actions
```

### Business Logic
```csharp
// Example: Creating a booking
booking = new Booking();
booking.Departure = cmbx_From.Text;
booking.Destination = cmbx_Destination.Text;
booking.TrainId = cmbx_Train.Text;
booking.TicketCost = booking.TicketCalculator(train, booking);
booking.NumOfTickets = Convert.ToInt32(num_of_tickets_Box.Text);
```

## 🎯 Learning Outcomes

This project demonstrates proficiency in:

- **Object-Oriented Programming**: Classes, objects, encapsulation, inheritance
- **Software Architecture**: Multi-tier design, separation of concerns
- **C# Programming**: Syntax, data types, control structures, methods
- **WPF Development**: XAML markup, event handling, data binding
- **Design Patterns**: Facade pattern, layered architecture
- **Database Concepts**: Data persistence, CRUD operations
- **User Interface Design**: Form validation, user feedback, layout design
- **Requirements Analysis**: Translating user needs into system design

## 🔮 Future Enhancements

### Planned Features
- **Database Integration**: Full SQL database implementation
- **Payment Processing**: Integrate payment gateway
- **User Authentication**: Login system for customers and staff
- **Booking History**: View past bookings
- **Seat Maps**: Visual seat selection interface
- **Email Confirmation**: Send booking confirmations
- **Discount Codes**: Apply promotional codes
- **Multi-Language Support**: Internationalization
- **Admin Panel**: Staff interface for managing trains and bookings
- **Real-Time Availability**: Check seat availability in real-time

### Technical Improvements
- **Data Binding**: Implement MVVM pattern for better separation
- **Unit Tests**: Comprehensive test coverage
- **Exception Handling**: Robust error management
- **Logging**: Application activity logging
- **Configuration**: External config file for settings
- **API Integration**: Connect to external train schedule APIs
- 
## 📸 Screenshots

<img width="1306" height="2051" alt="Train booking class diagram drawio" src="https://github.com/user-attachments/assets/d13bdfe4-844c-4c1e-9043-9db6ada076f0" />

## 🧪 Testing

### Test Scenarios
1. **Valid Booking**: Complete form with all fields, verify cost calculation
2. **Empty Name**: Try booking without entering name, expect error message
3. **Invalid Ticket Count**: Enter non-numeric value, expect error message
4. **Cost Calculation**: Verify different seat types produce correct costs
5. **Multiple Tickets**: Book various quantities, verify total cost multiplication

### Manual Testing Checklist
- [ ] All dropdowns populated correctly
- [ ] Name validation works
- [ ] Ticket number validation works
- [ ] Cost calculation accurate for all seat types
- [ ] Meal option affects price
- [ ] Reservation option affects price
- [ ] Display shows all booking details
- [ ] Multiple bookings can be created

## 📚 References & Resources

**Object-Oriented Design**:
- Design Patterns: Elements of Reusable Object-Oriented Software (Gang of Four)
- Clean Code by Robert C. Martin
- SOLID Principles

**WPF Development**:
- Microsoft WPF Documentation
- Pro WPF in C# (Matthew MacDonald)
- XAML markup language specification

**Software Architecture**:
- Pattern-Oriented Software Architecture
- Layered architecture best practices

## 👤 Author

**Romeo Mcdonald**
- GitHub: [@Ghoulbinder](https://github.com/Ghoulbinder)
- Institution: Edinburgh Napier University
- Course: Object-Oriented Software Development (OOSD)

## 📄 License

This project was created as part of university coursework. Please contact for usage permissions.

## 🙏 Acknowledgments

- Edinburgh Napier University OOSD course materials
- WPF community and documentation
- Design pattern resources and examples
- Course instructors and teaching staff

---

⭐ This project demonstrates comprehensive understanding of object-oriented software development principles, layered architecture, and desktop application development using WPF.

## 🔗 Related Projects

- Dynamic Difficulty Adjustment Game
- OpenGL 3D Graphics Showcase
- Database Systems Coursework
- Procedural Crafting System Generator

---

*Completed as part of Object-Oriented Software Development coursework at Edinburgh Napier University.*
