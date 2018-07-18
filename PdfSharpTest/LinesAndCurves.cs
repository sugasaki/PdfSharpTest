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

    public class LinesAndCurves
    {

        public void DrawPage(PdfPage page, PdfDocument s_document)
        {
            XGraphics gfx = XGraphics.FromPdfPage(page);

            var helper = new Helper();
            helper.DrawTitle(page, gfx, "Lines & Curves", s_document);

            //DrawLine(gfx, 1);
            DrawLines(gfx, 2);
            //DrawBezier(gfx, 3);
            //DrawBeziers(gfx, 4);
            //DrawCurve(gfx, 5);
            //DrawArc(gfx, 6);
        }


        void DrawLines(XGraphics gfx, int number)
        {
            //BeginBox(gfx, number, "DrawLines");

            XPen pen = new XPen(XColors.DarkSeaGreen, 6);
            pen.LineCap = XLineCap.Round;
            pen.LineJoin = XLineJoin.Bevel;
            XPoint[] points =
              new XPoint[] { new XPoint(20, 30), new XPoint(60, 120), new XPoint(90, 20), new XPoint(170, 90), new XPoint(230, 40) };
            gfx.DrawLines(pen, points);

            //EndBox(gfx);
        }



    }
}
