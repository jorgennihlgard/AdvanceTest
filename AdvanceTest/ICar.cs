namespace AdvanceTest
{
    public interface ICar
    {
        int Wheel { get; set; }
        string Color { get; set; }
        int Speed { get; set; }
        void SetSpeed(int speed);

    }
}