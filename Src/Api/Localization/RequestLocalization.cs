using System.Globalization;

namespace Api.Localization;

public class RequestLocalization
{
	private CultureInfo[] _supportCulture { get; set; }

	public RequestLocalization()
	{
		_supportCulture =
		[
			new CultureInfo("pt-BR")
		];
	}

	public RequestLocalizationOptions Execute()
	{
		return new RequestLocalizationOptions()
		{
			DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("pt-BR"),
			SupportedCultures = _supportCulture,
			SupportedUICultures = _supportCulture
		};
	}
}
