using System;
using System.Threading;

namespace UIAComWrapper
{
    public class DisposableBaseWithoutFinalizer : IDisposable
    {
        private int _isDisposed; // Interlocked.CompareExchange does not support bools.

        protected DisposableBaseWithoutFinalizer()
        {
            _isDisposed = 0;
        }

        public void Dispose()
        {
            if (Interlocked.CompareExchange(ref _isDisposed, 1, 0) == 1)
                return;

            DisposeManagedResource();
        }

        protected virtual void DisposeManagedResource()
        {
        }

        protected virtual void CheckDisposed()
        {
            if (_isDisposed == 1)
                throw new ObjectDisposedException(GetType().Name);
        }
    }
}