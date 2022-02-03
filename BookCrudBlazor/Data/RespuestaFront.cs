using System.Collections.Generic;

namespace BookCrudBlazor.Data
{
    public class RespuestaFront<T>
    {
        public int Congragulation { get; set; }
        public string CongragulationMessage { get; set; }
        public T CongragulationData { get; set; }

    }
}
