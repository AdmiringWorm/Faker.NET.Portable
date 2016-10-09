﻿using NUnit.Framework;

namespace Faker.Tests.en_US
{
	[SetUICulture("en-US")]
	[SetCulture("en-US")]
	[Category("Culture 'en_US'")]
	public class AppAmericanTests
	{
		[Test]
		[Repeat(1000)]
		public virtual void Should_Generate_Author()
		{
			string firstNameFormat = Resources.Name.First.ToFormat();
			string lastNameFormat = Resources.Name.Last.ToFormat();
			string prefixNameFormat = Resources.Name.Prefix.ToFormat();
			string suffixNameFormat = Resources.Name.Suffix.ToFormat();
			string suffixCompanyFormat = Resources.Company.Suffix.ToFormat();

			string author = App.Author();

			author.AssertFormats(firstNameFormat.Combine(lastNameFormat),
								 prefixNameFormat.Combine(firstNameFormat, lastNameFormat),
								 firstNameFormat.Combine(lastNameFormat, suffixNameFormat),
								 prefixNameFormat.Combine(firstNameFormat, lastNameFormat, suffixNameFormat),
								 lastNameFormat.Combine(suffixCompanyFormat),
								 lastNameFormat + "-" + lastNameFormat,
								 (lastNameFormat + ",").Combine(lastNameFormat, "and", lastNameFormat));
		}
	}
}
