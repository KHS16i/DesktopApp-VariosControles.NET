using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_III_DAL.Arreglo;

namespace Tarea_III_BLL.Arreglo
{
    public class cls_Arreglo_BLL
    {
        public void llenarArreglo(ref cls_Arreglo_DAL Obj_arreglo_DALL) {

            Obj_arreglo_DALL.arrNumeros = new int[Obj_arreglo_DALL.bTamano_arreglo];

            for (int i = 0; i < Obj_arreglo_DALL.bTamano_arreglo; i++)
            {
                Obj_arreglo_DALL.rdmGenerador = new Random();
                Obj_arreglo_DALL.inumTemp = Obj_arreglo_DALL.rdmGenerador.Next(0, Obj_arreglo_DALL.iLimite_random);

                if (Obj_arreglo_DALL.arrNumeros.Contains(Obj_arreglo_DALL.inumTemp))
                {
                    i--;
                }
                else {
                    Obj_arreglo_DALL.arrNumeros[i] = Obj_arreglo_DALL.inumTemp;
                }
            }

        }

        public void mostrarArreglo(ref cls_Arreglo_DAL ObjDALL) {

            ObjDALL.sResultado = string.Empty;
;
            for (int i = 0; i < ObjDALL.arrNumeros.Length; i++)
            {
                switch (ObjDALL.bOpc)
                {
                    case 1://elimina solo pares
                        {
                            if (ObjDALL.arrNumeros[i] % 2 != 0)
                            {
                                ObjDALL.sResultado += ObjDALL.arrNumeros[i].ToString() + "    ";
                            }
                            break;
                        }
                    case 2://elimina menores a 10
                        {
                            if (ObjDALL.arrNumeros[i] > 10)
                            {
                                ObjDALL.sResultado += ObjDALL.arrNumeros[i].ToString() + "    ";
                            }
                            break;
                        }
                    case 3:// elimina mayores a 50
                        {
                            if (ObjDALL.arrNumeros[i] < 50)
                            {
                                ObjDALL.sResultado += ObjDALL.arrNumeros[i].ToString() + "    ";
                            }
                            break;
                        }
                    case 4:// elimina pares y  menores a 10
                        {
                            if ((ObjDALL.arrNumeros[i] % 2 != 0) && (ObjDALL.arrNumeros[i] > 10))
                            {
                                ObjDALL.sResultado += ObjDALL.arrNumeros[i].ToString() + "    ";
                            }
                            break;
                        }
                    case 5:// elimina pares y  mayores a 50
                        {
                            if ((ObjDALL.arrNumeros[i] % 2 != 0) && (ObjDALL.arrNumeros[i] < 50))
                            {
                                ObjDALL.sResultado += ObjDALL.arrNumeros[i].ToString() + "    ";
                            }
                            break;
                        }
                    case 6:// elimina menores a 10 y  mayores a 50
                        {
                            if ((ObjDALL.arrNumeros[i] > 10) && (ObjDALL.arrNumeros[i] < 50))
                            {
                                ObjDALL.sResultado += ObjDALL.arrNumeros[i].ToString() + "    ";
                            }
                            break;
                        }
                    case 7:// elimina pares y menores a 10 y  mayores a 50
                        {
                            if ((ObjDALL.arrNumeros[i] % 2 != 0) && (ObjDALL.arrNumeros[i] > 10) && (ObjDALL.arrNumeros[i] < 50))
                            {
                                ObjDALL.sResultado += ObjDALL.arrNumeros[i].ToString() + "    ";
                            }
                            break;
                        }
                    case 8:// Si no tiene nada concatene todo
                        {
                            ObjDALL.sResultado += ObjDALL.arrNumeros[i].ToString() + "    ";                          
                            break;
                        }
                    default:
                        {
                            ObjDALL.sResultado = "Opcion de Despliegue no valida";
                            break;
                        }
                }
            }

        }

    }
}
