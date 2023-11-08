using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_
{
    internal class Attack
    {
        public List<List<int>> systems = new List<List<int>>();
        double prob;

        public Attack(int M, int N, double p)
        {
            for (int i = 0; i < M; i++)
            {
                systems.Add(new List<int>());
                for (int j = 0; j < N; j++)
                {
                    systems[i].Add(0);
                }
            }
            prob= p;
        }

        public void SimulateAttack()
        {
            Random random = new Random();

            for (int i = 0; i < systems.Count; i++)
            {
                for (int j = 0; j < systems[0].Count; j++)
                {
                    var nextRandom = random.NextDouble();
                    this.systems[i][j] = nextRandom <= prob ? -1 : 1;
                }
            }
        }

        public List<List<int>> Systems()
        {
            return this.systems;
        }
    }
}
