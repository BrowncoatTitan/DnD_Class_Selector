namespace D_D_Class_Selector.Models
{
    public interface IClassesRepository
    {
        public IEnumerable<Classes> GetAllClasses();
        public Classes GetClass(int id);
        public void UpdateClass (Classes classes);
        public void InsertClass(Classes classToInsert);
    }
}
