using System;
using System.Collections.Generic;

public class Robot
{
    List<string> robotNames = new List<string>();
    private string robotName = " ";
   


    public string Name
    {
        get
        {
            return robotName;
        }

    }



    private string GenerateRandomName()
    {
        Random _rand = new Random();
        string randomString = "";
        string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        for (int i = 0; i < 5; i++)
        {
            if (i < 2)
            {
                string randomLetter = letters[_rand.Next(0, 25)];
                randomString += randomLetter;
            }
            else
            {
                string randomInt = (_rand.Next(0, 9)).ToString();
                randomString += randomInt;
            }
        }
        return randomString;
    }

    private string TrackRobotNames(string randomString)
    {
        if (robotNames.Contains(randomString))
        {
            return randomString;
        }
        else
        {
            randomString = GenerateRandomName();
            robotNames.Add(randomString);
            return randomString;
        }
    }

    //private string RobotNames
    //{
    //    set
    //    {
    //        TrackRobotNames(value);
    //    }
    //}

    public void Reset()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}