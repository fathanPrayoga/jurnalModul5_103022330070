using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnalModul5_103022330070
{
    internal class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();


        }

        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.UtcNow);

        }
        public void PrintAllData()
        {
            for (int i =0;  i < storedData.Count; i++)
            {
                Console.WriteLine($" DATA: {storedData[i]}");
                Console.WriteLine($" DATA: {inputDates[i]}");
            }
        }
        }
    }
