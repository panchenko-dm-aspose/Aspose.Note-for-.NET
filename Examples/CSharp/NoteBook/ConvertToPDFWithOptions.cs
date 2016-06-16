
using System.IO;
using Aspose.Note;
using Aspose.Note.Saving;
using System;
using System.Collections.Generic;

namespace Aspose.Note.Examples.CSharp.WorkingWithNoteBook
{
    public class ConvertToPDFWithOptions
    {
        public static void Run()
        {
            // ExStart:ConvertToPDFWithOptions
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_NoteBook();

            // Load a OneNote Notebook
            var notebook = new Notebook(dataDir + "Notizbuch �ffnen.onetoc2");

            var notebookSaveOptions = new NotebookPdfSaveOptions();

            var documentSaveOptions = notebookSaveOptions.DocumentSaveOptions;

            documentSaveOptions.PageSplittingAlgorithm = new KeepSolidObjectsAlgorithm();

            dataDir = dataDir + "ConvertToPDF_out_.pdf";

            // Save the Notebook
            notebook.Save(dataDir, notebookSaveOptions);

            // ExEnd:ConvertToPDFWithOptions
            Console.WriteLine("\nNoteBook document converted to pdf successfully with save options.\nFile saved at " + dataDir);
        }
    }
}