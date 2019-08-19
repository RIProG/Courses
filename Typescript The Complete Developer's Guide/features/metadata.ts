import 'reflect-metadata';

const plane = {
  color: 'red'
};

// Metadata lets us attach little pieces of information to an object
// Reflect.defineMetadata('note', 'hi there', plane);
// Reflect.defineMetadata('height', '30', plane);

// const note = Reflect.getMetadata('note', plane);
// const height = Reflect.getMetadata('height', plane);

// console.log(note);
// console.log(height);

Reflect.defineMetadata('note', 'hi there', plane, 'color');

const note = Reflect.getMetadata('note', plane, 'color');

console.log(note);