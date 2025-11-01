using MakeenFitnessClass.Models.fito;

namespace MakeenFitnessClass
{
    internal class Program
    {
        static void Main(string[] args)
        {


 public string RegisterToClass(FitnessClass fitness)
        {
            if (fitness.numberOfMembers < fitness.members.Count())
            {
                fitness.members[fitness.members.Count() - 1] = this;
                this.regesteredClasses.Add(fitness);
                return "registered Successfully ";
            }
            else
            {
                return "already full we will put you on the waiting list ";
            }
        }
    }
    }
}
