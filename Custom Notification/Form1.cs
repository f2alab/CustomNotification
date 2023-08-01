using System;
using System.Drawing;
using System.Windows.Forms;
using static F2a_Notification.PositionEnum;

namespace F2a_Notification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Threading.Timer timer = new System.Threading.Timer(Repeat, null, 0, 2000);
            //AfficherToutesLesNotifs();
        }

        private void Repeat (object o)
        {
            Console.WriteLine(DateTime.Now);
        }


        private void RBBtn_Click(object sender, EventArgs e)
        {
            F2aNotif.Notification(this, "TERMINER!", "Produit Ajouté", backColor: Color.Fuchsia, position: Position.BottomRight);
        }
        private void RCBtn_Click(object sender, EventArgs e)
        {
            string message = "Produit Ajouté";
            F2aNotif.Notification(this, "TERMINER!", message, backColor: Color.White, textColor: Color.Black, position: Position.RightCenter, separatorColor: Color.DarkCyan, messageBoxHeight: 30, titleBoxHeight: 10);
        }

        private void TRBtn_Click(object sender, EventArgs e)
        {
            F2aNotif.Notification(this, "TERMINER!TERMINER!TERMINER!TERMINER!", "Produit Ajouté Produit Ajouté Produit Ajouté Produit Ajouté Produit Ajouté Produit Ajouté Produit Ajouté Produit Ajouté", backColor: Color.Chocolate, position: Position.TopRight);
        }

        private void TCBtn_Click(object sender, EventArgs e)
        {
            F2aNotif.Notification(this, "TERMINER!", "Produit Ajouté", backColor: Color.Goldenrod, position: Position.TopCenter);
        }

        private void TLBtn_Click(object sender, EventArgs e)
        {
            F2aNotif.Notification(this, "TERMINER!", "Produit Ajouté", backColor: Color.SeaGreen, position: Position.TopLeft);
        }

        private void LCBtn_Click(object sender, EventArgs e)
        {
            F2aNotif.Notification(this, "TERMINER!", "Produit Ajouté", backColor: Color.Pink, position: Position.LeftCenter);
        }

        private void LBBtn_Click(object sender, EventArgs e)
        {
            F2aNotif.Notification(this, "TERMINER!", "Produit Ajouté", backColor: Color.Crimson, position: Position.BottomLeft);
        }

        private void BCBtn_Click(object sender, EventArgs e)
        {
            F2aNotif.Notification(this, "TERMINER!", "Produit Ajouté", backColor: Color.Cyan, position: Position.BottomCenter);
        }

        private void CSBtn_Click(object sender, EventArgs e)
        {
            F2aNotif.Notification(this, "TERMINER!", "Produit Ajouté", backColor: Color.DarkGray, position: Position.CenterScreen);
        }

        

        private void AfficherToutesLesNotifs()
        {

            F2aNotif.Notification(this, "TERMINER!", "Produit Ajouté", backColor: Color.Green, position: Position.TopLeft);
            F2aNotif.Notification(this, "TERMINER!", "Produit Ajouté", backColor: Color.Violet, position: Position.LeftCenter);
            F2aNotif.Notification(this, "TERMINER!", "Produit Ajouté", backColor: Color.DarkTurquoise, position: Position.TopCenter);
            F2aNotif.Notification(this, "TERMINER!", "Produit Ajouté", backColor: Color.Blue, position: Position.TopRight);
            F2aNotif.Notification(this, "TERMINER!", "Produit Ajouté", backColor: Color.Gray, position: Position.RightCenter);
            F2aNotif.Notification(this, "TERMINER!", "Produit Ajouté", backColor: Color.Gold, position: Position.BottomRight);
            F2aNotif.Notification(this, "TERMINER!", "Produit Ajouté", backColor: Color.BlueViolet, position: Position.BottomCenter);
            F2aNotif.Notification(this, "TERMINER!", "Produit Ajouté", backColor: Color.SandyBrown, position: Position.BottomLeft);
            F2aNotif.Notification(this, "TERMINER!", "Produit Ajouté", backColor: Color.Navy, position: Position.LeftCenter);
            F2aNotif.Notification(this, "TERMINER!", "Produit Ajouté", backColor: Color.Red, position: Position.CenterScreen);
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
