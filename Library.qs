namespace Quantum.HelloQSharp {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    

    operation HelloW (name : String) : Unit {
        Message($"Hello world from Q# {name}");
    }
}
