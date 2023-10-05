using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietSentry
{
    internal class UtilitiesRMG
    {
        /// <summary>
        /// function that specifies the units used for an existing food item
        /// based on the food description string parameter sDesc,
        /// either grams (g) or millilitres (mL)
        /// </summary>
        /// <param name="sDesc"></param>
        /// <returns>a string</returns>
        public static string UnitsString(string sDesc)
        {
            string sT1 = sDesc.Substring(sDesc.Length - 3, 2);
            string sT2 = sDesc.Substring(sDesc.Length - 2, 2);
            if ((sT1.Equals("mL")) | (sT2.Equals("mL")))
            {
                return "mL";
            }
            else
            {
                return "g";
            }
        }


        /// <summary>
        /// A record structure to a food item,
        /// containing its type and the truncated description
        /// </summary>
        public record struct RDesc
        {
            public int foodType;
            public string truncDesc;
        }


        /// <summary>
        /// function that takes a FoodDescription string sDesc as argument and returns a rDesc record structure
        /// rDesc.truncDesc omits the food type information at the end. This is used as the Food Description
        /// when editing or adding a food to the database, the extra information is later added when
        /// editing of adding is completed. rDesc.foodType returns the food type (integer). 
        /// </summary>
        /// <param name="sDesc"></param>
        /// <returns>the rDesc record structure</returns>
        public static RDesc TruncFoodDesc(string sDesc)
        {
            int ln = sDesc.Length;
            string sL1 = sDesc[(ln - 1)..]; // get last character of sDesc
            string sL2 = sDesc[(ln - 2)..]; // get last 2 characters of SDesc
            string sL3 = sDesc[(ln - 3)..]; // get last 3 characters of SDesc
            RDesc rD;

            if (sL1 == "*")
            {
                // recipe
                rD.foodType = 2;

                // the removed string is of the form " {recipe=<grams>g}*", identified by "{"
                sDesc.LastIndexOf('{');
                rD.truncDesc = sDesc[..(sDesc.LastIndexOf('{') - 1)];
            }
            else if (sL2 == "mL")
            {
                // liquid - public
                rD.foodType = 1;
                rD.truncDesc = sDesc[..(ln - 3)];
            }
            else if (sL3 == "mL#")
            {
                // liquid - private
                rD.foodType = 4;
                rD.truncDesc = sDesc[..(ln - 4)];
            }
            else if (sL1 == "#")
            {
                // solid - private
                rD.foodType = 3;
                rD.truncDesc = sDesc[..(ln - 2)];
            }
            else
            {
                // solid - public
                rD.foodType = 0;
                rD.truncDesc = sDesc;
            }

            return rD;
        }


        /// <summary>
        /// function that returns true if the food item with the description sDesc is a recipe,
        /// false otherwise
        /// </summary>
        /// <param name="sDesc"></param>
        /// <returns>a boolean</returns>
        public static bool IsRecipe(string sDesc)
        {
            //string sT = sDesc.Substring(sDesc.Length - 1, 1);
            return (sDesc.Substring(sDesc.Length - 1, 1)).Equals("*");
        }


        /// <summary>
        /// function that returns the number of whole minutes elapsed from start of 1-Jan-2023
        /// (ie. midnight on 31-Dec-2022) to toDateTime
        /// </summary>
        /// <param name="toDateTime"></param>
        /// <returns></returns>
        public static int MTimeSpan(DateTime toDateTime)
        {
            DateTime drf = new(2023, 1, 1); // reference starting DateTime
            TimeSpan vTs = toDateTime-drf;
            string sTs1 = vTs.ToString("%d"); // whole days from drf to dtn 
            string sTs2 = vTs.ToString("%h"); // part of day in hours
            string sTs3 = vTs.ToString("%m"); // part of day in minutes
            int iTs1 = Int32.Parse(sTs1); // days
            int iTs2 = Int32.Parse(sTs2); // hours
            int iTs3 = Int32.Parse(sTs3); // minutes
            int Ts = (24 * 60) * iTs1 + 60 * iTs2 + iTs3; // number of minutes from drf till dtn.

            return Ts;
        }
    }

}
