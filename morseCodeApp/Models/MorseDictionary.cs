using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morseCodeApp.Models
{

    internal class MorseDictionary
    {
        public Dictionary<string, string> morseCodeMap = new Dictionary<string, string>{
    { ".-", "A" },
    { "-...", "B" },
    { "-.-.", "C" },
    { "-..", "D" },
    { ".", "E" },
    { "..-.", "F" },
    { "--.", "G" },
    { "....", "H" },
    { "..", "I" },
    { ".---", "J" },
    { "-.-", "K" },
    { ".-..", "L" },
    { "--", "M" },
    { "-.", "N" },
    { "---", "O" },
    { ".--.", "P" },
    { "--.-", "Q" },
    { ".-.", "R" },
    { "...", "S" },
    { "-", "T" },
    { "..-", "U" },
    { "...-", "V" },
    { ".--", "W" },
    { "-..-", "X" },
    { "-.--", "Y" },
    { "--..", "Z" }
    };

        public Dictionary<string, string> reverseMorseCodeMap = new Dictionary<string, string>
{
    { "A", ".-" },
    { "B", "-..." },
    { "C", "-.-." },
    { "D", "-.." },
    { "E", "." },
    { "F", "..-." },
    { "G", "--." },
    { "H", "...." },
    { "I", ".." },
    { "J", ".---" },
    { "K", "-.-" },
    { "L", ".-.." },
    { "M", "--" },
    { "N", "-." },
    { "O", "---" },
    { "P", ".--." },
    { "Q", "--.-" },
    { "R", ".-." },
    { "S", "..." },
    { "T", "-" },
    { "U", "..-" },
    { "V", "...-" },
    { "W", ".--" },
    { "X", "-..-" },
    { "Y", "-.--" },
    { "Z", "--.." }
};

    }
}
