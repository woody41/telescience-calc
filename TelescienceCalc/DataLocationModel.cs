using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelescienceCalc
{
    public class DataLocationModel :IListSource
    {

        private BindingList<Location> _data = new BindingList<Location>();

        public bool ContainsListCollection
        {
            get { throw new NotImplementedException(); }
        }

        public System.Collections.IList GetList()
        {
            return this._data;
        }
        public void DeleteLocation(int index)
        {
            try
            {
                this._data.RemoveAt(index);
            }
            catch
            {
                new MessageError().ShowDialog();
            }
        }
        public void AddLocation(Location loc)
        {
            this._data.Add(loc);
        }
        public Location GetLocation(int index)
        {
            return this._data[index];
        }
        public void DeleteAllLocations()
        {
            this._data.Clear();
        }
    }
}
