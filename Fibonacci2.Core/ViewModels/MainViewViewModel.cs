using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci2.Core.ViewModels
{
    public class MainViewViewModel
    {
        public MainViewViewModel()
        {
            Numbers = new ObservableCollection<long>();
            CallculateNumbers();

        }

        public long LongMax
        {
            get
            {
                return long.MaxValue;
            }
        }

        public ObservableCollection<long> Numbers { get; private set; }

        private void CallculateNumbers()
        {
            if(LongMax < 1)
            {
                throw new Exception("Long max must be bigger than 0");
            }

            Numbers.Add(1);
            Numbers.Add(1);

            long currentNumber = 1;

            while (currentNumber > 0 && currentNumber < LongMax)
            {
                Numbers.Add(Numbers[Numbers.Count - 2] + Numbers[Numbers.Count - 1]);
                currentNumber = Numbers[Numbers.Count - 1];
            }

            Numbers.RemoveAt(Numbers.Count - 1);
        }
    }
}
