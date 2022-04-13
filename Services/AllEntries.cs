using Business;
using DataAccess;
using System;
using System.Collections.Generic;

namespace Services
{
    public class AllEntries
    {
        public List<Event> Events()
        {
            PersonRepo personRepo = new PersonRepo();
            GatesRepo gateRepo = new GatesRepo();

            List<Event> list = new List<Event>();
            return list;
        }

        public bool Check(int personId, int gateId)
        {
            PersonRepo personRepo = new PersonRepo();
            GatesRepo gateRepo = new GatesRepo();

            try
            {
                List<int> gateAccessCodes = gateRepo.RetrieveGateAccessCodes(gateId);
                return gateAccessCodes.Contains(personId);
            }
            catch (ArgumentOutOfRangeException e)
            {
                return false;
            }
            catch (NullReferenceException e)
            {
                return false;
            }

        }
    }
}
