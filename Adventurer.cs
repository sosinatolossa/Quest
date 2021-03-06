using System.Collections.Generic;

namespace Quest
{
    // An instance of the Adventurer class is an object that will undergo some challenges
    public class Adventurer
    {
        // The is an "immutable" property. It only has a "get".
        // The only place the Name can be set is in the Adventurer constructor
        // Note: the constructor is defined below.
        public string Name { get; }

        // This is a mutable property it has a "get" and a "set"
        //  So it can be read and changed by any code in the application
        public int Awesomeness { get; set; }

        public Robe ColorfulRobe { get; }


        // A constructor to make a new Adventurer object with a given name
        // the value for Awesomeness is set to 50 by default so we don't pass it in the Adventurer new object
        public Adventurer(string name, Robe robe)
        {
            Name = name;
            Awesomeness = 50;
            ColorfulRobe = robe;
        }


        // This method returns a string that describes the Adventurer's status
        // Note one way to describe what this method does is:
        //   it transforms the Awesomeness integer into a status string
        public string GetAdventurerStatus()
        {
            string status = "okay";
            if (Awesomeness >= 75)
            {
                status = "great";
            }
            else if (Awesomeness < 25 && Awesomeness >= 10)
            {
                status = "not so good";
            }
            else if (Awesomeness < 10 && Awesomeness > 0)
            {
                status = "barely hanging on";
            }
            else if (Awesomeness <= 0)
            {
                status = "not gonna make it";
            }

            return $"Adventurer, {Name}, is {status}";
        }

        // Adding a new constructor parameter to the "Adventurer" class to accept a "Robe"
        //and to ser the "ColorfulRobe" property
        public string GetDescription()
        {
            string allColors = "";
            // List<string> robeColors = new List<string>();
            // robeColors = ColorfulRobe.robeColors;
            // foreach (string color in robeColors)
            // you can do what's above or just write one line for foreach
            foreach (string color in ColorfulRobe.robeColors)
            {
                allColors += $"{color} ";
            }
            return ($"Hi {Name}, you are wearing a nice {allColors}colored robe that is {ColorfulRobe.robeLength} inches long. Good luck on your quest!!");
        }
    }
}