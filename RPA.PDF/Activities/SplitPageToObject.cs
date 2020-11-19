using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.ComponentModel;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace RPA.PDF
{
    [Designer(typeof(SplitPageToObjectDesigner), typeof(System.ComponentModel.Design.IDesigner))]
    [System.Drawing.ToolboxBitmap(typeof(ResFinder), "Resources.toolbox.readpdf.png")]
    public class SplitPageToObject : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<string> Text { get; set; }

        public InArgument<string> FilePath { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            string text = context.GetValue(this.Text);
        }

       
    }
}
