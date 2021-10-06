
namespace Matrices
{
    public class Matriz
    {

        #region Atributos
        private int m;
        private int n;
        #endregion

        #region Propiedades
        public int M
        {
            get => m;
            set
            {
                if( value < 1   )
                {
                    m = 1;
                }
                else
                {
                    m = value;
                }
                
            }
        }
        public int N { 
            get => n; 
            set
            {
                if( value < 1 )
                {
                    n = 1;
                }
                else
                {
                    n = value;
                }    
                
            }
                
        }
        #endregion
    }

}
