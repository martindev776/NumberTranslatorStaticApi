using NumberTranslatorStaticClassesApi.DbTables;

namespace NumberTranslatorStaticClassesApi.Repositories
{
    public static class UniqueNumberRepository
    {
        public static string Get(int number)
        {
            return UniqueNumbersTable.Table
                .Find(x => x.Number == number)
                ?.Text;
        }
    }
}