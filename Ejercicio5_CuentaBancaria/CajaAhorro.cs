public class CajaAhorro : Cuenta
{
    protected float TasaInteres; // En porcentaje %

    public CajaAhorro(int numero, string titular, float saldo, float tasa)
        : base(numero, titular, saldo)
    {
        TasaInteres = tasa;
    }

    public override void ActualizarSaldo()
    {
        Saldo += Saldo * TasaInteres / 100;
    }

    public override void MostrarDatos()
    {
        Console.WriteLine($"[Caja de Ahorro] Cuenta: {NumeroCuenta} | Titular: {Titular} | Saldo: {Saldo} | Tasa: {TasaInteres}%");
    }
}