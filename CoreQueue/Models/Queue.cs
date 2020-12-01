namespace BL.Atlas.Infrastructure.CoreQueue.Models
{
  public static class QueueNames
    {
        public const string SendEmail = "SendEmail";

        public const string SAP_ECC_FI = "Integration-SAP-ECC-FI";

        public const string SAP_ECC_FI_Reverse = "Integration-SAP-ECC-FI-Reverse";

        public const string SAP_ECC_FI_Reverse_DeadLetter = "Integration-SAP-ECC-FI-Reverse.DeadLetter";

        public const string MDMSend = "Integration-MDMSend";

        public const string MDMSendDone = "Integration-MDMSendDone";

        public const string MDMReceive = "Integration-MDMReceive";

        public const string MDMReceiveDone = "Integration-MDMReceiveDone";

        public const string CASS = "Integration-CASS";

        public const string TraxonSendToMawb = "Integration-TraxonSendToMawb";

        public const string TraxonSendToHawb = "Integration-TraxonSendToHawb";

        public const string TraxonStatusMessage = "Integration-TraxonStatusMessage";

        public const string IntegrationSAPCustomSI = "Integration-SAP-Custom-SI";
        public const string IntegrationSAPCustomSIReturn = "Integration-SAP-Custom-SI-Return";
        public const string IntegrationSAPCustomSIReturnDeadLetter = "Integration-SAP-Custom-SI-Return.DeadLetter";
        public const string IntegrationSAPCustomSIReturnDeadLetterError = "Integration-SAP-Custom-SI-Return.DeadLetter.Error";

        public const string CrmIntegration = "Integration-CRM";
    }
}
