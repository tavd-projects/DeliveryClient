using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DeliveryClient.DTOs;

namespace DeliveryClient
{
    public class DeliveryApi
    {
        private HttpClientWrapper _client;
     
        public DeliveryApi(Uri siteUri) 
        {
            _client = new HttpClientWrapper(siteUri);
        }

        public TicketDto GetTicket(Guid id)
        {
            return _client.GetRequest<TicketDto>($"Ticket?ticketId={id}");
        }

        public GuidDto RegisterTicket(RegisterTicketDto registerTicketDto)
        {
            return _client.PostRequest<RegisterTicketDto, GuidDto>(registerTicketDto, "Ticket/register");
        }

        public void UpdateTicket(UpdateTicketDto updateTicket)
        {
            _client.UpdateRequest(updateTicket, "Ticket");
        }

        public IEnumerable<TicketDto> GetTickets()
        {
            return _client.GetRequest<IEnumerable<TicketDto>>("/Ticket/all");
        }

        public void CancelTicket(CancelTicketDto cancelTicketDto)
        {
            _client.PostRequest(cancelTicketDto, "/Ticket/cancel");
        }

        public IEnumerable<TicketDto> SearchTickets(string query)
        {
            return _client.GetRequest<IEnumerable<TicketDto>>("Ticket/search?Query=" + Uri.EscapeDataString(query));
        }

        public IEnumerable<TicketDto> GetNewTickets()
        {
            return _client.GetRequest<IEnumerable<TicketDto>>("Courier");
        }

        public void TakeTicketInWork(GuidDto guidDto)
        {
            _client.PostRequest(guidDto, "/Courier/take");
        }

        public void DoneTicket(GuidDto guidDto)
        {
            _client.PostRequest(guidDto, "/Courier/accept");
        }
    }
}