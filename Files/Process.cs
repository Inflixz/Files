using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        /// <summary>
        /// Взаимодействие с пользователем
        /// </summary>
        public void ActionsOfUser()
        {
            bool append = true;
            bool exist = true;//по умолчанию true - такой файл существует
            WorkWithFiles workWithFiles = new WorkWithFiles();
            int chooseOfACtion = interaction.TakeNumber();
            Menu();
            while (chooseOfACtion != 3)
            {
                interaction.ShowTextWriteLine("Напшите путь вашего файла");
                string pathgOfFile = interaction.TakeText();
                if (File.Exists(pathgOfFile))//?файл существует
                {
                    exist = true;//существует
                }

                if (chooseOfACtion == 1 && exist == false)//Если такой файл не существует 
                {
                    workWithFiles.FileChanger(pathgOfFile, append);
                }
                else if(chooseOfACtion == 1 && exist == true)//Если такой файл уже существует 
                {
                    interaction.ShowTextWriteLine("Такой файл уже есть. Перезаписать - 0," +
                                      "дописать файл - 1");
                    int changesInFile = interaction.TakeNumber();
                    if (changesInFile == 0)
                    {
                        append = false;
                    }
                    else
                    {
                        append = true;
                    }
                    workWithFiles.FileChanger(pathgOfFile, append);
                }

                //Чтение
                if(chooseOfACtion == 2 && exist == true)//мы можем прочитать файл только если он существует
                {
                    workWithFiles.ReadFile(pathgOfFile);
                    interaction.ShowTextWriteLine("Хотите что-то сделать с файлом(закончить - 0, " +
                                                  "изменнения в файле - 1)?");
                    int choose = interaction.TakeNumber();
                    if (choose == 1)//если пользователь хочет изменить что-нибудь в файле
                    {
                        interaction.ShowTextWriteLine("Перезаписать - 0," +
                                        "дописать файл - 1");
                        int changesInFile = interaction.TakeNumber();
                        if (changesInFile == 0)
                        {
                            append = false;
                        }
                        else
                        {
                            append = true;
                        }
                        workWithFiles.FileChanger(pathgOfFile, append);
                    }
                }
                Menu();
                chooseOfACtion = interaction.TakeNumber();
            }
        }
    }
}
