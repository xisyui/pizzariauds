using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PizzaUds
{
    class validapreco
    {
        private String texto;
        private char tecla;

        public validapreco(TextBox ttb, int tam_maximo)
        {
            texto_inicial();

            ttb.MaxLength = tam_maximo;
            ttb.TextAlign = HorizontalAlignment.Right;
            ttb.Text = "";

            ttb.KeyDown += new KeyEventHandler(validapreco_KeyDown);
            ttb.KeyPress += new KeyPressEventHandler(validapreco_KeyPress);
        }

        public void texto_inicial()
        {
            texto = "";
        }

        #region Keypress e KeyDown
        protected void validapreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        protected void validapreco_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;

            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
                || e.KeyCode == Keys.Back || e.KeyCode == Keys.Oemcomma)
            {
                if (((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Oemcomma)) && (texto.Length > 0))
                {
                    texto = texto.Substring(0, texto.Length - 1);
                }
                else if (!((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Oemcomma)) && texto.Length < ((TextBox)(sender)).MaxLength)
                {
                    if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
                        tecla = '0';
                    else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
                        tecla = '1';
                    else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
                        tecla = '2';
                    else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
                        tecla = '3';
                    else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
                        tecla = '4';
                    else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
                        tecla = '5';
                    else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
                        tecla = '6';
                    else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
                        tecla = '7';
                    else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
                        tecla = '8';
                    else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
                        tecla = '9';

                    texto = texto + tecla.ToString();
                }
                if (texto.Length == 0)
                {
                    ((TextBox)(sender)).Text = "";
                }
                if (texto.Length == 1)
                {
                    ((TextBox)(sender)).Text = "0,0" + texto;
                }
                else if (texto.Length == 2)
                {
                    ((TextBox)(sender)).Text = "0," + texto;
                }
                else if (texto.Length > 2 && texto.Length <= ((TextBox)(sender)).MaxLength)
                {
                    if (texto.Length > 5)
                    {
                        int aux = 1;
                        for (int aux2 = 6; aux2 < texto.Length; aux2++)
                        {
                            aux++;
                        }
                        int aux3 = 1;
                        for (int aux2 = 9; aux2 < texto.Length; aux2++)
                        {
                            aux3++;
                        }
                        int aux4 = 1;
                        for (int aux2 = 12; aux2 < texto.Length; aux2++)
                        {
                            aux4++;
                        }
                        int aux5 = 1;
                        for (int aux2 = 15; aux2 < texto.Length; aux2++)
                        {
                            aux5++;
                        }
                        if (texto.Length <= 8)
                            ((TextBox)(sender)).Text = texto.Substring(0, texto.Length - 5) + "." + texto.Substring(aux, texto.Length - (2 + aux)) + "," + texto.Substring(texto.Length - 2);
                        if (texto.Length > 8 && texto.Length <= 11)
                        {
                            ((TextBox)(sender)).Text = texto.Substring(0, texto.Length - 8) + "." +
                                texto.Substring(aux3, texto.Length - (2 + aux)) + "." +
                                texto.Substring(aux, texto.Length - (2 + aux))
                                + "," + texto.Substring(texto.Length - 2);
                        }
                        if (texto.Length > 11 && texto.Length <= 14)
                        {
                            ((TextBox)(sender)).Text = texto.Substring(0, texto.Length - 11) + "." +
                                texto.Substring(aux4, texto.Length - (2 + aux)) + "." +
                                texto.Substring(aux3, texto.Length - (2 + aux)) + "." +
                                texto.Substring(aux, texto.Length - (2 + aux))
                                + "," + texto.Substring(texto.Length - 2);
                        }
                        if (texto.Length > 14 && texto.Length <= 17)
                        {
                            ((TextBox)(sender)).Text = texto.Substring(0, texto.Length - 14) + "." +
                                texto.Substring(aux5, texto.Length - (2 + aux)) + "." +
                                texto.Substring(aux4, texto.Length - (2 + aux)) + "." +
                                texto.Substring(aux3, texto.Length - (2 + aux)) + "." +
                                texto.Substring(aux, texto.Length - (2 + aux))
                                + "," + texto.Substring(texto.Length - 2);
                        }
                    }
                    else
                        ((TextBox)(sender)).Text = texto.Substring(0, texto.Length - 2) + "," + texto.Substring(texto.Length - 2);
                }
                ((TextBox)(sender)).SelectionStart = ((TextBox)(sender)).Text.Length + 1;
            }
        }
        #endregion
    }
}
