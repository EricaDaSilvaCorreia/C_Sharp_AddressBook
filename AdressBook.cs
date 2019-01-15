using System;

namespace AddressBook
{
  class Book
  {
    static void Main()
    {
      //=== Prompt user for adding or searching entries ===
      string[] firstNames = new string[10];
      string[] lastNames = new string[10];
      string[] addresses = new string[10];
      string[] emails = new string[10];
      // int[] phoneNumbers;

      bool keepGoing = true;


      while (keepGoing)
      {

        Console.WriteLine("Welcome to the console rolodex! enter 'add' to add an entry or 'search' to search for an entry or type 'quit' to exit!  ");

        string entry = Console.ReadLine();

        if(entry.ToLower() == "add")
        {
          //=== if adding : Prompt user for firstname, lastname, address, email and phone number ===
          Console.WriteLine("Please enter the firstname: ");
          // string[] firstNames = new string[10];
          // for (int i=0; i<firstNames.Length; i++) {
            firstNames[0]= Console.ReadLine();
          // }

          Console.WriteLine("Please enter the lastname: ");
          // string lastName = Console.ReadLine();
          // string[] lastNames = new string[10];
          lastNames[0]= Console.ReadLine();

          Console.WriteLine("Please enter the address: ");
          // string address = Console.ReadLine();
          // string[] addresses = new string[10];
          addresses[0]= Console.ReadLine();

          Console.WriteLine("Please enter the email: ");
          // string email = Console.ReadLine();
          // string[] emails = new string[10];
          emails[0]= Console.ReadLine();

          Console.WriteLine("Please enter the phone number: ");
          // string phoneNumber = Console.ReadLine();
          // string[] phoneNumbers = new string[10];
          // phoneNumbers[0]= Console.ReadLine();
          //=== add info to Book ===
          continue;
        }
        else if (entry.ToLower() == "search")
        {
          //=== elseif searching : Prompt user for lastname ===
          Console.WriteLine("Please enter the lastname: ");

          string search = Console.ReadLine();
          //=== return entry ===
          if (search == lastNames[0])
          {
            Console.WriteLine("First Name : " + firstNames[0] + ", Last Name : " + lastNames[0] + ", Address : " + addresses[0] + ", Email : " + emails[0] + "." );
            continue;
          }
          else
          {
            Console.WriteLine("No Such Entry Found");
            continue;
          }

        }
        else if (entry.ToLower() == "quit") {
          keepGoing = false;

        }//End if
      }//End Loop




      //=== repeat until user quits===

    }// End Main
  }// End Book
}// End namespace
