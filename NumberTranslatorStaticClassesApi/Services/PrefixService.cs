using System;
using System.Collections.Generic;
using NumberTranslatorStaticClassesApi.Enums;

namespace NumberTranslatorStaticClassesApi.Services
{
    public static class PrefixService
    {
        public static string GetPrefix(Func<int, string> numberPrefixRepo, Func<int, string> translateUniqueNumbers, int number)
        {
            var startNumber = number < 20
                ? DigitService.GetDigit(DigitPlacesEnum.Ones, number)
                : DigitService.GetDigit(DigitPlacesEnum.Tens, number);

            if (startNumber == 4 && number > 14)
                return numberPrefixRepo(startNumber);

            var prefixNumbers = new List<int> { 2, 3, 5, 8 };
            if (prefixNumbers.Contains(startNumber))
                return numberPrefixRepo(startNumber);

            var validNumbers = new List<int> { 4, 6, 7, 9 };
            if (validNumbers.Contains(startNumber))
                return translateUniqueNumbers(startNumber);


            return $"(GetPrefixes) Can't find prefix for the number: {number}";
        }
    }
}