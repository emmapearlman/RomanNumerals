using FluentAssertions;
using RomanNumerals.Converter;


namespace RomanNumeralTests
{
    public class Tests
    {
        private readonly ConvertToRoman ctr = new ConvertToRoman();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConvertToRomanTest_1_Equals_I()
        {
            var expected = "I";
            var actual = ctr.ConvertRoman(1);
            actual.Equals(expected);
        }

        [Test]
        public void ConvertToRomanTest_4_Equals_IV()
        {
            var expected = "V";
            var actual = ctr.ConvertRoman(1);
            actual.Equals(expected);
        }

        [Test]
        public void ConvertToRomanTest_5_Equals_V()
        {
            var expected = "V";
            var actual = ctr.ConvertRoman(1);
            actual.Equals(expected);
        }
    }
}