﻿using Creational_FactoryMethod.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_FactoryMethod.Implementations.Factories
{
    public class PDFDocumentFactory : DocumentFactory
    {
        public override Document CreateDocument()
        {
            return new PDFDocument();
        }
    }
}
