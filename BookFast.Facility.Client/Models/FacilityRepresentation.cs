// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace BookFast.Facility.Client.Models
{
    using System.Linq;

    public partial class FacilityRepresentation
    {
        /// <summary>
        /// Initializes a new instance of the FacilityRepresentation class.
        /// </summary>
        public FacilityRepresentation() { }

        /// <summary>
        /// Initializes a new instance of the FacilityRepresentation class.
        /// </summary>
        /// <param name="id">Facility ID</param>
        /// <param name="name">Facility name</param>
        /// <param name="description">Facility description</param>
        /// <param name="streetAddress">Facility street address</param>
        /// <param name="longitude">Latitude</param>
        /// <param name="latitude">Longitude</param>
        /// <param name="images">Facility images</param>
        /// <param name="accommodationCount">Number of accommodations</param>
        public FacilityRepresentation(System.Guid? id = default(System.Guid?), string name = default(string), string description = default(string), string streetAddress = default(string), double? longitude = default(double?), double? latitude = default(double?), System.Collections.Generic.IList<string> images = default(System.Collections.Generic.IList<string>), int? accommodationCount = default(int?))
        {
            Id = id;
            Name = name;
            Description = description;
            StreetAddress = streetAddress;
            Longitude = longitude;
            Latitude = latitude;
            Images = images;
            AccommodationCount = accommodationCount;
        }

        /// <summary>
        /// Gets or sets facility ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public System.Guid? Id { get; set; }

        /// <summary>
        /// Gets or sets facility name
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets facility description
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets facility street address
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "streetAddress")]
        public string StreetAddress { get; set; }

        /// <summary>
        /// Gets or sets latitude
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "longitude")]
        public double? Longitude { get; set; }

        /// <summary>
        /// Gets or sets longitude
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "latitude")]
        public double? Latitude { get; set; }

        /// <summary>
        /// Gets or sets facility images
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "images")]
        public System.Collections.Generic.IList<string> Images { get; set; }

        /// <summary>
        /// Gets or sets number of accommodations
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "accommodationCount")]
        public int? AccommodationCount { get; set; }

    }
}