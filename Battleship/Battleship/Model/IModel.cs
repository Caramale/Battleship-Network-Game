using Battleship.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Model
{
    public delegate void ModelHandler<IModel>(IModel sender, CellEnteredEventArgs e);

    public interface IModel
    {
        void attach(IModelObserver modelObserver);
        void SetCabin(int indexRow, int indexColumn);
        void StepOfGame(int indexRow, int indexColumn);
    }
}
