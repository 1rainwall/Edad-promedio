namespace Ejercicio_2
{
    partial class Form1
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
            this.txtbox_edad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.txtbox_prom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbox_edad
            // 
            this.txtbox_edad.Location = new System.Drawing.Point(154, 49);
            this.txtbox_edad.Name = "txtbox_edad";
            this.txtbox_edad.Size = new System.Drawing.Size(204, 20);
            this.txtbox_edad.TabIndex = 0;
            this.txtbox_edad.TextChanged += new System.EventHandler(this.txtbox_edad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite su edad";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(117, 143);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(114, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "Pruebe su edad";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(251, 143);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(120, 23);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Cerrar ventana";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txtbox_prom
            // 
            this.txtbox_prom.Location = new System.Drawing.Point(154, 106);
            this.txtbox_prom.Name = "txtbox_prom";
            this.txtbox_prom.Size = new System.Drawing.Size(204, 20);
            this.txtbox_prom.TabIndex = 4;
            this.txtbox_prom.TextChanged += new System.EventHandler(this.txtbox_prom_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite la edad promedio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 207);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_prom);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_edad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_edad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txtbox_prom;
        private System.Windows.Forms.Label label2;
    }
}

