using System;
using System.Collections.Generic;

public interface IEmitSound
{
    void EmitSound();
}

//The properties animalType and sound are hidden and can only be accessed or modified through the class methods
class Animal : IEmitSound
{
    public string AnimalType { get; set; }
    public string Sound { get; set; }

    public Animal(string animalType, string sound)
    {
        AnimalType = animalType;
        Sound = sound;
    }

    public void EmitSound()
    {
        Console.WriteLine($"{AnimalType} makes sound: {Sound}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //the list of objects that implements the IEmitSound interface
        List<IEmitSound> soundEmitters = new List<IEmitSound>
        {
            new Animal("Dog", "Bark"),
            new Animal("Cat", "Meow"),
            new Animal("Cow", "Moo"),
            new Animal("Sheep", "Baa"),
            new Animal("Duck", "Quack")
        };

        foreach (var soundEmitter in soundEmitters)
        {
            soundEmitter.EmitSound();
        }
    }
}
