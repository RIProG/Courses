import { User } from './models/User';

const user = new User({ name: 'Bill', age: 20 });

user.set({ name: 'Steve', age: 33 });

console.log(user.get('name'));
console.log(user.get('age'));
