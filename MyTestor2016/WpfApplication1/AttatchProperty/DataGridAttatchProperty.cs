using Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MyProperty 
{
    public sealed class DataGridAttatchProperty:DependencyObject
    {
        public static PersonViewModel GeSelectingItem(DependencyObject obj)
        {
            return (PersonViewModel)obj.GetValue(SelectingItemAttatchedProperty);
        }

        public static void SetSelectingItem(DependencyObject obj, PersonViewModel value)
        {
            obj.SetValue(SelectingItemAttatchedProperty, value);
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectingItemAttatchedProperty =
            DependencyProperty.RegisterAttached("SelectingItem", typeof(PersonViewModel),
            typeof(DataGridAttatchProperty), new PropertyMetadata(null, OnSelectedItemChaning));

        private static void OnSelectedItemChaning(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var grid = d as DataGrid;

            if (grid != null && grid.SelectedItem!=null)
            {
                grid.UpdateLayout();
                grid.ScrollIntoView(grid.SelectedItem, null);
            }

            //var value= DataGridAttatchProperty.GeSelectingItem(grid);//useful code
            //if (value == null)
            //{
            //}
             
            
        }




    }
}
