
namespace Balta.ContentContext
{
    public class Base
    {
        // tudo que é comum nas outras classes ficam aqui dentro

        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
        public string? Title { get; private set; }
        public string? Url { get; private set; }

    }
}