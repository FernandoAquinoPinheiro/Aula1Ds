﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExibir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                MessageBox.Show("Olá " + textBoxNome.Text + ", seja bem-vindo!");
            }
            else
            {
                MessageBox.Show("Por favor, insira seu nome.");
            }

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            textBoxNome.Clear();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
