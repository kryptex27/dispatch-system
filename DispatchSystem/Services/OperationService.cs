using DispatchSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchSystem.Services
{
    internal class OperationService
    {
        public void MarkAsDelivered(Load load)
        {
            load.Status = "Delivered";
        }


        public void MarkAsPickingUp(Load load)
        {
            load.Status = "Picking Up";
        }

        public void MarkAsPickedUp(Load load)
        {
            load.Status = "Picked Up";
        }

        public void MarkAsCancelled(Load load)
        {
            load.Status = "Cancelled";
        }

        public void MarkAsInTransit(Load load)
        {
            load.Status = "In Transit";
        }
    }
}









