namespace SynchronizationPlayground.Synchronization;

internal class AlternativeSpinWaiter
{
    private volatile bool _isBusy = false;

    public void Acquire()
    {
        SpinWait.SpinUntil(() => !_isBusy);

        _isBusy = true;
    }

    public void Release()
    {
        _isBusy = false;
    }
}
