using System;

class SpecialPowers
{


static public string HowOldAreYou()
{//takes in a users year of birth and returns how old they are
Console.WriteLine("Please enter your year of birth....");
 string yearOfBirth = Console.ReadLine();
 if(int.TryParse(yearOfBirth, out int result))
 {
     int currentYear = System.DateTime.Now.Year;
      int yourage = currentYear-result;
      Console.WriteLine("Your are "+yourage.ToString()+" years old..");
      return "Your are "+yourage.ToString()+" years old..";
 }
 else
 {
        Console.WriteLine("Mumu!, please give me a valid year!");
        return "Mumu!, please give me a valid year!";
 }


}






    static public string SayHello(){
        //call this funtion it takes in a user name and user age to give a message
        string userName;
        string userAge;
        Console.WriteLine("Please provide your name below:");
        //get users name here
        userName = Console.ReadLine();
        Console.WriteLine("Please "+userName+" provide your age below:");
        userAge = Console.ReadLine();
        int attempts = 0;
        while(!int.TryParse(userAge,out int result))
        {   
            Console.WriteLine("Hello "+userName+" please enter a correct age!!!!!");
            userAge = Console.ReadLine();
            attempts = attempts + 1;
            if(attempts >= 3)
            {
                //lock user
                Console.WriteLine("You are wasting my time!!!!");
                return "You are wasting my time!!!!";
              
            }
            

        }
        string messageResponse = "Hello "+userName+", You are "+userAge+" years old";
        return messageResponse;



    }






}