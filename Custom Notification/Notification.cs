using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static F2a_Notification.PositionEnum;

namespace F2a_Notification
{
    public partial class Notification : Form
    {
        #region [ROUNDED BORDER AND SHADOW]
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,     // x-coordinate of upper-left corner
                int nTopRect,      // y-coordinate of upper-left corner
                int nRightRect,    // x-coordinate of lower-right corner
                int nBottomRect,   // y-coordinate of lower-right corner
                int nWidthEllipse, // height of ellipse
                int nHeightEllipse // width of ellipse
            );

        private const int CS_DROPSHADOW = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                // add the drop shadow flag for automatically drawing
                // a drop shadow around the form
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        #endregion [ROUNDED BORDER AND SHADOW]

        private readonly Form FormParent;
        private string Titre;
        private string Message;
        private Image Image;
        private Color BackgroundColor;
        private Color TextColor;
        private Position Position;
        

        public Notification()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            
        }
        
       
        public Notification(Form parentForm, string titre, string message, Image icon, Color backColor, Color textColor, Position position)
        {
            InitializeComponent();
            FormParent = parentForm;
            this.Titre = titre;
            this.Message = message;
            this.Image = icon;
            this.BackColor = backColor;
            this.TextColor = textColor;
            this.Position = position;


            //DEFINIR PARAMETRES
            LabelTitre.Text = titre;
            LabelMessage.Text = message;
            PictureBoxIcon.Image = icon;
            this.BackColor = backColor;
            LabelTitre.ForeColor = textColor;
            LabelMessage.ForeColor = textColor;

            //DEFINIR BORD ARRONDI
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }


        private void Notification_Load(object sender, EventArgs e)
        {
            FormLocation();
        }

        private void TimerSlideAnim_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1)
            {
                this.Opacity += 0.1;
            }
            SlideAnimation();

            
        }

        private void TimerTemps_Tick(object sender, EventArgs e)
        {
            ProgressBarTemps.Increment(10);
            if (ProgressBarTemps.Value == 100)
            {
                TimerTemps.Stop();
                TimerDisparition.Start();
            }
        }

        private void TimerDisparition_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            Disparition();
           
        }

        private void FormLocation()
        {
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int parentWidth = FormParent.Width;
            int parentHeight = FormParent.Height;
            int parentLocX = FormParent.Location.X;
            int parentLocY = FormParent.Location.Y;


            int espaceOccupe = parentWidth + parentLocX; //EspaceOccupe (longueur jusqu'à l'extrémité droit du FormParent) = Espace à gauche du FormParent + Largeur du FormParent
            int childWidth = this.Width;
            int childHeight = this.Height;
            int childX;
            int childY;
            switch (Position)
            {
                case Position.CenterScreen:
                    childX = parentWidth / 2 - childWidth / 2 + parentLocX;
                    childY = parentHeight / 2 - childHeight / 2 + parentLocY;
                    this.Location = new Point(childX, childY);
                    break;

                case Position.TopLeft:
                    childX = parentLocX;
                    childY = parentLocY;
                    this.Location = new Point(childX + 20, childY + 20); // +30 est l'Espace entre Haut de l'Ecran et le Haut du ChildForm(Dialog Notification) et -30 entre le Bord Droit de l'Ecran et celui du ChildForm
                    break;

                case Position.TopCenter:
                    childX = parentWidth / 2 - childWidth / 2 + parentLocX;
                    childY = parentLocY;
                    this.Location = new Point(childX, childY + 20);
                    break;

                case Position.TopRight:
                    childX = espaceOccupe - childWidth;
                    childY = parentLocY;
                    this.Location = new Point(childX - 20, childY + 20);
                    break;

                case Position.RightCenter:
                    childX = espaceOccupe - childWidth;
                    childY = parentHeight / 2 - childHeight / 2 + parentLocY;
                    this.Location = new Point(childX - 20, childY);
                    break;

                case Position.BottomRight:
                    childX = espaceOccupe - childWidth;
                    childY = parentLocY + parentHeight - childHeight;
                    this.Location = new Point(childX - 20, childY - 20);
                    break;

                case Position.BottomCenter:
                    childX = parentWidth / 2 - childWidth / 2 + parentLocX;
                    childY = parentLocY + parentHeight - childHeight;
                    this.Location = new Point(childX, childY - 20);
                    break;

                case Position.BottomLeft:
                    childX = parentLocX;
                    childY = parentLocY + parentHeight - childHeight;
                    this.Location = new Point(childX + 20, childY - 20);
                    break;

                case Position.LeftCenter:
                    childX = parentLocX;
                    childY = parentHeight / 2 - childHeight / 2 + parentLocY;
                    this.Location = new Point(childX + 20, childY);
                    break;

            }

        }

        private void SlideAnimation()
        {
            switch(Position)
            {
                case Position.CenterScreen:
                    TopToBottomSlideAnim();
                    break;
                case Position.TopLeft:
                    TopToBottomSlideAnim();
                    break;

                case Position.TopCenter:
                    TopToBottomSlideAnim();
                    break;

                case Position.TopRight:
                    TopToBottomSlideAnim();
                    break;

                case Position.RightCenter:
                    int w = FormParent.Location.X + FormParent.Width;
                    Left -= 2;
                    if (Left <= w + 20 && this.Opacity >= 1)
                    {
                        TimerAnim.Stop();
                        TimerTemps.Start();
                    }
                    break;

                case Position.BottomRight:
                    BottomToTopSlideAnim();
                    break;

                case Position.BottomCenter:
                    BottomToTopSlideAnim();
                    break;

                case Position.BottomLeft:  
                    BottomToTopSlideAnim();
                    break;

                case Position.LeftCenter:
                    Left += 2;
                    if (Left >= FormParent.Left + 20 && this.Opacity >= 1)
                    {
                        TimerAnim.Stop();
                        TimerTemps.Start();
                    }
                    break;

            }
        }

        private void Disparition()
        {
            switch (Position)
            {
                case Position.CenterScreen:
                    
                    break;
                case Position.TopLeft:
                    BottomToTopDisparition();
                    break;

                case Position.TopCenter:
                    BottomToTopDisparition();
                    break;

                case Position.TopRight:
                    BottomToTopDisparition();
                    break;

                case Position.RightCenter:
                    this.Left -= 2;
                    if (this.Opacity <= 0)
                    {
                        this.Close();
                        TimerDisparition.Stop();
                    }
                    break;

                case Position.BottomRight:
                    TopToBottomDisparition();
                    break;

                case Position.BottomCenter:
                    TopToBottomDisparition();
                    break;

                case Position.BottomLeft:
                    TopToBottomDisparition();
                    break;

                case Position.LeftCenter:
                    this.Left += 2;
                    if (this.Opacity <= 0)
                    {
                        this.Close();
                        TimerDisparition.Stop();
                    }
                    break;

            }
        }

        private void TopToBottomSlideAnim()
        {
            Top += 2;
            if (Top <= Screen.PrimaryScreen.WorkingArea.Height - this.Height - 20 && this.Opacity >= 1)
            {
                TimerAnim.Stop();
                TimerTemps.Start();
            }
        }

        private void TopToBottomDisparition()
        {
            this.Top += 2;
            if (this.Opacity <= 0)
            {
                this.Close();
                TimerDisparition.Stop();
            }

        }

        private void BottomToTopSlideAnim()
        {
            Top -= 2;
            if (Top <= Screen.PrimaryScreen.WorkingArea.Height - this.Height - 20 && this.Opacity >= 1)
            {
                TimerAnim.Stop();
                TimerTemps.Start();
            }
        }

        private void BottomToTopDisparition()
        {
            this.Top -= 2;
            if (this.Opacity <= 0)
            {
                this.Close();
                TimerDisparition.Stop();
            }
        }
    }
}
