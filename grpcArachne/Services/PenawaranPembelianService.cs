﻿using Grpc.Core;
using grpcArachne.Data;
using grpcArachne.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grpcArachne.Services
{
    public class PenawaranPembelianService : PenawaranPembelian.PenawaranPembelianBase
    {
        private readonly ILogger<PenawaranPembelianService> _logger;
        private readonly ServerDbContext _db;
        public PenawaranPembelianService(ILogger<PenawaranPembelianService> logger, ServerDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public override Task<pesan> InsertPenawaranPembelian(T6Request request, ServerCallContext context)
        {
            pesan pesan;
            try
            {
                var queryT6 = from T6PenawaranPembelian in _db.T6PenawaranPembelianDbSet
                              where T6PenawaranPembelian.IdPenawaranPembelian == request.IdPenawaranPembelian
                              select T6PenawaranPembelian.IdPenawaranPembelian;


                if (!queryT6.Any())
                {
                    DbT6PenawaranPembelian t6PenawaranPembelian = new DbT6PenawaranPembelian
                    {
                       IdPenawaranPembelian = request.IdPenawaranPembelian,
                       IdJenisSupplier = request.IdJenisSupplier
                    };

                    _db.T6PenawaranPembelianDbSet.AddRange(t6PenawaranPembelian);
                    _db.SaveChanges();
                  
                }
                pesan = new pesan() { Pesan = "Berhasil" };
            }
            catch (Exception ex)
            {

                Metadata metadata = new Metadata { { "Error", "Error : " + ex.Message } };
                throw new RpcException(new Status(StatusCode.Unknown, "Unknown"), metadata);

                pesan = new pesan() { Pesan = "Data Gagal terkirim ke server" };
            }
            return Task.FromResult(pesan);
        }
    }
}