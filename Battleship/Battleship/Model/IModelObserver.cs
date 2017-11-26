using Battleship.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Model
{
    public interface IModelObserver
    {
        void AddCabin(IModel model, CellEnteredEventArgs e);
    }
}
