using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Core.Utilities.Commands.Implementatinos
{
    public class ErrorItemCollection : ICollection<ErrorItem>
    {
        #region ICollection<ErrorItem>
        private List<ErrorItem> errorItems = new List<ErrorItem>();

        public int Count => errorItems?.Count ?? 0;

        public bool IsReadOnly => true;

        public void Add(ErrorItem item)
        {
            errorItems.Add(item);
        }

        public void Clear()
        {
            errorItems.Clear();
        }

        public bool Contains(ErrorItem item)
        {
            return errorItems.Contains(item);
        }

        public void CopyTo(ErrorItem[] array, int arrayIndex)
        {
            errorItems.CopyTo(array, arrayIndex);
        }

        public IEnumerator<ErrorItem> GetEnumerator()
        {
            return errorItems.GetEnumerator();
        }

        public bool Remove(ErrorItem item)
        {
            return errorItems.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return errorItems.GetEnumerator();
        }

        #endregion

        #region helpers
        public static ErrorItemCollection Create(params string[] errors)
        {
            if (errors == null) return null;
            
            var collection = new ErrorItemCollection();
            
            foreach (var error in errors)
            {
                collection.Add(ErrorItem.Create(error));
            }

            return collection;
        }
        #endregion
    }
}
