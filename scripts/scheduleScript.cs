
using System.Collections.Generic;
using System;
using UnityEngine;



public class scheduleScript
{
    private static readonly List<string> weightClasses = new List<string> { "125 lbs", "133 lbs", "141 lbs", "149 lbs", "157 lbs", "165 lbs", "174 lbs", "184 lbs", "190 lbs", "285 lbs" };
    private static readonly List<string> team1Wrestlers = new List<string>();
    private  Random random = new Random();

    void start(){
        LoadScene();
        GenerateSchedules();
        DisplaySchedule();
    }

public static void GenerateTeamWrestlers()
    {
        // Generate team1 wrestlers
        for (int i = 0; i < 10; i++)
        {
            Enemy enemy = new Enemy(); // Replace with your Enemy class
            string wrestlerName = enemy.GenerateRandomName(); // Replace with your Enemy class method to generate a random wrestler name
            team1Wrestlers.Add(wrestlerName);
        }

      
    }

    public static List<List<string>> GenerateSchedule(string selectedWeightClass)
    {
        List<List<string>> schedule = new List<List<string>>();

        int selectedWeightClassIndex = weightClasses.IndexOf(selectedWeightClass);

        if (selectedWeightClassIndex >= 0)
        {
            List<string> match = new List<string>();

            int randomIndex1 = random.Next(team1Wrestlers.Count);

            match.Add(team1Wrestlers[randomIndex1]);

            schedule.Add(match);
        }

        return schedule;
    }

    public static void DisplaySchedule(List<List<string>> schedule)
    {
        foreach (List<string> match in schedule)
        {
            string team1Wrestler = match[0];

            int team1NameLength = team1Wrestler.Length;

            int maxNameLength = Math.Max(team1NameLength);

            string team1PaddedName = team1Wrestler.PadRight(maxNameLength);

            string team1VS = "VS".PadLeft((maxNameLength * 2) - 2);

         //   string output = $"{team1PaddedName} {team1VS} {playerName}";

            Debug.Log(output);
        }
    }
}