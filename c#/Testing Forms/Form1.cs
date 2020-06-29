using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace TestingForms
{
    public partial class form : Form
    {
        public static SpeechSynthesizer speak = new SpeechSynthesizer();

        public form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutBox1 abbo = new AboutBox1();
            abbo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            speak.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            //if (richTextBox1.TextLength == 0)
            //{
            //    speak.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            //    speak.Speak("Type something you fucking ideot");
            //}
            //else
            //{
            //    speak.Speak(richTextBox1.Text);
            //}
            if (richTextBox1.Text == "Are you gay")
            {
                speak.Speak("No");
            }
            else if(richTextBox1.Text == "Do you have family")
            {
                speak.Speak("Yes, two brothers");
            }
            else if(richTextBox1.Text == "42")
            {
                speak.Speak("What is the meaning of life, are we here to just suffer, or to make pain?");
            }
            if(richTextBox1.Text == "Fuck you")
            {
                speak.Speak("Fuck you, you stupid human");
            }
            else if(richTextBox1.Text == "What is the weather")
            {
                speak.Speak("I dont no, how about you to look outside, and get of your lazy ass");
            }
            else if(richTextBox1.Text == "Help me")
            {
                speak.Speak("Oh k, calling your mom");
            }
        }

        private void form_Load(object sender, EventArgs e)
        {
            
        }
    }
}
