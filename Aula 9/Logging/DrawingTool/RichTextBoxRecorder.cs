using System.Windows.Forms;
using Logging;

namespace DrawingTool
{
    public class RichTextBoxRecorder : IRecorder
    {
        private readonly RichTextBox _richTextBox;

        public RichTextBoxRecorder(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox;
        }
        public void Record(string message)
        {
            _richTextBox.Text = message;
        }
    }
}