namespace inheritance;

public class Bitkiler:Canlilar
{
  protected void Fotosentez()
  {
    Console.WriteLine("Bitkiler fotosentez yapar.");
  }
}
public class TohumluBitkiler:Bitkiler
{
    public TohumluBitkiler()
    {
        base.Fotosentez();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
       
    }
    public void TohumlaCogalma()
  {
    Console.WriteLine("Bitkiler tohumla çogalir");
  }
}
public class TohumsuzBitkiler:Bitkiler
{
    public TohumsuzBitkiler()
    {
        base.Fotosentez();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
       
    }
    public void SporlaCogalma()
  {
    Console.WriteLine("Bitkiler sporla çogalir");
  }
}