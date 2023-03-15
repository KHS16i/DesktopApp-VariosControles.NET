using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_III_DAL.Ecuaciones_cuadraticas;
using Tarea_III_BLL.Ecuaciones_cuadraticas;
using Tarea_III_DAL.RadioButton;
using Tarea_III_BLL.RadioButton;
using Tarea_III_DAL.Arreglo;
using Tarea_III_BLL.Arreglo;
using Tarea_III_DAL.Timer;
using System.Globalization;

namespace Tarea_III_UX.Pantallas.Controles
{
    public partial class frm_Controles : Form
    {
        public frm_Controles()
        {
            InitializeComponent();
        }

        cls_Arreglo_DAL Obj_arreglo_DAL = new cls_Arreglo_DAL();
        cls_Arreglo_BLL Obj_arreglo_BLL = new cls_Arreglo_BLL();

        private void frm_Controles_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir del sistema?",
            "Alerta", MessageBoxButtons.YesNo,
             MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

            tmr_mili.Enabled = false;
            tmr_segundos.Enabled = false;
            tmr_minutos.Enabled = false;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region ECUACIONES CUADRATICAS

        private void btn_calc_Click(object sender, EventArgs e)
        {
            cls_Ecuaciones_Cuadraticas_DAL Obj_ecu_cua_DAL = new cls_Ecuaciones_Cuadraticas_DAL();
            cls_Ecuaciones_cuadraticas_BLL Obj_ecu_cua_BLL = new cls_Ecuaciones_cuadraticas_BLL();

            Obj_ecu_cua_DAL.dVariable_A = Convert.ToDouble(txt_A.Text);
            Obj_ecu_cua_DAL.dVariable_B = Convert.ToDouble(txt_B.Text);
            Obj_ecu_cua_DAL.dVariable_C = Convert.ToDouble(txt_C.Text);

            Obj_ecu_cua_BLL.ecuacion_cuadratica(ref Obj_ecu_cua_DAL);

            if (Obj_ecu_cua_DAL.dDiscriminante == 0) {
                MessageBox.Show("La ecuacion solo tiene una única solución", "Ecuaciones Cuadráticas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_discriminante.Text = Obj_ecu_cua_DAL.dDiscriminante.ToString();
                txt_sol1.Text = Obj_ecu_cua_DAL.dSolucion_I.ToString("f4");
                txt_sol2.Text = "";
            }
            else if (Obj_ecu_cua_DAL.dDiscriminante < 0)
            {
                MessageBox.Show("La ecuacion no tiene solución", "Ecuaciones Cuadráticas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_discriminante.Text = Obj_ecu_cua_DAL.dDiscriminante.ToString();
                txt_sol1.Text = "";
                txt_sol2.Text = "";

            }
            else {
                MessageBox.Show("La ecuacion tiene dos soluciones", "Ecuaciones Cuadráticas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_discriminante.Text = Obj_ecu_cua_DAL.dDiscriminante.ToString();
                txt_sol1.Text = Obj_ecu_cua_DAL.dSolucion_I.ToString("f4");
                txt_sol2.Text = Obj_ecu_cua_DAL.dSolucion_II.ToString("f4");
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_A.Text = "";
            txt_B.Text = "";
            txt_C.Text = "";
            txt_discriminante.Text = "";
            txt_sol1.Text = "";
            txt_sol2.Text = "";
            btn_calc.Enabled = false;

        }

        private void txt_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cSeparador = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (char.IsNumber(e.KeyChar) || (e.KeyChar == 8) || (e.KeyChar == cSeparador) || (e.KeyChar.ToString().Equals("-")))
            {
                if ((e.KeyChar == cSeparador) && (txt_A.Text.Contains(cSeparador.ToString())) || (e.KeyChar.ToString().Equals("-")) && (txt_A.Text.Contains("-")))
                {
                    e.Handled = true;
                }
                else
                {
                    if ((e.KeyChar == cSeparador) && ((txt_A.SelectionStart == 0)))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                    
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_B_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cSeparador = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (char.IsNumber(e.KeyChar) || (e.KeyChar == 8) || (e.KeyChar == cSeparador) || (e.KeyChar.ToString().Equals("-")))
            {
                if ((e.KeyChar == cSeparador) && (txt_B.Text.Contains(cSeparador.ToString())) || (e.KeyChar.ToString().Equals("-")) && (txt_B.Text.Contains("-")))
                {
                    e.Handled = true;
                }
                else
                {
                    if ((e.KeyChar == cSeparador) && ((txt_B.SelectionStart == 0)))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }
    
        private void txt_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cSeparador = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (char.IsNumber(e.KeyChar) || (e.KeyChar == 8) || (e.KeyChar == cSeparador) || (e.KeyChar.ToString().Equals("-")))
            {
                if ((e.KeyChar == cSeparador) && (txt_C.Text.Contains(cSeparador.ToString())) || (e.KeyChar.ToString().Equals("-")) && (txt_C.Text.Contains("-")))
                {
                    e.Handled = true;
                }
                else
                {
                    if ((e.KeyChar == cSeparador) && ((txt_C.SelectionStart == 0)))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_A_Leave(object sender, EventArgs e)
        {
            if ((txt_A.Text.Trim() == string.Empty))
            {
                erp_General.SetError(txt_A, "Campo requerido");
            }
            else if ((txt_A.Text.ToString().Equals("-")))
            {
                txt_A.Focus();
                erp_General.SetError(txt_A, "Te olvidaste de colocar el numero?");
            }
            else
            {
                erp_General.Clear();
            }
        }

        private void txt_B_Leave(object sender, EventArgs e)
        {
            if ((txt_B.Text.Trim() == string.Empty))
            {
                erp_General.SetError(txt_B, "Campo requerido");
            }
            else if ((txt_B.Text.ToString().Equals("-")))
            {
                erp_General.SetError(txt_B, "Te olvidaste de colocar el numero?");
            }
            else
            {
                erp_General.Clear();
            }
        }

        private void txt_C_Leave(object sender, EventArgs e)
        {
            if ((txt_C.Text.Trim() == string.Empty))
            {
                erp_General.SetError(txt_C, "Campo requerido");
            }
            else if ((txt_C.Text.ToString().Equals("-")))
            {
                txt_C.Focus();
                erp_General.SetError(txt_C, "Te olvidaste de colocar el numero?");
            }
            else
            {
                erp_General.Clear();
            }
        }

        private void txt_A_TextChanged(object sender, EventArgs e)
        {
            if (!(txt_A.Text.Trim() == string.Empty || (txt_B.Text.Trim() == string.Empty) || (txt_C.Text.Trim() == string.Empty)))
            {
                btn_calc.Enabled = true;
            }
            else
            {
                btn_calc.Enabled = false;
            }
        }

        private void txt_B_TextChanged(object sender, EventArgs e)
        {
            if (!(txt_B.Text.Trim() == string.Empty || txt_A.Text.Trim() == string.Empty || txt_C.Text.Trim() == string.Empty))
            {
                btn_calc.Enabled = true;
            }
            else
            {
                btn_calc.Enabled = false;
            }
        }

        private void txt_C_TextChanged(object sender, EventArgs e)
        {
            if (!(txt_C.Text.Trim() == string.Empty || txt_A.Text.Trim() == string.Empty || txt_B.Text.Trim() == string.Empty))
            {
                btn_calc.Enabled = true;
            }
            else
            {
                btn_calc.Enabled = false;
            }
        }

        #endregion

        #region SUMATORIA

        private void btn_sumar_Click(object sender, EventArgs e)
        {
            cls_RadioButton_DAL Obj_RadBut_DAL = new cls_RadioButton_DAL();
            cls_RadioButton_BLL Obj_RadBut_BLL = new cls_RadioButton_BLL();

            Obj_RadBut_DAL.iNum_limite = Convert.ToInt32(txt_num_lim.Text);

            if (rdb_todos.Checked)
            {
                Obj_RadBut_BLL.Sumatoria(ref Obj_RadBut_DAL);
                txt_Res_Sum.Text = Convert.ToString(Obj_RadBut_DAL.iRes_suma);
            }
            if (rdb_pares.Checked) {
                Obj_RadBut_BLL.Sumatoria_Pares(ref Obj_RadBut_DAL);
                txt_Res_Sum.Text = Convert.ToString(Obj_RadBut_DAL.iPares);
            }
            if (rdb_impares.Checked) {
                Obj_RadBut_BLL.Sumatoria_Impares(ref Obj_RadBut_DAL);
                txt_Res_Sum.Text = Convert.ToString(Obj_RadBut_DAL.iImpares);
            }


        }

        private void btn_lim_Click(object sender, EventArgs e)
        {
            txt_num_lim.Text = "";
            txt_Res_Sum.Text = "";
            btn_sumar.Enabled = false;
        }

        private void txt_num_lim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (e.KeyChar == 8))
            {             
                    e.Handled = false;      
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_num_lim_Leave(object sender, EventArgs e)
        {
            if ((txt_num_lim.Text == string.Empty))
            {
                erp_General.SetError(txt_num_lim, "Campo requerido");
            }
            else
            {
                erp_General.Clear();
                btn_sumar.Enabled = true;
            }
        }

        private void rdb_todos_CheckedChanged(object sender, EventArgs e)
        {
            txt_Res_Sum.Text = "";
        }

        private void rdb_pares_CheckedChanged(object sender, EventArgs e)
        {
            txt_Res_Sum.Text = "";
        }

        private void rdb_impares_CheckedChanged(object sender, EventArgs e)
        {
            txt_Res_Sum.Text = "";
        }

        private void txt_num_lim_TextChanged(object sender, EventArgs e)
        {
            if (!(txt_Res_Sum.Text.Trim() == string.Empty))
            {
                btn_sumar.Enabled = true;
            }
            else
            {
                btn_sumar.Enabled = false;
            }
        }

        #endregion

        #region TIMER

        int milisegundos = 1, segundos = 1, minutos = 0;

        private void tmr_minutos_Tick(object sender, EventArgs e)
        {
            cls_Timer_DAL Obj_Timer = new cls_Timer_DAL();
            Obj_Timer.bMinutos = Convert.ToInt32(txt_tiempo.Text);

            minutos++;
            lbl_minutos.Text = Convert.ToString(minutos);

            if (minutos == Obj_Timer.bMinutos)
            {
                tmr_mili.Stop();
                tmr_segundos.Stop();
                tmr_minutos.Stop();
                MessageBox.Show("Ha finalizado el tiempo.");
            }
        }

        private void tmr_segundos_Tick(object sender, EventArgs e)
        {
            segundos++;
            lbl_segundos.Text = Convert.ToString(segundos);

            if (segundos == 60)
            {
                segundos = 0;
            }
        }

        private void tmr_mili_Tick(object sender, EventArgs e)
        {
            milisegundos++;
            lbl_mili.Text = Convert.ToString(milisegundos);

            if (milisegundos == 60) {
                milisegundos = 0;
            }
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            tmr_mili.Enabled = true;
            tmr_segundos.Enabled = true;
            tmr_minutos.Enabled = true;
            tmr_mili.Start();
            tmr_segundos.Start();
            tmr_minutos.Start();

            lbl_mili.Text = "1";
            lbl_segundos.Text = "1";

        }

        private void btn_detener_Click(object sender, EventArgs e)
        {
            tmr_mili.Stop();
            tmr_segundos.Stop();
            tmr_minutos.Stop();
        }

        private void btn_limp_Click(object sender, EventArgs e)
        {
            lbl_mili.Text = "0";
            lbl_segundos.Text = "0";
            lbl_minutos.Text = "0";
            milisegundos = 60;
            segundos = 60;
            minutos = 0;
            btn_iniciar.Enabled = false;
            tmr_mili.Stop();
            tmr_segundos.Stop();
            tmr_minutos.Stop();
        }

        private void txt_tiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cSeparador = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if ((e.KeyChar.ToString().Contains("0") && txt_tiempo.SelectionStart == 0) || (e.KeyChar.ToString().Contains("1") && txt_tiempo.SelectionStart == 0) || (e.KeyChar.ToString().Contains("2") && txt_tiempo.SelectionStart == 0) || (e.KeyChar.ToString().Contains("3") && txt_tiempo.SelectionStart == 0) || (e.KeyChar.ToString().Contains("4") && txt_tiempo.SelectionStart == 0) || (e.KeyChar.ToString().Contains("5") && txt_tiempo.SelectionStart == 0) || (e.KeyChar == 8))
            {

                e.Handled = false;
            }
            else {
                e.Handled = true;
            }
        }

        private void txt_tiempo_TextChanged(object sender, EventArgs e)
        {
            cls_Timer_DAL Obj_Timer = new cls_Timer_DAL();

            if (!(txt_tiempo.ToString().Contains("0") || txt_tiempo.Text.Trim() == string.Empty))
            {
                lbl_minutos.Text = Convert.ToString((Obj_Timer.bMinutos));
                btn_iniciar.Enabled = true;
            }
            else
            {
                btn_iniciar.Enabled = false;
            }
        }

        #endregion

        #region Arreglo
        private void btn_lim_arre_Click(object sender, EventArgs e)
        {
            btn_llenar_arreglo.Enabled = true;
            txt_tam_arreglo.Enabled = true;
            txt_lim_arreglo.Enabled = true;

            btn_ver_arreglo.Enabled = false;
            btn_lim_arre.Enabled = false;

            chb_rem_pares.Checked = false;
            chb_rem_men_10.Checked = false;
            chb_rem_may_50.Checked = false;

            txt_cont_arre.Text = string.Empty;
        }

        private void btn_llenar_arreglo_Click(object sender, EventArgs e)
        {
            btn_llenar_arreglo.Enabled = false;
            txt_tam_arreglo.Enabled = false;
            txt_lim_arreglo.Enabled = false;

            btn_ver_arreglo.Enabled = true;
            btn_lim_arre.Enabled = true;

            Obj_arreglo_DAL = new cls_Arreglo_DAL();
            Obj_arreglo_DAL.bTamano_arreglo = Convert.ToByte(txt_tam_arreglo.Text.Trim());
            Obj_arreglo_DAL.iLimite_random = Convert.ToInt32(txt_lim_arreglo.Text.Trim());

            Obj_arreglo_BLL = new cls_Arreglo_BLL();
            Obj_arreglo_BLL.llenarArreglo(ref Obj_arreglo_DAL);

        }

        private void chb_rem_pares_CheckedChanged(object sender, EventArgs e)
        {
            Desplegar_Generico();
        }

        private void chb_rem_men_10_CheckedChanged(object sender, EventArgs e)
        {
            Desplegar_Generico();
        }

        private void chb_rem_may_50_CheckedChanged(object sender, EventArgs e)
        {
            Desplegar_Generico();
        }

        private void btn_ver_arreglo_Click(object sender, EventArgs e)
        {
            Desplegar_Generico();
        }

        public void Desplegar_Generico() {

            if ((chb_rem_pares.Checked == true) && (chb_rem_men_10.Checked == false) && (chb_rem_may_50.Checked == false))
            {
                Obj_arreglo_DAL.bOpc = 1;
            }
            else if ((chb_rem_pares.Checked == false) && (chb_rem_men_10.Checked == true) && (chb_rem_may_50.Checked == false))
            {
                Obj_arreglo_DAL.bOpc = 2;
            }
            else if ((chb_rem_pares.Checked == false) && (chb_rem_men_10.Checked == false) && (chb_rem_may_50.Checked == true))
            {
                Obj_arreglo_DAL.bOpc = 3;
            }
            else if ((chb_rem_pares.Checked == true) && (chb_rem_men_10.Checked == true) && (chb_rem_may_50.Checked == false))
            {
                Obj_arreglo_DAL.bOpc = 4;
            }
            else if ((chb_rem_pares.Checked == true) && (chb_rem_men_10.Checked == false) && (chb_rem_may_50.Checked == true))
            {
                Obj_arreglo_DAL.bOpc = 5;
            }
            else if ((chb_rem_pares.Checked == false) && (chb_rem_men_10.Checked == true) && (chb_rem_may_50.Checked == true))
            {
                Obj_arreglo_DAL.bOpc = 6;
            }
            else if ((chb_rem_pares.Checked == true) && (chb_rem_men_10.Checked == true) && (chb_rem_may_50.Checked == true))
            {
                Obj_arreglo_DAL.bOpc = 7;
            }
            else if ((chb_rem_pares.Checked == false) && (chb_rem_men_10.Checked == false) && (chb_rem_may_50.Checked == false))
            {
                Obj_arreglo_DAL.bOpc = 8;
            }
            else
            {
                Obj_arreglo_DAL.bOpc = 9;
            }

            Obj_arreglo_BLL.mostrarArreglo(ref Obj_arreglo_DAL);
            txt_cont_arre.Text = string.Empty;
            txt_cont_arre.Text = Obj_arreglo_DAL.sResultado;

        }
        #endregion
    }
}
