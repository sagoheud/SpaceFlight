namespace SpaceFlight
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MoveBgTimer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.LeftMove = new System.Windows.Forms.Timer(this.components);
            this.RightMove = new System.Windows.Forms.Timer(this.components);
            this.UpMove = new System.Windows.Forms.Timer(this.components);
            this.DownMove = new System.Windows.Forms.Timer(this.components);
            this.MunitionMove = new System.Windows.Forms.Timer(this.components);
            this.MoveEnemies = new System.Windows.Forms.Timer(this.components);
            this.EnemiesMunition = new System.Windows.Forms.Timer(this.components);
            this.txtLv = new System.Windows.Forms.Label();
            this.btnReplay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.scorelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.levellbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBgTimer
            // 
            this.MoveBgTimer.Enabled = true;
            this.MoveBgTimer.Interval = 10;
            this.MoveBgTimer.Tick += new System.EventHandler(this.MoveBgTimer_Tick);
            // 
            // Player
            // 
            this.Player.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.ErrorImage = global::SpaceFlight.Properties.Resources.Player;
            this.Player.Image = global::SpaceFlight.Properties.Resources.Player;
            this.Player.InitialImage = null;
            this.Player.Location = new System.Drawing.Point(264, 400);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 50);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // LeftMove
            // 
            this.LeftMove.Interval = 5;
            this.LeftMove.Tick += new System.EventHandler(this.LeftMove_Tick);
            // 
            // RightMove
            // 
            this.RightMove.Interval = 5;
            this.RightMove.Tick += new System.EventHandler(this.RightMove_Tick);
            // 
            // UpMove
            // 
            this.UpMove.Interval = 5;
            this.UpMove.Tick += new System.EventHandler(this.UpMove_Tick);
            // 
            // DownMove
            // 
            this.DownMove.Interval = 5;
            this.DownMove.Tick += new System.EventHandler(this.DownMove_Tick);
            // 
            // MunitionMove
            // 
            this.MunitionMove.Enabled = true;
            this.MunitionMove.Interval = 20;
            this.MunitionMove.Tick += new System.EventHandler(this.MunitionMove_Tick);
            // 
            // MoveEnemies
            // 
            this.MoveEnemies.Enabled = true;
            this.MoveEnemies.Tick += new System.EventHandler(this.MoveEnemies_Tick);
            // 
            // EnemiesMunition
            // 
            this.EnemiesMunition.Enabled = true;
            this.EnemiesMunition.Interval = 20;
            this.EnemiesMunition.Tick += new System.EventHandler(this.EnemiesMunition_Tick);
            // 
            // txtLv
            // 
            this.txtLv.AutoSize = true;
            this.txtLv.BackColor = System.Drawing.Color.Transparent;
            this.txtLv.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLv.ForeColor = System.Drawing.Color.White;
            this.txtLv.Location = new System.Drawing.Point(145, 120);
            this.txtLv.Name = "txtLv";
            this.txtLv.Size = new System.Drawing.Size(283, 65);
            this.txtLv.TabIndex = 1;
            this.txtLv.Text = "LABEL1";
            this.txtLv.Visible = false;
            // 
            // btnReplay
            // 
            this.btnReplay.BackColor = System.Drawing.Color.Transparent;
            this.btnReplay.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplay.Location = new System.Drawing.Point(160, 200);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(255, 55);
            this.btnReplay.TabIndex = 2;
            this.btnReplay.Text = "Replay";
            this.btnReplay.UseVisualStyleBackColor = false;
            this.btnReplay.Visible = false;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(160, 270);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(255, 55);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // scorelbl
            // 
            this.scorelbl.AutoSize = true;
            this.scorelbl.BackColor = System.Drawing.Color.Transparent;
            this.scorelbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelbl.ForeColor = System.Drawing.Color.Yellow;
            this.scorelbl.Location = new System.Drawing.Point(94, 13);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(28, 21);
            this.scorelbl.TabIndex = 3;
            this.scorelbl.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "SCORE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(491, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "LEVEL:";
            // 
            // levellbl
            // 
            this.levellbl.AutoSize = true;
            this.levellbl.BackColor = System.Drawing.Color.Transparent;
            this.levellbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levellbl.ForeColor = System.Drawing.Color.Yellow;
            this.levellbl.Location = new System.Drawing.Point(553, 9);
            this.levellbl.Name = "levellbl";
            this.levellbl.Size = new System.Drawing.Size(28, 21);
            this.levellbl.TabIndex = 3;
            this.levellbl.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.levellbl);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.txtLv);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Flight";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MoveBgTimer;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer LeftMove;
        private System.Windows.Forms.Timer RightMove;
        private System.Windows.Forms.Timer UpMove;
        private System.Windows.Forms.Timer DownMove;
        private System.Windows.Forms.Timer MunitionMove;
        private System.Windows.Forms.Timer MoveEnemies;
        private System.Windows.Forms.Timer EnemiesMunition;
        private System.Windows.Forms.Label txtLv;
        private System.Windows.Forms.Button btnReplay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label levellbl;
    }
}

