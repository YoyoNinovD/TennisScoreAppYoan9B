namespace Tennis_Score_App
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listViewRanking = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            listViewLatestGame = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Onyx", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(332, 9);
            label1.Name = "label1";
            label1.Size = new Size(158, 45);
            label1.TabIndex = 0;
            label1.Text = "Tennis Score";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell Extra Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(33, 45);
            label2.Name = "label2";
            label2.Size = new Size(126, 35);
            label2.TabIndex = 4;
            label2.Text = "Ranking";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell Extra Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(33, 251);
            label3.Name = "label3";
            label3.Size = new Size(183, 35);
            label3.TabIndex = 5;
            label3.Text = "Latest Game\r\n";
            label3.Click += label3_Click;
            // 
            // listViewRanking
            // 
            listViewRanking.BackColor = Color.Orange;
            listViewRanking.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewRanking.Location = new Point(33, 103);
            listViewRanking.Margin = new Padding(3, 2, 3, 2);
            listViewRanking.Name = "listViewRanking";
            listViewRanking.Size = new Size(623, 115);
            listViewRanking.TabIndex = 6;
            listViewRanking.UseCompatibleStateImageBehavior = false;
            listViewRanking.View = View.Details;
            listViewRanking.SelectedIndexChanged += listViewRanking_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "PlayerName";
            columnHeader1.Width = 350;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Score";
            columnHeader2.Width = 265;
            // 
            // listViewLatestGame
            // 
            listViewLatestGame.BackColor = Color.Orange;
            listViewLatestGame.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewLatestGame.Location = new Point(33, 303);
            listViewLatestGame.Margin = new Padding(3, 2, 3, 2);
            listViewLatestGame.Name = "listViewLatestGame";
            listViewLatestGame.Size = new Size(663, 123);
            listViewLatestGame.TabIndex = 7;
            listViewLatestGame.UseCompatibleStateImageBehavior = false;
            listViewLatestGame.View = View.Details;
            listViewLatestGame.SelectedIndexChanged += listViewLatestGame_SelectedIndexChanged;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "First Player";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Second Player";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Winner";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Score";
            columnHeader6.Width = 66;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(449, 251);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(200, 35);
            button1.TabIndex = 9;
            button1.Text = "Add New Game";
            button1.UseVisualStyleBackColor = false;
            button1.Click += AddNewGameButtonClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listViewLatestGame);
            Controls.Add(listViewRanking);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "ScoreForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListView listViewRanking;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView listViewLatestGame;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button button1;
    }
}