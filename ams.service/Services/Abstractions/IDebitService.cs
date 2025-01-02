namespace ams.service.Services.Abstractions
{
    using ams.core.Units;
    using ams.entity.DTOs;

    public interface IDebitService
    {
        Task<Result.ListResult<DebitDTO.Table>> GetDebitUnpaids(Guid housing_id);
        Task<Result.ListResult<DebitDTO.Table>> GetDebits(Guid apartment_id, int month, int year);
        Task<Result.ViewResult> DebitAddAsync(Guid apartment_id, Guid create_user, int month, int year);
        Task<Result.ViewResult> DebitPay(DebitDTO.Pay pay);
        Task<Result.ViewResult> DebitPays(DebitDTO.Pays pays);
    }
}
