class Vehicle {

  constructor(public color: string) {}

  // public drive(): void {
  //   console.log('chugga chugga');
  // }

  protected honk(): void {
    console.log('beep');
  }
}

const vehicle = new Vehicle('orange');
console.log(vehicle.color);

class Cary extends Vehicle { 
  constructor(public wheels: number, color: string){
    super(color); // Must call constructor in parentclass from childconstructor
  }
  private drive(): void { // Overriding the parentclass drive-method
    console.log('vroom');
  }

  startDrivingProcess(): void {
    this.drive();
    this.honk(); // Can be called since this is a childclass of Vehicle
  }
}

const cary = new Cary(4, 'red');
cary.startDrivingProcess(); // Can be called outside class since it does not have private modifier 
//cary.honk(); // Can't be called outside Vehicle-class

