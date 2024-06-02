// See https://aka.ms/new-console-template for more information

using DesignPatterns.Builder;

var computer = Computer
    .Builder()
    .WithProcessor("Intel Core i7 13650HX")
    .WithRamSize(32)
    .WithDiskSize(2000)
    .WithOperatingSystem(OperatingSystemType.WINDOWS).Build();
    
    
computer.PrintComputer();
    