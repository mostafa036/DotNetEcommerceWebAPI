﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entites;

namespace Talabat.Core.IRepositories
{
    public interface IBasketRepository
    {
        Task<CustomerBasket> GetBasketAsync(string bsaketId);
        Task<CustomerBasket> UpdateBasketAsync( CustomerBasket basket);
        Task<bool> DeleteBasketAsync(string bsaketId);


    }
}