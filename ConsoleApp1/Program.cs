using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static string timeConversion(string s)
        {
            List<string> parcala = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                parcala.Add(s[i].ToString());
            }
            string deger = "", returnSaat = "", saat = ""; string _deger = "";
            for (int i = 0; i < parcala.Count; i++)
            {
                if (parcala[i] == "P" || parcala[i] == "M" || parcala[i] == "A")
                {
                    deger += parcala[i];
                    if (deger == "PM")
                    {
                        if (parcala[0] == "1" && parcala[1] == "2")
                        {
                            for (int a = 0; a < parcala.Count - 2; a++)
                                returnSaat += parcala[a];
                        }
                        else
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                saat += parcala[j];
                                if (j == 1)
                                {
                                    int _saat24 = 12 + Convert.ToInt16(saat);
                                    for (int k = 2; k < parcala.Count - 2; k++)
                                    {
                                        _deger += parcala[k].ToString();
                                        if (k + 1 == parcala.Count - 2)
                                        {
                                            returnSaat = _saat24.ToString() + _deger;
                                        }
                                    }
                                    break;
                                }
                            }
                        }
                        break;
                    }
                    if (deger == "AM")
                    {
                        if (parcala[0] == "1" && parcala[1] == "2")
                        {
                            int fark = 12 - 12;
                            for (int k = 2; k < parcala.Count - 2; k++)
                            {
                                _deger += parcala[k].ToString();
                                if (k + 1 == parcala.Count - 2)
                                {
                                    returnSaat = fark.ToString() + fark.ToString() + _deger;
                                }
                            }
                        }
                        else
                        {
                            for (int a = 0; a < s.Length - 2; a++)
                                returnSaat += s[a].ToString();
                        }
                        break;
                    }
                }
            }
            return returnSaat;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine().Trim();

            string result = timeConversion(s);
            Console.WriteLine(" "+result);
            Console.ReadLine();
        }
    }
}
