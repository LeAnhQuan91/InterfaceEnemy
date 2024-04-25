internal class Program
{
    private static void Main(string[] args)
    {
        //Wood wood= new Wood();
        //wood.Efect();
//Iron iron = new Iron();
//iron.Efect();
Grass grass= new Grass();
grass.Efect();
   }
}


public interface IDamager
{
    void Efect();
}
public class Wood : IDamager
{
    public void Efect()
    {
        Console.WriteLine("Tao lo tren go khi dan ban");
    }
}

public class Iron : IDamager
{
    public void Efect( )
    {
        Console.WriteLine("Tao tia lua khi dan ban");
    }
}

public class Grass : IDamager
{
    public void Efect()
    {
        Console.WriteLine("Tao bun dat len khi dan ban");
    }
}

