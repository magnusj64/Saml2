﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Sustainsys.Saml2.Metadata
{
    public class ContactPerson
    {
		public string Company { get; set; }
		public ICollection<string> EmailAddresses { get; private set; } =
			new Collection<string>();
		public string GivenName { get; set; }
		public string Surname { get; set; }
		public ICollection<string> TelephoneNumbers { get; private set; } =
			new Collection<string>();
		public ContactType Type { get; set; }

		public ContactPerson()
		{
		}

		public ContactPerson(ContactType type)
		{
			Type = type;
		}
    }
}
