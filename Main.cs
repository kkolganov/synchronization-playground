using SynchronizationPlayground.Playground;

namespace SynchronizationPlayground
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnUnsynchronized_Click(object sender, EventArgs e)
        {
            _ = UnsynchronizedThreads.Run();
        }

        private void btnLockSynchronized_Click(object sender, EventArgs e)
        {
            _ = LockSynchronizedThreads.Run();
        }

        private void btnUnsyncWorkBlock_Click(object sender, EventArgs e)
        {
            _ = UnsynchronizedWorkBlock.Run();
        }

        private void btnLockSyncWorkBlock_Click(object sender, EventArgs e)
        {
            _ = LockSynchronizedWorkBlock.Run();
        }

        private void btnSemaphoredWorkBlock_Click(object sender, EventArgs e)
        {
            _ = SemaphoreSynchronizedWorkBlock.Run();
        }

        private void btnSpinnerSyncBlock_Click(object sender, EventArgs e)
        {
            _ = SpinningWorkBlock.Run();
        }

        private void btnSpinWaitWorkBlock_Click(object sender, EventArgs e)
        {
            _ = SpinWaitingWorkBlock.Run();
        }

        private void btnPulseWaitSync_Click(object sender, EventArgs e)
        {
            _ = PulseWaitWorkBlock.Run();
        }

        private void btnResetEventsyncWorkBlock_Click(object sender, EventArgs e)
        {
            _ = ManualResetEventWorkerBlock.Run();
        }

        private void btnAutoResetEventWorkBlock_Click(object sender, EventArgs e)
        {
            _ = AutoResetEventWorkBlock.Run();
        }

        private void btnBarrierSyncWorkBlock_Click(object sender, EventArgs e)
        {
            _ = BarrierWorkBlock.Run();
        }

        private void btnReadWriteSync_Click(object sender, EventArgs e)
        {
            _ = ReadWriteSynchronization.Run();
        }

        private void btnUnsyncReadWrite_Click(object sender, EventArgs e)
        {
            _ = UnsynchronizedReadWrite.Run();
        }

        private void btnAsyncAwaitSequential_Click(object sender, EventArgs e)
        {
            _ = AsyncAwaitBreakfast.RunSequential();
        }

        private void btnAsyncAwaitBreakfastParallel_Click(object sender, EventArgs e)
        {
            _ = AsyncAwaitBreakfast.RunParallel();
        }

        private void btnInterlockedExample_Click(object sender, EventArgs e)
        {
            _ = InterlockedCounter.Run();
        }
    }
}
