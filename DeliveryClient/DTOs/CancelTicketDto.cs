using System;

namespace DeliveryClient.DTOs
{
    public class CancelTicketDto
    {
        public Guid Id { get; set; }
        public string Reason { get; set; }
    }
}
