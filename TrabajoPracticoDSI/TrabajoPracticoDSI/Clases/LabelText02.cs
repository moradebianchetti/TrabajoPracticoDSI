using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase11.Clases
{
    public partial class LabelText02 : UserControl
    {
        public enum TipoDato { texto, numero, fecha }

        public string Pp_Etiqueta
        {
            get { return lblEtiqueta.Text; }
            set { lblEtiqueta.Text = value; }
        }
        public bool Pp_validable { get; set; }
        public string Pp_nombre_campo { get; set; }
        public string Pp_nombre_tabla { get; set; }
        public string Pp_mensajeError { get; set; }
        //-----------------------------
        public int Pp_ancho { get; set; } = 10;
        public int Pp_decimales { get; set; } = 2;

        public TipoDato Pp_tipoDato
        {
            get { return TipoD; }
            set
            {
                TipoD = value;
                string mascara = "";
                switch (TipoD)
                {
                    case TipoDato.texto:
                        TxtDato.Mask = mascara.PadLeft(Pp_ancho, 'C');
                        TxtDato.TextAlign = HorizontalAlignment.Left;
                        break;
                    case TipoDato.numero:
                        //TxtDato.RightToLeft = RightToLeft.Yes;
                        //TxtDato.TextAlign = HorizontalAlignment.Left;
                        // 9999999.99
                        
                        if (Pp_decimales >= 1)
                        {
                            mascara = mascara.PadLeft(Pp_ancho - Pp_decimales - 1, '9') + ".";
                            mascara = mascara.PadRight(Pp_ancho, '9');
                        }
                        else
                            mascara = mascara.PadLeft(Pp_ancho, '9');
                        TxtDato.Mask = mascara;
                        TxtDato.TextAlign = HorizontalAlignment.Right;
                        break;
                    case TipoDato.fecha:
                        TxtDato.Mask = "00/00/0000";
                        TxtDato.TextAlign = HorizontalAlignment.Left;
                        break;
                    default:
                        break;
                }
            }
        }
 
        public string Pp_Text
        {
            get =>  TxtDato.Text;
            set
            {
                if (TipoD == TipoDato.numero)
                {
                    if (Pp_decimales==0)
                        TxtDato.Text = string.Format("{0:" + TxtDato.Mask.Replace('9', '0') + "}", int.Parse(value));
                    else
                        TxtDato.Text = string.Format("{0:" + TxtDato.Mask.Replace('9', '0') + "}", double.Parse(value));
                    // String.Format("{0:000000.00}", double.Parse("10,25")) => 000010.25
                    // error 102500.00
                }
            }

        }

        public bool Pp_MaskFull => TxtDato.MaskFull;
        public bool Pp_ReadOnly
        {
            get => TxtDato.ReadOnly;
            set => TxtDato.ReadOnly = value;
        }

        TipoDato TipoD = TipoDato.texto;
        
        public LabelText02()
        {
            InitializeComponent();
        }

        private void TxtDato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar("."))
            {
                if (this.Pp_tipoDato == TipoDato.numero)
                {
                    TxtDato.Text = TxtDato.Text.Trim();
                    int blanco = TxtDato.Text.IndexOf(' ') ;
                    int entero = Pp_ancho - Pp_decimales -1 ;
                    
                        if (blanco <= entero && blanco!=-1)
                    {
                        for (int i = 0; i < entero - blanco; i++)
                        {
                            TxtDato.Text = " " + TxtDato.Text;
                        }
                    }
                    TxtDato.SelectionStart = TxtDato.Text.Length;
                }
            }
        }
    }
}
