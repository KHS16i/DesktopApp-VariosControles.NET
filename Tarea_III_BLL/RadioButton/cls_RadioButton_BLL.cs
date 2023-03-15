using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_III_DAL.RadioButton;

namespace Tarea_III_BLL.RadioButton
{
    public class cls_RadioButton_BLL
    {
        public void Sumatoria(ref cls_RadioButton_DAL Obj_RadBut_DAL) {

            int i = 1;

            while (i <= Obj_RadBut_DAL.iNum_limite) {
                Obj_RadBut_DAL.iRes_suma = Obj_RadBut_DAL.iRes_suma + i;
                i++;
            }
        }

        public void Sumatoria_Pares(ref cls_RadioButton_DAL Obj_RadBut_DAL) {

            int[] pares = new int[Obj_RadBut_DAL.iNum_limite];

            int cont = 0;

            for (int i = 0; i < Obj_RadBut_DAL.iNum_limite; i++) {
                if (i % 2 == 0)
                {
                    pares[cont] = i;
                    cont++;
                }
            }


            if (Obj_RadBut_DAL.iNum_limite % 2 == 0) {
                pares[Obj_RadBut_DAL.iNum_limite -1] = Obj_RadBut_DAL.iNum_limite;
            }

            for (int ii = 0; ii < Obj_RadBut_DAL.iNum_limite; ii++) {
                Obj_RadBut_DAL.iPares = Obj_RadBut_DAL.iPares + pares[ii];
            }
        }

        public void Sumatoria_Impares(ref cls_RadioButton_DAL Obj_RadBut_DAL)
        {

            int[] impares = new int[Obj_RadBut_DAL.iNum_limite];

            int cont = 0;

            for (int i = 0; i < Obj_RadBut_DAL.iNum_limite; i++)
            {
                if (!(i % 2 == 0))
                {
                    impares[cont] = i;
                    cont++;
                }
            }


            if (!(Obj_RadBut_DAL.iNum_limite % 2 == 0))
            {
                impares[Obj_RadBut_DAL.iNum_limite -1] = Obj_RadBut_DAL.iNum_limite;
            }


            for (int ii = 0; ii < Obj_RadBut_DAL.iNum_limite; ii++)
            {
                Obj_RadBut_DAL.iImpares = Obj_RadBut_DAL.iImpares + impares[ii];
            }
        }
    }
}
