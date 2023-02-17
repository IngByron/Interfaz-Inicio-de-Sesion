namespace CapaPresentacion
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBoxUsuario = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLineTextBoxContrasena = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLineTextBoxUsuario = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaImageButtonSalir = new Guna.UI.WinForms.GunaImageButton();
            this.gunaLabelIniciarSesion = new Guna.UI.WinForms.GunaLabel();
            this.gunaButtonIniciarSesion = new Guna.UI.WinForms.GunaButton();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 20;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaElipsePanel1.BackgroundImage")));
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaElipsePanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaElipsePanel1.Controls.Add(this.gunaPictureBoxUsuario);
            this.gunaElipsePanel1.Controls.Add(this.gunaLineTextBoxContrasena);
            this.gunaElipsePanel1.Controls.Add(this.gunaLineTextBoxUsuario);
            this.gunaElipsePanel1.Controls.Add(this.gunaImageButtonSalir);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabelIniciarSesion);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(-1, -1);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(503, 335);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(139, 214);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(40, 40);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaPictureBoxUsuario
            // 
            this.gunaPictureBoxUsuario.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBoxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBoxUsuario.Image")));
            this.gunaPictureBoxUsuario.Location = new System.Drawing.Point(139, 133);
            this.gunaPictureBoxUsuario.Name = "gunaPictureBoxUsuario";
            this.gunaPictureBoxUsuario.Size = new System.Drawing.Size(40, 40);
            this.gunaPictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBoxUsuario.TabIndex = 1;
            this.gunaPictureBoxUsuario.TabStop = false;
            // 
            // gunaLineTextBoxContrasena
            // 
            this.gunaLineTextBoxContrasena.Animated = true;
            this.gunaLineTextBoxContrasena.BackColor = System.Drawing.Color.LightCyan;
            this.gunaLineTextBoxContrasena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBoxContrasena.FocusedLineColor = System.Drawing.Color.Black;
            this.gunaLineTextBoxContrasena.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLineTextBoxContrasena.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLineTextBoxContrasena.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLineTextBoxContrasena.Location = new System.Drawing.Point(195, 220);
            this.gunaLineTextBoxContrasena.Name = "gunaLineTextBoxContrasena";
            this.gunaLineTextBoxContrasena.PasswordChar = '●';
            this.gunaLineTextBoxContrasena.Size = new System.Drawing.Size(160, 34);
            this.gunaLineTextBoxContrasena.TabIndex = 1;
            this.gunaLineTextBoxContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaLineTextBoxContrasena.UseSystemPasswordChar = true;
            // 
            // gunaLineTextBoxUsuario
            // 
            this.gunaLineTextBoxUsuario.Animated = true;
            this.gunaLineTextBoxUsuario.BackColor = System.Drawing.Color.LightCyan;
            this.gunaLineTextBoxUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBoxUsuario.FocusedLineColor = System.Drawing.Color.Black;
            this.gunaLineTextBoxUsuario.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLineTextBoxUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLineTextBoxUsuario.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLineTextBoxUsuario.Location = new System.Drawing.Point(195, 139);
            this.gunaLineTextBoxUsuario.Name = "gunaLineTextBoxUsuario";
            this.gunaLineTextBoxUsuario.PasswordChar = '\0';
            this.gunaLineTextBoxUsuario.Size = new System.Drawing.Size(160, 34);
            this.gunaLineTextBoxUsuario.TabIndex = 1;
            this.gunaLineTextBoxUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaImageButtonSalir
            // 
            this.gunaImageButtonSalir.BackColor = System.Drawing.Color.Transparent;
            this.gunaImageButtonSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButtonSalir.BackgroundImage")));
            this.gunaImageButtonSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageButtonSalir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButtonSalir.Image = null;
            this.gunaImageButtonSalir.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButtonSalir.Location = new System.Drawing.Point(445, 11);
            this.gunaImageButtonSalir.Name = "gunaImageButtonSalir";
            this.gunaImageButtonSalir.OnHoverImage = null;
            this.gunaImageButtonSalir.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButtonSalir.Size = new System.Drawing.Size(40, 40);
            this.gunaImageButtonSalir.TabIndex = 2;
            this.gunaImageButtonSalir.Click += new System.EventHandler(this.gunaImageButtonSalir_Click);
            // 
            // gunaLabelIniciarSesion
            // 
            this.gunaLabelIniciarSesion.AutoSize = true;
            this.gunaLabelIniciarSesion.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabelIniciarSesion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gunaLabelIniciarSesion.Location = new System.Drawing.Point(107, 76);
            this.gunaLabelIniciarSesion.Name = "gunaLabelIniciarSesion";
            this.gunaLabelIniciarSesion.Size = new System.Drawing.Size(297, 35);
            this.gunaLabelIniciarSesion.TabIndex = 1;
            this.gunaLabelIniciarSesion.Text = "DATOS DE LA SESIÓN";
            // 
            // gunaButtonIniciarSesion
            // 
            this.gunaButtonIniciarSesion.AnimationHoverSpeed = 0.07F;
            this.gunaButtonIniciarSesion.AnimationSpeed = 0.03F;
            this.gunaButtonIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.gunaButtonIniciarSesion.BaseColor = System.Drawing.Color.DeepSkyBlue;
            this.gunaButtonIniciarSesion.BorderColor = System.Drawing.Color.Transparent;
            this.gunaButtonIniciarSesion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonIniciarSesion.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButtonIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.gunaButtonIniciarSesion.Image = ((System.Drawing.Image)(resources.GetObject("gunaButtonIniciarSesion.Image")));
            this.gunaButtonIniciarSesion.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButtonIniciarSesion.Location = new System.Drawing.Point(139, 396);
            this.gunaButtonIniciarSesion.Name = "gunaButtonIniciarSesion";
            this.gunaButtonIniciarSesion.OnHoverBaseColor = System.Drawing.Color.RoyalBlue;
            this.gunaButtonIniciarSesion.OnHoverBorderColor = System.Drawing.Color.AliceBlue;
            this.gunaButtonIniciarSesion.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonIniciarSesion.OnHoverImage = null;
            this.gunaButtonIniciarSesion.OnPressedColor = System.Drawing.Color.LawnGreen;
            this.gunaButtonIniciarSesion.Radius = 25;
            this.gunaButtonIniciarSesion.Size = new System.Drawing.Size(224, 60);
            this.gunaButtonIniciarSesion.TabIndex = 1;
            this.gunaButtonIniciarSesion.Text = "INICIAR SESIÓN";
            this.gunaButtonIniciarSesion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonIniciarSesion.Click += new System.EventHandler(this.gunaButtonIniciarSesion_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(503, 551);
            this.Controls.Add(this.gunaButtonIniciarSesion);
            this.Controls.Add(this.gunaElipsePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema";
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabelIniciarSesion;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBoxUsuario;
        private Guna.UI.WinForms.GunaImageButton gunaImageButtonSalir;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBoxContrasena;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBoxUsuario;
        private Guna.UI.WinForms.GunaButton gunaButtonIniciarSesion;
    }
}

