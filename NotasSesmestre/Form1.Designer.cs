namespace NotasSesmestre
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DgNotas = new System.Windows.Forms.DataGridView();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnMenuVestical = new System.Windows.Forms.Panel();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.BtGuardar = new System.Windows.Forms.Button();
            this.LbFirma = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtAgregar = new System.Windows.Forms.Button();
            this.BtSalir = new System.Windows.Forms.Button();
            this.BtPromedio = new System.Windows.Forms.Button();
            this.PnBarraTitulo = new System.Windows.Forms.Panel();
            this.LbMensajeDatos = new System.Windows.Forms.Label();
            this.LbSaludo = new System.Windows.Forms.Label();
            this.LbMateria = new System.Windows.Forms.Label();
            this.LbNota1 = new System.Windows.Forms.Label();
            this.LbNota2 = new System.Windows.Forms.Label();
            this.LbNota3 = new System.Windows.Forms.Label();
            this.TxMateria = new System.Windows.Forms.TextBox();
            this.TxNota1 = new System.Windows.Forms.TextBox();
            this.TxNota2 = new System.Windows.Forms.TextBox();
            this.TxNota3 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LbAdvertencia = new System.Windows.Forms.Label();
            this.LbGano = new System.Windows.Forms.Label();
            this.LbOjops = new System.Windows.Forms.Label();
            this.LbPerdio = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgNotas)).BeginInit();
            this.PnMenuVestical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // DgNotas
            // 
            this.DgNotas.AllowUserToAddRows = false;
            this.DgNotas.AllowUserToDeleteRows = false;
            this.DgNotas.BackgroundColor = System.Drawing.Color.DarkRed;
            this.DgNotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgNotas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgNotas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgNotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgNotas.ColumnHeadersHeight = 25;
            this.DgNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Materia,
            this.Nota1,
            this.Nota2,
            this.Nota3,
            this.Promedio});
            this.DgNotas.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DgNotas.Location = new System.Drawing.Point(199, 109);
            this.DgNotas.Name = "DgNotas";
            this.DgNotas.ReadOnly = true;
            this.DgNotas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DgNotas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgNotas.Size = new System.Drawing.Size(573, 183);
            this.DgNotas.TabIndex = 0;
            this.DgNotas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgNotas_CellDoubleClick);
            // 
            // Materia
            // 
            this.Materia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            // 
            // Nota1
            // 
            this.Nota1.HeaderText = "Nota 1";
            this.Nota1.Name = "Nota1";
            this.Nota1.ReadOnly = true;
            this.Nota1.Width = 80;
            // 
            // Nota2
            // 
            this.Nota2.HeaderText = "Nota 2";
            this.Nota2.Name = "Nota2";
            this.Nota2.ReadOnly = true;
            this.Nota2.Width = 80;
            // 
            // Nota3
            // 
            this.Nota3.HeaderText = "Nota 3";
            this.Nota3.Name = "Nota3";
            this.Nota3.ReadOnly = true;
            this.Nota3.Width = 80;
            // 
            // Promedio
            // 
            this.Promedio.HeaderText = "Promedio";
            this.Promedio.Name = "Promedio";
            this.Promedio.ReadOnly = true;
            this.Promedio.Width = 80;
            // 
            // PnMenuVestical
            // 
            this.PnMenuVestical.BackColor = System.Drawing.Color.DarkRed;
            this.PnMenuVestical.Controls.Add(this.BtEliminar);
            this.PnMenuVestical.Controls.Add(this.BtGuardar);
            this.PnMenuVestical.Controls.Add(this.LbFirma);
            this.PnMenuVestical.Controls.Add(this.pictureBox1);
            this.PnMenuVestical.Controls.Add(this.BtAgregar);
            this.PnMenuVestical.Controls.Add(this.BtSalir);
            this.PnMenuVestical.Controls.Add(this.BtPromedio);
            this.PnMenuVestical.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnMenuVestical.Location = new System.Drawing.Point(0, 0);
            this.PnMenuVestical.Name = "PnMenuVestical";
            this.PnMenuVestical.Size = new System.Drawing.Size(200, 315);
            this.PnMenuVestical.TabIndex = 3;
            // 
            // BtEliminar
            // 
            this.BtEliminar.FlatAppearance.BorderSize = 0;
            this.BtEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.BtEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEliminar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEliminar.ForeColor = System.Drawing.Color.White;
            this.BtEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtEliminar.Image")));
            this.BtEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtEliminar.Location = new System.Drawing.Point(3, 191);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(190, 35);
            this.BtEliminar.TabIndex = 9;
            this.BtEliminar.Text = "&Eliminar";
            this.BtEliminar.UseVisualStyleBackColor = true;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // BtGuardar
            // 
            this.BtGuardar.FlatAppearance.BorderSize = 0;
            this.BtGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.BtGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtGuardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtGuardar.ForeColor = System.Drawing.Color.White;
            this.BtGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtGuardar.Image")));
            this.BtGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtGuardar.Location = new System.Drawing.Point(3, 150);
            this.BtGuardar.Name = "BtGuardar";
            this.BtGuardar.Size = new System.Drawing.Size(190, 35);
            this.BtGuardar.TabIndex = 8;
            this.BtGuardar.Text = "&Guardar";
            this.BtGuardar.UseVisualStyleBackColor = true;
            this.BtGuardar.Click += new System.EventHandler(this.BtGuardar_Click);
            // 
            // LbFirma
            // 
            this.LbFirma.AutoSize = true;
            this.LbFirma.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFirma.ForeColor = System.Drawing.Color.White;
            this.LbFirma.Location = new System.Drawing.Point(79, 24);
            this.LbFirma.Name = "LbFirma";
            this.LbFirma.Size = new System.Drawing.Size(114, 56);
            this.LbFirma.TabIndex = 7;
            this.LbFirma.Text = "Carlos E. \r\nZuñiga M.";
            this.LbFirma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 68);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // BtAgregar
            // 
            this.BtAgregar.FlatAppearance.BorderSize = 0;
            this.BtAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.BtAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAgregar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAgregar.ForeColor = System.Drawing.Color.White;
            this.BtAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtAgregar.Image")));
            this.BtAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAgregar.Location = new System.Drawing.Point(3, 109);
            this.BtAgregar.Name = "BtAgregar";
            this.BtAgregar.Size = new System.Drawing.Size(190, 35);
            this.BtAgregar.TabIndex = 5;
            this.BtAgregar.Text = "&Agregar";
            this.BtAgregar.UseVisualStyleBackColor = true;
            this.BtAgregar.Click += new System.EventHandler(this.BtAgregar_Click);
            // 
            // BtSalir
            // 
            this.BtSalir.FlatAppearance.BorderSize = 0;
            this.BtSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.BtSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSalir.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSalir.ForeColor = System.Drawing.Color.White;
            this.BtSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtSalir.Image")));
            this.BtSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtSalir.Location = new System.Drawing.Point(0, 273);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(197, 35);
            this.BtSalir.TabIndex = 4;
            this.BtSalir.Text = "&Salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // BtPromedio
            // 
            this.BtPromedio.FlatAppearance.BorderSize = 0;
            this.BtPromedio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.BtPromedio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtPromedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtPromedio.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPromedio.ForeColor = System.Drawing.Color.White;
            this.BtPromedio.Image = ((System.Drawing.Image)(resources.GetObject("BtPromedio.Image")));
            this.BtPromedio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtPromedio.Location = new System.Drawing.Point(0, 232);
            this.BtPromedio.Name = "BtPromedio";
            this.BtPromedio.Size = new System.Drawing.Size(197, 35);
            this.BtPromedio.TabIndex = 3;
            this.BtPromedio.Text = "Promedio";
            this.BtPromedio.UseVisualStyleBackColor = true;
            this.BtPromedio.Click += new System.EventHandler(this.BtPromedio_Click);
            // 
            // PnBarraTitulo
            // 
            this.PnBarraTitulo.BackColor = System.Drawing.Color.DarkRed;
            this.PnBarraTitulo.Controls.Add(this.LbMensajeDatos);
            this.PnBarraTitulo.Controls.Add(this.LbSaludo);
            this.PnBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnBarraTitulo.Location = new System.Drawing.Point(200, 0);
            this.PnBarraTitulo.Name = "PnBarraTitulo";
            this.PnBarraTitulo.Size = new System.Drawing.Size(877, 43);
            this.PnBarraTitulo.TabIndex = 4;
            this.PnBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnBarraTitulo_MouseDown_1);
            // 
            // LbMensajeDatos
            // 
            this.LbMensajeDatos.AutoSize = true;
            this.LbMensajeDatos.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMensajeDatos.ForeColor = System.Drawing.Color.White;
            this.LbMensajeDatos.Location = new System.Drawing.Point(652, 9);
            this.LbMensajeDatos.Name = "LbMensajeDatos";
            this.LbMensajeDatos.Size = new System.Drawing.Size(163, 21);
            this.LbMensajeDatos.TabIndex = 1;
            this.LbMensajeDatos.Text = "EDICIÒN DE DATOS";
            // 
            // LbSaludo
            // 
            this.LbSaludo.AutoSize = true;
            this.LbSaludo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSaludo.ForeColor = System.Drawing.Color.White;
            this.LbSaludo.Location = new System.Drawing.Point(82, 9);
            this.LbSaludo.Name = "LbSaludo";
            this.LbSaludo.Size = new System.Drawing.Size(368, 21);
            this.LbSaludo.TabIndex = 0;
            this.LbSaludo.Text = "MATERIAS CURSADAS DURANTE EL SEMESTRE";
            this.LbSaludo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbMateria
            // 
            this.LbMateria.AutoSize = true;
            this.LbMateria.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMateria.ForeColor = System.Drawing.Color.White;
            this.LbMateria.Location = new System.Drawing.Point(817, 116);
            this.LbMateria.Name = "LbMateria";
            this.LbMateria.Size = new System.Drawing.Size(73, 21);
            this.LbMateria.TabIndex = 5;
            this.LbMateria.Text = "Materia:";
            // 
            // LbNota1
            // 
            this.LbNota1.AutoSize = true;
            this.LbNota1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNota1.ForeColor = System.Drawing.Color.White;
            this.LbNota1.Location = new System.Drawing.Point(817, 156);
            this.LbNota1.Name = "LbNota1";
            this.LbNota1.Size = new System.Drawing.Size(66, 21);
            this.LbNota1.TabIndex = 6;
            this.LbNota1.Text = "Nota 1:";
            // 
            // LbNota2
            // 
            this.LbNota2.AutoSize = true;
            this.LbNota2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNota2.ForeColor = System.Drawing.Color.White;
            this.LbNota2.Location = new System.Drawing.Point(817, 197);
            this.LbNota2.Name = "LbNota2";
            this.LbNota2.Size = new System.Drawing.Size(66, 21);
            this.LbNota2.TabIndex = 7;
            this.LbNota2.Text = "Nota 2:";
            // 
            // LbNota3
            // 
            this.LbNota3.AutoSize = true;
            this.LbNota3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNota3.ForeColor = System.Drawing.Color.White;
            this.LbNota3.Location = new System.Drawing.Point(817, 237);
            this.LbNota3.Name = "LbNota3";
            this.LbNota3.Size = new System.Drawing.Size(66, 21);
            this.LbNota3.TabIndex = 8;
            this.LbNota3.Text = "Nota 3:";
            // 
            // TxMateria
            // 
            this.TxMateria.Location = new System.Drawing.Point(931, 116);
            this.TxMateria.Name = "TxMateria";
            this.TxMateria.Size = new System.Drawing.Size(100, 20);
            this.TxMateria.TabIndex = 9;
            // 
            // TxNota1
            // 
            this.TxNota1.Location = new System.Drawing.Point(931, 156);
            this.TxNota1.Name = "TxNota1";
            this.TxNota1.Size = new System.Drawing.Size(100, 20);
            this.TxNota1.TabIndex = 10;
            // 
            // TxNota2
            // 
            this.TxNota2.Location = new System.Drawing.Point(931, 197);
            this.TxNota2.Name = "TxNota2";
            this.TxNota2.Size = new System.Drawing.Size(100, 20);
            this.TxNota2.TabIndex = 11;
            // 
            // TxNota3
            // 
            this.TxNota3.Location = new System.Drawing.Point(931, 237);
            this.TxNota3.Name = "TxNota3";
            this.TxNota3.Size = new System.Drawing.Size(100, 20);
            this.TxNota3.TabIndex = 12;
            // 
            // LbAdvertencia
            // 
            this.LbAdvertencia.AutoSize = true;
            this.LbAdvertencia.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAdvertencia.ForeColor = System.Drawing.Color.White;
            this.LbAdvertencia.Location = new System.Drawing.Point(841, 59);
            this.LbAdvertencia.Name = "LbAdvertencia";
            this.LbAdvertencia.Size = new System.Drawing.Size(215, 38);
            this.LbAdvertencia.TabIndex = 13;
            this.LbAdvertencia.Text = "Recuerde ingresar los numeros \r\ndecimales con comas, ej 3,5 o 4,4";
            // 
            // LbGano
            // 
            this.LbGano.AutoSize = true;
            this.LbGano.BackColor = System.Drawing.Color.Transparent;
            this.LbGano.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbGano.ForeColor = System.Drawing.Color.White;
            this.LbGano.Location = new System.Drawing.Point(301, 59);
            this.LbGano.Name = "LbGano";
            this.LbGano.Size = new System.Drawing.Size(66, 28);
            this.LbGano.TabIndex = 14;
            this.LbGano.Text = "Ganó";
            this.LbGano.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbOjops
            // 
            this.LbOjops.AutoSize = true;
            this.LbOjops.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOjops.ForeColor = System.Drawing.Color.White;
            this.LbOjops.Location = new System.Drawing.Point(429, 59);
            this.LbOjops.Name = "LbOjops";
            this.LbOjops.Size = new System.Drawing.Size(185, 28);
            this.LbOjops.TabIndex = 15;
            this.LbOjops.Text = "Necesita 4 o mas";
            // 
            // LbPerdio
            // 
            this.LbPerdio.AutoSize = true;
            this.LbPerdio.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPerdio.ForeColor = System.Drawing.Color.White;
            this.LbPerdio.Location = new System.Drawing.Point(695, 59);
            this.LbPerdio.Name = "LbPerdio";
            this.LbPerdio.Size = new System.Drawing.Size(77, 28);
            this.LbPerdio.TabIndex = 16;
            this.LbPerdio.Text = "Perdió";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(373, 53);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(632, 53);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(242, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1077, 315);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.LbPerdio);
            this.Controls.Add(this.LbOjops);
            this.Controls.Add(this.LbGano);
            this.Controls.Add(this.LbAdvertencia);
            this.Controls.Add(this.TxNota3);
            this.Controls.Add(this.TxNota2);
            this.Controls.Add(this.TxNota1);
            this.Controls.Add(this.TxMateria);
            this.Controls.Add(this.LbNota3);
            this.Controls.Add(this.LbNota2);
            this.Controls.Add(this.LbNota1);
            this.Controls.Add(this.LbMateria);
            this.Controls.Add(this.PnBarraTitulo);
            this.Controls.Add(this.PnMenuVestical);
            this.Controls.Add(this.DgNotas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgNotas)).EndInit();
            this.PnMenuVestical.ResumeLayout(false);
            this.PnMenuVestical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnBarraTitulo.ResumeLayout(false);
            this.PnBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgNotas;
        private System.Windows.Forms.Panel PnMenuVestical;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promedio;
        private System.Windows.Forms.Button BtSalir;
        private System.Windows.Forms.Button BtPromedio;
        private System.Windows.Forms.Button BtAgregar;
        private System.Windows.Forms.Panel PnBarraTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LbFirma;
        private System.Windows.Forms.Label LbSaludo;
        private System.Windows.Forms.Label LbMensajeDatos;
        private System.Windows.Forms.Label LbMateria;
        private System.Windows.Forms.Label LbNota1;
        private System.Windows.Forms.Label LbNota2;
        private System.Windows.Forms.Label LbNota3;
        private System.Windows.Forms.TextBox TxMateria;
        private System.Windows.Forms.TextBox TxNota1;
        private System.Windows.Forms.TextBox TxNota2;
        private System.Windows.Forms.TextBox TxNota3;
        private System.Windows.Forms.Button BtGuardar;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label LbAdvertencia;
        private System.Windows.Forms.Label LbGano;
        private System.Windows.Forms.Label LbOjops;
        private System.Windows.Forms.Label LbPerdio;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

