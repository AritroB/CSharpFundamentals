Console.WriteLine("Welcome to Bethany's Pie Shop HRM!");

Console.WriteLine("Please enter your name: ");

//string name = Console.ReadLine();

/*
string name2 = Console.ReadLine();
string name_2 = Console.ReadLine();
*/
//string 2Name = Console.Readline();

int monthlyWage = 1234;

int months = 12, bonus = 1000;

bool isActive = true;

double rating = 99.25;

// byte numberOfEmployees = 300; does not work bc 300 is out of range of byte

int hoursWorked;

hoursWorked = 125;

const double interestRate = 0.07;

//interestRate = 0.08; doesn't work becaue of const

string firstName = "Bethany";
string lastName = "Smith";

string emptyString = "";

double ratePerHour = 12.34;
int numberOfHoursWorked = 165;

double currentMonthWage = ratePerHour * numberOfHoursWorked;
Console.WriteLine(currentMonthWage);

var numEmployees = 15;
numEmployees--;

int intMaxValue = int.MaxValue;
int intMinValue = int.MinValue;

char userSelection = 'a';
char upperVersion = char.ToUpper(userSelection);

DateTime hireDate = new DateTime(2023, 5, 11, 14, 30, 0);
Console.WriteLine(hireDate);

DateTime startDate = hireDate.AddDays(25);
Console.WriteLine("Start date: " + startDate);

var isActive = true;
