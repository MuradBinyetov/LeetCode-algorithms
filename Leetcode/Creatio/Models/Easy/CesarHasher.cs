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
            string respStr = string.Empty;
            foreach (var item in orgStr)
            {
                int orgIndex = (char)item;
                char hashLetter = ' ';
                if((orgIndex>=65 && orgIndex<=90) || (orgIndex>=97 && orgIndex<=122))
                {
                    int hashIndex = orgIndex + key;
                    if(orgIndex>=65 && orgIndex<=90)
                        {
                            if(hashIndex > 90){
                                hashIndex = 65 + (hashIndex-90);
                            }
                        }
                    else if(orgIndex>=97 && orgIndex<=122)
                    {
                        if(hashIndex > 122)
                        {
                            hashIndex = 97 + (hashIndex-122);
                        }
                    } 
                    hashLetter = Convert.ToChar(hashIndex);
                }
                else
                {
                     hashLetter= Convert.ToChar(orgIndex);
                } 
                
                respStr += hashLetter;
            }

            Console.WriteLine(respStr);
            return respStr;
        }
 
    }
}
