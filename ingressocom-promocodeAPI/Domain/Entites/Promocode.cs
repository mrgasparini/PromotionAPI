﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ingressocom_promocodeAPI.Domain.Entites
{
    [BsonIgnoreExtraElements]
    public class Promocode
    {
        public string Code { get; set; }
        public string PromotionId { get; set; }
    }
}
