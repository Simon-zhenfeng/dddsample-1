﻿using System;
using dddsample.domain.model.cargo.aggregate.interfaces;
using dddsample.domain.model.location.aggregate;
using dddsample.domain.model.location.aggregate.interfaces;

namespace dddsample.domain.model.cargo.aggregate
{
    public class Cargo : ICargo
    {
        readonly ITrackingId underlying_tracking_id;
        readonly IRouteSpecification underlying_route_specification;
        readonly ILocation underlying_origin_location;

        public Cargo(ITrackingId tracking_id, IRouteSpecification route_specification)
        {
            this.underlying_tracking_id = tracking_id;
            this.underlying_route_specification = route_specification;
            this.underlying_origin_location = route_specification.origin();
        }

        public bool has_the_same_identity_as(ICargo the_other_entity)
        {
            return the_other_entity != null && 
                   underlying_tracking_id.has_the_same_value_as(the_other_entity.tracking_id());
        }

        public ITrackingId tracking_id()
        {
            return this.underlying_tracking_id;
        }

        public IRouteSpecification route_specification()
        {
            return this.underlying_route_specification;
        }

        public ILocation origin_location()
        {
            return this.underlying_origin_location;
        }

        public override int GetHashCode()
        {
            return underlying_tracking_id.GetHashCode();
        }

        public override string ToString()
        {
            return underlying_tracking_id.id();
        }

        public override bool Equals(object the_to_compare_object)
        {
            return this.has_the_same_identity_as(the_to_compare_object as ICargo);
        }
    }
}