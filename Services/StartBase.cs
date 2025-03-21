using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace RiskDev.Services
{
    public class StartBase
    {
        private const string dateFormat = "MM/dd/yyyy";

        public DateTime? StringToDate(string? date)
        {
            if (string.IsNullOrEmpty(date))
                return null;

            DateTime resultDate = DateTime.MinValue;
            if (DateTime.TryParseExact(date, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out resultDate))
                return resultDate;

            return null;
        }

        public int? StringToInt(string value)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            int resultValue = 0;
            if (int.TryParse(value, out resultValue))
                return resultValue;

            return null;
        }

        public double? StringToDouble(string value)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            double resultValue = 0;
            if (double.TryParse(value, out resultValue))
                return resultValue;

            return null;
        }
    }
}