using System;
using HelloFsharp;
using Quantum.HelloQSharp;
using Microsoft.Quantum.Simulation.Simulators;

namespace SharpProject
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            string name = "Nico";
            //C#
            Console.WriteLine($"Hello World from C# {name}");

            //F#
            Say.hello(name);

            //Q#
            using (var sim = new QuantumSimulator())
                await HelloW.Run(sim, name);
        }
    }
}
