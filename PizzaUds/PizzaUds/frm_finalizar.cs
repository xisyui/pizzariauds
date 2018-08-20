using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PizzaUds
{
    public partial class frm_finalizar : Form
    {
        Pizza pizza = null;
        public frm_finalizar(Pizza pizza)
        {
            InitializeComponent();
            tb_tamanho.Text = pizza.getTamanho();
            tb_sabor.Text = pizza.getSabor();
            tb_personalizacao.Text = pizza.getPersonalizacao();
            validapreco va = new validapreco(tb_valor, 6);
            tb_valor.Text = pizza.getValor().ToString();
            mb_tempo.Text = pizza.getTempo().ToString();
            this.pizza = pizza;
        }

        private void frm_finalizar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PizzaController pp = new PizzaController();
            if (pizza != null)
            {
                if (pp.insere(pizza))
                {
                    Close();
                }
                else { MessageBox.Show("Falha"); }
            }
        }
    }
}
