using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace check
{
    public partial class voice : Form
    {
        Random random = new Random();
        submain submain;
        bat bat;
        public voice()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string check = trackBar1.Value.ToString();
                textBox1.Text = check;
                if (textBox1.Text == "0")
                {
                    if (globals.isbat == true)
                    {
                        var process = new Process();
                        process.StartInfo = new ProcessStartInfo(globals.batfile)
                        {
                            UseShellExecute = true
                        };
                        process.Start();
                        globals.rate = 0;
                        Speech.Speak(globals.batmsg);
                    }
                    else
                    {
                        globals.rate = 0;
                        Speech.Speak(globals.title + " , " + globals.msg);
                    }
                }
                if (textBox1.Text == "-1")
                {
                    if (globals.isbat == true)
                    {
                        var process = new Process();
                        process.StartInfo = new ProcessStartInfo(globals.batfile)
                        {
                            UseShellExecute = true
                        };
                        process.Start();
                        globals.rate = -1;
                        Speech.Speak(globals.batmsg);
                    }
                    else
                    {
                        globals.rate = -1;
                        Speech.Speak(globals.title + " , " + globals.msg);
                    }
                }
                if (textBox1.Text == "-2")
                {
                    if (globals.isbat == true)
                    {
                        var process = new Process();
                        process.StartInfo = new ProcessStartInfo(globals.batfile)
                        {
                            UseShellExecute = true
                        };
                        process.Start();
                        globals.rate = -2;
                        Speech.Speak(globals.batmsg);
                    }
                    else
                    {
                        globals.rate = -2;
                        Speech.Speak(globals.title + " , " + globals.msg);
                    }
                }
                if (textBox1.Text == "-3")
                {
                    if (globals.isbat == true)
                    {
                        var process = new Process();
                        process.StartInfo = new ProcessStartInfo(globals.batfile)
                        {
                            UseShellExecute = true
                        };
                        process.Start();
                        globals.rate = -3;
                        Speech.Speak(globals.batmsg);
                    }
                    else
                    {
                        globals.rate = -3;
                        Speech.Speak(globals.title + " , " + globals.msg);
                    }
                }
                if (textBox1.Text == "-4")
                {
                    if (globals.isbat == true)
                    {
                        var process = new Process();
                        process.StartInfo = new ProcessStartInfo(globals.batfile)
                        {
                            UseShellExecute = true
                        };
                        process.Start();
                        globals.rate = -4;
                        Speech.Speak(globals.batmsg);
                    }
                    else
                    {
                        globals.rate = -4;
                        Speech.Speak(globals.title + " , " + globals.msg);
                    }
                }
                if (textBox1.Text == "-5")
                {
                    if (globals.isbat == true)
                    {
                        var process = new Process();
                        process.StartInfo = new ProcessStartInfo(globals.batfile)
                        {
                            UseShellExecute = true
                        };
                        process.Start();
                        globals.rate = -5;
                        Speech.Speak(globals.batmsg);
                    }
                    else
                    {
                        globals.rate = -5;
                        Speech.Speak(globals.title + " , " + globals.msg);
                    }
                }
                if (textBox1.Text == "-6")
                {
                    if (globals.isbat == true)
                    {
                        var process = new Process();
                        process.StartInfo = new ProcessStartInfo(globals.batfile)
                        {
                            UseShellExecute = true
                        };
                        process.Start();
                        globals.rate = -6;
                        Speech.Speak(globals.batmsg);
                    }
                    else
                    {
                        globals.rate = -6;
                        Speech.Speak(globals.title + " , " + globals.msg);
                    }
                }
                if (textBox1.Text == "-7")
                {
                    if (globals.isbat == true)
                    {
                        var process = new Process();
                        process.StartInfo = new ProcessStartInfo(globals.batfile)
                        {
                            UseShellExecute = true
                        };
                        process.Start();
                        globals.rate = -7;
                        Speech.Speak(globals.batmsg);
                    }
                    else
                    {
                        globals.rate = -7;
                        Speech.Speak(globals.title + " , " + globals.msg);
                    }
                }
                if (textBox1.Text == "-8")
                {
                    if (globals.isbat == true)
                    {
                        var process = new Process();
                        process.StartInfo = new ProcessStartInfo(globals.batfile)
                        {
                            UseShellExecute = true
                        };
                        process.Start();
                        globals.rate = -8;
                        Speech.Speak(globals.batmsg);
                    }
                    else
                    {
                        globals.rate = -8;
                        Speech.Speak(globals.title + " , " + globals.msg);
                    }
                }
                if (textBox1.Text == "-9")
                {
                    if (globals.isbat == true)
                    {
                        var process = new Process();
                        process.StartInfo = new ProcessStartInfo(globals.batfile)
                        {
                            UseShellExecute = true
                        };
                        process.Start();
                        globals.rate = -9;
                        Speech.Speak(globals.batmsg);
                    }
                    else
                    {
                        globals.rate = -9;
                        Speech.Speak(globals.title + " , " + globals.msg);
                    }
                }
                if (textBox1.Text == "-10")
                {
                    if (globals.isbat == true)
                    {
                        var process = new Process();
                        process.StartInfo = new ProcessStartInfo(globals.batfile)
                        {
                            UseShellExecute = true
                        };
                        process.Start();
                        globals.rate = -10;
                        Speech.Speak(globals.batmsg);
                    }
                    else
                    {
                        globals.rate = -10;
                        Speech.Speak(globals.title + " , " + globals.msg);
                    }
                }
                if (textBox1.Text == "1")
                {
                    if (globals.isbat == true)
                    {
                        var process = new Process();
                        process.StartInfo = new ProcessStartInfo(globals.batfile)
                        {
                            UseShellExecute = true
                        };
                        process.Start();
                        globals.rate = 1;
                        Speech.Speak(globals.batmsg);
                    }
                    else
                    {
                        globals.rate = 1;
                        Speech.Speak(globals.title + " , " + globals.msg);
                    }
                }
                if (textBox1.Text == "2")
                {
                    if (globals.isbat == true)
                    {
                        var process = new Process();
                        process.StartInfo = new ProcessStartInfo(globals.batfile)
                        {
                            UseShellExecute = true
                        };
                        process.Start();
                        globals.rate = 2;
                        Speech.Speak(globals.batmsg);
                    }
                    else
                    {
                        globals.rate = 2;
                        Speech.Speak(globals.title + " , " + globals.msg);
                    }
                }
                if (textBox1.Text == "3")
                {
                    if (globals.isbat == true)
                    {
                        var process = new Process();
                        process.StartInfo = new ProcessStartInfo(globals.batfile)
                        {
                            UseShellExecute = true
                        };
                        process.Start();
                        globals.rate = 3;
                        Speech.Speak(globals.batmsg);
                    }
                    else
                    {
                        globals.rate = 3;
                        Speech.Speak(globals.title + " , " + globals.msg);
                    }
                }
                if (textBox1.Text == "4")
                {
                    if (globals.isbat == true)
                    {
                        var process = new Process();
                        process.StartInfo = new ProcessStartInfo(globals.batfile)
                        {
                            UseShellExecute = true
                        };
                        process.Start();
                        globals.rate = 4;
                        Speech.Speak(globals.batmsg);
                    }
                    else
                    {
                        globals.rate = 4;
                        Speech.Speak(globals.title + " , " + globals.msg);
                    }
                }
                if (textBox1.Text == "5")
                {
                    if (globals.isbat == true)
                    {
                        var process = new Process();
                        process.StartInfo = new ProcessStartInfo(globals.batfile)
                        {
                            UseShellExecute = true
                        };
                        process.Start();
                        globals.rate = 5;
                        Speech.Speak(globals.batmsg);
                    }
                    else
                    {
                        globals.rate = 5;
                        Speech.Speak(globals.title + " , " + globals.msg);
                    }
                }
                if (textBox1.Text == "6")
                {
                    if (globals.isbat == true)
                    {
                        var process = new Process();
                        process.StartInfo = new ProcessStartInfo(globals.batfile)
                        {
                            UseShellExecute = true
                        };
                        process.Start();
                        globals.rate = 6;
                        Speech.Speak(globals.batmsg);
                    }
                    else
                    {
                        globals.rate = 6;
                        Speech.Speak(globals.title + " , " + globals.msg);
                    }
                }
                if (textBox1.Text == "7")
                {
                    if (globals.isbat == true)
                    {
                        var process = new Process();
                        process.StartInfo = new ProcessStartInfo(globals.batfile)
                        {
                            UseShellExecute = true
                        };
                        process.Start();
                        globals.rate = 7;
                        Speech.Speak(globals.batmsg);
                    }
                    else
                    {
                        globals.rate = 7;
                        Speech.Speak(globals.title + " , " + globals.msg);
                    }
                }
                if (textBox1.Text == "8")
                {
                    if (globals.isbat == true)
                    {
                        var process = new Process();
                        process.StartInfo = new ProcessStartInfo(globals.batfile)
                        {
                            UseShellExecute = true
                        };
                        process.Start();
                        globals.rate = 8;
                        Speech.Speak(globals.batmsg);
                    }
                    else
                    {
                        globals.rate = 8;
                        Speech.Speak(globals.title + " , " + globals.msg);
                    }
                }
                if (textBox1.Text == "9")
                {
                    if (globals.isbat == true)
                    {
                        var process = new Process();
                        process.StartInfo = new ProcessStartInfo(globals.batfile)
                        {
                            UseShellExecute = true
                        };
                        process.Start();
                        globals.rate = 9;
                        Speech.Speak(globals.batmsg);
                    }
                    else
                    {
                        globals.rate = 9;
                        Speech.Speak(globals.title + " , " + globals.msg);
                    }
                }
                if (textBox1.Text == "10")
                {
                    if (globals.isbat == true)
                    {
                        var process = new Process();
                        process.StartInfo = new ProcessStartInfo(globals.batfile)
                        {
                            UseShellExecute = true
                        };
                        process.Start();
                        globals.rate = 10;
                        Speech.Speak(globals.batmsg);
                    }
                    else
                    {
                        globals.rate = 10;
                        Speech.Speak(globals.title + " , " + globals.msg);
                    }
                }
            }
            catch (Exception)
            {

            }
            if (globals.isnormalok == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.OK);
            }
            if (globals.isnormaloc == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.OKCancel);
            }
            if (globals.isnormalari == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.AbortRetryIgnore);
            }
            if (globals.isnormalync == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.YesNoCancel);
            }
            if (globals.isnormalrc == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.RetryCancel);
            }
            if (globals.isnormalyn == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.YesNo);
            }
            if (globals.iserrorok == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (globals.iserroroc == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            if (globals.iserrorari == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
            if (globals.iserrorync == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            }
            if (globals.iserroryn == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            if (globals.iserrorrc == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            if (globals.isinfook == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (globals.isinfooc == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            if (globals.isinfoari == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
            }
            if (globals.isinfoync == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            }
            if (globals.isinfoyn == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            if (globals.isinforc == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }
            if (globals.isquestionok == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            if (globals.isquestionoc == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            if (globals.isquestionari == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);
            }
            if (globals.isquestionync == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            }
            if (globals.isquestionyn == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (globals.isquestionrc == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
            }
            if (globals.iswarnok == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (globals.iswarnoc == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            if (globals.iswarnari == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            }
            if (globals.iswarnync == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            }
            if (globals.iswarnyn == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            if (globals.iswarnrc == true)
            {
                MessageBox.Show(globals.msg, globals.title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            if (globals.isicon == true)
            {
                StreamWriter File = new StreamWriter(globals.folder + "/message.vbs");
                File.Write("x = msgbox(" + "\"" + globals.msg + "\"" + ",4096," + "\"" + globals.title + "\"" + ")");
                File.Close();
                var process = new Process();
                process.StartInfo = new ProcessStartInfo(globals.vbsfile)
                {
                    UseShellExecute = true
                };
                process.Start();
            }
            if (globals.isinputbox == true)
            {
                StreamWriter File = new StreamWriter(globals.folder + "/inputbox.vbs");
                File.Write("x = InputBox(" + "\"" + globals.msg + "\"" + "," + "\"" + globals.title + "\"" + ")");
                File.Close();
                var process = new Process();
                process.StartInfo = new ProcessStartInfo(globals.inputfile)
                {
                    UseShellExecute = true
                };
                process.Start();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (submain == null)
            {
                submain = new submain();   //Create form if not created
                submain.FormClosed += submain_closed;  //Add eventhandler to cleanup after form closes
            }

            submain.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
            if (globals.isbat == true)
            {
                submain.Hide();
                if (bat == null)
                {
                    bat = new bat();   //Create form if not created
                    bat.FormClosed += bat_closed;  //Add eventhandler to cleanup after form closes
                }

                bat.Show(this);  //Show Form assigning this form as the forms owner
                Hide();
                globals.batmsg = "";
            }
            else
            {
                globals.isbat = false;
            }
        }

        private void bat_closed(object sender, FormClosedEventArgs e)
        {
            bat = null;
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random color = new Random();
            int R, G, B;
            R = color.Next(0, 255);
            G = color.Next(0, 255);
            B = color.Next(0, 255);
            globals.isdavid = true;
            globals.iszira = false;
            globals.isneutral = false;
            this.Size = new Size(618, 476);
            button1.BackColor = Color.FromArgb(R, G, B);
            button2.BackColor = Color.FromName("ControlLight");
            button8.BackColor = Color.FromName("ControlLight");
            button6.BackColor = Color.FromName("ControlLight");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random color = new Random();
            int R, G, B;
            R = color.Next(0, 255);
            G = color.Next(0, 255);
            B = color.Next(0, 255);
            globals.isneutral = false;
            globals.isdavid = false;
            globals.iszira = true;
            this.Size = new Size(618, 476);
            button1.BackColor = Color.FromName("ControlLight");
            button2.BackColor = Color.FromArgb(R, G, B);
            button8.BackColor = Color.FromName("ControlLight");
            button6.BackColor = Color.FromName("ControlLight");
        }

        void submain_closed(object sender, FormClosedEventArgs e)
        {
            submain = null;  //If form is closed make sure reference is set to null
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random color = new Random();
            int R, G, B;
            R = color.Next(0, 255);
            G = color.Next(0, 255);
            B = color.Next(0, 255);
            globals.isneutral = true;
            globals.isdavid = false;
            globals.iszira = false;
            this.Size = new Size(618, 476);
            button1.BackColor = Color.FromName("ControlLight");
            button2.BackColor = Color.FromName("ControlLight");
            button8.BackColor = Color.FromName("ControlLight");
            button6.BackColor = Color.FromArgb(R, G, B);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Random color = new Random();
            int R, G, B;
            R = color.Next(0, 255);
            G = color.Next(0, 255);
            B = color.Next(0, 255);
            this.Size = new Size(618, 476);
            button1.BackColor = Color.FromName("ControlLight");
            button2.BackColor = Color.FromName("ControlLight");
            button8.BackColor = Color.FromName("ControlLight");
            button6.BackColor = Color.FromName("ControlLight");
            for (int x = 0; x < 1; x++)
            {
                button7.Text = random.Next(1, 4).ToString();
                if (button7.Text == "1")
                {
                    globals.isdavid = true;
                    globals.iszira = false;
                    globals.isneutral = false;
                    button1.BackColor = Color.FromArgb(R, G, B);
                    button2.BackColor = Color.FromName("ControlLight");
                    button8.BackColor = Color.FromName("ControlLight");
                    button6.BackColor = Color.FromName("ControlLight");
                }
                if (button7.Text == "2")
                {
                    globals.isneutral = true;
                    globals.isdavid = false;
                    globals.iszira = false;
                    button1.BackColor = Color.FromName("ControlLight");
                    button2.BackColor = Color.FromName("ControlLight");
                    button8.BackColor = Color.FromName("ControlLight");
                    button6.BackColor = Color.FromArgb(R, G, B);
                }
                if (button7.Text == "3")
                {
                    globals.iszira = true;
                    globals.isdavid = false;
                    globals.isneutral = false;
                    button1.BackColor = Color.FromName("ControlLight");
                    button2.BackColor = Color.FromArgb(R, G, B);
                    button8.BackColor = Color.FromName("ControlLight");
                    button6.BackColor = Color.FromName("ControlLight");
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < 20; a++)
            {
                trackBar1.Value = random.Next(-10, 11);
                textBox1.Text = trackBar1.Value.ToString();
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
            globals.rate = int.Parse(textBox1.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 4;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBar1.Value = int.Parse(textBox1.Text);
                globals.rate = int.Parse(textBox1.Text);
            }
            catch
            {
                trackBar1.Value = 0;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ok = e.KeyChar;

            if (!char.IsDigit(ok) && ok != 8 && ok != 17 && ok != 46 && ok != 189 && ok != 35 && ok != 36 && ok != 162 && ok != 37 && ok != 160 && ok != 0 && ok != 163 && ok != 39 && ok != 161 && ok != 16 && ok != 109 && ok != 9)
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            globals.volume = trackBar2.Value;
            try
            {
                trackBar2.Value = int.Parse(textBox2.Text);
            }
            catch
            {
                trackBar2.Value = 100;
            }
        }

        private void voice_Load(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            globals.volume = trackBar2.Value;
            textBox2.Text = trackBar2.Value.ToString();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char numbers = e.KeyChar;

            if (!char.IsDigit(numbers) && numbers != '-' && numbers != 8 && numbers != 17 && numbers != 46 && numbers != 189 && numbers != 35 && numbers != 36 && numbers != 162 && numbers != 37 && numbers != 160 && numbers != 0 && numbers != 163 && numbers != 39 && numbers != 161 && numbers != 16 && numbers != 109 && numbers != 9)
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < 100; a++)
            {
                trackBar2.Value = random.Next(0, 101);
                textBox2.Text = trackBar2.Value.ToString();
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = ".wav File (*.wav) | *.wav";
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                globals.savepath = save.FileName;
                Speaker.Speak(globals.title + " , " + globals.msg);
            }
        }

        private void voice_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (globals.autosave == true)
                {
                    System.IO.File.Delete(globals.folder + "/Settings.msgmaker");
                    StreamWriter File = new StreamWriter(@globals.folder + "/Settings.msgmaker", true);
                    for (int i = 1; i < 2; i++)
                    {
                        File.Write("Autosave = True\r\n");
                        File.Write("voice");
                    }
                    File.Close();
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }
    }

    public static class Speech
    {
        public static void Speak(string text, bool wait = false)
        {
            if (globals.isdavid == true)
            {
                if (globals.rate == 0)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer
                $speak.Rate = 0
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.Speak(""{text}"")");
                }
                if (globals.rate == -1)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -1
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -2)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -2
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -3)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -3
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -4)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -4
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -5)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -5
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -6)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -6
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -7)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -7
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -8)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -8
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -9)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -9
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -10)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -10
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 1)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 1
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 2)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 2
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 3)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 3
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 4)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 4
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 5)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 5
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 6)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 6
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 7)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 7
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 8)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 8
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 9)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 9
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 10)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 10
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.Speak(""{text}"");");
                }
            }
            if (globals.iszira == true)
            {
                if (globals.rate == 0)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 0
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -1)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -1
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -2)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -2
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -3)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -3
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -4)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -4
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -5)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -5
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -6)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -6
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -7)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -7
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -8)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -8
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -9)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -9
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -10)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -10
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 1)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 1
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 2)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 2
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 3)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 3
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 4)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 4
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 5)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 5
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 6)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 6
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 7)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 7
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 8)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 8
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 9)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 9
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 10)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 10
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.Speak(""{text}"");");
                }
            }
            if (globals.isneutral == true)
            {
                if (globals.rate == 0)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 0
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -1)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -1
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -2)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -2
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -3)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -3
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -4)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -4
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -5)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -5
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -6)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -6
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -7)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -7
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -8)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -8
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -9)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -9
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == -10)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -10
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 1)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 1
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 2)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 2
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 3)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 3
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 4)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 4
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 5)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 5
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 6)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 6
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 7)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 7
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 8)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 8
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 9)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 9
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.Speak(""{text}"");");
                }
                if (globals.rate == 10)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 10
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.Speak(""{text}"");");
                }
            }

            void ExecuteCommand(string command)
            {
                string path = Path.GetDirectoryName(globals.folder) + "message" + ".ps1";

                // make sure to be using System.Text
                using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
                {
                    sw.Write(command);

                    ProcessStartInfo start = new ProcessStartInfo()
                    {
                        FileName = @"C:\Windows\System32\windowspowershell\v1.0\powershell.exe",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        Arguments = $"-executionpolicy bypass -File {path}",
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    Process process = Process.Start(start);

                    if (wait)
                        process.WaitForExit();
                }
            }
        }
    }

    public static class Speaker
    {
        public static void Speak(string text, bool wait = false)
        {
            if (globals.isdavid == true)
            {
                if (globals.rate == 0)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer
                $speak.Rate = 0
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -1)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -1
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -2)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -2
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -3)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -3
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -4)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -4
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -5)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -5
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -6)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -6
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -7)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -7
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -8)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -8
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -9)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -9
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -10)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -10
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 1)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 1
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 2)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 2
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 3)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 3
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 4)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 4
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 5)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 5
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 6)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 6
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 7)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 7
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 8)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 8
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 9)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 9
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 10)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 10
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft David Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
            }
            if (globals.iszira == true)
            {
                if (globals.rate == 0)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 0
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -1)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -1
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -2)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -2
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -3)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -3
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -4)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -4
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -5)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -5
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -6)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -6
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -7)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -7
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -8)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -8
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -9)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -9
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -10)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -10
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 1)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 1
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 2)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 2
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 3)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 3
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 4)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 4
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 5)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 5
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 6)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 6
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 7)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 7
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 8)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 8
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 9)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 9
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 10)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 10
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Zira Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
            }
            if (globals.isneutral == true)
            {
                if (globals.rate == 0)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 0
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -1)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -1
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -2)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -2
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -3)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -3
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -4)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -4
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -5)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -5
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -6)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -6
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -7)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -7
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -8)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -8
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -9)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -9
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == -10)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = -10
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 1)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 1
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 2)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 2
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 3)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 3
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 4)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 4
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 5)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 5
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 6)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 6
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 7)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 7
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 8)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 8
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 9)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 9
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
                if (globals.rate == 10)
                {
                    ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer;
                $speak.Rate = 10
                $speak.Volume = {globals.volume}
                $speak.SelectVoice('Microsoft Hazel Desktop')
                $speak.SetOutputToWaveFile(""{globals.savepath}"")
                $speak.Speak(""{text}"")
                $speak.Dispose()");
                }
            }

            void ExecuteCommand(string command)
            {
                string path = Path.GetDirectoryName(globals.folder) + "message" + ".ps1";

                // make sure to be using System.Text
                using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
                {
                    sw.Write(command);

                    ProcessStartInfo start = new ProcessStartInfo()
                    {
                        FileName = @"C:\Windows\System32\windowspowershell\v1.0\powershell.exe",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        Arguments = $"-executionpolicy bypass -File {path}",
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    Process process = Process.Start(start);

                    if (wait)
                        process.WaitForExit();
                }
            }
        }
    }
}
