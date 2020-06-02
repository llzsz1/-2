using System;

namespace WMS_Entity
{
    public partial class Dept
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public bool IsOK { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
