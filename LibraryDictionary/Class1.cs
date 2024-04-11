using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDictionary
{
    public class Morse
    {
        Dictionary<char, string> morseCodeDictionary = new Dictionary<char, string>()
        {
            {'A', ".-"},
            {'B', "-..."},
            {'C', "-.-."},
            {'D', "-.."},
            {'E', "."},
            {'F', "..-."},
            {'G', "--."},
            {'H', "...."},
            {'I', ".."},
            {'J', ".---"},
            {'K', "-.-"},
            {'L', ".-.."},
            {'M', "--"},
            {'N', "-."},
            {'O', "---"},
            {'P', ".--."},
            {'Q', "--.-"},
            {'R', ".-."},
            {'S', "..."},
            {'T', "-"},
            {'U', "..-"},
            {'V', "...-"},
            {'W', ".--"},
            {'X', "-..-"},
            {'Y', "-.--"},
            {'Z', "--.."},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},
            {'0', "-----"},
            {' ', "_"}
        };

        public string ToMorse(string text)
        {
            text = text.ToUpper();
            char[] arr = text.ToArray();
            string[] strArr = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                strArr[i] = morseCodeDictionary[arr[i]];
            }
            string res = string.Join("_", strArr);
            return res;
        }

        public void Print(string arr)
        {
            Console.WriteLine(arr);
        }

        public string ToString(string str)
        {
            string[] arrMorse = str.Split('_');
            char[] arrDefault = new char[arrMorse.Length];
            int index = 0;

            foreach (string morse in arrMorse)
            {
                bool found = false;
                foreach (var pair in morseCodeDictionary)
                {
                    if (pair.Value == morse)
                    {
                        arrDefault[index++] = pair.Key;
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    arrDefault[index++] = ' ';
                }
            }

            string res = new string(arrDefault).Trim();
            res = res.ToLower();

            return res;
        }
    }
    }
