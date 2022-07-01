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
                int number;
                string file = read.ReadToEnd();
                interaction.ShowTextWriteLine(file);
                interaction.ShowTextWriteLine("хотите дописать или перезаписать (дописать - 1,перезаписать - 2)?");
                string input = interaction.TakeText();
                int.TryParse(input, out number);
                if(number == 1)
                {

                }
            }
        }
        public void CreateFile(string pathgOfFile)
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