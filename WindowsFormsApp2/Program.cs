using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    class NewProgram
    {
        Random rand = new Random();

        public void taskTriangle(TextBox field, int N)
        {
            field.Text = "Все треугольники:\r\n";

            Triangle[] triangle = new Triangle[N];
            int maxS = 0;

            for(int i = 0; i < N; i++)
            {
                float s1 = (float)rand.Next(15) + 1;
                float s2 = (float)rand.Next(15) + 1;
                float s3 = (float)rand.Next(15) + 1;

                while (!Triangle.exists(s1, s2, s3))
                {
                    s1 = (float)rand.Next(15) + 1;
                    s2 = (float)rand.Next(15) + 1;
                    s3 = (float)rand.Next(15) + 1;
                }

                triangle[i] = new Triangle(s1, s2, s3);

                if (triangle[i].getSquare() > triangle[maxS].getSquare()) maxS = i;

                field.Text += "Треугольник №" + (i + 1) + "\r\n" + triangle[i].getInfo();
            }

            field.Text += "\r\nТреугольник с максимальной площадью:\r\n";
            field.Text += "Треугольник №" + (maxS + 1) + "\r\n" + triangle[maxS].getInfo();
        }

        public void taskRTriangle(TextBox field, int M)
        {
            field.Text = "Все прямоугольные треугольники:\r\n";

            RightTriangle[] triangle = new RightTriangle[M];

            int minH = 0;

            for(int i = 0; i < M; i++)
            {
                float s1 = (float)rand.Next(15) + 1;
                float s2 = (float)rand.Next(15) + 1;

                triangle[i] = new RightTriangle(s1, s2);

                if (triangle[i].getHypotenuse() < triangle[minH].getHypotenuse()) minH = i;

                field.Text += "Треугольник №" + (i + 1) + "\r\n" + triangle[i].getInfo();
            }

            field.Text += "\r\nТреугольник с минимальной гипотенузой:\r\n";
            field.Text += "Треугольник №" + (minH + 1) + "\r\n" + triangle[minH].getInfo();
        }
    }
}
