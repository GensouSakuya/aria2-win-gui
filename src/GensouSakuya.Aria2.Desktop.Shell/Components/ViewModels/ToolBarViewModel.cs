﻿using System.Collections.ObjectModel;
using GensouSakuya.Aria2.Desktop.Resource;
using GensouSakuya.Aria2.Desktop.Shell.Controls.ViewModels;
using GensouSakuya.Aria2.Desktop.Shell.Helper;
using GensouSakuya.Aria2.Desktop.Shell.ViewModels;
using GensouSakuya.Aria2.Desktop.Shell.Views;

namespace GensouSakuya.Aria2.Desktop.Shell.Components.ViewModels
{
    public class ToolBarViewModel: ViewModelBase
    {
        public ToolBarViewModel()
        {
            Buttons = new ObservableCollection<ToolButtonViewModel>();
            Buttons.Add(new ToolButtonViewModel
            {
                Img = BitmapHelper.GetImg(Icons.Download),
                Click = () =>
                {
                    var page = new CreateDownloadTaskPage();
                    page.DataContext = new CreateDownloadTaskPageViewModel()
                    {
                        Self = page
                    };
                    DialogHelper.ShowDialog(page);
                }
            });
        }

        public ObservableCollection<ToolButtonViewModel> Buttons { get; set; }
    }
}
