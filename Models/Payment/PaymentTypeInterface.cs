namespace sharecare_backend.Models.Payment
{
    public interface PaymentTypeInterface
    {
        public int Id { get; }
        public PaymentTypeEnum Type { get; }
    }
}
