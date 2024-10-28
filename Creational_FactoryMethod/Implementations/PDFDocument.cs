using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_FactoryMethod.Implementations
{
    public class PDFDocument : AbstractClasses.Document
    {
        public PDFDocument()
        {
            FileType = "PDF";
        }

        public override void Open()
        {
            Console.WriteLine("Abrindo documento PDF: " + Title);
        }

        public override void Save()
        {
            Console.WriteLine("Salvando documento PDF: " + Title);
        }
    }
}
