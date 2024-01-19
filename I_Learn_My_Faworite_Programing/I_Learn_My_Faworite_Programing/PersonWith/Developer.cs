using I_Learn_My_Faworite_Programing.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace I_Learn_My_Faworite_Programing.PersonWith
{
    class Developer
    {
        private readonly string NameProgramer;
        private Ilearn Ilearn;
        public Developer(string name)
        {
            NameProgramer = name;
        }
        public void StartedProgrammer(Ilearn ilearn)
        {
            Ilearn = ilearn;
        }
        public void MySuperProgress()
        {
            Console.WriteLine($"\t\t///////////////////\n" +
                $"\t\tMyself programmer!\n" +
                $"\t\t////////////////////\n");
            if(Ilearn is null)
            {
                Console.WriteLine($"\t\t{NameProgramer} is trying learn programm!\n");
                return;
            }
            Ilearn.ProgramLearn();
        }
    }
}
