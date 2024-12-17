using AutoMapper;
using ichan.Domain.Base;
using ichan.Domain.Entities;
using ichan.Repository.Context;
using ichan.Repository.Repository;
using ichan.Service.Services;
using ichan.Service.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ichan.Test
{
    [TestClass]
    public class UnitTestService ()
    {

        private ServiceCollection? services;

        public ServiceProvider ConfigureServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(options =>
            {
                var server = "localhost";
                var port = "3306";
                var database = "ichanTestService";
                var username = "root";
                var password = "admin";
                var strCon = $"Server={server};Port={port};Database={database};" +
                            $"Uid={username};Pwd={password}";
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            #region Repositórios
            services.AddScoped<IBaseRepository<CategoriaDaComunidade>, BaseRepository<CategoriaDaComunidade>>();
            services.AddScoped<IBaseRepository<Amizade>, BaseRepository<Amizade>>();
            services.AddScoped<IBaseRepository<CategoriaDaComunidade>, BaseRepository<CategoriaDaComunidade>>();
            services.AddScoped<IBaseRepository<Categoria>, BaseRepository<Categoria>>();
            services.AddScoped<IBaseRepository<Comentario>, BaseRepository<Comentario>>();
            services.AddScoped<IBaseRepository<Post>, BaseRepository<Post>>();
            services.AddScoped<IBaseRepository<Segue>, BaseRepository<Segue>>();
            #endregion

            #region Serviços
            services.AddScoped<IBaseService<CategoriaDaComunidade>, BaseService<CategoriaDaComunidade>>();
            services.AddScoped<IBaseService<Amizade>, BaseService<Amizade>>();
            services.AddScoped<IBaseService<CategoriaDaComunidade>, BaseService<CategoriaDaComunidade>>();
            services.AddScoped<IBaseService<Categoria>, BaseService<Categoria>>();
            services.AddScoped<IBaseService<Comentario>, BaseService<Comentario>>();
            services.AddScoped<IBaseService<Post>, BaseService<Post>>();
            services.AddScoped<IBaseService<Segue>, BaseService<Segue>>();
            #endregion

            #region mapping

            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<CategoriaDaComunidade, CategoriaDaComunidade>();
            }).CreateMapper());
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Amizade, Amizade>();
            }).CreateMapper());
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<CategoriaDaComunidade, CategoriaDaComunidade>();
            }).CreateMapper());
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Categoria, Categoria>();
            }).CreateMapper());
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Comentario, Comentario>();
            }).CreateMapper());
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Post, Post>();
            }).CreateMapper());
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Segue, Segue>();
            }).CreateMapper());

            #endregion


            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestInsertUsuario()
        {
            var sp = ConfigureServices();
            var usuarioService = sp.GetService<IBaseService<CategoriaDaComunidade>>();
            var usuario = new Usuario
            {
                Nome = "Kaue",
                Email = "kaueleivas0@gmail.com",
                Senha = "123Rt@#jdjfhfh!",
                Bios = "fundador do ichan"
            };

            var result = usuarioService.Add<CategoriaDaComunidade, CategoriaDaComunidade, UsuarioValidator>((CategoriaDaComunidade)usuario);
            Console.Write(JsonSerializer.Serialize(result));
        }
    }
}
