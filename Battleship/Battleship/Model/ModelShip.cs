using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Model
{
    class ModelShip 
    {
        private List<ModelCabin> _cabins = new List<ModelCabin>();
        private bool _isSunk;

        public List<ModelCabin> Cabins
        {
            get { return _cabins; }
            set
            {
                if (value == null)
                    return;

                _cabins = value;
            }
        }
        public bool IsSunk
        {
            get { return _isSunk; }
            set { _isSunk = value; }
        }

        public ModelShip(int n)
        {
            for (int i = 0; i < n; i++)
                Cabins.Add(new ModelCabin());
            IsSunk = false;
        }

        public void IsSunkAll()
        {
            foreach (ModelCabin cabin in Cabins)
                if (cabin.IsAlive) IsSunk = false;

            IsSunk = true;
        }
    }
}
