using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_Mastermind
{
    class Game
    {
        //

        public static CodeColor[] NewCode()
        {
            CodeColor[] hiddenCode = new CodeColor[4];

            Random codeGenerator = new Random();

            for (int i = 0; i < hiddenCode.Length; i++)
            {
                hiddenCode[i] = (CodeColor)codeGenerator.Next(0, (int)CodeColor.Count);
            }

            return hiddenCode;
        }


        public static bool CheckCode(CodeColor[] original, CodeColor[] input)
        {
            bool solved = false;
            int counter = 0;

            for (int i = 0; i < original.Length; i++)
            {
                if (original[i] == input[i])
                {
                    counter++;
                }
            }

            if (counter > 3)
            {
                solved = true;
            }

            return solved;
        }

        
    }
}
