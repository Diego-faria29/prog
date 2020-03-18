using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorComprimento
{
    class Comprimentos
    {
        private double quilometro;
        private double metro;
        private double centimetro;
        private double milimetro;
        private double micrometro;
        private double nanometro;
        private double milha;
        private double jarda;
        private double pe;
        private double polegada;
        private double milhanautica;


        public double Quilometro
        {
            get { return quilometro; }
            set
            {
                quilometro = value;
                metro      = value * 1000;
                centimetro = value * 100000;
                milimetro  = value * 1000000;
                micrometro = value * 1000000000;
                nanometro  = value * 1000000000000;
                milha      = value / 1.60934;
                jarda      = value * 1094;
                pe         = value * 3281;
                polegada   = value * 39370;
                milhanautica = value / 1.852;
            }
        }
        public double Metro
        {
            get { return metro; }
            set
            {
                metro = value;
                quilometro = value * 0.001;
                centimetro = value * 100;
                milimetro = value * 1000;
                micrometro = value * 1000000;
                nanometro = value * 1000000000;
                milha = value / 1609;
                jarda = value * 1.094;
                pe = value * 3.281;
                polegada = value * 39.370;
                milhanautica = value / 1852;
            }
        }
        public double Centimetro
        {
            get { return centimetro; }
            set
            {
                centimetro = value;
                quilometro = value / 100000;
                metro = value / 100;
                milimetro = value * 10;
                micrometro = value * 10000;
                nanometro = value * 10000000;
                milha = value / 160934;
                jarda = value / 91.44;
                pe = value / 30.48;
                polegada = value / 2.54;
                milhanautica = value / 185200;
            }
        }

        public double Milimetro
        {
            get { return milimetro; }
            set
            {
                milimetro = value;
                quilometro = value / 1000000;
                metro = value / 1000;
                centimetro = value / 10;
                micrometro = value * 1000;
                nanometro = value * 1000000;
                milha = value / 1609000000;
                jarda = value / 914;
                pe = value / 305;
                polegada = value / 25.4;
                milhanautica = value / 1852000000;
            }
        }

        public double Micrometro
        {
            get { return micrometro; }
            set
            {
                micrometro = value;
                quilometro = value / 1000000000;
                metro = value / 1000000;
                centimetro = value / 10000;
                milimetro = value / 1000;
                nanometro = value * 1000;
                milha = value / 1609000000000;
                jarda = value / 9144000;
                pe = value / 304800;
                polegada = value / 25400;
                milhanautica = value / 1852000000000;
            }
        }
        public double Nanometro
        {
            get { return nanometro; }
            set
            {
                nanometro = value;
                quilometro = value / 1000000000000;
                metro = value / 1000000000;
                centimetro = value / 100000000;
                milimetro = value / 1000000;
                micrometro = value / 1000;
                milha = value / 1609000000000000;
                jarda = value / 914400000000;
                pe = value / 3048000000000;
                polegada = value / 2540000000;
                milhanautica = value / 1852000000000000;
            }
        }

        public double Milha
        {
            get { return milha; }
            set
            {
                milha = value;
                quilometro = value * 1.609;
                metro = value * 1609;
                centimetro = value * 160934;
                milimetro = value * 1.609000000;
                micrometro = value * 1.609000000000;
                nanometro = value * 1609000000000000;
                jarda = value * 1760;
                pe = value * 5280;
                polegada = value * 63360;
                milhanautica = value / 1.151;
            }
        }
        public double Jarda
        {
            get { return jarda; }
            set
            {
                jarda = value;
                quilometro = value / 1094;
                metro = value / 1.094;
                centimetro = value * 91.44;
                milimetro = value * 914;
                micrometro = value * 914400;
                nanometro = value * 9.14400000000;
                milha = value / 1760;
                pe = value * 3;
                polegada = value * 36;
                milhanautica = value / 2025;
            }
        }
        public double Pe
        {
            get { return pe; }
            set
            {
                pe = value;
                quilometro = value / 3281;
                metro = value / 3.281;
                centimetro = value * 30.48;
                milimetro = value * 305;
                micrometro = value * 304800;
                nanometro = value * 3.04800000000;
                milha = value / 5280;
                jarda = value / 3;
                polegada = value * 12;
                milhanautica = value / 6076;
            }
        }

        public double Polegada
        {
            get { return polegada; }
            set
            {
                polegada = value;
                quilometro = value / 39370;
                metro = value / 39.37;
                centimetro = value * 2.54;
                milimetro = value * 25.4;
                micrometro = value * 25400;
                nanometro = value * 2.540000000;
                milha = value / 63360;
                jarda = value / 3;
                pe = value * 12;
                milhanautica = value / 72613;
            }
        }

        public double Milhanautica
        {
            get { return milhanautica; }
            set
            {
                milhanautica = value;
                quilometro = value * 1.852;
                metro = value * 1852;
                centimetro = value * 185200;
                milimetro = value * 1852000000;
                micrometro = value * 1852000000000;
                nanometro = value * 1852000000000000;
                milha = value * 1.151;
                jarda = value * 2025;
                pe = value * 6076;
                polegada = value * 72913;
            }
        }


    }
}
