namespace Ordering.Domain.Abstractions
{
    public abstract class Entity<T> : IEntity<T>
    {
        public T Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? LastTimeModiied { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? LastModifiedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
