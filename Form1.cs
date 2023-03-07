using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void GenerateFibonacciSequence(int nthTerm)
        {
            var stringBuilder = new StringBuilder();
            long firstTerm = 0, secondTerm = 1, nextTerm;
            for (int i = 0; i < nthTerm; i++)
            {
                stringBuilder.Append(firstTerm + "\n");
                nextTerm = firstTerm + secondTerm;
                firstTerm = secondTerm;
                secondTerm = nextTerm;
            }
            listBox1.BeginUpdate();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(stringBuilder.ToString().Split('\n'));
            listBox1.EndUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int nthTerm))
            {
                GenerateFibonacciSequence(nthTerm);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            listBox1.Items.Clear();
            listBox1.EndUpdate();
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
