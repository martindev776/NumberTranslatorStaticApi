using System;
using NumberTranslatorStaticClassesApi.Enums;
using NUnit.Framework;

using NumberTranslatorStaticClassesApi.Services;

namespace NumberTranslatorStaticClassesApiTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGetDigit()
        {
            var expected = new[]{ 3, 1 };
            var actual = new[]{ DigitService.GetDigit(DigitPlacesEnum.Tens, 31),
                                     DigitService.GetDigit(DigitPlacesEnum.Ones, 31)};

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestUniqueNumbers()
        {
            static Func<int, string> TranslateUniqueNumbersWithRepoMock()
            {
                return x => UniqueNumberTranslatorService.TranslateUniqueNumbers(_ => "zero", x);
            }

            var expected = "zero";
            var actual = TranslateUniqueNumbersWithRepoMock()(0);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestTeens()
        {
            var expected = "thirteen";
            string GetPrefixMock(int _) => "thir";
            var actual = TeensTranslatorService.TranslateTeens(GetPrefixMock, 13);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestTranslateTensWithZeroAtEnd()
        {
            var expected = "twenty";

            static Func<int, string> TranslateUniqueNumbers()
            {
                return x => "";
            }

            static Func<int, string> GetPrefixService()
            {
                return x => "twen";
            }

            var actual = TensTranslatorService.TranslateTens(GetPrefixService(), TranslateUniqueNumbers(), 20);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestTranslateTensWithNonZeroAtEnd()
        {
            var expected = "twenty-two";

            static Func<int, string> TranslateUniqueNumbers()
            {
                return x => "two";
            }

            static Func<int, string> GetPrefixService()
            {
                return x => "twen";
            }

            var actual = TensTranslatorService.TranslateTens(GetPrefixService(), TranslateUniqueNumbers(), 22);

            Assert.AreEqual(expected, actual);
        }
    }
}