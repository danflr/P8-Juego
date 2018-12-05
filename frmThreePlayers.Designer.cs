namespace P8_JuegoLoco
{
    partial class frmThreePlayers
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblP2 = new System.Windows.Forms.Label();
            this.btnRollP2 = new System.Windows.Forms.Button();
            this.btnLeftP2 = new System.Windows.Forms.Button();
            this.btnDownP2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblP1 = new System.Windows.Forms.Label();
            this.btnRightP1 = new System.Windows.Forms.Button();
            this.btnDownP1 = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblP4 = new System.Windows.Forms.Label();
            this.btnRoll4 = new System.Windows.Forms.Button();
            this.btnLeft4 = new System.Windows.Forms.Button();
            this.btnUp4 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblP3 = new System.Windows.Forms.Label();
            this.btnRight3 = new System.Windows.Forms.Button();
            this.btnUp3 = new System.Windows.Forms.Button();
            this.btnRoll3 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblP2);
            this.groupBox2.Controls.Add(this.btnRollP2);
            this.groupBox2.Controls.Add(this.btnLeftP2);
            this.groupBox2.Controls.Add(this.btnDownP2);
            this.groupBox2.Location = new System.Drawing.Point(267, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 124);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jugador 2";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblP1);
            this.groupBox1.Controls.Add(this.btnRightP1);
            this.groupBox1.Controls.Add(this.btnDownP1);
            this.groupBox1.Controls.Add(this.btnRoll);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 124);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jugador 1";
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
            this.dgGrid.Location = new System.Drawing.Point(12, 142);
            this.dgGrid.Name = "dgGrid";
            this.dgGrid.Size = new System.Drawing.Size(502, 500);
            this.dgGrid.TabIndex = 4;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblP4);
            this.groupBox3.Controls.Add(this.btnRoll4);
            this.groupBox3.Controls.Add(this.btnLeft4);
            this.groupBox3.Controls.Add(this.btnUp4);
            this.groupBox3.Location = new System.Drawing.Point(267, 648);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 124);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Jugador 4";
            // 
            // lblP4
            // 
            this.lblP4.AutoSize = true;
            this.lblP4.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP4.Location = new System.Drawing.Point(36, 44);
            this.lblP4.Name = "lblP4";
            this.lblP4.Size = new System.Drawing.Size(42, 46);
            this.lblP4.TabIndex = 7;
            this.lblP4.Text = "0";
            // 
            // btnRoll4
            // 
            this.btnRoll4.Location = new System.Drawing.Point(133, 35);
            this.btnRoll4.Name = "btnRoll4";
            this.btnRoll4.Size = new System.Drawing.Size(108, 23);
            this.btnRoll4.TabIndex = 4;
            this.btnRoll4.Text = "Rodar dado";
            this.btnRoll4.UseVisualStyleBackColor = true;
            this.btnRoll4.Click += new System.EventHandler(this.btnRoll4_Click);
            // 
            // btnLeft4
            // 
            this.btnLeft4.Location = new System.Drawing.Point(133, 64);
            this.btnLeft4.Name = "btnLeft4";
            this.btnLeft4.Size = new System.Drawing.Size(108, 23);
            this.btnLeft4.TabIndex = 6;
            this.btnLeft4.Text = "Avanzar Izquierda";
            this.btnLeft4.UseVisualStyleBackColor = true;
            this.btnLeft4.Click += new System.EventHandler(this.btnLeft4_Click);
            // 
            // btnUp4
            // 
            this.btnUp4.Location = new System.Drawing.Point(133, 95);
            this.btnUp4.Name = "btnUp4";
            this.btnUp4.Size = new System.Drawing.Size(108, 23);
            this.btnUp4.TabIndex = 5;
            this.btnUp4.Text = "Avanzar Arriba";
            this.btnUp4.UseVisualStyleBackColor = true;
            this.btnUp4.Click += new System.EventHandler(this.btnUp4_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblP3);
            this.groupBox4.Controls.Add(this.btnRight3);
            this.groupBox4.Controls.Add(this.btnUp3);
            this.groupBox4.Controls.Add(this.btnRoll3);
            this.groupBox4.Location = new System.Drawing.Point(12, 648);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(249, 124);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Jugador 3";
            // 
            // lblP3
            // 
            this.lblP3.AutoSize = true;
            this.lblP3.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP3.Location = new System.Drawing.Point(38, 44);
            this.lblP3.Name = "lblP3";
            this.lblP3.Size = new System.Drawing.Size(42, 46);
            this.lblP3.TabIndex = 3;
            this.lblP3.Text = "0";
            // 
            // btnRight3
            // 
            this.btnRight3.Location = new System.Drawing.Point(135, 64);
            this.btnRight3.Name = "btnRight3";
            this.btnRight3.Size = new System.Drawing.Size(108, 23);
            this.btnRight3.TabIndex = 2;
            this.btnRight3.Text = "Avanzar Derecha";
            this.btnRight3.UseVisualStyleBackColor = true;
            this.btnRight3.Click += new System.EventHandler(this.btnRight3_Click);
            // 
            // btnUp3
            // 
            this.btnUp3.Location = new System.Drawing.Point(135, 95);
            this.btnUp3.Name = "btnUp3";
            this.btnUp3.Size = new System.Drawing.Size(108, 23);
            this.btnUp3.TabIndex = 1;
            this.btnUp3.Text = "Avanzar Arriba";
            this.btnUp3.UseVisualStyleBackColor = true;
            this.btnUp3.Click += new System.EventHandler(this.btnUp3_Click);
            // 
            // btnRoll3
            // 
            this.btnRoll3.Location = new System.Drawing.Point(135, 35);
            this.btnRoll3.Name = "btnRoll3";
            this.btnRoll3.Size = new System.Drawing.Size(108, 23);
            this.btnRoll3.TabIndex = 0;
            this.btnRoll3.Text = "Rodar dado";
            this.btnRoll3.UseVisualStyleBackColor = true;
            this.btnRoll3.Click += new System.EventHandler(this.btnRoll3_Click);
            // 
            // frmThreePlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 780);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgGrid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThreePlayers";
            this.Text = "frmThreePlayers";
            this.Load += new System.EventHandler(this.frmThreePlayers_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.Button btnRollP2;
        private System.Windows.Forms.Button btnLeftP2;
        private System.Windows.Forms.Button btnDownP2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Button btnRightP1;
        private System.Windows.Forms.Button btnDownP1;
        private System.Windows.Forms.Button btnRoll;
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblP4;
        private System.Windows.Forms.Button btnRoll4;
        private System.Windows.Forms.Button btnLeft4;
        private System.Windows.Forms.Button btnUp4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblP3;
        private System.Windows.Forms.Button btnRight3;
        private System.Windows.Forms.Button btnUp3;
        private System.Windows.Forms.Button btnRoll3;
    }
}