using System;
using System.Text.RegularExpressions;

namespace topic2
{
    public class RegexTest
    {
        //验证订单号为“年月日+三位流水号”
        public static bool OrderNumTest(string ordernum)
        {
            String partten = @"[0-9]{8}/+[0-9]{3}$";
            Regex regex = new Regex(partten);
            return regex.IsMatch(ordernum);
        }

        //验证手机号是否为正确形式
        public static bool PhoneTest(string phone)
        {
            String pattern = @"^(13[0-9]|14[5|7]|15[0|1|2|3|5|6|7|8|9]|18[0|1|2|3|5|6|7|8|9])\d{8}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(phone);
        }
    }
}
