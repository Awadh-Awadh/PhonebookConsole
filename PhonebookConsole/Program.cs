// See https://aka.ms/new-console-template for more information
using PhonebookConsole;

Console.WriteLine("Hello from the Console phonebook app");
Console.WriteLine("Select an Operation");

Console.WriteLine("1 Add Contact");
Console.WriteLine("2 Display Contact by number");
Console.WriteLine("3 View all contacts");
Console.WriteLine("4 Search for contatcs for a given name ");
Console.WriteLine("Press x to exit");    

var userSelection = Console.ReadLine();
var phoneBook = new Phonebook();
bool selection = false;


while (!selection)
{
    switch (userSelection)
    {
        case "1":
            Console.WriteLine("Please Contact Name");
            var name = Console.ReadLine();
            Console.WriteLine("Please Enter the Number");
            var number = Console.ReadLine();

            var contact = new Contact(name, number);

            phoneBook.AddContact(contact);
            break;
        case "2":
            Console.WriteLine("Please Enter the Number");
            var displayNumber = Console.ReadLine();
            phoneBook.DisplayContact(displayNumber);

            break;
        case "3":
            phoneBook.DisplayAllContacts();
            break;
        case "4":
            Console.WriteLine("Please Enter the Name");
            var searchName = Console.ReadLine();
            phoneBook.DisplayMatchingContacts(searchName);

            break;
        case "x":
            return;
        default:
            Console.WriteLine("Please select the correct operation");
            break;

    }
    Console.WriteLine("Select an Operation");
    userSelection = Console.ReadLine();
}






