namespace BlackJack
{
    partial class Form1
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
            ShuffleDeck = new Button();
            DrawCard = new Button();
            DrawCardText = new Label();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            Player1Card1 = new Label();
            Player1Card2 = new Label();
            Player2Card2 = new Label();
            Player2Card1 = new Label();
            DealerCard2 = new Label();
            dealerCard1 = new Label();
            SuspendLayout();
            // 
            // ShuffleDeck
            // 
            ShuffleDeck.Location = new Point(157, 84);
            ShuffleDeck.Name = "ShuffleDeck";
            ShuffleDeck.Size = new Size(94, 29);
            ShuffleDeck.TabIndex = 0;
            ShuffleDeck.Text = "Shuflle";
            ShuffleDeck.UseVisualStyleBackColor = true;
            ShuffleDeck.Click += ShuffleDeck_Click;
            // 
            // DrawCard
            // 
            DrawCard.Location = new Point(186, 236);
            DrawCard.Name = "DrawCard";
            DrawCard.Size = new Size(94, 29);
            DrawCard.TabIndex = 1;
            DrawCard.Text = "Draw Card";
            DrawCard.UseVisualStyleBackColor = true;
            DrawCard.Click += DrawCard_Click;
            // 
            // DrawCardText
            // 
            DrawCardText.AutoSize = true;
            DrawCardText.Location = new Point(179, 202);
            DrawCardText.Name = "DrawCardText";
            DrawCardText.Size = new Size(106, 20);
            DrawCardText.TabIndex = 2;
            DrawCardText.Text = "Draw card text";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(607, 329);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(157, 348);
            button1.Name = "button1";
            button1.Size = new Size(128, 29);
            button1.TabIndex = 6;
            button1.Text = "Dealing cards";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(359, 37);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(359, 71);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(487, 37);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(487, 71);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(531, 178);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(531, 211);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(493, 84);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 13;
            label8.Text = "Player 2 Hand";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(375, 84);
            label9.Name = "label9";
            label9.Size = new Size(101, 20);
            label9.TabIndex = 14;
            label9.Text = "Player 1 Hand";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(430, 231);
            label10.Name = "label10";
            label10.Size = new Size(105, 20);
            label10.TabIndex = 15;
            label10.Text = "Dealer 2 Hand";
            // 
            // Player1Card1
            // 
            Player1Card1.AutoSize = true;
            Player1Card1.Location = new Point(375, 122);
            Player1Card1.Name = "Player1Card1";
            Player1Card1.Size = new Size(104, 20);
            Player1Card1.TabIndex = 16;
            Player1Card1.Text = "Player 1 Card1";
            // 
            // Player1Card2
            // 
            Player1Card2.AutoSize = true;
            Player1Card2.Location = new Point(375, 155);
            Player1Card2.Name = "Player1Card2";
            Player1Card2.Size = new Size(104, 20);
            Player1Card2.TabIndex = 17;
            Player1Card2.Text = "Player 1 Card2";
            // 
            // Player2Card2
            // 
            Player2Card2.AutoSize = true;
            Player2Card2.Location = new Point(540, 155);
            Player2Card2.Name = "Player2Card2";
            Player2Card2.Size = new Size(104, 20);
            Player2Card2.TabIndex = 19;
            Player2Card2.Text = "Player 2 Card2";
            // 
            // Player2Card1
            // 
            Player2Card1.AutoSize = true;
            Player2Card1.Location = new Point(540, 122);
            Player2Card1.Name = "Player2Card1";
            Player2Card1.Size = new Size(104, 20);
            Player2Card1.TabIndex = 18;
            Player2Card1.Text = "Player 2 Card1";
            // 
            // DealerCard2
            // 
            DealerCard2.AutoSize = true;
            DealerCard2.Location = new Point(431, 299);
            DealerCard2.Name = "DealerCard2";
            DealerCard2.Size = new Size(100, 20);
            DealerCard2.TabIndex = 21;
            DealerCard2.Text = "Dealer  Card2";
            // 
            // dealerCard1
            // 
            dealerCard1.AutoSize = true;
            dealerCard1.Location = new Point(431, 266);
            dealerCard1.Name = "dealerCard1";
            dealerCard1.Size = new Size(96, 20);
            dealerCard1.TabIndex = 20;
            dealerCard1.Text = "Dealer Card1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DealerCard2);
            Controls.Add(dealerCard1);
            Controls.Add(Player2Card2);
            Controls.Add(Player2Card1);
            Controls.Add(Player1Card2);
            Controls.Add(Player1Card1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(DrawCardText);
            Controls.Add(DrawCard);
            Controls.Add(ShuffleDeck);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ShuffleDeck;
        private Button DrawCard;
        private Label DrawCardText;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label Player1Card1;
        private Label Player1Card2;
        private Label Player2Card2;
        private Label Player2Card1;
        private Label DealerCard2;
        private Label dealerCard1;
    }
}
