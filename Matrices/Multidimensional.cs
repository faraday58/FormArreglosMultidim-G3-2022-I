
namespace Matrices
{
    public class Multidimensional:Matriz
    {
        private float[,] A;

        public Multidimensional(int M,int N)
        {
            this.M = M;
            this.N = N;
            A = new  float[M,N];
        }

      /*  public static Multidimensional Leer(string A  )
        {
            //1,2,3,4;5,6,7,8
          //  string[] renglones = A.Split(';');
          //  string[] columnas = renglones[0].Split(',');




            //for( int i=0;    )


        }
      */

    }
}
