using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime dob)
        {
            var today = DateTime.Today; // Save today's date.
            var age = today.Year - dob.Year; // Calculate the age.
          if (dob.Date > today.AddYears(-age)) age--; // Go back to the year in which the person was born in case of a leap year
            return age;
        }
    }
}