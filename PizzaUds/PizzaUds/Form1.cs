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
    public partial class frm_main : Form
    {
        Pizza pizza =null;
        public frm_main()
        {
            InitializeComponent();
            pizza = new Pizza(); 
            pizza.setPersonalizacao("");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rb_pequena.Checked == true)
            {
                pizza.setTamanho("Pequeno");
                pizza.setTempo(15);
                pizza.setValor(20);
            }
            if (rb_media.Checked == true)
            {
                pizza.setTamanho("Média");
                pizza.setTempo(20);
                pizza.setValor(30);
            }
            if (rb_grande.Checked == true)
            {
                pizza.setTamanho("Grande");
                pizza.setTempo(25);
                pizza.setValor(40);
            }
            if (rb_calabresa.Checked == true)
            {
                pizza.setSabor("Calabresa");
            }
            if (rb_marguerita.Checked == true)
            {
                pizza.setSabor("Marguerita");
            }
            if (rb_portuguesa.Checked == true)
            {
                pizza.setSabor("Portuguesa");
                pizza.setTempo(pizza.getTempo()+5);
            }
            pizza.setPersonalizacao("");
            if (cb_bacon.Checked == true)
            {
                pizza.setPersonalizacao("Extra Bacon ");
                pizza.setValor(pizza.getValor() + 3);
            }
            if (cb_semcebola.Checked == true)
            {
                pizza.setPersonalizacao(pizza.getPersonalizacao()+"Sem Cebola ");
            }
            if (cb_borda.Checked == true)
            {
                pizza.setPersonalizacao(pizza.getPersonalizacao() + "Borda Recheada");
                pizza.setValor(pizza.getValor() + 5);
                pizza.setTempo(pizza.getTempo() + 5);
            }
            frm_finalizar t = new frm_finalizar(pizza);
            t.ShowDialog();
            t.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
