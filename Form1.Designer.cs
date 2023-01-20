namespace AppDatosPersonales
{
    partial class frmPrincipal
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
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.lbl_Dir = new System.Windows.Forms.Label();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.lv_Result = new System.Windows.Forms.ListView();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.txt_Dir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido.Location = new System.Drawing.Point(101, 72);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(108, 29);
            this.lbl_Apellido.TabIndex = 0;
            this.lbl_Apellido.Text = "Apellido:";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(101, 119);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(107, 29);
            this.lbl_Nombre.TabIndex = 1;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Edad.Location = new System.Drawing.Point(101, 160);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(76, 29);
            this.lbl_Edad.TabIndex = 2;
            this.lbl_Edad.Text = "Edad:";
            // 
            // lbl_Dir
            // 
            this.lbl_Dir.AutoSize = true;
            this.lbl_Dir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dir.Location = new System.Drawing.Point(101, 203);
            this.lbl_Dir.Name = "lbl_Dir";
            this.lbl_Dir.Size = new System.Drawing.Size(121, 29);
            this.lbl_Dir.TabIndex = 3;
            this.lbl_Dir.Text = "Dirección:";
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Result.Location = new System.Drawing.Point(101, 257);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(128, 29);
            this.lbl_Result.TabIndex = 4;
            this.lbl_Result.Text = "Resultado:";
            // 
            // lv_Result
            // 
            this.lv_Result.HideSelection = false;
            this.lv_Result.Location = new System.Drawing.Point(106, 303);
            this.lv_Result.Name = "lv_Result";
            this.lv_Result.Size = new System.Drawing.Size(638, 202);
            this.lv_Result.TabIndex = 5;
            this.lv_Result.UseCompatibleStateImageBehavior = false;
            this.lv_Result.View = System.Windows.Forms.View.List;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(250, 535);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(100, 41);
            this.btn_Aceptar.TabIndex = 6;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(433, 535);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(100, 41);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Apellido.Location = new System.Drawing.Point(230, 74);
            this.txt_Apellido.MaxLength = 20;
            this.txt_Apellido.Multiline = true;
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(514, 26);
            this.txt_Apellido.TabIndex = 8;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Nombre.Location = new System.Drawing.Point(230, 122);
            this.txt_Nombre.MaxLength = 20;
            this.txt_Nombre.Multiline = true;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(514, 26);
            this.txt_Nombre.TabIndex = 9;
            // 
            // txt_Edad
            // 
            this.txt_Edad.Location = new System.Drawing.Point(230, 162);
            this.txt_Edad.MaxLength = 3;
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(100, 26);
            this.txt_Edad.TabIndex = 10;
            this.txt_Edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Edad_KeyPress);
            // 
            // txt_Dir
            // 
            this.txt_Dir.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Dir.Location = new System.Drawing.Point(230, 205);
            this.txt_Dir.MaxLength = 40;
            this.txt_Dir.Multiline = true;
            this.txt_Dir.Name = "txt_Dir";
            this.txt_Dir.Size = new System.Drawing.Size(514, 26);
            this.txt_Dir.TabIndex = 11;
            this.txt_Dir.WordWrap = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(853, 619);
            this.Controls.Add(this.txt_Dir);
            this.Controls.Add(this.txt_Edad);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.lv_Result);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.lbl_Dir);
            this.Controls.Add(this.lbl_Edad);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Apellido);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Personales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Edad;
        private System.Windows.Forms.Label lbl_Dir;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.ListView lv_Result;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.TextBox txt_Dir;
    }
}

