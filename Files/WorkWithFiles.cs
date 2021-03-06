using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    class WorkWithFiles
    {
        public WorkWithFiles()
        {
            interaction = new Interaction();
        }
        Interaction interaction;

        public void ReadFile(string path)
        {
            using (StreamReader read = new StreamReader(path))
            {
                string file = read.ReadToEnd();
                interaction.ShowTextWriteLine(file);
            }
        }
        public void CreateFile(string pathgOfFile)
        {
            bool append = true;
            if (File.Exists(pathgOfFile))///если такой файл уже существует
            {
                interaction.ShowTextWriteLine("Перезаписать - 0," +
                                              "дописать файл - 1");
                int choose = interaction.TakeNumber();
                if(choose == 0)/// ситуация номер 1: перезапись всего файла
                {
                    append = false;
                    interaction.ShowTextWriteLine("что будет в этом файле?");
                }
                else///ситуация номер 2: дозаписование старого файла
                {
                    append = true;
                    interaction.ShowTextWriteLine("Что будет добавлено в этом файле?");
                }
            }
            else/// если такой файл не существует
            {
                interaction.ShowTextWriteLine("Что будет этом файле?");
            }
            using (StreamWriter Writer = new StreamWriter(pathgOfFile, append))
            {
                string containingsOfNewFile = interaction.TakeText();
                Writer.Write(containingsOfNewFile);
            }
        }
    }
}