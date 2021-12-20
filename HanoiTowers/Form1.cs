using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HanoiTowers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Solver s = new Solver();
        Random rnd = new Random();
        int moveIndex = 0;
        List<Move> solutionMoves = new List<HanoiTowers.Move>();
        List<Button> Pole1 = new List<Button>();
        List<Button> Pole2 = new List<Button>();
        List<Button> Pole3 = new List<Button>();


        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SolveFor(3);
            init(3);
        }

        private void SolveFor(int diskSize)
        {
            txtDurum.Text = "Solving..."; this.Refresh();//To show "solving" text in status bar...No refresh, no change :)
            solutionMoves = s.SolveHanoi(diskSize);
            int i = 1;
            lstHamleler.Items.Clear();
            foreach (Move m in solutionMoves)
            {
                lstHamleler.Items.Add(i + ". " + m.poleFrom + "→ " + m.poleTo);
                i++;
            }
            txtDurum.Text = "Finished Solving. Total Move Count : " +  (Math.Pow(2,diskSize)-1).ToString() + ". Click Play to watch moves";
        }

        private void init(int diskSize)
        {
            Pole1.Clear();
            Pole2.Clear();
            Pole3.Clear();
            oynatToolStripMenuItem.Enabled = true;
            List<Button> btnstoDelete = new List<Button>();
            foreach (Control c in this.Controls)
            {
                Button b = c as Button;
                if (null != b)
                { btnstoDelete.Add(b); }
            }
            foreach (Button b in btnstoDelete)
            {
                b.Dispose();
            }
            Button btn = new Button();
            for (int i = 0; i < diskSize; i++)
            {
                btn = new Button();
                btn.Location = new Point(160 + (i * 5), 470 - (i * 30));
                btn.Size = new Size(200 - (i * 10), 30);
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = FlatStyle.Popup;
                btn.BackColor = RandomColor();
                this.Controls.Add(btn);
                Pole1.Add(btn);
            }
            pbKule1.SendToBack();
        }

        private int count = 0;
        private Color RandomColor()
        {
            if (count <= 235)
            {
                count += 20;
                return Color.FromArgb(count, count+10, count+10);
                
            }
            count = 0;
            return Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            string input = "";
            ShowInputDialog(ref input);
            int n;
            if (!int.TryParse(input, out n)||n>15||input=="")//More than 15 is solveable. But the button heights arent responsible. So it doesnt fit in the screen :)
            {
                MessageBox.Show("Please enter numeric between 3-15");
                txtDurum.Text = "Please enter numeric between 3-15";
            }
            else {
            SolveFor(Convert.ToInt16(input));
            init(Convert.ToInt16(input));
            }
        }

        private static DialogResult ShowInputDialog(ref string input)
        {
            //Nothing to do here. 
            //Copy-Paste code from stackoverflow to show an inputdialog!
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            inputBox.ClientSize = size;
            inputBox.Text = "Please enter numeric between 3-15";

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }

        private void oynatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moveIndex = 0;
            timer1.Start();
            oynatToolStripMenuItem.Enabled = false;
        }
        private void makeMove(Move m)
        {

                Button btntoMove = new Button(); //Get the last element of a pole which is on the top.

                switch (m.poleTo)
                {
                    case 1:
                        switch (m.poleFrom)
                        {
                            case 2:
                                btntoMove = Pole2.Last();
                                moveButton(btntoMove, 1);
                                Pole1.Add(btntoMove);
                                Pole2.RemoveAt(Pole2.Count - 1);
                                break;
                            case 3:
                                btntoMove = Pole3.Last();
                                moveButton(btntoMove, 1);
                                Pole1.Add(btntoMove);
                                Pole3.RemoveAt(Pole3.Count - 1);
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        switch (m.poleFrom)
                        {
                            case 1:
                                btntoMove = Pole1.Last();
                                moveButton(btntoMove, 2);
                                Pole2.Add(btntoMove);
                                Pole1.RemoveAt(Pole1.Count - 1);
                                break;
                            case 3:
                                btntoMove = Pole3.Last();
                                moveButton(btntoMove, 2);
                                Pole2.Add(btntoMove);
                                Pole3.RemoveAt(Pole3.Count - 1);
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        switch (m.poleFrom)
                        {
                            case 2:
                                btntoMove = Pole2.Last();
                                moveButton(btntoMove, 3);
                                Pole3.Add(btntoMove);
                                Pole2.RemoveAt(Pole2.Count - 1);
                                break;
                            case 1:
                                btntoMove = Pole1.Last();
                                moveButton(btntoMove, 3);
                                Pole3.Add(btntoMove);
                                Pole1.RemoveAt(Pole1.Count - 1);
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            

        }
        private void moveButton(Button toMove, int PoleIndex)
        {
            Point startPoint = toMove.Location;
            Point endPoint = new Point();
            switch (PoleIndex)
            {
                case 1:
                    endPoint= new Point(160 + ((200 - toMove.Size.Width) / 2), 470 - ((Pole1.Count()) * 30));
                    break;
                case 2:
                    endPoint = new Point(366 + ((200 - toMove.Size.Width) / 2), 470 - ((Pole2.Count()) * 30));
                    break;
                case 3:
                    endPoint = new Point(572 + ((200 - toMove.Size.Width) / 2), 470 - ((Pole3.Count()) * 30));
                    break;
                default:
                    break;
            }

            for (int i = 0; i <= 5; i++)
            {
                toMove.Location = new Point(startPoint.X + Convert.ToInt16((Convert.ToDecimal(endPoint.X) - startPoint.X) / 5 * i), startPoint.Y + (endPoint.Y - startPoint.Y) / 5 * i); // Converts are for decimal divides
                toMove.BringToFront();
                this.Refresh();
                Thread.Sleep(20);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (moveIndex < solutionMoves.Count)
            {
                Move m = solutionMoves.ElementAt(moveIndex);
                txtDurum.Text = moveIndex + 1 + ".Move = From Pole: " + m.poleFrom + " → To Pole: " + m.poleTo;
                makeMove(m);
                moveIndex++;
                lstHamleler.SelectedIndex = moveIndex-1;
            }
            else {
                timer1.Stop();
                oynatToolStripMenuItem.Enabled = false;
                txtDurum.Text = "Finished Playing. You can start with a new setting.";
            }

        }

        private void cmbHiz_IndexChanged(object sender, EventArgs e)
        {
                switch (cmbHiz.SelectedIndex)
                {
                case 0:timer1.Interval = 2000; break;
                case 1: timer1.Interval = 1000; break;
                case 2: timer1.Interval = 500; break;
                case 3: timer1.Interval = 250; break;
                case 4: timer1.Interval = 200; break;
                default: break;
                }
        }


        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
