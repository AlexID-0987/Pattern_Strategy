using I_Learn_My_Faworite_Programing.PersonWith;
using I_Learn_My_Faworite_Programing.Strategies;
using System;

namespace I_Learn_My_Faworite_Programing
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer("Fred");
            developer.MySuperProgress();
            developer.StartedProgrammer(new ProgrammingAnBasic("Basic", "1995"));
            developer.MySuperProgress();
            developer.StartedProgrammer(new ProgrammingAnConsole("Console APP", "2019"));
            developer.MySuperProgress();
            developer.StartedProgrammer(new ProgramingWPF("C#,WPF", "2020"));
            developer.MySuperProgress();
            developer.StartedProgrammer(new ProgrammingASPNET("ASPnet.Core", "2022"));
            developer.MySuperProgress();
            developer.StartedProgrammer(new ProgrammingAnBeckEnd("React,Angular,Pyton", "2023"));
            developer.MySuperProgress();
        }
    }
}
