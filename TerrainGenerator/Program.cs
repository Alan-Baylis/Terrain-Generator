﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerrainGenerator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            int octaves = 6;
            double frequency = 5;
            double persistance = .5;
            double lacunarity = 2.12;
            NoiseGenerator generator = new NoiseGenerator();
            string filename = "terrain.raw";

            using (BinaryWriter writer = new BinaryWriter(File.Open(filename, FileMode.Create)))
            {
                for (int i = 0; i < 1024; i++)
                {
                    for (int j = 0; j < 1024; j++)
                    {
                        UInt16 output = (ushort)(generator.OctavePerlin(i * .001, j * .001, 0, frequency, octaves, persistance, lacunarity) * 65536);
                        //Console.WriteLine(output);
                        writer.Write(output);
                    }
                }
            }
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/
        }
    }

    class NoiseGenerator
    {
        private static int repeat = 0;
        // permutation table for generating psuedorandom numbers
        private static int[] p =
        {
            120, 227, 122, 223, 150, 210, 83, 69, 231, 131, 225, 55, 160, 121, 86, 232, 1, 93, 13, 188, 41, 117, 134, 113, 90, 23, 3, 9, 108,
            72, 197, 79, 255, 163, 214, 155, 208, 220, 56, 224, 202, 248, 42, 34, 171, 6, 145, 174, 172, 20, 57, 181, 111, 203, 62, 156, 43,
            25, 61, 40, 239, 60, 196, 44, 29, 75, 116, 103, 119, 254, 22, 195, 182, 33, 76, 26, 235, 153, 7, 178, 173, 102, 133, 18, 114, 17,
            249, 193, 159, 130, 12, 157, 14, 65, 87, 221, 28, 88, 67, 50, 180, 169, 152, 206, 199, 198, 24, 70, 141, 252, 215, 85, 185, 187,
            247, 89, 91, 99, 8, 233, 158, 71, 184, 175, 58, 46, 228, 226, 183, 109, 253, 54, 124, 162, 48, 179, 177, 74, 77, 59, 142, 96, 242,
            10, 143, 146, 204, 132, 201, 27, 209, 95, 222, 139, 151, 38, 82, 135, 148, 241, 63, 19, 37, 49, 238, 31, 251, 234, 0, 246, 168,
            106, 107, 128, 45, 68, 165, 30, 21, 176, 94, 2, 211, 125, 217, 189, 229, 127, 98, 147, 64, 194, 186, 51, 123, 149, 110, 237, 4,
            161, 129, 15, 166, 218, 144, 154, 104, 190, 118, 138, 97, 5, 137, 240, 81, 244, 105, 167, 115, 84, 243, 92, 192, 250, 205, 140,
            112, 100, 245, 213, 52, 16, 207, 78, 212, 35, 73, 47, 32, 53, 136, 80, 236, 230, 11, 170, 164, 39, 219, 216, 66, 101, 191, 126,
            200, 36, 120, 227, 122, 223, 150, 210, 83, 69, 231, 131, 225, 55, 160, 121, 86, 232, 1, 93, 13, 188, 41, 117, 134, 113, 90, 23, 3, 9, 108,
            72, 197, 79, 255, 163, 214, 155, 208, 220, 56, 224, 202, 248, 42, 34, 171, 6, 145, 174, 172, 20, 57, 181, 111, 203, 62, 156, 43,
            25, 61, 40, 239, 60, 196, 44, 29, 75, 116, 103, 119, 254, 22, 195, 182, 33, 76, 26, 235, 153, 7, 178, 173, 102, 133, 18, 114, 17,
            249, 193, 159, 130, 12, 157, 14, 65, 87, 221, 28, 88, 67, 50, 180, 169, 152, 206, 199, 198, 24, 70, 141, 252, 215, 85, 185, 187,
            247, 89, 91, 99, 8, 233, 158, 71, 184, 175, 58, 46, 228, 226, 183, 109, 253, 54, 124, 162, 48, 179, 177, 74, 77, 59, 142, 96, 242,
            10, 143, 146, 204, 132, 201, 27, 209, 95, 222, 139, 151, 38, 82, 135, 148, 241, 63, 19, 37, 49, 238, 31, 251, 234, 0, 246, 168,
            106, 107, 128, 45, 68, 165, 30, 21, 176, 94, 2, 211, 125, 217, 189, 229, 127, 98, 147, 64, 194, 186, 51, 123, 149, 110, 237, 4,
            161, 129, 15, 166, 218, 144, 154, 104, 190, 118, 138, 97, 5, 137, 240, 81, 244, 105, 167, 115, 84, 243, 92, 192, 250, 205, 140,
            112, 100, 245, 213, 52, 16, 207, 78, 212, 35, 73, 47, 32, 53, 136, 80, 236, 230, 11, 170, 164, 39, 219, 216, 66, 101, 191, 126,
            200, 36
        };


        static double Lerp(double input1, double input2, double weight)
        {
            return (1 - weight) * input1 + weight * input2 ;

        }

        // Fade function used to ease the coordinate values and smooth the final output
        static double Fade(double t)
        {
            return t * t * t * (t * (t * 6 - 15) + 10);
        }

        // pick a random vector based on the hash
        static double Grad(int hash, double x, double y, double z)
        {
            switch (hash & 0xF)
            {
                case 0x0: return x + y;
                case 0x1: return -x + y;
                case 0x2: return x - y;
                case 0x3: return -x - y;
                case 0x4: return x + z;
                case 0x5: return -x + z;
                case 0x6: return x - z;
                case 0x7: return -x - z;
                case 0x8: return y + z;
                case 0x9: return -y + z;
                case 0xA: return y - z;
                case 0xB: return -y - z;
                case 0xC: return y + x;
                case 0xD: return -y + z;
                case 0xE: return y - x;
                case 0xF: return -y - z;
                default: return 0; // should never happen
            }
        }

        public int Inc(int num)
        {
            num++;
            if (repeat > 0) num %= repeat;
            return num;
        }

        public double PerlinNoise(double x, double y, double z)
        {
            if (repeat > 0)
            {
                x %= repeat;
                y %= repeat;
                z %= repeat;
            }
            // calculate the unit cube that the point is located in
            int xi = (int)x & 255;
            int yi = (int)y & 255;
            int zi = (int)z & 255;
            // calulate the local coordinates within the world unit cube
            double xf = x - (int)x;
            double yf = y - (int)y;
            double zf = z - (int)z;

            double u = Fade(xf);
            double v = Fade(yf);
            double w = Fade(zf);

            // hash the coordinates surrounding the input coordinate
            int aaa, aba, aab, abb, baa, bba, bab, bbb;
            aaa = p[p[p[xi] + yi] + zi];
            aba = p[p[p[xi] + Inc(yi)] + zi];
            aab = p[p[p[xi] + yi] + Inc(zi)];
            abb = p[p[p[xi] + Inc(yi)] + Inc(zi)];
            baa = p[p[p[Inc(xi)] + yi] + zi];
            bba = p[p[p[Inc(xi)] + Inc(yi)] + zi];
            bab = p[p[p[Inc(xi)] + yi] + Inc(zi)];
            bbb = p[p[p[Inc(xi)] + Inc(yi)] + Inc(zi)];

            // Gradient function calculates the dot product between the psuedorandom vector and the location vector from the 8 surrounding corners of the unit cube
            // These are then interpolated based on the faded u, v, w values created earlier
            double x1, x2, y1, y2;
            x1 = Lerp(Grad(aaa, xf, yf, zf),
                      Grad(baa, xf - 1, yf, zf), u);
            x2 = Lerp(Grad(aba, xf, yf - 1, zf), 
                      Grad(bba, xf - 1, yf - 1, zf), u);
            y1 = Lerp(x1, x2, v);
            x1 = Lerp(Grad(aab, xf, yf, zf - 1),
                      Grad(bab, xf - 1, yf, zf - 1), u);
            x2 = Lerp(Grad(abb, xf, yf - 1, zf - 1),
                      Grad(bbb, xf - 1, yf - 1, zf - 1), u);
            y2 = Lerp(x1, x2, v);

            return (Lerp(y1, y2, w) + 1) / 2; // return interpolated result, change range from -1...1 to 0...1
        }

        public double OctavePerlin(double x, double y, double z, double frequency, int octaves, double persistance, double lacunarity)
        {
            double total = 0;
            double amplitude = 1;
            double maxValue = 0;
            for (int i = 0; i < octaves; i++)
            {
                total += PerlinNoise(x * frequency, y * frequency, z * frequency) * amplitude;
                maxValue += amplitude;
                amplitude *= persistance;
                frequency *= lacunarity;
            }
            return total / maxValue;
        }
    }
}
