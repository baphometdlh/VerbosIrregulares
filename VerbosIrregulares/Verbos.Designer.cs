﻿namespace VerbosIrregulares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verbos));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblVerb = new System.Windows.Forms.Label();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelVerb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCantidadFallos = new System.Windows.Forms.Label();
            this.labelCantidadAciertos = new System.Windows.Forms.Label();
            this.labelCantidadVerbos = new System.Windows.Forms.Label();
            this.labelFallo = new System.Windows.Forms.Label();
            this.labelAcierto = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textPParticiple = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(157, 282);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 71);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "EMPEZAR";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(327, 279);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(100, 74);
            this.btnFinish.TabIndex = 1;
            this.btnFinish.Text = "TERMINAR";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click_1);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(157, 162);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(238, 32);
            this.txtAnswer.TabIndex = 2;
            this.txtAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnswer_KeyDown_1);
            // 
            // lblVerb
            // 
            this.lblVerb.AutoSize = true;
            this.lblVerb.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerb.Location = new System.Drawing.Point(167, 37);
            this.lblVerb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVerb.Name = "lblVerb";
            this.lblVerb.Size = new System.Drawing.Size(123, 34);
            this.lblVerb.TabIndex = 3;
            this.lblVerb.Text = "label1";
            this.lblVerb.Visible = false;
            // 
            // txtMeaning
            // 
            this.txtMeaning.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeaning.Location = new System.Drawing.Point(157, 105);
            this.txtMeaning.Margin = new System.Windows.Forms.Padding(2);
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(238, 32);
            this.txtMeaning.TabIndex = 4;
            this.txtMeaning.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMeaning_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "PAST SIMPLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "MEANING";
            // 
            // labelVerb
            // 
            this.labelVerb.AutoSize = true;
            this.labelVerb.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerb.Location = new System.Drawing.Point(31, 28);
            this.labelVerb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVerb.Name = "labelVerb";
            this.labelVerb.Size = new System.Drawing.Size(63, 16);
            this.labelVerb.TabIndex = 7;
            this.labelVerb.Text = "VERBOS:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.labelCantidadFallos);
            this.panel1.Controls.Add(this.labelCantidadAciertos);
            this.panel1.Controls.Add(this.labelCantidadVerbos);
            this.panel1.Controls.Add(this.labelFallo);
            this.panel1.Controls.Add(this.labelAcierto);
            this.panel1.Controls.Add(this.labelVerb);
            this.panel1.Location = new System.Drawing.Point(481, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 153);
            this.panel1.TabIndex = 8;
            // 
            // labelCantidadFallos
            // 
            this.labelCantidadFallos.AutoSize = true;
            this.labelCantidadFallos.Location = new System.Drawing.Point(110, 116);
            this.labelCantidadFallos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCantidadFallos.Name = "labelCantidadFallos";
            this.labelCantidadFallos.Size = new System.Drawing.Size(35, 13);
            this.labelCantidadFallos.TabIndex = 12;
            this.labelCantidadFallos.Text = "label5";
            // 
            // labelCantidadAciertos
            // 
            this.labelCantidadAciertos.AutoSize = true;
            this.labelCantidadAciertos.Location = new System.Drawing.Point(110, 74);
            this.labelCantidadAciertos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCantidadAciertos.Name = "labelCantidadAciertos";
            this.labelCantidadAciertos.Size = new System.Drawing.Size(35, 13);
            this.labelCantidadAciertos.TabIndex = 11;
            this.labelCantidadAciertos.Text = "label4";
            // 
            // labelCantidadVerbos
            // 
            this.labelCantidadVerbos.AutoSize = true;
            this.labelCantidadVerbos.Location = new System.Drawing.Point(110, 31);
            this.labelCantidadVerbos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCantidadVerbos.Name = "labelCantidadVerbos";
            this.labelCantidadVerbos.Size = new System.Drawing.Size(35, 13);
            this.labelCantidadVerbos.TabIndex = 10;
            this.labelCantidadVerbos.Text = "label3";
            // 
            // labelFallo
            // 
            this.labelFallo.AutoSize = true;
            this.labelFallo.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFallo.Location = new System.Drawing.Point(31, 113);
            this.labelFallo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFallo.Name = "labelFallo";
            this.labelFallo.Size = new System.Drawing.Size(63, 16);
            this.labelFallo.TabIndex = 9;
            this.labelFallo.Text = "FALLOS:";
            // 
            // labelAcierto
            // 
            this.labelAcierto.AutoSize = true;
            this.labelAcierto.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcierto.Location = new System.Drawing.Point(16, 71);
            this.labelAcierto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAcierto.Name = "labelAcierto";
            this.labelAcierto.Size = new System.Drawing.Size(79, 16);
            this.labelAcierto.TabIndex = 8;
            this.labelAcierto.Text = "ACIERTOS:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(479, 37);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(35, 13);
            this.labelTotal.TabIndex = 9;
            this.labelTotal.Text = "label3";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(615, 326);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textPParticiple
            // 
            this.textPParticiple.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPParticiple.Location = new System.Drawing.Point(157, 216);
            this.textPParticiple.Margin = new System.Windows.Forms.Padding(2);
            this.textPParticiple.Name = "textPParticiple";
            this.textPParticiple.Size = new System.Drawing.Size(238, 32);
            this.textPParticiple.TabIndex = 11;
            this.textPParticiple.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPParticiple_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "P. PARTICIPLE";
            // 
            // Verbos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 399);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPParticiple);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMeaning);
            this.Controls.Add(this.lblVerb);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Verbos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verbos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label labelVerb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFallo;
        private System.Windows.Forms.Label labelAcierto;
        private System.Windows.Forms.Label labelCantidadFallos;
        private System.Windows.Forms.Label labelCantidadAciertos;
        private System.Windows.Forms.Label labelCantidadVerbos;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textPParticiple;
        private System.Windows.Forms.Label label3;
    }
}

