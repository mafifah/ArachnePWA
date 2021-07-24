using AutoMapper;
using System;
using grpcArachne.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grpcArachne.Utility
{
    public class clsMapper
    {
        public Mapper Mapper;
        public clsMapper()
        {
            MapperConfiguration conf = new(ce =>
            {
                ce.CreateMap<DbT6PenawaranPembelian, InsertDataT6Requset>().ReverseMap();
                ce.CreateMap<DbT7PenawaranPembelian, InsertDataT6Requset>().ReverseMap();
            });
            Mapper = new Mapper(conf);
        }
    }
}
