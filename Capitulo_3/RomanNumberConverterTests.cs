using NUnit.Framework;

namespace Chapter_3;

[TestFixture]
public class Tests
{
    [Test]
    public void ShouldUnderstandSymbolI()
    {
        int number = RomanNumberConverter.Convert("I");
        Assert.That(number, Is.EqualTo(1));
    }

    [Test]
    public void ShouldUnderstandSymbolV()
    {
        int number = RomanNumberConverter.Convert("V");
        Assert.That(number, Is.EqualTo(5));
    }

    [Test]
    public void ShouldUnderstandTwoSymbolsLikeII()
    {
        int number = RomanNumberConverter.Convert("II");
        Assert.That(number, Is.EqualTo(2));
    }

    [Test]
    public void ShouldUnderstandFourSymbolsPairwiseLikeXXII()
    {
        int number = RomanNumberConverter.Convert("XXII");
        Assert.That(number, Is.EqualTo(22));
    }

    [Test]
    public void ShouldUnderstandNumbersLikeIX()
    {
        int number = RomanNumberConverter.Convert("IX");
        Assert.That(number, Is.EqualTo(9));
    }

    [Test]
    public void ShouldUnderstandComplexNumbersLikeXXIV()
    {
        int number = RomanNumberConverter.Convert("XXIV");
        Assert.That(number, Is.EqualTo(24));
    }
}