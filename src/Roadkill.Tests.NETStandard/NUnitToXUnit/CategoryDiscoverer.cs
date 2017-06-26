using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Roadkill.Tests.NETStandard.NUnitToXUnit
{
	public class CategoryDiscoverer : ITraitDiscoverer
	{
		internal const string DiscovererTypeName = DiscovererUtil.AssemblyName + "." + nameof(CategoryDiscoverer);

		public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
		{
			var categoryName = traitAttribute.GetNamedArgument<string>("Name");

			if (!string.IsNullOrWhiteSpace(categoryName))
				yield return new KeyValuePair<string, string>("Category", categoryName);
		}
	}
}