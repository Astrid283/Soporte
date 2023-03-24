namespace Examen_IIParcial
{
    partial class TicketsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TipoSoporteTextBox = new System.Windows.Forms.TextBox();
            this.CodigoSoporteTextBox = new System.Windows.Forms.TextBox();
            this.NombreClienteLabel = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.TipoSoporteLabel = new System.Windows.Forms.Label();
            this.DescripcionSolicitudTextBox = new System.Windows.Forms.TextBox();
            this.CodigoSoporteLabel = new System.Windows.Forms.Label();
            this.DescripcionSolicitudLabel = new System.Windows.Forms.Label();
            this.DescripcionRespuestalabel = new System.Windows.Forms.Label();
            this.DescripcionRespuestaTextBox = new System.Windows.Forms.TextBox();
            this.TicketDataGridView = new System.Windows.Forms.DataGridView();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.DescuentoTextBox = new System.Windows.Forms.TextBox();
            this.DescuentoLabel = new System.Windows.Forms.Label();
            this.ISVTextBox = new System.Windows.Forms.TextBox();
            this.ISVLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FechaDateTimePicker);
            this.groupBox1.Controls.Add(this.FechaLabel);
            this.groupBox1.Controls.Add(this.UsuarioTextBox);
            this.groupBox1.Controls.Add(this.UsuarioLabel);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1156, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F);
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(943, 9);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(116, 25);
            this.FechaDateTimePicker.TabIndex = 3;
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLabel.Location = new System.Drawing.Point(885, 17);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(50, 17);
            this.FechaLabel.TabIndex = 2;
            this.FechaLabel.Text = "Fecha";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTextBox.Location = new System.Drawing.Point(133, 14);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.ReadOnly = true;
            this.UsuarioTextBox.Size = new System.Drawing.Size(241, 25);
            this.UsuarioTextBox.TabIndex = 1;
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.Location = new System.Drawing.Point(12, 20);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(115, 17);
            this.UsuarioLabel.TabIndex = 0;
            this.UsuarioLabel.Text = "Correo Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TipoSoporteTextBox);
            this.groupBox2.Controls.Add(this.CodigoSoporteTextBox);
            this.groupBox2.Controls.Add(this.NombreClienteLabel);
            this.groupBox2.Controls.Add(this.NombreTextBox);
            this.groupBox2.Controls.Add(this.TipoSoporteLabel);
            this.groupBox2.Controls.Add(this.DescripcionSolicitudTextBox);
            this.groupBox2.Controls.Add(this.CodigoSoporteLabel);
            this.groupBox2.Controls.Add(this.DescripcionSolicitudLabel);
            this.groupBox2.Controls.Add(this.DescripcionRespuestalabel);
            this.groupBox2.Controls.Add(this.DescripcionRespuestaTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1156, 100);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // TipoSoporteTextBox
            // 
            this.TipoSoporteTextBox.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoSoporteTextBox.Location = new System.Drawing.Point(793, 19);
            this.TipoSoporteTextBox.Name = "TipoSoporteTextBox";
            this.TipoSoporteTextBox.ReadOnly = true;
            this.TipoSoporteTextBox.Size = new System.Drawing.Size(267, 25);
            this.TipoSoporteTextBox.TabIndex = 24;
            // 
            // CodigoSoporteTextBox
            // 
            this.CodigoSoporteTextBox.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoSoporteTextBox.Location = new System.Drawing.Point(480, 19);
            this.CodigoSoporteTextBox.Name = "CodigoSoporteTextBox";
            this.CodigoSoporteTextBox.Size = new System.Drawing.Size(190, 25);
            this.CodigoSoporteTextBox.TabIndex = 21;
            this.CodigoSoporteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodigoSoporteTextBox_KeyPress);
            // 
            // NombreClienteLabel
            // 
            this.NombreClienteLabel.AccessibleName = "";
            this.NombreClienteLabel.AutoSize = true;
            this.NombreClienteLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreClienteLabel.Location = new System.Drawing.Point(13, 27);
            this.NombreClienteLabel.Name = "NombreClienteLabel";
            this.NombreClienteLabel.Size = new System.Drawing.Size(64, 17);
            this.NombreClienteLabel.TabIndex = 0;
            this.NombreClienteLabel.Text = "Nombre";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTextBox.Location = new System.Drawing.Point(83, 19);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(258, 25);
            this.NombreTextBox.TabIndex = 20;
            // 
            // TipoSoporteLabel
            // 
            this.TipoSoporteLabel.AccessibleName = "";
            this.TipoSoporteLabel.AutoSize = true;
            this.TipoSoporteLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoSoporteLabel.Location = new System.Drawing.Point(691, 27);
            this.TipoSoporteLabel.Name = "TipoSoporteLabel";
            this.TipoSoporteLabel.Size = new System.Drawing.Size(96, 17);
            this.TipoSoporteLabel.TabIndex = 2;
            this.TipoSoporteLabel.Text = "Tipo Soporte";
            // 
            // DescripcionSolicitudTextBox
            // 
            this.DescripcionSolicitudTextBox.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionSolicitudTextBox.Location = new System.Drawing.Point(762, 66);
            this.DescripcionSolicitudTextBox.Name = "DescripcionSolicitudTextBox";
            this.DescripcionSolicitudTextBox.Size = new System.Drawing.Size(241, 25);
            this.DescripcionSolicitudTextBox.TabIndex = 9;
            this.DescripcionSolicitudTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescripcionSolicitudTextBox_KeyPress);
            // 
            // CodigoSoporteLabel
            // 
            this.CodigoSoporteLabel.AccessibleName = "";
            this.CodigoSoporteLabel.AutoSize = true;
            this.CodigoSoporteLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoSoporteLabel.Location = new System.Drawing.Point(362, 27);
            this.CodigoSoporteLabel.Name = "CodigoSoporteLabel";
            this.CodigoSoporteLabel.Size = new System.Drawing.Size(112, 17);
            this.CodigoSoporteLabel.TabIndex = 5;
            this.CodigoSoporteLabel.Text = "Codigo Soporte";
            // 
            // DescripcionSolicitudLabel
            // 
            this.DescripcionSolicitudLabel.AccessibleName = "";
            this.DescripcionSolicitudLabel.AutoSize = true;
            this.DescripcionSolicitudLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionSolicitudLabel.Location = new System.Drawing.Point(576, 74);
            this.DescripcionSolicitudLabel.Name = "DescripcionSolicitudLabel";
            this.DescripcionSolicitudLabel.Size = new System.Drawing.Size(156, 17);
            this.DescripcionSolicitudLabel.TabIndex = 8;
            this.DescripcionSolicitudLabel.Text = "Descripcion Solicitud";
            // 
            // DescripcionRespuestalabel
            // 
            this.DescripcionRespuestalabel.AccessibleName = "";
            this.DescripcionRespuestalabel.AutoSize = true;
            this.DescripcionRespuestalabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionRespuestalabel.Location = new System.Drawing.Point(116, 74);
            this.DescripcionRespuestalabel.Name = "DescripcionRespuestalabel";
            this.DescripcionRespuestalabel.Size = new System.Drawing.Size(165, 17);
            this.DescripcionRespuestalabel.TabIndex = 6;
            this.DescripcionRespuestalabel.Text = "Descripcion Respuesta";
            // 
            // DescripcionRespuestaTextBox
            // 
            this.DescripcionRespuestaTextBox.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionRespuestaTextBox.Location = new System.Drawing.Point(287, 66);
            this.DescripcionRespuestaTextBox.Name = "DescripcionRespuestaTextBox";
            this.DescripcionRespuestaTextBox.Size = new System.Drawing.Size(241, 25);
            this.DescripcionRespuestaTextBox.TabIndex = 7;
            // 
            // TicketDataGridView
            // 
            this.TicketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketDataGridView.Location = new System.Drawing.Point(1, 167);
            this.TicketDataGridView.Name = "TicketDataGridView";
            this.TicketDataGridView.Size = new System.Drawing.Size(1156, 225);
            this.TicketDataGridView.TabIndex = 27;
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioTextBox.Location = new System.Drawing.Point(878, 413);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(122, 25);
            this.PrecioTextBox.TabIndex = 35;
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F);
            this.PrecioLabel.Location = new System.Drawing.Point(828, 417);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(52, 17);
            this.PrecioLabel.TabIndex = 34;
            this.PrecioLabel.Text = "Precio";
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalTextBox.Location = new System.Drawing.Point(684, 413);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(122, 25);
            this.SubTotalTextBox.TabIndex = 33;
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F);
            this.SubTotalLabel.Location = new System.Drawing.Point(609, 417);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(69, 17);
            this.SubTotalLabel.TabIndex = 32;
            this.SubTotalLabel.Text = "SubTotal";
            // 
            // DescuentoTextBox
            // 
            this.DescuentoTextBox.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescuentoTextBox.Location = new System.Drawing.Point(474, 413);
            this.DescuentoTextBox.Name = "DescuentoTextBox";
            this.DescuentoTextBox.Size = new System.Drawing.Size(122, 25);
            this.DescuentoTextBox.TabIndex = 31;
            // 
            // DescuentoLabel
            // 
            this.DescuentoLabel.AutoSize = true;
            this.DescuentoLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F);
            this.DescuentoLabel.Location = new System.Drawing.Point(388, 417);
            this.DescuentoLabel.Name = "DescuentoLabel";
            this.DescuentoLabel.Size = new System.Drawing.Size(80, 17);
            this.DescuentoLabel.TabIndex = 30;
            this.DescuentoLabel.Text = "Descuento";
            // 
            // ISVTextBox
            // 
            this.ISVTextBox.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISVTextBox.Location = new System.Drawing.Point(244, 413);
            this.ISVTextBox.Name = "ISVTextBox";
            this.ISVTextBox.ReadOnly = true;
            this.ISVTextBox.Size = new System.Drawing.Size(122, 25);
            this.ISVTextBox.TabIndex = 29;
            // 
            // ISVLabel
            // 
            this.ISVLabel.AutoSize = true;
            this.ISVLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F);
            this.ISVLabel.Location = new System.Drawing.Point(204, 416);
            this.ISVLabel.Name = "ISVLabel";
            this.ISVLabel.Size = new System.Drawing.Size(34, 17);
            this.ISVLabel.TabIndex = 28;
            this.ISVLabel.Text = "ISV";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextBox.Location = new System.Drawing.Point(62, 414);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(122, 25);
            this.TotalTextBox.TabIndex = 38;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F);
            this.TotalLabel.Location = new System.Drawing.Point(12, 417);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(44, 17);
            this.TotalLabel.TabIndex = 37;
            this.TotalLabel.Text = "Total";
            // 
            // TicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 450);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.PrecioLabel);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.SubTotalLabel);
            this.Controls.Add(this.DescuentoTextBox);
            this.Controls.Add(this.DescuentoLabel);
            this.Controls.Add(this.ISVTextBox);
            this.Controls.Add(this.ISVLabel);
            this.Controls.Add(this.TicketDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TicketsForm";
            this.Text = "TicketsForm";
            this.Load += new System.EventHandler(this.TicketsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TipoSoporteTextBox;
        private System.Windows.Forms.TextBox CodigoSoporteTextBox;
        private System.Windows.Forms.Label NombreClienteLabel;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label TipoSoporteLabel;
        private System.Windows.Forms.TextBox DescripcionSolicitudTextBox;
        private System.Windows.Forms.Label CodigoSoporteLabel;
        private System.Windows.Forms.Label DescripcionSolicitudLabel;
        private System.Windows.Forms.Label DescripcionRespuestalabel;
        private System.Windows.Forms.TextBox DescripcionRespuestaTextBox;
        private System.Windows.Forms.DataGridView TicketDataGridView;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Label PrecioLabel;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.TextBox DescuentoTextBox;
        private System.Windows.Forms.Label DescuentoLabel;
        private System.Windows.Forms.TextBox ISVTextBox;
        private System.Windows.Forms.Label ISVLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label TotalLabel;
    }
}