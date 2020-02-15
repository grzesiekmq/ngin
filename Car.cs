// Copyright (C) Grzegorz Futa. All rights reserved.


using System;
using rgn.Physics;

using BulletSharp.Math;

namespace rgn
{
    public class Car
    {



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

        Rigid rb;

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