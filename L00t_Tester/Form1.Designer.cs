namespace L00t_Tester
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
            this.pnlPlayDeck = new System.Windows.Forms.Panel();
            this.txtCardClass = new System.Windows.Forms.TextBox();
            this.txtCardDescription = new System.Windows.Forms.TextBox();
            this.txtCardTitle = new System.Windows.Forms.TextBox();
            this.pnlLootDeck = new System.Windows.Forms.Panel();
            this.txtLootWorth = new System.Windows.Forms.TextBox();
            this.txtLootDescription = new System.Windows.Forms.TextBox();
            this.txtLootTitle = new System.Windows.Forms.TextBox();
            this.btnDrawCard = new System.Windows.Forms.Button();
            this.btnDrawLoot = new System.Windows.Forms.Button();
            this.btnSetUpGame = new System.Windows.Forms.Button();
            this.btnShuffleDeck = new System.Windows.Forms.Button();
            this.lvWizard = new System.Windows.Forms.ListView();
            this.WIZARD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvWarrior = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCleric = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvThief = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPlayCard = new System.Windows.Forms.Button();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.lvPlayDeck = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvLootDeck = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPlayCard2 = new System.Windows.Forms.Button();
            this.btnDrawCard2 = new System.Windows.Forms.Button();
            this.btnEndTurn2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPlayDeck.SuspendLayout();
            this.pnlLootDeck.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPlayDeck
            // 
            this.pnlPlayDeck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlPlayDeck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayDeck.Controls.Add(this.txtCardClass);
            this.pnlPlayDeck.Controls.Add(this.txtCardDescription);
            this.pnlPlayDeck.Controls.Add(this.txtCardTitle);
            this.pnlPlayDeck.Location = new System.Drawing.Point(208, 212);
            this.pnlPlayDeck.Name = "pnlPlayDeck";
            this.pnlPlayDeck.Size = new System.Drawing.Size(204, 249);
            this.pnlPlayDeck.TabIndex = 4;
            // 
            // txtCardClass
            // 
            this.txtCardClass.BackColor = System.Drawing.Color.Silver;
            this.txtCardClass.Location = new System.Drawing.Point(4, 224);
            this.txtCardClass.Name = "txtCardClass";
            this.txtCardClass.Size = new System.Drawing.Size(191, 20);
            this.txtCardClass.TabIndex = 2;
            // 
            // txtCardDescription
            // 
            this.txtCardDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCardDescription.Location = new System.Drawing.Point(4, 30);
            this.txtCardDescription.Multiline = true;
            this.txtCardDescription.Name = "txtCardDescription";
            this.txtCardDescription.Size = new System.Drawing.Size(191, 188);
            this.txtCardDescription.TabIndex = 1;
            // 
            // txtCardTitle
            // 
            this.txtCardTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtCardTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardTitle.Location = new System.Drawing.Point(4, 4);
            this.txtCardTitle.Name = "txtCardTitle";
            this.txtCardTitle.Size = new System.Drawing.Size(191, 20);
            this.txtCardTitle.TabIndex = 0;
            this.txtCardTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlLootDeck
            // 
            this.pnlLootDeck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLootDeck.Controls.Add(this.txtLootWorth);
            this.pnlLootDeck.Controls.Add(this.txtLootDescription);
            this.pnlLootDeck.Controls.Add(this.txtLootTitle);
            this.pnlLootDeck.Location = new System.Drawing.Point(418, 212);
            this.pnlLootDeck.Name = "pnlLootDeck";
            this.pnlLootDeck.Size = new System.Drawing.Size(204, 249);
            this.pnlLootDeck.TabIndex = 6;
            // 
            // txtLootWorth
            // 
            this.txtLootWorth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtLootWorth.Location = new System.Drawing.Point(4, 224);
            this.txtLootWorth.Name = "txtLootWorth";
            this.txtLootWorth.Size = new System.Drawing.Size(191, 20);
            this.txtLootWorth.TabIndex = 3;
            // 
            // txtLootDescription
            // 
            this.txtLootDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtLootDescription.Location = new System.Drawing.Point(4, 30);
            this.txtLootDescription.Multiline = true;
            this.txtLootDescription.Name = "txtLootDescription";
            this.txtLootDescription.Size = new System.Drawing.Size(191, 188);
            this.txtLootDescription.TabIndex = 2;
            // 
            // txtLootTitle
            // 
            this.txtLootTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtLootTitle.Location = new System.Drawing.Point(4, 4);
            this.txtLootTitle.Name = "txtLootTitle";
            this.txtLootTitle.Size = new System.Drawing.Size(191, 20);
            this.txtLootTitle.TabIndex = 1;
            // 
            // btnDrawCard
            // 
            this.btnDrawCard.Enabled = false;
            this.btnDrawCard.Location = new System.Drawing.Point(2, 294);
            this.btnDrawCard.Name = "btnDrawCard";
            this.btnDrawCard.Size = new System.Drawing.Size(200, 30);
            this.btnDrawCard.TabIndex = 7;
            this.btnDrawCard.Text = "&DRAW CARD";
            this.btnDrawCard.UseVisualStyleBackColor = true;
            this.btnDrawCard.Visible = false;
            this.btnDrawCard.Click += new System.EventHandler(this.btnDrawCard_Click);
            // 
            // btnDrawLoot
            // 
            this.btnDrawLoot.Enabled = false;
            this.btnDrawLoot.Location = new System.Drawing.Point(423, 176);
            this.btnDrawLoot.Name = "btnDrawLoot";
            this.btnDrawLoot.Size = new System.Drawing.Size(191, 30);
            this.btnDrawLoot.TabIndex = 8;
            this.btnDrawLoot.Text = "GRAB LOOT";
            this.btnDrawLoot.UseVisualStyleBackColor = true;
            this.btnDrawLoot.Visible = false;
            this.btnDrawLoot.Click += new System.EventHandler(this.btnDrawLoot_Click);
            // 
            // btnSetUpGame
            // 
            this.btnSetUpGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSetUpGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetUpGame.ForeColor = System.Drawing.Color.White;
            this.btnSetUpGame.Location = new System.Drawing.Point(325, 2);
            this.btnSetUpGame.Name = "btnSetUpGame";
            this.btnSetUpGame.Size = new System.Drawing.Size(199, 30);
            this.btnSetUpGame.TabIndex = 9;
            this.btnSetUpGame.Text = "SET UP GAME";
            this.btnSetUpGame.UseVisualStyleBackColor = false;
            this.btnSetUpGame.Click += new System.EventHandler(this.btnSetUpGame_Click);
            // 
            // btnShuffleDeck
            // 
            this.btnShuffleDeck.Location = new System.Drawing.Point(213, 176);
            this.btnShuffleDeck.Name = "btnShuffleDeck";
            this.btnShuffleDeck.Size = new System.Drawing.Size(191, 30);
            this.btnShuffleDeck.TabIndex = 11;
            this.btnShuffleDeck.Text = "SHUFFLE DECK";
            this.btnShuffleDeck.UseVisualStyleBackColor = true;
            this.btnShuffleDeck.Click += new System.EventHandler(this.btnShuffleDeck_Click);
            // 
            // lvWizard
            // 
            this.lvWizard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lvWizard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.WIZARD,
            this.ID});
            this.lvWizard.Location = new System.Drawing.Point(5, 11);
            this.lvWizard.MultiSelect = false;
            this.lvWizard.Name = "lvWizard";
            this.lvWizard.Size = new System.Drawing.Size(197, 159);
            this.lvWizard.TabIndex = 12;
            this.lvWizard.UseCompatibleStateImageBehavior = false;
            this.lvWizard.View = System.Windows.Forms.View.Details;
            this.lvWizard.Click += new System.EventHandler(this.lvWizard_Click);
            // 
            // WIZARD
            // 
            this.WIZARD.Text = "WIZARD";
            this.WIZARD.Width = 131;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // lvWarrior
            // 
            this.lvWarrior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lvWarrior.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvWarrior.Location = new System.Drawing.Point(628, 11);
            this.lvWarrior.MultiSelect = false;
            this.lvWarrior.Name = "lvWarrior";
            this.lvWarrior.Size = new System.Drawing.Size(197, 159);
            this.lvWarrior.TabIndex = 13;
            this.lvWarrior.UseCompatibleStateImageBehavior = false;
            this.lvWarrior.View = System.Windows.Forms.View.Details;
            this.lvWarrior.Click += new System.EventHandler(this.lvWarrior_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "WARRIOR";
            this.columnHeader1.Width = 132;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            // 
            // lvCleric
            // 
            this.lvCleric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lvCleric.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvCleric.Location = new System.Drawing.Point(5, 462);
            this.lvCleric.MultiSelect = false;
            this.lvCleric.Name = "lvCleric";
            this.lvCleric.Size = new System.Drawing.Size(197, 159);
            this.lvCleric.TabIndex = 14;
            this.lvCleric.UseCompatibleStateImageBehavior = false;
            this.lvCleric.View = System.Windows.Forms.View.Details;
            this.lvCleric.Click += new System.EventHandler(this.lvCleric_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CLERIC";
            this.columnHeader3.Width = 131;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            // 
            // lvThief
            // 
            this.lvThief.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lvThief.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lvThief.Location = new System.Drawing.Point(628, 462);
            this.lvThief.MultiSelect = false;
            this.lvThief.Name = "lvThief";
            this.lvThief.Size = new System.Drawing.Size(197, 159);
            this.lvThief.TabIndex = 15;
            this.lvThief.UseCompatibleStateImageBehavior = false;
            this.lvThief.View = System.Windows.Forms.View.Details;
            this.lvThief.Click += new System.EventHandler(this.lvThief_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "THIEF";
            this.columnHeader5.Width = 133;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            // 
            // btnPlayCard
            // 
            this.btnPlayCard.Location = new System.Drawing.Point(2, 262);
            this.btnPlayCard.Name = "btnPlayCard";
            this.btnPlayCard.Size = new System.Drawing.Size(200, 30);
            this.btnPlayCard.TabIndex = 16;
            this.btnPlayCard.Text = "PLAY CARD";
            this.btnPlayCard.UseVisualStyleBackColor = true;
            this.btnPlayCard.Visible = false;
            this.btnPlayCard.Click += new System.EventHandler(this.btnPlayCard_Click);
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Location = new System.Drawing.Point(2, 325);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(200, 29);
            this.btnEndTurn.TabIndex = 17;
            this.btnEndTurn.Text = "&END TURN";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            this.btnEndTurn.Visible = false;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // lvPlayDeck
            // 
            this.lvPlayDeck.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9});
            this.lvPlayDeck.Location = new System.Drawing.Point(841, 12);
            this.lvPlayDeck.MultiSelect = false;
            this.lvPlayDeck.Name = "lvPlayDeck";
            this.lvPlayDeck.Size = new System.Drawing.Size(170, 374);
            this.lvPlayDeck.TabIndex = 19;
            this.lvPlayDeck.UseCompatibleStateImageBehavior = false;
            this.lvPlayDeck.View = System.Windows.Forms.View.Details;
            this.lvPlayDeck.SelectedIndexChanged += new System.EventHandler(this.lvPlayDeck_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "PLAY DECK";
            this.columnHeader8.Width = 174;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ID";
            // 
            // lvLootDeck
            // 
            this.lvLootDeck.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader10});
            this.lvLootDeck.Location = new System.Drawing.Point(841, 392);
            this.lvLootDeck.MultiSelect = false;
            this.lvLootDeck.Name = "lvLootDeck";
            this.lvLootDeck.Size = new System.Drawing.Size(170, 229);
            this.lvLootDeck.TabIndex = 20;
            this.lvLootDeck.UseCompatibleStateImageBehavior = false;
            this.lvLootDeck.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "LOOT CARD";
            this.columnHeader7.Width = 174;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ID";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
            this.listView2.Location = new System.Drawing.Point(213, 483);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(405, 125);
            this.listView2.TabIndex = 21;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "PLAYER";
            this.columnHeader11.Width = 136;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "POINTS";
            // 
            // btnPlayCard2
            // 
            this.btnPlayCard2.Location = new System.Drawing.Point(628, 262);
            this.btnPlayCard2.Name = "btnPlayCard2";
            this.btnPlayCard2.Size = new System.Drawing.Size(200, 30);
            this.btnPlayCard2.TabIndex = 22;
            this.btnPlayCard2.Text = "PLAY CARD";
            this.btnPlayCard2.UseVisualStyleBackColor = true;
            this.btnPlayCard2.Visible = false;
            this.btnPlayCard2.Click += new System.EventHandler(this.btnPlayCard_Click);
            // 
            // btnDrawCard2
            // 
            this.btnDrawCard2.Enabled = false;
            this.btnDrawCard2.Location = new System.Drawing.Point(628, 294);
            this.btnDrawCard2.Name = "btnDrawCard2";
            this.btnDrawCard2.Size = new System.Drawing.Size(200, 30);
            this.btnDrawCard2.TabIndex = 23;
            this.btnDrawCard2.Text = "&DRAW CARD";
            this.btnDrawCard2.UseVisualStyleBackColor = true;
            this.btnDrawCard2.Visible = false;
            this.btnDrawCard2.Click += new System.EventHandler(this.btnDrawCard_Click);
            // 
            // btnEndTurn2
            // 
            this.btnEndTurn2.Location = new System.Drawing.Point(628, 325);
            this.btnEndTurn2.Name = "btnEndTurn2";
            this.btnEndTurn2.Size = new System.Drawing.Size(200, 29);
            this.btnEndTurn2.TabIndex = 24;
            this.btnEndTurn2.Text = "&END TURN";
            this.btnEndTurn2.UseVisualStyleBackColor = true;
            this.btnEndTurn2.Visible = false;
            this.btnEndTurn2.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(338, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 63);
            this.label1.TabIndex = 25;
            this.label1.Text = "L00T!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::L00t_Tester.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1021, 633);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEndTurn2);
            this.Controls.Add(this.btnDrawCard2);
            this.Controls.Add(this.btnPlayCard2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.lvLootDeck);
            this.Controls.Add(this.lvPlayDeck);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.btnPlayCard);
            this.Controls.Add(this.lvThief);
            this.Controls.Add(this.lvCleric);
            this.Controls.Add(this.lvWarrior);
            this.Controls.Add(this.lvWizard);
            this.Controls.Add(this.btnShuffleDeck);
            this.Controls.Add(this.btnSetUpGame);
            this.Controls.Add(this.btnDrawLoot);
            this.Controls.Add(this.btnDrawCard);
            this.Controls.Add(this.pnlLootDeck);
            this.Controls.Add(this.pnlPlayDeck);
            this.Name = "Form1";
            this.Text = "4 Rivals";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlPlayDeck.ResumeLayout(false);
            this.pnlPlayDeck.PerformLayout();
            this.pnlLootDeck.ResumeLayout(false);
            this.pnlLootDeck.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlPlayDeck;
        private System.Windows.Forms.Panel pnlLootDeck;
        private System.Windows.Forms.Button btnDrawCard;
        private System.Windows.Forms.Button btnDrawLoot;
        private System.Windows.Forms.Button btnSetUpGame;
        private System.Windows.Forms.TextBox txtCardDescription;
        private System.Windows.Forms.TextBox txtCardTitle;
        private System.Windows.Forms.TextBox txtCardClass;
        private System.Windows.Forms.TextBox txtLootWorth;
        private System.Windows.Forms.TextBox txtLootDescription;
        private System.Windows.Forms.TextBox txtLootTitle;
        private System.Windows.Forms.Button btnShuffleDeck;
        private System.Windows.Forms.ListView lvWizard;
        private System.Windows.Forms.ColumnHeader WIZARD;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ListView lvWarrior;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvCleric;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lvThief;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnPlayCard;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.ListView lvPlayDeck;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView lvLootDeck;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button btnPlayCard2;
        private System.Windows.Forms.Button btnDrawCard2;
        private System.Windows.Forms.Button btnEndTurn2;
        private System.Windows.Forms.Label label1;
    }
}

