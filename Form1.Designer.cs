namespace Cobrinha_2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_snake = new System.Windows.Forms.Label();
            this.pb_snake = new System.Windows.Forms.PictureBox();
            this.bt_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_points = new System.Windows.Forms.Label();
            this.pn_points = new System.Windows.Forms.Panel();
            this.lb_gameover = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_snake)).BeginInit();
            this.pn_points.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_snake
            // 
            this.lb_snake.AutoSize = true;
            this.lb_snake.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_snake.Location = new System.Drawing.Point(200, 21);
            this.lb_snake.Name = "lb_snake";
            this.lb_snake.Size = new System.Drawing.Size(96, 31);
            this.lb_snake.TabIndex = 0;
            this.lb_snake.Text = "Snake";
            // 
            // pb_snake
            // 
            this.pb_snake.Image = ((System.Drawing.Image)(resources.GetObject("pb_snake.Image")));
            this.pb_snake.Location = new System.Drawing.Point(83, 69);
            this.pb_snake.Name = "pb_snake";
            this.pb_snake.Size = new System.Drawing.Size(329, 270);
            this.pb_snake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_snake.TabIndex = 1;
            this.pb_snake.TabStop = false;
            // 
            // bt_start
            // 
            this.bt_start.BackColor = System.Drawing.Color.Gold;
            this.bt_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_start.Location = new System.Drawing.Point(83, 345);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(329, 62);
            this.bt_start.TabIndex = 2;
            this.bt_start.Text = "START";
            this.bt_start.UseVisualStyleBackColor = false;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lb_points
            // 
            this.lb_points.AutoSize = true;
            this.lb_points.BackColor = System.Drawing.Color.Black;
            this.lb_points.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_points.ForeColor = System.Drawing.Color.White;
            this.lb_points.Location = new System.Drawing.Point(3, 1);
            this.lb_points.Name = "lb_points";
            this.lb_points.Size = new System.Drawing.Size(67, 15);
            this.lb_points.TabIndex = 3;
            this.lb_points.Text = "Pontos: 0";
            this.lb_points.Visible = false;
            // 
            // pn_points
            // 
            this.pn_points.BackColor = System.Drawing.Color.Black;
            this.pn_points.Controls.Add(this.lb_points);
            this.pn_points.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_points.Location = new System.Drawing.Point(0, 0);
            this.pn_points.Name = "pn_points";
            this.pn_points.Size = new System.Drawing.Size(484, 20);
            this.pn_points.TabIndex = 4;
            this.pn_points.Visible = false;
            // 
            // lb_gameover
            // 
            this.lb_gameover.AutoSize = true;
            this.lb_gameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gameover.ForeColor = System.Drawing.Color.Firebrick;
            this.lb_gameover.Location = new System.Drawing.Point(157, 201);
            this.lb_gameover.Name = "lb_gameover";
            this.lb_gameover.Size = new System.Drawing.Size(171, 31);
            this.lb_gameover.TabIndex = 5;
            this.lb_gameover.Text = "Game Over!";
            this.lb_gameover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_gameover.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lb_gameover);
            this.Controls.Add(this.pn_points);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.pb_snake);
            this.Controls.Add(this.lb_snake);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.pb_snake)).EndInit();
            this.pn_points.ResumeLayout(false);
            this.pn_points.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_snake;
        private System.Windows.Forms.PictureBox pb_snake;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_points;
        private System.Windows.Forms.Panel pn_points;
        private System.Windows.Forms.Label lb_gameover;
    }
}

