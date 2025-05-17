/*var challenge = new CodeChallenge();
var list = challenge.listExample();

foreach(var numberss in list)
{
    Console.WriteLine(numberss);
}

Console.WriteLine("    ");



var even = new CodeChallenge();
var digits = new List<int> {15,79,9,56,6,9};

var outcome  = even.evenNumbers(digits);

foreach(var digit in outcome)
{
    Console.WriteLine(digit);
}



Console.WriteLine("    ");




var Summ = new CodeChallenge();
List<int> number = new List<int> {1,2,3,4,5};
Console.WriteLine("Sum:" + Summ.CalculateSum(number));



Console.WriteLine("    ");




var indexx = new CodeChallenge();
List<int> numbers = new List<int> {56,7,9,54,76};
int target = 4;
int index = indexx.FindIndex(numbers, target);
Console.WriteLine("Index:" + index);


Console.WriteLine("    ");



var duplicate = new CodeChallenge();
List<int> numbbers = new List<int> {4,1,5,8,4,5,1,4};
List<int> uniqueNumbers = duplicate.FindDuplicate(numbers);
Console.WriteLine("uniqueNumbers:" + string.Join(",", uniqueNumbers));





Console.WriteLine("    ");




Calculator Add = new Calculator();
var result = Add.AddNumbers(2, 5);
Console.WriteLine("Results:" + result);


Console.WriteLine("    ");


Inventory stock = new Inventory();
while (true)
{
    Console.WriteLine("Welcome to Mega Hedge inventory collection");
    Console.WriteLine("1. Enter a new item");
    Console.WriteLine("2. Remove an item");
    Console.WriteLine("3. Update an item");
    Console.WriteLine("4. Display all item");
    Console.WriteLine("5. Exit");
    Console.Write("Choose an option");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
        Console.WriteLine("Enter an item");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the quantity");
        int quantity = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the price");
        decimal price = Convert.ToDecimal(Console.ReadLine());
        stock.AddItem(name,quantity,price);
        break;

        case 2:
        Console.WriteLine("Enter item you want to remove");
        string RemoveName = Console.ReadLine();
        stock.RemoveItem(RemoveName);
        break;

        case 3:
        Console.WriteLine("Enter an item");
        string updateName = Console.ReadLine();
        Console.WriteLine("Enter new quantity");
        int newQuantity = Convert.ToInt32(Console.ReadLine);
        stock.UpdateItem(updateName, newQuantity);
        break;

        case 4:
        stock.DisplayInventory();
        break;

        case 5:
        Environment.Exit(0);
        break;

        default:
        Console.WriteLine("Error occured. Enter a valid option");
        break;


    }





}





var collection = new Inventory();

collection.AddStudentScore("John", 85);
collection.AddStudentScore("Tobi", 80);
collection.AddStudentScore("Mahmud", 80);
collection.AddStudentScore("Amjad", 70);
collection.AddStudentScore("Eniola", 90);
collection.AddStudentScore("Yasir", 93);
collection.AddStudentScore("Mujeeb", 90);




var studentScore = collection.GetStudentScore();


//Linq

//syntax Query

var topStudent = (from score in studentScore
orderby score.Value descending
select score)
.GroupBy(x => x.Value)
.Select(m =>
new
{
    key = m.Key,
    count = m.Count()
}).OrderByDescending(x => x.count);



foreach (var student in topStudent)
{

    Console.WriteLine($"Score: {student.key}, Count: {student.count}");
}



//Method

//var topStudentMethod = studentScore
//    .Where(score => score.Value > 83)
//    .Select(score => score)
//    .OrderByDescending(score => score.Value)4;


//foreach (var student in topStudentMethod)
//{
//    Console.WriteLine($"Student: {student.Key}, Score: {student.Value}");
//}

var topStudentCount = studentScore.Sum(x => x.Value);

Console.WriteLine($"Total number of students: {topStudentCount}");





Console.Write("    ");





        NoteManager noteManager = new NoteManager();


        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("=== Student Note Keeper ===");
            Console.WriteLine("1. Write New Note (Overwrite)");
            Console.WriteLine("2. Add Note (Append)");
            Console.WriteLine("3. Read Notes");
            Console.WriteLine("4. Delete Notes");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option (1-5): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    noteManager.WriteNewNote();
                    break;
                case "2":
                    noteManager.AppendNote();
                    break;
                case "3":
                    noteManager.ReadNotes();
                    break;
                case "4":
                    noteManager.DeleteNotes();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press any key to try again.");
                    Console.ReadKey();
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        Console.WriteLine("Goodbye!");






Console.WriteLine("    ");*/





ContactBook phone = new ContactBook();
while (true)
{
    Console.WriteLine("1: Add number");
    Console.WriteLine("2: View Contact");
    Console.WriteLine("3: Search Contact");
    Console.WriteLine("4: Delete Contact");
    Console.WriteLine("5: Exit");
    Console.Write("Enter your choice");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            phone.AddContact();
            break;
        case 2:
            phone.ViewContact();
            break;
        case 3:
            phone.SearchContact();
            break;
        case 4:
            phone.DeleteContact();
            break;
        case 5:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid Choice: Please try again");
            break;

    }
}