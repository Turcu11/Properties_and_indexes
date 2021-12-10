using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_and_indexes
{
    class Adress
    {
        public string City { get; set; }

        public string StreetName { get; set; }

        public string StreetNumber { get; set; }

        public string PoastalCode { get; set; }

        public string this [string part]
        {
            get
            {
                if(string.Equals(part, nameof(City), StringComparison.OrdinalIgnoreCase))
                {
                    return City;
                }

                if (string.Equals(part, nameof(StreetName), StringComparison.OrdinalIgnoreCase))
                {
                    return StreetName;
                }

                if (string.Equals(part, nameof(StreetNumber), StringComparison.OrdinalIgnoreCase))
                {
                    return StreetNumber;
                }

                if (string.Equals(part, nameof(PoastalCode), StringComparison.OrdinalIgnoreCase))
                {
                    return PoastalCode;
                }

                return string.Empty;
            }
        }
    }
}
