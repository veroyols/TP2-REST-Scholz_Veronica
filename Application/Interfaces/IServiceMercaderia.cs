﻿using Application.Schemas;

namespace Application.Interfaces
{
    public interface IServiceMercaderia
    {
        //1
        public Task<bool> Exists(string name);
        public Task<MercaderiaResponse> Create(MercaderiaRequest body);
        //4
        public Task<List<MercaderiaGetResponse>?> GetFilteredByNameAndTipe(int? tipo, string nombre, string? orden);
        public Task<List<MercaderiaGetResponse>?> GetFilteredByTipe(int? tipo, string? orden);
        public Task<List<MercaderiaGetResponse>?> GetFilteredByName(string nombre, string? orden);
        public Task<List<MercaderiaGetResponse>?> GetAll(string? orden);
        //5
        public Task<bool> Exists(int id);
        public Task<bool> TipeExists(int? id);

        public Task<MercaderiaResponse> Update(int id, MercaderiaRequest body);
        //6
        public Task Delete(int id);
        public Task<bool> ComandaMercaderiaExist(int mercaderiaId);
        //7
        public Task<MercaderiaResponse?> GetMercaderiaById(int id);
        public Task<bool> Exist(List<int> mercaderias);
    }
}
