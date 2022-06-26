namespace PracticaAnimales.Repositorios
{
    public abstract class BaseRepositorio
    {
        protected _20221CPracticaEFContext _Contexto { get; set; }

        public BaseRepositorio(_20221CPracticaEFContext ctx)
        {
            _Contexto = ctx;    
        }

        public void SaveChanges()
        {
            _Contexto.SaveChanges();   
        }
    }
}
