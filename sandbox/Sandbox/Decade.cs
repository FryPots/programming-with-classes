using System;

public class Decade
{
    List<Prayer> _prayers;
    public Decade(Prayer mistery, Prayer content)
    {
        _prayers = new List<Prayer>();
        _prayers.Add(mistery);

        for (int i=0; i<10; i++)
        {
        _prayers.Add(content);
        }
    }

    public void AddPrayer(Prayer prayer)
    {
        _prayers.Add(prayer);
    }
    public void DisplayAll()
    {
        foreach (Prayer prayer in _prayers)
        {
            prayer.Display();
        }
    }

    public void Pray()
    {
        foreach (Prayer prayer in _prayers)
        {
            prayer.Pray();
        }
    }
}