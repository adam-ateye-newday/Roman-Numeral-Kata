using System.Linq;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(51,"LI")]
        [InlineData(54,"LIV")]
        [InlineData(20, "XX")]
        [InlineData(30, "XXX")]
        [InlineData(40, "XL")]
        [InlineData(90, "XC")]
        [InlineData(400, "CD")]
        [InlineData(900, "CM")]
        [InlineData(1893, "MDCCCXCIII")]
        [InlineData(2022, "MMXXII")]
        [InlineData(3999, "MMMCMXCIX")]
        [InlineData(190, "CXC")]
        public void Test2(int input, string expectedOutput)
        {
            //arrange
            var converter = new RomanNumeral();

            //act
            var actualOutput = converter.Convert(input);

            //assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void FindsTheBiggestSpecialThatsLessThanTheInput()
        {
            //arrange 
            var specialMap = new SpecialMap();

            //act
            var actual = specialMap.BiggestSpecialKeyLessThanTheInput(6);

            //assert
            Assert.Equal(5, actual);
        }
    }


    public class RomanNumeral
    {
        public string Convert(int input)
        {
            var specialMapObject = new SpecialMap();

            string result = "";
            while (input > 0)
            {
                var special = specialMapObject.BiggestSpecialKeyLessThanTheInput(input);

                input -= special;
                result += specialMapObject.getSpecial(special);
            }

            return result;
        }
    }
}