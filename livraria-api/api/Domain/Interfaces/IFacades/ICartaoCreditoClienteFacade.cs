﻿using livraria_api.api.Domain.Models;

namespace livraria_api.api.Domain.Interfaces.IFacades
{
    public interface ICartaoCreditoClienteFacade : IFacadeBase<CartaoCreditoCliente>
    {
        Task<bool> ExistsAsync(int id);
    }
}
