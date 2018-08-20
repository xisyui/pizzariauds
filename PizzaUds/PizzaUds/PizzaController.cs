using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PizzaUds
{
    class PizzaController
    {
        public Boolean insere(Pizza pizza)
        {
            Banco banco = new Banco();

            try
            {
                if (banco.Conecta())
                {
                    String sql = @"INSERT INTO pizza (piz_tamanho, piz_sabor, piz_tempo, piz_personalizacao, piz_valor) 
                                  VALUES (@tamanho, @sabor, @tempo, @personalizacao, @valor)";
                   if (banco.ExecuteNonQuery(sql, "@tamanho", pizza.getTamanho(),
                        "@sabor", pizza.getSabor(), "@tempo", pizza.getTempo(),
                        "@personalizacao", pizza.getPersonalizacao(), "@valor", pizza.getValor()))
                    {
                        banco.Desconecta();
                        return true;
                    }

                }

            }
            catch
            {
                banco.Desconecta();
            }


            return false;
        }
        public DataTable retornaTodos()
        {
            String sql = @"select * from pizza";

            Banco b = new Banco();

            try
            {
                if (b.Conecta())
                {
                    DataTable dt;
                    b.ExecuteQuery(sql, out dt);
                    return dt;
                }
            }
            catch { b.Desconecta(); }
            return null;
        }
        public Boolean remove(int codigo)
        {
            Banco banco = new Banco();
            try
            {
                if (banco.Conecta())
                {
                    String sql = @"DELETE FROM pizza  
                                 WHERE piz_codigo = @cod";

                    if (banco.ExecuteNonQuery(sql, "@cod", codigo))
                    {
                        banco.Desconecta();
                        return true;
                    }

                }

            }
            catch
            {
                banco.Desconecta();
            }


            return false;
        }
    }
}
