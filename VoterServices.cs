using System;
using System.Collections.Generic;
using System.IO;

namespace dictionary_exec_fix
{
    class VoterServices
    {

        Dictionary<int, Voter> dic = new Dictionary<int, Voter>();


        public void Read()
        {
            string filePath = @"C:\temp\voter.txt";
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] x = lines[i].Split(',');
                string name = x[0];
                int quantity = int.Parse(x[1]);
                AddVoter(i, name, quantity);
            }
        }

        public void AddVoter(int key, string name, int quantity)
        {
            int count = 0;
            foreach (var item in dic)
            {
                if (item.Value.Name == name)
                {
                    count++;
                    item.Value.VoteQuantity += quantity;
                }
            }
            if (count == 0)
            {
                dic.Add(key, new Voter(name, quantity));
            }
        }

        public void Write()
        {
            string targetFile = @"C:\temp\voterExit.txt";
            File.CreateText(targetFile).Close();
            foreach (var item in dic)
            {
                File.AppendAllText(targetFile, item.Value.ToString());
                File.AppendAllText(targetFile, "\n");
            }
        }

        public void Print()
        {
            foreach (var item in dic)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
