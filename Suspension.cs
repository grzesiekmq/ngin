namespace rgn.CarParts
{
    public class Suspension
    {
        public float Distance { get; set; }

        private Spring spring = new Spring();

        private int SpringRate(int mass, float Distance, int noOfWheels = 4)
        {
            return (int)(mass / noOfWheels * 2 * 9.81 / Distance);
        }

        private int CompressionDistance(int weight, float gravity, int SpringRate)
        {
            return (int)(weight * gravity / SpringRate);
        }

        public int Force(int SpringRate, int CompressionDistance, int damper, int contactSpeed)
        {
            return (int)(SpringRate * CompressionDistance + damper * contactSpeed);
        }
    }

    internal class Spring
    {
        public int SpringForce { get; set; }
        public int Damper { get; set; }
        public float TargetPos { get; set; } = .5f;
    }
}