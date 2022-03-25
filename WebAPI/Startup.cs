using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddControllers();
            var key = "D2E2fc3TH2HN5K6PbNluKFDJ6RJjSYS9mYsCMSKvnDGcSfnLXSioZB6IdfymCuG5";
            services.AddAuthentication(x =>
           {
               x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
               x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
           }).AddJwtBearer(x =>
          {
              x.RequireHttpsMetadata = false;
              x.SaveToken = true;
              x.TokenValidationParameters = new TokenValidationParameters
              {
                  ValidateIssuerSigningKey = true,
                  IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
                  ValidateIssuer = false,
                  ValidateAudience = false
              };
          });

            services.AddSingleton<IJWTAuthenticationManager>(new JWTAuthenticationManager(key));

            services.AddSingleton<IKullaniciService, KullaniciManager>();
            services.AddSingleton<IKullaniciDal, EfKullaniciDal>();

            services.AddSingleton<IDuyurularService, DuyurularManager>();
            services.AddSingleton<IDuyurularDal, EfDuyurularDal>();

            services.AddSingleton<IE_BultenlerService, E_BultenlerManager>();
            services.AddSingleton<IE_BultenlerDal, EfE_BultenlerDal>();

            services.AddSingleton<IEtkinliklerService, EtkinliklerManager>();
            services.AddSingleton<IEtkinliklerDal, EfEtkinliklerDal>();

            services.AddSingleton<IFooter_Menu_BaslikService, Footer_Menu_BaslikManager>();
            services.AddSingleton<IFooter_Menu_BaslikDal, EfFooter_Menu_BaslikDal>();

            services.AddSingleton<IFooter_Menu_OgeService, Footer_Menu_OgeManager>();
            services.AddSingleton<IFooter_Menu_OgeDal, EfFooter_Menu_OgeDal>();

            services.AddSingleton<IHaberlerService, HaberlerManager>();
            services.AddSingleton<IHaberlerDal, EfHaberlerDal>();

            services.AddSingleton<IHeader_MenuService, Header_MenuManager>();
            services.AddSingleton<IHeader_MenuDal, EfHeader_MenuDal>();

            services.AddSingleton<IHeader_Menu_OgeService, Header_Menu_OgeManager>();
            services.AddSingleton<IHeader_Menu_OgeDal, EfHeader_Menu_OgeDal>();

            services.AddSingleton<IHizmetlerService, HizmetlerManager>();
            services.AddSingleton<IHizmetlerDal, EfHizmetlerDal>();

            services.AddSingleton<IIcerik_DosyalarService, Icerik_DosyalarManager>();
            services.AddSingleton<IIcerik_DosyalarDal, EfIcerik_DosyalarDal>();

            services.AddSingleton<IIcerik_ResimlerService, Icerik_ResimlerManager>();
            services.AddSingleton<IIcerik_ResimlerDal, EfIcerik_ResimlerDal>();

            services.AddSingleton<IIceriklerService, IceriklerManager>();
            services.AddSingleton<IIceriklerDal, EfIceriklerDal>();

            services.AddSingleton<IModalService, ModalManager>();
            services.AddSingleton<IModalDal, EfModalDal>();

            services.AddSingleton<IOrtaMenuService, OrtaMenuManager>();
            services.AddSingleton<IOrtaMenuDal, EfOrtaMenuDal>();

            services.AddSingleton<IReferanslarService, ReferanslarManager>();
            services.AddSingleton<IReferanslarDal, EfReferanslarDal>();

            services.AddSingleton<ISayfalarService, SayfalarManager>();
            services.AddSingleton<ISayfalarDal, EfSayfalarDal>();

            services.AddSingleton<ISimgelerService, SimgelerManager>();
            services.AddSingleton<ISimgelerDal, EfSimgelerDal>();

            services.AddSingleton<ITopMenuService, TopMenuManager>();
            services.AddSingleton<ITopMenuDal, EfTopMenuDal>();

            services.AddSingleton<IKategoriService, KategoriManager>();
            services.AddSingleton<IKategoriDal, EfKategoriDal>();

            services.AddSingleton<IFotogaleriService, FotogaleriManager>();
            services.AddSingleton<IFotogaleriDal, EfFotogaleriDal>();

            services.AddSingleton<IStratejikPlanService, StratejikPlanManager>();
            services.AddSingleton<IStratejikPlanDal, EfStratejikPlanDal>();

            services.AddSingleton<IVideogaleriService, VideogaleriManager>();
            services.AddSingleton<IVideogaleriDal, EfVideogaleriDal>();

            services.AddSingleton<IBillboardService, BillboardManager>();
            services.AddSingleton<IBillboardDal, EfBillboardDal>();

            services.AddSingleton<IFormiletisimService, FormiletisimManager>();
            services.AddSingleton<IFormiletisimDal, EfFormiletisimDal>();

            services.AddSingleton<IMenuService, MenuManager>();
            services.AddSingleton<IMenuDal, EfMenuDal>();


            services.AddCors(opt => opt.AddDefaultPolicy(
                builder => builder.AllowAnyOrigin()
                ));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();


            app.Use(async (context, next) =>
            {
                await next();

                if (context.Response.StatusCode == 404 && !Path.HasExtension(context.Request.Path.Value))
                {
                    context.Request.Path = "/index.html";
                    await next();
                }
            });

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"StaticFiles")),
                RequestPath = new PathString("/StaticFiles")
            });
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"kullanici")),
                RequestPath = new PathString("")
            });

            app.UseRouting();

            //app.UseCors(options => {
            //    options.AllowAnyHeader();
            //});

            app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
