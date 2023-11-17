

Dictionary<string, string> lookup = new Dictionary<string, string>();

lookup["animal"] = "Not a human";
lookup["fish"] = "Not a human that swims";
lookup["human"] = "Us";

Console.WriteLine($"The definition of fish is {lookup["fish"]}");

Dictionary<int, string> employees = new Dictionary<int, string>();

employees[95] = "Justin Spencer";
employees[50] = "Ray Cooper";

Console.WriteLine($"The employee with ID number 50 is {employees[50]}");

Dictionary<string, int> dayOfWeek = new Dictionary<string, int>();

dayOfWeek["Wednesday"] = 3;
dayOfWeek["Thursday"] = 4;
dayOfWeek["Friday"] = 5;

Console.WriteLine($"Wednesday is day number {dayOfWeek["Wednesday"]}");
