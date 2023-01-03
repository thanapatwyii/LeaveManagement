using LMS_1.Contracts;
using LMS_1.Data;

namespace LMS_1.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        { }
    }
}
