using F2a_Notification.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static F2a_Notification.PositionEnum;

namespace F2a_Notification
{
    public class F2aNotif
    {
        
        public static void Notification (Form parentForm, string titre, string message, Image icon = null, Color? backColor = null , Color? textColor = null, Color? separatorColor = null, Position position = Position.BottomRight)
        {
            Notification notification = new Notification(parentForm, titre, message, icon ?? Resources.Done_26px, backColor ?? Color.FromArgb(0, 192, 0), textColor??Color.White, separatorColor ?? Color.White, position);
            notification.Show();
        }
    }
}
