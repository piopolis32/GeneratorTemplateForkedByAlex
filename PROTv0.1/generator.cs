﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PROTv0._1
{
    /// <summary>
    /// Class that generate and print questions
    /// </summary>
    internal static class Generator
    {
        
        /// <summary>
        /// Function that generate and print linear question, can generate true and false questions
        /// </summary>
        /// <param name="mas">array of data</param>
        /// <param name="ogr">integer that used in random (less number)</param>
        /// <param name="amount">integer represent amount of generated questions</param>>
        /// <param name="flag">bool is Negative?</param>>
        public static void GenerateLinear(MyData[] mas,int ogr,int amount, bool flag) {
            Random rand = new Random();
            int amQuest = 0;
            List<int> intTrueAns = new List<int> ();
            List<int> intFalseAns = new List<int> ();
            List<int> intQuest = new List<int> ();

            void ParseData(MyData[] mas)
            {
                int i = -1;
                while (i++ < mas.Length-1)
                {
                    
                    if (mas[i].priz == 1 && mas[i].isNeg==flag)
                    {
                        intQuest.Add (i);
                    }
                    else
                    {
                        if (mas[i].isTrue)
                        {
                            intTrueAns.Add (i);
                        }
                        else
                        {
                            intFalseAns.Add (i);
                        }
                    }
                }
            }

            void GenerateQuest(List<int> a,List<int> b,int k)
            {
                Console.WriteLine($"1){mas[a[rand.Next(a.Count)]].text}");
                k--;
                while (k-- > 0)
                {
                    int IA = rand.Next(b.Count);
                    var AA = mas[b[IA]];
                    b.RemoveAt(IA);

                    Console.WriteLine($"T){AA.text}");
                }
            }

            ParseData(mas);

            while (amount-- > 0)
            {
                List<int> mT = intTrueAns.Slice(0, intTrueAns.Count);
                List<int> mF = intFalseAns.Slice(0, intTrueAns.Count);
                int k = rand.Next(2, ogr);

                int IQ = rand.Next(intQuest.Count);
                var AQ = mas[intQuest[IQ]];
                intQuest.RemoveAt(IQ);

                Console.WriteLine($"{AQ.text}");
                if (AQ.isNeg)
                {
                    GenerateQuest(mF, mT, k);
                }
                else
                {
                    GenerateQuest(mT, mF, k);
                }

            }

        }
        /// <summary>
        /// Function that generate and print IsItquestion
        /// </summary>
        /// <param name="mas">Array of Data</param>
        /// <param name="amount">Amount of Question</param>
        public static void GenerateIsIt(MyData[] mas,int amount)
        {
            const String APPE = "Являются ли ";
            const String ANSW = "1)Являются.\n2)Не являются";
            String ENDP = "";
            List<int> IntQuest = new List<int>();   
            for(int i = 0; i < mas.Length - 1; i++)
            {
                if (mas[i].priz == 2)
                {
                    IntQuest.Add(i);
                }
                else
                {
                    if (mas[i].priz == 0)
                    {
                        ENDP = mas[i].text;
                    }
                }
            }


            while (amount-->0)
            {
                Random m = new Random();
                int IA = m.Next(IntQuest.Count);
                int AA = IntQuest[IA];
                IntQuest.RemoveAt(IA);

                Console.WriteLine($"{APPE} {mas[AA].text.ToLower()} {ENDP}?\n{ANSW}");

            }


        }


    }
}
