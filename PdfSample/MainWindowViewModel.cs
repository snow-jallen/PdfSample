using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace PdfSample
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            Title = DateTime.Now.ToString();
        }

        public string Title { get; private set; }
    }
}
