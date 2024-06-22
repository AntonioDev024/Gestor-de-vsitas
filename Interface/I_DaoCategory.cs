

using GestorVisitas.Data.Entities;

namespace GestorVisitas.Data.Interface
{
    public interface I_DaoCategory
    {
       public List<Category> GetCategories();

        Category GetCategory(int id);
        void RemoveCategory(Category category);
        void UpdateCategory(Category category);
        void SaveCAtegory (Category category);
    }
}
