using System;


public class Robot
{
    list<string> robotNames = new list<string>();

    public string Name
    {
        get
        {
            string randomString = GenerateRandomName();
           
            
            return randomString;
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

    public void Reset()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}