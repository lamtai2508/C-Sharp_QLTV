namespace qltv.DTO
{
    public class StatisticsMemberVisitDTO
    {
        public DateTime VisitDate { get; set; }
        public string Status { get; set; }
        public int MemberCount { get; set; }
    }

    public class StatisticsDeviceBorrowingDTO
    {
        public DateTime BorrowedDate { get; set; }
        public string DeviceName { get; set; }
        public int BorrowCount { get; set; }
    }

    public class StatisticsBorrowedDeviceDTO
    {
        public DateTime BorrowedDate { get; set; }
        public string DeviceName { get; set; }
        public string MemberId { get; set; }
        public string Status { get; set; }
    }

    public class StatisticsViolationDTO
    {
        public string ViolationId { get; set; }
        public string MemberId { get; set; }
        public DateTime ViolationDate { get; set; }
        public string Status { get; set; }
        public double CompensationAmount { get; set; }
    }
}