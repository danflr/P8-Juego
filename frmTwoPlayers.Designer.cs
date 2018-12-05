namespace P8_JuegoLoco
{
    partial class frmTwoPlayers
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbGrid = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnDownP1 = new System.Windows.Forms.Button();
            this.btnRightP1 = new System.Windows.Forms.Button();
            this.lblP1 = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.btnLeftP2 = new System.Windows.Forms.Button();
            this.btnDownP2 = new System.Windows.Forms.Button();
            this.btnRollP2 = new System.Windows.Forms.Button();
            this.dgGrid = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.J = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblP1);
            this.groupBox1.Controls.Add(this.btnRightP1);
            this.groupBox1.Controls.Add(this.btnDownP1);
            this.groupBox1.Controls.Add(this.btnRoll);
            this.groupBox1.Location = new System.Drawing.Point(13, 519);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jugador 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblP2);
            this.groupBox2.Controls.Add(this.btnRollP2);
            this.groupBox2.Controls.Add(this.btnLeftP2);
            this.groupBox2.Controls.Add(this.btnDownP2);
            this.groupBox2.Location = new System.Drawing.Point(268, 519);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jugador 2";
            // 
            // pbGrid
            // 
            this.pbGrid.Location = new System.Drawing.Point(13, 13);
            this.pbGrid.Name = "pbGrid";
            this.pbGrid.Size = new System.Drawing.Size(500, 500);
            this.pbGrid.TabIndex = 2;
            this.pbGrid.TabStop = false;
            this.pbGrid.Visible = false;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(135, 35);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(108, 23);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Rodar dado";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnDownP1
            // 
            this.btnDownP1.Location = new System.Drawing.Point(135, 95);
            this.btnDownP1.Name = "btnDownP1";
            this.btnDownP1.Size = new System.Drawing.Size(108, 23);
            this.btnDownP1.TabIndex = 1;
            this.btnDownP1.Text = "Avanzar Abajo";
            this.btnDownP1.UseVisualStyleBackColor = true;
            this.btnDownP1.Click += new System.EventHandler(this.btnDownP1_Click);
            // 
            // btnRightP1
            // 
            this.btnRightP1.Location = new System.Drawing.Point(135, 64);
            this.btnRightP1.Name = "btnRightP1";
            this.btnRightP1.Size = new System.Drawing.Size(108, 23);
            this.btnRightP1.TabIndex = 2;
            this.btnRightP1.Text = "Avanzar Derecha";
            this.btnRightP1.UseVisualStyleBackColor = true;
            this.btnRightP1.Click += new System.EventHandler(this.btnRightP1_Click);
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1.Location = new System.Drawing.Point(38, 44);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(42, 46);
            this.lblP1.TabIndex = 3;
            this.lblP1.Text = "0";
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2.Location = new System.Drawing.Point(36, 44);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(42, 46);
            this.lblP2.TabIndex = 7;
            this.lblP2.Text = "0";
            // 
            // btnLeftP2
            // 
            this.btnLeftP2.Location = new System.Drawing.Point(133, 64);
            this.btnLeftP2.Name = "btnLeftP2";
            this.btnLeftP2.Size = new System.Drawing.Size(108, 23);
            this.btnLeftP2.TabIndex = 6;
            this.btnLeftP2.Text = "Avanzar Izquierda";
            this.btnLeftP2.UseVisualStyleBackColor = true;
            this.btnLeftP2.Click += new System.EventHandler(this.btnLeftP2_Click);
            // 
            // btnDownP2
            // 
            this.btnDownP2.Location = new System.Drawing.Point(133, 95);
            this.btnDownP2.Name = "btnDownP2";
            this.btnDownP2.Size = new System.Drawing.Size(108, 23);
            this.btnDownP2.TabIndex = 5;
            this.btnDownP2.Text = "Avanzar Abajo";
            this.btnDownP2.UseVisualStyleBackColor = true;
            this.btnDownP2.Click += new System.EventHandler(this.btnDownP2_Click);
            // 
            // btnRollP2
            // 
            this.btnRollP2.Location = new System.Drawing.Point(133, 35);
            this.btnRollP2.Name = "btnRollP2";
            this.btnRollP2.Size = new System.Drawing.Size(108, 23);
            this.btnRollP2.TabIndex = 4;
            this.btnRollP2.Text = "Rodar dado";
            this.btnRollP2.UseVisualStyleBackColor = true;
            this.btnRollP2.Click += new System.EventHandler(this.btnRollP2_Click);
            // 
            // dgGrid
            // 
            this.dgGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.b,
            this.C,
            this.D,
            this.E,
            this.F,
            this.G,
            this.H,
            this.I,
            this.J});
            this.dgGrid.Enabled = false;
            this.dgGrid.Location = new System.Drawing.Point(13, 13);
            this.dgGrid.Name = "dgGrid";
            this.dgGrid.Size = new System.Drawing.Size(502, 500);
            this.dgGrid.TabIndex = 3;
            // 
            // a
            // 
            this.a.HeaderText = "A";
            this.a.Name = "a";
            // 
            // b
            // 
            this.b.HeaderText = "B";
            this.b.Name = "b";
            // 
            // C
            // 
            this.C.HeaderText = "C";
            this.C.Name = "C";
            // 
            // D
            // 
            this.D.HeaderText = "D";
            this.D.Name = "D";
            this.D.ReadOnly = true;
            // 
            // E
            // 
            this.E.HeaderText = "E";
            this.E.Name = "E";
            this.E.ReadOnly = true;
            // 
            // F
            // 
            this.F.HeaderText = "F";
            this.F.Name = "F";
            this.F.ReadOnly = true;
            // 
            // G
            // 
            this.G.HeaderText = "G";
            this.G.Name = "G";
            this.G.ReadOnly = true;
            // 
            // H
            // 
            this.H.HeaderText = "H";
            this.H.Name = "H";
            this.H.ReadOnly = true;
            // 
            // I
            // 
            this.I.HeaderText = "I";
            this.I.Name = "I";
            this.I.ReadOnly = true;
            // 
            // J
            // 
            this.J.HeaderText = "J";
            this.J.Name = "J";
            this.J.ReadOnly = true;
            // 
            // frmTwoPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 655);
            this.Controls.Add(this.dgGrid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbGrid);
            this.Name = "frmTwoPlayers";
            this.Text = "Juego loco";
            this.Load += new System.EventHandler(this.frmTwoPlayers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbGrid;
        private System.Windows.Forms.Button btnRightP1;
        private System.Windows.Forms.Button btnDownP1;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.Button btnRollP2;
        private System.Windows.Forms.Button btnLeftP2;
        private System.Windows.Forms.Button btnDownP2;
        private System.Windows.Forms.DataGridView dgGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn E;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataGridViewTextBoxColumn G;
        private System.Windows.Forms.DataGridViewTextBoxColumn H;
        private System.Windows.Forms.DataGridViewTextBoxColumn I;
        private System.Windows.Forms.DataGridViewTextBoxColumn J;
    }
}