﻿using System;
namespace ConsumoListaApp.Model
{
    public class Mestre
    {
        public string tipo { get; set; }
        public string nome { get; set; }

        public Mestre()
        {
        }

        public static explicit operator Mestre(string v)
        {
            throw new NotImplementedException();
        }
    }
}
