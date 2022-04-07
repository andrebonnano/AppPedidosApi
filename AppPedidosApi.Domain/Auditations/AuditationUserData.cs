namespace AppPedidosApi.Domain.Auditations
{
    public class AuditationUserData
    {
        public Guid Id { get; set; } = new Guid();
        public Guid AuditationId { get; set; }
        public Guid UserId { get;  set; }
        public DateTime Moment { get;  set; }

        public AuditationUserData()
        {
        }

        public AuditationUserData(Guid userId, DateTime moment, Guid auditationId)
        {
            UserId = userId;
            Moment = moment;
            AuditationId = auditationId;
        }
    }
}
