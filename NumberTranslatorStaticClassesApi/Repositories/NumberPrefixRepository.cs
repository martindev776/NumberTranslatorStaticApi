using NumberTranslatorStaticClassesApi.DbTables;

namespace NumberTranslatorStaticClassesApi.Repositories
{
    public static class NumberPrefixRepository
    {
        public static string Get(int number)
        {
            return NumberPrefixTable.Table
                .Find(x => x.Number == number)
                ?.Text;
        }
    }
}