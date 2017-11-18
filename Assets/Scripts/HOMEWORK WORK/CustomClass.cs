public class CustomClass
{
    public int Health = 5;
  public int MaxHealth = 10;
    public float CurrentHealthPercent ()
    {
        return Health / ((float) MaxHealth) * 100 ;


    }

}