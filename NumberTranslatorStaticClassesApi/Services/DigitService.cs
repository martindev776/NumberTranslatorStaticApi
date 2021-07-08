using System;
using System.Collections.Generic;
using System.Linq;
using NumberTranslatorStaticClassesApi.Enums;

namespace NumberTranslatorStaticClassesApi.Services
{
    public static class DigitService
    {
        public static int GetDigit(DigitPlacesEnum digitPlace, int number)
        {
            static DigitPlacesEnum MapDigitPlaces(int digit)
            {
                switch (digit)
                {
                    case 0:
                        return DigitPlacesEnum.Ones;
                    case 1:
                        return DigitPlacesEnum.Tens;
                    default:
                        return DigitPlacesEnum.None;
                }
            }

            static IDictionary<DigitPlacesEnum, int> IntToDictionary(int number)
            {
                var numberAsCharArray = number.ToString().ToCharArray();

                var count = 0;
                var dictionary = new Dictionary<DigitPlacesEnum, int>();
                foreach (var c in numberAsCharArray.Reverse())
                {
                    var digit = Convert.ToInt32(c.ToString());
                    var digitPlace = MapDigitPlaces(count);
                    count++;
                    dictionary.Add(digitPlace, digit);
                }

                return dictionary;
            }

            var digitDictionary = IntToDictionary(number);
            return digitDictionary[digitPlace];
        }
    }
}