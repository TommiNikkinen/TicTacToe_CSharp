
namespace TicTacToe
{
    partial class Form3
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
            this.pInfoTitleLabel = new System.Windows.Forms.Label();
            this.p1Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.p1DataGridView = new System.Windows.Forms.DataGridView();
            this.p2DataGridView = new System.Windows.Forms.DataGridView();
            this.addPlayerBtn = new System.Windows.Forms.Button();
            this.startGameBtn = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.p1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2DataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pInfoTitleLabel
            // 
            this.pInfoTitleLabel.AutoSize = true;
            this.pInfoTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pInfoTitleLabel.Location = new System.Drawing.Point(305, 108);
            this.pInfoTitleLabel.Name = "pInfoTitleLabel";
            this.pInfoTitleLabel.Size = new System.Drawing.Size(206, 31);
            this.pInfoTitleLabel.TabIndex = 0;
            this.pInfoTitleLabel.Text = "Choose Players";
            // 
            // p1Label
            // 
            this.p1Label.AutoSize = true;
            this.p1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Label.Location = new System.Drawing.Point(147, 151);
            this.p1Label.Name = "p1Label";
            this.p1Label.Size = new System.Drawing.Size(65, 20);
            this.p1Label.TabIndex = 1;
            this.p1Label.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(606, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player 2";
            // 
            // p1DataGridView
            // 
            this.p1DataGridView.AllowUserToDeleteRows = false;
            this.p1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.p1DataGridView.Location = new System.Drawing.Point(12, 197);
            this.p1DataGridView.MultiSelect = false;
            this.p1DataGridView.Name = "p1DataGridView";
            this.p1DataGridView.ReadOnly = true;
            this.p1DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.p1DataGridView.Size = new System.Drawing.Size(347, 204);
            this.p1DataGridView.TabIndex = 3;
            // 
            // p2DataGridView
            // 
            this.p2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.p2DataGridView.Location = new System.Drawing.Point(473, 197);
            this.p2DataGridView.MultiSelect = false;
            this.p2DataGridView.Name = "p2DataGridView";
            this.p2DataGridView.ReadOnly = true;
            this.p2DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.p2DataGridView.Size = new System.Drawing.Size(331, 204);
            this.p2DataGridView.TabIndex = 4;
            // 
            // addPlayerBtn
            // 
            this.addPlayerBtn.Location = new System.Drawing.Point(382, 287);
            this.addPlayerBtn.Name = "addPlayerBtn";
            this.addPlayerBtn.Size = new System.Drawing.Size(75, 23);
            this.addPlayerBtn.TabIndex = 5;
            this.addPlayerBtn.Text = "Add Player";
            this.addPlayerBtn.UseVisualStyleBackColor = true;
            this.addPlayerBtn.Click += new System.EventHandler(this.addPlayerBtn_Click);
            // 
            // startGameBtn
            // 
            this.startGameBtn.Location = new System.Drawing.Point(290, 427);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(244, 69);
            this.startGameBtn.TabIndex = 6;
            this.startGameBtn.Text = "START GAME";
            this.startGameBtn.UseVisualStyleBackColor = true;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(209, 48);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(388, 37);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Tic Tac Toe - The Game";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 525);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.startGameBtn);
            this.Controls.Add(this.addPlayerBtn);
            this.Controls.Add(this.p2DataGridView);
            this.Controls.Add(this.p1DataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p1Label);
            this.Controls.Add(this.pInfoTitleLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Tic Tac Toe - The Game";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2DataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pInfoTitleLabel;
        private System.Windows.Forms.Label p1Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView p1DataGridView;
        private System.Windows.Forms.DataGridView p2DataGridView;
        private System.Windows.Forms.Button addPlayerBtn;
        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
    }
}