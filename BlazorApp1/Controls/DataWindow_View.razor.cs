using SnapObjects.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Controls
{
    public partial class DataWindow_View<TItem, TViewModel>
        where TItem:new()
        where TViewModel:DataWindow_ViewModel<TItem>,new()
    {
    }

    public class DataWindow_ViewModel<TItem> where TItem : new()
    {
        public TItem Model { get; set; } = new TItem();
        public int Index { get; set; } = -1;
        public ModelState Status { get; set; } = ModelState.NotModified;
    }
}
