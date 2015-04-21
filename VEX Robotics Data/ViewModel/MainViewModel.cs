using GalaSoft.MvvmLight;
using RoboticsDatabase.Model;

namespace RoboticsDatabase.ViewModel
{
	/// <summary>
	/// This class contains properties that the main View can data bind to.
	/// <para>
	/// See http://www.galasoft.ch/mvvm
	/// </para>
	/// </summary>
	public class MainViewModel : ViewModelBase
	{
		private readonly IDataService _dataService;

		/// <summary>
		/// The <see cref="WelcomeTitle" /> property's name.
		/// </summary>
		public const string WelcomeTitlePropertyName = "WelcomeTitle";

		private string _welcomeTitle = string.Empty;

		/// <summary>
		/// Gets the WelcomeTitle property.
		/// Changes to that property's value raise the PropertyChanged event. 
		/// </summary>
		public string WelcomeTitle
		{
			get
			{
				return _welcomeTitle;
			}

			set
			{
				if (_welcomeTitle == value)
				{
					return;
				}

				_welcomeTitle = value;
				RaisePropertyChanged(WelcomeTitlePropertyName);
			}
		}

		/// <summary>
		/// Initializes a new instance of the MainViewModel class.
		/// </summary>
		public MainViewModel(IDataService dataService)
		{
			_dataService = dataService;
			_dataService.GetData(
				(item, error) =>
				{
					if (error != null)
					{
						// Report error here
						return;
					}

					WelcomeTitle = item.Title;
				});
		}

		public const string SearchPropertyName = "SearchProperty";
		private string _searchProperty = "";
		public string SearchProperty
		{
			get
			{
				return _searchProperty;
			}

			set
			{
				if (_searchProperty == value)
				{
					return;
				}

				_searchProperty = value;
				RaisePropertyChanged(SearchPropertyName);
			}
		}

		private RelayCommand _reloadAllCommand;

		/// <summary>
		/// Gets the ReloadAllCommand.
		/// </summary>
		public RelayCommand ReloadAllCommand
		{
			get
			{
				return _reloadAllCommand
					?? (_reloadAllCommand = new RelayCommand(
					() =>
					{
						
					}));
			}
		}

		////public override void Cleanup()
		////{
		////    // Clean up if needed

		////    base.Cleanup();
		////}
	}
}