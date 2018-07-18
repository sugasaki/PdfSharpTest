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
    public class Images
    {

        public void DrawPage(PdfPage page, PdfDocument s_document)
        {
            XGraphics gfx = XGraphics.FromPdfPage(page);

            var helper = new Helper();
            helper.DrawTitle(page, gfx, "Images", s_document);

            helper.DrawImage(gfx, 1);
            //DrawImageScaled(gfx, 2);
            //DrawImageRotated(gfx, 3);
            //DrawImageSheared(gfx, 4);
            //DrawGif(gfx, 5);
            //DrawPng(gfx, 6);
            //DrawTiff(gfx, 7);
            //DrawFormXObject(gfx, 8);
        }


    }
}
