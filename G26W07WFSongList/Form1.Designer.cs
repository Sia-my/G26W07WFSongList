namespace G26W07WFSongList
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
            listSong = new ListBox();
            txtTitle = new TextBox();
            txtArtist = new TextBox();
            txtRating = new TextBox();
            btnAdd = new Button();
            txtSelected = new TextBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // listSong
            // 
            listSong.FormattingEnabled = true;
            listSong.Location = new Point(12, 13);
            listSong.Name = "listSong";
            listSong.Size = new Size(776, 424);
            listSong.TabIndex = 0;
            listSong.SelectedIndexChanged += OnChanged;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(16, 458);
            txtTitle.MaxLength = 1;
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "제목";
            txtTitle.Size = new Size(296, 35);
            txtTitle.TabIndex = 1;
            // 
            // txtArtist
            // 
            txtArtist.Location = new Point(318, 459);
            txtArtist.Name = "txtArtist";
            txtArtist.PlaceholderText = "가수";
            txtArtist.Size = new Size(204, 35);
            txtArtist.TabIndex = 2;
            // 
            // txtRating
            // 
            txtRating.Location = new Point(528, 459);
            txtRating.Name = "txtRating";
            txtRating.PlaceholderText = "평점";
            txtRating.Size = new Size(127, 35);
            txtRating.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(661, 458);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(127, 36);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "추가";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += OnAdd;
            // 
            // txtSelected
            // 
            txtSelected.Enabled = false;
            txtSelected.Location = new Point(12, 500);
            txtSelected.Name = "txtSelected";
            txtSelected.PlaceholderText = "삭제를 위해 선택된 노래";
            txtSelected.ReadOnly = true;
            txtSelected.Size = new Size(639, 35);
            txtSelected.TabIndex = 5;
            txtSelected.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(661, 501);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(127, 35);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += OnDelete;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 549);
            Controls.Add(btnDelete);
            Controls.Add(txtSelected);
            Controls.Add(btnAdd);
            Controls.Add(txtRating);
            Controls.Add(txtArtist);
            Controls.Add(txtTitle);
            Controls.Add(listSong);
            Name = "Form1";
            Text = "애창곡";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listSong;
        private TextBox txtTitle;
        private TextBox txtArtist;
        private TextBox txtRating;
        private Button btnAdd;
        private TextBox txtSelected;
        private Button btnDelete;
    }
}
