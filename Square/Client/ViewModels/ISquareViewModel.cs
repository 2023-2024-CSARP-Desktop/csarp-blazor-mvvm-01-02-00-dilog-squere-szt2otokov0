namespace Square.Client.ViewModels
{
    public interface ISquareViewModel
    {
        public string Side {get;set;}
        public string Perimeter { get;}
        public string Area { get;}

        public void Compute();
    }
}
