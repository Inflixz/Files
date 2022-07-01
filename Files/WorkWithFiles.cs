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
                interaction.ShowTextWriteLine("Хотите что-то сделать с файлом(Перезаписать - 0, дописать файл - 1)?");
                CreateFile(file);
            }
        }
        public void CreateFile(string pathgOfFile)
        {
            if (File.Exists(pathgOfFile))///если такой файл уже существует
            {
                interaction.ShowTextWriteLine("Такой файл уже есть! Перезаписать - 0," +
                                              "дописать файл - 1");
                string input = interaction.TakeText();
                int number;
                int.TryParse(input, out number);
                switch(number)
                {
                    case 0:/// ситуация номер 1: перезапись всего файла
                        {
                            bool append = false;
                            using (StreamWriter Writer = new StreamWriter(pathgOfFile, append))
                            {
                                interaction.ShowTextWriteLine("что будет в этом файле?");
                                string containingsOfNewFile = interaction.TakeText();
                                Writer.Write(containingsOfNewFile);
                            }
                            break;
                        }
                    case 1: ///ситуация номер 2: дозаписование старого файла
                        {
                            bool append = true;
                            using (StreamWriter Writer = new StreamWriter(pathgOfFile, append))
                            {
                                interaction.ShowTextWriteLine("Что будет добавлено в этом файле?");
                                string AddingOfFile = interaction.TakeText();
                                Writer.Write(AddingOfFile);
                            }
                            break;
                        }
                }
            }
            else/// если такой файл не существует
            {
                bool append = true;
                using (StreamWriter Writer = new StreamWriter(pathgOfFile, append))
                {
                    interaction.ShowTextWriteLine("Что будет этом файле?");
                    string containingsOfNewFile = interaction.TakeText();
                    Writer.Write(containingsOfNewFile);
                }
            }
        }
    }
}