using System;
using System.Windows.Forms;

namespace naraian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string NewxPer(string w)
        {
            int l = w.Length;
            string r = "";

            char[] s = w.ToCharArray();

            byte[] b = new byte[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                b[i] = Convert.ToByte(s[i]);
            }

            for (int i = l - 1; i > 0; i--)
            {
                if (b[i - 1] < b[i])
                {
                    int pivot = i;

                    for (int j = pivot; j < l; j++)
                    {
                        if (b[j] <= b[pivot] && b[i - 1] < b[j])
                        {
                            pivot = j;

                        }
                    }
                    byte tr = b[i - 1];
                    b[i - 1] = b[pivot];
                    b[pivot] = tr;


                    for (int j = l - 1; i < j;)
                    {
                        byte tr2 = b[i];
                        b[i] = b[j];
                        b[j] = tr2;

                        i++;
                        j--;
                    }

                    for (int k = 0; k < s.Length; k++)
                    {
                        s[k] = Convert.ToChar(b[k]);
                    }

                    for (int k = 0; k < s.Length; k++)
                    {
                        r += s[k];
                    }
                    break;

                }

            }
            return r;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = NewxPer(textBox1.Text);
        }
    }
}
