using Formatos_Geometricos_COM_INTERFACE.Model.Entities;

namespace Formatos_Geometricos_COM_INTERFACE
{
    abstract class Abstract_Formato : IFormato
    {
        public Cor Cor { get; set; }

        public abstract double Area();
    }
}
