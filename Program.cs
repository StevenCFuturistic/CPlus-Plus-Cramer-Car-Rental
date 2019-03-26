using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Car_Rental
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
           
            int days;
            string daysAsString;
            double miles;
            string milesAsString;
            double totalDaysFee;
            double totalMilesFee;
            double dailyChargeTotal;
            double milesChargeTotal;
            double rentalRatePerMile = .25;
            double dailyRentalFee = 20.00;
            double totalRentalFee;
           
           
            // Get information from the user

            Write(" Cramer Car Rental: \n");
            Write(" Enter how many days you wish to rent a car ? >> \n");
            daysAsString = ReadLine();
            days = Convert.ToInt32(daysAsString);
            Write(" Enter how many miles total did you drive? >> \n");
            milesAsString = ReadLine();
            miles = Convert.ToDouble(milesAsString);
   

            // Outputs 
            Write("Your total rental days are: {0} " + " Your total miles are: {1} \n ", days, miles);

            totalDaysFee = days * dailyRentalFee;
            totalMilesFee = miles * rentalRatePerMile;
            totalRentalFee = totalDaysFee + totalMilesFee;

            Write(" Your total rental fee from Cramer Car Rental: {0} \n", totalRentalFee.ToString("C2"));
            Write("---------------------------------------------------- \n");
            Write(" Your days driven total: {0} \n" + " Your daily rental charge is {1} \n", days, dailyRentalFee);

            dailyChargeTotal = days * dailyRentalFee;
            Write("Your days subtotal: {0} \n", dailyChargeTotal.ToString("C2"));
            Write(" Your miles driven: {0} \n" + " Your rate per mile {1} \n", miles, rentalRatePerMile);

            milesChargeTotal = miles * rentalRatePerMile;

            Write("Your Mileage Rate Subtotal is: {0} ", milesChargeTotal.ToString("C2"));


            Console.ReadKey();

        }
    }
}
