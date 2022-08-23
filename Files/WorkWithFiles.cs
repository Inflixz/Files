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
        public void FileChanger(string pathgOfFile, bool append)
        {
            using (StreamWriter Writer = new StreamWriter(pathgOfFile, append))
            {
                string containingsOfNewFile = interaction.TakeText();
                Writer.Write(containingsOfNewFile);
            }
        }
    }
}