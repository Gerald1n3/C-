using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cuenta
{
    //Definicion de atributos
    private string Numero;
    private double Saldo;
    private string Clave;
    private DateTime FechaApertura;
    private DateTime UltimoMovimiento;
    private bool Estado;
    private Titular Titular;

    //Definicion de metodos
    public Cuenta()
    {
    }

    public Cuenta(string nu, double sal, string cla, DateTime fa,
        DateTime um, bool est, Titular tit)
    {
        this.Numero = nu;
        this.Saldo = sal;
        this.Clave = cla;
        this.FechaApertura = fa;
        this.UltimoMovimiento = um;
        this.Estado = est;
        this.Titular = tit;
    }

    public string getNumero()
    {
        return this.Numero;
    }
    public void setNumero(string num)
    {
        this.Numero = num;
    }

    public double getSaldo()
    {
        return this.Saldo;
    }
    public void setSaldo(double sal)
    {
        this.Saldo = sal;
    }

    public string getClave()
    {
        return this.Clave;
    }
    public void setClave(string cla)
    {
        this.Clave = cla;
    }

    public DateTime getFechaApertura()
    {
        return this.FechaApertura;
    }
    public void setFechaApertura(DateTime fa)
    {
        this.FechaApertura = fa;
    }

    public DateTime getUltimoMovimiento()
    {
        return this.UltimoMovimiento;
    }
    public void setUltimoMovimiento(DateTime um)
    {
        this.UltimoMovimiento = um;
    }

    public bool getEstado()
    {
        return this.Estado;
    }
    public void setEstato(bool est)
    {
        this.Estado = est;
    }

    public Titular getTitular()
    {
        return this.Titular;
    }
    public void setUltimoMovimiento(Titular tit)
    {
        this.Titular = tit;
    }

    public void Consignar(double valor)
    {
        this.Saldo += valor;
    }


}

