using GamerApp.Absstract;
using GamerApp.GamerApp;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;
using System.Net;

namespace GamerApp.Adapters
{
    public class MernisServiceAdapter : IGamerCheckServis
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);

            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalityId), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirth.Year);
            return result.Result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
