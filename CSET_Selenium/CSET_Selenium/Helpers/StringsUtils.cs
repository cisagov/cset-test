using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace CSET_Selenium.Helpers
{
	static class StringsUtils
    {
		public static bool EqualsIgnoreCase(String firstString, String secondString)
		{
			return firstString.Equals(secondString, StringComparison.OrdinalIgnoreCase);
		}
		public static String[] SplitStringByString(String stringToSplit, String splitString)
        {
			String[] stringSplit = stringToSplit.Split(new string[] { splitString }, StringSplitOptions.None);
			return stringSplit;
		}
		public static String[] GetStringSplitFromFullName(String fullName)
		{
			String[] splitName = fullName.Split(' ');
			switch (fullName)
			{ //special people with special last names and such
				case "First M Last":
					splitName[0] = "First";
					splitName[splitName.Length - 1] = "M Last";
					break;
			}
			return splitName;
		}

		/**
		 * Returns a cleaned-up version of the xpath passed in as a
		 * string value. This escapes characters that, if not escaped,
		 * will cause the xpath to not evaluate.
		 *
		 * @param sqlQueryString
		 *            Messy xpath with characters that need to be escaped.
		 * @return String with the special charaters for an xpath (',") escaped.
		 */
		public static String SpecialCharacterEscape(String sqlQueryString)
		{
			String returnString = "";
			String searchString = sqlQueryString;
			char[] quoteChars = new char[] { '\'', '"' };

			int quotePos = searchString.IndexOfAny(quoteChars);
			if (quotePos == -1)
			{
				returnString = searchString;
			}
			else
			{
				while (quotePos != -1)
				{
					String subString = searchString.Substring(0, quotePos);
					returnString += subString;
					if (searchString.Substring(quotePos, (quotePos + 1)).Equals("'"))
					{
						returnString += "'";
					}
					else
					{
						//must be a double quote
						returnString += "\"";
					}
					searchString = searchString.Substring(quotePos + 1, searchString.Length);
					quotePos = searchString.IndexOfAny(quoteChars);
				}
				returnString += searchString;
			}
			return returnString;
		}

		/**
		 * Returns a cleaned-up version of the xpath passed in as a
		 * string value. This escapes characters that, if not escaped,
		 * will cause the xpath to not evaluate.
		 *
		 * @param xPathQueryString Messy xpath with characters that need to be escaped.
		 * @return String with the special charaters for an xpath (',") escaped.
		 * @Warning PLEASE NOTE: This method will require an xpath to not be surrounded by single ticks to work correctly. I.E. - findElements(By.xpath(".//div[contains(text(), " + StringsUtils.xPathSpecialCharacterEscape(companyName) + ")]
		 * instead of findElements(By.xpath(".//div[contains(text(), <b>'</b> " + StringsUtils.xPathSpecialCharacterEscape(companyName) + " <b>'</b> )]
		 */
		public static String XPathSpecialCharacterEscape(String xPathQueryString)
		{
			String returnString = "";
			String searchString = xPathQueryString;
			char[] quoteChars = new char[] { '\'', '"' };

			int quotePos = searchString.IndexOfAny(quoteChars);
			if (quotePos == -1)
			{
				returnString = "'" + searchString + "'";
			}
			else
			{
				returnString = "concat(";
				while (quotePos != -1)
				{
					String subString = searchString.Substring(0, quotePos);
					returnString += "'" + subString + "', ";
					if (searchString.Substring(quotePos, quotePos + 1).Equals("'"))
					{
						returnString += "\"'\", ";
					}
					else
					{
						//must be a double quote
						returnString += "'\"', ";
					}
					searchString = searchString.Substring(quotePos + 1, searchString.Length);
					// This was in the code originally included. I cannot figure out what it was meant to do.
					// searchString = searchString.substring(quotePos + 1, searchString.length() - quotePos - 1);
					quotePos = searchString.IndexOfAny(quoteChars);
				}
				returnString += "'" + searchString + "')";
			}
			return returnString;
		}

		public static String[] CityStateZipParserRegex(String cityStateZipComboToParse)
		{
			String[] returnStringArray = Regex.Split(cityStateZipComboToParse, ",\\s*|\\s(?=\\d)");
			return returnStringArray;
		}

		/** This method will take a line of text containing a city, state, zip, and postal code combo and split it into individual parts.
		 * @param cityStateZipComboToParse - String combo of city, state, zip, and postal code to parse out.
		 * @return String[] - Array of strings corresponding to the individual pieces of the split-out combo. The map of items is as follows:
		 * <p> 0 - City </p>
		 * <p> 1 - State </p>
		 * <p> 2 - Zip </p>
		 * <p> 3 - Postal Code </p>
		 */
		public static String[] CityStateZipParser(String cityStateZipComboToParse)
		{
			String[] citySplit = cityStateZipComboToParse.Split(',');
			String city = citySplit[0];
			String[] stateZip = citySplit[1].Trim().Split(' ');
			String state = stateZip[0];
			String zip = stateZip[1];
			String postalCode = null;
			if (zip.Contains("-"))
			{
				String[] zipSplit = zip.Split('-');
				zip = zipSplit[0];
				postalCode = zipSplit[1];
			}

			String[] returnStringArray = { city, state, zip, postalCode };
			return returnStringArray;
		}

		public static String[] FirstLastNameParser(String fullNameToParse)
		{
			String[] firstLastNameArray = fullNameToParse.Split(' ');
			return firstLastNameArray;
		}

		public static String FormatDoubleValueToDecimalPlaces(double number, int numberOfDecimalPlaces)
		{
			return number.ToString("D" + numberOfDecimalPlaces);
		}

		public static String FormatDecimalValueToDecimalPlaces(decimal number, int numberOfDecimalPlaces)
		{
			return number.ToString("N" + numberOfDecimalPlaces);
		}

		public static String CurrencyRepresentationOfNumber(decimal number)
		{
			return number.ToString("C", CultureInfo.CurrentCulture);
		}

		public static String GetUserNameFromFirstLastName(String firstLastName)
		{
			String firstName = FirstLastNameParser(firstLastName)[0];
			String lastName = FirstLastNameParser(firstLastName)[1];
			String userName = firstName.Substring(0, 1) + lastName;
			return userName;
		}

		public static String FormatTIN(String tin)
		{
			return tin.Substring(0, 2) + "-" + tin.Substring(2, tin.Length);
		}

		public static String FormatSSN(String ssn)
		{
			if (ssn.Length == 9)
			{
				return ssn.Substring(0, 3) + "-" + ssn.Substring(3, 5) + "-" + ssn.Substring(5, ssn.Length);
			}
			else if (ssn.Length == 11)
			{
				return ssn;
			}
			else
			{
				return "";
			}
		}

		/*Valid SSN Rules
	  "(?!\\b(\\d)\\1+-?(\\d)\\1+-?(\\d)\\1+\\b)"+           //Don't allow all matching digits for every field with optional dashes
	  "(?!123-45-6789|987-65-4321|219-09-9999|078-05-1120)"+ //Don't allow "123-45-6789", "987-65-4321", "219-09-9999", or "078-05-1120"
	  "(?!666|000|9\\d{2})\\d{3}"+                           //Don't allow the SSN to begin with 666, 000, or anything between 900-999
	  "-?"+                                                  //An optional dash (separating Area and Group numbers)
	  "(?!00)\\d{2}"+                                        //Don't allow the Group Number to be "00"            
	  "-?"+                                                  //Another optional dash (separating Group and Serial numbers)
	  "(?!0{4})\\d{4}$"                                      //Don't allow last four digits to be "0000"
		 */
		public static String GetValidSSN()
		{
			String ssn = GenerateRandomNumberDigits(9);
			String ssnRegex = "^(?!219099999|078051120)(?!666|000|9\\d{2})\\d{3}(?!00)\\d{2}(?!0{4})\\d{4}$"; // Above regex simplified to test valid rules.
			Match m = Regex.Match(ssn, ssnRegex);
			int counter = 0;
			// If first ssn isn't valid loop until you have a valid one.
			while (!m.Success && counter < 20)
			{
				ssn = GenerateRandomNumberDigits(9); // new ssn
				m = Regex.Match(ssn, ssnRegex);
				counter++;
			}
			return ssn;
		}

		public static String GetRandomStringFromArray(String[] array)
		{
			int rnd = new Random().Next(array.Length);
			return array[rnd];
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
		 */
		public static String GenerateRandomNumber(int min, int max)
		{
			Random rand = new Random(Environment.TickCount);
			int randomNum = rand.Next(max - min + 1) + min;

			return randomNum.ToString("D2");
		}

		/**
		 * Returns a pseudo-random number as many digits long as you want.
		 *
		 * @param length Length (Number of Digits) of random number generated.
		 * @return String random number x digits long.
		 */
		public static String GenerateRandomNumberDigits(int length)
		{
			Random rand = new Random();

			StringBuilder builder = new StringBuilder();
			for (int i = 0; i < length; i++)
			{
				int digit = rand.Next(10);
				builder.Append(digit);
			}
			return builder.ToString();
		}

		/**
		 * Returns a pseudo-random number as many digits long as you want.
		 *
		 * @param minLength Minimum length (Number of Digits) of random number generated.
		 * @param maxLength Maximum length (Number of Digits) of random number generated.
		 * @return String random number x digits long.
		 * @see java.util.Random#nextInt(int)
		 */
		public static String GenerateRandomNumberDigits(int minLength, int maxLength)
		{
			int digit;
			Random rand = new Random();
			int length = rand.Next(maxLength - minLength + 1);
			length += minLength;
			StringBuilder builder = new StringBuilder();
			for (int i = 0; i < length; i++)
			{
				digit = rand.Next(10);
				while (i == 0 && digit == 0)
				{
					digit = rand.Next(10);
				}
				builder.Append(digit);
			}
			return builder.ToString();
		}

		public static String RemoveNewLineFromString(String badString)
		{
			String[] split = badString.Replace("\n", " ").Split(' ');
			String returnString = "";
			foreach (String word in split)
			{
				if (!String.IsNullOrEmpty(word))
				{
					returnString = returnString + word.Trim() + " ";
				}
			}
			return returnString.Trim();
		}

		public static bool ContainsNoCase(String stringToSearch, String stringToFind)
		{
			return stringToSearch.ToLower().Contains(stringToFind.ToLower());
		}

		public static List<String> LastFirstMiddleInitialNameParser(String name)
		{
			Console.WriteLine("The name to Parse is " + name);
			List<String> returnNameList = new List<String>();
			String[] nameSplit = SplitStringByString(name, ", ");
			String[] firstNameMI = nameSplit[1].Split(' ');
			returnNameList.Add(firstNameMI[0]);
			if (firstNameMI.Length > 1)
			{
				returnNameList.Add(firstNameMI[1]);
			}
			returnNameList.Add(nameSplit[0]);
			return returnNameList;
		}

		public static String CapitalizeName(String name)
		{
			String nameToLower = name.ToLower();
			String firstChar = name.Substring(0, 1);
			firstChar.ToUpper();
			String nameToReturn = firstChar + nameToLower.Substring(1);
			return nameToReturn;
		}


		public static String CapitalizeAllWords(String fullString)
		{
			String toReturn = "";
			String[] stringSplit = fullString.Split(' ');
			foreach (String stringToCapitalize in stringSplit)
			{
				toReturn += " " + CapitalizeName(stringToCapitalize);
			}

			return toReturn.Trim();
		}
	}
}
