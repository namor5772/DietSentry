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
        /// based on the food description string parameter sDesc, either grams (g) or millilitres (mL)
        /// </summary>
        /// <param name="sDesc"></param>
        /// <returns></returns>
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


        public record struct rDesc
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
        /// <returns></returns>
        public static rDesc TruncFoodDesc(string sDesc)
        {
            int ln = sDesc.Length;
            string sL1 = sDesc.Substring(ln - 1); // get last character of sDesc
            string sL2 = sDesc.Substring(ln - 2); // get last 2 characters of SDesc
            string sL3 = sDesc.Substring(ln - 3); // get last 3 characters of SDesc
            string sT1 = sDesc.Substring(sDesc.Length - 3, 2);
            string sT2 = sDesc.Substring(sDesc.Length - 2, 2);
            rDesc rD;

            if (sL1 == "*")
            {
                // recipe
                rD.foodType = 2;
                rD.truncDesc = sDesc.Substring(0, ln - 2);
            }
            else if (sL2 == "mL")
            {
                // liquid - public
                rD.foodType = 1;
                rD.truncDesc = sDesc.Substring(0, ln - 3);
            }
            else if (sL3 == "mL#")
            {
                // liquid - private
                rD.foodType = 4;
                rD.truncDesc = sDesc.Substring(0, ln - 4);
            }
            else if (sL1 == "#")
            {
                // solid - private
                rD.foodType = 3;
                rD.truncDesc = sDesc.Substring(0, ln - 2);
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
        /// function that returns true if the food item with the description sDesc is a recipe, false otherwise
        /// </summary>
        /// <param name="sDesc"></param>
        /// <returns></returns>
        public static bool isRecipe(string sDesc)
        {
            //string sT = sDesc.Substring(sDesc.Length - 1, 1);
            return (sDesc.Substring(sDesc.Length - 1, 1)).Equals("*");
        }

    }

}
