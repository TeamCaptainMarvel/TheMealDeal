namespace TheMealDeal.Extensions
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public static class EnumerableExtensions
    {
        public static void AddRange<T>(this ObservableCollection<T> collection, IEnumerable<T> items)
        {
            foreach(var item in items)
            {
                collection.Add(item);
            }
        }
    }
}
