using Serenity.Services;
using System.Data;
using Serenity.Data;
using System.Globalization;
using System.Linq;

namespace SmartERP.Administration
{
    public interface ICompanyGetDefaultCurrencyHandler : IRequestHandler
    {
        GetDefaultCurrencyResponse GetDefaultCurrency(IDbConnection connection, GetDefaultCurrencyRequest request);
    }

    public class CompanyGetDefaultCurrencyHandler : ICompanyGetDefaultCurrencyHandler
    {
        public GetDefaultCurrencyResponse GetDefaultCurrency(IDbConnection connection, GetDefaultCurrencyRequest request)
        {
            var result = connection.Query<GetDefaultCurrencyResponse>(
                @$"
                    select cu.CurrencyName as CurrencyName 
                    from Companies co inner join Currencies cu on co.[CurrencyId] = cu.Id
                    where co.Id = {request.CompanyId}
                ", 
                null, 
                commandType: CommandType.Text
                ).FirstOrDefault();

            if (result==null || result.CurrencyName==null)
            {
                result = new GetDefaultCurrencyResponse();
                result.CurrencyName = "";
            }
            return result;
        }
    }

    public class GetDefaultCurrencyRequest : ServiceRequest
    {
        public int CompanyId { get; set; }
    }

    public class GetDefaultCurrencyResponse : ServiceResponse
    {
        public string CurrencyName { get; set; }
    }

}
