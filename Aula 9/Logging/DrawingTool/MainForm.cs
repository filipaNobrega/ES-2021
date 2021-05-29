using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Logging;

namespace DrawingTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Logger.Instance.Recorder = new DateDecorator(new RichTextBoxRecorder(infoRichTextBox));
        }

        private void OnPaint(object sender, PaintEventArgs args)
        {
            var stopwatch = Stopwatch.StartNew();

            var colors = new[]
            {
                Color.Aqua,
                Color.Green,
                Color.Blue,
                Color.LightCoral,
                Color.Pink,
                Color.BlueViolet,
                Color.Brown,
                Color.Gray,
                Color.Yellow,
                Color.Orange
            };
            var random = new Random();
            for (int i = 0; i < 100000; i++)
            {
                var x = random.Next(ClientSize.Width - 10);
                var y = random.Next(ClientSize.Height - 10);
                var width = random.Next(ClientSize.Width - x);
                var height = random.Next(ClientSize.Height - y);
                
                var flyweight = FlyweightFactory.GetFlyweight(colors[random.Next(10)]);
                flyweight.DrawRectangle(args.Graphics, x, y, width, height);
            }

            stopwatch.Stop();

            Logger.Instance.Log($"Took about {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
