namespace ChainOfResponsibility
{
    using System;

    public abstract class IHandler
    {
        protected IHandler Successor { get; private set; }

        public void SetSuccessor(IHandler successor)
        {
            this.Successor = successor;
        }

        public abstract void HandleRequest(int request);
    }
}
