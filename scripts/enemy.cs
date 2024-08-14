using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    private int overall;
    private name;
    private team;
     private static readonly Random random = new Random();

    private static readonly List<string> maleFirstNames = new List<string> {
    "Adam", "Alexander", "Andrew", "Benjamin", "Brian", "Charles", "Christopher", "Daniel", "David", "Dominic",
    "Ethan", "Frank", "Gabriel", "Henry", "Isaac", "Jacob", "James", "Jason", "Jeremy", "John", "Joseph",
    "Joshua", "Julian", "Kevin", "Liam", "Matthew", "Michael", "Nicholas", "Noah", "Oliver", "Patrick",
    "Peter", "Richard", "Robert", "Ryan", "Samuel", "Thomas", "William"};
    private static readonly List<string> maleLastNames = new List<string> {
    "Anderson", "Brown", "Campbell", "Carson", "Clark", "Cox", "Davis", "Dixon", "Duncan", "Ellis",
    "Evans", "Ferguson", "Ford", "Garcia", "Harris", "Henderson", "Hill", "Hunt", "Jackson", "Johnson",
    "Jones", "Kelly", "King", "Lee", "Lewis", "Lopez", "Martin", "Mitchell", "Moore", "Murphy",
    "Nelson", "Parker", "Perez", "Peterson", "Phillips", "Price", "Ramirez", "Reed", "Rogers", "Russell",
    "Sanchez", "Sanders", "Thomas", "Thompson", "Torres", "Turner", "Walker", "Watson", "White", "Williams",
    "Wilson", "Young"};


    public enemy(int overall, string name, string team)
    {
        this.overall = overall;
        this.name = name;
    }
    private void getOverall()
    {
        return overall;  
    }

    private void getName()
    {
        return GenerateRandomName();
    }
    public static string GenerateRandomName()
    {
        string firstName = maleFirstNames[random.Next(maleFirstNames.Count)];
        string lastName = maleLastNames[random.Next(maleLastNames.Count)];
        return firstName + " " + lastName;
    }
}
