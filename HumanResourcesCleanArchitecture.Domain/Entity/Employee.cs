using System;
using HumanResourcesCleanArchitecture.Domain.Enum;

namespace HumanResourcesCleanArchitecture.Domain.Entity
{
	public class EmptyClass
	{
		public EmptyClass()
		{
		}

		public string Name { get; set; } = string.Empty;

		public TypeEmployeeEnum TypeEmployeeEnum { get; set; }

		public IdentificationTypeEnum IdentificationTypeEnum { get; set; }

        public string ContentIdentification { get; set; } = string.Empty;

    }
}

