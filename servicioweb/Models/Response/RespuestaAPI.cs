using System.Collections.Generic;

namespace servicioweb.Models.Response
{
    public class RespuestaAPI<T>
    {
        public int Congragulation { get; set; }
        public string CongragulationMessage { get; set; }
        public T CongragulationData { get; set;}

        public RespuestaAPI()
        {
            this.Congragulation = 0;
        }
    }
}
