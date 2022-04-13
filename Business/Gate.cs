using System.Collections.Generic;

namespace Business
{
    public class Gate
    {
        public int Id { get; }
        public List<int> AccessCodeId { get; }

        public Gate(int id, List<int> accessCodeId)
        {
            Id = id;
            AccessCodeId = accessCodeId;
        }
    }
}
