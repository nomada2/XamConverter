﻿using Xamarin.Forms;

namespace XamConverter
{
	public class BaseContentPage<TViewModel> : ContentPage where TViewModel : BaseViewModel, new()
	{
		TViewModel _viewModel;

		public BaseContentPage()
		{
			BindingContext = ViewModel;
		}

		protected TViewModel ViewModel => _viewModel ?? (_viewModel = new TViewModel());
	}
}
