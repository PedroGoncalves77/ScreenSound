using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    internal class DAL<T> where T: class
    {
        private readonly Context context;
        public DAL(Context context)
        {
            this.context = context; 
        }
        public IEnumerable<T> Listar()
        {
            return context.Set<T>().ToList();
        }
        public void Adicionar(T objeto)
        {
            context.Set<T>().Add(objeto);   
            context.SaveChanges();
        }
        public void Alterar(T objeto)
        {
            context.Set<T>().Update(objeto);
            context.SaveChanges();
        }
        public void Deletar(T objeto)
        {
            context.Set<T>().Remove(objeto);
            context.SaveChanges();
        }
        public T? RetornaPor(Func<T, bool> func)
        {
            var elemento =  context.Set<T>().FirstOrDefault(func);
            return elemento;
        }

    }
}
