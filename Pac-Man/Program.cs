﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pac_Man
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tablero tab = new Tablero("level01.dat");
            tab.Dibuja();
            while (true)
            {
                tab.BorraPers();
                tab.pers[0].dirY = 1;
                tab.muevePacman();
                //tab.Dibuja();
                tab.DibujaPers();
                System.Threading.Thread.Sleep(500);
            }
            //Hola soy un comentario
            //Aqui miniman comentando
            //Otro commit en master
            //Aqui tendria que estar en miniman 2
            //Espero que miniman 2 no cambie esto
            //miman 2 cambio esto
        }
    }
}
