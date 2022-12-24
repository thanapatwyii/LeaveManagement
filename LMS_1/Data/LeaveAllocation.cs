namespace LMS_1.Data
{
    public class LeaveAllocation : BaseEntity
    {

        public int NumberOfDays { get; set; } /* the resulting number of days*/

        public LeaveType LeaveType { get; set; } /* parse the leave type property from the leavetype table*/
        public int LeaveTypeId { get; set; } /* foreign key to connect to leavetype table */

        public string EmployeeId { get; set; } /* foreign key to connect to employee tabel*/
    }
}
 