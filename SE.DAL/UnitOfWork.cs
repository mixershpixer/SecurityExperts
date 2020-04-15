//using BubiShop.DataProvider.Repositories;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SE.DAL
//{
//    public interface IUnitOfWork
//    {
//        IOrderRepository Orders { get; }
//        IProductRepository Products { get; }
//        IUserRepository Users { get; }
//        void Save();
//    }

//    public class UnitOfWork : IUnitOfWork
//    {
//        private BubiShopContext _context;

//        public UnitOfWork(BubiShopContext context)
//        {
//            _context = context;
//        }

//        private OrderRepository _orderRepository;
//        private ProductRepository _productRepository;
//        private UserRepository _userRepository;

//        public IOrderRepository Orders
//        {
//            get
//            {
//                if (_orderRepository == null)
//                {
//                    _orderRepository = new OrderRepository(_context);
//                }
//                return _orderRepository;
//            }
//        }

//        public IProductRepository Products
//        {
//            get
//            {
//                if (_productRepository == null)
//                {
//                    _productRepository = new ProductRepository(_context);
//                }
//                return _productRepository;
//            }
//        }

//        public IUserRepository Users
//        {
//            get
//            {
//                if (_userRepository == null)
//                {
//                    _userRepository = new UserRepository(_context);
//                }
//                return _userRepository;
//            }
//        }

//        public void Save() => _context.SaveChanges();
//    }
//}
