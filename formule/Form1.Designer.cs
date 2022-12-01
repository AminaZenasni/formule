using System;

namespace formule
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Suprimer = new System.Windows.Forms.Button();
            this.Quest = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ann = new System.Windows.Forms.Button();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Pink;
            this.textBox1.Location = new System.Drawing.Point(145, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(532, 22);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Ajouter.Location = new System.Drawing.Point(380, 116);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(108, 52);
            this.Ajouter.TabIndex = 1;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Suprimer
            // 
            this.Suprimer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Suprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suprimer.Location = new System.Drawing.Point(494, 116);
            this.Suprimer.Name = "Suprimer";
            this.Suprimer.Size = new System.Drawing.Size(108, 52);
            this.Suprimer.TabIndex = 3;
            this.Suprimer.Text = "Supprimer";
            this.Suprimer.UseVisualStyleBackColor = false;
            this.Suprimer.Click += new System.EventHandler(this.Suprimer_Click);
            // 
            // Quest
            // 
            this.Quest.AutoSize = true;
            this.Quest.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quest.Location = new System.Drawing.Point(47, 29);
            this.Quest.Name = "Quest";
            this.Quest.Size = new System.Drawing.Size(60, 24);
            this.Quest.TabIndex = 6;
            this.Quest.Text = "Nom";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Pink;
            this.textBox2.Location = new System.Drawing.Point(145, 59);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(532, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Prenom";
            // 
            // Ann
            // 
            this.Ann.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ann.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ann.Location = new System.Drawing.Point(313, 174);
            this.Ann.Name = "Ann";
            this.Ann.Size = new System.Drawing.Size(115, 55);
            this.Ann.TabIndex = 16;
            this.Ann.Text = "Annuler";
            this.Ann.UseVisualStyleBackColor = false;
            this.Ann.Click += new System.EventHandler(this.Ann_Click);
            // 
            // Enregistrer
            // 
            this.Enregistrer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enregistrer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Enregistrer.Location = new System.Drawing.Point(259, 116);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(115, 52);
            this.Enregistrer.TabIndex = 13;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = false;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.Location = new System.Drawing.Point(145, 116);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(108, 52);
            this.Modifier.TabIndex = 15;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "zina",
            "amina",
            "zenasni"});
            this.comboBox1.Location = new System.Drawing.Point(145, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(532, 23);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(689, 371);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.Ann);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Quest);
            this.Controls.Add(this.Suprimer);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Suprimer;
        private System.Windows.Forms.Label Quest;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ann;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

