// See https://aka.ms/new-console-template for more information


using ExampleStack;

var stack = new StackExample();

Console.WriteLine($"Empilahndo: {stack.StackUp(1).item}");
Console.WriteLine($"Empilahndo: {stack.StackUp(10).item}");
Console.WriteLine($"Empilahndo: {stack.StackUp(100).item}");


Console.WriteLine($"Desempilando: {stack.Unstack()}");
Console.WriteLine($"Desempilando: {stack.Unstack()}");
Console.WriteLine($"Desempilando: {stack.Unstack()}");
Console.WriteLine($"Desempilando: {stack.Unstack()}");
