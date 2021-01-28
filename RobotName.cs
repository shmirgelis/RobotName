using System;
using System.Collections.Generic;

public class Robot
{
    public Robot()
    {
        name = UniqueRobotName();
    }

    List<string> robotNames = new List<string>();
    private string name;



    public string Name
    {
        get
        {
            return name;
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

    private string UniqueRobotName()
    {
        string randomName;
        do
        {
            randomName = GenerateRandomName();
        } while(robotNames.Contains(randomName));
        robotNames.Add(randomName);
        return randomName;
    }


    public void Reset()
    {
        name = UniqueRobotName();
    }
}