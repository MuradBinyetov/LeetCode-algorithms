using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class CesarHasher
    {
        static string Cesar(string orgStr, int key)
        {
            var hashStr = string.Empty;
            if (key > 26)
            {
                key = key % 26;
            }
            for (var i = 0; i < orgStr.Length; i++)
            {
                int orgIndex = (char)orgStr[i];
                var hashLetterIndex = orgIndex + key;
                if (orgIndex >= 65 && orgIndex <= 90)
                {
                    if (hashLetterIndex > 90)
                    {
                        hashLetterIndex = hashLetterIndex - 26;
                    }
                }
                else
                {
                    hashLetterIndex = orgIndex;
                }
                var hashLetter = Convert.ToChar(hashLetterIndex);

                hashStr += hashLetter;

            }
            return hashStr;
        }
 
    }
}
