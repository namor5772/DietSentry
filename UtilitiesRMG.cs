using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietSentry
{
    internal class UtilitiesRMG
    {
        /* function that specifies the units used for an existing food item
         * based on the food description string parameter sDesc.
         * either grams (g) or millilitres (mL) */
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

    }

}
