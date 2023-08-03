using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexaoBancoNovo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        cadastrar cad;
        consultar con;
        atualizar atu;
        excluir exc;

        public Empresa ()
        {
            InitializeComponent();
            cad = new cadastrar();
            con = new consultar();
            atu= new atualizar();
            exc = new excluir();
        }// fim do construtor 
        private void button3_Click(object sender, EventArgs e)
        {
            cad.ShowDialog();
        }// cadastrar 

        private void button2_Click(object sender, EventArgs e)
        {
            con.ShowDialog();
        }// consultar 

        private void button5_Click(object sender, EventArgs e)
        {
            atu.ShowDialog();
        }// atualizar 

        private void button4_Click(object sender, EventArgs e)
        {
          exc.ShowDialog();
        }// exluir 
    }// fim da classe 
}// fim do projeto 
