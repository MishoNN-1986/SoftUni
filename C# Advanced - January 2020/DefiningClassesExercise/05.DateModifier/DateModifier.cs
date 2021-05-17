using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        public int CalculateDifference(string firstDate, string secondDate)
        {
            int[] firstDateInfo = firstDate
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int firstYear = firstDateInfo[0];
            int firstMonth = firstDateInfo[1];
            int firstDay = firstDateInfo[2];

            int[] secondDateInfo = secondDate
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            int secondYear = secondDateInfo[0];
            int secondMonth = secondDateInfo[1];
            int secondDay = secondDateInfo[2];

            DateTime firstDateTime = new DateTime(firstYear, firstMonth, firstDay);
            DateTime secondDateTime = new DateTime(secondYear, secondMonth, secondDay);
            return Math.Abs((firstDateTime - secondDateTime).Days);
        }
    }
}
