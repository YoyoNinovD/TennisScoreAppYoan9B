namespace Tennis_Score_App
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
            PlayerName = new Label();
            Victories = new Label();
            label3 = new Label();
            label4 = new Label();
            listViewVictories = new ListView();
            CompetitorHeader = new ColumnHeader();
            ScoreHeader = new ColumnHeader();
            listViewLosses = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            listViewDraw = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // PlayerName
            // 
            PlayerName.AutoSize = true;
            PlayerName.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            PlayerName.Location = new Point(287, 39);
            PlayerName.Name = "PlayerName";
            PlayerName.Size = new Size(227, 39);
            PlayerName.TabIndex = 0;
            PlayerName.Text = "Player Name";
            // 
            // Victories
            // 
            Victories.AutoSize = true;
            Victories.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            Victories.Location = new Point(73, 100);
            Victories.Name = "Victories";
            Victories.Size = new Size(107, 31);
            Victories.TabIndex = 1;
            Victories.Text = "Victories";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(353, 100);
            label3.Name = "label3";
            label3.Size = new Size(81, 31);
            label3.TabIndex = 2;
            label3.Text = "Losses";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(652, 100);
            label4.Name = "label4";
            label4.Size = new Size(72, 31);
            label4.TabIndex = 3;
            label4.Text = "Draw";
            label4.Click += label4_Click;
            // 
            // listViewVictories
            // 
            listViewVictories.BackColor = Color.OldLace;
            listViewVictories.Columns.AddRange(new ColumnHeader[] { CompetitorHeader, ScoreHeader });
            listViewVictories.Location = new Point(29, 198);
            listViewVictories.Name = "listViewVictories";
            listViewVictories.Size = new Size(238, 152);
            listViewVictories.TabIndex = 4;
            listViewVictories.UseCompatibleStateImageBehavior = false;
            listViewVictories.View = View.Details;
            // 
            // CompetitorHeader
            // 
            CompetitorHeader.Text = "Competitor";
            CompetitorHeader.Width = 110;
            // 
            // ScoreHeader
            // 
            ScoreHeader.Text = "Score";
            ScoreHeader.Width = 120;
            // 
            // listViewLosses
            // 
            listViewLosses.BackColor = Color.FromArgb(255, 128, 128);
            listViewLosses.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewLosses.Location = new Point(287, 198);
            listViewLosses.Name = "listViewLosses";
            listViewLosses.Size = new Size(238, 152);
            listViewLosses.TabIndex = 5;
            listViewLosses.UseCompatibleStateImageBehavior = false;
            listViewLosses.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Competitor";
            columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Score";
            columnHeader2.Width = 120;
            // 
            // listViewDraw
            // 
            listViewDraw.BackColor = Color.FloralWhite;
            listViewDraw.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            listViewDraw.Location = new Point(561, 198);
            listViewDraw.Name = "listViewDraw";
            listViewDraw.Size = new Size(238, 152);
            listViewDraw.TabIndex = 6;
            listViewDraw.UseCompatibleStateImageBehavior = false;
            listViewDraw.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Competitor";
            columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Score";
            columnHeader4.Width = 120;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewDraw);
            Controls.Add(listViewLosses);
            Controls.Add(listViewVictories);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Victories);
            Controls.Add(PlayerName);
            Name = "Form3";
            Text = "PlayerInfoForm";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PlayerName;
        private Label Victories;
        private Label label3;
        private Label label4;
        private ListView listViewVictories;
        private ColumnHeader CompetitorHeader;
        private ColumnHeader ScoreHeader;
        private ListView listViewLosses;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView listViewDraw;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}