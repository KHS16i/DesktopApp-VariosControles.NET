
namespace Tarea_III_UX.Pantallas.Controles
{
    partial class frm_Controles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tab_ecu_cua = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbx_ecu_cua = new System.Windows.Forms.GroupBox();
            this.gbx_cal_lim = new System.Windows.Forms.GroupBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_calc = new System.Windows.Forms.Button();
            this.txt_sol1 = new System.Windows.Forms.TextBox();
            this.txt_sol2 = new System.Windows.Forms.TextBox();
            this.txt_discriminante = new System.Windows.Forms.TextBox();
            this.lbl_sol1 = new System.Windows.Forms.Label();
            this.lbl_sol2 = new System.Windows.Forms.Label();
            this.lbl_discriminante = new System.Windows.Forms.Label();
            this.txt_B = new System.Windows.Forms.TextBox();
            this.txt_C = new System.Windows.Forms.TextBox();
            this.txt_A = new System.Windows.Forms.TextBox();
            this.lbl_B = new System.Windows.Forms.Label();
            this.lbl_C = new System.Windows.Forms.Label();
            this.lbl_A = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbx_sumatoria = new System.Windows.Forms.GroupBox();
            this.txt_Res_Sum = new System.Windows.Forms.TextBox();
            this.lbl_res = new System.Windows.Forms.Label();
            this.btn_lim = new System.Windows.Forms.Button();
            this.gbx_opciones = new System.Windows.Forms.GroupBox();
            this.btn_sumar = new System.Windows.Forms.Button();
            this.gbx_control = new System.Windows.Forms.GroupBox();
            this.rdb_impares = new System.Windows.Forms.RadioButton();
            this.rdb_pares = new System.Windows.Forms.RadioButton();
            this.rdb_todos = new System.Windows.Forms.RadioButton();
            this.txt_num_lim = new System.Windows.Forms.TextBox();
            this.lbl_num_limite = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gbx_arreglo = new System.Windows.Forms.GroupBox();
            this.gbx_control_arre = new System.Windows.Forms.GroupBox();
            this.chb_rem_may_50 = new System.Windows.Forms.CheckBox();
            this.chb_rem_men_10 = new System.Windows.Forms.CheckBox();
            this.chb_rem_pares = new System.Windows.Forms.CheckBox();
            this.gbx_opc_arreglo = new System.Windows.Forms.GroupBox();
            this.btn_ver_arreglo = new System.Windows.Forms.Button();
            this.btn_lim_arre = new System.Windows.Forms.Button();
            this.lbl_conte_arreglo = new System.Windows.Forms.Label();
            this.txt_cont_arre = new System.Windows.Forms.TextBox();
            this.lbl_lim_random = new System.Windows.Forms.Label();
            this.lbl_tam_arreglo = new System.Windows.Forms.Label();
            this.btn_llenar_arreglo = new System.Windows.Forms.Button();
            this.txt_lim_arreglo = new System.Windows.Forms.TextBox();
            this.txt_tam_arreglo = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_minutos = new System.Windows.Forms.Label();
            this.lbl_mili = new System.Windows.Forms.Label();
            this.lbl_segundos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bbx_opciones = new System.Windows.Forms.GroupBox();
            this.btn_detener = new System.Windows.Forms.Button();
            this.btn_limp = new System.Windows.Forms.Button();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tiempo = new System.Windows.Forms.TextBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.erp_General = new System.Windows.Forms.ErrorProvider(this.components);
            this.tmr_segundos = new System.Windows.Forms.Timer(this.components);
            this.tmr_minutos = new System.Windows.Forms.Timer(this.components);
            this.tmr_mili = new System.Windows.Forms.Timer(this.components);
            this.tab_ecu_cua.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbx_ecu_cua.SuspendLayout();
            this.gbx_cal_lim.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbx_sumatoria.SuspendLayout();
            this.gbx_opciones.SuspendLayout();
            this.gbx_control.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gbx_arreglo.SuspendLayout();
            this.gbx_control_arre.SuspendLayout();
            this.gbx_opc_arreglo.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.bbx_opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp_General)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_ecu_cua
            // 
            this.tab_ecu_cua.Controls.Add(this.tabPage1);
            this.tab_ecu_cua.Controls.Add(this.tabPage2);
            this.tab_ecu_cua.Controls.Add(this.tabPage3);
            this.tab_ecu_cua.Controls.Add(this.tabPage4);
            this.tab_ecu_cua.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_ecu_cua.Location = new System.Drawing.Point(12, 12);
            this.tab_ecu_cua.Name = "tab_ecu_cua";
            this.tab_ecu_cua.SelectedIndex = 0;
            this.tab_ecu_cua.Size = new System.Drawing.Size(776, 379);
            this.tab_ecu_cua.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.gbx_ecu_cua);
            this.tabPage1.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(768, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ecuaciones Cuadráticas";
            // 
            // gbx_ecu_cua
            // 
            this.gbx_ecu_cua.Controls.Add(this.gbx_cal_lim);
            this.gbx_ecu_cua.Controls.Add(this.txt_sol1);
            this.gbx_ecu_cua.Controls.Add(this.txt_sol2);
            this.gbx_ecu_cua.Controls.Add(this.txt_discriminante);
            this.gbx_ecu_cua.Controls.Add(this.lbl_sol1);
            this.gbx_ecu_cua.Controls.Add(this.lbl_sol2);
            this.gbx_ecu_cua.Controls.Add(this.lbl_discriminante);
            this.gbx_ecu_cua.Controls.Add(this.txt_B);
            this.gbx_ecu_cua.Controls.Add(this.txt_C);
            this.gbx_ecu_cua.Controls.Add(this.txt_A);
            this.gbx_ecu_cua.Controls.Add(this.lbl_B);
            this.gbx_ecu_cua.Controls.Add(this.lbl_C);
            this.gbx_ecu_cua.Controls.Add(this.lbl_A);
            this.gbx_ecu_cua.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_ecu_cua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbx_ecu_cua.Location = new System.Drawing.Point(20, 19);
            this.gbx_ecu_cua.Name = "gbx_ecu_cua";
            this.gbx_ecu_cua.Size = new System.Drawing.Size(593, 301);
            this.gbx_ecu_cua.TabIndex = 0;
            this.gbx_ecu_cua.TabStop = false;
            this.gbx_ecu_cua.Text = "Información de la Ecuación";
            // 
            // gbx_cal_lim
            // 
            this.gbx_cal_lim.Controls.Add(this.btn_limpiar);
            this.gbx_cal_lim.Controls.Add(this.btn_calc);
            this.gbx_cal_lim.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_cal_lim.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbx_cal_lim.Location = new System.Drawing.Point(359, 41);
            this.gbx_cal_lim.Name = "gbx_cal_lim";
            this.gbx_cal_lim.Size = new System.Drawing.Size(200, 139);
            this.gbx_cal_lim.TabIndex = 12;
            this.gbx_cal_lim.TabStop = false;
            this.gbx_cal_lim.Text = "Opciones";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_limpiar.Location = new System.Drawing.Point(58, 86);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(100, 41);
            this.btn_limpiar.TabIndex = 2;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_calc
            // 
            this.btn_calc.Enabled = false;
            this.btn_calc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_calc.Location = new System.Drawing.Point(58, 40);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(100, 41);
            this.btn_calc.TabIndex = 3;
            this.btn_calc.Text = "Calcular";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // txt_sol1
            // 
            this.txt_sol1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sol1.Location = new System.Drawing.Point(175, 218);
            this.txt_sol1.Name = "txt_sol1";
            this.txt_sol1.ReadOnly = true;
            this.txt_sol1.Size = new System.Drawing.Size(100, 28);
            this.txt_sol1.TabIndex = 11;
            // 
            // txt_sol2
            // 
            this.txt_sol2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sol2.Location = new System.Drawing.Point(175, 255);
            this.txt_sol2.Name = "txt_sol2";
            this.txt_sol2.ReadOnly = true;
            this.txt_sol2.Size = new System.Drawing.Size(100, 28);
            this.txt_sol2.TabIndex = 10;
            // 
            // txt_discriminante
            // 
            this.txt_discriminante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_discriminante.Location = new System.Drawing.Point(175, 176);
            this.txt_discriminante.Name = "txt_discriminante";
            this.txt_discriminante.ReadOnly = true;
            this.txt_discriminante.Size = new System.Drawing.Size(100, 28);
            this.txt_discriminante.TabIndex = 9;
            // 
            // lbl_sol1
            // 
            this.lbl_sol1.AutoSize = true;
            this.lbl_sol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sol1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_sol1.Location = new System.Drawing.Point(36, 213);
            this.lbl_sol1.Name = "lbl_sol1";
            this.lbl_sol1.Size = new System.Drawing.Size(109, 24);
            this.lbl_sol1.TabIndex = 8;
            this.lbl_sol1.Text = "Solución 1 :";
            // 
            // lbl_sol2
            // 
            this.lbl_sol2.AutoSize = true;
            this.lbl_sol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sol2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_sol2.Location = new System.Drawing.Point(36, 250);
            this.lbl_sol2.Name = "lbl_sol2";
            this.lbl_sol2.Size = new System.Drawing.Size(109, 24);
            this.lbl_sol2.TabIndex = 7;
            this.lbl_sol2.Text = "Solución 2 :";
            // 
            // lbl_discriminante
            // 
            this.lbl_discriminante.AutoSize = true;
            this.lbl_discriminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discriminante.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_discriminante.Location = new System.Drawing.Point(36, 176);
            this.lbl_discriminante.Name = "lbl_discriminante";
            this.lbl_discriminante.Size = new System.Drawing.Size(133, 24);
            this.lbl_discriminante.TabIndex = 6;
            this.lbl_discriminante.Text = "Discriminante :";
            // 
            // txt_B
            // 
            this.txt_B.Location = new System.Drawing.Point(140, 117);
            this.txt_B.Name = "txt_B";
            this.txt_B.ShortcutsEnabled = false;
            this.txt_B.Size = new System.Drawing.Size(63, 28);
            this.txt_B.TabIndex = 5;
            this.txt_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_B.TextChanged += new System.EventHandler(this.txt_B_TextChanged);
            this.txt_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_B_KeyPress);
            this.txt_B.Leave += new System.EventHandler(this.txt_B_Leave);
            // 
            // txt_C
            // 
            this.txt_C.Location = new System.Drawing.Point(244, 117);
            this.txt_C.Name = "txt_C";
            this.txt_C.ShortcutsEnabled = false;
            this.txt_C.Size = new System.Drawing.Size(63, 28);
            this.txt_C.TabIndex = 4;
            this.txt_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_C.TextChanged += new System.EventHandler(this.txt_C_TextChanged);
            this.txt_C.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_C_KeyPress);
            this.txt_C.Leave += new System.EventHandler(this.txt_C_Leave);
            // 
            // txt_A
            // 
            this.txt_A.Location = new System.Drawing.Point(40, 117);
            this.txt_A.Name = "txt_A";
            this.txt_A.ShortcutsEnabled = false;
            this.txt_A.Size = new System.Drawing.Size(63, 28);
            this.txt_A.TabIndex = 3;
            this.txt_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_A.TextChanged += new System.EventHandler(this.txt_A_TextChanged);
            this.txt_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_A_KeyPress);
            this.txt_A.Leave += new System.EventHandler(this.txt_A_Leave);
            // 
            // lbl_B
            // 
            this.lbl_B.AutoSize = true;
            this.lbl_B.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_B.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_B.Location = new System.Drawing.Point(142, 41);
            this.lbl_B.Name = "lbl_B";
            this.lbl_B.Size = new System.Drawing.Size(61, 64);
            this.lbl_B.TabIndex = 2;
            this.lbl_B.Text = "B";
            // 
            // lbl_C
            // 
            this.lbl_C.AutoSize = true;
            this.lbl_C.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_C.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_C.Location = new System.Drawing.Point(247, 41);
            this.lbl_C.Name = "lbl_C";
            this.lbl_C.Size = new System.Drawing.Size(60, 64);
            this.lbl_C.TabIndex = 1;
            this.lbl_C.Text = "C";
            // 
            // lbl_A
            // 
            this.lbl_A.AutoSize = true;
            this.lbl_A.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_A.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_A.Location = new System.Drawing.Point(39, 41);
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(64, 64);
            this.lbl_A.TabIndex = 0;
            this.lbl_A.Text = "A";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbx_sumatoria);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(768, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RadioButton";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbx_sumatoria
            // 
            this.gbx_sumatoria.Controls.Add(this.txt_Res_Sum);
            this.gbx_sumatoria.Controls.Add(this.lbl_res);
            this.gbx_sumatoria.Controls.Add(this.btn_lim);
            this.gbx_sumatoria.Controls.Add(this.gbx_opciones);
            this.gbx_sumatoria.Controls.Add(this.gbx_control);
            this.gbx_sumatoria.Controls.Add(this.txt_num_lim);
            this.gbx_sumatoria.Controls.Add(this.lbl_num_limite);
            this.gbx_sumatoria.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_sumatoria.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbx_sumatoria.Location = new System.Drawing.Point(19, 16);
            this.gbx_sumatoria.Name = "gbx_sumatoria";
            this.gbx_sumatoria.Size = new System.Drawing.Size(702, 252);
            this.gbx_sumatoria.TabIndex = 0;
            this.gbx_sumatoria.TabStop = false;
            this.gbx_sumatoria.Text = "Sumatoria";
            // 
            // txt_Res_Sum
            // 
            this.txt_Res_Sum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Res_Sum.Location = new System.Drawing.Point(199, 186);
            this.txt_Res_Sum.Name = "txt_Res_Sum";
            this.txt_Res_Sum.ReadOnly = true;
            this.txt_Res_Sum.Size = new System.Drawing.Size(130, 28);
            this.txt_Res_Sum.TabIndex = 5;
            this.txt_Res_Sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_res
            // 
            this.lbl_res.AutoSize = true;
            this.lbl_res.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_res.Location = new System.Drawing.Point(25, 189);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(168, 21);
            this.lbl_res.TabIndex = 4;
            this.lbl_res.Text = "Resultado Sumatoria";
            // 
            // btn_lim
            // 
            this.btn_lim.AllowDrop = true;
            this.btn_lim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_lim.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_lim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lim.Location = new System.Drawing.Point(542, 128);
            this.btn_lim.Name = "btn_lim";
            this.btn_lim.Size = new System.Drawing.Size(100, 41);
            this.btn_lim.TabIndex = 2;
            this.btn_lim.Text = "Limpiar";
            this.btn_lim.UseVisualStyleBackColor = true;
            this.btn_lim.Click += new System.EventHandler(this.btn_lim_Click);
            // 
            // gbx_opciones
            // 
            this.gbx_opciones.Controls.Add(this.btn_sumar);
            this.gbx_opciones.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbx_opciones.Location = new System.Drawing.Point(484, 55);
            this.gbx_opciones.Name = "gbx_opciones";
            this.gbx_opciones.Size = new System.Drawing.Size(200, 134);
            this.gbx_opciones.TabIndex = 3;
            this.gbx_opciones.TabStop = false;
            this.gbx_opciones.Text = "Opciones";
            // 
            // btn_sumar
            // 
            this.btn_sumar.AllowDrop = true;
            this.btn_sumar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sumar.Enabled = false;
            this.btn_sumar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_sumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sumar.Location = new System.Drawing.Point(58, 26);
            this.btn_sumar.Name = "btn_sumar";
            this.btn_sumar.Size = new System.Drawing.Size(100, 41);
            this.btn_sumar.TabIndex = 3;
            this.btn_sumar.Text = "Sumar";
            this.btn_sumar.UseVisualStyleBackColor = true;
            this.btn_sumar.Click += new System.EventHandler(this.btn_sumar_Click);
            // 
            // gbx_control
            // 
            this.gbx_control.Controls.Add(this.rdb_impares);
            this.gbx_control.Controls.Add(this.rdb_pares);
            this.gbx_control.Controls.Add(this.rdb_todos);
            this.gbx_control.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbx_control.Location = new System.Drawing.Point(28, 95);
            this.gbx_control.Name = "gbx_control";
            this.gbx_control.Size = new System.Drawing.Size(427, 57);
            this.gbx_control.TabIndex = 2;
            this.gbx_control.TabStop = false;
            this.gbx_control.Text = "Control";
            // 
            // rdb_impares
            // 
            this.rdb_impares.AutoSize = true;
            this.rdb_impares.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rdb_impares.Location = new System.Drawing.Point(298, 23);
            this.rdb_impares.Name = "rdb_impares";
            this.rdb_impares.Size = new System.Drawing.Size(126, 25);
            this.rdb_impares.TabIndex = 2;
            this.rdb_impares.TabStop = true;
            this.rdb_impares.Text = "Solo impares";
            this.rdb_impares.UseVisualStyleBackColor = true;
            this.rdb_impares.CheckedChanged += new System.EventHandler(this.rdb_impares_CheckedChanged);
            // 
            // rdb_pares
            // 
            this.rdb_pares.AutoSize = true;
            this.rdb_pares.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rdb_pares.Location = new System.Drawing.Point(157, 23);
            this.rdb_pares.Name = "rdb_pares";
            this.rdb_pares.Size = new System.Drawing.Size(107, 25);
            this.rdb_pares.TabIndex = 1;
            this.rdb_pares.TabStop = true;
            this.rdb_pares.Text = "Solo pares";
            this.rdb_pares.UseVisualStyleBackColor = true;
            this.rdb_pares.CheckedChanged += new System.EventHandler(this.rdb_pares_CheckedChanged);
            // 
            // rdb_todos
            // 
            this.rdb_todos.AutoSize = true;
            this.rdb_todos.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rdb_todos.Location = new System.Drawing.Point(25, 24);
            this.rdb_todos.Name = "rdb_todos";
            this.rdb_todos.Size = new System.Drawing.Size(74, 25);
            this.rdb_todos.TabIndex = 0;
            this.rdb_todos.TabStop = true;
            this.rdb_todos.Text = "Todos";
            this.rdb_todos.UseVisualStyleBackColor = true;
            this.rdb_todos.CheckedChanged += new System.EventHandler(this.rdb_todos_CheckedChanged);
            // 
            // txt_num_lim
            // 
            this.txt_num_lim.Location = new System.Drawing.Point(155, 52);
            this.txt_num_lim.Name = "txt_num_lim";
            this.txt_num_lim.ShortcutsEnabled = false;
            this.txt_num_lim.Size = new System.Drawing.Size(125, 28);
            this.txt_num_lim.TabIndex = 1;
            this.txt_num_lim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_num_lim.TextChanged += new System.EventHandler(this.txt_num_lim_TextChanged);
            this.txt_num_lim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num_lim_KeyPress);
            this.txt_num_lim.Leave += new System.EventHandler(this.txt_num_lim_Leave);
            // 
            // lbl_num_limite
            // 
            this.lbl_num_limite.AutoSize = true;
            this.lbl_num_limite.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_num_limite.Location = new System.Drawing.Point(25, 55);
            this.lbl_num_limite.Name = "lbl_num_limite";
            this.lbl_num_limite.Size = new System.Drawing.Size(124, 21);
            this.lbl_num_limite.TabIndex = 0;
            this.lbl_num_limite.Text = "Número Límite";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gbx_arreglo);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(768, 347);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CheckBox";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gbx_arreglo
            // 
            this.gbx_arreglo.Controls.Add(this.gbx_control_arre);
            this.gbx_arreglo.Controls.Add(this.gbx_opc_arreglo);
            this.gbx_arreglo.Controls.Add(this.lbl_conte_arreglo);
            this.gbx_arreglo.Controls.Add(this.txt_cont_arre);
            this.gbx_arreglo.Controls.Add(this.lbl_lim_random);
            this.gbx_arreglo.Controls.Add(this.lbl_tam_arreglo);
            this.gbx_arreglo.Controls.Add(this.btn_llenar_arreglo);
            this.gbx_arreglo.Controls.Add(this.txt_lim_arreglo);
            this.gbx_arreglo.Controls.Add(this.txt_tam_arreglo);
            this.gbx_arreglo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_arreglo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbx_arreglo.Location = new System.Drawing.Point(17, 17);
            this.gbx_arreglo.Name = "gbx_arreglo";
            this.gbx_arreglo.Size = new System.Drawing.Size(731, 314);
            this.gbx_arreglo.TabIndex = 5;
            this.gbx_arreglo.TabStop = false;
            this.gbx_arreglo.Text = "Arreglo";
            // 
            // gbx_control_arre
            // 
            this.gbx_control_arre.Controls.Add(this.chb_rem_may_50);
            this.gbx_control_arre.Controls.Add(this.chb_rem_men_10);
            this.gbx_control_arre.Controls.Add(this.chb_rem_pares);
            this.gbx_control_arre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbx_control_arre.Location = new System.Drawing.Point(43, 125);
            this.gbx_control_arre.Name = "gbx_control_arre";
            this.gbx_control_arre.Size = new System.Drawing.Size(299, 126);
            this.gbx_control_arre.TabIndex = 10;
            this.gbx_control_arre.TabStop = false;
            this.gbx_control_arre.Text = "Control";
            // 
            // chb_rem_may_50
            // 
            this.chb_rem_may_50.AutoSize = true;
            this.chb_rem_may_50.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chb_rem_may_50.Location = new System.Drawing.Point(16, 92);
            this.chb_rem_may_50.Name = "chb_rem_may_50";
            this.chb_rem_may_50.Size = new System.Drawing.Size(274, 25);
            this.chb_rem_may_50.TabIndex = 2;
            this.chb_rem_may_50.Text = "Remover números mayores a 50";
            this.chb_rem_may_50.UseVisualStyleBackColor = true;
            this.chb_rem_may_50.CheckedChanged += new System.EventHandler(this.chb_rem_may_50_CheckedChanged);
            // 
            // chb_rem_men_10
            // 
            this.chb_rem_men_10.AutoSize = true;
            this.chb_rem_men_10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chb_rem_men_10.Location = new System.Drawing.Point(16, 60);
            this.chb_rem_men_10.Name = "chb_rem_men_10";
            this.chb_rem_men_10.Size = new System.Drawing.Size(276, 25);
            this.chb_rem_men_10.TabIndex = 1;
            this.chb_rem_men_10.Text = "Remover números menores a 10";
            this.chb_rem_men_10.UseVisualStyleBackColor = true;
            this.chb_rem_men_10.CheckedChanged += new System.EventHandler(this.chb_rem_men_10_CheckedChanged);
            // 
            // chb_rem_pares
            // 
            this.chb_rem_pares.AutoSize = true;
            this.chb_rem_pares.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chb_rem_pares.Location = new System.Drawing.Point(16, 28);
            this.chb_rem_pares.Name = "chb_rem_pares";
            this.chb_rem_pares.Size = new System.Drawing.Size(214, 25);
            this.chb_rem_pares.TabIndex = 0;
            this.chb_rem_pares.Text = "Remover números pares";
            this.chb_rem_pares.UseVisualStyleBackColor = true;
            this.chb_rem_pares.CheckedChanged += new System.EventHandler(this.chb_rem_pares_CheckedChanged);
            // 
            // gbx_opc_arreglo
            // 
            this.gbx_opc_arreglo.Controls.Add(this.btn_ver_arreglo);
            this.gbx_opc_arreglo.Controls.Add(this.btn_lim_arre);
            this.gbx_opc_arreglo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbx_opc_arreglo.Location = new System.Drawing.Point(502, 73);
            this.gbx_opc_arreglo.Name = "gbx_opc_arreglo";
            this.gbx_opc_arreglo.Size = new System.Drawing.Size(200, 131);
            this.gbx_opc_arreglo.TabIndex = 9;
            this.gbx_opc_arreglo.TabStop = false;
            this.gbx_opc_arreglo.Text = "Opciones";
            // 
            // btn_ver_arreglo
            // 
            this.btn_ver_arreglo.Enabled = false;
            this.btn_ver_arreglo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ver_arreglo.Location = new System.Drawing.Point(50, 27);
            this.btn_ver_arreglo.Name = "btn_ver_arreglo";
            this.btn_ver_arreglo.Size = new System.Drawing.Size(109, 41);
            this.btn_ver_arreglo.TabIndex = 3;
            this.btn_ver_arreglo.Text = "Ver arreglo";
            this.btn_ver_arreglo.UseVisualStyleBackColor = true;
            this.btn_ver_arreglo.Click += new System.EventHandler(this.btn_ver_arreglo_Click);
            // 
            // btn_lim_arre
            // 
            this.btn_lim_arre.Enabled = false;
            this.btn_lim_arre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_lim_arre.Location = new System.Drawing.Point(50, 74);
            this.btn_lim_arre.Name = "btn_lim_arre";
            this.btn_lim_arre.Size = new System.Drawing.Size(109, 41);
            this.btn_lim_arre.TabIndex = 4;
            this.btn_lim_arre.Text = "Limpiar";
            this.btn_lim_arre.UseVisualStyleBackColor = true;
            this.btn_lim_arre.Click += new System.EventHandler(this.btn_lim_arre_Click);
            // 
            // lbl_conte_arreglo
            // 
            this.lbl_conte_arreglo.AutoSize = true;
            this.lbl_conte_arreglo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_conte_arreglo.Location = new System.Drawing.Point(39, 268);
            this.lbl_conte_arreglo.Name = "lbl_conte_arreglo";
            this.lbl_conte_arreglo.Size = new System.Drawing.Size(183, 21);
            this.lbl_conte_arreglo.TabIndex = 8;
            this.lbl_conte_arreglo.Text = "Contenido del Arreglo:";
            // 
            // txt_cont_arre
            // 
            this.txt_cont_arre.Location = new System.Drawing.Point(224, 265);
            this.txt_cont_arre.Name = "txt_cont_arre";
            this.txt_cont_arre.ReadOnly = true;
            this.txt_cont_arre.Size = new System.Drawing.Size(478, 28);
            this.txt_cont_arre.TabIndex = 7;
            this.txt_cont_arre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_lim_random
            // 
            this.lbl_lim_random.AutoSize = true;
            this.lbl_lim_random.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_lim_random.Location = new System.Drawing.Point(39, 83);
            this.lbl_lim_random.Name = "lbl_lim_random";
            this.lbl_lim_random.Size = new System.Drawing.Size(157, 21);
            this.lbl_lim_random.TabIndex = 6;
            this.lbl_lim_random.Text = "Limite del Random:";
            // 
            // lbl_tam_arreglo
            // 
            this.lbl_tam_arreglo.AutoSize = true;
            this.lbl_tam_arreglo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_tam_arreglo.Location = new System.Drawing.Point(39, 46);
            this.lbl_tam_arreglo.Name = "lbl_tam_arreglo";
            this.lbl_tam_arreglo.Size = new System.Drawing.Size(137, 21);
            this.lbl_tam_arreglo.TabIndex = 5;
            this.lbl_tam_arreglo.Text = "Tamaño Arreglo:";
            // 
            // btn_llenar_arreglo
            // 
            this.btn_llenar_arreglo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_llenar_arreglo.Location = new System.Drawing.Point(327, 73);
            this.btn_llenar_arreglo.Name = "btn_llenar_arreglo";
            this.btn_llenar_arreglo.Size = new System.Drawing.Size(126, 41);
            this.btn_llenar_arreglo.TabIndex = 0;
            this.btn_llenar_arreglo.Text = "Llenar arreglo";
            this.btn_llenar_arreglo.UseVisualStyleBackColor = true;
            this.btn_llenar_arreglo.Click += new System.EventHandler(this.btn_llenar_arreglo_Click);
            // 
            // txt_lim_arreglo
            // 
            this.txt_lim_arreglo.Location = new System.Drawing.Point(210, 77);
            this.txt_lim_arreglo.Name = "txt_lim_arreglo";
            this.txt_lim_arreglo.ShortcutsEnabled = false;
            this.txt_lim_arreglo.Size = new System.Drawing.Size(100, 28);
            this.txt_lim_arreglo.TabIndex = 2;
            // 
            // txt_tam_arreglo
            // 
            this.txt_tam_arreglo.Location = new System.Drawing.Point(210, 43);
            this.txt_tam_arreglo.Name = "txt_tam_arreglo";
            this.txt_tam_arreglo.ShortcutsEnabled = false;
            this.txt_tam_arreglo.Size = new System.Drawing.Size(100, 28);
            this.txt_tam_arreglo.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage4.Size = new System.Drawing.Size(768, 347);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Timer";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_minutos);
            this.groupBox1.Controls.Add(this.lbl_mili);
            this.groupBox1.Controls.Add(this.lbl_segundos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bbx_opciones);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_tiempo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(33, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cronometro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(267, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "minutos";
            // 
            // lbl_minutos
            // 
            this.lbl_minutos.AutoSize = true;
            this.lbl_minutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_minutos.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minutos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_minutos.Location = new System.Drawing.Point(127, 229);
            this.lbl_minutos.Name = "lbl_minutos";
            this.lbl_minutos.Size = new System.Drawing.Size(33, 37);
            this.lbl_minutos.TabIndex = 11;
            this.lbl_minutos.Text = "0";
            // 
            // lbl_mili
            // 
            this.lbl_mili.AutoSize = true;
            this.lbl_mili.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_mili.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mili.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_mili.Location = new System.Drawing.Point(451, 229);
            this.lbl_mili.Name = "lbl_mili";
            this.lbl_mili.Size = new System.Drawing.Size(33, 37);
            this.lbl_mili.TabIndex = 10;
            this.lbl_mili.Text = "0";
            // 
            // lbl_segundos
            // 
            this.lbl_segundos.AutoSize = true;
            this.lbl_segundos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_segundos.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_segundos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_segundos.Location = new System.Drawing.Point(276, 229);
            this.lbl_segundos.Name = "lbl_segundos";
            this.lbl_segundos.Size = new System.Drawing.Size(33, 37);
            this.lbl_segundos.TabIndex = 9;
            this.lbl_segundos.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(334, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Milisegundos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(185, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Segundos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(48, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Minutos";
            // 
            // bbx_opciones
            // 
            this.bbx_opciones.Controls.Add(this.btn_detener);
            this.bbx_opciones.Controls.Add(this.btn_limp);
            this.bbx_opciones.Controls.Add(this.btn_iniciar);
            this.bbx_opciones.Location = new System.Drawing.Point(431, 32);
            this.bbx_opciones.Name = "bbx_opciones";
            this.bbx_opciones.Size = new System.Drawing.Size(200, 175);
            this.bbx_opciones.TabIndex = 2;
            this.bbx_opciones.TabStop = false;
            this.bbx_opciones.Text = "Opciones";
            // 
            // btn_detener
            // 
            this.btn_detener.AllowDrop = true;
            this.btn_detener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_detener.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_detener.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detener.Location = new System.Drawing.Point(49, 71);
            this.btn_detener.Name = "btn_detener";
            this.btn_detener.Size = new System.Drawing.Size(100, 41);
            this.btn_detener.TabIndex = 2;
            this.btn_detener.Text = "Detener";
            this.btn_detener.UseVisualStyleBackColor = true;
            this.btn_detener.Click += new System.EventHandler(this.btn_detener_Click);
            // 
            // btn_limp
            // 
            this.btn_limp.AllowDrop = true;
            this.btn_limp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_limp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limp.Location = new System.Drawing.Point(49, 118);
            this.btn_limp.Name = "btn_limp";
            this.btn_limp.Size = new System.Drawing.Size(100, 41);
            this.btn_limp.TabIndex = 3;
            this.btn_limp.Text = "Limpiar";
            this.btn_limp.UseVisualStyleBackColor = true;
            this.btn_limp.Click += new System.EventHandler(this.btn_limp_Click);
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.AllowDrop = true;
            this.btn_iniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_iniciar.Enabled = false;
            this.btn_iniciar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar.Location = new System.Drawing.Point(49, 19);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(100, 41);
            this.btn_iniciar.TabIndex = 3;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(47, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiempo:";
            // 
            // txt_tiempo
            // 
            this.txt_tiempo.Location = new System.Drawing.Point(161, 93);
            this.txt_tiempo.Name = "txt_tiempo";
            this.txt_tiempo.ShortcutsEnabled = false;
            this.txt_tiempo.Size = new System.Drawing.Size(100, 28);
            this.txt_tiempo.TabIndex = 0;
            this.txt_tiempo.Text = "0";
            this.txt_tiempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_tiempo.TextChanged += new System.EventHandler(this.txt_tiempo_TextChanged);
            this.txt_tiempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tiempo_KeyPress);
            // 
            // btn_salir
            // 
            this.btn_salir.AllowDrop = true;
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(684, 397);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(100, 41);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // erp_General
            // 
            this.erp_General.ContainerControl = this;
            // 
            // tmr_segundos
            // 
            this.tmr_segundos.Interval = 1000;
            this.tmr_segundos.Tick += new System.EventHandler(this.tmr_segundos_Tick);
            // 
            // tmr_minutos
            // 
            this.tmr_minutos.Interval = 60000;
            this.tmr_minutos.Tick += new System.EventHandler(this.tmr_minutos_Tick);
            // 
            // tmr_mili
            // 
            this.tmr_mili.Interval = 1;
            this.tmr_mili.Tick += new System.EventHandler(this.tmr_mili_Tick);
            // 
            // frm_Controles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.tab_ecu_cua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_Controles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Controles_FormClosing);
            this.tab_ecu_cua.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbx_ecu_cua.ResumeLayout(false);
            this.gbx_ecu_cua.PerformLayout();
            this.gbx_cal_lim.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.gbx_sumatoria.ResumeLayout(false);
            this.gbx_sumatoria.PerformLayout();
            this.gbx_opciones.ResumeLayout(false);
            this.gbx_control.ResumeLayout(false);
            this.gbx_control.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.gbx_arreglo.ResumeLayout(false);
            this.gbx_arreglo.PerformLayout();
            this.gbx_control_arre.ResumeLayout(false);
            this.gbx_control_arre.PerformLayout();
            this.gbx_opc_arreglo.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.bbx_opciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erp_General)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_ecu_cua;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbx_ecu_cua;
        private System.Windows.Forms.Label lbl_A;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txt_B;
        private System.Windows.Forms.TextBox txt_C;
        private System.Windows.Forms.TextBox txt_A;
        private System.Windows.Forms.Label lbl_B;
        private System.Windows.Forms.Label lbl_C;
        private System.Windows.Forms.TextBox txt_sol1;
        private System.Windows.Forms.TextBox txt_sol2;
        private System.Windows.Forms.TextBox txt_discriminante;
        private System.Windows.Forms.Label lbl_sol1;
        private System.Windows.Forms.Label lbl_sol2;
        private System.Windows.Forms.Label lbl_discriminante;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.GroupBox gbx_cal_lim;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.ErrorProvider erp_General;
        private System.Windows.Forms.GroupBox gbx_sumatoria;
        private System.Windows.Forms.TextBox txt_Res_Sum;
        private System.Windows.Forms.Label lbl_res;
        private System.Windows.Forms.Button btn_lim;
        private System.Windows.Forms.GroupBox gbx_opciones;
        private System.Windows.Forms.Button btn_sumar;
        private System.Windows.Forms.GroupBox gbx_control;
        private System.Windows.Forms.TextBox txt_num_lim;
        private System.Windows.Forms.Label lbl_num_limite;
        private System.Windows.Forms.RadioButton rdb_impares;
        private System.Windows.Forms.RadioButton rdb_pares;
        private System.Windows.Forms.RadioButton rdb_todos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox bbx_opciones;
        private System.Windows.Forms.Button btn_detener;
        private System.Windows.Forms.Button btn_limp;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tiempo;
        private System.Windows.Forms.Timer tmr_segundos;
        private System.Windows.Forms.Label lbl_segundos;
        private System.Windows.Forms.Label lbl_minutos;
        private System.Windows.Forms.Label lbl_mili;
        private System.Windows.Forms.Timer tmr_minutos;
        private System.Windows.Forms.Timer tmr_mili;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_llenar_arreglo;
        private System.Windows.Forms.TextBox txt_lim_arreglo;
        private System.Windows.Forms.TextBox txt_tam_arreglo;
        private System.Windows.Forms.Button btn_ver_arreglo;
        private System.Windows.Forms.Button btn_lim_arre;
        private System.Windows.Forms.GroupBox gbx_arreglo;
        private System.Windows.Forms.GroupBox gbx_control_arre;
        private System.Windows.Forms.CheckBox chb_rem_may_50;
        private System.Windows.Forms.CheckBox chb_rem_men_10;
        private System.Windows.Forms.CheckBox chb_rem_pares;
        private System.Windows.Forms.GroupBox gbx_opc_arreglo;
        private System.Windows.Forms.Label lbl_conte_arreglo;
        private System.Windows.Forms.TextBox txt_cont_arre;
        private System.Windows.Forms.Label lbl_lim_random;
        private System.Windows.Forms.Label lbl_tam_arreglo;
    }
}