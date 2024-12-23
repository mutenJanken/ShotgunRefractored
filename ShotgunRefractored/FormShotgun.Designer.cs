namespace ShotgunRefractored
{
    partial class FormShotgun
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShotgun));
            cmdShoot = new Button();
            cmdLoad = new Button();
            cmdBlock = new Button();
            cmdShotgun = new Button();
            textBoxTurn = new TextBox();
            textBoxBotBullets = new TextBox();
            textBoxPlayerBullets = new TextBox();
            textBoxPlayerAction = new TextBox();
            textBoxBotAction = new TextBox();
            textBoxUserWins = new TextBox();
            textBoxBotWins = new TextBox();
            cmdPlayAgain = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cmdExitGame = new Button();
            SuspendLayout();
            // 
            // cmdShoot
            // 
            cmdShoot.Image = (Image)resources.GetObject("cmdShoot.Image");
            cmdShoot.Location = new Point(161, 599);
            cmdShoot.Margin = new Padding(6, 7, 6, 7);
            cmdShoot.Name = "cmdShoot";
            cmdShoot.Size = new Size(244, 192);
            cmdShoot.TabIndex = 0;
            cmdShoot.UseVisualStyleBackColor = true;
            cmdShoot.Click += cmdShoot_Click;
            // 
            // cmdLoad
            // 
            cmdLoad.Image = (Image)resources.GetObject("cmdLoad.Image");
            cmdLoad.Location = new Point(418, 599);
            cmdLoad.Margin = new Padding(6, 7, 6, 7);
            cmdLoad.Name = "cmdLoad";
            cmdLoad.Size = new Size(244, 192);
            cmdLoad.TabIndex = 1;
            cmdLoad.UseVisualStyleBackColor = true;
            cmdLoad.Click += cmdLoad_Click;
            // 
            // cmdBlock
            // 
            cmdBlock.Image = (Image)resources.GetObject("cmdBlock.Image");
            cmdBlock.Location = new Point(675, 599);
            cmdBlock.Margin = new Padding(6, 7, 6, 7);
            cmdBlock.Name = "cmdBlock";
            cmdBlock.Size = new Size(244, 192);
            cmdBlock.TabIndex = 2;
            cmdBlock.UseVisualStyleBackColor = true;
            cmdBlock.Click += cmdBlock_Click;
            // 
            // cmdShotgun
            // 
            cmdShotgun.Image = (Image)resources.GetObject("cmdShotgun.Image");
            cmdShotgun.Location = new Point(932, 599);
            cmdShotgun.Margin = new Padding(6, 7, 6, 7);
            cmdShotgun.Name = "cmdShotgun";
            cmdShotgun.Size = new Size(244, 192);
            cmdShotgun.TabIndex = 3;
            cmdShotgun.UseVisualStyleBackColor = true;
            cmdShotgun.Click += cmdShotgun_Click;
            // 
            // textBoxTurn
            // 
            textBoxTurn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxTurn.Location = new Point(161, 506);
            textBoxTurn.Margin = new Padding(6, 7, 6, 7);
            textBoxTurn.Name = "textBoxTurn";
            textBoxTurn.ReadOnly = true;
            textBoxTurn.Size = new Size(1011, 46);
            textBoxTurn.TabIndex = 4;
            textBoxTurn.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxBotBullets
            // 
            textBoxBotBullets.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxBotBullets.Location = new Point(962, 363);
            textBoxBotBullets.Margin = new Padding(6, 7, 6, 7);
            textBoxBotBullets.Name = "textBoxBotBullets";
            textBoxBotBullets.ReadOnly = true;
            textBoxBotBullets.Size = new Size(210, 46);
            textBoxBotBullets.TabIndex = 5;
            textBoxBotBullets.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPlayerBullets
            // 
            textBoxPlayerBullets.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPlayerBullets.Location = new Point(161, 363);
            textBoxPlayerBullets.Margin = new Padding(6, 7, 6, 7);
            textBoxPlayerBullets.Name = "textBoxPlayerBullets";
            textBoxPlayerBullets.ReadOnly = true;
            textBoxPlayerBullets.Size = new Size(210, 46);
            textBoxPlayerBullets.TabIndex = 6;
            textBoxPlayerBullets.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPlayerAction
            // 
            textBoxPlayerAction.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPlayerAction.Location = new Point(161, 434);
            textBoxPlayerAction.Margin = new Padding(6, 7, 6, 7);
            textBoxPlayerAction.Name = "textBoxPlayerAction";
            textBoxPlayerAction.ReadOnly = true;
            textBoxPlayerAction.Size = new Size(210, 46);
            textBoxPlayerAction.TabIndex = 7;
            textBoxPlayerAction.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxBotAction
            // 
            textBoxBotAction.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxBotAction.Location = new Point(962, 434);
            textBoxBotAction.Margin = new Padding(6, 7, 6, 7);
            textBoxBotAction.Name = "textBoxBotAction";
            textBoxBotAction.ReadOnly = true;
            textBoxBotAction.Size = new Size(210, 46);
            textBoxBotAction.TabIndex = 8;
            textBoxBotAction.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxUserWins
            // 
            textBoxUserWins.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxUserWins.Location = new Point(161, 286);
            textBoxUserWins.Margin = new Padding(6, 7, 6, 7);
            textBoxUserWins.Name = "textBoxUserWins";
            textBoxUserWins.ReadOnly = true;
            textBoxUserWins.Size = new Size(210, 46);
            textBoxUserWins.TabIndex = 10;
            textBoxUserWins.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxBotWins
            // 
            textBoxBotWins.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxBotWins.Location = new Point(962, 286);
            textBoxBotWins.Margin = new Padding(6, 7, 6, 7);
            textBoxBotWins.Name = "textBoxBotWins";
            textBoxBotWins.ReadOnly = true;
            textBoxBotWins.Size = new Size(210, 46);
            textBoxBotWins.TabIndex = 11;
            textBoxBotWins.TextAlign = HorizontalAlignment.Center;
            // 
            // cmdPlayAgain
            // 
            cmdPlayAgain.Location = new Point(589, 807);
            cmdPlayAgain.Margin = new Padding(6, 7, 6, 7);
            cmdPlayAgain.Name = "cmdPlayAgain";
            cmdPlayAgain.Size = new Size(161, 57);
            cmdPlayAgain.TabIndex = 12;
            cmdPlayAgain.Text = "Play again";
            cmdPlayAgain.UseVisualStyleBackColor = true;
            cmdPlayAgain.Click += cmdPlayAgain_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(161, 138);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 59);
            label1.TabIndex = 13;
            label1.Text = "Player";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(1086, 138);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 59);
            label2.TabIndex = 14;
            label2.Text = "Bot";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 294);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 41);
            label3.TabIndex = 15;
            label3.Text = "Wins";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(49, 370);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(115, 41);
            label4.TabIndex = 16;
            label4.Text = "Bullets";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(49, 442);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(109, 41);
            label5.TabIndex = 17;
            label5.Text = "Action";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(1189, 294);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(89, 41);
            label7.TabIndex = 19;
            label7.Text = "Wins";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(1189, 370);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(115, 41);
            label8.TabIndex = 20;
            label8.Text = "Bullets";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(1189, 442);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(109, 41);
            label9.TabIndex = 21;
            label9.Text = "Action";
            // 
            // cmdExitGame
            // 
            cmdExitGame.Location = new Point(1166, 30);
            cmdExitGame.Margin = new Padding(6, 7, 6, 7);
            cmdExitGame.Name = "cmdExitGame";
            cmdExitGame.Size = new Size(161, 57);
            cmdExitGame.TabIndex = 0;
            cmdExitGame.Text = "Exit game";
            cmdExitGame.Click += cmdExitGame_Click;
            // 
            // FormShotgun
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1352, 918);
            Controls.Add(cmdExitGame);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmdPlayAgain);
            Controls.Add(textBoxBotWins);
            Controls.Add(textBoxUserWins);
            Controls.Add(textBoxBotAction);
            Controls.Add(textBoxPlayerAction);
            Controls.Add(textBoxPlayerBullets);
            Controls.Add(textBoxBotBullets);
            Controls.Add(textBoxTurn);
            Controls.Add(cmdShotgun);
            Controls.Add(cmdBlock);
            Controls.Add(cmdLoad);
            Controls.Add(cmdShoot);
            Margin = new Padding(6, 7, 6, 7);
            Name = "FormShotgun";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdShoot;
        private Button cmdLoad;
        private Button cmdBlock;
        private Button cmdShotgun;
        private TextBox textBoxTurn;
        private TextBox textBoxBotBullets;
        private TextBox textBoxPlayerBullets;
        private TextBox textBoxPlayerAction;
        private TextBox textBoxBotAction;
        private TextBox textBoxUserWins;
        private TextBox textBoxBotWins;
        private Button cmdPlayAgain;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button cmdExitGame;
    }
}
