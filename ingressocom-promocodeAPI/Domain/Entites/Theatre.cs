﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ingressocom_promocodeAPI.Domain.Entites
{
    public class Theatre
    {
        [BsonId]
        public  string _id { get; set; }
        public string Name { get; set; }
    }
}
