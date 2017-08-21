
using System;
using System.Globalization;

namespace ResxI18N.Helpers
{
	public interface ILocalize
	{
		CultureInfo GetCurrentCultureInfo();
		void SetLocale(CultureInfo ci);
	}
}
