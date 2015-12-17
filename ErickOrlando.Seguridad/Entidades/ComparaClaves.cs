using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Csla.Core;
using Csla.Rules;

namespace ErickOrlando.Seguridad.Entidades
{
	internal class ComparaClaves : BusinessRule
	{

		internal ComparaClaves(IPropertyInfo prop, IPropertyInfo prop2)
			:base(prop)
		{
			InputProperties = new List<IPropertyInfo> { prop, prop2 };
			SecondaryProperty = prop2;
		}

		private IPropertyInfo SecondaryProperty { get; set; }

		protected override void Execute(RuleContext context)
		{
			var primero = (string)context.InputPropertyValues[PrimaryProperty];
			var segundo = (string)context.InputPropertyValues[SecondaryProperty];

			if (primero != segundo)
				context.AddErrorResult("Las contraseñas no son iguales! Verifique por favor");
		}
	}
}
