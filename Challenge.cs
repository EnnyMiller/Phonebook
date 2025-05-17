using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

public class CodeChallenge
{
    public List<int> listExample()
    {
        var numbers = new List<int> { 99,240,15,8,54};

        numbers.Add(40);
        numbers.Sort();
        numbers.Count();

        return numbers;
    
    }
    


      //Check if number is even number and greater than 10
     public List<int> evenNumbers(List<int> digits)
    {

        return digits
            .Where(IsEvenGreaterThan10)
            .ToList();

    }

    private bool IsEvenGreaterThan10(int numbers)
    {
        return(numbers > 10 && numbers % 2 == 0);
    }

    // Sum of all list
    public int CalculateSum(List<int> number)
    {
        return number.Sum();
    
    }

    //Find the index of an element
    public int FindIndex(List<int> numbers, int target)
    {
        return numbers.IndexOf(target);
    }

    // Remove duplicate
     public List<int> FindDuplicate(List<int> numbers)
    {
        return numbers.Distinct().ToList();
    }

}



public class Calculator
{
    public int AddNumbers(int firstNumber, int secondNumber)
    {
        try
        {
            Console.WriteLine("Enter first number");
             firstNumber = Convert.ToInt32(Console.ReadLine());
             
             Console.WriteLine("Enter second number");
             secondNumber = Convert.ToInt32(Console.ReadLine());

             int result = firstNumber + secondNumber;


            return result;
        }
        catch(Exception ex)
        {
            Console.WriteLine("An error occured:" + ex.Message);
            return 0;

        }
    }
    
}


public class InventoryItem
{
    public string Name;
    public int Quantity;
    public decimal Price;

    public InventoryItem(string name, int quantity, decimal price)
    {
        Name = name;
        Quantity = quantity;
        Price = price;
    }
}
class Inventory
{
    private Dictionary<string, InventoryItem> inventory = new Dictionary<string, InventoryItem>();
    public string AddItem(string name, int quantity,Decimal price)
    {
        if(inventory.ContainsKey(name))
        {
            inventory[name].Quantity += quantity;
            return "Item already exist in the inventory. Quantity updated";
        }
        else
        {
            inventory.Add(name, new InventoryItem(name,quantity,price)  );
            return "Item has been updated";
        }
    }

    public string RemoveItem(string name)
    {
        if(inventory.ContainsKey(name))
        {
            inventory.Remove(name);
            return "Item has been successfuly removed";
        }
        else
        {
            return "Item is not in the inventory";
        }
    }

    public string UpdateItem(string name, int quantity)
    {
        if(inventory.ContainsKey(name))
        {
            inventory[name].Quantity = quantity;
            return "Quantity updated";
        }
        else
        {
            return "Item cannot be found in the inventory";
        }
    }

    public void DisplayInventory()
    {
        foreach(var item in inventory.Values)
        {
            Console.WriteLine($"Name: {item.Name}, {item.Quantity}, {item.Price} ");
        }
    }




    // Dictionary Practice

     Dictionary<string, double> studentScore = new Dictionary<string, double>();

    public Dictionary<string,double> AddStudentScore(string name, double score)
    {
        if (!studentScore.ContainsKey(name))
        {
            studentScore.Add(name, score);
        }

        return studentScore;
    }

    public Dictionary<string, double> GetStudentScore()
    {
        return studentScore;
    }




    
}

public class NoteManager
{
    private string _filePath; 

    public NoteManager(string filePath = "student_notes.txt")
    { 
        _filePath = filePath; 
    }  
 
    // Overwrites the file with a new note using StreamWriter
    public void WriteNewNote() 
    {
        Console.Write("Enter your note: ");
        string note = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(_filePath, append: false)) 
        {
            writer.WriteLine(note);
        }
        Console.WriteLine("Note written successfully (overwritten).");
    }

    // Appends a new note using StreamWriter
    public void AppendNote()
    {
        Console.Write("Enter a note to add: "); 
        string note = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(_filePath, append: true))
        {
            writer.WriteLine(note);
        }

        Console.WriteLine("Note appended successfully.");
    }
    
    // Reads all notes line by line using StreamReader
    public void ReadNotes()
    {
        Console.WriteLine("\n--- All Notes ---");

        if (File.Exists(_filePath))  
        {
            using (StreamReader reader = new StreamReader(_filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        else
        {
            Console.WriteLine("No notes found.");
        }
    }

    // Deletes the file
    public void DeleteNotes() 
    {
        if (File.Exists(_filePath)) 
        {
            File.Delete(_filePath);
            Console.WriteLine("Notes deleted successfully.");
        }
        else
        {
            Console.WriteLine("No notes to delete.");
        }
    }
}






public class Phonebook
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }

    public Phonebook(string name, string phoneNumber)
    {
        Name = name;
        PhoneNumber = phoneNumber;
    }
    public override string ToString()
    {
        return $"Name: {Name}, PhoneNumber: {PhoneNumber}";
    }

}
public class ContactBook
{
    private string filepath = "contacts.txt";
    public void AddContact()
    {
        Console.WriteLine("Enter name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Phonenumber");
        string phoneNumber = Console.ReadLine();
        Phonebook contact = new Phonebook(name, phoneNumber);
        using (StreamWriter writer = File.AppendText(filepath))
        {
            writer.WriteLine($"{contact.Name}, {contact.PhoneNumber}");
            Console.WriteLine("Contact added successfully");
        }
    }

    public void ViewContact()
    {
        if (!File.Exists(filepath))
        {
            Console.Write("Contact does not exist");
            return;
        }
        using (StreamReader reader = File.OpenText(filepath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                Phonebook contact = new Phonebook(parts[0], parts[1]);
                Console.WriteLine(contact);
            }
        }
    }


    public void SearchContact()
    {
        Console.WriteLine("Enter a name");
        string name = Console.ReadLine();
        if (!File.Exists(filepath))
        {
            Console.WriteLine("No contact available");
            return;
        }
        bool found = false;
        using (StreamReader reader = File.OpenText(filepath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts[0].ToLower() == name.ToLower())
                {
                    Phonebook contact = new Phonebook(parts[0], parts[1]);
                    Console.WriteLine(contact);
                    found = true;
                }

            }
            if (!found)
            {
                Console.WriteLine("Contact not found");
            }
        }

    }


    public void DeleteContact()
    {
        Console.WriteLine("Enter a name");
        string name = Console.ReadLine();
        if (!File.Exists(filepath))
        {
            Console.WriteLine("Contact not found");
            return;
        }
        List<string> lines = new List<string>();
        bool found = false;
        using (StreamReader reader = File.OpenText(filepath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts[0].ToLower() != name.ToLower())
                {
                    lines.Add(line);
                }
                else
                {
                    found = true;
                }
            }
        }
        if (found)
        {
            File.WriteAllLines(filepath, lines);
            Console.WriteLine("Contact deleted successfully");
        }
        else
        {
            Console.WriteLine("Conatct not found");
        }
    }
}