using Battleship.Model;
using Battleship.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Controller
{
    public class FieldController : IController
    {
        IView _view;
        IModel _model;

        public FieldController(IView v, IModel m)
        {
            if (v == null)
                throw new ArgumentNullException(nameof(v));
            if (m == null)
                throw new ArgumentNullException(nameof(m));

            _view = v;
            _model = m;
            _view.setController(this);
            _model.attach((IModelObserver)_view);
            _view.CabinChanged += new ViewCabinHandler<IView>(this.CabinChanged);
        }

        public void CabinChanged(IView v, CellEnteredEventArgs e)
        {

        }
    }
}
