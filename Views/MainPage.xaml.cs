

namespace libre
{
	public partial class MainPage : ContentPage
	{
		

		public MainPage()
		{
			InitializeComponent();
		}

		[ContentProperty("Member")]
		public class StaticExtension : IMarkupExtension
		{
			public string Member { get; set; }
			public object ProvideValue(IServiceProvider serviceProvider)
			{
				return Member;
			}
		}

	}

}
