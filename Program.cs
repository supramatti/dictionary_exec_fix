using System;

namespace dictionary_exec_fix
{
    class Program
    {
        static void Main(string[] args)
        {
            VoterServices vs = new VoterServices();
            vs.Read();
            vs.Print();
            vs.Write();
        }
    }
}
