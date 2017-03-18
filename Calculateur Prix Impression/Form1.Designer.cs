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
			this.gb_printers = new System.Windows.Forms.GroupBox();
			this.lb_printers = new System.Windows.Forms.ListBox();
			this.bt_printers_add = new System.Windows.Forms.Button();
			this.bt_printers_delete = new System.Windows.Forms.Button();
			this.bt_printers_ok = new System.Windows.Forms.Button();
			this.lb_printers_price = new System.Windows.Forms.Label();
			this.tb_printers_price = new System.Windows.Forms.TextBox();
			this.lb_printers_price_unit = new System.Windows.Forms.Label();
			this.lb_printers_lifetime_unit = new System.Windows.Forms.Label();
			this.tb_printers_lifetime = new System.Windows.Forms.TextBox();
			this.lb_printers_lifetime = new System.Windows.Forms.Label();
			this.lb_printers_care_unit = new System.Windows.Forms.Label();
			this.tb_printers_care = new System.Windows.Forms.TextBox();
			this.lb_printers_care = new System.Windows.Forms.Label();
			this.lb_printers_power_unit = new System.Windows.Forms.Label();
			this.tb_printers_power = new System.Windows.Forms.TextBox();
			this.lb_printers_power = new System.Windows.Forms.Label();
			this.bt_printers_save = new System.Windows.Forms.Button();
			this.bt_printers_cancel = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.gb_printers.SuspendLayout();
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
			this.réglagesToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.réglagesToolStripMenuItem.Text = "Réglages";
			this.réglagesToolStripMenuItem.Click += new System.EventHandler(this.réglagesToolStripMenuItem_Click);
			// 
			// quitterToolStripMenuItem
			// 
			this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
			this.quitterToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
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
			// gb_printers
			// 
			this.gb_printers.Controls.Add(this.bt_printers_cancel);
			this.gb_printers.Controls.Add(this.bt_printers_save);
			this.gb_printers.Controls.Add(this.lb_printers_power_unit);
			this.gb_printers.Controls.Add(this.tb_printers_power);
			this.gb_printers.Controls.Add(this.lb_printers_power);
			this.gb_printers.Controls.Add(this.lb_printers_care_unit);
			this.gb_printers.Controls.Add(this.tb_printers_care);
			this.gb_printers.Controls.Add(this.lb_printers_care);
			this.gb_printers.Controls.Add(this.lb_printers_lifetime_unit);
			this.gb_printers.Controls.Add(this.tb_printers_lifetime);
			this.gb_printers.Controls.Add(this.lb_printers_lifetime);
			this.gb_printers.Controls.Add(this.lb_printers_price_unit);
			this.gb_printers.Controls.Add(this.tb_printers_price);
			this.gb_printers.Controls.Add(this.lb_printers_price);
			this.gb_printers.Controls.Add(this.bt_printers_ok);
			this.gb_printers.Controls.Add(this.bt_printers_delete);
			this.gb_printers.Controls.Add(this.bt_printers_add);
			this.gb_printers.Controls.Add(this.lb_printers);
			this.gb_printers.Location = new System.Drawing.Point(27, 27);
			this.gb_printers.Name = "gb_printers";
			this.gb_printers.Size = new System.Drawing.Size(303, 227);
			this.gb_printers.TabIndex = 14;
			this.gb_printers.TabStop = false;
			this.gb_printers.Text = "Manage Printers";
			this.gb_printers.Visible = false;
			// 
			// lb_printers
			// 
			this.lb_printers.FormattingEnabled = true;
			this.lb_printers.Location = new System.Drawing.Point(7, 17);
			this.lb_printers.Name = "lb_printers";
			this.lb_printers.Size = new System.Drawing.Size(135, 173);
			this.lb_printers.TabIndex = 0;
			this.lb_printers.SelectedIndexChanged += new System.EventHandler(this.lb_printers_SelectedIndexChanged);
			// 
			// bt_printers_add
			// 
			this.bt_printers_add.Location = new System.Drawing.Point(7, 197);
			this.bt_printers_add.Name = "bt_printers_add";
			this.bt_printers_add.Size = new System.Drawing.Size(64, 23);
			this.bt_printers_add.TabIndex = 1;
			this.bt_printers_add.Text = "Add";
			this.bt_printers_add.UseVisualStyleBackColor = true;
			this.bt_printers_add.Click += new System.EventHandler(this.bt_printers_add_Click);
			// 
			// bt_printers_delete
			// 
			this.bt_printers_delete.Location = new System.Drawing.Point(78, 197);
			this.bt_printers_delete.Name = "bt_printers_delete";
			this.bt_printers_delete.Size = new System.Drawing.Size(64, 23);
			this.bt_printers_delete.TabIndex = 2;
			this.bt_printers_delete.Text = "Delete";
			this.bt_printers_delete.UseVisualStyleBackColor = true;
			this.bt_printers_delete.Click += new System.EventHandler(this.bt_printers_delete_Click);
			// 
			// bt_printers_ok
			// 
			this.bt_printers_ok.Location = new System.Drawing.Point(178, 197);
			this.bt_printers_ok.Name = "bt_printers_ok";
			this.bt_printers_ok.Size = new System.Drawing.Size(106, 23);
			this.bt_printers_ok.TabIndex = 3;
			this.bt_printers_ok.Text = "OK";
			this.bt_printers_ok.UseVisualStyleBackColor = true;
			this.bt_printers_ok.Click += new System.EventHandler(this.bt_printers_ok_Click);
			// 
			// lb_printers_price
			// 
			this.lb_printers_price.AutoSize = true;
			this.lb_printers_price.Location = new System.Drawing.Point(159, 24);
			this.lb_printers_price.Name = "lb_printers_price";
			this.lb_printers_price.Size = new System.Drawing.Size(31, 13);
			this.lb_printers_price.TabIndex = 4;
			this.lb_printers_price.Text = "Price";
			// 
			// tb_printers_price
			// 
			this.tb_printers_price.Enabled = false;
			this.tb_printers_price.Location = new System.Drawing.Point(215, 20);
			this.tb_printers_price.Name = "tb_printers_price";
			this.tb_printers_price.Size = new System.Drawing.Size(50, 20);
			this.tb_printers_price.TabIndex = 5;
			// 
			// lb_printers_price_unit
			// 
			this.lb_printers_price_unit.AutoSize = true;
			this.lb_printers_price_unit.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.lb_printers_price_unit.Location = new System.Drawing.Point(267, 24);
			this.lb_printers_price_unit.Name = "lb_printers_price_unit";
			this.lb_printers_price_unit.Size = new System.Drawing.Size(13, 13);
			this.lb_printers_price_unit.TabIndex = 6;
			this.lb_printers_price_unit.Text = "€";
			// 
			// lb_printers_lifetime_unit
			// 
			this.lb_printers_lifetime_unit.AutoSize = true;
			this.lb_printers_lifetime_unit.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.lb_printers_lifetime_unit.Location = new System.Drawing.Point(267, 54);
			this.lb_printers_lifetime_unit.Name = "lb_printers_lifetime_unit";
			this.lb_printers_lifetime_unit.Size = new System.Drawing.Size(32, 13);
			this.lb_printers_lifetime_unit.TabIndex = 9;
			this.lb_printers_lifetime_unit.Text = "years";
			// 
			// tb_printers_lifetime
			// 
			this.tb_printers_lifetime.Enabled = false;
			this.tb_printers_lifetime.Location = new System.Drawing.Point(215, 50);
			this.tb_printers_lifetime.Name = "tb_printers_lifetime";
			this.tb_printers_lifetime.Size = new System.Drawing.Size(50, 20);
			this.tb_printers_lifetime.TabIndex = 8;
			// 
			// lb_printers_lifetime
			// 
			this.lb_printers_lifetime.AutoSize = true;
			this.lb_printers_lifetime.Location = new System.Drawing.Point(159, 54);
			this.lb_printers_lifetime.Name = "lb_printers_lifetime";
			this.lb_printers_lifetime.Size = new System.Drawing.Size(43, 13);
			this.lb_printers_lifetime.TabIndex = 7;
			this.lb_printers_lifetime.Text = "Lifetime";
			// 
			// lb_printers_care_unit
			// 
			this.lb_printers_care_unit.AutoSize = true;
			this.lb_printers_care_unit.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.lb_printers_care_unit.Location = new System.Drawing.Point(267, 84);
			this.lb_printers_care_unit.Name = "lb_printers_care_unit";
			this.lb_printers_care_unit.Size = new System.Drawing.Size(15, 13);
			this.lb_printers_care_unit.TabIndex = 12;
			this.lb_printers_care_unit.Text = "%";
			// 
			// tb_printers_care
			// 
			this.tb_printers_care.Enabled = false;
			this.tb_printers_care.Location = new System.Drawing.Point(215, 80);
			this.tb_printers_care.Name = "tb_printers_care";
			this.tb_printers_care.Size = new System.Drawing.Size(50, 20);
			this.tb_printers_care.TabIndex = 11;
			// 
			// lb_printers_care
			// 
			this.lb_printers_care.AutoSize = true;
			this.lb_printers_care.Location = new System.Drawing.Point(159, 84);
			this.lb_printers_care.Name = "lb_printers_care";
			this.lb_printers_care.Size = new System.Drawing.Size(52, 13);
			this.lb_printers_care.TabIndex = 10;
			this.lb_printers_care.Text = "Care cost";
			// 
			// lb_printers_power_unit
			// 
			this.lb_printers_power_unit.AutoSize = true;
			this.lb_printers_power_unit.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.lb_printers_power_unit.Location = new System.Drawing.Point(267, 114);
			this.lb_printers_power_unit.Name = "lb_printers_power_unit";
			this.lb_printers_power_unit.Size = new System.Drawing.Size(35, 13);
			this.lb_printers_power_unit.TabIndex = 15;
			this.lb_printers_power_unit.Text = "Watts";
			// 
			// tb_printers_power
			// 
			this.tb_printers_power.Enabled = false;
			this.tb_printers_power.Location = new System.Drawing.Point(215, 110);
			this.tb_printers_power.Name = "tb_printers_power";
			this.tb_printers_power.Size = new System.Drawing.Size(50, 20);
			this.tb_printers_power.TabIndex = 14;
			// 
			// lb_printers_power
			// 
			this.lb_printers_power.AutoSize = true;
			this.lb_printers_power.Location = new System.Drawing.Point(159, 114);
			this.lb_printers_power.Name = "lb_printers_power";
			this.lb_printers_power.Size = new System.Drawing.Size(37, 13);
			this.lb_printers_power.TabIndex = 13;
			this.lb_printers_power.Text = "Power";
			// 
			// bt_printers_save
			// 
			this.bt_printers_save.Location = new System.Drawing.Point(162, 143);
			this.bt_printers_save.Name = "bt_printers_save";
			this.bt_printers_save.Size = new System.Drawing.Size(59, 23);
			this.bt_printers_save.TabIndex = 16;
			this.bt_printers_save.Text = "Save";
			this.bt_printers_save.UseVisualStyleBackColor = true;
			this.bt_printers_save.Click += new System.EventHandler(this.bt_printers_save_Click);
			// 
			// bt_printers_cancel
			// 
			this.bt_printers_cancel.Location = new System.Drawing.Point(229, 143);
			this.bt_printers_cancel.Name = "bt_printers_cancel";
			this.bt_printers_cancel.Size = new System.Drawing.Size(59, 23);
			this.bt_printers_cancel.TabIndex = 17;
			this.bt_printers_cancel.Text = "Cancel";
			this.bt_printers_cancel.UseVisualStyleBackColor = true;
			this.bt_printers_cancel.Click += new System.EventHandler(this.bt_printers_cancel_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 266);
			this.Controls.Add(this.gb_printers);
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
			this.gb_printers.ResumeLayout(false);
			this.gb_printers.PerformLayout();
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
		private System.Windows.Forms.GroupBox gb_printers;
		private System.Windows.Forms.Label lb_printers_price;
		private System.Windows.Forms.Button bt_printers_ok;
		private System.Windows.Forms.Button bt_printers_delete;
		private System.Windows.Forms.Button bt_printers_add;
		private System.Windows.Forms.ListBox lb_printers;
		private System.Windows.Forms.Label lb_printers_lifetime_unit;
		private System.Windows.Forms.TextBox tb_printers_lifetime;
		private System.Windows.Forms.Label lb_printers_lifetime;
		private System.Windows.Forms.Label lb_printers_price_unit;
		private System.Windows.Forms.TextBox tb_printers_price;
		private System.Windows.Forms.Label lb_printers_care_unit;
		private System.Windows.Forms.TextBox tb_printers_care;
		private System.Windows.Forms.Label lb_printers_care;
		private System.Windows.Forms.Label lb_printers_power_unit;
		private System.Windows.Forms.TextBox tb_printers_power;
		private System.Windows.Forms.Label lb_printers_power;
		private System.Windows.Forms.Button bt_printers_cancel;
		private System.Windows.Forms.Button bt_printers_save;
	}
}

