﻿
namespace Ucoin.Framework.Dependency
{
    public class SimpleLocator<T> where T : SimpleLocator, new()
    {
        private static T _instance;
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new T();
                }
                return _instance;
            }
        }

        /// <summary>
        /// Gets the current Locator <see cref="IContainer"/>.
        /// </summary>
        public static IContainer Current
        {
            get { return Instance.Container; }
        }        
    }

    public class SimpleLocator
    {
        private IContainer _container;

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleLocator"/> class.
        /// </summary>
        public SimpleLocator()
        {
            _container = new SimpleContainer();
            RegisterDefaults(_container);
        }

        /// <summary>
        /// Gets the <see cref="IContainer"/> for this instance.
        /// </summary>
        public IContainer Container
        {
            get { return _container; }
        }

        /// <summary>
        /// Registers the default service provider resolvers.
        /// </summary>
        /// <param name="container">The <see cref="IContainer"/> to register the default service resolvers with.</param>
        public virtual void RegisterDefaults(IContainer container)
        {
        }        
    }
}
