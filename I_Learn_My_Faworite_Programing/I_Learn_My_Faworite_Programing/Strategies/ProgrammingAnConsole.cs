using System;
using System.Collections.Generic;
using System.Text;

namespace I_Learn_My_Faworite_Programing.Strategies
{
    public class ProgrammingAnConsole : Programinglanguage, Ilearn
    {

        private string Name { get; set; }
        private string Year { get; set; }
        public ProgrammingAnConsole(string name, string year)
        {
            Name = name;
            Year = year;
        }
        
        
        public override string MyProgress()
        {
            return $"\t\t-----------------------------------\n" +
                $"\t\tI`m learning {Name} on {Year}\n" +
                $"\t\t--------------------------------------";
        }
        public void ProgramLearn()
        {
            Console.WriteLine(MyProgress());
        }
    }
}
