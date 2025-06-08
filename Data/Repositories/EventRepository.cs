using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Data.Contexts;
using Data.Entities;
using Data.Models;

namespace Data.Repositories;

public class EventRepository(DataContext context) : BaseRepository<EventEntity>(context), IEventRepository
{
}
