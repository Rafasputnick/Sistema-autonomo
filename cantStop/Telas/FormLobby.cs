﻿using System;
using System.Windows.Forms;
using cantStop.Classes;
using CantStopServer;

namespace cantStop
{
    public partial class FormLobby : Form
    {
        public bool entrou = false;

        public Jogador jogadorCriado { get; set; }
        public Partida partidaSelecionada { get; set; }

        public FormLobby()
        {
            InitializeComponent();
            ListarPartidas();
        
        }

         private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ListarPartidas();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Partida partida = (Partida)dgvListaPartidas.SelectedRows[0].DataBoundItem;
            string nome = txbNome.Text;
            string senha = txbSenha.Text;
            int idPartida = (int)partida.Id;

            string retorno = Jogo.EntrarPartida(idPartida, nome, senha);
            if(retorno[0] == 'E') MessageBox.Show(retorno.Split(':')[1], "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else 
            {
                partidaSelecionada.ListarJogadores();
                this.jogadorCriado = new Jogador();
                this.jogadorCriado.entrandoPartida(retorno, txbNome.Text);

                this.entrou = true;

                this.Close();
            }
        }

        private void ListarPartidas()
        {
            ListaPartidas listaPartidas = new ListaPartidas("T");

            dgvListaPartidas.DataSource = listaPartidas.dadosPartidas; // Atribuindo os dados do objeto ao dataSource do dvgListaPartidas

            dgvListaPartidas.Columns[0].Visible = false; // Ocultando id partida
            dgvListaPartidas.Columns[3].Visible = false; // Ocultando senha partida

            dgvListaPartidas.Columns[1].Width = 101;
            dgvListaPartidas.Columns[2].Width = 99;
            dgvListaPartidas.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (this.partidaSelecionada == null)
            {
                partidaSelecionada = (Partida)listaPartidas.dadosPartidas[0];
                partidaSelecionada.jogadores = Jogador.ListarJogadores(partidaSelecionada.Id);
                lblJogadores.Text = "Jogadores de " + partidaSelecionada.Nome;

                switch (partidaSelecionada.jogadores.Count)
                {
                    case 0:
                        pcbIcon1.Visible = false;
                        pcbIcon2.Visible = false;
                        pcbIcon3.Visible = false;
                        pcbIcon4.Visible = false;

                        lblJogador1.Visible = false;
                        lblJogador3.Visible = false;
                        lblJogador4.Visible = false;
                        lblJogador2.Text = "A partida está vazia";
                        break;
                    case 1:
                        pcbIcon1.Visible = true;
                        pcbIcon2.Visible = false;
                        pcbIcon3.Visible = false;
                        pcbIcon4.Visible = false;

                        lblJogador1.Visible = true;
                        lblJogador2.Visible = false;
                        lblJogador3.Visible = false;
                        lblJogador4.Visible = false;

                        lblJogador1.Text = "-     " + partidaSelecionada.jogadores[0].nome;

                        // lblJogador1.Visible = false;
                        break;
                    case 2:
                        pcbIcon1.Visible = true;
                        pcbIcon2.Visible = true;
                        pcbIcon3.Visible = false;
                        pcbIcon4.Visible = false;

                        lblJogador1.Visible = true;
                        lblJogador2.Visible = true;
                        lblJogador3.Visible = false;
                        lblJogador4.Visible = false;

                        lblJogador1.Text = "-     " + partidaSelecionada.jogadores[0].nome;
                        lblJogador2.Text = "-     " + partidaSelecionada.jogadores[1].nome;

                        // lblJogador1.Visible = false;
                        break;
                    case 3:
                        pcbIcon1.Visible = true;
                        pcbIcon2.Visible = true;
                        pcbIcon3.Visible = true;
                        pcbIcon4.Visible = false;

                        lblJogador1.Visible = true;
                        lblJogador2.Visible = true;
                        lblJogador3.Visible = true;
                        lblJogador4.Visible = false;

                        lblJogador1.Text = "-     " + partidaSelecionada.jogadores[0].nome;
                        lblJogador2.Text = "-     " + partidaSelecionada.jogadores[1].nome;
                        lblJogador3.Text = "-     " + partidaSelecionada.jogadores[2].nome;

                        // lblJogador1.Visible = false;
                        break;
                    case 4:
                        pcbIcon1.Visible = true;
                        pcbIcon2.Visible = true;
                        pcbIcon3.Visible = true;
                        pcbIcon4.Visible = true;

                        lblJogador1.Visible = true;
                        lblJogador2.Visible = true;
                        lblJogador3.Visible = true;
                        lblJogador4.Visible = true;

                        lblJogador1.Text = "-     " + partidaSelecionada.jogadores[0].nome;
                        lblJogador2.Text = "-     " + partidaSelecionada.jogadores[1].nome;
                        lblJogador3.Text = "-     " + partidaSelecionada.jogadores[2].nome;
                        lblJogador4.Text = "-     " + partidaSelecionada.jogadores[3].nome;

                        break;
                }

            }
        }

        private void dgvListaPartidas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            partidaSelecionada = (Partida)dgvListaPartidas.SelectedRows[0].DataBoundItem;
            partidaSelecionada.ListarJogadores();
            lblJogadores.Text = "Jogadores de " + partidaSelecionada.Nome;

            switch (partidaSelecionada.jogadores.Count) {
                case 0:
                    pcbIcon1.Visible = false;
                    pcbIcon2.Visible = false;
                    pcbIcon3.Visible = false;
                    pcbIcon4.Visible = false;

                    lblJogador1.Visible = false;
                    lblJogador3.Visible = false;
                    lblJogador4.Visible = false;
                    lblJogador2.Text = "A partida está vazia";
                    break;
                case 1:
                    pcbIcon1.Visible = true;
                    pcbIcon2.Visible = false;
                    pcbIcon3.Visible = false;
                    pcbIcon4.Visible = false;

                    lblJogador1.Visible = true;
                    lblJogador2.Visible = false;
                    lblJogador3.Visible = false;
                    lblJogador4.Visible = false;

                    lblJogador1.Text = "-     " + partidaSelecionada.jogadores[0].nome;

                    // lblJogador1.Visible = false;
                    break;
                case 2:
                    pcbIcon1.Visible = true;
                    pcbIcon2.Visible = true;
                    pcbIcon3.Visible = false;
                    pcbIcon4.Visible = false;

                    lblJogador1.Visible = true;
                    lblJogador2.Visible = true;
                    lblJogador3.Visible = false;
                    lblJogador4.Visible = false;

                    lblJogador1.Text = "-     " + partidaSelecionada.jogadores[0].nome;
                    lblJogador2.Text = "-     " + partidaSelecionada.jogadores[1].nome;

                    // lblJogador1.Visible = false;
                    break;
                case 3:
                    pcbIcon1.Visible = true;
                    pcbIcon2.Visible = true;
                    pcbIcon3.Visible = true;
                    pcbIcon4.Visible = false;

                    lblJogador1.Visible = true;
                    lblJogador2.Visible = true;
                    lblJogador3.Visible = true;
                    lblJogador4.Visible = false;

                    lblJogador1.Text = "-     " + partidaSelecionada.jogadores[0].nome;
                    lblJogador2.Text = "-     " + partidaSelecionada.jogadores[1].nome;
                    lblJogador3.Text = "-     " + partidaSelecionada.jogadores[2].nome;

                    // lblJogador1.Visible = false;
                    break;
                case 4:
                    pcbIcon1.Visible = true;
                    pcbIcon2.Visible = true;
                    pcbIcon3.Visible = true;
                    pcbIcon4.Visible = true;

                    lblJogador1.Visible = true;
                    lblJogador2.Visible = true;
                    lblJogador3.Visible = true;
                    lblJogador4.Visible = true;

                    lblJogador1.Text = "-     " + partidaSelecionada.jogadores[0].nome;
                    lblJogador2.Text = "-     " + partidaSelecionada.jogadores[1].nome;
                    lblJogador3.Text = "-     " + partidaSelecionada.jogadores[2].nome;
                    lblJogador4.Text = "-     " + partidaSelecionada.jogadores[3].nome;

                    break;
            }

        }

        private void btnCriarSala_Click(object sender, EventArgs e)
        {
            string nome = txbNome.Text;
            string senha = txbSenha.Text;
            string retorno = Jogo.CriarPartida(nome, senha);

            if (retorno[0] == 'E') MessageBox.Show(retorno.Split(':')[1], "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else ListarPartidas();
        }

        private void btnEntrarBot_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrarEspec_Click(object sender, EventArgs e)
        {

        }

        private void btnInstrucoes_Click(object sender, EventArgs e)
        {

        }
    }
}