using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;


namespace PdfSharpTest
{
    public class PdfImage
    {


        public static void Graphics(string filename)
        {
            // Create a temporary file
            var s_document = new PdfDocument();
            s_document.Info.Title = "PDFsharp XGraphic Sample";
            s_document.Info.Author = "Stefan Lange";
            s_document.Info.Subject = "Created with code snippets that show the use of graphical functions";
            s_document.Info.Keywords = "PDFsharp, XGraphics";

            // Create demonstration pages
            new LinesAndCurves().DrawPage(s_document.AddPage(), s_document);
            new Shapes().DrawPage(s_document.AddPage(), s_document);
            //new Paths().DrawPage(s_document.AddPage());
            //new Text().DrawPage(s_document.AddPage());
            new Images().DrawPage(s_document.AddPage(), s_document);

            // Save the s_document...
            s_document.Save(filename);


            // ...and start a viewer
            System.Diagnostics.Process.Start(filename);

        }




    }
}
