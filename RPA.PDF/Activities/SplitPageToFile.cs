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
    [Designer(typeof(SplitPageToFileDesigner), typeof(System.ComponentModel.Design.IDesigner))]
    [System.Drawing.ToolboxBitmap(typeof(ResFinder), "Resources.toolbox.pdf-split1.png")]
    public class SplitPageToFile : CodeActivity
    {

        public InArgument<string> FilePath { get; set; }
        public InArgument<string> OutputPath { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            string filePath = context.GetValue(this.FilePath);
            string outputPath = context.GetValue(this.OutputPath);

            PDFUtil pdfUtil = new PDFUtil();
            pdfUtil.ExtractPagesToFile(filePath, outputPath);

        }

    }
}
