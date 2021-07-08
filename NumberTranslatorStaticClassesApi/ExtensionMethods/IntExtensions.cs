namespace NumberTranslatorStaticClassesApi.ExtensionMethods
{
    public static class IntExtensions
    {
        public static bool Between(this int number, int min, int max)
        {
            return min <= number && number <= max;
        }
    }
}