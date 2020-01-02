namespace Sprm
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_proxys = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.visualizer = new System.Windows.Forms.Panel();
            this.btn_copped = new System.Windows.Forms.Button();
            this.btn_billing = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_tasks = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tasks1 = new Sprm.Tasks();
            this.proxys1 = new Sprm.Proxys();
            this.billing1 = new Sprm.Billing();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_proxys
            // 
            this.btn_proxys.BackColor = System.Drawing.Color.Gray;
            this.btn_proxys.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_proxys.FlatAppearance.BorderSize = 0;
            this.btn_proxys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proxys.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proxys.ForeColor = System.Drawing.Color.White;
            this.btn_proxys.Location = new System.Drawing.Point(394, 17);
            this.btn_proxys.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_proxys.Name = "btn_proxys";
            this.btn_proxys.Size = new System.Drawing.Size(172, 39);
            this.btn_proxys.TabIndex = 0;
            this.btn_proxys.Text = "Proxys";
            this.btn_proxys.UseVisualStyleBackColor = false;
            this.btn_proxys.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.visualizer);
            this.panel1.Controls.Add(this.btn_copped);
            this.panel1.Controls.Add(this.btn_billing);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_proxys);
            this.panel1.Controls.Add(this.btn_tasks);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 62);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(910, 17);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 39);
            this.panel4.TabIndex = 1;
            // 
            // visualizer
            // 
            this.visualizer.BackColor = System.Drawing.Color.Red;
            this.visualizer.Location = new System.Drawing.Point(222, 7);
            this.visualizer.Name = "visualizer";
            this.visualizer.Size = new System.Drawing.Size(172, 10);
            this.visualizer.TabIndex = 0;
            // 
            // btn_copped
            // 
            this.btn_copped.BackColor = System.Drawing.Color.Gray;
            this.btn_copped.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_copped.FlatAppearance.BorderSize = 0;
            this.btn_copped.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_copped.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copped.ForeColor = System.Drawing.Color.White;
            this.btn_copped.Location = new System.Drawing.Point(738, 17);
            this.btn_copped.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_copped.Name = "btn_copped";
            this.btn_copped.Size = new System.Drawing.Size(172, 39);
            this.btn_copped.TabIndex = 3;
            this.btn_copped.Text = "Copped";
            this.btn_copped.UseVisualStyleBackColor = false;
            this.btn_copped.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btn_billing
            // 
            this.btn_billing.BackColor = System.Drawing.Color.Gray;
            this.btn_billing.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_billing.FlatAppearance.BorderSize = 0;
            this.btn_billing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_billing.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_billing.ForeColor = System.Drawing.Color.White;
            this.btn_billing.Location = new System.Drawing.Point(566, 17);
            this.btn_billing.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_billing.Name = "btn_billing";
            this.btn_billing.Size = new System.Drawing.Size(172, 39);
            this.btn_billing.TabIndex = 2;
            this.btn_billing.Text = "Billing";
            this.btn_billing.UseVisualStyleBackColor = false;
            this.btn_billing.Click += new System.EventHandler(this.Button2_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Location = new System.Drawing.Point(210, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(12, 62);
            this.panel5.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Sprm.io.Properties.Resources.logo_supreme_x2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 62);
            this.panel2.TabIndex = 1;
            // 
            // btn_tasks
            // 
            this.btn_tasks.BackColor = System.Drawing.Color.Gray;
            this.btn_tasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_tasks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_tasks.FlatAppearance.BorderSize = 0;
            this.btn_tasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tasks.ForeColor = System.Drawing.Color.White;
            this.btn_tasks.Location = new System.Drawing.Point(222, 17);
            this.btn_tasks.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_tasks.Name = "btn_tasks";
            this.btn_tasks.Size = new System.Drawing.Size(172, 39);
            this.btn_tasks.TabIndex = 0;
            this.btn_tasks.Text = "Tasks";
            this.btn_tasks.UseVisualStyleBackColor = false;
            this.btn_tasks.Click += new System.EventHandler(this.Button3_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tasks1);
            this.panel3.Controls.Add(this.proxys1);
            this.panel3.Controls.Add(this.billing1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1210, 499);
            this.panel3.TabIndex = 2;
            // 
            // tasks1
            // 
            this.tasks1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tasks1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasks1.Location = new System.Drawing.Point(0, 0);
            this.tasks1.Name = "tasks1";
            this.tasks1.Size = new System.Drawing.Size(1210, 499);
            this.tasks1.TabIndex = 0;
            // 
            // proxys1
            // 
            this.proxys1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proxys1.Location = new System.Drawing.Point(0, 0);
            this.proxys1.Name = "proxys1";
            this.proxys1.Size = new System.Drawing.Size(1210, 499);
            this.proxys1.TabIndex = 1;
            // 
            // billing1
            // 
            this.billing1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billing1.Location = new System.Drawing.Point(0, 0);
            this.billing1.Name = "billing1";
            this.billing1.Size = new System.Drawing.Size(1210, 499);
            this.billing1.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1226, 600);
            this.MinimumSize = new System.Drawing.Size(1226, 600);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPRM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_proxys;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_tasks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_copped;
        private System.Windows.Forms.Button btn_billing;
        private System.Windows.Forms.Panel visualizer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Tasks tasks1;
        private Proxys proxys1;
        private System.Windows.Forms.Panel panel5;
        private Billing billing1;
    }
}

