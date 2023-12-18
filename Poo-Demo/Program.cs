// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Apuntador apuntadorPlatzi = new Apuntador();
Apuntador apuntadorCesde = new Apuntador();

apuntadorPlatzi.Color = "Blue";

class Apuntador
{
    public string Color;
    public double Largo;
    public short NumeroBotones;
    public bool TieneStickers;
}