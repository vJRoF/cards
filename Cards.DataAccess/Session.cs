using System;

namespace Cards.DataAccess
{
    public class Session
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTimeOffset Created { get; set; }

        public DateTimeOffset Modified { get; set; }
    }
}
