namespace DataSense
{
    partial class MainForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonMore = new FontAwesome.Sharp.IconButton();
            this.iconButtonGames = new FontAwesome.Sharp.IconButton();
            this.iconButtonSeries = new FontAwesome.Sharp.IconButton();
            this.iconButtonManga = new FontAwesome.Sharp.IconButton();
            this.iconButtonAnime = new FontAwesome.Sharp.IconButton();
            this.iconButtonMovies = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelChild = new System.Windows.Forms.Label();
            this.iconCurrentChild = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChild)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(132)))), ((int)(((byte)(178)))));
            this.panelMenu.Controls.Add(this.iconButtonMore);
            this.panelMenu.Controls.Add(this.iconButtonGames);
            this.panelMenu.Controls.Add(this.iconButtonSeries);
            this.panelMenu.Controls.Add(this.iconButtonManga);
            this.panelMenu.Controls.Add(this.iconButtonAnime);
            this.panelMenu.Controls.Add(this.iconButtonMovies);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 631);
            this.panelMenu.TabIndex = 1;
            // 
            // iconButtonMore
            // 
            this.iconButtonMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(126)))), ((int)(((byte)(175)))));
            this.iconButtonMore.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonMore.FlatAppearance.BorderSize = 0;
            this.iconButtonMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMore.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMore.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconButtonMore.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMore.IconSize = 32;
            this.iconButtonMore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMore.Location = new System.Drawing.Point(0, 440);
            this.iconButtonMore.Name = "iconButtonMore";
            this.iconButtonMore.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonMore.Size = new System.Drawing.Size(220, 60);
            this.iconButtonMore.TabIndex = 7;
            this.iconButtonMore.Text = "More";
            this.iconButtonMore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMore.UseVisualStyleBackColor = false;
            this.iconButtonMore.Click += new System.EventHandler(this.iconButtonMore_Click);
            // 
            // iconButtonGames
            // 
            this.iconButtonGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(132)))), ((int)(((byte)(178)))));
            this.iconButtonGames.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonGames.FlatAppearance.BorderSize = 0;
            this.iconButtonGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonGames.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonGames.IconChar = FontAwesome.Sharp.IconChar.Gamepad;
            this.iconButtonGames.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonGames.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonGames.IconSize = 32;
            this.iconButtonGames.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonGames.Location = new System.Drawing.Point(0, 380);
            this.iconButtonGames.Name = "iconButtonGames";
            this.iconButtonGames.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonGames.Size = new System.Drawing.Size(220, 60);
            this.iconButtonGames.TabIndex = 1;
            this.iconButtonGames.Text = "Games";
            this.iconButtonGames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonGames.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonGames.UseVisualStyleBackColor = false;
            this.iconButtonGames.Click += new System.EventHandler(this.iconButtonGame_Click);
            // 
            // iconButtonSeries
            // 
            this.iconButtonSeries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(126)))), ((int)(((byte)(175)))));
            this.iconButtonSeries.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSeries.FlatAppearance.BorderSize = 0;
            this.iconButtonSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSeries.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSeries.IconChar = FontAwesome.Sharp.IconChar.Film;
            this.iconButtonSeries.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSeries.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSeries.IconSize = 32;
            this.iconButtonSeries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSeries.Location = new System.Drawing.Point(0, 320);
            this.iconButtonSeries.Name = "iconButtonSeries";
            this.iconButtonSeries.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonSeries.Size = new System.Drawing.Size(220, 60);
            this.iconButtonSeries.TabIndex = 5;
            this.iconButtonSeries.Text = "Series";
            this.iconButtonSeries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSeries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSeries.UseVisualStyleBackColor = false;
            this.iconButtonSeries.Click += new System.EventHandler(this.iconButtonSeries_Click);
            // 
            // iconButtonManga
            // 
            this.iconButtonManga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(132)))), ((int)(((byte)(178)))));
            this.iconButtonManga.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonManga.FlatAppearance.BorderSize = 0;
            this.iconButtonManga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonManga.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonManga.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconButtonManga.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonManga.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonManga.IconSize = 32;
            this.iconButtonManga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonManga.Location = new System.Drawing.Point(0, 260);
            this.iconButtonManga.Name = "iconButtonManga";
            this.iconButtonManga.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonManga.Size = new System.Drawing.Size(220, 60);
            this.iconButtonManga.TabIndex = 3;
            this.iconButtonManga.Text = "Manga";
            this.iconButtonManga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonManga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonManga.UseVisualStyleBackColor = false;
            this.iconButtonManga.Click += new System.EventHandler(this.iconButtonManga_Click);
            // 
            // iconButtonAnime
            // 
            this.iconButtonAnime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(126)))), ((int)(((byte)(175)))));
            this.iconButtonAnime.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonAnime.FlatAppearance.BorderSize = 0;
            this.iconButtonAnime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAnime.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonAnime.IconChar = FontAwesome.Sharp.IconChar.WheelchairAlt;
            this.iconButtonAnime.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonAnime.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAnime.IconSize = 32;
            this.iconButtonAnime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAnime.Location = new System.Drawing.Point(0, 200);
            this.iconButtonAnime.Name = "iconButtonAnime";
            this.iconButtonAnime.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonAnime.Size = new System.Drawing.Size(220, 60);
            this.iconButtonAnime.TabIndex = 2;
            this.iconButtonAnime.Text = "Anime";
            this.iconButtonAnime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAnime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAnime.UseVisualStyleBackColor = false;
            this.iconButtonAnime.Click += new System.EventHandler(this.iconButtonAnime_Click);
            // 
            // iconButtonMovies
            // 
            this.iconButtonMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(132)))), ((int)(((byte)(178)))));
            this.iconButtonMovies.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonMovies.FlatAppearance.BorderSize = 0;
            this.iconButtonMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMovies.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMovies.IconChar = FontAwesome.Sharp.IconChar.Video;
            this.iconButtonMovies.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMovies.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMovies.IconSize = 32;
            this.iconButtonMovies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMovies.Location = new System.Drawing.Point(0, 140);
            this.iconButtonMovies.Name = "iconButtonMovies";
            this.iconButtonMovies.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonMovies.Size = new System.Drawing.Size(220, 60);
            this.iconButtonMovies.TabIndex = 4;
            this.iconButtonMovies.Text = "Movies";
            this.iconButtonMovies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMovies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMovies.UseVisualStyleBackColor = false;
            this.iconButtonMovies.Click += new System.EventHandler(this.iconButtonMovies_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(126)))), ((int)(((byte)(175)))));
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Image = global::DataSense.Properties.Resources.logo_no_background;
            this.btnHome.Location = new System.Drawing.Point(60, 20);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 100);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(132)))), ((int)(((byte)(178)))));
            this.panelTitleBar.Controls.Add(this.button3);
            this.panelTitleBar.Controls.Add(this.button2);
            this.panelTitleBar.Controls.Add(this.exitButton);
            this.panelTitleBar.Controls.Add(this.labelChild);
            this.panelTitleBar.Controls.Add(this.iconCurrentChild);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(998, 60);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // labelChild
            // 
            this.labelChild.AutoSize = true;
            this.labelChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChild.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelChild.Location = new System.Drawing.Point(65, 22);
            this.labelChild.Name = "labelChild";
            this.labelChild.Size = new System.Drawing.Size(54, 20);
            this.labelChild.TabIndex = 1;
            this.labelChild.Text = "Home";
            // 
            // iconCurrentChild
            // 
            this.iconCurrentChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(132)))), ((int)(((byte)(178)))));
            this.iconCurrentChild.ForeColor = System.Drawing.Color.Goldenrod;
            this.iconCurrentChild.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChild.IconColor = System.Drawing.Color.Goldenrod;
            this.iconCurrentChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChild.IconSize = 40;
            this.iconCurrentChild.Location = new System.Drawing.Point(16, 12);
            this.iconCurrentChild.Name = "iconCurrentChild";
            this.iconCurrentChild.Size = new System.Drawing.Size(40, 40);
            this.iconCurrentChild.TabIndex = 0;
            this.iconCurrentChild.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(118)))), ((int)(((byte)(170)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 60);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(998, 4);
            this.panelShadow.TabIndex = 3;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.panelDesktop.Controls.Add(this.button1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 64);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(998, 567);
            this.panelDesktop.TabIndex = 4;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.exitButton.Location = new System.Drawing.Point(964, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(34, 60);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "O";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(930, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "O";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Location = new System.Drawing.Point(896, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = "O";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 631);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainForm";
            this.Text = "DataSense";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChild)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonMore;
        private FontAwesome.Sharp.IconButton iconButtonSeries;
        private FontAwesome.Sharp.IconButton iconButtonMovies;
        private FontAwesome.Sharp.IconButton iconButtonManga;
        private FontAwesome.Sharp.IconButton iconButtonAnime;
        private FontAwesome.Sharp.IconButton iconButtonGames;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChild;
        private System.Windows.Forms.Label labelChild;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

