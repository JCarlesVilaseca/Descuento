using System;
using System.Collections.Generic;
using System.Web;

public class PriceCalc
{
    public static string PriceShow(decimal price, float discount, decimal threshold)
    {
        if (price > threshold)
            return "<font size=\"-2\"><strike>$" + string.Format("{0:f}",price) + "</strike> <font color=\"red\">("+ discount +"%Off)</font></font> $"+ string.Format("{0:f}",(float)price - (float)price*discount/100);
        else
            return "$"+string.Format("{0:f}",price);
    }

    public static string PriceValue(decimal price, float discount, decimal threshold)
    {
        if (price > threshold)
            return string.Format("{0:f}",(float)price - (float)price*discount/100);
        else
            return string.Format("{0:f}",price);
    }
}
