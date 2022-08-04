using System;
namespace Owomida
{
    
    public class Driver
    {
        public bool checkRegistration() //Ask driver to input reg number and return true or false depending on entry
        {
            string userID;
            string idNum;
            Console.WriteLine("If you are a member, Enter your ID: ");
            userID = Console.ReadLine();
            if (userID == null || userID == " ")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    public class Calculator
    {
        public double tollCalculator()
        {
            int numOfTrips;
            Driver thisDriver = new Driver();
            Console.WriteLine("How many trips has driver taken?: ");
            numOfTrips = Convert.ToInt32(Console.ReadLine());
            bool regStatus;
            double tollFee;
            double discount;
            double discountedTollFee;
            double charge;
            regStatus = thisDriver.checkRegistration();
            Console.WriteLine("Enter vehicle type: ");
            
            string newVehicle = Console.ReadLine();
            if (newVehicle == "Tricycle" || newVehicle == "tricycle")
            {
                charge = 80;
            }
            else if (newVehicle == "Motorcycle" || newVehicle == "motorcycle")
            {
                charge = 50;
            }
            else if (newVehicle == "Minibus" || newVehicle == "minibus")
            {
                charge = 100;
            }
            else if (newVehicle == "BRT" || newVehicle == "BRT Bus" || newVehicle == "brt bus")
            {
                charge = 150;
            }
            else
            {
                Console.WriteLine("Enter valid vehicle type");
                charge = 0;
            }


            tollFee = numOfTrips * charge;
            if (regStatus == true)
            {
                discount = 0.3 * tollFee;
            }
            else
            {
                discount = 0;
            }
            discountedTollFee = (numOfTrips * charge) - discount;
            return discountedTollFee;
        }
    }

    internal class MyMoney
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Calculator newFee = new Calculator();
                double myFee = newFee.tollCalculator();
                Console.WriteLine("Your toll fee is: " + myFee);
            }


        }

    }
}