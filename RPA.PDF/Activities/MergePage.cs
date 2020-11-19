using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.ComponentModel;
using iTextSharp.text.pdf;
using iTextSharp.text;
using RPA.PDF.Utilities;

namespace RPA.PDF
{
    [Designer(typeof(MergePageDesigner), typeof(System.ComponentModel.Design.IDesigner))]
    [System.Drawing.ToolboxBitmap(typeof(ResFinder), "Resources.toolbox.pdf-split1.png")]
    public class MergePage : CodeActivity
    {

        public InArgument<string> SourcePath { get; set; }
        public InArgument<string[]> FileName { get; set; }
        public InArgument<string> OutputPath { get; set; }
        public InArgument<string> OutputFileName{ get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            string sourcePath = context.GetValue(this.SourcePath);
            string[] fileName = context.GetValue(this.FileName);
            string outputPath = context.GetValue(this.OutputPath);
            string outputFileName = context.GetValue(this.OutputFileName);

            PDFUtil pdfUtil = new PDFUtil();
            pdfUtil.MergePage(sourcePath, fileName, outputPath, outputFileName);
        }

    }
}
