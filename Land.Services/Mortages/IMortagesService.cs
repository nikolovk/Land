using System;
namespace Land.Services.Mortages
{
    public interface IMortagesService
    {
        int CreateMortage(Land.Data.Entities.Mortage Mortage);
        bool EditMortage(Land.Data.Entities.Mortage mortage);
        Land.Data.Entities.Mortage GetMortage(int id);
        System.Collections.Generic.List<Land.Data.Entities.Mortage> GetMortages();
    }
}
