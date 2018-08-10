using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace API
{
    class cValidarCampo
    {
        public bool ValidarRut(string rut)
        {
            //Leave
            bool validacion = false;
            rut = rut.ToUpper();
            rut = rut.Replace(".", "");
            rut = rut.Replace("-", "");
            if (rut.Length <= 1 | rut.Length > 10) { return validacion; }
            int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));
            char dv = char.Parse(rut.Substring(rut.Length - 1, 1));
            int m = 0, s = 1;

            for (; rutAux != 0; rutAux /= 10)
            {
                s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
            }

            if (dv == (char)(s != 0 ? s + 47 : 75))
            {
                validacion = true;
            }
            return validacion;
        }

        //KeyPress
        public void ValidarNumeros(KeyPressEventArgs pKey, Control pTexto, int pMaxLength, int pDecimales)
        {
            if (pKey.KeyChar == 8) //Permite la tecla de Retroceso
            {
                pKey.Handled = false;
                return;
            }

            if (pKey.KeyChar == 46)
            {
                pKey.KeyChar = ',';
            }

            if (pTexto.Text.Length == pMaxLength - 1 & (pKey.KeyChar == 44 | pKey.KeyChar == 46))
            {
                pKey.Handled = true;
                return;
            }

            if (pTexto.Text.Length == 0 & (pKey.KeyChar == 44 | pKey.KeyChar == 46))
            {
                pKey.Handled = true;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;
            //Permite el ingreso de coma
            for (int i = 0; i < pTexto.Text.Length; i++)
            {
                if (pTexto.Text[i] == ',' | pTexto.Text[i] == '.')
                {
                    IsDec = true; //Permite agregar la coma solo una vez
                }

                if (IsDec && nroDec++ >= pDecimales && pDecimales != -1) //Permite decimales
                {
                    pKey.Handled = true;
                    return;
                }
            }
            //Permite solo numeros
            if (pKey.KeyChar >= 48 && pKey.KeyChar <= 57)
            {
                pKey.Handled = false;
            }
            else if (pKey.KeyChar == 44 | pKey.KeyChar == 46) //Permite la coma si es que no existe     
            {
                pKey.Handled = (IsDec) ? true : false;
            }
            else
            {
                pKey.Handled = true;
            }
        }
        public string FormatearTextoNumero(string pNumero)
        {
            //Leave
            string decimales = "";
            char[] charsToTrim = { ',', '.', ' ' };
            pNumero = pNumero.TrimEnd(charsToTrim);
            if (pNumero.Contains(','))
            {
                decimales = pNumero.Substring(pNumero.IndexOf(','), pNumero.Length - pNumero.IndexOf(','));
                pNumero = pNumero.Substring(0, pNumero.IndexOf(','));
            }

            string auxNumeroFormateado = "";
            int auxIndice = pNumero.Trim().Length - 1;
            int auxCuentaPosiciones = 0;
            while (auxIndice >= 0)
            {
                auxNumeroFormateado = pNumero.Substring(auxIndice, 1) + auxNumeroFormateado;
                auxCuentaPosiciones++;
                if (auxCuentaPosiciones == 3 & auxIndice > 0)
                {
                    auxNumeroFormateado = "." + auxNumeroFormateado;
                    auxCuentaPosiciones = 0;
                }
                auxIndice--;
            }

            return auxNumeroFormateado + decimales;
        }

        public bool ValidarCorreo(string email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion) | email == "")
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        //Probar
        private string ChequearNumero(string pValor)
        {
            if (pValor.IndexOf(",") == -1 && pValor.IndexOf(".") == -1)
            { pValor = pValor.Trim() + System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator; }
            if (System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator == ",") { pValor = pValor.Replace(".", ","); }
            if (System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator == ".") { pValor = pValor.Replace(",", "."); }
            string Valor = pValor.Trim().Replace("_", "");
            string auxTalla = "00" + Valor + "00";
            string auxSimboloDecimal = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            string auxResultado = auxTalla.Substring(auxTalla.IndexOf(auxSimboloDecimal) - 2, 5);
            return auxResultado;
        }
    }
}
