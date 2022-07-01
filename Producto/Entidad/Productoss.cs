using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{


    public class Productoss
    {


        public class Productos
        {

            public Productos(int cod, string desc, int cant)
            {
                codigo = cod;
                descripcion = desc;
                stock = cant;

            }
            #region atributos
            public int codigo;
            public string descripcion;
            public int stock;
            #endregion
            #region ctor
            public Productos()
            {

            }

            public Productos(int cod, string desc)
            {
                codigo = cod;
                descripcion = desc;
                stock = 0;
            }
            #endregion
            #region metodos
            public void Ingreso(int cant)
            {
                stock = stock + cant;
            }
            public void Salida(int cant)
            {
                stock = stock - cant;
            }
            #endregion

            public int p_codigo

            {

                set { codigo = value; }
                get { return codigo; }

            }

            public string p_descripcion
            {

                set { descripcion = value; }
                get { return descripcion; }
            
            }
            
            public int p_stock

            {
            
            get { return stock; }
            
            }
        
        
        }
    }
}