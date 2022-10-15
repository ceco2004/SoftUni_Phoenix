using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Ex01._DefiningClasses
{
    public class DateModifier
    {
       private DateTime date1;
       private DateTime date2;
       private int diffrence;

       public DateTime Date1 { get; private set; }
       public DateTime Date2 { get; private set; }

       public int Diffrence { get; private set; }

        public DateModifier(string dateAsString_1, string dateAsString_2)
        {
            Date1 = ConvertToDate(dateAsString_1);
            Date2 = ConvertToDate(dateAsString_2);
            Diffrence = Math.Abs(Date1.Subtract(Date2).Days);
        }

        private DateTime ConvertToDate(string dataAsString)
        {
            return DateTime.ParseExact(dataAsString, "yyyy MM dd", DateTimeFormatInfo.InvariantInfo);
        }
    }
}
