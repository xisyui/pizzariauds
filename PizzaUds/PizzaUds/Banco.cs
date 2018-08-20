﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PizzaUds
{
    class Banco
    {
        //private String strcon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\T-Gamer\Documents\pizza.mdf;Integrated Security=True;Connect Timeout=30";
        private String strcon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\pizza.mdf;Integrated Security=True;Connect Timeout=30";
        private SqlConnection con = null;
        private SqlTransaction trans = null;

        public bool Conecta()
        {
            bool resultado = false;
            try
            {
                con = new SqlConnection(strcon);
                con.Open();
                resultado = true;
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("Erro conexão" + e.Message);
            }
            return resultado;
        }

        public void Desconecta()
        {
            if ((con != null) && (con.State == System.Data.ConnectionState.Open))
            {
                con.Close();
                con = null;
            }
        }

        public void BeginTransaction()
        {
            if ((con != null) && (con.State == System.Data.ConnectionState.Open))
                trans = con.BeginTransaction();
        }

        public void CommitTransaction()
        {
            if ((con != null) && (trans != null) && (con.State == System.Data.ConnectionState.Open))
            {
                trans.Commit();
                trans = null;
            }
        }

        public void RollbackTransaction()
        {
            if ((con != null) && (trans != null) && (con.State == System.Data.ConnectionState.Open))
            {
                trans.Rollback();
                trans = null;
            }
        }

        public bool ExecuteQuery(String sql, out DataTable dt, params Object[] parametros)
        {
            dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Transaction = trans;
                for (int i = 0; i < parametros.Length; i += 2)
                    cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("Erro execute query" + e.Message);
                return false;
            }
        }

        public bool executeQuery_all(String sql, out DataTable dt)
        {
            dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool ExecuteNonQuery(String sql, params Object[] parametros)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Transaction = trans;
                for (int i = 0; i < parametros.Length; i += 2)
                    cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("Erro execute nonquery" + e.Message);
                return false;
            }
        }

        public int GetIdentity()
        {
            SqlCommand cmd = new SqlCommand("SELECT @@IDENTITY", con);
            object o = cmd.ExecuteScalar();
            if (o != null)
                return Convert.ToInt32(o);
            else
                return 0;
        }
        public int executeScalar(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            object o = cmd.ExecuteScalar();
            if (o != DBNull.Value)
                return (Convert.ToInt32(o) + 1);
            else
                return 1;
        }
        public string getConexao()
        {
            return strcon;
        }
    }
}
