using System;
using System.Collections.Generic;

namespace Design_Underground_System
{
    public class UndergroundSystem
    {
        private Dictionary<int, Tuple<string, int>> checkIns = new Dictionary<int, Tuple<string, int>>();
        private Dictionary<Tuple<string, string>, Tuple<int, int>> journeys = new Dictionary<Tuple<string, string>, Tuple<int, int>>();

        public UndergroundSystem()
        {

        }

        public void CheckIn(int id, string stationName, int t) => checkIns.Add(id, new Tuple<string, int>(stationName, t));

        public void CheckOut(int id, string stationName, int t)
        {
            string checkInStation = checkIns[id].Item1;
            int checkInTime = checkIns[id].Item2;
            var route = new Tuple<string, string>(checkInStation, stationName);

            int totalTripTime = t - checkInTime;
            int totalTripCount = 1;
            var journeyTotal = new Tuple<int, int>(0, 0);
            if (journeys.TryGetValue(route, out journeyTotal))
            {
                totalTripTime += journeyTotal.Item1;
                totalTripCount += journeyTotal.Item2;
            }

            journeys[route] = new Tuple<int, int>(totalTripTime, totalTripCount);

            checkIns.Remove(id);
        }

        public double GetAverageTime(string startStation, string endStation)
        {
            var route = new Tuple<string, string>(startStation, endStation);

            return (double)journeys[route].Item1 / journeys[route].Item2;
        }
    }
}
