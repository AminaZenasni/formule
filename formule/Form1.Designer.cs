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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ann = new System.Windows.Forms.Button();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Pink;
            this.textBox1.Location = new System.Drawing.Point(107, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 22);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ajouter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ajouter.Location = new System.Drawing.Point(107, 103);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 52);
            this.Ajouter.TabIndex = 1;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Suprimer
            // 
            this.Suprimer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Suprimer.Location = new System.Drawing.Point(188, 103);
            this.Suprimer.Name = "Suprimer";
            this.Suprimer.Size = new System.Drawing.Size(75, 52);
            this.Suprimer.TabIndex = 3;
            this.Suprimer.Text = "Suprimer";
            this.Suprimer.UseVisualStyleBackColor = false;
            this.Suprimer.Click += new System.EventHandler(this.Suprimer_Click);
            // 
            // Quest
            // 
            this.Quest.AutoSize = true;
            this.Quest.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quest.Location = new System.Drawing.Point(12, 31);
            this.Quest.Name = "Quest";
            this.Quest.Size = new System.Drawing.Size(60, 24);
            this.Quest.TabIndex = 6;
            this.Quest.Text = "Nom";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Pink;
            this.textBox2.Location = new System.Drawing.Point(107, 59);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Prenom";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(107, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(408, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ann
            // 
            this.Ann.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ann.Location = new System.Drawing.Point(350, 103);
            this.Ann.Name = "Ann";
            this.Ann.Size = new System.Drawing.Size(75, 52);
            this.Ann.TabIndex = 16;
            this.Ann.Text = "Annuler";
            this.Ann.UseVisualStyleBackColor = false;
            this.Ann.Click += new System.EventHandler(this.Ann_Click);
            // 
            // Enregistrer
            // 
            this.Enregistrer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Enregistrer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Enregistrer.Location = new System.Drawing.Point(431, 103);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(84, 52);
            this.Enregistrer.TabIndex = 13;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = false;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Modifier.Location = new System.Drawing.Point(269, 103);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(75, 52);
            this.Modifier.TabIndex = 15;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(710, 363);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.Ann);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Quest);
            this.Controls.Add(this.Suprimer);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Ann;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.Button Modifier;
    }
}

