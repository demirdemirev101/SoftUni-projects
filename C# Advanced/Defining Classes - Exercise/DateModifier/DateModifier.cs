using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        public static int DateDifference(string startDateAsString, string endDateAsString)
        {
            DateTime startDate= DateTime.Parse(startDateAsString);
            DateTime endDate= DateTime.Parse(endDateAsString);

            var difference=endDate-startDate;
            int result = difference.Days;
            return Math.Abs(result);
        }
    }
}
