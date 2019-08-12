const carMakers = ['ford', 'toyota', 'tesla'];
const carMakers2: string[] = [];
const dates = [new Date(), new Date()];

const carsByMake = [
  ['f150'],
  ['corolla'],
  ['model 3']
];
const carsByMake2: string[][] = [];

// Help with inference when extracting values
const car2 = carMakers[0];
const myCar = carMakers.pop();

// Prevent incompatible values
// carMakers.push(100); // Gives error

// Help with 'map'
carMakers.map ((car: string): string => {
  return car.toUpperCase();
});

// Flexible types 
const importantDates: (Date | string)[] = [];
importantDates.push('2030-10-10');
importantDates.push(new Date());