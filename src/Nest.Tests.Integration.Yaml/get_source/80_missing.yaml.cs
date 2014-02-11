using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;
using NUnit.Framework;
using Nest.Tests.Integration.Yaml;


namespace Nest.Tests.Integration.Yaml.GetSource
{
	public partial class GetSourceTests
	{	


		public class MissingDocumentWithCatchTests : YamlTestsBase
		{
			[Test]
			public void MissingDocumentWithCatchTest()
			{	

				//do get_source 
				this.Do(()=> this._client.GetSource("test_1", "test", "1"));

			}
		}

		public class MissingDocumentWithIgnoreTests : YamlTestsBase
		{
			[Test]
			public void MissingDocumentWithIgnoreTest()
			{	

				//do get_source 
				this.Do(()=> this._client.GetSource("test_1", "test", "1", nv=>nv
					.Add("ignore", 404)
				));

			}
		}
	}
}

