namespace Autobrawl.Engine.Mechanics.Functions;
public class RngFunctions<T>
    where T : class
{
    private static Random random = new();

    private List<Node<T>> GenerateHeap(List<T> values)
    {
        List<Node<T>> nodes = new();
        nodes.Add(null);

        return nodes;
    }
}

internal class Node<T>
    where T : class
{
    public Node(int weight, int totalWeight, T value)
    {
        Weight = weight;
        TotalWeight = totalWeight;
        Value = value;
    }

    public int Weight {  get; set; }
    public int TotalWeight {  get; set; }
    public T Value {  get; set; }
}