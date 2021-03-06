﻿using dddsample.domain.model.location.aggregate;
using dddsample.domain.model.location.aggregate.interfaces;
using dddsample.domain.model.voyage.aggregate;
using dddsample.domain.model.voyage.aggregate.interfaces;
using dddsample.domain.shared;

namespace dddsample.domain.model.handling.aggregate.interfaces
{
    public interface IHandlingEvent : IDomainEvent<IHandlingEvent>
    {
        ILocation location();
        IVoyage voyage();
        IHandlingEventType type();
    }
}