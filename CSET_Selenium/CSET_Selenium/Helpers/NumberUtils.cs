using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Helpers
{
    static class NumberUtils
    {
		private static decimal GetCurrencyValueFrom(String elementText)
		{
			Decimal decimalValue = new Decimal();
			try
			{
				decimalValue = Decimal.Parse(elementText, NumberStyles.Currency);
			}
			catch (FormatException)
			{
				if (!elementText.Equals("-") && !elementText.Trim().Equals(""))
				{
					Assert.Fail("The text passed in to the \"getCurrencyValue\" function used was not properly formatted as a US currency, or was not \"-\", indicating a Zero dollar amount. Please investigate this failure.");
				}
				else
				{
					decimalValue = Decimal.Zero;
				}
			}
			return decimalValue;
		}
		public static decimal GetCurrencyValueFromElement(IWebElement element)
		{

			String elementText = element.Text;

			return GetCurrencyValueFrom(elementText);
		}

		public static decimal GetCurrencyValueFromElement(String elementText)
		{

			return GetCurrencyValueFrom(elementText);

		}

		/**
		 * Returns a pseudo-random number between min and max, inclusive. The
		 * difference between min and max can be at most
		 * <code>Integer.MAX_VALUE - 1</code>.
		 *
		 * @param min
		 *            Minimum value
		 * @param max
		 *            Maximum value. Must be greater than min.
		 * @return Integer between min and max, inclusive.
		 * @see java.util.Random#nextInt(int)
		 */
		public static int GenerateRandomNumberInt(int min, int max)
		{

			// NOTE: Usually this should be a field rather than a method
			// variable so that it is not re-seeded every call.
			Random rand = new Random(Environment.TickCount);

			// nextInt is normally exclusive of the top value,
			// so add 1 to make it inclusive
			int randomNum = rand.Next(max - min + 1) + min;

			return randomNum;
		}

		/**
		 * Returns a pseudo-random number between min and max, inclusive,
		 * excluding any numbers you don't want in the result. The
		 * difference between min and max can be at most
		 * <code>Integer.MAX_VALUE - 1</code>.
		 *
		 * @param min
		 *            Minimum value
		 * @param max
		 *            Maximum value. Must be greater than min.
		 * @param excludedValues
		 * 				Value you want excluded from the result.
		 * @return Integer between min and max, inclusive and excluding results listed.
		 * @see java.util.Random#nextInt(int)
		 */
		public static int GenerateRandomNumberInt(int min, int max, int excludedValue)
		{

			// NOTE: Usually this should be a field rather than a method
			// variable so that it is not re-seeded every call.
			Random rand = new Random(Environment.TickCount);

			// nextInt is normally exclusive of the top value,
			// so add 1 to make it inclusive
			int randomNum = rand.Next(max - min + 1) + min;

			if (randomNum == excludedValue)
			{
				randomNum = randomNum + 1;
			}

			/*boolean randomNumberOnExcludedList = false;

			for (int value : excludedValues) {
				while (randomNumberOnExcludedList = false) {
					if (randomNum == value) {
						randomNumberOnExcludedList = true;
					}
				}
			}

			if (randomNumberOnExcludedList == true) {
				randomNum = randomNum + 1;
			}*/

			return randomNum;
		}

		public static int GetRandomIntFromArray(int[] array)
		{
			int rnd = new Random().Next(array.Count());
			return array[rnd];
		}

		public static int GetRandomIntFromList(List<int> array)
		{
			if (array.Count() < 1)
			{
				Assert.Fail("The passed-in array is empty.");
			}

			int randomOption = NumberUtils.GenerateRandomNumberInt(0, array.Count() - 1);
			return array.ElementAt(randomOption);
		}

		/**
		 * Returns a pseudo-random number as many digits long as you want.
		 *
		 * @param length
		 *            Length (Number of Digits) of random number generated.
		 * @return String random number x digits long.
		 * @see java.util.Random#nextInt(int)
		 */
		public static long generateRandomNumberDigits(int length)
		{
			String resultantNumber = StringsUtils.generateRandomNumberDigits(length);
			long numberFromResult = long.Parse(resultantNumber);
			return numberFromResult;
		}

		/**
		 * Returns a pseudo-random number as many digits long as you want.
		 *
		 * @param length
		 *            Length (Number of Digits) of random number generated.
		 * @return String random number x digits long.
		 * @see java.util.Random#nextInt(int)
		 */
		public static long GenerateRandomNumberDigits(int minLength, int maxLength)
		{
			String resultantNumber = StringsUtils.generateRandomNumberDigits(minLength, maxLength);
			long numberFromResult = long.Parse(resultantNumber);
			return numberFromResult;
		}

		public static double Round(double numberToRound, int places)
		{
			if (places < 0)
			{
				throw new ArgumentException("The number of places to round cannot be less than zero. Please correct this.");
			}

			return Math.Round(numberToRound, places, MidpointRounding.AwayFromZero);
		}

		public static List<Double> RemoveHighestOrLowestListValue(List<Double> listToManipulate, String highestOrLowestOption)
		{
			int index = 0;
			if (highestOrLowestOption.Equals("Highest", StringComparison.OrdinalIgnoreCase))
			{
				if (listToManipulate.Count() > 0)
				{
					double highest = listToManipulate.ElementAt(0);
					for (int i = 1; i < listToManipulate.Count(); i++)
					{
						double currentValue = listToManipulate.ElementAt(i);
						if (currentValue > highest)
						{
							highest = currentValue;
							index = i;
						}
					}
				}
			}
			else if (highestOrLowestOption.Equals("Lowest", StringComparison.OrdinalIgnoreCase))
			{
				if (listToManipulate.Count() > 0)
				{
					double lowest = listToManipulate.ElementAt(0);
					for (int i = 1; i < listToManipulate.Count(); i++)
					{
						double currentValue = listToManipulate.ElementAt(i);
						if (currentValue < lowest)
						{
							lowest = currentValue;
							index = i;
						}
					}
				}
			}
			listToManipulate.RemoveAt(index);
			return listToManipulate;
		}


		public static bool IsBetween(int value, int lowValue, int highValue)
		{
			return lowValue < value && value < highValue;
		}
	}
}
