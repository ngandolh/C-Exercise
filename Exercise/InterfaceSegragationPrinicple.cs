using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public interface IReadableDocument
    {
        void Open();
    }

    public interface IPrintableDocument
    {
        void Print();
    }

    public interface ISaveableDocument
    {
        void Save();
    }

    public interface IEmailableDocument
    {
        void Email();
    }

    //Classes implementing specific interfaces
    public class SimpleDocument : IReadableDocument, IPrintableDocument, IEmailableDocument
    {
        public void Email()
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }

    //Client using the specific interfaces
    public class DocumentClient
    {
        private IReadableDocument readbleDocument;
        private IPrintableDocument printableDocument;
        private ISaveableDocument saveableDocument;

        public DocumentClient(IReadableDocument readDoc, IPrintableDocument printDoc, ISaveableDocument saveDoc)
        {
            this.readbleDocument = readDoc;
            this.printableDocument = printDoc;
            this.saveableDocument = saveDoc;
        }

        public void PerformActions()
        {
            readbleDocument.Open();
            printableDocument.Print();
            saveableDocument.Save();
        }
    }
}
