using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace BookMyTrain
{
    //AUTHOR: Romeo Mcdonald
    //CLASS DISCRIPTION: Class conatains the values of client


    internal class Client
    {   

        //Declaring the strings and ints for client class
   
        private string clientID;

        //public getters and setters
  
        public string ClientId 
        {
            get { return clientID; }
            set { clientID = value; }
        }

    }  
}

