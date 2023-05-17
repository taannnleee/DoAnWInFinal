using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinDows.Utilities
{
    public class Captcha
    {
        public static string CaptchaRanDom()
        {
            string captcha = "";
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                int rand = random.Next(0, 36);
                if (rand < 10)
                {
                    captcha += rand.ToString();
                }
                else
                {
                    char temp = (char)(97 + rand - 10);  //97 = 'a'
                    captcha += temp.ToString();
                }
            }
            return captcha;
        }

        public static void DrawCaptcha(string captcha, PictureBox picCaptcha)
        {
            Bitmap bm = new Bitmap(picCaptcha.Width, picCaptcha.Height);
            Graphics graphics = Graphics.FromImage(bm);
            graphics.Clear(Color.White);
            Random rand = new Random();
            for (int i = 0; i < captcha.Length; i++)
            {
                Font font = new Font("Arial", 28, FontStyle.Bold);
                Brush brush = new SolidBrush(Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)));
                graphics.DrawString(captcha[i].ToString(), font, brush, i * 25, 0);
            }
            picCaptcha.Image = bm;
        }
    }
}
