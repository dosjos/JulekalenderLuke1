﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulekalenderLuke4
{
    class Program
    {
        static void Main(string[] args)
        {

            var s = "TAACGAGTCTGCCACTAGATAGCCCGCGCTATTAATGGGATGTTCTAGGTCTTCACCTCGACCTATACAAGACGAGAAT"+
                    "TCTGGTTCAGCCGGTCCGGGGTCGGGAGTTTGGCTTCATAACACAATTGCAGGCGTCAGAGGCCATACCTTAAACCCAT"+
                    "CATACGACCGGTACGAAAATCCATGTCACAGACTAATGATCCCTGCTAAGAGATCGTAGCAACCGTTCTGGATCCAAGC"+
                    "AGCTAATAAGTTAGCAAGCTGGTGTGTTTTTGATATTTGCAGTGGCAAACTGTTGCCTGGGTCGGTCCGATGGTCCTCA"+
                    "TCGGACGCTGATGACGGACTTTGCACGGTCGCAAGTCGCTGATAGAAGGTGACTCTCGTGCACGATTTAGACCGGCAGT"+
                    "GCTGCGTGAAGGGGGCTCCCTTATCTGATATGCGCAGACTATTTCGGCGTGGAATGCACATGTTCCCCGACCACTTCAA"+
                    "CCCTCATGTTGAGGACTTCCTGCCATAACAACAGGGTAACTTAACTCAGGATGTCTTAAAAAAATAGGCTTCTCATGTG"+
                    "CTCACATTTGGGACCGTATGTGCTAAACGGTGTACTATACGCGGTGGAATTTGGAATGGCAAACTTAACAGCAGGTCTA"+
                    "ACCGTAGAAGACGTTACGAGTAAGTGTCAAGTCAGCATTGGCGGATCACGGCGTCGCTATGCCGTCAAGCTCTTTTGCG"+
                    "GATATGATCTAAATCAGATTACGAGCGACGCCTGTTTCTAAAATGACCAATGGTACGCAACACGCTGGTAGGATCTGAG"+
                    "CGAGCAAAGCATAAATAGACCCATCGTGTCGCCTGTAAATTGCAAGAGTACCAAGAACCCCGCAATTACGTTGGGTTCG"+
                    "CTATAGTTGAAAGTTACCGATAAACTACCTTTCGCGACCCGTTTTATAACATAACTAGCATTATTACTCAAGGTGCTCT"+
                    "GATTCCCAGAATACCCAAGAACTAGCGCGTTTTTATTTCTTTGGGGAGGTCTTGTCATGATGTTCATACTTGTCGCCTA"+
                    "GGTTTGCCGACTTGTCCTTCTCTTACACTATTCCGAAATCGCAGTTGCACCACGATCGATGAGCATGGTAGTTACTTAA"+
                    "ATATTCAAGAGTCCTGGTCCTCGAAATGGCATATGCTTGCAGGTGCCCCCGATCAGATAGAAGACCGCGGCCGAGGAGG"+
                    "TAGTCCGGTACTGTGCGTTTGGTGCCTTTGACTCTTTACGCACTACTGGACCGGCCTTCGAGGTCTAAGGCTACGTCCT"+
                    "TTAACGCTTTTACTATACAATAGAAGGTGTTCTACACACTGCGTGTCGCTGGATTGGCCTTCGACACGCCTTAGCGGCA"+
                    "TGTATCAAGCTATCAGGGAGCCCATTGTGGGCGGTTACTCGTCGTTTGCACAACATCAGACCATTCACTATTAAGCTCA"+
                    "TCCCCGAAGAAGGCACCCTACCGTTGTAAGTGCGACTTTGGAACCTCTCGGTAATGCCGGTTGCGGCACTTTCAACGTA"+
                    "CATTCCGACCTAGTGCAGAAGAATGGATAGCGAGCTGTTTTTCGAGCTCTACCTAATCGGCTCGAATCTACTCGACGTG"+
                    "TCGAGCGTCCTGTCGCATGGCTCGAAGCGGTATCGAGTCAGTCCCCCAGGGGCGCCGACACGTAGTGAGGTGAAAACAT"+
                    "CGACATGTGCTTTTGATGTATATGGCTGAGCTTCAATGCGTGGCTAAAGTGGTCAATCCACTCAGGGCATGGATACTCG"+
                    "GCTCAACATAGTAAATTGTCTCCGCGTCCGATAGGCGGGGGTCAATCCGCCGCACTGGTGGGTCACCCGTGATGCTAGG"+
                    "TCTATAGCAGGGCCCCGACCGTAAACTTCAAGCTTTCCCGGTTGCTGTTGTTTTTTGAGCACAGGGAAACGAGCAGTAT"+
                    "TGAATCTGAAGGGGGATAGGCGTTTAATTATTCAGAAGTAGTGCGAAGGGCTCCATATGACACTAGTCGTAGTAAGCAC"+
                    "ATGCTGGAGGTCTGGACTTCCTTCG";
            int a = 0, c = 0, g = 0, t=0;

            foreach (var ca in s)
            {
                switch (ca)
                {
                    case 'A':
                        a++;
                        break;
                    case 'C':
                        c++;
                        break;
                    case 'G':
                        g++;
                        break;
                    case 'T':
                        t++;
                        break;
                }
            }

            Console.WriteLine("A{0}, C{1}, G{2}, T{3}",a,c,g,t);
            Console.ReadLine();
        }
    }
}
