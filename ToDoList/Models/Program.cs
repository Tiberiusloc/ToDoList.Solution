using System.Collections.Generic;
using ToDoList.Models;
using System.Linq;
using System;

namespace program.cs 
{
  public class program 
  {
    public static void Main()
    {
      List<Item> newList = new List<Item> {};
      Console.WriteLine("Welcome to the To Do List, Massa.");
      Console.WriteLine("-------------------------------------");
      Console.WriteLine("Do you want to add an item to your list or view it?");
      Console.WriteLine("Add/View");
      string UserInput = Console.ReadLine();
      if (UserInput.ToLower() == "add") 
      {
        Console.WriteLine("Enter description for new item: ");
        string ItemDesc = Console.ReadLine();
        Item newItem = new Item(ItemDesc);
        Console.WriteLine("" + newItem.Description + "" + " has been added to the list. Would you like to add to or view your list?(Add/View)");
        string reset = Console.ReadLine();
        if(reset.ToLower() == "add"){
          Main();
        } 
        else 
        {
        Console.WriteLine("You're now viewing your Item List, Massa"); 
        var listItems = Item.GetAll();    
        foreach (Item element in listItems)
        {
          Console.WriteLine(element.Description);
        }    
        Console.WriteLine("Type done when finished viewing, Massa");
        string userFinished = Console.ReadLine();
        if(userFinished.ToLower() == "done") {
          Main();
        }
        }
      }
      else if (UserInput.ToLower() == "view")
      {
        Console.WriteLine("You're now viewing your Item List, Massa");
        var listItems = Item.GetAll();
        foreach (Item element in listItems)
        {
          Console.WriteLine(element.Description);
        }
        Console.WriteLine("Type done when finished viewing, Massa");
        string userFinished = Console.ReadLine();
        if(userFinished.ToLower() == "done"){
          Main();
        }
      } 
    }
  }
}