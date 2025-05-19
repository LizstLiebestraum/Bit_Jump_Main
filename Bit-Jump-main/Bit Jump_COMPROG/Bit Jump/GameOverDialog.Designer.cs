namespace Bit_Jump
{
    partial class GameOverDialog
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMessage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblMessage
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("PixelFont", 14F);
            this.lblMessage.Location = new System.Drawing.Point(50, 20);
            this.lblMessage.Text = "Game Over!";
            this.lblMessage.ForeColor = System.Drawing.Color.Red;

            // btnRestart
            this.btnRestart.Font = new System.Drawing.Font("PixelFont", 12F);
            this.btnRestart.Location = new System.Drawing.Point(30, 60);
            this.btnRestart.Size = new System.Drawing.Size(100, 40);
            this.btnRestart.Text = "Restart";
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);

            // btnMenu
            this.btnMenu.Font = new System.Drawing.Font("PixelFont", 12F);
            this.btnMenu.Location = new System.Drawing.Point(140, 60);
            this.btnMenu.Size = new System.Drawing.Size(100, 40);
            this.btnMenu.Text = "Menu";
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);

            // btnExit
            this.btnExit.Font = new System.Drawing.Font("PixelFont", 12F);
            this.btnExit.Location = new System.Drawing.Point(85, 110);
            this.btnExit.Size = new System.Drawing.Size(100, 40);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // GameOverDialog
            this.ClientSize = new System.Drawing.Size(280, 170);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GameOverDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Over";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
