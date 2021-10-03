namespace Course3.presentation.observer
{
    public interface IObservable<T>
    {

        void RegisterObserver(IObserver<T> e);
        void UnregisterObserver();
    }
}