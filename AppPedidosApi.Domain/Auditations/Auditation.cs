namespace AppPedidosApi.Domain.Auditations
{
    public class Auditation
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public AuditationUserData AuditInsert { get; private set; } = new AuditationUserData();
        public List<AuditationUserData> AuditEditList { get; private set; } = new List<AuditationUserData>();


        public Auditation()
        {
            AuditInsert.UserId = Id;
            AuditInsert.Moment = DateTime.Now;
            AuditInsert.AuditationId = Id;
            AuditEditList.Add(AuditInsert);
        }

        public AuditationUserData GetInsertData()
        {
            return AuditInsert;
        }

        public List<AuditationUserData> GetEditData()
        {
            return AuditEditList;
        }

        public void AddEditData(Guid userId)
        {
            AuditationUserData data = new();
            data.UserId = userId;
            data.Moment = DateTime.Now;
            data.AuditationId=Id;
            AuditEditList.Add(data);
        }
    }
}
