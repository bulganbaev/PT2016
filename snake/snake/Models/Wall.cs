using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace snake.models
{
    public class Wall: Drawer
    {
        public Wall()
        {
            color = ConsoleColor.Red;
            sign = '#';
            setLevel(1);
        }

        public void setLevel(int level)
        {
            string fileName = string.Format(@"C:\Users\User\Desktop\map\level{0}.txt", level);
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            string map = sr.ReadToEnd();
            string[] rows = map.Split('\n');

            // ......####.... rows[0]
            // .....####..... rows[1]
            body.Clear();
  
            for (int i = 0; i < rows.Length; i++)
                for (int j = 0; j < rows[i].Length; j++)
                    if (rows[i][j] == '#')
                        body.Add(new Point(j, i));
            for (int i = 0; i < 66; i++)
                body.Add(new Point(i, 0));
            for (int i = 0; i < 66; i++)
                body.Add(new Point(i, 29));
            for (int i = 0; i < 30; i++)
                body.Add(new Point(0, i));
            for (int i = 0; i < 30; i++)
                body.Add(new Point(66,i));
           

            sr.Close();
            fs.Close();
        }
    }
}
