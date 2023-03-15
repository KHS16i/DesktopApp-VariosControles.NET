using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_III_DAL.Arreglo
{
    public class cls_Arreglo_DAL
    {

        #region VARIABLES PRIVADAS

        private byte _bTamano_arreglo, _bOpc;
        private int _iLimite_random, _inumTemp;
        private string _sResultado;

        private int[] _arrNumeros;

        private Random _rdmGenerador;

        #endregion

        #region CONSTRUCTORES

        public byte bTamano_arreglo { get => _bTamano_arreglo; set => _bTamano_arreglo = value; }
        public byte bOpc { get => _bOpc; set => _bOpc = value; }
        public int iLimite_random { get => _iLimite_random; set => _iLimite_random = value; }
        public string sResultado { get => _sResultado; set => _sResultado = value; }
        public int[] arrNumeros { get => _arrNumeros; set => _arrNumeros = value; }
        public int inumTemp { get => _inumTemp; set => _inumTemp = value; }
        public Random rdmGenerador { get => _rdmGenerador; set => _rdmGenerador = value; }

        #endregion
    }
}
