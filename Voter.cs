namespace dictionary_exec_fix
{
    class Voter
    {
        public string Name { get; set; }
        public int VoteQuantity { get; set; }

        public Voter()
        {
        }

        public Voter(string name, int voteQuantity)
        {
            Name = name;
            VoteQuantity = voteQuantity;
        }

        public override string ToString()
        {
            return Name + ": " + VoteQuantity;
        }
    }
}
