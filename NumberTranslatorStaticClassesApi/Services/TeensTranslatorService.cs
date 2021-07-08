using System;
using NumberTranslatorStaticClassesApi.ExtensionMethods;

namespace NumberTranslatorStaticClassesApi.Services
{
    public static class TeensTranslatorService
    {
        public static string TranslateTeens(Func<int, string> getPrefix, int number)
        {
            if (number.Between(13, 19))
                return getPrefix(number) + "teen";

            throw new Exception($"(TranslateTeens) Can't translate the number: {number}");
        }
    }
}