namespace Builder.HouseBuilder;

// Concrete builder class for Luxury Houses
public class LuxuryHouseBuilder : IHouseBuilder
{
    private readonly House _house = new ();

    public void BuildBedrooms(int bedrooms) {
        _house.Bedrooms = bedrooms;
    }

    public void BuildGarage(bool hasGarage) {
        _house.HasGarage = hasGarage;
    }

    public void BuildAmenities(List<string> amenities) {
        _house.Amenities = amenities;
    }

    public House GetHouse() {
        return _house;
    }
}