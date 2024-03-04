namespace Builder.HouseBuilder;

// Concrete builder class for Eco-Friendly Houses
public class EcoFriendlyHouseBuilder : IHouseBuilder
{
    private readonly House _house = new ();

    public void BuildBedrooms(int bedrooms) {
        _house.Bedrooms = bedrooms;
    }

    public void BuildGarage(bool hasGarage) {
        _house.HasGarage = hasGarage;
    }
    
    public void BuildAmenities(List<string> amenities) {
        // Eco-friendly houses have additional green amenities
        amenities.Add("Solar panels");
        amenities.Add("Rainwater harvesting system");
        _house.Amenities = amenities;
    }

    public House GetHouse() {
        return _house;
    }
}