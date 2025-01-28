using System;

public class GalacticTravelAgency { 
  public static void Main(string[] args) {

    string passengerName = "Zara";
    int passengerAge = 28;
    var ticketType = "First Class";
    string prefferedPlanet = "Mars";

    Console.WriteLine(passengerName);
    Console.WriteLine(passengerAge);
    Console.WriteLine(ticketType);
    Console.WriteLine(prefferedPlanet);

    passengerAge = passengerAge+1;
    Console.WriteLine(passengerAge);

    double passengerAgeDouble = (double)passengerAge;
    Console.WriteLine(passengerAgeDouble);

    double passengerAgeDouble2 = passengerAgeDouble;
    Console.WriteLine(passengerAgeDouble2);

    string passengerAgeString = Convert.ToString(passengerAge);
    Console.WriteLine(passengerAgeString);


  }
}
