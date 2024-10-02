using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BorkovNA.Sprint1.Task6.V7.Lib
{
    public class DataService : ISprint1Task6V7
    {
        public string DeleteLastLetter(string value)
        {
            value = value.Remove(value.Length);
            string[] words = value.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);
            string[] wordsRemoveLastLiter = words.Where(x => x.Length <= 30).Select(x => x.Remove(x.Length - 1)).ToArray<string>();
            string strFinal = string.Join(" ", wordsRemoveLastLiter);
            return strFinal;
            
        }
    }
}
