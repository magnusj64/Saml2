﻿using System;
using Microsoft.IdentityModel.Xml;

namespace Sustainsys.Saml2.Metadata
{
	public class EncryptedData
	{
		public string Id { get; set; }
		public Uri Type { get; set; }
		public string MimeType { get; set; }
		public Uri Encoding { get; set; }
		public EncryptionMethod EncryptionMethod { get; set; }
		public DSigKeyInfo KeyInfo { get; set; }
		public CipherData CipherData { get; set; }
		public EncryptionProperties EncryptionProperties { get; set; }
	}
}
