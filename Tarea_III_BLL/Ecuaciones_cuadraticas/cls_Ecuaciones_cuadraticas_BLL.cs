using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_III_DAL.Ecuaciones_cuadraticas;

namespace Tarea_III_BLL.Ecuaciones_cuadraticas
{
    public class cls_Ecuaciones_cuadraticas_BLL
    {
        public void ecuacion_cuadratica(ref cls_Ecuaciones_Cuadraticas_DAL Obj_Ecu_cua) {
            Obj_Ecu_cua.dDiscriminante = (Math.Pow(Obj_Ecu_cua.dVariable_B,2)) - (4 * Obj_Ecu_cua.dVariable_A * Obj_Ecu_cua.dVariable_C);
            if (Obj_Ecu_cua.dDiscriminante == 0) {
                Obj_Ecu_cua.dSolucion_I = (-Obj_Ecu_cua.dVariable_B) / (2 * Obj_Ecu_cua.dVariable_A);
            }if (Obj_Ecu_cua.dDiscriminante < 0)
            {
                Obj_Ecu_cua.dSolucion_I = 0;
            }
            else {
                Obj_Ecu_cua.dSolucion_I = (-Obj_Ecu_cua.dVariable_B + (Math.Sqrt((Math.Pow(Obj_Ecu_cua.dVariable_B, 2)) - (4 * Obj_Ecu_cua.dVariable_A * Obj_Ecu_cua.dVariable_C)))) / (2 * Obj_Ecu_cua.dVariable_A);
                Obj_Ecu_cua.dSolucion_II = (-Obj_Ecu_cua.dVariable_B - (Math.Sqrt((Math.Pow(Obj_Ecu_cua.dVariable_B, 2)) - (4 * Obj_Ecu_cua.dVariable_A * Obj_Ecu_cua.dVariable_C)))) / (2 * Obj_Ecu_cua.dVariable_A);
            }
        }
    }
}
