using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_FactoryMethod.AbstractClasses
{
    public abstract class Document
    {
        public  string? Title { get; set; }
        public string? Content { get; set; }
        public string? FileType { get; set; }

        public abstract void Open();
        public abstract void Save();
    }
}
