using MernisService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCKimlikNumarasiDogrulama
{
    public class Mernis
    {
        public async static Task<bool> TcNoDogrula(long TcNo, string Ad, string Soyad, int DogumYılı)
        {
            var client = new MernisService.KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var repsonse = await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(TcNo), Ad, Soyad, DogumYılı);
            var result = repsonse.Body.TCKimlikNoDogrulaResult;
            return result;
        }
    }
}
