using DocumentFormat.OpenXml.ExtendedProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MAUIUI.Helpers
{
    public class InputValidator
    {
        public static bool EmailValidating(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.([a-zA-Z]{2,}|[^\x00-\x7F]{1,})$";

            if (!Regex.IsMatch(email, emailPattern))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        //Telefon numarası şart ise nullable'a false değeri veriniz, şart değil ise true değeri veriniz.
        //Hiç değer vermezseniz nullable varsayılan olarak true değeri alır.
        public static bool PhoneValidating(string phone, bool isNullable = true)
        {
            int numCount = 0;
            for(int i=0; i<phone.Length; i++)
            {
                if (char.IsDigit(phone[i]))
                {
                    numCount++;
                }
            }
            if(numCount != 10 && !(isNullable && numCount == 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        //Sadece ilk kelimesinin ilk harfi büyük, geri kalan tüm kelimelerin tüm harfleri küçük yapılacaksa allWords'e FALSE değeri veriniz.
        //Tüm kelimelerin ilk harfi büyük, diğer harfler küçük yapılacaksa allWords'e TRUE değeri veriniz.
        //Hiç değer vermezseniz allWords varsayılan olarak FALSE değeri alır.
        public static string CaseFormatter(string text, bool allWords = false)
        {
            if(text.Length > 1)
            {
                if (allWords)
                {
                    string[] wordsArray = text.Split(' ');
                    for(int i=0; i<wordsArray.Length; i++)
                    {
                        wordsArray[i] = char.ToUpper(wordsArray[i][0]) + wordsArray[i].Substring(1).ToLower();
                    }
                    text = string.Join(" ", wordsArray);
                }
                else
                {
                    text = char.ToUpper(text[0]) + text.Substring(1).ToLower();
                }
                
            }
            else if(text.Length == 1)
            {
                text = char.ToUpper(text[0]).ToString();
            }
            return text;
        }


        //Boşluk kullanılabilecekse isSpaceAllowed TRUE, kullanılamayacaksa FALSE değeri veriniz.
        //Ondalıklı sayılar için ayırıcı (örn. virgül, nokta vs.) kullanılacaksa decimalSeperator parametresine ayırıcı için değer veriniz.
        //Ondalıklı olmayan sayılar için decimalSeperator parametresi default olarak null değeri alır.
        //Değer verilmezse isSpaceAllowed default olarak FALSE değeri alır.
        //Örnek kullanım: 3,14 --> onlyNumeric(e, false, ',')
        //public static void OnlyNumeric(KeyPressEventArgs e,bool isSpaceAllowed = false, char? decimalSeperator = null)
        //{
        //    int seperator = 0;
        //    if(decimalSeperator.HasValue)
        //    {
        //        seperator = Convert.ToInt32(decimalSeperator);
        //    }
        //    if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || (e.KeyChar == 32 && isSpaceAllowed) || (decimalSeperator.HasValue && e.KeyChar == seperator))
        //    {
        //        e.Handled = false;
        //    }
        //    else
        //    {
        //        e.Handled = true;
        //    }
        //}
        


        //Boşluk kullanılabilecekse isSpaceAllowed TRUE değeri veriniz.
        //Boşluk kullanılamayacaksa isSpaceAllowed FALSE değeri veriniz.
        //Değer verilmezse isSpaceAllowed default olarak FALSE değeri alır.
        //public static void OnlyLetter(KeyPressEventArgs e, bool isSpaceAllowed = false)
        //{
        //    if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || (e.KeyChar == 32 && isSpaceAllowed))
        //    {
        //        e.Handled = false;
        //    }
        //    else
        //    {
        //        e.Handled = true;
        //    }
        //}


        //Harf girilebilecekse isLetterAllowed'e TRUE, girilemeycekse FALSE veriniz.
        //Sayı girilebilecekse isNumberAllowed'e TRUE, girilemeycekse FALSE veriniz.
        //Boşluk girilebilecekse isSpaceAllowed'e TRUE, girilemeycekse FALSE veriniz.
        //Değer verilmezse hepsi default olarak TRUE değeri alır.
        //public static void LetterNumericSpace(KeyPressEventArgs e,
        //    bool isLetterAllowed = true,
        //    bool isNumberAllowed = true,
        //    bool isSpaceAllowed = true)
        //{
        //    if ((char.IsLetter(e.KeyChar) && isLetterAllowed) || (char.IsNumber(e.KeyChar) && isNumberAllowed) || (e.KeyChar == 32 && isSpaceAllowed) || e.KeyChar == 8)
        //    {
        //        e.Handled = false;
        //    }
        //    else
        //    {
        //        e.Handled = true;
        //    }
        //}
        //HARF ve BOŞLUK: InputValidator.LetterNumberSpace(e, true, false, true);
        //Sadece SAYI: InputValidator.LetterNumberSpace(e, false, true, false);
        //HARF, SAYI, BOŞLUK: InputValidator.LetterNumberSpace(e);


    }
}
