﻿
namespace cantStop
{
    partial class FormTabuleiro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabuleiro));
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblJogador = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblCorJogador = new System.Windows.Forms.Label();
            this.lblPartidaIniciada = new System.Windows.Forms.Label();
            this.tmrPartidaIniciada = new System.Windows.Forms.Timer(this.components);
            this.tmrPartidaJogando = new System.Windows.Forms.Timer(this.components);
            this.gbxJogadas = new System.Windows.Forms.GroupBox();
            this.lblOu3 = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.lblOu2 = new System.Windows.Forms.Label();
            this.lblOu1 = new System.Windows.Forms.Label();
            this.rbxOpcao4 = new System.Windows.Forms.RadioButton();
            this.rbxOpcao5 = new System.Windows.Forms.RadioButton();
            this.rbxOpcao6 = new System.Windows.Forms.RadioButton();
            this.rbxOpcao3 = new System.Windows.Forms.RadioButton();
            this.rbxOpcao2 = new System.Windows.Forms.RadioButton();
            this.rbxOpcao1 = new System.Windows.Forms.RadioButton();
            this.pcbDado4 = new System.Windows.Forms.PictureBox();
            this.pcbDado3 = new System.Windows.Forms.PictureBox();
            this.pcbDado1 = new System.Windows.Forms.PictureBox();
            this.pcbDado2 = new System.Windows.Forms.PictureBox();
            this.pcbTabuleiro = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblUltimasJogadas = new System.Windows.Forms.Label();
            this.lblUltimaJogada = new System.Windows.Forms.Label();
            this.lblAntipenultimaJogada = new System.Windows.Forms.Label();
            this.lblPenultinaJogada = new System.Windows.Forms.Label();
            this.lblJogadorVez = new System.Windows.Forms.Label();
            this.lblVezDe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbStatusBot = new System.Windows.Forms.PictureBox();
            this.tmrJogadaBot = new System.Windows.Forms.Timer(this.components);
            this.btnRolarDados = new System.Windows.Forms.Button();
            this.btnPassarVez = new System.Windows.Forms.Button();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.nmrDelay = new System.Windows.Forms.NumericUpDown();
            this.chbPorPasso = new System.Windows.Forms.CheckBox();
            this.gbxBotDebug = new System.Windows.Forms.GroupBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.lblProbabilidadeCair = new System.Windows.Forms.Label();
            this.lblJogadas = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblTituloProbabilidadeCair = new System.Windows.Forms.Label();
            this.gbxJogadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTabuleiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStatusBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDelay)).BeginInit();
            this.gbxBotDebug.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.ForeColor = System.Drawing.Color.White;
            this.lblVersao.Location = new System.Drawing.Point(1049, 587);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(84, 13);
            this.lblVersao.TabIndex = 0;
            this.lblVersao.Text = "Versão DLL: 0.0";
            // 
            // lblJogador
            // 
            this.lblJogador.AutoSize = true;
            this.lblJogador.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador.ForeColor = System.Drawing.Color.White;
            this.lblJogador.Location = new System.Drawing.Point(1020, 492);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(45, 13);
            this.lblJogador.TabIndex = 9;
            this.lblJogador.Text = "Jogador";
            this.lblJogador.Visible = false;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(903, 624);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(76, 13);
            this.lblSenha.TabIndex = 10;
            this.lblSenha.Text = "SenhaJogador";
            this.lblSenha.Visible = false;
            // 
            // lblCorJogador
            // 
            this.lblCorJogador.AutoSize = true;
            this.lblCorJogador.ForeColor = System.Drawing.Color.White;
            this.lblCorJogador.Location = new System.Drawing.Point(1020, 467);
            this.lblCorJogador.Name = "lblCorJogador";
            this.lblCorJogador.Size = new System.Drawing.Size(61, 13);
            this.lblCorJogador.TabIndex = 11;
            this.lblCorJogador.Text = "CorJogador";
            this.lblCorJogador.Visible = false;
            // 
            // lblPartidaIniciada
            // 
            this.lblPartidaIniciada.AutoSize = true;
            this.lblPartidaIniciada.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidaIniciada.ForeColor = System.Drawing.Color.White;
            this.lblPartidaIniciada.Location = new System.Drawing.Point(12, 572);
            this.lblPartidaIniciada.Name = "lblPartidaIniciada";
            this.lblPartidaIniciada.Size = new System.Drawing.Size(146, 21);
            this.lblPartidaIniciada.TabIndex = 12;
            this.lblPartidaIniciada.Text = "Partida não iniciada";
            // 
            // tmrPartidaIniciada
            // 
            this.tmrPartidaIniciada.Interval = 5000;
            this.tmrPartidaIniciada.Tick += new System.EventHandler(this.tmrPartidaIniciada_Tick);
            // 
            // tmrPartidaJogando
            // 
            this.tmrPartidaJogando.Interval = 2700;
            this.tmrPartidaJogando.Tick += new System.EventHandler(this.tmrPartidaJogando_Tick);
            // 
            // gbxJogadas
            // 
            this.gbxJogadas.Controls.Add(this.lblOu3);
            this.gbxJogadas.Controls.Add(this.btnJogar);
            this.gbxJogadas.Controls.Add(this.lblOu2);
            this.gbxJogadas.Controls.Add(this.lblOu1);
            this.gbxJogadas.Controls.Add(this.rbxOpcao4);
            this.gbxJogadas.Controls.Add(this.rbxOpcao5);
            this.gbxJogadas.Controls.Add(this.rbxOpcao6);
            this.gbxJogadas.Controls.Add(this.rbxOpcao3);
            this.gbxJogadas.Controls.Add(this.rbxOpcao2);
            this.gbxJogadas.Controls.Add(this.rbxOpcao1);
            this.gbxJogadas.Enabled = false;
            this.gbxJogadas.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxJogadas.ForeColor = System.Drawing.Color.White;
            this.gbxJogadas.Location = new System.Drawing.Point(15, 310);
            this.gbxJogadas.Name = "gbxJogadas";
            this.gbxJogadas.Size = new System.Drawing.Size(232, 130);
            this.gbxJogadas.TabIndex = 23;
            this.gbxJogadas.TabStop = false;
            this.gbxJogadas.Tag = "jogadas";
            this.gbxJogadas.Text = "Jogadas";
            this.gbxJogadas.Visible = false;
            // 
            // lblOu3
            // 
            this.lblOu3.AutoSize = true;
            this.lblOu3.Location = new System.Drawing.Point(87, 67);
            this.lblOu3.Name = "lblOu3";
            this.lblOu3.Size = new System.Drawing.Size(28, 21);
            this.lblOu3.TabIndex = 8;
            this.lblOu3.Text = "ou";
            this.lblOu3.Visible = false;
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(62)))));
            this.btnJogar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnJogar.Location = new System.Drawing.Point(6, 92);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(220, 32);
            this.btnJogar.TabIndex = 34;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // lblOu2
            // 
            this.lblOu2.AutoSize = true;
            this.lblOu2.Location = new System.Drawing.Point(87, 44);
            this.lblOu2.Name = "lblOu2";
            this.lblOu2.Size = new System.Drawing.Size(28, 21);
            this.lblOu2.TabIndex = 7;
            this.lblOu2.Text = "ou";
            this.lblOu2.Visible = false;
            // 
            // lblOu1
            // 
            this.lblOu1.AutoSize = true;
            this.lblOu1.Location = new System.Drawing.Point(87, 19);
            this.lblOu1.Name = "lblOu1";
            this.lblOu1.Size = new System.Drawing.Size(28, 21);
            this.lblOu1.TabIndex = 6;
            this.lblOu1.Text = "ou";
            this.lblOu1.Visible = false;
            // 
            // rbxOpcao4
            // 
            this.rbxOpcao4.AutoSize = true;
            this.rbxOpcao4.ForeColor = System.Drawing.Color.White;
            this.rbxOpcao4.Location = new System.Drawing.Point(126, 19);
            this.rbxOpcao4.Name = "rbxOpcao4";
            this.rbxOpcao4.Size = new System.Drawing.Size(86, 25);
            this.rbxOpcao4.TabIndex = 5;
            this.rbxOpcao4.TabStop = true;
            this.rbxOpcao4.Tag = "jogada";
            this.rbxOpcao4.Text = "Opcao 4";
            this.rbxOpcao4.UseVisualStyleBackColor = true;
            // 
            // rbxOpcao5
            // 
            this.rbxOpcao5.AutoSize = true;
            this.rbxOpcao5.ForeColor = System.Drawing.Color.White;
            this.rbxOpcao5.Location = new System.Drawing.Point(126, 42);
            this.rbxOpcao5.Name = "rbxOpcao5";
            this.rbxOpcao5.Size = new System.Drawing.Size(86, 25);
            this.rbxOpcao5.TabIndex = 4;
            this.rbxOpcao5.TabStop = true;
            this.rbxOpcao5.Tag = "jogada";
            this.rbxOpcao5.Text = "Opcao 5";
            this.rbxOpcao5.UseVisualStyleBackColor = true;
            // 
            // rbxOpcao6
            // 
            this.rbxOpcao6.AutoSize = true;
            this.rbxOpcao6.ForeColor = System.Drawing.Color.White;
            this.rbxOpcao6.Location = new System.Drawing.Point(126, 65);
            this.rbxOpcao6.Name = "rbxOpcao6";
            this.rbxOpcao6.Size = new System.Drawing.Size(86, 25);
            this.rbxOpcao6.TabIndex = 3;
            this.rbxOpcao6.TabStop = true;
            this.rbxOpcao6.Tag = "jogada";
            this.rbxOpcao6.Text = "Opcao 6";
            this.rbxOpcao6.UseVisualStyleBackColor = true;
            // 
            // rbxOpcao3
            // 
            this.rbxOpcao3.AutoSize = true;
            this.rbxOpcao3.ForeColor = System.Drawing.Color.White;
            this.rbxOpcao3.Location = new System.Drawing.Point(9, 65);
            this.rbxOpcao3.Name = "rbxOpcao3";
            this.rbxOpcao3.Size = new System.Drawing.Size(86, 25);
            this.rbxOpcao3.TabIndex = 2;
            this.rbxOpcao3.TabStop = true;
            this.rbxOpcao3.Tag = "jogada";
            this.rbxOpcao3.Text = "Opcao 3";
            this.rbxOpcao3.UseVisualStyleBackColor = true;
            // 
            // rbxOpcao2
            // 
            this.rbxOpcao2.AutoSize = true;
            this.rbxOpcao2.ForeColor = System.Drawing.Color.White;
            this.rbxOpcao2.Location = new System.Drawing.Point(9, 42);
            this.rbxOpcao2.Name = "rbxOpcao2";
            this.rbxOpcao2.Size = new System.Drawing.Size(86, 25);
            this.rbxOpcao2.TabIndex = 1;
            this.rbxOpcao2.TabStop = true;
            this.rbxOpcao2.Tag = "jogada";
            this.rbxOpcao2.Text = "Opcao 2";
            this.rbxOpcao2.UseVisualStyleBackColor = true;
            // 
            // rbxOpcao1
            // 
            this.rbxOpcao1.AutoSize = true;
            this.rbxOpcao1.ForeColor = System.Drawing.Color.White;
            this.rbxOpcao1.Location = new System.Drawing.Point(9, 19);
            this.rbxOpcao1.Name = "rbxOpcao1";
            this.rbxOpcao1.Size = new System.Drawing.Size(86, 25);
            this.rbxOpcao1.TabIndex = 0;
            this.rbxOpcao1.TabStop = true;
            this.rbxOpcao1.Tag = "jogada";
            this.rbxOpcao1.Text = "Opcao 1";
            this.rbxOpcao1.UseVisualStyleBackColor = true;
            // 
            // pcbDado4
            // 
            this.pcbDado4.Image = global::cantStop.Properties.Resources.dado1;
            this.pcbDado4.Location = new System.Drawing.Point(132, 170);
            this.pcbDado4.Name = "pcbDado4";
            this.pcbDado4.Size = new System.Drawing.Size(70, 70);
            this.pcbDado4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDado4.TabIndex = 22;
            this.pcbDado4.TabStop = false;
            this.pcbDado4.Visible = false;
            // 
            // pcbDado3
            // 
            this.pcbDado3.Image = global::cantStop.Properties.Resources.dado1;
            this.pcbDado3.Location = new System.Drawing.Point(21, 170);
            this.pcbDado3.Name = "pcbDado3";
            this.pcbDado3.Size = new System.Drawing.Size(70, 70);
            this.pcbDado3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDado3.TabIndex = 21;
            this.pcbDado3.TabStop = false;
            this.pcbDado3.Visible = false;
            // 
            // pcbDado1
            // 
            this.pcbDado1.Image = global::cantStop.Properties.Resources.dado1;
            this.pcbDado1.Location = new System.Drawing.Point(21, 57);
            this.pcbDado1.Name = "pcbDado1";
            this.pcbDado1.Size = new System.Drawing.Size(70, 70);
            this.pcbDado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDado1.TabIndex = 20;
            this.pcbDado1.TabStop = false;
            this.pcbDado1.Visible = false;
            // 
            // pcbDado2
            // 
            this.pcbDado2.Image = global::cantStop.Properties.Resources.dado1;
            this.pcbDado2.Location = new System.Drawing.Point(132, 57);
            this.pcbDado2.Name = "pcbDado2";
            this.pcbDado2.Size = new System.Drawing.Size(70, 70);
            this.pcbDado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDado2.TabIndex = 19;
            this.pcbDado2.TabStop = false;
            this.pcbDado2.Visible = false;
            // 
            // pcbTabuleiro
            // 
            this.pcbTabuleiro.Image = global::cantStop.Properties.Resources.tabuleiroleiro;
            this.pcbTabuleiro.Location = new System.Drawing.Point(267, 7);
            this.pcbTabuleiro.Name = "pcbTabuleiro";
            this.pcbTabuleiro.Size = new System.Drawing.Size(630, 630);
            this.pcbTabuleiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTabuleiro.TabIndex = 13;
            this.pcbTabuleiro.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(953, 372);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // lblUltimasJogadas
            // 
            this.lblUltimasJogadas.AutoSize = true;
            this.lblUltimasJogadas.ForeColor = System.Drawing.Color.White;
            this.lblUltimasJogadas.Location = new System.Drawing.Point(905, 494);
            this.lblUltimasJogadas.Name = "lblUltimasJogadas";
            this.lblUltimasJogadas.Size = new System.Drawing.Size(81, 13);
            this.lblUltimasJogadas.TabIndex = 24;
            this.lblUltimasJogadas.Text = "Ultimas jogadas";
            this.lblUltimasJogadas.Visible = false;
            // 
            // lblUltimaJogada
            // 
            this.lblUltimaJogada.AutoSize = true;
            this.lblUltimaJogada.ForeColor = System.Drawing.Color.White;
            this.lblUltimaJogada.Location = new System.Drawing.Point(905, 519);
            this.lblUltimaJogada.Name = "lblUltimaJogada";
            this.lblUltimaJogada.Size = new System.Drawing.Size(74, 13);
            this.lblUltimaJogada.TabIndex = 25;
            this.lblUltimaJogada.Text = "Ultima Jogada";
            this.lblUltimaJogada.Visible = false;
            // 
            // lblAntipenultimaJogada
            // 
            this.lblAntipenultimaJogada.AutoSize = true;
            this.lblAntipenultimaJogada.ForeColor = System.Drawing.Color.White;
            this.lblAntipenultimaJogada.Location = new System.Drawing.Point(905, 567);
            this.lblAntipenultimaJogada.Name = "lblAntipenultimaJogada";
            this.lblAntipenultimaJogada.Size = new System.Drawing.Size(106, 13);
            this.lblAntipenultimaJogada.TabIndex = 27;
            this.lblAntipenultimaJogada.Text = "Antipenultina Jogada";
            this.lblAntipenultimaJogada.Visible = false;
            // 
            // lblPenultinaJogada
            // 
            this.lblPenultinaJogada.AutoSize = true;
            this.lblPenultinaJogada.ForeColor = System.Drawing.Color.White;
            this.lblPenultinaJogada.Location = new System.Drawing.Point(905, 542);
            this.lblPenultinaJogada.Name = "lblPenultinaJogada";
            this.lblPenultinaJogada.Size = new System.Drawing.Size(91, 13);
            this.lblPenultinaJogada.TabIndex = 26;
            this.lblPenultinaJogada.Text = "Penultima Jogada";
            this.lblPenultinaJogada.Visible = false;
            // 
            // lblJogadorVez
            // 
            this.lblJogadorVez.AutoSize = true;
            this.lblJogadorVez.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadorVez.ForeColor = System.Drawing.Color.White;
            this.lblJogadorVez.Location = new System.Drawing.Point(997, 51);
            this.lblJogadorVez.Name = "lblJogadorVez";
            this.lblJogadorVez.Size = new System.Drawing.Size(84, 28);
            this.lblJogadorVez.TabIndex = 28;
            this.lblJogadorVez.Text = "Jogador";
            this.lblJogadorVez.Visible = false;
            // 
            // lblVezDe
            // 
            this.lblVezDe.AutoSize = true;
            this.lblVezDe.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVezDe.ForeColor = System.Drawing.Color.White;
            this.lblVezDe.Location = new System.Drawing.Point(960, 11);
            this.lblVezDe.Name = "lblVezDe";
            this.lblVezDe.Size = new System.Drawing.Size(152, 28);
            this.lblVezDe.TabIndex = 29;
            this.lblVezDe.Text = "Vez do Jogador:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 28);
            this.label1.TabIndex = 30;
            this.label1.Text = "Sistema autônomo:";
            // 
            // pcbStatusBot
            // 
            this.pcbStatusBot.Image = global::cantStop.Properties.Resources.pointR;
            this.pcbStatusBot.Location = new System.Drawing.Point(199, 23);
            this.pcbStatusBot.Name = "pcbStatusBot";
            this.pcbStatusBot.Size = new System.Drawing.Size(12, 12);
            this.pcbStatusBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbStatusBot.TabIndex = 31;
            this.pcbStatusBot.TabStop = false;
            // 
            // tmrJogadaBot
            // 
            this.tmrJogadaBot.Tick += new System.EventHandler(this.tmrJogadaBot_Tick);
            // 
            // btnRolarDados
            // 
            this.btnRolarDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(62)))));
            this.btnRolarDados.Enabled = false;
            this.btnRolarDados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnRolarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolarDados.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRolarDados.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRolarDados.Location = new System.Drawing.Point(16, 271);
            this.btnRolarDados.Name = "btnRolarDados";
            this.btnRolarDados.Size = new System.Drawing.Size(106, 30);
            this.btnRolarDados.TabIndex = 32;
            this.btnRolarDados.Text = "Rolar Dados";
            this.btnRolarDados.UseVisualStyleBackColor = false;
            this.btnRolarDados.Visible = false;
            this.btnRolarDados.Click += new System.EventHandler(this.btnRolarDados_Click);
            // 
            // btnPassarVez
            // 
            this.btnPassarVez.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(62)))));
            this.btnPassarVez.Enabled = false;
            this.btnPassarVez.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnPassarVez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassarVez.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassarVez.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPassarVez.Location = new System.Drawing.Point(135, 271);
            this.btnPassarVez.Name = "btnPassarVez";
            this.btnPassarVez.Size = new System.Drawing.Size(106, 30);
            this.btnPassarVez.TabIndex = 33;
            this.btnPassarVez.Text = "Passar Vez";
            this.btnPassarVez.UseVisualStyleBackColor = false;
            this.btnPassarVez.Visible = false;
            this.btnPassarVez.Click += new System.EventHandler(this.btnPassarVez_Click);
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(62)))));
            this.btnIniciarPartida.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnIniciarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarPartida.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.ForeColor = System.Drawing.SystemColors.Window;
            this.btnIniciarPartida.Location = new System.Drawing.Point(12, 601);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(126, 30);
            this.btnIniciarPartida.TabIndex = 35;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(62)))));
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.Location = new System.Drawing.Point(1010, 607);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(126, 30);
            this.btnVoltar.TabIndex = 36;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(62)))));
            this.btnContinuar.Enabled = false;
            this.btnContinuar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnContinuar.Location = new System.Drawing.Point(6, 67);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(220, 32);
            this.btnContinuar.TabIndex = 35;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Visible = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // nmrDelay
            // 
            this.nmrDelay.Enabled = false;
            this.nmrDelay.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmrDelay.Location = new System.Drawing.Point(6, 37);
            this.nmrDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrDelay.Name = "nmrDelay";
            this.nmrDelay.Size = new System.Drawing.Size(78, 20);
            this.nmrDelay.TabIndex = 37;
            this.nmrDelay.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrDelay.Visible = false;
            // 
            // chbPorPasso
            // 
            this.chbPorPasso.AutoSize = true;
            this.chbPorPasso.Enabled = false;
            this.chbPorPasso.ForeColor = System.Drawing.Color.White;
            this.chbPorPasso.Location = new System.Drawing.Point(131, 17);
            this.chbPorPasso.Name = "chbPorPasso";
            this.chbPorPasso.Size = new System.Drawing.Size(95, 17);
            this.chbPorPasso.TabIndex = 38;
            this.chbPorPasso.Text = "Passo a passo";
            this.chbPorPasso.UseVisualStyleBackColor = true;
            this.chbPorPasso.Visible = false;
            this.chbPorPasso.CheckedChanged += new System.EventHandler(this.chbPorPasso_CheckedChanged);
            // 
            // gbxBotDebug
            // 
            this.gbxBotDebug.Controls.Add(this.lblDelay);
            this.gbxBotDebug.Controls.Add(this.btnContinuar);
            this.gbxBotDebug.Controls.Add(this.chbPorPasso);
            this.gbxBotDebug.Controls.Add(this.nmrDelay);
            this.gbxBotDebug.Enabled = false;
            this.gbxBotDebug.ForeColor = System.Drawing.Color.White;
            this.gbxBotDebug.Location = new System.Drawing.Point(12, 455);
            this.gbxBotDebug.Name = "gbxBotDebug";
            this.gbxBotDebug.Size = new System.Drawing.Size(232, 105);
            this.gbxBotDebug.TabIndex = 39;
            this.gbxBotDebug.TabStop = false;
            this.gbxBotDebug.Text = "Debug";
            this.gbxBotDebug.Visible = false;
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(3, 21);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(105, 13);
            this.lblDelay.TabIndex = 39;
            this.lblDelay.Text = "Delay(100ms * Valor)";
            // 
            // lblProbabilidadeCair
            // 
            this.lblProbabilidadeCair.AutoSize = true;
            this.lblProbabilidadeCair.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProbabilidadeCair.ForeColor = System.Drawing.Color.White;
            this.lblProbabilidadeCair.Location = new System.Drawing.Point(924, 300);
            this.lblProbabilidadeCair.Name = "lblProbabilidadeCair";
            this.lblProbabilidadeCair.Size = new System.Drawing.Size(135, 28);
            this.lblProbabilidadeCair.TabIndex = 37;
            this.lblProbabilidadeCair.Text = "Probabilidade";
            this.lblProbabilidadeCair.Visible = false;
            // 
            // lblJogadas
            // 
            this.lblJogadas.AutoSize = true;
            this.lblJogadas.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadas.ForeColor = System.Drawing.Color.White;
            this.lblJogadas.Location = new System.Drawing.Point(903, 455);
            this.lblJogadas.Name = "lblJogadas";
            this.lblJogadas.Size = new System.Drawing.Size(83, 28);
            this.lblJogadas.TabIndex = 40;
            this.lblJogadas.Text = "Jogadas";
            this.lblJogadas.Visible = false;
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimite.ForeColor = System.Drawing.Color.White;
            this.lblLimite.Location = new System.Drawing.Point(928, 339);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(65, 28);
            this.lblLimite.TabIndex = 41;
            this.lblLimite.Text = "Limite";
            this.lblLimite.Visible = false;
            // 
            // lblTituloProbabilidadeCair
            // 
            this.lblTituloProbabilidadeCair.AutoSize = true;
            this.lblTituloProbabilidadeCair.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProbabilidadeCair.ForeColor = System.Drawing.Color.White;
            this.lblTituloProbabilidadeCair.Location = new System.Drawing.Point(924, 261);
            this.lblTituloProbabilidadeCair.Name = "lblTituloProbabilidadeCair";
            this.lblTituloProbabilidadeCair.Size = new System.Drawing.Size(198, 28);
            this.lblTituloProbabilidadeCair.TabIndex = 42;
            this.lblTituloProbabilidadeCair.Text = "Probabilidade de cair";
            this.lblTituloProbabilidadeCair.Visible = false;
            // 
            // FormTabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1148, 646);
            this.Controls.Add(this.lblTituloProbabilidadeCair);
            this.Controls.Add(this.lblLimite);
            this.Controls.Add(this.lblJogadas);
            this.Controls.Add(this.gbxBotDebug);
            this.Controls.Add(this.lblProbabilidadeCair);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.btnPassarVez);
            this.Controls.Add(this.btnRolarDados);
            this.Controls.Add(this.pcbStatusBot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVezDe);
            this.Controls.Add(this.lblJogadorVez);
            this.Controls.Add(this.lblAntipenultimaJogada);
            this.Controls.Add(this.lblPenultinaJogada);
            this.Controls.Add(this.lblUltimaJogada);
            this.Controls.Add(this.lblUltimasJogadas);
            this.Controls.Add(this.gbxJogadas);
            this.Controls.Add(this.pcbDado4);
            this.Controls.Add(this.pcbDado3);
            this.Controls.Add(this.pcbDado1);
            this.Controls.Add(this.pcbDado2);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.pcbTabuleiro);
            this.Controls.Add(this.lblPartidaIniciada);
            this.Controls.Add(this.lblCorJogador);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblJogador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormTabuleiro";
            this.Text = "Tabuleiro";
            this.Load += new System.EventHandler(this.Tabuleiro_Load);
            this.gbxJogadas.ResumeLayout(false);
            this.gbxJogadas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTabuleiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStatusBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDelay)).EndInit();
            this.gbxBotDebug.ResumeLayout(false);
            this.gbxBotDebug.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblCorJogador;
        private System.Windows.Forms.Label lblPartidaIniciada;
        private System.Windows.Forms.Timer tmrPartidaIniciada;
        private System.Windows.Forms.Timer tmrPartidaJogando;
        private System.Windows.Forms.PictureBox pcbTabuleiro;
        private System.Windows.Forms.PictureBox pcbDado2;
        private System.Windows.Forms.PictureBox pcbDado1;
        private System.Windows.Forms.PictureBox pcbDado3;
        private System.Windows.Forms.PictureBox pcbDado4;
        private System.Windows.Forms.GroupBox gbxJogadas;
        private System.Windows.Forms.RadioButton rbxOpcao3;
        private System.Windows.Forms.RadioButton rbxOpcao2;
        private System.Windows.Forms.RadioButton rbxOpcao1;
        private System.Windows.Forms.RadioButton rbxOpcao4;
        private System.Windows.Forms.RadioButton rbxOpcao5;
        private System.Windows.Forms.RadioButton rbxOpcao6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblOu3;
        private System.Windows.Forms.Label lblOu2;
        private System.Windows.Forms.Label lblOu1;
        private System.Windows.Forms.Label lblUltimasJogadas;
        private System.Windows.Forms.Label lblUltimaJogada;
        private System.Windows.Forms.Label lblAntipenultimaJogada;
        private System.Windows.Forms.Label lblPenultinaJogada;
        private System.Windows.Forms.Label lblJogadorVez;
        private System.Windows.Forms.Label lblVezDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbStatusBot;
        private System.Windows.Forms.Timer tmrJogadaBot;
        private System.Windows.Forms.Button btnRolarDados;
        private System.Windows.Forms.Button btnPassarVez;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.NumericUpDown nmrDelay;
        private System.Windows.Forms.CheckBox chbPorPasso;
        private System.Windows.Forms.GroupBox gbxBotDebug;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Label lblProbabilidadeCair;
        private System.Windows.Forms.Label lblJogadas;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblTituloProbabilidadeCair;
    }
}