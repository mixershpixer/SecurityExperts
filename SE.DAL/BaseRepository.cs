//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SE.DAL
//{
//    public interface IRepository<T>
//        where T : class, new()
//    {
//        IEnumerable<T> GetAll();
//        T GetById(Guid id);
//        bool IsExists(Guid id);
//        //int GetCount();
//    }

//    public abstract class BaseRepository<T> : IRepository<T>
//        where T : class, new()
//    {
//        protected BubiShopContext Context { get; }

//        public BaseRepository(BubiShopContext context)
//        {
//            Context = context;
//        }

//        protected DbSet<T> DbSet
//        {
//            get
//            {
//                return Context.Set<T>();
//            }
//        }

//        public IEnumerable<T> GetAll()
//        {
//            return DbSet;
//        }

//        public T GetById(Guid id)
//        {
//            return DbSet.Find(id);
//        }

//        public bool IsExists(Guid id)
//        {
//            var entity = DbSet.Find(id);

//            if (entity == null)
//            {
//                throw new ApplicationException($"Can't find item with id = {id}");
//            }

//            return true;
//        }

//        //public int GetCount()
//        //{
//        //    return DbSet.Count();
//        //}
//    }
//}