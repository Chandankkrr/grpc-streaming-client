//using System.Collections.Generic;
//using System.Threading.Tasks;
//using Grpc.Core;
//using ReactClient;

//namespace threemillion.Data
//{
//    public class LocationDataService
//    {
//        private readonly LocationData.LocationDataClient _client;

//        public LocationDataService(LocationData.LocationDataClient client)
//        {
//            _client = client;
//        }

//        public async Task<IEnumerable<Location>> GetAllLocationData()
//        {
//            var locations = new List<Location>();

//            using var call = _client.GetAllLocationData(new GetLocationRequest { DataLimit = 10000 });

//            await foreach (var response in call.ResponseStream.ReadAllAsync())
//            {
//                locations.Add(new Location
//                {
//                    Latitude = response.LatitudeE7,
//                    Longitude = response.LongitudeE7
//                });
//            }

//            return locations;
//        }
//    }
//}
