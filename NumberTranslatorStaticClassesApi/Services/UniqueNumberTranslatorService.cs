using System;
using NumberTranslatorStaticClassesApi.ExtensionMethods;

namespace NumberTranslatorStaticClassesApi.Services
{
    public static class UniqueNumberTranslatorService
    {
        public static string TranslateUniqueNumbers(Func<int, string> uniqueNumberRepository, int number)
        {
            return number.Between(0, 12)
                ? uniqueNumberRepository(number)
                : $"(TranslateOnes) Can't translate the number: {number}";
        }
    }
}