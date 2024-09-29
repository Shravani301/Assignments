using System;
using System.Collections;
using System.Drawing;

namespace EnumDemo
{
    enum Week
    {
        // enum is to define our own data types (Enumerated Data Types).
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum Color
    {
        // enum data members
        Red,
        Yellow,
        Blue,

        // assigning value yellow(1) + 5
        Green = Yellow + 5,
        Brown,

        // assigning value Green(6) + 3
        Black = Green + 3
    }

    // Changing the type of Enum’s Data Member
    // changing the type to byte using :
    enum Light : byte
    {
        // OFF denotes the Light is switched Off... with value 0
        Off,

        // ON denotes the Light is switched on.. with value 1
        On
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The difference between Special Initialisation cases and non-initialisation cases\n\n");

            // Printing Week enum values
            PrintEnumValues<Week>("Week Enum");

            // Colors is the special initialization case demonstrated as expected
            // Red will be assigned value 0, similarly Yellow will be 1 and Blue will be 2
            // Green will be assigned the value Yellow(1) + 5 = 6, and so on
            PrintEnumValues<Color>("Color Enum");

            // checking with the byte whether light is on or off
            CheckLightStatus();

            //with the stack checking the enumerator
            //This method returns an IEnumerator that iterates through the Stack.
            Console.WriteLine("\nEnum trying with stack");
            Stack myStack = new Stack();
            myStack.Push("Welcome");
            myStack.Push("to");
            myStack.Push("C#");
            PrintStackElements(myStack);

            // CharEnumerator.Clone Method is used to create a copy of the current CharEnumerator object.
            // This is useful for saving the current state while iterating through a String object.
            string str = "The Sun rises in the East, sets in the West.";
            PrintStringCharacters(str);

            // Instantiate a copy of CharEnumerator object with the current state
            CloneAndPrintEnumerator(str);
        }

        // An explicit cast is required to convert from enum type to an integral type.
        public static void PrintEnumValues<T>(string enumName) where T : Enum
        {
            Console.WriteLine($"\n{enumName} Enum Values:");
            foreach (var enumValue in Enum.GetValues(typeof(T)))
            {
                Console.WriteLine($"Value of {enumValue} is {(int)enumValue}");
            }
        }

        // checking with the byte whether light is on or off
        public static void CheckLightStatus()
        {
            Console.WriteLine("\nChecking whether the light is on or off using byte input:");
            if (byte.TryParse(Console.ReadLine(), out byte input))
            {
                if (input == (byte)Light.Off)
                    Console.WriteLine("Checking with byte type (OFF): " + Light.Off);
                else if (input == (byte)Light.On)
                    Console.WriteLine("Checking with the byte type (ON): " + Light.On);
                else
                    Console.WriteLine("Byte cannot store values other than 0 and 1.");
            }
            else
            {
                Console.WriteLine("Invalid byte input.");
            }
        }

        // This method returns an IEnumerator that iterates through the Stack.
        public static void PrintStackElements(Stack stack)
        {
            IEnumerator enumerator = stack.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

        // Printing characters from a string
        public static void PrintStringCharacters(string str)
        {
            CharEnumerator charEnum = str.GetEnumerator();
            Console.WriteLine("\nCharacters in the string up to the first comma:");
            while (charEnum.MoveNext())
            {
                Console.Write(charEnum.Current);
                if (charEnum.Current == ',')
                {
                    Console.WriteLine();
                    break;
                }
            }
        }

        // Cloning the CharEnumerator and printing the remaining characters
        public static void CloneAndPrintEnumerator(string str)
        {
            CharEnumerator charEnum = str.GetEnumerator();
            CharEnumerator charEnumClone = (CharEnumerator)charEnum.Clone();

            // Printing the rest of the characters
            while (charEnumClone.MoveNext())
            {
                Console.Write(charEnumClone.Current);
            }

            // Printing the Type of the CharEnumerator objects and its clone
            Console.WriteLine($"\nType of CharEnumerator Object: {charEnum.GetType()}");
            Console.WriteLine($"Type of CharEnumerator clone Object: {charEnumClone.GetType()}");
        }
    }
}
