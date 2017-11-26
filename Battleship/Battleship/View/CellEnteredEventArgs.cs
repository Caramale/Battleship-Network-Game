using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.View
{
    public class CellEnteredEventArgs : EventArgs
    {
        public bool _isActive;
        public int _indexRow;
        public int _indexColumn;

        public CellEnteredEventArgs(bool isActive, int indexRow, int indexColumn)
        {
            _isActive = isActive;
            _indexRow = indexRow;
            _indexColumn = indexColumn;
        }
    }
}
