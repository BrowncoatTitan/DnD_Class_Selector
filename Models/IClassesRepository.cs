namespace D_D_Class_Selector.Models
{
    public interface IClassesRepository
    {
        public IEnumerable<Classes> GetAllClasses();
        public IEnumerable<Classes> GetClasses(int id);
    }
}
