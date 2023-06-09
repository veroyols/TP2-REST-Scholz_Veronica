﻿using Application.Interfaces;
using Infrastructure.Persistence;

namespace Infrastructure.cqrs_Query
{
    public class QueryFormaEntrega : IQueryFormaEntrega
    {
        private readonly AppDbContext _appDbContext;

        public QueryFormaEntrega(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        //2
        public async Task<string> GetFormaEntrega(int id)
        {
            var query = await _appDbContext.FormaEntregaDb.FindAsync(id);
            return query.Descripcion;
        }
    }
}
