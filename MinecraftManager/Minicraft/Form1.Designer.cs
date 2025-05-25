namespace Minicraft
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            buttonCrear = new Button();
            buttonBuscar = new Button();
            textBoxID = new TextBox();
            textBoxNombre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxNivel = new TextBox();
            textBoxFechaCreacion = new TextBox();
            buttonEliminar = new Button();
            buttonActualizar = new Button();
            dataGridView = new DataGridView();
            comboBoxTipoBloque = new ComboBox();
            label5 = new Label();
            pictureBoxBloque = new PictureBox();
            labelNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBloque).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Azure;
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Azure;
            label2.Name = "label2";
            // 
            // buttonCrear
            // 
            resources.ApplyResources(buttonCrear, "buttonCrear");
            buttonCrear.Name = "buttonCrear";
            buttonCrear.UseVisualStyleBackColor = true;
            buttonCrear.Click += buttonCrear_Click;
            // 
            // buttonBuscar
            // 
            resources.ApplyResources(buttonBuscar, "buttonBuscar");
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // textBoxID
            // 
            resources.ApplyResources(textBoxID, "textBoxID");
            textBoxID.Name = "textBoxID";
            // 
            // textBoxNombre
            // 
            resources.ApplyResources(textBoxNombre, "textBoxNombre");
            textBoxNombre.Name = "textBoxNombre";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.LightCyan;
            label3.Name = "label3";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.BackColor = Color.LightCyan;
            label4.Name = "label4";
            // 
            // textBoxNivel
            // 
            resources.ApplyResources(textBoxNivel, "textBoxNivel");
            textBoxNivel.Name = "textBoxNivel";
            // 
            // textBoxFechaCreacion
            // 
            resources.ApplyResources(textBoxFechaCreacion, "textBoxFechaCreacion");
            textBoxFechaCreacion.Name = "textBoxFechaCreacion";
            // 
            // buttonEliminar
            // 
            resources.ApplyResources(buttonEliminar, "buttonEliminar");
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonActualizar
            // 
            resources.ApplyResources(buttonActualizar, "buttonActualizar");
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.UseVisualStyleBackColor = true;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // dataGridView
            // 
            resources.ApplyResources(dataGridView, "dataGridView");
            dataGridView.BackgroundColor = Color.SeaGreen;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Name = "dataGridView";
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // comboBoxTipoBloque
            // 
            resources.ApplyResources(comboBoxTipoBloque, "comboBoxTipoBloque");
            comboBoxTipoBloque.FormattingEnabled = true;
            comboBoxTipoBloque.Items.AddRange(new object[] { resources.GetString("comboBoxTipoBloque.Items"), resources.GetString("comboBoxTipoBloque.Items1"), resources.GetString("comboBoxTipoBloque.Items2"), resources.GetString("comboBoxTipoBloque.Items3"), resources.GetString("comboBoxTipoBloque.Items4"), resources.GetString("comboBoxTipoBloque.Items5") });
            comboBoxTipoBloque.Name = "comboBoxTipoBloque";
            comboBoxTipoBloque.SelectedIndexChanged += comboBoxTipoBloque_SelectedIndexChanged;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.BackColor = Color.Azure;
            label5.Name = "label5";
            // 
            // pictureBoxBloque
            // 
            resources.ApplyResources(pictureBoxBloque, "pictureBoxBloque");
            pictureBoxBloque.BackColor = Color.FromArgb(128, 255, 255);
            pictureBoxBloque.Name = "pictureBoxBloque";
            pictureBoxBloque.TabStop = false;
            pictureBoxBloque.Click += pictureBoxBloque_Click;
            // 
            // labelNombre
            // 
            resources.ApplyResources(labelNombre, "labelNombre");
            labelNombre.BackColor = Color.White;
            labelNombre.ForeColor = SystemColors.Highlight;
            labelNombre.Name = "labelNombre";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.minecraft_world_scenery_desktop_wallpaper_preview;
            Controls.Add(labelNombre);
            Controls.Add(pictureBoxBloque);
            Controls.Add(label5);
            Controls.Add(comboBoxTipoBloque);
            Controls.Add(dataGridView);
            Controls.Add(buttonActualizar);
            Controls.Add(buttonEliminar);
            Controls.Add(textBoxFechaCreacion);
            Controls.Add(textBoxNivel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxID);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonCrear);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBloque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonCrear;
        private Button buttonBuscar;
        private TextBox textBoxID;
        private TextBox textBoxNombre;
        private Label label3;
        private Label label4;
        private TextBox textBoxNivel;
        private TextBox textBoxFechaCreacion;
        private Button buttonEliminar;
        private Button buttonActualizar;
        private DataGridView dataGridView;
        private ComboBox comboBoxTipoBloque;
        private Label label5;
        private PictureBox pictureBoxBloque;
        private Label labelNombre;
    }
}
