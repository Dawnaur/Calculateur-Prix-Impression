namespace Calculateur_Prix_Impression
{
	partial class Form1
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.réglagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.filamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imprimanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lb_time = new System.Windows.Forms.Label();
			this.lg_weight = new System.Windows.Forms.Label();
			this.lb_start = new System.Windows.Forms.Label();
			this.tb_time = new System.Windows.Forms.TextBox();
			this.tb_weight = new System.Windows.Forms.TextBox();
			this.tb_start = new System.Windows.Forms.TextBox();
			this.lb_time_unit = new System.Windows.Forms.Label();
			this.lb_start_unit = new System.Windows.Forms.Label();
			this.lb_weight_unit = new System.Windows.Forms.Label();
			this.lb_total = new System.Windows.Forms.Label();
			this.tb_total = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.filamentToolStripMenuItem,
            this.imprimanteToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(356, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fichierToolStripMenuItem
			// 
			this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.réglagesToolStripMenuItem,
            this.quitterToolStripMenuItem});
			this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
			this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.fichierToolStripMenuItem.Text = "Fichier";
			// 
			// réglagesToolStripMenuItem
			// 
			this.réglagesToolStripMenuItem.Name = "réglagesToolStripMenuItem";
			this.réglagesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.réglagesToolStripMenuItem.Text = "Réglages";
			this.réglagesToolStripMenuItem.Click += new System.EventHandler(this.réglagesToolStripMenuItem_Click);
			// 
			// quitterToolStripMenuItem
			// 
			this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
			this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.quitterToolStripMenuItem.Text = "Quitter";
			this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
			// 
			// filamentToolStripMenuItem
			// 
			this.filamentToolStripMenuItem.Name = "filamentToolStripMenuItem";
			this.filamentToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.filamentToolStripMenuItem.Text = "Filament";
			// 
			// imprimanteToolStripMenuItem
			// 
			this.imprimanteToolStripMenuItem.Name = "imprimanteToolStripMenuItem";
			this.imprimanteToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
			this.imprimanteToolStripMenuItem.Text = "Imprimante";
			// 
			// lb_time
			// 
			this.lb_time.AutoSize = true;
			this.lb_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_time.Location = new System.Drawing.Point(24, 44);
			this.lb_time.Name = "lb_time";
			this.lb_time.Size = new System.Drawing.Size(134, 17);
			this.lb_time.TabIndex = 1;
			this.lb_time.Text = "Temps d\'impression";
			this.lb_time.Click += new System.EventHandler(this.label1_Click);
			// 
			// lg_weight
			// 
			this.lg_weight.AutoSize = true;
			this.lg_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lg_weight.Location = new System.Drawing.Point(24, 74);
			this.lg_weight.Name = "lg_weight";
			this.lg_weight.Size = new System.Drawing.Size(43, 17);
			this.lg_weight.TabIndex = 2;
			this.lg_weight.Text = "Poids";
			// 
			// lb_start
			// 
			this.lb_start.AutoSize = true;
			this.lb_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_start.Location = new System.Drawing.Point(24, 104);
			this.lb_start.Name = "lb_start";
			this.lb_start.Size = new System.Drawing.Size(126, 17);
			this.lb_start.TabIndex = 3;
			this.lb_start.Text = "Coût de lancement";
			// 
			// tb_time
			// 
			this.tb_time.Location = new System.Drawing.Point(218, 44);
			this.tb_time.Name = "tb_time";
			this.tb_time.Size = new System.Drawing.Size(50, 20);
			this.tb_time.TabIndex = 4;
			this.tb_time.Text = "1,64";
			this.tb_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tb_time.TextChanged += new System.EventHandler(this.tb_time_TextChanged);
			// 
			// tb_weight
			// 
			this.tb_weight.Location = new System.Drawing.Point(218, 74);
			this.tb_weight.Name = "tb_weight";
			this.tb_weight.Size = new System.Drawing.Size(50, 20);
			this.tb_weight.TabIndex = 5;
			this.tb_weight.Text = "42";
			this.tb_weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tb_weight.TextChanged += new System.EventHandler(this.tb_weight_TextChanged);
			// 
			// tb_start
			// 
			this.tb_start.Location = new System.Drawing.Point(218, 104);
			this.tb_start.Name = "tb_start";
			this.tb_start.Size = new System.Drawing.Size(50, 20);
			this.tb_start.TabIndex = 6;
			this.tb_start.Text = "1";
			this.tb_start.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tb_start.TextChanged += new System.EventHandler(this.tb_start_TextChanged);
			// 
			// lb_time_unit
			// 
			this.lb_time_unit.AutoSize = true;
			this.lb_time_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_time_unit.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.lb_time_unit.Location = new System.Drawing.Point(270, 46);
			this.lb_time_unit.Name = "lb_time_unit";
			this.lb_time_unit.Size = new System.Drawing.Size(45, 15);
			this.lb_time_unit.TabIndex = 7;
			this.lb_time_unit.Text = "heures";
			// 
			// lb_start_unit
			// 
			this.lb_start_unit.AutoSize = true;
			this.lb_start_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_start_unit.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.lb_start_unit.Location = new System.Drawing.Point(270, 106);
			this.lb_start_unit.Name = "lb_start_unit";
			this.lb_start_unit.Size = new System.Drawing.Size(14, 15);
			this.lb_start_unit.TabIndex = 8;
			this.lb_start_unit.Text = "€";
			// 
			// lb_weight_unit
			// 
			this.lb_weight_unit.AutoSize = true;
			this.lb_weight_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_weight_unit.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.lb_weight_unit.Location = new System.Drawing.Point(270, 76);
			this.lb_weight_unit.Name = "lb_weight_unit";
			this.lb_weight_unit.Size = new System.Drawing.Size(60, 15);
			this.lb_weight_unit.TabIndex = 9;
			this.lb_weight_unit.Text = "grammes";
			// 
			// lb_total
			// 
			this.lb_total.AutoSize = true;
			this.lb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_total.Location = new System.Drawing.Point(24, 194);
			this.lb_total.Name = "lb_total";
			this.lb_total.Size = new System.Drawing.Size(45, 17);
			this.lb_total.TabIndex = 10;
			this.lb_total.Text = "Total";
			// 
			// tb_total
			// 
			this.tb_total.Location = new System.Drawing.Point(218, 194);
			this.tb_total.Name = "tb_total";
			this.tb_total.ReadOnly = true;
			this.tb_total.Size = new System.Drawing.Size(50, 20);
			this.tb_total.TabIndex = 11;
			this.tb_total.Text = "0";
			this.tb_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(270, 196);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(14, 15);
			this.label1.TabIndex = 12;
			this.label1.Text = "€";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.4F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.label2.Location = new System.Drawing.Point(164, 253);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(182, 12);
			this.label2.TabIndex = 13;
			this.label2.Text = "Soft by Dawnaur, inspired by Sylvain Denis";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 266);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb_total);
			this.Controls.Add(this.lb_total);
			this.Controls.Add(this.lb_weight_unit);
			this.Controls.Add(this.lb_start_unit);
			this.Controls.Add(this.lb_time_unit);
			this.Controls.Add(this.tb_start);
			this.Controls.Add(this.tb_weight);
			this.Controls.Add(this.tb_time);
			this.Controls.Add(this.lb_start);
			this.Controls.Add(this.lg_weight);
			this.Controls.Add(this.lb_time);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximumSize = new System.Drawing.Size(372, 305);
			this.MinimumSize = new System.Drawing.Size(372, 305);
			this.Name = "Form1";
			this.Text = "Print Cost";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem filamentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imprimanteToolStripMenuItem;
		private System.Windows.Forms.Label lb_time;
		private System.Windows.Forms.Label lg_weight;
		private System.Windows.Forms.Label lb_start;
		private System.Windows.Forms.TextBox tb_time;
		private System.Windows.Forms.TextBox tb_weight;
		private System.Windows.Forms.TextBox tb_start;
		private System.Windows.Forms.Label lb_time_unit;
		private System.Windows.Forms.Label lb_start_unit;
		private System.Windows.Forms.Label lb_weight_unit;
		private System.Windows.Forms.Label lb_total;
		private System.Windows.Forms.TextBox tb_total;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolStripMenuItem réglagesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
	}
}

