public class Lecture : Event
{
    private string speakerName;
    private int capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speakerName, int capacity)
        : base(title, description, date, time, address)
    {
        this.speakerName = speakerName;
        this.capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker: {speakerName}\nCapacity: {capacity}";
    }
}