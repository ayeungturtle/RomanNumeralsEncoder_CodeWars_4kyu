using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RomanConvert
{
    public static string Solution(int n)
    {
        RomanConverter converter = new RomanConverter();
        string finalResult = converter.Convert(n);
        return finalResult;
    }
}

public class Denomination
{
    public int value;
    public string name;
}

public class RomanConverter
{
    private List<Denomination> denominations;

    public RomanConverter()
    {
        denominations = new List<Denomination>();
        FillDenominations();
    }

    public RomanConverter(List<Denomination> denominations)
    {
        this.denominations = denominations;
    }

    private void FillDenominations()
    {
        AddDenomination(1000, "M");
        AddDenomination(900, "CM");
        AddDenomination(500, "D");
        AddDenomination(100, "C");
        AddDenomination(90, "XC");
        AddDenomination(50, "L");
        AddDenomination(40, "XL");
        AddDenomination(10, "X");
        AddDenomination(9, "IX");
        AddDenomination(5, "V");
        AddDenomination(4, "IV");
        AddDenomination(1, "I");
    }

    private void AddDenomination(int value, string name)
    {
        Denomination tempDenomination = new Denomination();
        tempDenomination.value = value;
        tempDenomination.name = name;
        denominations.Add(tempDenomination);
    }

    public string Convert(int number)
    {
        string result = "";
        foreach (Denomination denomination in denominations)
        {
            while (number >= denomination.value)
            {
                number -= denomination.value;
                result += denomination.name;
            }
        }
        return result;
    }
}