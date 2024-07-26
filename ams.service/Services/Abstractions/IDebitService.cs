namespace ams.service.Services.Abstractions
{
    using ams.core.Units;

    public interface IDebitService
    {
        Task<Result.ViewResult> DebitAddAsync(Guid apartment_id, Guid create_user, int month, int year);
    }
}
