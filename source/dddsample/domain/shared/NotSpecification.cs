namespace dddsample.domain.shared
{
    public class NotSpecification<T> : ISpecification<T> 
    {
        ISpecification<T> to_negate_specification;

        public NotSpecification(ISpecification<T> to_negate_specification)
        {
            this.to_negate_specification = to_negate_specification;
        }

        public bool is_satisfied_by(T item)
        {
            return !this.to_negate_specification.is_satisfied_by(item);
        }
    }
}