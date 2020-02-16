using rgn.Physics;
using System;

namespace rgn
{
    public class Car
    {
        public Car(string make, string model, string description, int hp)
        {
            Make = make;
            Model = model;

            Description = description;
            HP = hp;
        }

        // car related types

        private enum DriveType
        {
            fwd,
            rwd,
            awd
        }

        private enum TransmissionType
        {
            MT,
            AT
        }

        private enum CarType
        {
            sports,
            racecar,
            supercar,
            drift,
            drag,
            rally,
            concept,
            hypercar,
            tuned
        }

        private enum RacingType
        {
            GTR,
            F1,
            Touring
        }

        private enum TireType
        {
            sport,
            semiSlick,
            slick,
            supersoft,
            soft,
            medium,
            hard,
            dry,
            wet,
            street,
            rally,
            dirt,
            snow,
            summer,
        }

        private enum Paint
        { matte, chrome, metallic, pearl, solid }

        private enum SafetySystems
        {
            ABS,
            ESP,
            TCS,
            ESC,
            ASR,
        }

        private enum Price
        {
            usd,
            eur
        }

        public float Speed
        {
            get;
            set;
        }

        public float Distance
        {
            get;
            set;
        }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }
        public string Description { get; set; }

        // horsepower
        public int HP { get; set; }

        public int Weight { get; set; }

        public float WheelBase { get; set; }
        public float RearTrack { get; set; }
        public float TurnRadius { get; set; }

        public float WheelRadius { get; set; }

        public int RPM { get; set; }

        public bool IsLocked { get; set; }

        public bool IsInMeeting { get; set; }

        public bool IsOnTrack { get; set; }

        public bool IsUsed { get; set; }
        public bool AImode { get; set; }

        public bool EnableCarPhysics { get; set; }

        public float FuelConsumption { get; set; }

        public float TireExploit { get; set; }

        public object Differential { get; set; }

        public object Clutch { get; set; }

        public object Gearbox { get; set; }

        public object Suspension { get; set; }

        private enum Wheels
        {
            // front
            FR,

            FL,

            // rear
            RL,

            RR
        }

        private enum WheelColliders
        {
            // front
            ColFR,

            ColFL,

            // rear
            ColRL,

            ColRR
        }

        private Rigid rb;

        /// <summary>
        /// left angle of ackermann steering in degrees
        /// </summary>
        /// params in metres
        /// <param name="rearTrack"></param>
        /// <param name="wheelBase"></param>
        /// <param name="turnRadius"></param>
        ///
        /// <returns>angle</returns>
        public static double AckermannLeft(float rearTrack, float wheelBase, float turnRadius)
        {
            var left = Math.Atan(wheelBase / (turnRadius + rearTrack / 2));
            return Maths.RadToDeg(left);
        }

        /// <summary>
        /// right angle of ackermann steering in degrees
        /// </summary>
        /// <param name="rearTrack"></param>
        /// <param name="wheelBase"></param>
        /// <param name="turnRadius"></param>
        /// <returns>angle</returns>
        public static double AckermannRight(float rearTrack, float wheelBase, float turnRadius)
        {
            var right = Math.Atan(wheelBase / (turnRadius - rearTrack / 2));
            return Maths.RadToDeg(right);
        }

        /// <summary>
        /// Meters per second to kmh.
        /// </summary>
        /// <returns>speed in kmh</returns>
        /// <param name="speed">Speed</param>
        public int MpsToKmh(float speed)
        {
            return (int)Math.Round(speed * 3.6);
        }

        /// <summary>
        /// Meters to km.
        /// </summary>
        /// <returns>The km.</returns>
        /// <param name="distance">Distance.</param>
        public float MToKm(float distance)
        {
            return distance / 1000;
        }

        /// <summary>
        /// Kmh to mph
        /// </summary>
        /// <returns>speed in mph</returns>
        /// <param name="speed">Speed</param>
        public int KmhToMph(int speed)
        {
            return (int)Math.Round(speed / 1.61);
        }

        /// <summary>
        /// Mph to kmh
        /// </summary>
        /// <returns>speed in kmh</returns>
        /// <param name="speed">Speed</param>
        public int MphToKmh(int speed)
        {
            return (int)Math.Round(speed * 1.61);
        }

        public void Accelerate(int engineForce)
        {
            rb.AddForce(engineForce);
        }

        public void Brake(int brakeForce)
        {
            rb.AddForce(brakeForce);
        }

        public void SteerLeft(int torque)
        {
            rb.AddTorque(torque * -1);
        }

        public void SteerRight(int torque)
        {
            rb.AddTorque(torque);
        }
    }
}