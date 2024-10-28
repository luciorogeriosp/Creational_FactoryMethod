using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_FactoryMethod.AbstractClasses
{
    public abstract class DocumentFactory
    {
        public abstract Document CreateDocument();
    }
}
