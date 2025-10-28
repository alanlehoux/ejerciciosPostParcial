public class CuentaCorriente : Cuenta
{
    protected float LimiteDescubierto;

    public CuentaCorriente(int numero, string titular, float saldo, float limite)
        : base(numero, titular, saldo)
    {
        LimiteDescubierto = limite;
    }

    public override bool Extraer(float monto)
    {
        if (Saldo + LimiteDescubierto >= monto)
        {
            Saldo -= monto;
            return true;
        }
        return false;
    }

    public override void MostrarDatos()
    {
        Console.WriteLine($"[Cuenta Corriente] Cuenta: {NumeroCuenta} | Titular: {Titular} | Saldo: {Saldo} | Límite Descubierto: {LimiteDescubierto}");
    }
}