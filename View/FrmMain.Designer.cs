namespace BotAbrirSoftware.View
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalvarConfig = new System.Windows.Forms.Button();
            this.btnPathBlueStacks = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nUDEmuladoresSimultaneos = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nUDIntervaloMinuto = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnApagarTodosEmuladores = new System.Windows.Forms.Button();
            this.btnSalvarEmulador = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnResetar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chkEvento = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComando = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblStatusSistema = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblEmuladoresEvento = new System.Windows.Forms.Label();
            this.lblEmuladoresHabilitados = new System.Windows.Forms.Label();
            this.lblEmuladoresTotais = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPathBlueStacks = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerOpenApp = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDEmuladoresSimultaneos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDIntervaloMinuto)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalvarConfig);
            this.groupBox1.Controls.Add(this.btnPathBlueStacks);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nUDEmuladoresSimultaneos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nUDIntervaloMinuto);
            this.groupBox1.Location = new System.Drawing.Point(9, 339);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(270, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuração";
            // 
            // btnSalvarConfig
            // 
            this.btnSalvarConfig.BackColor = System.Drawing.Color.White;
            this.btnSalvarConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarConfig.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarConfig.ForeColor = System.Drawing.Color.Silver;
            this.btnSalvarConfig.Image = global::Workana_BlueStaks_Manager.Properties.Resources.icons8_save_32px;
            this.btnSalvarConfig.Location = new System.Drawing.Point(28, 135);
            this.btnSalvarConfig.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSalvarConfig.Name = "btnSalvarConfig";
            this.btnSalvarConfig.Size = new System.Drawing.Size(188, 41);
            this.btnSalvarConfig.TabIndex = 6;
            this.btnSalvarConfig.UseVisualStyleBackColor = false;
            this.btnSalvarConfig.Click += new System.EventHandler(this.btnSalvarConfig_Click);
            // 
            // btnPathBlueStacks
            // 
            this.btnPathBlueStacks.BackColor = System.Drawing.Color.White;
            this.btnPathBlueStacks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPathBlueStacks.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPathBlueStacks.ForeColor = System.Drawing.Color.Silver;
            this.btnPathBlueStacks.Image = global::Workana_BlueStaks_Manager.Properties.Resources.icons8_folder_32px;
            this.btnPathBlueStacks.Location = new System.Drawing.Point(174, 87);
            this.btnPathBlueStacks.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPathBlueStacks.Name = "btnPathBlueStacks";
            this.btnPathBlueStacks.Size = new System.Drawing.Size(59, 32);
            this.btnPathBlueStacks.TabIndex = 5;
            this.btnPathBlueStacks.UseVisualStyleBackColor = false;
            this.btnPathBlueStacks.Click += new System.EventHandler(this.btnPathBlueStacks_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Caminho BlueStacks :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(5, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Emuladores Simultâneos :";
            // 
            // nUDEmuladoresSimultaneos
            // 
            this.nUDEmuladoresSimultaneos.Location = new System.Drawing.Point(175, 59);
            this.nUDEmuladoresSimultaneos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nUDEmuladoresSimultaneos.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUDEmuladoresSimultaneos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDEmuladoresSimultaneos.Name = "nUDEmuladoresSimultaneos";
            this.nUDEmuladoresSimultaneos.Size = new System.Drawing.Size(59, 22);
            this.nUDEmuladoresSimultaneos.TabIndex = 2;
            this.nUDEmuladoresSimultaneos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Intervalo de Minutos :";
            // 
            // nUDIntervaloMinuto
            // 
            this.nUDIntervaloMinuto.Location = new System.Drawing.Point(175, 31);
            this.nUDIntervaloMinuto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nUDIntervaloMinuto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nUDIntervaloMinuto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDIntervaloMinuto.Name = "nUDIntervaloMinuto";
            this.nUDIntervaloMinuto.Size = new System.Drawing.Size(59, 22);
            this.nUDIntervaloMinuto.TabIndex = 0;
            this.nUDIntervaloMinuto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblId);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.btnApagarTodosEmuladores);
            this.groupBox2.Controls.Add(this.btnSalvarEmulador);
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Controls.Add(this.btnDeletar);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnResetar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.chkEvento);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.chkHabilitado);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtComando);
            this.groupBox2.Controls.Add(this.dataGridView);
            this.groupBox2.Location = new System.Drawing.Point(9, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(270, 322);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Emuladores";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(10, 193);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 16);
            this.lblId.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(10, 169);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 16);
            this.label18.TabIndex = 13;
            this.label18.Text = "id";
            // 
            // btnApagarTodosEmuladores
            // 
            this.btnApagarTodosEmuladores.BackColor = System.Drawing.Color.White;
            this.btnApagarTodosEmuladores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagarTodosEmuladores.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnApagarTodosEmuladores.ForeColor = System.Drawing.Color.Black;
            this.btnApagarTodosEmuladores.Location = new System.Drawing.Point(10, 270);
            this.btnApagarTodosEmuladores.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnApagarTodosEmuladores.Name = "btnApagarTodosEmuladores";
            this.btnApagarTodosEmuladores.Size = new System.Drawing.Size(90, 40);
            this.btnApagarTodosEmuladores.TabIndex = 12;
            this.btnApagarTodosEmuladores.Text = "Apagar Todos Emuladores";
            this.btnApagarTodosEmuladores.UseVisualStyleBackColor = false;
            this.btnApagarTodosEmuladores.Click += new System.EventHandler(this.btnApagarTodosEmuladores_Click);
            // 
            // btnSalvarEmulador
            // 
            this.btnSalvarEmulador.BackColor = System.Drawing.Color.White;
            this.btnSalvarEmulador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarEmulador.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarEmulador.ForeColor = System.Drawing.Color.Silver;
            this.btnSalvarEmulador.Image = global::Workana_BlueStaks_Manager.Properties.Resources.icons8_save_32px;
            this.btnSalvarEmulador.Location = new System.Drawing.Point(114, 270);
            this.btnSalvarEmulador.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSalvarEmulador.Name = "btnSalvarEmulador";
            this.btnSalvarEmulador.Size = new System.Drawing.Size(146, 40);
            this.btnSalvarEmulador.TabIndex = 11;
            this.btnSalvarEmulador.UseVisualStyleBackColor = false;
            this.btnSalvarEmulador.Click += new System.EventHandler(this.btnSalvarEmulador_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.White;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNovo.ForeColor = System.Drawing.Color.Silver;
            this.btnNovo.Image = global::Workana_BlueStaks_Manager.Properties.Resources.icons8_add_32px;
            this.btnNovo.Location = new System.Drawing.Point(225, 232);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(35, 32);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.White;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletar.ForeColor = System.Drawing.Color.Silver;
            this.btnDeletar.Image = global::Workana_BlueStaks_Manager.Properties.Resources.icons8_Remove_32px;
            this.btnDeletar.Location = new System.Drawing.Point(169, 232);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(35, 32);
            this.btnDeletar.TabIndex = 9;
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.Silver;
            this.btnCancelar.Image = global::Workana_BlueStaks_Manager.Properties.Resources.icons8_broom_32px;
            this.btnCancelar.Location = new System.Drawing.Point(114, 232);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(35, 32);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnResetar
            // 
            this.btnResetar.BackColor = System.Drawing.Color.White;
            this.btnResetar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResetar.ForeColor = System.Drawing.Color.Silver;
            this.btnResetar.Image = global::Workana_BlueStaks_Manager.Properties.Resources.icons8_reset_32px;
            this.btnResetar.Location = new System.Drawing.Point(10, 232);
            this.btnResetar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(90, 32);
            this.btnResetar.TabIndex = 7;
            this.btnResetar.UseVisualStyleBackColor = false;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(214, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Evento";
            // 
            // chkEvento
            // 
            this.chkEvento.AutoSize = true;
            this.chkEvento.Location = new System.Drawing.Point(229, 193);
            this.chkEvento.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkEvento.Name = "chkEvento";
            this.chkEvento.Size = new System.Drawing.Size(15, 14);
            this.chkEvento.TabIndex = 5;
            this.chkEvento.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(146, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Habilitado";
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Location = new System.Drawing.Point(174, 193);
            this.chkHabilitado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(15, 14);
            this.chkHabilitado.TabIndex = 3;
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(38, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Comando";
            // 
            // txtComando
            // 
            this.txtComando.Location = new System.Drawing.Point(38, 188);
            this.txtComando.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtComando.Name = "txtComando";
            this.txtComando.Size = new System.Drawing.Size(111, 22);
            this.txtComando.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(10, 22);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(250, 135);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblStatusSistema);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.lblTimer);
            this.groupBox3.Controls.Add(this.lblEmuladoresEvento);
            this.groupBox3.Controls.Add(this.lblEmuladoresHabilitados);
            this.groupBox3.Controls.Add(this.lblEmuladoresTotais);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(291, 339);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(282, 182);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // lblStatusSistema
            // 
            this.lblStatusSistema.AutoSize = true;
            this.lblStatusSistema.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatusSistema.Location = new System.Drawing.Point(189, 135);
            this.lblStatusSistema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatusSistema.Name = "lblStatusSistema";
            this.lblStatusSistema.Size = new System.Drawing.Size(14, 16);
            this.lblStatusSistema.TabIndex = 11;
            this.lblStatusSistema.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(13, 135);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 16);
            this.label17.TabIndex = 10;
            this.label17.Text = "Estado Sistema :";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.Location = new System.Drawing.Point(189, 107);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(14, 16);
            this.lblTimer.TabIndex = 9;
            this.lblTimer.Text = "0";
            // 
            // lblEmuladoresEvento
            // 
            this.lblEmuladoresEvento.AutoSize = true;
            this.lblEmuladoresEvento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmuladoresEvento.Location = new System.Drawing.Point(189, 84);
            this.lblEmuladoresEvento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmuladoresEvento.Name = "lblEmuladoresEvento";
            this.lblEmuladoresEvento.Size = new System.Drawing.Size(14, 16);
            this.lblEmuladoresEvento.TabIndex = 8;
            this.lblEmuladoresEvento.Text = "0";
            // 
            // lblEmuladoresHabilitados
            // 
            this.lblEmuladoresHabilitados.AutoSize = true;
            this.lblEmuladoresHabilitados.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmuladoresHabilitados.Location = new System.Drawing.Point(189, 57);
            this.lblEmuladoresHabilitados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmuladoresHabilitados.Name = "lblEmuladoresHabilitados";
            this.lblEmuladoresHabilitados.Size = new System.Drawing.Size(14, 16);
            this.lblEmuladoresHabilitados.TabIndex = 7;
            this.lblEmuladoresHabilitados.Text = "0";
            // 
            // lblEmuladoresTotais
            // 
            this.lblEmuladoresTotais.AutoSize = true;
            this.lblEmuladoresTotais.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmuladoresTotais.Location = new System.Drawing.Point(189, 26);
            this.lblEmuladoresTotais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmuladoresTotais.Name = "lblEmuladoresTotais";
            this.lblEmuladoresTotais.Size = new System.Drawing.Size(14, 16);
            this.lblEmuladoresTotais.TabIndex = 6;
            this.lblEmuladoresTotais.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(13, 107);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Timer  :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(13, 80);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Emuladores Evento :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(13, 57);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Emuladores Habilitado :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(13, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Emuladores Total :";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Image = global::Workana_BlueStaks_Manager.Properties.Resources.icons8_play_32px;
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciar.Location = new System.Drawing.Point(291, 62);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(282, 106);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnParar
            // 
            this.btnParar.BackColor = System.Drawing.Color.IndianRed;
            this.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnParar.ForeColor = System.Drawing.Color.White;
            this.btnParar.Image = global::Workana_BlueStaks_Manager.Properties.Resources.icons8_stop_32px;
            this.btnParar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParar.Location = new System.Drawing.Point(291, 187);
            this.btnParar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(282, 106);
            this.btnParar.TabIndex = 4;
            this.btnParar.Text = "Parar";
            this.btnParar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnParar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnParar.UseVisualStyleBackColor = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(11, 536);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "BlueStacks :";
            // 
            // lblPathBlueStacks
            // 
            this.lblPathBlueStacks.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPathBlueStacks.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPathBlueStacks.Location = new System.Drawing.Point(98, 524);
            this.lblPathBlueStacks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPathBlueStacks.Name = "lblPathBlueStacks";
            this.lblPathBlueStacks.Size = new System.Drawing.Size(475, 28);
            this.lblPathBlueStacks.TabIndex = 7;
            this.lblPathBlueStacks.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            // 
            // timerOpenApp
            // 
            this.timerOpenApp.Enabled = true;
            this.timerOpenApp.Interval = 10000;
            this.timerOpenApp.Tick += new System.EventHandler(this.timerOpenApp_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.lblPathBlueStacks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlueStacks Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDEmuladoresSimultaneos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDIntervaloMinuto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnIniciar;
        private Button btnParar;
        private Label label1;
        private NumericUpDown nUDIntervaloMinuto;
        private Button btnPathBlueStacks;
        private Label label3;
        private Label label2;
        private NumericUpDown nUDEmuladoresSimultaneos;
        private Label label4;
        private Label lblPathBlueStacks;
        private Button btnSalvarConfig;
        private DataGridView dataGridView;
        private Label label7;
        private CheckBox chkEvento;
        private Label label6;
        private CheckBox chkHabilitado;
        private Label label5;
        private TextBox txtComando;
        private Button btnNovo;
        private Button btnDeletar;
        private Button btnCancelar;
        private Button btnResetar;
        private Button btnSalvarEmulador;
        private Button btnApagarTodosEmuladores;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label lblTimer;
        private Label lblEmuladoresEvento;
        private Label lblEmuladoresHabilitados;
        private Label lblEmuladoresTotais;
        private Label label11;
        private Label lblStatusSistema;
        private Label label17;
        private Label lblId;
        private Label label18;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerOpenApp;
    }
}