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
        public void ActionsOfUser()
        {
            WorkWithFiles workWithFiles = new WorkWithFiles();
            int chooseOfACtion = interaction.TakeNumber();
            Menu();
            while (chooseOfACtion != 3)
            {
                interaction.ShowTextWriteLine("Напшите путь вашего файла");
                string pathgOfFile = interaction.TakeText();
                if (chooseOfACtion == 1)
                {
                    workWithFiles.CreateFile(pathgOfFile);
                }
                else
                {
                    workWithFiles.ReadFile(pathgOfFile);
                    interaction.ShowTextWriteLine("Хотите что-то сделать с файлом(закончить - 0, " +
                                                  "изменнения в файле - 1)?");
                    int choose = interaction.TakeNumber();
                    if (choose == 1)
                    {
                        workWithFiles.CreateFile(pathgOfFile);
                    }
                }
                Menu();
                chooseOfACtion = interaction.TakeNumber();
            }
        }
    }
}
