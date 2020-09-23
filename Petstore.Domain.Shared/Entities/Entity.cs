using System;

namespace Petstore.Domain.Shared.Entities
{
    public abstract class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
            CreateDateTime = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public DateTime CreateDateTime { get; private set; }
    }
}