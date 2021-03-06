using Microsoft.EntityFrameworkCore;
using Formation.CQRS.Service.Entity;
using System.Collections.Generic;

namespace Formation.CQRS.Service.AccesLayer
{
    public interface IGeoLocalisationContext
    {
        DbSet<GeoLocalisationEntity> GeoLocalisation { get; set; }
        int SaveChanges();

        IEnumerable<string> GetAllDevicesGuid();
        IEnumerable<GeoLocalisationEntity> GetDeviceGeoLocalisation(string guid);
    }
}