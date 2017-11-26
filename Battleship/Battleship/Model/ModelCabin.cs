
using System;

namespace Battleship.Model
{
    class ModelCabin : IModel
    {
        public event ModelHandler<ModelCabin> Changed;

        private bool _isAlive = true;
        private int _rowIndex;
        private int _columnIndex;

        public bool IsAlive
        {
            get { return _isAlive; }
            set { _isAlive = value; }
        }

        public void attach(IModelObserver modelObserver)
        {
            Changed += new ModelHandler<ModelCabin>(modelObserver.AddCabin);
        }

        public void SetCabin(int indexRow, int indexColumn)
        {
            Changed.Invoke(this, new View.CellEnteredEventArgs(_isAlive, _rowIndex, _columnIndex));
        }

        public void StepOfGame(int indexRow, int indexColumn)
        {
            throw new NotImplementedException();
        }
    }
}
