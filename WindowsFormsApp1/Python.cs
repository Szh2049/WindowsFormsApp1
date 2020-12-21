﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Python : Form
    {
        public Python()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //清空Richtextbox
            foreach (var item in this.Controls)
            {
                if (item is RichTextBox)
                {
                    RichTextBox tb = item as RichTextBox;
                    tb.Text = "";
                }
            }
        }
        public string path = null;
        private void button1_Click(object sender, EventArgs e)
        {
            string content = "\n" + this.python_code.Text;
            File.AppendAllText(path, content, Encoding.Default);
            this.Dispose();
        }
    }
}
