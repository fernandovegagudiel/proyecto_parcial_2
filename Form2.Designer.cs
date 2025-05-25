namespace Minicraft
{
    partial class Form2
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
            buttonInicio = new Button();
            textBoxUser = new TextBox();
            textBoxContraseña = new TextBox();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // buttonInicio
            // 
            buttonInicio.Location = new Point(252, 219);
            buttonInicio.Name = "buttonInicio";
            buttonInicio.Size = new Size(94, 29);
            buttonInicio.TabIndex = 0;
            buttonInicio.Text = "Inicio Sesion";
            buttonInicio.UseVisualStyleBackColor = true;
            buttonInicio.Click += buttonInicio_Click;
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(201, 118);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(326, 27);
            textBoxUser.TabIndex = 1;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(201, 162);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.PasswordChar = '*';
            textBoxContraseña.Size = new Size(326, 27);
            textBoxContraseña.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(405, 219);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.minecraft_world_scenery_desktop_wallpaper_preview;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrar);
            Controls.Add(textBoxContraseña);
            Controls.Add(textBoxUser);
            Controls.Add(buttonInicio);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonInicio;
        private TextBox textBoxUser;
        private TextBox textBoxContraseña;
        private Button button1;
        private Button btnRegistrar;
    }
}