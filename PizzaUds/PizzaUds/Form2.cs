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
    public partial class Form2 : Form
    {
        public DataRow linha = null;
        public Form2()
        {
            PizzaController pp = new PizzaController();
            InitializeComponent();
            dvg.DataSource = pp.retornaTodos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir este registro permanentemente?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PizzaController pp = new PizzaController();
                DataRowView currentDataRowView = (DataRowView)dvg.CurrentRow.DataBoundItem;
                linha = currentDataRowView.Row;

                int codi = Convert.ToInt32(linha["piz_codigo"].ToString());

                if (pp.remove(codi))
                {
                    if (dvg.CurrentRow != null)
                    {
                        dvg.Rows.RemoveAt(dvg.CurrentRow.Index);
                    }
                }
            }
        }
    }
}
