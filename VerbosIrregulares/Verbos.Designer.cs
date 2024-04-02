namespace VerbosIrregulares
{
    partial class Verbos
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblVerb = new System.Windows.Forms.Label();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(160, 312);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(138, 87);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "EMPEZAR";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(440, 312);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(134, 91);
            this.btnFinish.TabIndex = 1;
            this.btnFinish.Text = "TERMINAR";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click_1);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(190, 199);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(316, 38);
            this.txtAnswer.TabIndex = 2;
            this.txtAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnswer_KeyDown_1);
            // 
            // lblVerb
            // 
            this.lblVerb.AutoSize = true;
            this.lblVerb.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerb.Location = new System.Drawing.Point(203, 45);
            this.lblVerb.Name = "lblVerb";
            this.lblVerb.Size = new System.Drawing.Size(150, 41);
            this.lblVerb.TabIndex = 3;
            this.lblVerb.Text = "label1";
            this.lblVerb.Visible = false;
            // 
            // txtMeaning
            // 
            this.txtMeaning.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeaning.Location = new System.Drawing.Point(190, 129);
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(316, 38);
            this.txtMeaning.TabIndex = 4;
            this.txtMeaning.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMeaning_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "PAST SIMPLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "MEANING";
            // 
            // Verbos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 491);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMeaning);
            this.Controls.Add(this.lblVerb);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnStart);
            this.Name = "Verbos";
            this.Text = "Verbos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblVerb;
        private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

