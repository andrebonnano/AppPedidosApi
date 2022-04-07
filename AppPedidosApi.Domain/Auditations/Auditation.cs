﻿namespace AppPedidosApi.Domain.Auditations
{
    public class Auditation
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public AuditationUserData Insert { get; private set; } = new AuditationUserData();
        public List<AuditationUserData> Edit { get; private set; } = new List<AuditationUserData>();


        public Auditation()
        {
            Insert.UserId = Id;
            Insert.Moment = DateTime.Now;
            Insert.AuditationId = Id;
            Edit.Add(Insert);
        }

        public AuditationUserData GetInsertData()
        {
            return Insert;
        }

        public List<AuditationUserData> GetEditData()
        {
            return Edit;
        }

        public void AddEditData(Guid userId)
        {
            AuditationUserData data = new();
            data.UserId = userId;
            data.Moment = DateTime.Now;
            data.AuditationId=Id;
            Edit.Add(data);
        }
    }
}
