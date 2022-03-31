
namespace TicTacToe
{
    partial class AddPlayerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstnameTb = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.surnameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pInfoLabel = new System.Windows.Forms.Label();
            this.DobDtp = new System.Windows.Forms.DateTimePicker();
            this.addNewPlayerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname";
            // 
            // firstnameTb
            // 
            this.firstnameTb.Location = new System.Drawing.Point(302, 147);
            this.firstnameTb.Name = "firstnameTb";
            this.firstnameTb.Size = new System.Drawing.Size(200, 20);
            this.firstnameTb.TabIndex = 1;
            this.firstnameTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstnameTb_KeyPress);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(299, 170);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(49, 13);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Surname";
            // 
            // surnameTb
            // 
            this.surnameTb.Location = new System.Drawing.Point(302, 186);
            this.surnameTb.Name = "surnameTb";
            this.surnameTb.Size = new System.Drawing.Size(200, 20);
            this.surnameTb.TabIndex = 3;
            this.surnameTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstnameTb_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date of Birth";
            // 
            // pInfoLabel
            // 
            this.pInfoLabel.AutoSize = true;
            this.pInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pInfoLabel.Location = new System.Drawing.Point(308, 63);
            this.pInfoLabel.Name = "pInfoLabel";
            this.pInfoLabel.Size = new System.Drawing.Size(179, 37);
            this.pInfoLabel.TabIndex = 6;
            this.pInfoLabel.Text = "Player Info";
            // 
            // DobDtp
            // 
            this.DobDtp.Location = new System.Drawing.Point(302, 234);
            this.DobDtp.Name = "DobDtp";
            this.DobDtp.Size = new System.Drawing.Size(200, 20);
            this.DobDtp.TabIndex = 7;
            this.DobDtp.ValueChanged += new System.EventHandler(this.DobDtp_ValueChanged);
            // 
            // addNewPlayerBtn
            // 
            this.addNewPlayerBtn.Location = new System.Drawing.Point(340, 272);
            this.addNewPlayerBtn.Name = "addNewPlayerBtn";
            this.addNewPlayerBtn.Size = new System.Drawing.Size(115, 45);
            this.addNewPlayerBtn.TabIndex = 8;
            this.addNewPlayerBtn.Text = "Add Player";
            this.addNewPlayerBtn.UseVisualStyleBackColor = true;
            this.addNewPlayerBtn.Click += new System.EventHandler(this.addNewPlayerBtn_Click);
            // 
            // AddPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addNewPlayerBtn);
            this.Controls.Add(this.DobDtp);
            this.Controls.Add(this.pInfoLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surnameTb);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.firstnameTb);
            this.Controls.Add(this.label1);
            this.Name = "AddPlayerForm";
            this.Text = "AddPlayerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstnameTb;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox surnameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pInfoLabel;
        private System.Windows.Forms.DateTimePicker DobDtp;
        private System.Windows.Forms.Button addNewPlayerBtn;
    }
}