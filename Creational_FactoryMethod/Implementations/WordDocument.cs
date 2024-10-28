using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_FactoryMethod.Implementations
{
    public class WordDocument : AbstractClasses.Document
    {
        public WordDocument()
        {
            FileType = "Word";
        }

        public override void Open()
        {
            Console.WriteLine("Abrindo documento Word: " + Title);
        }

        public override void Save()
        {
            Console.WriteLine("Salvando documento Word: " + Title);
        }
    }
}
