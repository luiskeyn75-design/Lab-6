using System;
using System.Collections.Generic;

namespace LabPolymorphism;

class Program
{
    static void Main(string[] args)
    {
        List<Artifact> inventory = new List<Artifact>();

        inventory.Add(new MagicScroll(101));
        inventory.Add(new AncientSword(202));

        Console.WriteLine("--- Аналіз інвентарю ---");

        foreach (var item in inventory)
        {
            item.Identify();
        }

        Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
        Console.ReadKey();
    }
}

public class Artifact
{
    private int id;

    public Artifact(int id)
    {
        this.id = id;
    }

    public virtual void Identify()
    {
        Console.WriteLine($"[Artifact ID: {id}] Це невідомий стародавній предмет.");
    }
}

public class MagicScroll : Artifact
{
    public MagicScroll(int id) : base(id)
    {
    }

    public override void Identify()
    {
        Console.WriteLine("[Magic Scroll] Це сувій з закляттям вогню.");
    }
}

public class AncientSword : Artifact
{
    public AncientSword(int id) : base(id)
    {
    }

    public override void Identify()
    {
        Console.WriteLine("[Ancient Sword] Це заіржавілий меч короля.");
    }
}