public class Compra
{
    private decimal desconto;
    public decimal Desconto
    {
        get
        {
            if (this.quantidade <= 5)
                return 0.98m;
            if (this.quantidade > 5 && this.quantidade <= 10)
                return 0.97m;
            if (this.quantidade > 10)
                return 0.95m;
            return this.desconto;
        }
        set
        {
            desconto = value;
        }
    }
    public int quantidade { get; set; }
    public Produto produto { get; set; }
}