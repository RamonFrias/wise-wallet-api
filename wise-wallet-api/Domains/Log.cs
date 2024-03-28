using wise_wallet_api.Domains.Enums;

namespace wise_wallet_api.Domains
{
    public class Log
    {
        public int LogId { get; set; }
        public DateTime LogDateTime { get; set; }
        public EStatus LogStatus { get; set; }
        public string LogAction { get; set; }

        public Log(int logId, DateTime logDateTime, EStatus logStatus, string logAction)
        {
            LogId = logId;
            LogDateTime = logDateTime;
            LogStatus = logStatus;
            LogAction = logAction;
        }
    }
}
