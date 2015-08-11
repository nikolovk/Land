using System;
namespace Land.Services.LandProperties
{
    public interface ILandPropertiesService
    {
        string CreateLandProperty(Land.Data.Entities.LandProperty landProperty);
        bool EditLandProperty(Land.Data.Entities.LandProperty landProperty);
        System.Collections.Generic.List<Land.Data.Entities.LandProperty> GetLandProperties();
        Land.Data.Entities.LandProperty GetLandProperty(string id);
    }
}
