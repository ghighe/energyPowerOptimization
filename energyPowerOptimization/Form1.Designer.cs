
namespace energyPowerOptimization
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
            this.top_panel = new System.Windows.Forms.Panel();
            this.logo_upit_pic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.iesire_app_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panou_control_btn = new Guna.UI2.WinForms.Guna2Button();
            this.optimizare_consum_btn = new Guna.UI2.WinForms.Guna2Button();
            this.adauga_consumatori_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_upit_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.Violet;
            this.top_panel.Controls.Add(this.logo_upit_pic);
            this.top_panel.Controls.Add(this.label1);
            this.top_panel.Controls.Add(this.pictureBox1);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1167, 83);
            this.top_panel.TabIndex = 0;
            // 
            // logo_upit_pic
            // 
            this.logo_upit_pic.Image = global::energyPowerOptimization.Properties.Resources._1200px_Logo_Universitatea_din_Pitești_svg;
            this.logo_upit_pic.ImageRotate = 0F;
            this.logo_upit_pic.Location = new System.Drawing.Point(1066, 3);
            this.logo_upit_pic.Name = "logo_upit_pic";
            this.logo_upit_pic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.logo_upit_pic.Size = new System.Drawing.Size(98, 78);
            this.logo_upit_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_upit_pic.TabIndex = 0;
            this.logo_upit_pic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(374, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestionarea Optima a\n Consumului Energetic al unei Locuinte";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::energyPowerOptimization.Properties.Resources.green_energy_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.White;
            this.menu_panel.Controls.Add(this.iesire_app_btn);
            this.menu_panel.Controls.Add(this.panou_control_btn);
            this.menu_panel.Controls.Add(this.optimizare_consum_btn);
            this.menu_panel.Controls.Add(this.adauga_consumatori_btn);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_panel.Location = new System.Drawing.Point(0, 83);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(1167, 50);
            this.menu_panel.TabIndex = 1;
            // 
            // iesire_app_btn
            // 
            this.iesire_app_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.iesire_app_btn.CheckedState.CustomBorderColor = System.Drawing.Color.Violet;
            this.iesire_app_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iesire_app_btn.CustomBorderColor = System.Drawing.Color.Violet;
            this.iesire_app_btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.iesire_app_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.iesire_app_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.iesire_app_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.iesire_app_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.iesire_app_btn.FillColor = System.Drawing.Color.White;
            this.iesire_app_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iesire_app_btn.ForeColor = System.Drawing.Color.Black;
            this.iesire_app_btn.HoverState.CustomBorderColor = System.Drawing.Color.Violet;
            this.iesire_app_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.iesire_app_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.iesire_app_btn.Image = global::energyPowerOptimization.Properties.Resources.exit;
            this.iesire_app_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.iesire_app_btn.Location = new System.Drawing.Point(924, 0);
            this.iesire_app_btn.Name = "iesire_app_btn";
            this.iesire_app_btn.Size = new System.Drawing.Size(192, 50);
            this.iesire_app_btn.TabIndex = 3;
            this.iesire_app_btn.Text = "Iesire";
            this.iesire_app_btn.Click += new System.EventHandler(this.iesire_app_btn_Click);
            // 
            // panou_control_btn
            // 
            this.panou_control_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.panou_control_btn.CheckedState.CustomBorderColor = System.Drawing.Color.Violet;
            this.panou_control_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panou_control_btn.CustomBorderColor = System.Drawing.Color.Violet;
            this.panou_control_btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panou_control_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.panou_control_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.panou_control_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.panou_control_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.panou_control_btn.FillColor = System.Drawing.Color.White;
            this.panou_control_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panou_control_btn.ForeColor = System.Drawing.Color.Black;
            this.panou_control_btn.HoverState.CustomBorderColor = System.Drawing.Color.Violet;
            this.panou_control_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panou_control_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.panou_control_btn.Image = global::energyPowerOptimization.Properties.Resources.dashboard;
            this.panou_control_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.panou_control_btn.Location = new System.Drawing.Point(638, 0);
            this.panou_control_btn.Name = "panou_control_btn";
            this.panou_control_btn.Size = new System.Drawing.Size(192, 50);
            this.panou_control_btn.TabIndex = 2;
            this.panou_control_btn.Text = "Grafic Optimizare";
            this.panou_control_btn.Click += new System.EventHandler(this.panou_control_btn_Click);
            // 
            // optimizare_consum_btn
            // 
            this.optimizare_consum_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.optimizare_consum_btn.CheckedState.CustomBorderColor = System.Drawing.Color.Violet;
            this.optimizare_consum_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optimizare_consum_btn.CustomBorderColor = System.Drawing.Color.Violet;
            this.optimizare_consum_btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.optimizare_consum_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.optimizare_consum_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.optimizare_consum_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.optimizare_consum_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.optimizare_consum_btn.FillColor = System.Drawing.Color.White;
            this.optimizare_consum_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optimizare_consum_btn.ForeColor = System.Drawing.Color.Black;
            this.optimizare_consum_btn.HoverState.CustomBorderColor = System.Drawing.Color.Violet;
            this.optimizare_consum_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.optimizare_consum_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.optimizare_consum_btn.Image = global::energyPowerOptimization.Properties.Resources.renewable_energy;
            this.optimizare_consum_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.optimizare_consum_btn.Location = new System.Drawing.Point(338, 0);
            this.optimizare_consum_btn.Name = "optimizare_consum_btn";
            this.optimizare_consum_btn.Size = new System.Drawing.Size(204, 50);
            this.optimizare_consum_btn.TabIndex = 1;
            this.optimizare_consum_btn.Text = "Optimizare Consum";
            this.optimizare_consum_btn.Click += new System.EventHandler(this.optimizare_consum_btn_Click);
            // 
            // adauga_consumatori_btn
            // 
            this.adauga_consumatori_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.adauga_consumatori_btn.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.adauga_consumatori_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adauga_consumatori_btn.CustomBorderColor = System.Drawing.Color.Violet;
            this.adauga_consumatori_btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.adauga_consumatori_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.adauga_consumatori_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.adauga_consumatori_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adauga_consumatori_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.adauga_consumatori_btn.FillColor = System.Drawing.Color.White;
            this.adauga_consumatori_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adauga_consumatori_btn.ForeColor = System.Drawing.Color.Black;
            this.adauga_consumatori_btn.HoverState.CustomBorderColor = System.Drawing.Color.Violet;
            this.adauga_consumatori_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.adauga_consumatori_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.adauga_consumatori_btn.Image = global::energyPowerOptimization.Properties.Resources.plus;
            this.adauga_consumatori_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.adauga_consumatori_btn.Location = new System.Drawing.Point(61, 0);
            this.adauga_consumatori_btn.Name = "adauga_consumatori_btn";
            this.adauga_consumatori_btn.Size = new System.Drawing.Size(192, 50);
            this.adauga_consumatori_btn.TabIndex = 0;
            this.adauga_consumatori_btn.Text = "Adauga Consumatori";
            this.adauga_consumatori_btn.Click += new System.EventHandler(this.adauga_consumatori_btn_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 133);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1167, 598);
            this.panelContainer.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 731);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.top_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_upit_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button adauga_consumatori_btn;
        private Guna.UI2.WinForms.Guna2Button iesire_app_btn;
        private Guna.UI2.WinForms.Guna2Button panou_control_btn;
        private Guna.UI2.WinForms.Guna2Button optimizare_consum_btn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox logo_upit_pic;
    }
}

