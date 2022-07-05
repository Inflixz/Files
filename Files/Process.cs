using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Process///процес взаимодействия с пользователем
    {
        public Process()
        {
            interaction = new Interaction();
        }
        Interaction interaction;
        public void Menu()
        {
            interaction.ShowTextWriteLine("1 - создать файл \n 2 - прочитать файл \n 3 - выход");
        }
        public void User()
        {
            WorkWithFiles workWithFiles = new WorkWithFiles();
            int number;
            string input = interaction.TakeText();
            int.TryParse(input, out number);
            while (number != 3)
            {
                interaction.ShowTextWriteLine("Напшите путь вашего файла");
                string pathgOfFile = interaction.TakeText();
                switch (number)
                {
                    case 1:
                        {
                            workWithFiles.CreateFile(pathgOfFile);
                            break;
                        }
                    case 2:
                        {
                            workWithFiles.ReadFile(pathgOfFile);
                            break;
                        }
                }
            }
        }
    }
}
