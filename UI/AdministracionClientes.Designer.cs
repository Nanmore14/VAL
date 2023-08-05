namespace UI
{
    partial class AdministracionClientes
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
            lblNombreCliente = new Label();
            txtNombreCliente = new TextBox();
            txtNumero = new TextBox();
            label1 = new Label();
            txtCorreo = new TextBox();
            label2 = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnAnular = new Button();
            gridClientes = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            SuspendLayout();
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(26, 45);
            lblNombreCliente.Margin = new Padding(4, 0, 4, 0);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(169, 29);
            lblNombreCliente.TabIndex = 0;
            lblNombreCliente.Text = "Nombre del Cliente";
            lblNombreCliente.Click += lblNombreCliente_Click;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(26, 78);
            txtNombreCliente.Margin = new Padding(4, 4, 4, 4);
            txtNombreCliente.MaxLength = 200;
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(712, 37);
            txtNombreCliente.TabIndex = 1;
            txtNombreCliente.TextChanged += txtNombreCliente_TextChanged;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(26, 180);
            txtNumero.Margin = new Padding(4, 4, 4, 4);
            txtNumero.MaxLength = 8;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(712, 37);
            txtNumero.TabIndex = 3;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 146);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 29);
            label1.TabIndex = 2;
            label1.Text = "Número de teléfono";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(26, 291);
            txtCorreo.Margin = new Padding(4, 4, 4, 4);
            txtCorreo.MaxLength = 200;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(712, 37);
            txtCorreo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 258);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 29);
            label2.TabIndex = 4;
            label2.Text = "Correo";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(26, 381);
            btnNuevo.Margin = new Padding(4, 4, 4, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(129, 42);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(194, 381);
            btnGuardar.Margin = new Padding(4, 4, 4, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(129, 42);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnAnular
            // 
            btnAnular.Location = new Point(369, 381);
            btnAnular.Margin = new Padding(4, 4, 4, 4);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(129, 42);
            btnAnular.TabIndex = 8;
            btnAnular.Text = "Anular";
            btnAnular.UseVisualStyleBackColor = true;
            btnAnular.Click += btnAnular_Click;
            // 
            // gridClientes
            // 
            gridClientes.AllowUserToAddRows = false;
            gridClientes.AllowUserToDeleteRows = false;
            gridClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridClientes.BackgroundColor = SystemColors.ButtonHighlight;
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.GridColor = SystemColors.ActiveCaptionText;
            gridClientes.Location = new Point(29, 496);
            gridClientes.Margin = new Padding(4, 4, 4, 4);
            gridClientes.MultiSelect = false;
            gridClientes.Name = "gridClientes";
            gridClientes.ReadOnly = true;
            gridClientes.RowHeadersVisible = false;
            gridClientes.RowHeadersWidth = 51;
            gridClientes.RowTemplate.Height = 29;
            gridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridClientes.Size = new Size(711, 439);
            gridClientes.TabIndex = 9;
            gridClientes.CellClick += gridClientes_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 463);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(167, 29);
            label3.TabIndex = 10;
            label3.Text = "Listado de Clientes";
            // 
            // AdministracionClientes
            // 
            AutoScaleDimensions = new SizeF(11F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(777, 953);
            Controls.Add(label3);
            Controls.Add(gridClientes);
            Controls.Add(btnAnular);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtCorreo);
            Controls.Add(label2);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Controls.Add(txtNombreCliente);
            Controls.Add(lblNombreCliente);
            Font = new Font("Viner Hand ITC", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Navy;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "AdministracionClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdministracionClientes";
            TransparencyKey = Color.Red;
            Load += AdministracionClientes_Load;
            ((System.ComponentModel.ISupportInitialize)gridClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreCliente;
        private TextBox txtNombreCliente;
        private TextBox txtNumero;
        private Label label1;
        private TextBox txtCorreo;
        private Label label2;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnAnular;
        private DataGridView gridClientes;
        private Label label3;
    }
}