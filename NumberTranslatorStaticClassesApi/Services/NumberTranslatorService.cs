using System;
using NumberTranslatorStaticClassesApi.ExtensionMethods;
using NumberTranslatorStaticClassesApi.Repositories;

namespace NumberTranslatorStaticClassesApi.Services
{
    public static class NumberTranslatorService
    {
        public static Func<int, string> TranslateUniqueNumbersWithRepo()
        {
            return x => UniqueNumberTranslatorService.TranslateUniqueNumbers(UniqueNumberRepository.Get, x);
        }

        public static Func<int, string> GetPrefixWithRepo()
        {
            return x => PrefixService.GetPrefix(NumberPrefixRepository.Get, TranslateUniqueNumbersWithRepo(), x);
        }

        public static string Translate(int number)
        {

            if (number.Between(0, 12))
                return TranslateUniqueNumbersWithRepo()(number);

            if (number.Between(12, 19))
                return TeensTranslatorService.TranslateTeens(GetPrefixWithRepo(), number);

            if(number.Between(20, 99))
                return TensTranslatorService.TranslateTens(GetPrefixWithRepo(), TranslateUniqueNumbersWithRepo(), number);

            return $"(Translate) Can't translate the number: {number}";
        }
    }
}