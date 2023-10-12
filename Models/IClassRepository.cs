namespace D_D_Class_Selector.Models
{
    public interface IClassRepository
    {
        public IEnumerable<Classes> GetAllClasses();
    }
}
