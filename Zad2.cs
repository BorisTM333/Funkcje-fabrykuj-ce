function createCar(brand, model, year, mileage) {
  return {
    brand,
    model,
    year,
    mileage,

    displayInfo() {
      console.log(`${this.brand} ${this.model} (${this.year}) – ${this.mileage} km`);
    },

    drive(distance) {
      console.log(`Przejechano ${distance} km`);
    }
  };
}

const car1 = createCar('BMW', 'E46', 2003, 245000);
const car2 = createCar('Audi', 'A4 B8', 2011, 198000);
const car3 = createCar('Volkswagen', 'Golf 7', 2016, 152000);

car1.displayInfo();
car1.drive(120);

car2.displayInfo();
car2.drive(60);

car3.displayInfo();
car3.drive(200);
