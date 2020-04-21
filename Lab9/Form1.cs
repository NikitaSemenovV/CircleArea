using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
        private readonly Color[] colors = { Color.Blue, Color.Red, Color.Brown, Color.DarkRed, Color.LimeGreen, Color.MediumSpringGreen, Color.Teal, Color.Aqua, Color.Coral, Color.Khaki,
        Color.Yellow, Color.HotPink, Color.DarkOrange, Color.Lavender, Color.Purple, Color.MidnightBlue, Color.Indigo, Color.Maroon, Color.Fuchsia, Color.Navy};

        private static Graphics graphics;
        private static int[] center;
        private static int r, inp = 0, total = 0;
        private static int _tracker = 0;
        private List<System.Threading.Timer> timers;

        private static ThreadLocal<Random> _random = new ThreadLocal<Random>(() => {
            var seed = (int)(Environment.TickCount & 0xFFFFFF00 | (byte)(Interlocked.Increment(ref _tracker) % 255));
            var random = new Random(seed);
            return random;
        });

        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;
            graphics.Clear(Color.White);
            inp = 0;
            total = 0;
            center = new int[2] { pictureBox1.Width / 2, pictureBox1.Height / 2 };
            r = (int)rad.Value;
            graphics.DrawRectangle(Pens.Black, center[0] - r, center[1] - r, r * 2, r * 2);
            graphics.DrawEllipse(Pens.Green, center[0] - r, center[1] - r, r * 2, r * 2);
            timers = new List<System.Threading.Timer>();
            for (int i = 0; i < threadNum.Value; i++)
            {
                timers.Add(new System.Threading.Timer(new TimerCallback(DrawDot), GetPen(i), i * 1000, (int)interv.Value));
            }
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            foreach (System.Threading.Timer timer in this.timers)
                timer.Dispose();
            button2.Enabled = true;
            resText.Text = (Math.Pow(r * 2, 2) * inp / total).ToString();
        }

        private Pen GetPen(int i) => new Pen(colors[i], 1);

        public void DrawDot(object pen)
        {
            Interlocked.Increment(ref total);
            int x = _random.Value.Next(center[0] - r, center[0] + r);
            int y = _random.Value.Next(center[1] - r, center[1] + r);
            lock (graphics)
            {
                graphics.DrawRectangle((Pen)pen, x, y, 1, 1);
            }
            if (Math.Pow(x - center[0], 2) + Math.Pow(y - center[1], 2) <= Math.Pow(r, 2))
                Interlocked.Increment(ref inp);
        }
    }
}
