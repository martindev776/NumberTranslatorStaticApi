using System;
using NumberTranslatorStaticClassesApi.Enums;

namespace NumberTranslatorStaticClassesApi.Services
{
    public static class TensTranslatorService
    {
        public static string TranslateTens(Func<int, string> getPrefix, Func<int, string> translateUniqueNumbers, int number)
        {
            var prefix = getPrefix(number);
            var onesDigit = DigitService.GetDigit(DigitPlacesEnum.Ones, number);

            var onesNumber = onesDigit == 0
                ? ""
                : "-" + translateUniqueNumbers(onesDigit);

            return prefix + "ty" + onesNumber;
        }
    }
}