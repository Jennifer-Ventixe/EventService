﻿using Business.Models;

namespace Business.Interfaces
{
    public interface IEventService
    {
        Task<EventResult> CreateEventAsync(CreateEventRequest request);
        Task<EventResult<Event?>> GetEventAsync(string eventId);
        Task<EventResult<IEnumerable<Event>>> GetEventsAsync();
    }
}