namespace Code_jeu_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAchille = new Button();
            btnHeros = new Button();
            ChoixPerso = new Label();
            ChoixArmure = new Label();
            btnArmureDemon = new Button();
            btnArmurePaladin = new Button();
            ChoixArme = new Label();
            btnEpee = new Button();
            btnMace = new Button();
            btnMarteau = new Button();
            TitreRound = new Label();
            PicGobelin = new PictureBox();
            PicSquellette = new PictureBox();
            PicAchille = new PictureBox();
            btnSoins = new Button();
            btnFaiblesse = new Button();
            VieHeros = new ProgressBar();
            VieGobelin = new ProgressBar();
            VieSquellette = new ProgressBar();
            HPHeros = new Label();
            HPGobelin = new Label();
            HPSquellette = new Label();
            LabelTour = new Label();
            PicHeros = new PictureBox();
            LabelDegats1 = new Label();
            LabelDegats3 = new Label();
            LabelDegats2 = new Label();
            GobelinPresentation = new PictureBox();
            SquellettePresentation = new PictureBox();
            labelRound = new Label();
            btnStart = new Button();
            labelInfoSquellette = new Label();
            labelGobelinInfo = new Label();
            button1 = new Button();
            btnModeFacile = new Button();
            labelActu = new Label();
            ((System.ComponentModel.ISupportInitialize)PicGobelin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicSquellette).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicAchille).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicHeros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GobelinPresentation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SquellettePresentation).BeginInit();
            SuspendLayout();
            // 
            // btnAchille
            // 
            btnAchille.BackColor = Color.LightCoral;
            btnAchille.Cursor = Cursors.Hand;
            btnAchille.Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            btnAchille.Location = new Point(25, 79);
            btnAchille.Name = "btnAchille";
            btnAchille.Size = new Size(259, 39);
            btnAchille.TabIndex = 0;
            btnAchille.Text = " Achille (70 DMG 280HP )";
            btnAchille.UseVisualStyleBackColor = false;
            btnAchille.Visible = false;
            btnAchille.Click += btnAchille_Click;
            // 
            // btnHeros
            // 
            btnHeros.BackColor = Color.DeepSkyBlue;
            btnHeros.Cursor = Cursors.Hand;
            btnHeros.Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            btnHeros.Location = new Point(290, 79);
            btnHeros.Name = "btnHeros";
            btnHeros.Size = new Size(226, 39);
            btnHeros.TabIndex = 1;
            btnHeros.Text = "Héros (50 DMG 360HP)";
            btnHeros.UseVisualStyleBackColor = false;
            btnHeros.Visible = false;
            btnHeros.Click += btnHeros_Click;
            // 
            // ChoixPerso
            // 
            ChoixPerso.AutoSize = true;
            ChoixPerso.BackColor = Color.WhiteSmoke;
            ChoixPerso.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            ChoixPerso.Location = new Point(25, 35);
            ChoixPerso.Name = "ChoixPerso";
            ChoixPerso.Size = new Size(249, 26);
            ChoixPerso.TabIndex = 2;
            ChoixPerso.Text = "Choisi ton Personnage :  ";
            ChoixPerso.Visible = false;
            // 
            // ChoixArmure
            // 
            ChoixArmure.AutoSize = true;
            ChoixArmure.BackColor = Color.WhiteSmoke;
            ChoixArmure.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            ChoixArmure.Location = new Point(25, 121);
            ChoixArmure.Name = "ChoixArmure";
            ChoixArmure.Size = new Size(215, 26);
            ChoixArmure.TabIndex = 3;
            ChoixArmure.Text = "Choisi ton Armure :  ";
            ChoixArmure.Visible = false;
            // 
            // btnArmureDemon
            // 
            btnArmureDemon.BackColor = Color.DarkRed;
            btnArmureDemon.Cursor = Cursors.Hand;
            btnArmureDemon.Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            btnArmureDemon.Location = new Point(25, 172);
            btnArmureDemon.Name = "btnArmureDemon";
            btnArmureDemon.Size = new Size(312, 41);
            btnArmureDemon.TabIndex = 4;
            btnArmureDemon.Text = "Armure Démon (5 DEF +10DMG)";
            btnArmureDemon.UseVisualStyleBackColor = false;
            btnArmureDemon.Visible = false;
            btnArmureDemon.Click += btnArmureDemon_Click;
            // 
            // btnArmurePaladin
            // 
            btnArmurePaladin.BackColor = Color.Gold;
            btnArmurePaladin.Cursor = Cursors.Hand;
            btnArmurePaladin.Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            btnArmurePaladin.Location = new Point(341, 172);
            btnArmurePaladin.Name = "btnArmurePaladin";
            btnArmurePaladin.Size = new Size(249, 41);
            btnArmurePaladin.TabIndex = 5;
            btnArmurePaladin.Text = "Armure Paladin (15 DEF)";
            btnArmurePaladin.UseVisualStyleBackColor = false;
            btnArmurePaladin.Visible = false;
            btnArmurePaladin.Click += btnArmurePaladin_Click;
            // 
            // ChoixArme
            // 
            ChoixArme.AutoSize = true;
            ChoixArme.BackColor = Color.WhiteSmoke;
            ChoixArme.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            ChoixArme.Location = new Point(25, 222);
            ChoixArme.Name = "ChoixArme";
            ChoixArme.Size = new Size(193, 26);
            ChoixArme.TabIndex = 8;
            ChoixArme.Text = "Choisi ton Arme :  ";
            ChoixArme.Visible = false;
            // 
            // btnEpee
            // 
            btnEpee.BackColor = Color.DarkGray;
            btnEpee.Cursor = Cursors.Hand;
            btnEpee.Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            btnEpee.Location = new Point(25, 270);
            btnEpee.Name = "btnEpee";
            btnEpee.Size = new Size(276, 41);
            btnEpee.TabIndex = 9;
            btnEpee.Text = "Sword (+20 DMG + 1 POTION)";
            btnEpee.UseVisualStyleBackColor = false;
            btnEpee.Visible = false;
            btnEpee.Click += btnEpee_Click;
            // 
            // btnMace
            // 
            btnMace.BackColor = Color.Gray;
            btnMace.Cursor = Cursors.Hand;
            btnMace.Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            btnMace.Location = new Point(307, 270);
            btnMace.Name = "btnMace";
            btnMace.Size = new Size(224, 41);
            btnMace.TabIndex = 10;
            btnMace.Text = "Mace ( +30 DMG )";
            btnMace.UseVisualStyleBackColor = false;
            btnMace.Visible = false;
            btnMace.Click += btnMace_Click;
            // 
            // btnMarteau
            // 
            btnMarteau.BackColor = Color.DimGray;
            btnMarteau.Cursor = Cursors.Hand;
            btnMarteau.Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            btnMarteau.Location = new Point(537, 270);
            btnMarteau.Name = "btnMarteau";
            btnMarteau.Size = new Size(260, 41);
            btnMarteau.TabIndex = 11;
            btnMarteau.Text = "Marteau ( +40 DMG  -20HP )";
            btnMarteau.UseVisualStyleBackColor = false;
            btnMarteau.Visible = false;
            btnMarteau.Click += btnMarteau_Click;
            // 
            // TitreRound
            // 
            TitreRound.AutoSize = true;
            TitreRound.BackColor = Color.Transparent;
            TitreRound.Font = new Font("Impact", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitreRound.ForeColor = Color.Black;
            TitreRound.Location = new Point(457, 5);
            TitreRound.Name = "TitreRound";
            TitreRound.Size = new Size(318, 135);
            TitreRound.TabIndex = 12;
            TitreRound.Text = "          Round 1\r\nHeros Vs Monstres\r\n\r\n";
            TitreRound.Visible = false;
            // 
            // PicGobelin
            // 
            PicGobelin.BackColor = Color.Transparent;
            PicGobelin.Cursor = Cursors.Hand;
            PicGobelin.Image = (Image)resources.GetObject("PicGobelin.Image");
            PicGobelin.Location = new Point(647, 172);
            PicGobelin.Name = "PicGobelin";
            PicGobelin.Size = new Size(187, 186);
            PicGobelin.SizeMode = PictureBoxSizeMode.Zoom;
            PicGobelin.TabIndex = 13;
            PicGobelin.TabStop = false;
            PicGobelin.Visible = false;
            PicGobelin.Click += PicGobelin_Click;
            PicGobelin.MouseEnter += PicGobelin_MouseEnter;
            PicGobelin.MouseLeave += PicGobelin_MouseLeave;
            // 
            // PicSquellette
            // 
            PicSquellette.BackColor = Color.Transparent;
            PicSquellette.Cursor = Cursors.Hand;
            PicSquellette.Image = (Image)resources.GetObject("PicSquellette.Image");
            PicSquellette.Location = new Point(815, 251);
            PicSquellette.Name = "PicSquellette";
            PicSquellette.Size = new Size(201, 236);
            PicSquellette.SizeMode = PictureBoxSizeMode.Zoom;
            PicSquellette.TabIndex = 14;
            PicSquellette.TabStop = false;
            PicSquellette.Visible = false;
            PicSquellette.Click += PicSquellette_Click;
            PicSquellette.MouseEnter += PicSquellette_MouseEnter;
            PicSquellette.MouseLeave += PicSquellette_MouseLeave;
            // 
            // PicAchille
            // 
            PicAchille.BackColor = Color.Transparent;
            PicAchille.Image = (Image)resources.GetObject("PicAchille.Image");
            PicAchille.Location = new Point(246, 197);
            PicAchille.Name = "PicAchille";
            PicAchille.Size = new Size(188, 258);
            PicAchille.SizeMode = PictureBoxSizeMode.Zoom;
            PicAchille.TabIndex = 15;
            PicAchille.TabStop = false;
            PicAchille.Visible = false;
            // 
            // btnSoins
            // 
            btnSoins.BackColor = Color.FromArgb(0, 192, 0);
            btnSoins.BackgroundImageLayout = ImageLayout.Stretch;
            btnSoins.Cursor = Cursors.Hand;
            btnSoins.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSoins.ImageAlign = ContentAlignment.BottomRight;
            btnSoins.Location = new Point(476, 370);
            btnSoins.Name = "btnSoins";
            btnSoins.Size = new Size(221, 29);
            btnSoins.TabIndex = 16;
            btnSoins.Text = "Soins (+100HP) [ 2 soins ]";
            btnSoins.UseVisualStyleBackColor = false;
            btnSoins.Visible = false;
            btnSoins.Click += btnSoins_Click;
            // 
            // btnFaiblesse
            // 
            btnFaiblesse.BackColor = Color.Gray;
            btnFaiblesse.Cursor = Cursors.Hand;
            btnFaiblesse.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFaiblesse.Location = new Point(476, 405);
            btnFaiblesse.Name = "btnFaiblesse";
            btnFaiblesse.Size = new Size(296, 29);
            btnFaiblesse.TabIndex = 17;
            btnFaiblesse.Text = "Potion Faiblesse (-20 MDG) [1 potion]";
            btnFaiblesse.UseVisualStyleBackColor = false;
            btnFaiblesse.Visible = false;
            btnFaiblesse.Click += btnFaiblesse_Click;
            // 
            // VieHeros
            // 
            VieHeros.BackColor = Color.FromArgb(0, 0, 192);
            VieHeros.ForeColor = Color.FromArgb(0, 0, 192);
            VieHeros.Location = new Point(246, 197);
            VieHeros.Maximum = 600;
            VieHeros.Name = "VieHeros";
            VieHeros.Size = new Size(202, 23);
            VieHeros.TabIndex = 19;
            VieHeros.Value = 300;
            VieHeros.Visible = false;
            // 
            // VieGobelin
            // 
            VieGobelin.BackColor = Color.IndianRed;
            VieGobelin.ForeColor = Color.IndianRed;
            VieGobelin.Location = new Point(664, 162);
            VieGobelin.Maximum = 600;
            VieGobelin.Name = "VieGobelin";
            VieGobelin.Size = new Size(145, 23);
            VieGobelin.TabIndex = 20;
            VieGobelin.Visible = false;
            // 
            // VieSquellette
            // 
            VieSquellette.Location = new Point(851, 251);
            VieSquellette.Maximum = 600;
            VieSquellette.Name = "VieSquellette";
            VieSquellette.Size = new Size(116, 23);
            VieSquellette.TabIndex = 21;
            VieSquellette.Value = 150;
            VieSquellette.Visible = false;
            // 
            // HPHeros
            // 
            HPHeros.AutoSize = true;
            HPHeros.BackColor = Color.FromArgb(255, 128, 128);
            HPHeros.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HPHeros.Location = new Point(457, 197);
            HPHeros.Name = "HPHeros";
            HPHeros.Size = new Size(20, 23);
            HPHeros.TabIndex = 22;
            HPHeros.Text = "0";
            HPHeros.Visible = false;
            // 
            // HPGobelin
            // 
            HPGobelin.AutoSize = true;
            HPGobelin.BackColor = Color.FromArgb(255, 128, 128);
            HPGobelin.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold);
            HPGobelin.Location = new Point(815, 162);
            HPGobelin.Name = "HPGobelin";
            HPGobelin.Size = new Size(20, 23);
            HPGobelin.TabIndex = 23;
            HPGobelin.Text = "0";
            HPGobelin.Visible = false;
            // 
            // HPSquellette
            // 
            HPSquellette.AutoSize = true;
            HPSquellette.BackColor = Color.FromArgb(255, 128, 128);
            HPSquellette.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold);
            HPSquellette.Location = new Point(973, 251);
            HPSquellette.Name = "HPSquellette";
            HPSquellette.Size = new Size(20, 23);
            HPSquellette.TabIndex = 24;
            HPSquellette.Text = "0";
            HPSquellette.Visible = false;
            // 
            // LabelTour
            // 
            LabelTour.AutoSize = true;
            LabelTour.BackColor = Color.Transparent;
            LabelTour.Font = new Font("Segoe UI", 21F, FontStyle.Bold | FontStyle.Italic);
            LabelTour.ForeColor = Color.Blue;
            LabelTour.Location = new Point(781, 35);
            LabelTour.Name = "LabelTour";
            LabelTour.Size = new Size(274, 47);
            LabelTour.TabIndex = 25;
            LabelTour.Text = "Tour du Héros !";
            LabelTour.Visible = false;
            // 
            // PicHeros
            // 
            PicHeros.BackColor = Color.Transparent;
            PicHeros.Image = (Image)resources.GetObject("PicHeros.Image");
            PicHeros.Location = new Point(246, 216);
            PicHeros.Name = "PicHeros";
            PicHeros.Size = new Size(224, 289);
            PicHeros.SizeMode = PictureBoxSizeMode.Zoom;
            PicHeros.TabIndex = 27;
            PicHeros.TabStop = false;
            PicHeros.Visible = false;
            // 
            // LabelDegats1
            // 
            LabelDegats1.AutoSize = true;
            LabelDegats1.BackColor = Color.Transparent;
            LabelDegats1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelDegats1.ForeColor = Color.Red;
            LabelDegats1.Location = new Point(357, 223);
            LabelDegats1.Name = "LabelDegats1";
            LabelDegats1.Size = new Size(77, 28);
            LabelDegats1.TabIndex = 28;
            LabelDegats1.Text = "- 50HP";
            LabelDegats1.Visible = false;
            // 
            // LabelDegats3
            // 
            LabelDegats3.AutoSize = true;
            LabelDegats3.BackColor = Color.Transparent;
            LabelDegats3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelDegats3.ForeColor = Color.Red;
            LabelDegats3.Location = new Point(973, 330);
            LabelDegats3.Name = "LabelDegats3";
            LabelDegats3.Size = new Size(77, 28);
            LabelDegats3.TabIndex = 29;
            LabelDegats3.Text = "- 50HP";
            LabelDegats3.Visible = false;
            // 
            // LabelDegats2
            // 
            LabelDegats2.AutoSize = true;
            LabelDegats2.BackColor = Color.Transparent;
            LabelDegats2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelDegats2.ForeColor = Color.Red;
            LabelDegats2.Location = new Point(794, 197);
            LabelDegats2.Name = "LabelDegats2";
            LabelDegats2.Size = new Size(77, 28);
            LabelDegats2.TabIndex = 30;
            LabelDegats2.Text = "- 50HP";
            LabelDegats2.Visible = false;
            // 
            // GobelinPresentation
            // 
            GobelinPresentation.BackColor = Color.Transparent;
            GobelinPresentation.Image = (Image)resources.GetObject("GobelinPresentation.Image");
            GobelinPresentation.Location = new Point(640, 216);
            GobelinPresentation.Name = "GobelinPresentation";
            GobelinPresentation.Size = new Size(194, 183);
            GobelinPresentation.SizeMode = PictureBoxSizeMode.Zoom;
            GobelinPresentation.TabIndex = 31;
            GobelinPresentation.TabStop = false;
            // 
            // SquellettePresentation
            // 
            SquellettePresentation.BackColor = Color.Transparent;
            SquellettePresentation.Image = (Image)resources.GetObject("SquellettePresentation.Image");
            SquellettePresentation.Location = new Point(454, 219);
            SquellettePresentation.Name = "SquellettePresentation";
            SquellettePresentation.Size = new Size(180, 180);
            SquellettePresentation.SizeMode = PictureBoxSizeMode.Zoom;
            SquellettePresentation.TabIndex = 32;
            SquellettePresentation.TabStop = false;
            // 
            // labelRound
            // 
            labelRound.AutoSize = true;
            labelRound.BackColor = Color.Firebrick;
            labelRound.Font = new Font("DejaVu Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRound.ForeColor = Color.Black;
            labelRound.Location = new Point(457, 143);
            labelRound.Name = "labelRound";
            labelRound.Size = new Size(438, 44);
            labelRound.TabIndex = 33;
            labelRound.Text = "Round 1 Ennemies :";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.LightGray;
            btnStart.Cursor = Cursors.Hand;
            btnStart.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(584, 527);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(114, 47);
            btnStart.TabIndex = 34;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // labelInfoSquellette
            // 
            labelInfoSquellette.AutoSize = true;
            labelInfoSquellette.BackColor = Color.FromArgb(255, 224, 192);
            labelInfoSquellette.BorderStyle = BorderStyle.Fixed3D;
            labelInfoSquellette.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfoSquellette.Location = new Point(495, 405);
            labelInfoSquellette.Name = "labelInfoSquellette";
            labelInfoSquellette.Size = new Size(121, 86);
            labelInfoSquellette.TabIndex = 35;
            labelInfoSquellette.Text = "Squellette :\r\n280 HP\r\n50 DMG";
            // 
            // labelGobelinInfo
            // 
            labelGobelinInfo.AutoSize = true;
            labelGobelinInfo.BackColor = Color.Green;
            labelGobelinInfo.BorderStyle = BorderStyle.Fixed3D;
            labelGobelinInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGobelinInfo.Location = new Point(688, 405);
            labelGobelinInfo.Name = "labelGobelinInfo";
            labelGobelinInfo.Size = new Size(98, 86);
            labelGobelinInfo.TabIndex = 36;
            labelGobelinInfo.Text = "Gobelin :\r\n330 HP\r\n80 DMG";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Sylfaen", 1F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1159, 121);
            button1.Name = "button1";
            button1.Size = new Size(10, 10);
            button1.TabIndex = 37;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnModeFacile
            // 
            btnModeFacile.BackColor = Color.LimeGreen;
            btnModeFacile.Cursor = Cursors.Hand;
            btnModeFacile.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModeFacile.Location = new Point(246, 527);
            btnModeFacile.Name = "btnModeFacile";
            btnModeFacile.Size = new Size(270, 47);
            btnModeFacile.TabIndex = 38;
            btnModeFacile.Text = "Mode Facile";
            btnModeFacile.UseVisualStyleBackColor = false;
            btnModeFacile.Click += btnModeFacile_Click;
            // 
            // labelActu
            // 
            labelActu.AutoSize = true;
            labelActu.BackColor = Color.WhiteSmoke;
            labelActu.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelActu.Location = new Point(815, 84);
            labelActu.Name = "labelActu";
            labelActu.Size = new Size(157, 96);
            labelActu.TabIndex = 39;
            labelActu.Text = "Actuellement :\r\nHP : 0\r\nDEF : 0\r\nDMG : 0";
            labelActu.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1170, 621);
            Controls.Add(labelActu);
            Controls.Add(labelRound);
            Controls.Add(btnFaiblesse);
            Controls.Add(btnSoins);
            Controls.Add(btnModeFacile);
            Controls.Add(LabelDegats3);
            Controls.Add(LabelDegats2);
            Controls.Add(LabelDegats1);
            Controls.Add(VieHeros);
            Controls.Add(button1);
            Controls.Add(labelGobelinInfo);
            Controls.Add(labelInfoSquellette);
            Controls.Add(btnStart);
            Controls.Add(SquellettePresentation);
            Controls.Add(GobelinPresentation);
            Controls.Add(HPHeros);
            Controls.Add(HPSquellette);
            Controls.Add(HPGobelin);
            Controls.Add(VieSquellette);
            Controls.Add(VieGobelin);
            Controls.Add(LabelTour);
            Controls.Add(TitreRound);
            Controls.Add(btnMarteau);
            Controls.Add(btnMace);
            Controls.Add(btnEpee);
            Controls.Add(ChoixArme);
            Controls.Add(btnArmurePaladin);
            Controls.Add(btnArmureDemon);
            Controls.Add(ChoixArmure);
            Controls.Add(ChoixPerso);
            Controls.Add(btnHeros);
            Controls.Add(btnAchille);
            Controls.Add(PicAchille);
            Controls.Add(PicHeros);
            Controls.Add(PicSquellette);
            Controls.Add(PicGobelin);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "FIA";
            ((System.ComponentModel.ISupportInitialize)PicGobelin).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicSquellette).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicAchille).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicHeros).EndInit();
            ((System.ComponentModel.ISupportInitialize)GobelinPresentation).EndInit();
            ((System.ComponentModel.ISupportInitialize)SquellettePresentation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAchille;
        private Button btnHeros;
        private Label ChoixPerso;
        private Label ChoixArmure;
        private Button btnArmureDemon;
        private Button btnArmurePaladin;
        private Label ChoixArme;
        private Button btnEpee;
        private Button btnMace;
        private Button btnMarteau;
        private Label TitreRound;
        private PictureBox PicGobelin;
        private PictureBox PicSquellette;
        private PictureBox PicAchille;
        private Button btnSoins;
        private Button btnFaiblesse;
        private ProgressBar VieHeros;
        private ProgressBar VieGobelin;
        private ProgressBar VieSquellette;
        private Label HPHeros;
        private Label HPGobelin;
        private Label HPSquellette;
        internal Label LabelTour;
        private PictureBox PicHeros;
        private Label LabelDegats1;
        private Label LabelDegats3;
        private Label LabelDegats2;
        private PictureBox GobelinPresentation;
        private PictureBox SquellettePresentation;
        private Label labelRound;
        private Button btnStart;
        private Label labelInfoSquellette;
        private Label labelGobelinInfo;
        private Button button1;
        private Button btnModeFacile;
        private Label labelActu;
    }
}
