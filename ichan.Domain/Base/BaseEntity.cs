﻿namespace ichan.Domain.Base
{
    public abstract class BaseEntity<TID> : IBaseEntity
    {
        protected BaseEntity() { }

        protected BaseEntity(TID id)
        {
            Id = id;
        }

        public TID? Id { get; set; }
    }
}
