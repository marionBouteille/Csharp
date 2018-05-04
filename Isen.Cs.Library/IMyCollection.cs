namespace Isen.Cs.Library
{
    public interface IMyCollection
    {
        //getter sans setter
        int Count { get; } 
        string[] Values { get; }
        void Add(string item);
        void InsertAt(int index, string item);

        void RemoveAt(int index);

    }
}