using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Generator.Generator
{
    static class GeneratorRandomValue
    {
        private static readonly Random Random = new Random(DateTime.Now.Millisecond);

        private static int FindWeightingCoefficientInTheFile(string value, IEnumerable<KeyValuePair<string, int>> availableValues)
        {
            var result = -1;
            foreach (var parameter in availableValues.Where(parameter => parameter.Key == value))
            {
                result = Convert.ToInt32(parameter.Value);
                break;
            }
            return result;
        }

        static private int SumOfWeightCoefficient(IEnumerable<string> arrayOfValues, IEnumerable<KeyValuePair<string, int>> values)
        {
            var availableValues = values as KeyValuePair<string, int>[] ?? values.ToArray();
            var sumOfWeightCoefficients = availableValues.Sum(keyValuePair => keyValuePair.Value); // сумма весовых коэффициентов в массиве

            var ofValues = arrayOfValues as string[] ?? arrayOfValues.ToArray();
            sumOfWeightCoefficients = ofValues.Where(method => FindWeightingCoefficientInTheFile(method, availableValues) == -1).Aggregate(sumOfWeightCoefficients, (current, method) => current + current / ofValues.Length); //пересчет суммы если есть методы, которые не были описаны в файле конфигурации
            return sumOfWeightCoefficients;
        }

       static public string GetRandomValue(IEnumerable<string> arrayOfValues, IEnumerable<KeyValuePair<string, int>> available)
       {
          
            var result = string.Empty;
            var keyValuePairs = available as KeyValuePair<string, int>[] ?? available.ToArray();
            var listOfValues = arrayOfValues as IList<string> ?? arrayOfValues.ToList(); 
           if (keyValuePairs.Count() == 0)
            {
                return listOfValues.ElementAt(Random.Next(0, listOfValues.Count()));
            }
            int sumOfWeightCoefficients = SumOfWeightCoefficient(listOfValues, keyValuePairs);
            var randomWeightCoefficientOfMethods = Random.Next(1, sumOfWeightCoefficients);
            var previousWeightCoefficient = 0;
            var tempWeightCoefficient = 0;

            foreach (var value in listOfValues)
            {
                var weightCoefficient = FindWeightingCoefficientInTheFile(value, keyValuePairs);
                tempWeightCoefficient += weightCoefficient != -1
                    ? weightCoefficient
                    : sumOfWeightCoefficients / keyValuePairs.Length; //если коэффициент не найден, то считаем, что он равен среднему арифметическому среди всех элементов.
                if (randomWeightCoefficientOfMethods <= tempWeightCoefficient &&
                    randomWeightCoefficientOfMethods > previousWeightCoefficient)
                {
                    result = value;
                    break;
                }
                previousWeightCoefficient = tempWeightCoefficient;
            }
            return result;
        }
    }
}
