public class Coin {
    public string Country { get; set; }
    public string Denomination { get; set; }
    public int Year { get; set; }
    public string Metal { get; set; }
    public long Mintage { get; set; }
    public string Features { get; set; }

    public Coin() { }

    public override string ToString() {
        return $"{Denomination} ({Country}, {Year})";
    }
}