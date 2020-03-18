using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Saper
{
    public partial class FormMainWindow : Form
    {
        //wielkość pojedynczego buttona w pikselach
        private const int fieldSize = 30;
        private SapperLogic myGame;
        public FormMainWindow()
        {
            InitializeComponent();
            //wywołanie metody tworzącej na start prostą grę
            prostaToolStripMenuItem_Click(null, null);
        }
        private void prostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myGame = new SapperLogic(8, 8, 10);
            generateView();
        }
        private void średniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myGame = new SapperLogic(12, 10, 25);
            generateView();
        }
        private void trudnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myGame = new SapperLogic(20, 15, 50);
            generateView();
        }
        //tworzenie nowej planszy
        private void generateView()
        {
            //kasowanie starych buttonów
            panelButtons.Controls.Clear();
            //generowanie nowych buttonów
            for (int x = 0; x < myGame.BoardWidth; x++)
            {
                for (int y = 0; y < myGame.BoardHeight; y++)
                {
                    Button b = new Button();
                    b.Size = new Size(fieldSize, fieldSize);
                    b.Location = new Point(fieldSize * x, fieldSize * y);
                    b.Click += button_Click;
                    panelButtons.Controls.Add(b);
                    //Tag jest typu object i można tam wstawić cokolwiek
                    //Trzeba jednak później pamiętać o kontroli i konwersji typów
                    //Każdy przycisk oznaczam przy pomocy jego logicznego położenia w odniesienu do planszy gry
                    b.Tag = new Point(x, y);
                }
            }
        }
        //obsługa kliknięcia na buttony podczas gry w sapera
        private void button_Click(object sender, EventArgs e)
        {
            if (myGame.State == SapperLogic.GameState.InProgress)
            {
                if (sender is Button)
                {
                    Button b = sender as Button;
                    if (b.Tag is Point)
                    {
                        Point p = (Point)b.Tag;

                        myGame.Uncover(p);
                        refreshView();

                        if (myGame.State == SapperLogic.GameState.Win)
                        {
                            MessageBox.Show("Wygrana");
                        }
                        else if (myGame.State == SapperLogic.GameState.Loss)
                        {
                            MessageBox.Show("Przegrana");
                        }
                    }
                }
            }
        }
        private void refreshView()
        {
            //pętla po wszystkich buttonach tworzących grę
            foreach (Button b in panelButtons.Controls)
            {
                //pobieram z gry pole powiązane z danym buttonem
                SapperLogic.Field f = myGame.GetFiled((Point)b.Tag);
                if (f.Covered == false)
                {
                    if (f.FieldType == SapperLogic.FieldTypeEnum.Bomb)
                    {
                        b.BackColor = Color.Red;
                        b.Text = "@";
                    }
                    //else dotyczy pól pustych i tych z cyframi
                    else
                    {
                        //dla obydwu rodzajów pól
                        b.BackColor = Color.White;
                        //tylko dla pól z cyframi
                        if (f.FieldType == SapperLogic.FieldTypeEnum.BombCount)
                        {
                            b.Text = f.BombCount.ToString();
                        }
                    }
                }
            }
        }
    }
}
