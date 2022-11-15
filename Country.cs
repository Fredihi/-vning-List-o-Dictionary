using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_List_o_Dictionary
{
    public class Country
    {
        public string Name;
        public int Code;
        public string Capital;

        public Country(string name, int code, string capital)
        {
            Name = name;
            Code = code;
            Capital = capital;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nCode: {Code}\nCapital: {Capital}";
        }
    }
}
