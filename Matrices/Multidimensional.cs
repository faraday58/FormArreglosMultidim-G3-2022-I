using System;
namespace Matrices
{
    public class Multidimensional:Matriz
    {
        private float[,] A;

        /// <summary>
        /// Constructor de la clase Multidimensional que permite definir 
        /// el número de renglones y columnas del arreglo
        /// </summary>
        /// <param name="M">Renglones</param>
        /// <param name="N">Columnas</param>
        public Multidimensional(int M,int N)
        {
            
            this.M = M;
            this.N = N;
            A = new  float[M,N];
        }


        public static Multidimensional Leer(string A  )
        {
            //1,2,3,4;5,6,7,8
            string[] renglones = A.Split(';'); // Las cadenas son inmutables, 
            string[] columnas = renglones[0].Split(',');
            Multidimensional m1 = new Multidimensional(renglones.Length,columnas.Length);           

            for(int i=0; i < m1.M ; i++   )
            {
                columnas =renglones[i].Split(',');
                for( int j=0; j< m1.N; j++ )
                {
                    m1.A[i, j] = float.Parse(columnas[j]);
                }
            }
            return m1;
        }

        public override string ToString()
        {
            //1 2 3 4
            //5 6 7 8
            string A = "";
            for( int i =0; i < M; i++ )
            {
                for(int j =0; j<N; j++)
                {
                    A = A + " " + this.A[i,j].ToString();
                }
                A = A + "\n";
            }
            return A ;
        }




    }
}
