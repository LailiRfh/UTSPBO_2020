using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MscStdReservation
{
    class cPayment
    {
        private string roomType;
        private int rentTime;

        public string theRoomType
        {
            get
            {
                return this.roomType;
            }
            set
            {
                this.roomType = value;
            }
        }

        public int theRentTime
        {
            get
            {
                return this.rentTime;
            }
            set
            {
                this.rentTime = value;
            }
        }
    }
}
