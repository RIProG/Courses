interface Reportable {
  // name: string;
  // year: Date;
  // broken: boolean;
  summary(): string;
};

const oldCivic = {
  name: 'civic',
  year: new Date(),
  broken: true,
  summary(): string {
    return `Name: ${this.name}`;
  }
};

const drinky = {
  color: 'brown',
  carbonated: true,
  sugar: 40,
  summary(): string {
    return `My drink has ${this.sugar} grams of sugar`;
  }
};

const printSummary = (item: Reportable): void => { // Using interface as property-requirements.
  console.log(item.summary());                    // Doesn't matter if passed in object has
};                                               // additional properties. 

printSummary(oldCivic);
printSummary(drinky);

