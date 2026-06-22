namespace IntroClasses;

public class Cell
{
    public Character Occupant;
    public char Visuals;
    public Item? Item { get; set; }

    public void Display()
    {
        if (IsOccupied())
        {
            Occupant.Display();
        }
        else if (HasItem())
        {
            Item.Display();
        }
        else
        {
            Console.Write(Visuals);
        }
    }

    public bool IsOccupied()
    {
        return Occupant != null;
    }

    public bool HasItem()
    {
        return Item != null;
    }

    public void PutItem(Item item)
    {
        Item = item;
    }

    public Item TakeItem()
    {
        Item item = Item;
        Item = null;
        
        return item;
    }

    /// <summary>
    /// Place character on this cell by putting it into Occupant field.
    /// </summary>
    /// <param name="character">Character to put into Occupant field</param>
    public void Occupy(Character character)
    {
        Occupant = character;
    }

    public void Leave()
    {
        Occupant = null;
    }
}