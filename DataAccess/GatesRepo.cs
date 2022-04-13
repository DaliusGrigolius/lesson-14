using Business;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class GatesRepo
    {
        private List<Gate> gatesList { get; }
        private List<int> accessCodes1 { get; }
        private List<int> accessCodes2 { get; }
        private List<int> accessCodes3 { get; }
        private List<int> accessCodes4 { get; }

        public GatesRepo()
        {
            accessCodes1 = new List<int> { 1, 2, 3, 4 };
            accessCodes2 = new List<int> { 1, 2, 3 };
            accessCodes3 = new List<int> { 5, 6, 7, 8 };
            accessCodes4 = new List<int> { 9, 10 };

            Gate gate1 = new Gate(1, accessCodes1);
            Gate gate2 = new Gate(2, accessCodes2);
            Gate gate3 = new Gate(3, accessCodes3);
            Gate gate4 = new Gate(4, accessCodes4);

            gatesList = new List<Gate> { gate1, gate2, gate3, gate4};
        }
        public List<Gate> RetrieveGatesList()
        {
            return gatesList;
        }
        public Gate RetrieveGate(int gateIndex)
        {
            return gatesList[gateIndex];
        }
        public List<int> RetrieveGateAccessCodes(int gateId)
        {
            try
            {
                return gatesList[gateId - 1].AccessCodeId;
            }
            catch(Exception e)
            {
                Console.WriteLine($"Ivestas skaicius turi buti tarp 1 ir 4 {e.Message}");
                gateId = Convert.ToInt32(Console.ReadLine());

             
                return null;
            }
        }
    }
}
