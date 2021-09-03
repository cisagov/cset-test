using CSET_Selenium.Enums;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Helpers
{
    class DateUtils
    {
		public static DateTime dateAddSubtract(DateTime dateToChange, DateAddSubtractOptions changeFormat, int amountToChange)
		{
			switch (changeFormat)
			{
				case DateAddSubtractOptions.Day:
					dateToChange.AddDays(amountToChange);
					break;
				case DateAddSubtractOptions.Week:
					dateToChange.AddDays(7 * amountToChange);
					break;
				case DateAddSubtractOptions.Month:
					dateToChange.AddMonths(amountToChange);
					break;
				case DateAddSubtractOptions.Quarter:
					dateToChange.AddMonths(3 * amountToChange);
					break;
				case DateAddSubtractOptions.Year:
					dateToChange.AddYears(amountToChange);
					break;
				case DateAddSubtractOptions.Hour:
					dateToChange.AddHours(amountToChange);
					break;
				case DateAddSubtractOptions.BusinessDay:
					if (dateToChange.DayOfWeek == DayOfWeek.Saturday)
					{
						dateToChange = dateToChange.AddDays(2);
						amountToChange -= 1;
					}
					else if (dateToChange.DayOfWeek == DayOfWeek.Sunday)
					{
						dateToChange = dateToChange.AddDays(1);
						amountToChange -= 1;
					}

					dateToChange = dateToChange.AddDays(amountToChange / 5 * 7);
					int extraDays = amountToChange % 5;

					if ((int)dateToChange.DayOfWeek + extraDays > 5)
					{
						extraDays += 2;
					}
					dateToChange.AddDays(extraDays);
					break;
				default:
					break;
			}
			return dateToChange;
		}

		public static int GetBusinessDays(DateTime start, DateTime end)
		{
			if (start.DayOfWeek == DayOfWeek.Saturday)
			{
				start = start.AddDays(2);
			}
			else if (start.DayOfWeek == DayOfWeek.Sunday)
			{
				start = start.AddDays(1);
			}

			if (end.DayOfWeek == DayOfWeek.Saturday)
			{
				end = end.AddDays(-1);
			}
			else if (end.DayOfWeek == DayOfWeek.Sunday)
			{
				end = end.AddDays(-2);
			}

			int diff = (int)end.Subtract(start).TotalDays;

			int result = diff / 7 * 5 + diff % 7;

			if (end.DayOfWeek < start.DayOfWeek)
			{
				return result - 2;
			}
			else
			{
				return result;
			}
		}

		public static int getYearFromDate(DateTime date)
		{
			return date.Year;
		}

		public struct DateTimeSpan
		{
			public int Years { get; }
			public int Months { get; }
			public int Days { get; }
			public int Hours { get; }
			public int Minutes { get; }
			public int Seconds { get; }
			public int Milliseconds { get; }

			public DateTimeSpan(int years, int months, int days, int hours, int minutes, int seconds, int milliseconds)
			{
				Years = years;
				Months = months;
				Days = days;
				Hours = hours;
				Minutes = minutes;
				Seconds = seconds;
				Milliseconds = milliseconds;
			}

			enum Phase { Years, Months, Days, Done }

			public static DateTimeSpan CompareDates(DateTime date1, DateTime date2)
			{
				if (date2 < date1)
				{
					var sub = date1;
					date1 = date2;
					date2 = sub;
				}

				DateTime current = date1;
				int years = 0;
				int months = 0;
				int days = 0;

				Phase phase = Phase.Years;
				DateTimeSpan span = new DateTimeSpan();
				int officialDay = current.Day;

				while (phase != Phase.Done)
				{
					switch (phase)
					{
						case Phase.Years:
							if (current.AddYears(years + 1) > date2)
							{
								phase = Phase.Months;
								current = current.AddYears(years);
							}
							else
							{
								years++;
							}
							break;
						case Phase.Months:
							if (current.AddMonths(months + 1) > date2)
							{
								phase = Phase.Days;
								current = current.AddMonths(months);
								if (current.Day < officialDay && officialDay <= DateTime.DaysInMonth(current.Year, current.Month))
									current = current.AddDays(officialDay - current.Day);
							}
							else
							{
								months++;
							}
							break;
						case Phase.Days:
							if (current.AddDays(days + 1) > date2)
							{
								current = current.AddDays(days);
								var timespan = date2 - current;
								span = new DateTimeSpan(years, months, days, timespan.Hours, timespan.Minutes, timespan.Seconds, timespan.Milliseconds);
								phase = Phase.Done;
							}
							else
							{
								days++;
							}
							break;
					}
				}

				return span;
			}
		}

		public static int getDifferenceBetweenDates(DateTime firstDateTime, DateTime secondDateTime, DateDifferenceOptions dateDifferenceOption)
		{
			int dateDifference = 0;
			var dateSpan = DateTimeSpan.CompareDates(firstDateTime, secondDateTime);
			switch (dateDifferenceOption)
			{
				case DateDifferenceOptions.Day:
					dateDifference = dateSpan.Days;
					break;
				case DateDifferenceOptions.Month:
					dateDifference = dateSpan.Months;
					break;
				case DateDifferenceOptions.Year:
					dateDifference = dateSpan.Years;
					break;
				case DateDifferenceOptions.Hour:
					dateDifference = dateSpan.Hours;
					break;
				default:
					//A case does not currently exist for the option selected.
					break;
			}
			return dateDifference;
		}

		/** This method simply takes the date passed in and formats it according to the format specified. It then returns it as a string.
		 * 
		 * @param dateFormat
		 * String format to be used for formatting the date returned. This uses the "SimpleDateFormat" class from oracle.
		 * The documentation for this class can be found here: <a href="http://docs.oracle.com/javase/7/docs/api/java/text/SimpleDateFormat.html">http://docs.oracle.com/javase/7/docs/api/java/text/SimpleDateFormat.html</a>
		 * @param dateToFormat
		 * Date that you need to have formatted
		 * @return
		 */
		public static String dateFormatAsString(DateTime dateToFormat, String dateFormat)
		{
			return dateToFormat.ToString(dateFormat);
		}

		/** This method simply takes the date passed in and formats it according to the format specified. It then returns it as an Integer.
		 * 
		 * @param dateFormat
		 * String format to be used for formatting the date returned. This uses the "SimpleDateFormat" class from oracle.
		 * The documentation for this class can be found here: <a href="http://docs.oracle.com/javase/7/docs/api/java/text/SimpleDateFormat.html">http://docs.oracle.com/javase/7/docs/api/java/text/SimpleDateFormat.html</a>
		 * @param dateToFormat
		 * Date that you need to have formatted
		 * @return
		 */
		public static int dateFormatAsInt(DateTime dateToFormat, String dateFormat)
		{
			String formattedDate = dateFormatAsString(dateToFormat, dateFormat);
			return Int32.Parse(formattedDate);
		}

		/** This method takes the date passed in as a String (useful when pulling a date from a page in Guidewire) and converts
		 * it to a date object for use elsewhere.
		 * 
		 * @param dateString
		 * The date needing conversion, passed in as a string.
		 * @param dateFormat
		 * String format to be used for formatting the date returned. This uses the "SimpleDateFormat" class from oracle.
		 * The documentation for this class can be found here: <a href="http://docs.oracle.com/javase/8/docs/api/java/text/SimpleDateFormat.html">http://docs.oracle.com/javase/8/docs/api/java/text/SimpleDateFormat.html</a>
		 * @return date
		 * The date object resulting from the conversion from a string value.
		 * @throws Exception 
		 * @throws ParseException
		 */
		public static DateTime convertStringtoDate(String dateString, String dateFormat)
		{
			DateTime date = DateTime.ParseExact(dateString, dateFormat, null);
			return date;
		}
	
		/** This method is useful for taking a date-time combo (Most prevalent when using the "getCenterDate" methods) and getting just the portion declared in the dateFormat passed in.
		 * For options regarding the date formats possible, please follow this link: <a href="http://docs.oracle.com/javase/7/docs/api/java/text/SimpleDateFormat.html">http://docs.oracle.com/javase/7/docs/api/java/text/SimpleDateFormat.html</a>
		 * @param dateTimeCombo
		 * A Full Date-Time combination (Usually obtained from the getCenterDate Methods)
		 * @param dateFormat
		 * String Format for the date-time combo.
		 * @return dateValueOfFormat
		 * The Date (fastTime) returned as only the format passed in.
		 */
		public static DateTime getDateValueOfFormat(DateTime dateTimeCombo, String dateFormat)
		{
			String dateTimeComboString = dateFormatAsString(dateTimeCombo, dateFormat);
			DateTime dateValueOfFormat = new DateTime();
			try
			{
				dateValueOfFormat = convertStringtoDate(dateTimeComboString, dateFormat);
			}
			catch (Exception e)
			{
				Assert.Fail("Parse Exception: The Date-Time Combo could not be parsed to convert to a date without time.");
			}
			return dateValueOfFormat;
		}
	}
}
