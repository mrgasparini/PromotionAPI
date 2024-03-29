﻿using ingressocom_promocodeAPI.ViewModels;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ingressocom_promocodeAPI.Services.Interface
{
    public interface IPromotionService
    {
        Task<bool> ValidatePromotionConditions(CartViewModel cart, string promotionId);
        Task<decimal> GetPromotionDiscount(CartViewModel cart, string promotionId);
    }
}
