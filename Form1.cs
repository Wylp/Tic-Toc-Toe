using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TP04_192149
{
    public partial class Form1 : Form
    {

        #region Variaveis Globais
        int playerScore1, playerScore2, turn = 1;
        int[,] table = new int[3, 3];
        int aux;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region setCurrentPlayer
        public void setCurrentPlayer() {
            if (turn == 1)
            {
                Lbl_playerName1.ForeColor = System.Drawing.Color.Black;
                Lbl_playerName2.ForeColor = System.Drawing.Color.Red;
                turn = 2;
            }
            else {
                Lbl_playerName1.ForeColor = System.Drawing.Color.Red;
                Lbl_playerName2.ForeColor = System.Drawing.Color.Black;
                turn = 1;
            }

        }
        #endregion

        #region BottonGame
        private void Btn_NW_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                table[0, 0] = 1;
                Btn_NW.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\x.png");
            }
            else {
                table[0, 0] = 10;
                Btn_NW.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\o.png");
            }
            winVerif();
            setCurrentPlayer();
        }
        private void Btn_N_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                table[0, 1] = 1;
                Btn_N.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\x.png");
            }
            else
            {
                table[0, 1] = 10;
                Btn_N.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\o.png");
            }
            winVerif();
            setCurrentPlayer();
        }
        private void Btn_NE_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                table[0, 2] = 1;
                Btn_NE.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\x.png");
            }
            else
            {
                table[0, 2] = 10;
                Btn_NE.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\o.png");
            }
            winVerif();
            setCurrentPlayer();
        }
        private void Btn_W_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                table[1, 0] = 1;
                Btn_W.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\x.png");
            }
            else
            {
                table[1, 0] = 10;
                Btn_W.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\o.png");
            }
            winVerif();
            setCurrentPlayer();
        }
        private void Btn_C_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                table[1, 1] = 1;
                Btn_C.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\x.png");
            }
            else
            {
                table[1, 1] = 10;
                Btn_C.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\o.png");
            }
            winVerif();
            setCurrentPlayer();
        }
        private void Btn_E_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                table[1, 2] = 1;
                Btn_E.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\x.png");
            }
            else
            {
                table[1, 2] = 10;
                Btn_E.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\o.png");
            }
            winVerif();
            setCurrentPlayer();
        }
        private void Btn_SW_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                table[2, 0] = 1;
                Btn_SW.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\x.png");
            }
            else
            {
                table[2, 0] = 10;
                Btn_SW.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\o.png");
            }
            winVerif();
            setCurrentPlayer();
        }
        private void Btn_S_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                table[2, 1] = 1;
                Btn_S.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\x.png");
            }
            else
            {
                table[2, 1] = 10;
                Btn_S.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\o.png");
            }
            winVerif();
            setCurrentPlayer();
        }
        private void Btn_SE_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                table[2, 2] = 1;
                Btn_SE.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\x.png");
            }
            else
            {
                table[2, 2] = 10;
                Btn_SE.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\o.png");
            }
            winVerif();
            setCurrentPlayer();
        }
        #endregion

        #region winVerif
        public void winVerif() {
            if (logicH1(0) || logicH1(1) || logicH1(2)) {
                MessageBox.Show("Jogador X Venceu");
                playerScore1++;
                Lbl_score1.Text = Convert.ToString(playerScore1);
                resetTable();
            } else if (logicH2(0) || logicH2(1) || logicH2(2)) {
                MessageBox.Show("Jogador O Venceu");
                playerScore2++;
                Lbl_score2.Text = Convert.ToString(playerScore2);
                resetTable();
            } else if (logicV1(0) || logicV1(1) || logicV1(2)) {
                MessageBox.Show("Jogador X Venceu");
                playerScore1++;
                Lbl_score1.Text = Convert.ToString(playerScore1);
                resetTable();
            } else if (logicV2(0) || logicV2(1) || logicV2(2)) {
                MessageBox.Show("Jogador O Venceu");
                playerScore2++;
                Lbl_score2.Text = Convert.ToString(playerScore2);
                resetTable();
            } else if (calcD1() == 3) {
                MessageBox.Show("Jogador X Venceu");
                playerScore1++;
                Lbl_score1.Text = Convert.ToString(playerScore1);
                resetTable();
            } else if (calcD1() == 30) {
                MessageBox.Show("Jogador O Venceu");
                playerScore2++;
                Lbl_score2.Text = Convert.ToString(playerScore2);
                resetTable();
            } else if (calcD2() == 3) {
                MessageBox.Show("Jogador X Venceu");
                playerScore1++;
                Lbl_score1.Text = Convert.ToString(playerScore1);
                resetTable();
            } else if (calcD2() == 30) {
                MessageBox.Show("Jogador O Venceu");
                playerScore2++;
                Lbl_score2.Text = Convert.ToString(playerScore2);
                resetTable();
            } else if (fullBoard()) {
                MessageBox.Show("Empate");
                resetTable();
            }
        }
        #region Calculos
        private bool logicH1(int line){
            for (int c = 0; c < 3; c++) {
                if (table[line, c] != 1) {
                    return false;
                }
            }
            return true;
        }

        private bool logicH2(int line){
            for (int c = 0; c < 3; c++){
                if (table[line, c] != 10) {
                    return false;
                }
            }
            return true;
        }

        private bool logicV1(int column){
            for (int l = 0; l < 3; l++){
                if (table[l, column] != 1)
                {
                    return false;
                }
            }
            return true;
        }
        private bool logicV2(int column){
            for (int l = 0; l < 3; l++){
                if (table[l, column] != 10)
                {
                    return false;
                }
            }
            return true;
        }

        private int calcD1() {
            return table[0,0] + table[1,1] + table[2,2];
        }
        private int calcD2() {
            return table[0,2] + table[1,1] + table[2,0];
        }
        #endregion
        #region FullBoard
        private bool fullBoard() {
            for (int l = 0; l < 3; l++) {
                for (int c = 0; c < 3; c++) {
                    if (table[l, c] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion

        #endregion

        #region Reset
        public void resetTable()
        {
            for (int l = 0; l < 3; l++) {
                for (int c = 0; c < 3; c++) {
                    table[l, c] = 0;
                }
            }

            Btn_NW.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\white.png");
            Btn_N.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\white.png");
            Btn_NE.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\white.png");
            Btn_W.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\white.png");
            Btn_C.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\white.png");
            Btn_E.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\white.png");
            Btn_SW.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\white.png");
            Btn_S.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\white.png");
            Btn_SE.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\white.png");
        }

        public void resetGame() {
            playerScore1 = 0;
            playerScore2 = 0;
            Lbl_score1.Text = Convert.ToString(playerScore1);
            Lbl_score2.Text = Convert.ToString(playerScore2);

            resetTable();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            resetGame();
        }
        #endregion

    }
}
