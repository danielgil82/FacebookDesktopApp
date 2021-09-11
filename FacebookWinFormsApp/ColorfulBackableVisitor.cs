using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace BasicFacebookFeatures
{
    internal class ColorfulBackableVisitor
    {
        private readonly List<Color> m_Colors = new List<Color>() {Color.Aqua, Color.Azure, Color.BurlyWood, Color.IndianRed, Color.DeepPink, Color.LawnGreen};
        private Timer m_Timer = new Timer(500);
        private Random m_RandomIndex = new Random();

        public Button BackButton { get; set; }

        public int RandomIdx { get; set; }

        public ColorfulBackableVisitor()
        {
            m_Timer.Elapsed += TimerOnElapsed;
            m_Timer.Enabled = true;
            m_Timer.AutoReset = true;
            m_Timer.Start();
            BackButton = new Button();
        }

        private void TimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            RandomIdx = m_RandomIndex.Next(m_Colors.Count);
            BackButton.BackColor = m_Colors[RandomIdx];
        }

        internal void Back(Form i_CurrentForm)
        {
            m_Timer.Stop();
            i_CurrentForm.Close();
        }
    }
}
