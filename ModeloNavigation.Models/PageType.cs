using System;

namespace ModeloNavigation.Models
{
    public class PageType
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public ViewModelType TypePage { get; set; }
    }

    public enum ViewModelType
    {
        UmViewModel,
        DoisViewModel
    }
}
