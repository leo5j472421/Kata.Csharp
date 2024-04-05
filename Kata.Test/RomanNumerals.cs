namespace Kata.Test {
    // TODO: Replace examples and use TDD by writing your own tests

    [TestFixture]
    public class SolutionTest
    {
        [TestCase(1,"I")]
        [TestCase(2,"II")]
        [TestCase(3,"III")]
        [TestCase(4,"IV")]
        [TestCase(5,"V")]
        [TestCase(9,"IX")]
        [TestCase(10,"X")]
        [TestCase(40,"XL")]
        [TestCase(50,"L")]
        [TestCase(90,"XC")]
        [TestCase(100,"C")]
        [TestCase(400,"CD")]
        [TestCase(500,"D")]
        [TestCase(900,"CM")]
        [TestCase(1000,"M")]
        [TestCase(1954,"MCMLIV")]
        [TestCase(1990,"MCMXC")]
        [TestCase(2008,"MMVIII")]
        [TestCase(2014,"MMXIV")]
        [TestCase(3999,"MMMCMXCIX")]
        public void TestToRoman(int input , string expected)
        {
            string actual = RomanNumerals.ToRoman(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("I",1)]
        [TestCase("II",2)]
        [TestCase("III",3)]
        [TestCase("IV",4)]
        [TestCase("V",5)]
        [TestCase("IX",9)]
        [TestCase("X",10)]
        [TestCase("XL",40)]
        [TestCase("L",50)]
        [TestCase("XC",90)]
        [TestCase("C",100)]
        [TestCase("CD",400)]
        [TestCase("D",500)]
        [TestCase("CM",900)]
        [TestCase("M",1000)]
        [TestCase("MCMLIV",1954)]
        [TestCase("MCMXC",1990)]
        [TestCase("MMVIII",2008)]
        [TestCase("MMXIV",2014)]
        [TestCase("MMMCMXCIX",3999)]
        public void TestFromRoman_001(string input, int expected)
        {
            int actual = RomanNumerals.FromRoman(input);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}