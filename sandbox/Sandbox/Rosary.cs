using System;

public class Rosary
{
    private List<Decade> _decades;
    public Rosary()
    {
        _decades = new List<Decade>();
    }

    public void AddDecade(Decade decade)
    {
        _decades.Add(decade);
    }

    public void DisplayAll()
    {
        foreach (Decade decade in _decades)
        {
            decade.DisplayAll();
        }
    }

    public void Pray()
    {
        foreach (Decade decade in _decades)
        {
            decade.Pray();
        }
    }
}