namespace Battleship.View
{
    public delegate void ViewCabinHandler<IView>(IView sender, CellEnteredEventArgs e);

    public interface IView
    {
        event ViewCabinHandler<IView> CabinChanged;
        void setController(Controller.IController controller);
    }
}
