const drink = {
  color: 'brown',
  carbonated: true,
  sugar: 40
};

// Type alias
type Drink = [string, boolean, number];

const pepsi: [string, boolean, number] = ['brown', true, 40];
const fanta: Drink = ['yellow', true, 40];
const coffee: Drink = ['black', false, 0];

const carSpecs: [number, number] = [400, 3354]; // Hard to understand values as tuple

const carStats = {
  horsepower: 400, // Easier to understand values here, as an object
  weight: 3354
};