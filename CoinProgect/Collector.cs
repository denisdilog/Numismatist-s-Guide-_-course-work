/// <summary>
/// Клас, що представляє сутність "Колекціонер" та містить його персональні, 
/// контактні дані, а також статус наявності власної колекції.
/// </summary>
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