
namespace tp_Etudiant
{
    partial class Notes
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
            this.label4 = new System.Windows.Forms.Label();
            this.cb_etud = new System.Windows.Forms.ComboBox();
            this.cb_matiere = new System.Windows.Forms.ComboBox();
            this.lb_coeff = new System.Windows.Forms.Label();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.btn_ajout = new System.Windows.Forms.Button();
            this.btn_Annuller = new System.Windows.Forms.Button();
            this.lb_nom = new System.Windows.Forms.Label();
            this.lb_prenom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etudiant :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matiere :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Coeff :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Note :";
            // 
            // cb_etud
            // 
            this.cb_etud.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_etud.FormattingEnabled = true;
            this.cb_etud.Location = new System.Drawing.Point(236, 91);
            this.cb_etud.Name = "cb_etud";
            this.cb_etud.Size = new System.Drawing.Size(143, 33);
            this.cb_etud.TabIndex = 4;
            this.cb_etud.SelectedIndexChanged += new System.EventHandler(this.cb_etud_SelectedIndexChanged);
            // 
            // cb_matiere
            // 
            this.cb_matiere.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_matiere.FormattingEnabled = true;
            this.cb_matiere.Location = new System.Drawing.Point(226, 160);
            this.cb_matiere.Name = "cb_matiere";
            this.cb_matiere.Size = new System.Drawing.Size(143, 33);
            this.cb_matiere.TabIndex = 5;
            this.cb_matiere.SelectedIndexChanged += new System.EventHandler(this.cb_matiere_SelectedIndexChanged);
            // 
            // lb_coeff
            // 
            this.lb_coeff.AutoSize = true;
            this.lb_coeff.Location = new System.Drawing.Point(197, 289);
            this.lb_coeff.Name = "lb_coeff";
            this.lb_coeff.Size = new System.Drawing.Size(10, 13);
            this.lb_coeff.TabIndex = 6;
            this.lb_coeff.Text = " ";
            // 
            // txt_note
            // 
            this.txt_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_note.Location = new System.Drawing.Point(191, 224);
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(143, 31);
            this.txt_note.TabIndex = 7;
            this.txt_note.TextChanged += new System.EventHandler(this.txt_note_TextChanged);
            // 
            // btn_ajout
            // 
            this.btn_ajout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ajout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajout.Location = new System.Drawing.Point(535, 102);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(162, 69);
            this.btn_ajout.TabIndex = 8;
            this.btn_ajout.Text = "Ajouter";
            this.btn_ajout.UseVisualStyleBackColor = false;
            this.btn_ajout.Click += new System.EventHandler(this.btn_ajout_Click);
            // 
            // btn_Annuller
            // 
            this.btn_Annuller.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Annuller.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Annuller.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Annuller.Location = new System.Drawing.Point(535, 189);
            this.btn_Annuller.Name = "btn_Annuller";
            this.btn_Annuller.Size = new System.Drawing.Size(162, 69);
            this.btn_Annuller.TabIndex = 9;
            this.btn_Annuller.Text = "Annuller";
            this.btn_Annuller.UseVisualStyleBackColor = false;
            this.btn_Annuller.Click += new System.EventHandler(this.btn_Annuller_Click);
            // 
            // lb_nom
            // 
            this.lb_nom.AutoSize = true;
            this.lb_nom.Location = new System.Drawing.Point(233, 180);
            this.lb_nom.Name = "lb_nom";
            this.lb_nom.Size = new System.Drawing.Size(0, 13);
            this.lb_nom.TabIndex = 10;
            // 
            // lb_prenom
            // 
            this.lb_prenom.AutoSize = true;
            this.lb_prenom.Location = new System.Drawing.Point(383, 209);
            this.lb_prenom.Name = "lb_prenom";
            this.lb_prenom.Size = new System.Drawing.Size(0, 13);
            this.lb_prenom.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(41, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(421, 43);
            this.label5.TabIndex = 12;
            this.label5.Text = "GESTION DES NOTES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(617, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 100);
            this.button3.TabIndex = 21;
            this.button3.Text = "Retour";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_prenom);
            this.Controls.Add(this.lb_nom);
            this.Controls.Add(this.btn_Annuller);
            this.Controls.Add(this.btn_ajout);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.lb_coeff);
            this.Controls.Add(this.cb_matiere);
            this.Controls.Add(this.cb_etud);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Notes";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.Notes_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_etud;
        private System.Windows.Forms.ComboBox cb_matiere;
        private System.Windows.Forms.Label lb_coeff;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.Button btn_ajout;
        private System.Windows.Forms.Button btn_Annuller;
        private System.Windows.Forms.Label lb_nom;
        private System.Windows.Forms.Label lb_prenom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
    }
}