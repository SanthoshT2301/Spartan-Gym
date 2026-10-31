using System;
using System.Collections.Generic;
using System.Text;
using SpartanGym_Core.DTO;

namespace SpartanGym_Business.Interface.Event
{

// AddEvent
//UpdateEventDetails
//GetAllEvents
//GetEventById

    public interface IEventService
    {
        public Task<bool> AddEvent(EventDto AddEvent);
        public Task<bool> UpdateEventDetails(EventDto UpdateEvent);
        public Task<List<EventDto>> GetAllEvents();
        public Task<EventDto> GetEventById(int Id);
    }
}
