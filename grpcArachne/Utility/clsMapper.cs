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
                ce.CreateMap<DbT6PenawaranPembelian, InsertDataRequset>().ReverseMap();
                ce.CreateMap<DbT7PenawaranPembelian, InsertDataRequset>().ReverseMap();
            });
            Mapper = new Mapper(conf);
        }
    }
}
