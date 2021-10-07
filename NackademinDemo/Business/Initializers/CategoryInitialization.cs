using EPiServer.Cms.Shell;
using EPiServer.DataAbstraction;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using System.Collections.Generic;

namespace NackademinDemo.Business.Initializers
{
    [InitializableModule]
    [ModuleDependency(typeof(InitializableModule))]
    public class CategoryInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            CreateCategories();
        }

        private void CreateCategories()
        {
            var categoryRepository = ServiceLocator.Current.GetInstance<CategoryRepository>();
            var root = categoryRepository.GetRoot();

            if (categoryRepository.Get("[Fotbollslag]") == null)
            {
                var systemCategory = new Category(root, "[Fotbollslag]")
                {
                    Description = "[Fotbollslag]",
                    Selectable = false
                };

                categoryRepository.Save(systemCategory);

                var system = categoryRepository.Get("[Fotbollslag]");

                var team = new Category(system, "Djurgården")
                {
                    Description = "Djurgården",
                    Selectable = false
                };

                categoryRepository.Save(team);
            }

            if (categoryRepository.Get("Djurgården") != null)
            {
                var team = categoryRepository.Get("Djurgården");

                var  categories = new List<string>
                {
                    "Damer",
                    "Herrar",
                    "Juniorer"
                };

                foreach (var item in categories)
                {
                    if (categoryRepository.Get(item) == null)
                    {
                        var category = new Category(team, item)
                        {
                            Description = item
                        };

                        categoryRepository.Save(category);
                    }
                }                
            }
        }

        public void Uninitialize(InitializationEngine context)
        {            
        }
    }
}