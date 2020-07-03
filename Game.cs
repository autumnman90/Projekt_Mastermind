using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace Projekt_Mastermind
{
    public enum SND
    {
        Play,
        Stop
    }

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


        public static CBox[] CheckCode(CodeColor[] original, CodeColor[] input)
        {
            int cntRightPlace = 0;
            int cntRightColor = 0;
            int dif = 0;

            CBox[] output = new CBox[4];
            //TODO: for schleifen durch whileschliefe ersetzen (Kassettenmethode)

            for (int i = 0; i < original.Length; i++)
            {
                if (original[i] == input[i])
                {
                    cntRightPlace++;
                    continue;
                }
                else
                {
                    
                    for (int j = 0; j < original.Length; j++)
                    {
                        if (original[j] == input[i])
                        {
                            cntRightColor++;
                        }
                    }
                    
                }
            }

            if (cntRightPlace > cntRightColor)
            {
                dif = cntRightPlace - cntRightColor;
            }
            else if (cntRightColor > cntRightPlace)
            {
                dif = cntRightColor - cntRightPlace;
            }


            for (int i = 0; i < cntRightPlace; i++)
            {
                output[i] = CBox.Black;
            }

            for (int i = cntRightPlace; i < dif; i++)
            {
                output[i] = CBox.White;
            }

            return output;
        }
   
    }
}
