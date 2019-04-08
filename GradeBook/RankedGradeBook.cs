using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RakedGradeBook : BaseGradeBook
    {
        public RakedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }
    }
}
