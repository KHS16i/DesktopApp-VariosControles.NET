using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_III_DAL.RadioButton
{
    public class cls_RadioButton_DAL
    {
        #region VARIABLES PRIVADAS

        private int _iNum_limite, _iRes_suma, _iPares, _iImpares;

        #endregion

        #region CONSTRUCTORES

        public int iNum_limite { get => _iNum_limite; set => _iNum_limite = value; }
        public int iRes_suma { get => _iRes_suma; set => _iRes_suma = value; }
        public int iPares { get => _iPares; set => _iPares = value; }
        public int iImpares { get => _iImpares; set => _iImpares = value; }

        #endregion
    }
}
