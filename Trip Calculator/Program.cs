//Part 1: Road Trip

System.Console.Write("How many miles is your round trip? ");
double roundTripMiles = Convert.ToDouble(Console.ReadLine());

System.Console.Write("How many miled per gallon does your car get? ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());

System.Console.Write("What is the price per gallon of gas in dollars? $");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

double gallonsNeeded = Convert.ToDouble(roundTripMiles/milesPerGallon);
double fuelCost = Convert.ToDouble(gallonsNeeded * pricePerGallon);

System.Console.WriteLine($"Gallons needed: {gallonsNeeded.ToString("F2")}");
System.Console.WriteLine($"Fuel Cost: {fuelCost.ToString("C")}");

//Part 2: Pizza Party
const int slicesPerPizza = 8;

System.Console.Write("How many people are going to the party? ");
int numberOfAttendees = Convert.ToInt32(Console.ReadLine());

System.Console.Write("How many pizzas? ");
int numberOfPizzas = Convert.ToInt32(Console.ReadLine());

System.Console.Write("What is the price per pizza? $");
double priceofPizza = Convert.ToDouble(Console.ReadLine());

double totalSlices = numberOfPizzas * slicesPerPizza;
double slicesPerPerson = Convert.ToDouble(totalSlices/(double)numberOfAttendees);
double pizzaCost = numberOfPizzas * priceofPizza;

System.Console.WriteLine($"Total Slices: {totalSlices}");
System.Console.WriteLine($"Slices per Person: {slicesPerPerson.ToString("F1")}");
System.Console.WriteLine($"Pizza Cost: {pizzaCost.ToString("C")}");

//Part 3: Paycheck

const double taxRate = 0.18;

System.Console.Write("How many hours did you work this week? ");
double hoursWorked = Convert.ToDouble(Console.ReadLine());

System.Console.Write("What is your Hourly rate? $");
double payRate = Convert.ToDouble(Console.ReadLine());

double grossPay = hoursWorked * payRate;
double taxWithheld = grossPay * taxRate;
double takeHomePay = grossPay - taxWithheld;

System.Console.WriteLine($"Gross pay: {grossPay.ToString("C")}");
System.Console.WriteLine($"Tax Withheld: {taxWithheld.ToString("C")}");
System.Console.WriteLine($"Take home pay: {takeHomePay.ToString("C")}");

//Part 4: The Whole Trip

double tripTotal = fuelCost + pizzaCost;
double costPerPerson = tripTotal/numberOfAttendees;
double takeHomePayPerHour = takeHomePay/hoursWorked;
double hoursYouMustWork = costPerPerson/takeHomePayPerHour;

System.Console.WriteLine($"Trip Total: {tripTotal.ToString("C")}");
System.Console.WriteLine($"Cost Per Person: {costPerPerson.ToString("C")}");
System.Console.WriteLine($"Take home pay per hour: {takeHomePayPerHour.ToString("C")}");
System.Console.WriteLine($"Hours you must work to cover your share: {hoursYouMustWork.ToString("F2")}");