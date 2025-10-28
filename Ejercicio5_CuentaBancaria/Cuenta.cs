public class Cuenta
{
    protected int NumeroCuenta;
    protected string Titular;
    protected float Saldo;

    public int GetNumeroCuenta() => NumeroCuenta;
    public string GetTitular() => Titular;
    public float GetSaldo() => Saldo;

    public void SetTitular(string titular) => Titular = titular;
    public void SetSaldo(float saldo) => Saldo = saldo;

    public Cuenta(int numeroCuenta, string titular, float saldo)
    {
        NumeroCuenta = numeroCuenta;
        Titular = titular;
        Saldo = saldo;
    }

    public virtual void MostrarDatos()
    {
        Console.WriteLine($"Cuenta: {NumeroCuenta} | Titular: {Titular} | Saldo: {Saldo}");
    }

    public virtual void Depositar(float monto)
    {
        Saldo += monto;
    }

    public virtual bool Extraer(float monto)
    {
        if (Saldo >= monto)
        {
            Saldo -= monto;
            return true;
        }
        return false;
    }

    public virtual void ActualizarSaldo() { } // Sobreescribimos en CajaAhorro
}