using ClownInterfaces;

IClown.CarCapacity = 28;
Console.WriteLine(IClown.ClownCarDescription());

IClown fingersTheClown = new ScaryClown(14, "a big red nose");
fingersTheClown.Honk();

if (fingersTheClown is IScaryClown iScaryClownReference)
    iScaryClownReference.ScareAdults();