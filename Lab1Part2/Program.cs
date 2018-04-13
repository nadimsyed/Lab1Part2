using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //In Lab one instruction it asks the task be written in a seperate method, so I also wrote my code in another method in this lab so Main is as clean as possible.
            Dates();
        }
        //Named the method dates since that is the shortest clear name for it. Thought it was better than DifferentDates.
        public static void Dates()
            {
                //This condition was made to be able to handle the while loop parameters in multiple ways
                bool condition = true;
                
                //Using a while loop so user can input multiple pairs of dates they want to check and also so if they put an invalid input, they can easily get another try
                while (condition == true)
                {
                    //Using a try catch because I want to be able to handle error messages and provide feedback to user when an error has occured
                    try
                    {
                        //Prompting user to input first date. I'm using a ToLower so that way any variation in the writing of "quit" allows for the funcion of "quit" to be executed. 
                        Console.WriteLine("Enter first date in the Format MM/DD/YYYY OR Type \"quit\" to exit. ");
                        string firstD = Console.ReadLine().ToLower();

                        //This quit break is here because I was running into the issue of the user being prompter for a second input even though they had already put a "quit"
                        // in the first input. So for user ease and fluidity of the console app I inserted this to stop the application here if user desires.
                        if (firstD == "quit")
                        {
                            break;
                        }

                    //Prompting user to input second date here. I'm using a ToLower again here for the same mentioned reasons as above.
                    Console.WriteLine("Enter second date in the Format MM/DD/YYYY OR Type \"quit\" to exit. ");
                        string secondD = Console.ReadLine().ToLower();
                    

                        //This quit break is here so that if the user decides during the second date entry they want to quit out the application, they can do so.
                        if (secondD == "quit")
                        {
                            break;
                        }
                        else
                        {
                            //In the following two statements I am converting from the string the user inputed to DateTime
                            DateTime firstDate = DateTime.Parse(firstD);

                            DateTime secondDate = DateTime.Parse(secondD);

                        //Here I am taking the two new DateTime I have made to TimeSpan to calculate the difference in time, that's why I named the new values of TimeSpan Class
                        // diff. Following that is an if else statement to make sure the answer is in positive. We don't speak about time negatively, we just say the difference
                        // so for readability reasons I make sure the output is positive numbers.
                        TimeSpan diff;

                        if (firstDate > secondDate)
                        {
                            diff = firstDate - secondDate;
                        }
                        else
                        {
                            diff = secondDate - firstDate;
                        }

                            //Creating a year value and a month value from the existing TotalDays method inside the class TimeSpan
                            double years = (double)diff.TotalDays / 365;
                            double months = years * 12;
                            
                            //This step is necessary conversion, because if you have less than a year and use int, months will be 0 as long as year is not at least 1
                            //Also if you just left it as double like above, you would have decimal numbers, and since in spoken language that does not sound right, I did these two steps
                            // to make sure it reads easy and you get whole number months, and whole number years.
                            int years2 = (int)years;
                            int months2 = (int)months;
                            
                            //Here the code is just printing to console the answers of the questions we were asked. Years passed, months passed, days passed, hours passed, minutes passed.
                            Console.WriteLine("Years : " + years2.ToString());
                            Console.WriteLine("Months: " + months2.ToString());
                            Console.WriteLine("Days : " + diff.TotalDays.ToString());
                            Console.WriteLine("Hours : " + diff.TotalHours.ToString());
                            Console.WriteLine("Minutes : " + diff.TotalMinutes.ToString());
                        }    
                    }
                    //This is to error handle. If the user places an input we do not want, like letters, or symbols, we tell them it is invalid then give them another try
                    catch (Exception)
                        {
                            Console.WriteLine("Invalid Input! Please Try Again!!!");
                        }
                }
            }
    }
}
