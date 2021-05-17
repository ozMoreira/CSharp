using FormatoGeometrico_POO_Metodos_Abstratos.Entities.Enums;

namespace FormatoGeometrico_POO_Metodos_Abstratos
{
    abstract class Formato
    {
        public Cor Cor { get; set; }

        public Formato(Cor cor)
        {
            Cor = cor;
        }

        public abstract double Area();
        
    }


}
