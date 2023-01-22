using Balta.NotificationContext;

namespace Balta.SharedContext
{
    public abstract class Base: Notifiable
    {
        protected Base()
        {
            Id = Guid.NewGuid();
        }

        //Guid = global unique identifier.
        public Guid Id { get; private set; }
    }
}