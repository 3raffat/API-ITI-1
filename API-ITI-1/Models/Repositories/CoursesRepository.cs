
using API_ITI_1.Data;

namespace API_ITI_1.Models.Repositories
{
    public class CoursesRepository : IRepository<Courses>
    {
        public AppDbContext Db { get; }

        public CoursesRepository(AppDbContext db)
        {
            Db = db;
        }


        public void Add(Courses entity)
        {
            Db.Courses.Add(entity);
            Db.SaveChanges();
        }

        public void Delete(int Id, Courses entity)
        {
           entity= FindById(Id);
            if (entity != null)
            {
                Db.Courses.Remove(entity);
                Db.SaveChanges();
            }
            else
            {
                throw new Exception("Course not found");
            }
        }

        public Courses FindById(int Id)
        {
            return Db.Courses.SingleOrDefault(x => x.Id == Id);
        }

        public Courses FindByName(string Name)
        {
            return Db.Courses.SingleOrDefault(x => x.Crs_Name == Name);
        }


        public void Update(int Id, Courses entity)
        {
            Db.Courses.Update(entity);
            Db.SaveChanges();
        }

        public List<Courses> View()
        {
           return Db.Courses.ToList();
        }

       
    }
}
