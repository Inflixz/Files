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

        /// <summary>
        /// Прочтение файла
        /// </summary>
        /// <param name="path"></param>
        public void ReadFile(string path)
        {
            try
            {
                if(path == null)
                {
                    throw new ArgumentNullException("Вы ничего не послали!");
                }
                using (StreamReader read = new StreamReader(path))
                {
                    string file = read.ReadToEnd();
                    interaction.ShowTextWriteLine(file);
                }
            }
            catch(Exception ex)
            {
                interaction.ShowTextWriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Изменение файла
        /// </summary>
        /// <param name="pathgOfFile"></param>
        /// <param name="append"></param>
        public void FileChanger(string pathgOfFile, bool append)
        {
            try
            {
                if(pathgOfFile == null)
                {
                    throw new ArgumentNullException("Вы ничего не послали!");
                }
                using (StreamWriter Writer = new StreamWriter(pathgOfFile, append))
                {
                    string containingsOfNewFile = interaction.TakeText();
                    Writer.Write(containingsOfNewFile);
                }
            }
            catch(Exception ex)
            {
                interaction.ShowTextWriteLine(ex.Message);
            }
        }
    }
}