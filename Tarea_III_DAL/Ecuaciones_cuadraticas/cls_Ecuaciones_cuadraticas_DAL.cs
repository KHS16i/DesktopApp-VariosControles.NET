using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_III_DAL.Ecuaciones_cuadraticas
{
    public class cls_Ecuaciones_Cuadraticas_DAL
    {
        #region VARIABLES PRIVADAS
        
        private double _dVariable_A, _dVariable_B, _dVariable_C, _dDiscriminante, _dSolucion_I, _dSolucion_II;

        #endregion

        #region CONSTRUCTORES

        public double dVariable_A { get => _dVariable_A; set => _dVariable_A = value; }
        public double dVariable_B { get => _dVariable_B; set => _dVariable_B = value; }
        public double dVariable_C { get => _dVariable_C; set => _dVariable_C = value; }
        public double dDiscriminante { get => _dDiscriminante; set => _dDiscriminante = value; }
        public double dSolucion_I { get => _dSolucion_I; set => _dSolucion_I = value; }
        public double dSolucion_II { get => _dSolucion_II; set => _dSolucion_II = value; }

        #endregion
    }
}
