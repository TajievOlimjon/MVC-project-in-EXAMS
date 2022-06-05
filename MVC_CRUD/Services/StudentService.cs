using MVC_CRUD.Data;
using MVC_CRUD.Data.Entities;

namespace MVC_CRUD.Services
{
    public class StudentService
    {
        private readonly DataContext dataContext;

        public StudentService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public List<Student> GetStudents()
        {
            var list = dataContext.Students.ToList();
            return list;
        }

        public Student GetStudentById(int Id)
        {
            var list = dataContext.Students.Find(Id);
            if (list == null) return new Student();
            else
            return list;
        }

        public int Create(Student student)
        {
            dataContext.Students.Add(student);
            return dataContext.SaveChanges();
        }

        public int Update(Student student)
        {
            var st = dataContext.Students.Find(student.Id);
            if (st == null) return 0;           
            st.FirstName = student.FirstName;
            st.LastName = student.LastName;
            st.Age = student.Age;
            st.Email = student.Email;
            return dataContext.SaveChanges();

        }

        public int Delete(int Id)
        {
            var student = dataContext.Students.Find(Id);
            if(student==null)return 0;
            dataContext.Students.Remove(student);
            return dataContext.SaveChanges();
        }
    }
}
