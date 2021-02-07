
namespace tp_Etudiant
{
    partial class Matiere
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_libelle = new System.Windows.Forms.ComboBox();
            this.nm_coeff = new System.Windows.Forms.NumericUpDown();
            this.cb_enseignant = new System.Windows.Forms.ComboBox();
            this.lb_NomE = new System.Windows.Forms.Label();
            this.lb_specialité = new System.Windows.Forms.Label();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nm_coeff)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libelle :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coeff :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enseignant :";
            // 
            // cb_libelle
            // 
            this.cb_libelle.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_libelle.FormattingEnabled = true;
            this.cb_libelle.Location = new System.Drawing.Point(213, 96);
            this.cb_libelle.Name = "cb_libelle";
            this.cb_libelle.Size = new System.Drawing.Size(121, 35);
            this.cb_libelle.TabIndex = 3;
            this.cb_libelle.SelectedIndexChanged += new System.EventHandler(this.cb_libelle_SelectedIndexChanged);
            // 
            // nm_coeff
            // 
            this.nm_coeff.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_coeff.Location = new System.Drawing.Point(214, 153);
            this.nm_coeff.Name = "nm_coeff";
            this.nm_coeff.Size = new System.Drawing.Size(120, 34);
            this.nm_coeff.TabIndex = 4;
            // 
            // cb_enseignant
            // 
            this.cb_enseignant.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_enseignant.FormattingEnabled = true;
            this.cb_enseignant.Location = new System.Drawing.Point(213, 201);
            this.cb_enseignant.Name = "cb_enseignant";
            this.cb_enseignant.Size = new System.Drawing.Size(121, 35);
            this.cb_enseignant.TabIndex = 5;
            this.cb_enseignant.SelectedIndexChanged += new System.EventHandler(this.cb_enseignant_SelectedIndexChanged);
            // 
            // lb_NomE
            // 
            this.lb_NomE.AutoSize = true;
            this.lb_NomE.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NomE.Location = new System.Drawing.Point(190, 261);
            this.lb_NomE.Name = "lb_NomE";
            this.lb_NomE.Size = new System.Drawing.Size(0, 36);
            this.lb_NomE.TabIndex = 6;
            // 
            // lb_specialité
            // 
            this.lb_specialité.AutoSize = true;
            this.lb_specialité.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_specialité.Location = new System.Drawing.Point(334, 261);
            this.lb_specialité.Name = "lb_specialité";
            this.lb_specialité.Size = new System.Drawing.Size(0, 36);
            this.lb_specialité.TabIndex = 7;
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ajouter.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ajouter.Location = new System.Drawing.Point(621, 66);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(142, 71);
            this.btn_Ajouter.TabIndex = 8;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = false;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_modifier.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifier.Location = new System.Drawing.Point(621, 153);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(142, 83);
            this.btn_modifier.TabIndex = 9;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = false;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Supprimer.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Supprimer.Location = new System.Drawing.Point(621, 246);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(142, 77);
            this.btn_Supprimer.TabIndex = 10;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = false;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(352, 205);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(159, 31);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Afficher tous";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(64, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 43);
            this.label5.TabIndex = 16;
            this.label5.Text = "Matière";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(658, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 100);
            this.button1.TabIndex = 11;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Matiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.lb_specialité);
            this.Controls.Add(this.lb_NomE);
            this.Controls.Add(this.cb_enseignant);
            this.Controls.Add(this.nm_coeff);
            this.Controls.Add(this.cb_libelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Matiere";
            this.Text = "Matiere";
            this.Load += new System.EventHandler(this.Matiere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nm_coeff)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_libelle;
        private System.Windows.Forms.NumericUpDown nm_coeff;
        private System.Windows.Forms.ComboBox cb_enseignant;
        private System.Windows.Forms.Label lb_NomE;
        private System.Windows.Forms.Label lb_specialité;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}