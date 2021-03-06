﻿using Atomiv.Core.Domain;

namespace Atomiv.Template.Core.Domain.Customers
{
    public class CustomerEditedEvent : Event<CustomerIdentity>
    {
        public CustomerEditedEvent(CustomerIdentity id,
            CustomerReferenceNumber referenceNumber,
            string firstName,
            string lastName)
            : base(id)
        {
            ReferenceNumber = referenceNumber;
            FirstName = firstName;
            LastName = lastName;
        }

        public CustomerReferenceNumber ReferenceNumber { get; }

        public string FirstName { get; }

        public string LastName { get; }
    }
}
