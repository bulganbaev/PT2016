﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace snake.models
{
    public class Food : Drawer
    {
        public Food()
        {
            color = ConsoleColor.Yellow;
            sign = '$';
            setNewPosition();
        }

        public void setNewPosition()
        {
            
            int x = (new Random().Next()) % 20;
            int y = (new Random().Next()) % 20;
            if (body.Count == 0)
                body.Add(new Point(x, y));
            else
            {
                body[0].x = x;
                body[0].y = y;
            }
          
          

        }
    }
}
