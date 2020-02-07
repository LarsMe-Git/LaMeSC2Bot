using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaMeBotNS
{
    class DebugUtil
    {
       
            // Writing to the console doesn't work on linux when the output stream is closed.
            // Here we check if that is the case and if so we stop writing to the console.
            private static bool ConsoleBroken = false;

            public static void WriteLine(string line)
            {
                if (!ConsoleBroken)
                {
                    try
                    {
                        Console.WriteLine(line);
                    }
                    catch (Exception)
                    {
                        ConsoleBroken = true;
                    }
                }
            }

            public static void WriteLine()
            {
                WriteLine("");
            }
        }
    }


