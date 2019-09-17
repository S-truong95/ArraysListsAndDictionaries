using System;
using System.Collections.Generic;

namespace ArraysListAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[10];
            //Integer Array named numbers that has 10 indices(Index)
            numbers[5] = 9;
            numbers[9] = 1111;
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = 1;
            }


            int[] otherNumbers = new int[] { 1, 3, 5, 7, 9 };
            //different ways to write an array

            int[] newOtherNumbers = { 1, 3, 5, 7, 9 };
            //alternative syntax to above declaration

            string[] namesOfTerribleCharacters = { "Jim", "Pan", "Dwight", "All of Game of Thrones" };

            List<int> numbersList = new List<int>();
            //List named numbers

            //Adding to a List
            numbersList.Add(1);
            numbersList.Add(5);

            numbersList.RemoveAt(0);
            //removes at index 0
            numbersList.Remove(5);
            //removes the first instance

            List<string> animals = new List<string>() { "bird", "cat", "dog" };

            List<string> officeList = new List<string>();

            officeList.Add("Jim");
            officeList.Add("Pam");
            officeList.Add("Dwight");

            //List<Person> theOffice = new List<Person>();


            //Dictionaries

            Dictionary<string, string> characters = new Dictionary<string, string>();

            characters.Add("24601", "Jean Val Jean");

            characters.Remove("24601");

            Dictionary<int, string> newCharacters = new Dictionary<int, string>();

            newCharacters.Add(24601, "Jean Val Jean");

        }
    }
}
