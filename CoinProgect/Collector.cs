public class Collector {
    public string Name { get; set; }
    public string Country { get; set; }
    public string ContactInfo { get; set; }
    public string RareCoinsInfo { get; set; }
    public bool HasOwnCollection { get; set; }

    public Collector() { }

    public override string ToString() {
        return $"{Name} [{Country}]";
    }
}