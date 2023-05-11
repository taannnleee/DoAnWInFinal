using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinDows.Utilities
{
    public class RanDom
    {
        public static string RandomCharacters()
        {
            string characters = "";
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                int rand = random.Next(65, 91);
                char temp = (char)rand;
                characters += temp.ToString();
            }
            return characters;
        }
    }
}
