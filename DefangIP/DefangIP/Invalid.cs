using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Program
{
    class Invalid
    {

        public static IList<string> InvalidTransactions(string[] transactions)
        {
            IList<string> answers = new List<string>();
            List<string> names = new List<string>();
            List<int> time = new List<int>();
            List<int> amounts = new List<int>();
            List<string> cities = new List<string>();

            // Iterate through each row in input and put into lists
            for (int i = 0; i < transactions.Length; i++)
            {
                string stream = new string(transactions[i]);
                string[] values = stream.Split(',');
                names.Add(values[0]);
                time.Add(int.Parse(values[1]));
                amounts.Add(int.Parse(values[2]));
                cities.Add( values[3]);                
            }

            for (int j = 0; j < transactions.Length; j++)
            {

                if (amounts[j] >= 1000)
                {
                    answers.Add(transactions[j]);
                    continue;
                }

                // if same name and transactions within 60 minutes and town name is distinct.  Add it to answers
                if (IsInvalid(names, time, cities, j))
                {
                    answers.Add(transactions[j]);                    
                }
            }

            return answers;
        }

        private static bool IsInvalid(List<string> names, List<int> times, List<string> cities, int position)
        {
           
            // get all transactions for given person, don't care about index position
            List<int> allByPerson = GetPersonData( names, names[position]);
            if (allByPerson.Count == 1) { return false; }
            // compare index to others to narrow down to within 60 minutes
          List<int> allInvalidTimes =  GetInvalidTimes(allByPerson, times, position);
            // compare index to values within 60 minutes, distinct city

            return HasDistinctCity(allInvalidTimes, cities, position);
        }

        private static List<int> GetPersonData(List<string> names, string matchName)
        {
            List<int> namePositions = new List<int>();

            for (int k = 0; k < names.Count; k++)
            {
                if (names[k] == matchName) { namePositions.Add(k); }
            }

            return namePositions;
        }

        private static List<int> GetInvalidTimes(List<int> namePositions, List<int> times, int indexTimeToMatch)
        {
            List<int> positions = new List<int>();

          //  for (int l = 0; l < namePositions.Count; l++)
          foreach (int namePosition in namePositions)
            {
                // need to do some math for times to see if it's within 60 minutes before or after.             
                if (Math.Abs(times[namePosition] - times[indexTimeToMatch]) <=60)
                {
                    positions.Add(namePosition);
                }
            }

            return positions;
        }

        private static bool HasDistinctCity(List<int> cityPositions, List<string> cities, int indexToCheck)
        {
            bool cityDistinct = false;

            for (int m = 0; m < cityPositions.Count; m++)
            {
                if (cityPositions[m] == indexToCheck ) { continue; }

                if (cities[cityPositions[m]] != cities[indexToCheck]) { cityDistinct = true; }
            }

            return cityDistinct;
        }
    }
}
