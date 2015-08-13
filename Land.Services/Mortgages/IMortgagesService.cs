using System;
namespace Land.Services.Mortgages
{
    public interface IMortgagesService
    {
        string CreateMortgage(Land.Data.Entities.Mortgage mortgage);
        bool EditMortgage(Land.Data.Entities.Mortgage mortgage);
        Land.Data.Entities.Mortgage GetMortgage(int id);
        System.Collections.Generic.List<Land.Data.Entities.Mortgage> GetMortgages();
    }
}
