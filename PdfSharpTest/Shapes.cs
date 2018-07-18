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
    public class Shapes
    {

        public void DrawPage(PdfPage page, PdfDocument s_document)
        {
            XGraphics gfx = XGraphics.FromPdfPage(page);

            var helper = new Helper();
            helper.DrawTitle(page, gfx, "Shapes", s_document);

            //DrawRectangle(gfx, 1);
            //DrawRoundedRectangle(gfx, 2);
            //DrawEllipse(gfx, 3);
            //DrawPolygon(gfx, 4);
            //DrawPie(gfx, 5);
            //DrawClosedCurve(gfx, 6);
        }


    }
}
