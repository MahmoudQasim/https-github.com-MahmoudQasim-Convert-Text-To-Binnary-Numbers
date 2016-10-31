using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_text_to_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Convert Text To Binnary Numbers
             * mahmmoud Qasim Development
             * 2016-2017
             * fb.com/mah.070
             * mah_devpro@hotmail.com
             * 10110111000011000101110110111011011111101110101110010011000011110100110011011111101100001111011011101001101110110010111   
             */
            Console.WriteLine("Enter the text for convert to binary.");
            List<string> binarys = new List<string>();
            string t = Console.ReadLine().ToString();
            byte[] ENC = Encoding.ASCII.GetBytes(t);
            int x = 0, c = 0;
            string bin = "";
            while(x < t.Length)
            {
                c = ENC[x];
                while (c != 0)
                {
                    if(c %2 == 0)
                    {
                        bin += "0";
                    }
                    else
                    {
                        bin += "1";
                    }
                    c = c / 2;
                    if(c == 0)
                    {
                        binarys.Add(bin);
                        bin = "";
                    }
                }
                x += 1;
            }

            Console.WriteLine("This is Result : ");
            foreach(string binary_byte in binarys)
            {
                Console.Write(binary_byte);
            }
            Console.WriteLine();
        }
    }
}