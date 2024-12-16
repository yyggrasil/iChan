using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ichan.Service.Services;
using ichan.Repository.Context;
using AutoMapper;
using ichan.Domain.Base;
using ichan.Domain.Entities;
using ichan.Repository.Repository;
using ichan.App.Cadastros;
using ichan.App.Models;

namespace ichan.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;
        public static IServiceProvider? ServicesProvider;

        public static void ConfigureServices()
        {
            Services = new ServiceCollection();
            
            #region Banco de dados
            // Configura Banco na Injeção de dependencia
            var strCon = File.ReadAllText("Config/ConfigBanco.txt");
            Services.AddDbContext<MySqlContext>(options =>
            {
                options.LogTo(Console.WriteLine)
                .EnableSensitiveDataLogging();
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure();
                });
            });
            #endregion

            #region Repositórios
            Services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            Services.AddScoped<IBaseRepository<CategoriaDaComunidade>, BaseRepository<CategoriaDaComunidade>>();
            Services.AddScoped<IBaseRepository<Categoria>, BaseRepository<Categoria>>();
            Services.AddScoped<IBaseRepository<Comunidade>, BaseRepository<Comunidade>>();
            Services.AddScoped<IBaseRepository<Comentario>, BaseRepository<Comentario>>();
            Services.AddScoped<IBaseRepository<Post>, BaseRepository<Post>>();
            Services.AddScoped<IBaseRepository<Segue>, BaseRepository<Segue>>();
            #endregion

            #region Serviços
            Services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            Services.AddScoped<IBaseService<CategoriaDaComunidade>, BaseService<CategoriaDaComunidade>>();
            Services.AddScoped<IBaseService<Comunidade>, BaseService<Comunidade>>();
            Services.AddScoped<IBaseService<Categoria>, BaseService<Categoria>>();
            Services.AddScoped<IBaseService<Comentario>, BaseService<Comentario>>();
            Services.AddScoped<IBaseService<Post>, BaseService<Post>>();
            Services.AddScoped<IBaseService<Segue>, BaseService<Segue>>();
            #endregion

            #region Formulários
            Services.AddTransient<CadastroCategoria, CadastroCategoria>();
            Services.AddTransient<CadastroCategoriaDaComunidade, CadastroCategoriaDaComunidade>();
            Services.AddTransient<CadastroComentario, CadastroComentario>();
            Services.AddTransient<CadastroComunidade, CadastroComunidade>();
            Services.AddTransient<CadastroPost, CadastroPost>();
            Services.AddTransient<CadastroSegue, CadastroSegue>();
            Services.AddTransient<CadastroUsuario, CadastroUsuario>();
            #endregion

            #region mapping

            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Usuario, UsuarioModel>();
                config.CreateMap<Categoria, CategoriaModel>();
                config.CreateMap<Comunidade, ComunidadeModel>();
                config.CreateMap<Post, PostModel>()
                    .ForMember(d=>d.IdUsuario, d=> d.MapFrom(x => x.Usuario!.Id))
                    .ForMember(d=>d.Usuario, d => d.MapFrom(x => x.Usuario!.Nome));
                config.CreateMap<CategoriaDaComunidade, CategoriaDaComunidadeModel>()
                    .ForMember(d => d.IdCategoria, d => d.MapFrom(x => x.Categoria!.Id))
                    .ForMember(d => d.Categoria, d => d.MapFrom(x => x.Categoria!.Nome))
                    .ForMember(d => d.IdComunidade, d => d.MapFrom(x => x.Comunidade!.Id))
                    .ForMember(d => d.Comunidade, d => d.MapFrom(x => x.Comunidade!.Nome));
                config.CreateMap<Comentario, ComentarioModel>()
                    .ForMember(d => d.IdPost, d => d.MapFrom(x => x.Post!.Id))
                    .ForMember(d => d.Post, d => d.MapFrom(x => x.Post!.Titulo))
                    .ForMember(d => d.IdUsuario, d => d.MapFrom(x => x.Usuario!.Id))
                    .ForMember(d => d.Usuario, d => d.MapFrom(x => x.Usuario!.Nome));
                config.CreateMap<Segue, SegueModel>()
                    .ForMember(d => d.IdUsuario, d => d.MapFrom(x => x.Usuario!.Id))
                    .ForMember(d => d.Usuario, d => d.MapFrom(x => x.Usuario!.Nome))
                    .ForMember(d => d.IdComunidade, d => d.MapFrom(x => x.Comunidade!.Id))
                    .ForMember(d => d.Comunidade, d => d.MapFrom(x => x.Comunidade!.Nome));

            }).CreateMapper());

            #endregion


            ServicesProvider = Services.BuildServiceProvider();

        }

    }
}
