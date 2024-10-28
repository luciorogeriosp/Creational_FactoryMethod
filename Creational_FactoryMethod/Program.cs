using Creational_FactoryMethod.AbstractClasses;
using Creational_FactoryMethod.Implementations.Factories;

Console.WriteLine("Hello, World!");


DocumentFactory pdfFactory = new PDFDocumentFactory();
Document pdf = pdfFactory.CreateDocument();
pdf.Title = "Relatório Anual";
pdf.Content = "Conteúdo do relatório";
pdf.Open();
pdf.Save();

Document pdf2 = pdfFactory.CreateDocument();
pdf2.Title = "Relatório Anual 2";
pdf2.Content = "Conteúdo do relatório";
pdf2.Open();
pdf2.Save();

DocumentFactory wordFactory = new WordDocumentFactory();
Document word = wordFactory.CreateDocument();
word.Title = "Carta de Apresentação";
word.Content = "Conteúdo da carta";
word.Open();
word.Save();