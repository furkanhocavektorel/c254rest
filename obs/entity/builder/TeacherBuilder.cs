namespace obs.entity.builder
{
    public class TeacherBuilder
    {
        private long AuthId;
        private string Name;
        private string Surname;
        private DateOnly? BirthDate;
        private DateOnly? StartDate;
        private string? Sınıf;
    
        public TeacherBuilder authId(long authId)
        {
            this.AuthId = authId;
            return this;
        }

        public TeacherBuilder name(string name)
        {
            this.Name = name;
            return this;
        }
        public TeacherBuilder surname(string Surname)
        {
            this.Surname = Surname;
            return this;
        }
        public TeacherBuilder birthDate(DateOnly birthDate)
        {
            this.BirthDate = birthDate;
            return this;
        }
        public TeacherBuilder startDate(DateOnly startDate)
        {
            this.StartDate = startDate;
            return this;
        }
        public TeacherBuilder sınıf(string sınıf)
        {
            this.Sınıf = sınıf;
            return this;
        }

        public Teacher build()
        {
            Teacher t = new Teacher();
            t.AuthId = this.AuthId;
            t.Name = this.Name;
            t.StartDate = this.StartDate;
            t.Sınıf = this.Sınıf;
            t.BirthDate = this.BirthDate;
            t.Surname= this.Surname;
            return t;
        }

    }
}
