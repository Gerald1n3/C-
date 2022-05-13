using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Titular
{
    //Definicion de atributos
    private string Documento;
    private string Nombres;
    private string Apellidos;
    private string Celular;
    private string Correo;
    private string Direccion;

    public Titular()
    {
    }

    public Titular(string doc, string nom, string ape, string cel,
        string cor, string dir)
    {
        this.Documento = doc;
        this.Nombres = nom;
        this.Apellidos = ape;
        this.Celular = cel;
        this.Correo = cor;
        this.Direccion = dir;
    }
    public string getDocumento()
    {
        return this.Documento;
    }
    public void setDocumento(string doc)
    {
        this.Documento = doc;
    }

    public string getNombres()
    {
        return this.Nombres;
    }
    public void setNombres(string nom)
    {
        this.Nombres = nom;
    }

    public string getApellidos()
    {
        return this.Apellidos;
    }
    public void setApellidos(string ape)
    {
        this.Apellidos = ape;
    }

    public string getCelular()
    {
        return this.Celular;
    }
    public void setCelular(string cel)
    {
        this.Celular = cel;
    }

    public string getCorreo()
    {
        return this.Correo;
    }

    public void setCorreo(string cor)
    {
        this.Correo = cor;
    }
    public string getDireccion()
    {
        return this.Direccion;
    }
    public void setDireccion(string dir)
    {
        this.Direccion = dir;
    }


}
