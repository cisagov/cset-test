using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.Helpers;

namespace CSET_Selenium.Enums
{
    public enum States
    {
        [StatesAttr("Alabama", "AL", true)] Alabama,
        [StatesAttr("Alaska", "AK", true)] Alaska,
        [StatesAttr("Arizona", "AZ", true)] Arizona,
        [StatesAttr("Arkansas", "AR", true)] Arkansas,
        [StatesAttr("California", "CA", true)] California,
        [StatesAttr("Colorado", "CO", true)] Colorado,
        [StatesAttr("Connecticut", "CT", true)] Connecticut,
        [StatesAttr("Delaware", "DE", true)] Delaware,
        [StatesAttr("Florida", "FL", true)] Florida,
        [StatesAttr("Georgia", "GA", true)] Georgia,
        [StatesAttr("Hawaii", "HI", true)] Hawaii,
        [StatesAttr("Idaho", "ID", true)] Idaho,
        [StatesAttr("Illinois", "IL", true)] Illinois,
        [StatesAttr("Indiana", "IN", true)] Indiana,
        [StatesAttr("Iowa", "IA", true)] Iowa,
        [StatesAttr("Kansas", "KS", true)] Kansas,
        [StatesAttr("Kentucky", "KY", true)] Kentucky,
        [StatesAttr("Louisiana", "LA", true)] Louisiana,
        [StatesAttr("Maine", "ME", true)] Maine,
        [StatesAttr("Maryland", "MD", true)] Maryland,
        [StatesAttr("Massachusetts", "MA", true)] Massachusetts,
        [StatesAttr("Michigan", "MI", true)] Michigan,
        [StatesAttr("Minnesota", "MN", true)] Minnesota,
        [StatesAttr("Mississippi", "MS", true)] Mississippi,
        [StatesAttr("Missouri", "MO", true)] Missouri,
        [StatesAttr("Montana", "MT", true)] Montana,
        [StatesAttr("Nebraska", "NE", true)] Nebraska,
        [StatesAttr("Nevada", "NV", true)] Nevada,
        [StatesAttr("New Hampshire", "NH", true)] NewHampshire,
        [StatesAttr("New Jersey", "NJ", true)] NewJersey,
        [StatesAttr("New Mexico", "NM", true)] NewMexico,
        [StatesAttr("New York", "NY", true)] NewYork,
        [StatesAttr("North Carolina", "NC", true)] NorthCarolina,
        [StatesAttr("North Dakota", "ND", true)] NorthDakota,
        [StatesAttr("Ohio", "OH", true)] Ohio,
        [StatesAttr("Oklahoma", "OK", true)] Oklahoma,
        [StatesAttr("Oregon", "OR", true)] Oregon,
        [StatesAttr("Pennsylvania", "PA", true)] Pennsylvania,
        [StatesAttr("Rhode Island", "RI", true)] RhodeIsland,
        [StatesAttr("South Carolina", "SC", true)] SouthCarolina,
        [StatesAttr("South Dakota", "SD", true)] SouthDakota,
        [StatesAttr("Tennessee", "TN", true)] Tennessee,
        [StatesAttr("Texas", "TX", true)] Texas,
        [StatesAttr("Utah", "UT", true)] Utah,
        [StatesAttr("Vermont", "VT", true)] Vermont,
        [StatesAttr("Virginia", "VA", true)] Virginia,
        [StatesAttr("Washington", "WA", true)] Washington,
        [StatesAttr("West Virginia", "WV", true)] WestVirginia,
        [StatesAttr("Wisconsin", "WI", true)] Wisconsin,
        [StatesAttr("Wyoming", "WY", true)] Wyoming,

        [StatesAttr("American Samoa", "AS", false)] AmericanSamoa,
        [StatesAttr("District of Columbia", "DC", false)] DistrictOfColumbia,
        [StatesAttr("Federated States of Micronesia", "FM", false)] FederatedStatesOfMicronesia,
        [StatesAttr("Guam", "GU", false)] Guam,
        [StatesAttr("Marshall Islands", "MH", false)] MarshallIslands,
        [StatesAttr("Northern Mariana Islands", "MP", false)] NorthernMarianaIslands,
        [StatesAttr("Palau", "PW", false)] Palau,
        [StatesAttr("Puerto Rico", "PR", false)] PuertoRico,
        [StatesAttr("Virgin Islands", "VI", false)] VirginIslands
    }

    class StatesAttr : Attribute
    {
        internal StatesAttr(String name, String abbreviation, bool original50)
        {
            this.Name = name;
            this.Abbreviation = abbreviation;
            this.Original50 = original50;
        }
        public String Name { get; private set; }
        public String Abbreviation { get; private set; }
        public bool Original50 { get; private set; }
    }

    public static class StatesExtensions
    {
        public static String GetStateName(this States enumChoice)
        {
            var attr = enumChoice.GetAttribute<StatesAttr>();
            return attr.Name;
        }

        public static String GetAbbreviation(this States enumChoice)
        {
            var attr = enumChoice.GetAttribute<StatesAttr>();
            return attr.Abbreviation;
        }

        public static bool IsOriginal50(this States enumChoice)
        {
            var attr = enumChoice.GetAttribute<StatesAttr>();
            return attr.Original50;
        }

        public static States ValueOfAbbreviation(String abreviation)
        {
            States stateToReturn = new States();
            foreach (States state in Enum.GetValues(typeof(States)))
            {
                if (StringsUtils.EqualsIgnoreCase(state.GetAbbreviation(), abreviation))
                {
                    stateToReturn = state;
                    break;
                }
            }
            return stateToReturn;
        }
    }
}